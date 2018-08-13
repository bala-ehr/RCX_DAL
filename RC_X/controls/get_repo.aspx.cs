using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace RC_X.controls
{
    public partial class get_repo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lbResult.Text = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Authority;
            if (Request.QueryString.Count == 0) { lbResult.Text = "This artifact is not available for download. Please check to see whether it has been deleted"; return; }
            Guid ArtifactID = Guid.Parse(Request.QueryString[0]);
            List<Artifact> Repository = rc_services.GetArtifacts("All");
            Artifact DownloadFile = new Artifact();

            foreach (Artifact file in Repository)
            {
                if (file.ArtifactID == ArtifactID)
                {
                    DownloadFile.ArtifactID = ArtifactID;
                    DownloadFile.filename = file.filename;
                    DownloadFile.filestoragename = file.filestoragename;
                }
            }
             try
            {
                string accountName = "UploadAzureAccount";
                string containerName = Session["enterpriseID"].ToString().ToUpper();
                string fileURL = GetFileUrl(DownloadFile.filestoragename, accountName, containerName);


                byte[] fileData = null;
                using (var wc = new System.Net.WebClient())
                    fileData = wc.DownloadData(fileURL);
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=\"" + DownloadFile.filename + "\"");
                Response.AddHeader("Content-Length", fileData.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.BinaryWrite(fileData);
            }
            catch
            {
                lbResult.Text = "This artifact is not available for download. Please check to see whether it has been deleted"; return;
            }
            finally
            {

            }
           
        }

        string GetFileUrl(string fileName, string accountName, string containerName)
        {
            DevExpress.Web.AzureFileSystemProvider provider = new DevExpress.Web.AzureFileSystemProvider("");
            provider.AccountName = accountName;
            provider.ContainerName = containerName.ToLower();
            provider.BlobEndpoint = ConfigurationManager.AppSettings["BlobEndpoint"].ToString();

            FileManagerFile file = new FileManagerFile(provider, fileName);

            
            FileManagerFile[] files = new FileManagerFile[] { file };
            return provider.GetDownloadUrl(files);
        }
    }
}