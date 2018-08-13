using DevExpress.Pdf;
using DevExpress.Web;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RC_X.controls
{

    public partial class attacher : System.Web.UI.UserControl
    {
        RootMaster MasterPage;
        ASPxHiddenField rootParameters;

        string xFileName;
        string xStorageName;
        string xType;
        string xTitle;
        string xDesc;
        string xFullText;
        //ASPxComboBox TypeChooser;

        public String ItemKey
        {
            get { if (rootParameters.Contains("xkey")) { return rootParameters["xkey"] as string; } else { return null; } }
            set { rootParameters.Set("xkey", value); }
        }
        public String MilestoneID
        {
            get { if (rootParameters.Contains("MilestoneID")) { return rootParameters["MilestoneID"] as string; } else { return null; } }
            set { rootParameters.Set("MilestoneID", value); }
        }
        public String ArtifactHome
        {
            get { if (rootParameters.Contains("ArtifactHome")) { return rootParameters["ArtifactHome"] as string; } else { return null; } }
            set { rootParameters.Set("ArtifactHome", value); }
        }
        //public Boolean IsSelecting // must use control with default value of false
        //{
        //    get { if (rootParameters.Contains("attacherIsSelecting")) { return (bool)rootParameters["attacherIsSelecting"]; } else { return false; }; }
        //    set { rootParameters.Set("attacherIsSelecting", value); }
        //}


        protected void Page_Init(object sender, EventArgs e)
        {
            MasterPage = (RootMaster)Page.Master.Master;
            rootParameters = MasterPage.masterParameters;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //Boolean.TryParse(Session["widgetAttachOpen"], widgetAttachOpen);
            if (ItemKey == null)
            {
                return;
            }
            else if (Session["widgetAttachOpen"] != null)
            {
                //Temporarily just Project level, need feedback in hub
               // ArtifactHome = "P";
                BindGrid();
            }
            //sets the folder in which this solution's files are stored in Azure
            fileUP.AzureSettings.ContainerName= Session["EnterpriseID"].ToString() ;
        }

        public void BindGrid()
        {
            //when the control loads, it needs to be given information as to what Item it is loading attachments for (xKey)
            // and what current project it is working on - only Global and Solution artifacts can be seen here 
            //(cannot show artifacts from other solutions)
            gridAttached.DataSource = rc_services.GetAttachments(Guid.Parse(ItemKey));
            gridAttached.DataBind();

            ////DO not bind when attaching because it will result in empty page reference boxes
            //if (callAttach.IsCallback == false)
            //{
                gridRepository.DataSource = rc_services.GetRepository("P", false);
            gridRepository.DataBind();
            //}

            //TODO   Uploading Disabled
            //dropType.DataSource = common_services.GetCustomDropDown("artifact");
            //dropType.DataBind();
        }


        protected void fileUP_FileUploadComplete(object sender, DevExpress.Web.FileUploadCompleteEventArgs e)
        {
           

           //send back filename and filename in azurestorage to be handled client side, where a callback for storing the data
           // will  be called - this is because the fileuploader has its own callback for uploading the file, handled in this event

           // e.CallbackData = e.UploadedFile.FileName + "|" + e.UploadedFile.FileNameInStorage;

            //routine from pro_repository.aspx to extract text - both should be moved to rc_services
            string FileExtn = "", plainText = "";

            ASPxUploadControl ArtifactUploader = (ASPxUploadControl)sender;
            string accountName = ArtifactUploader.AzureSettings.AccountName;
            //string containerName =ArtifactUploader.AzureSettings.ContainerName; --does not work, even though blob is uploded to proper container
            string containerName = Session["enterpriseID"].ToString().ToLower();
            string url = GetFileUrl(e.UploadedFile.FileNameInStorage, accountName, containerName, ref FileExtn);
            if (FileExtn == ".txt" || FileExtn == ".doc" || FileExtn == ".docx")
            {
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile(url, Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                }
           
                RichEditDocumentServer richEditDocument = new RichEditDocumentServer();
                richEditDocument.LoadDocument(Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                plainText = richEditDocument.Text;
            }
            else if (FileExtn == ".pdf")
            {
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile(url, Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                }

                using (PdfDocumentProcessor documentProcessor = new PdfDocumentProcessor())
                {
                    documentProcessor.LoadDocument(Path.GetTempPath() + "\\" + e.UploadedFile.FileName);
                    plainText = documentProcessor.Text;
                }
            }
            e.CallbackData = e.UploadedFile.FileName + "|" + e.UploadedFile.FileNameInStorage + "|" + plainText;
            paramUpload.Clear();
        }

        string GetFileUrl(string fileName, string accountName, string containerName, ref string FileExtn)
        {
          
            AzureFileSystemProvider provider = new AzureFileSystemProvider("");
            provider.AccountName = accountName;
            provider.ContainerName = containerName.ToLower();

            FileManagerFile file = new FileManagerFile(provider, fileName);

            FileExtn = file.Extension;
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);

        }
   

        // Callback of the CallbackPanel which contains the entire control, to handle attaching and uploading
        protected void callAttach_Callback(object sender, DevExpress.Web.CallbackEventArgsBase e)
        {

            //Select whether this is an attachment of a existing artifact, or an upload AND attachment of new artifact
            switch (e.Parameter) {
                //case "bindrepository":
                //    gridRepository.DataSource = rc_services.GetRepository("P", false);
                //    gridRepository.DataBind();
                //    break;
                case "attach":

                    //Use class AttachmentList to create a list of artifacts to be attached
                    AttachmentList xMultiAttachment = new AttachmentList();

                    //go through grid and create an unit for each selected item
                    for (int i= 0; i<=gridRepository.VisibleRowCount; i=i+1 )
                    {
                        if (gridRepository.Selection.IsRowSelected(i) == true)
                        {
                            //get page ref from text box inside cell template
                            string PageRef="";
                            string xRowIndex = Convert.ToString(i);
                            if (paramUpload.Contains("txPage" + xRowIndex))
                            {
                                PageRef = paramUpload["txPage" + xRowIndex].ToString();
                            }
                            //ASPxTextBox txPage = (ASPxTextBox)gridRepository.FindRowCellTemplateControl(i, gridRepository.DataColumns[8], "txPage");

                          string rowlibid = gridRepository.GetRowValues(i, "ArtifactID").ToString();
                          xMultiAttachment.Add(new Attachment() { ProjectID = Session["projectID"].ToString(), ArtifactID = rowlibid, ItemID = ItemKey.ToString() ,PageReference=PageRef   });
                        }
                    }

                    //If any selected, call the function in rc_services to attach multiple artifacts
                    if (xMultiAttachment.Count > 0)
                    {
                        string xMultiAttachResult = rc_services.AttachArtifact(xMultiAttachment);
                        BindGrid();
                        gridRepository.Selection.UnselectAll();
                    }
                    
                    break;  
                    
                    //If they are uploading new artifact, first create it, and then attach it, using functions in rc_services
                case "newartifact":

                    //Get variables loaded clientside on ASPxHiddenField Control
                    xFileName = (string)paramUpload.Get("xFileName");
                    xStorageName = (string)paramUpload.Get("xStorageName");
                    xType = (string)paramUpload.Get("xType");
                    xTitle = (string)paramUpload.Get("xTitle");
                    xDesc = (string)paramUpload.Get("xDesc");
                    xFullText = (string)paramUpload.Get("xFullText");

                    //Use NewArtifact from rc_services class to create an object
                    
                    string xNewID = rc_services.NewArtifact(Session["projectID"].ToString(), xTitle, xType, ArtifactHome, xFileName, xStorageName, xDesc, xFullText, (string)Session["UserID"]);
                    AttachmentList xAttachment = new AttachmentList();
                    xAttachment.Add(new Attachment() { ProjectID = Session["projectID"].ToString(), ArtifactID = xNewID, ItemID = ItemKey });

                    //Call function that attaches artifact after it has been created in above code
                    string xAttachResult = rc_services.AttachArtifact(xAttachment);

                    paramUpload.Clear();

                    paramUpload.Add("xNewArtifact", xAttachResult);
                    BindGrid();

                    break;

            }
        }

        protected void gridAttached_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {
            rc_services.DeleteAttachment(Guid.Parse(e.Keys[0].ToString()));
            e.Cancel = true;
            BindGrid();
        }

        protected void dropType_Init(object sender, EventArgs e)
        {

        }
    }
    
}