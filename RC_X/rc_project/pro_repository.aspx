<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pro_repository.aspx.cs" Inherits="RC_X.project.pro_repository" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">        
        function OnUploadComplete(args) {
            //debugger;
            //alert("abc");
            var fileData = args.callbackData.split('|');
            hiddenFileName.Set("filename", fileData[0]);
            hiddenFileName.Set("filestoragename", fileData[1]);
            hiddenFileName.Set("filetext", fileData[2]);
            ArtifactsGrid.UpdateEdit();

        }

        function OnSubmit() {
            if (uploader.GetText() == "") {
                if (ArtifactsGrid.IsNewRowEditing()) {
                    alert("Please select a file");
                }
                else {
                    var isValid = ASPxClientEdit.ValidateEditorsInContainer(ArtifactsGrid.GetMainElement());
                    if (isValid)
                        ArtifactsGrid.UpdateEdit();
                }
            }
            else {
                var isValid = ASPxClientEdit.ValidateEditorsInContainer(ArtifactsGrid.GetMainElement());
                if (isValid)
                    uploader.Upload();
            }

        }

        function checkDuplicates(s, e) {
            var text = s.GetText(e.inputIndex);

            if (text) {
                LoadingPanel.Show();
                var fileName = text.substring(text.lastIndexOf('\\') + 1);
                var data = { fileName: fileName };

                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState == 4 && this.status == 200) {
                        checkDuplicatesCallback(this.responseText, e);
                    }
                };
                xhttp.open("POST", "pro_repository.aspx/GetDuplicateFileUploadNames", true);
                xhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
                xhttp.send(JSON.stringify(data));
            }

        }

        function checkDuplicatesCallback(result, e) {
            LoadingPanel.Hide();
            var res = JSON.parse(result);
            if (res.d > 0) {
                alert("Filename already exists. Please choose another file or rename current file.");
                uploader.RemoveFileFromSelection(0);
            }

        }

        function OnCancel() {
            ArtifactsGrid.CancelEdit();
        }
    </script>
    <dx:ASPxHiddenField ID="hiddenFileName" runat="server" ClientInstanceName="hiddenFileName">
    </dx:ASPxHiddenField>
    <dx:ASPxGridView ID="ArtifactsGrid" runat="server" ClientInstanceName="ArtifactsGrid" AutoGenerateColumns="False" KeyFieldName="ArtifactID" OnRowInserting="ArtifactsGrid_RowInserting" OnRowUpdating="ArifactsGrid_RowUpdating" OnRowDeleting="ArtifactsGrid_RowDeleting" Width="100%"
        OnDetailRowExpandedChanged="ArtifactsGrid_DetailRowExpandedChanged" OnHtmlEditFormCreated="ArtifactsGrid_HtmlEditFormCreated" OnCellEditorInitialize="ArtifactsGrid_CellEditorInitialize">
        <Toolbars>
            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                <Items>
                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
                    <dx:GridViewToolbarItem Text="Export to" Image-IconID="actions_download_16x16office2013" BeginGroup="true">
                        <Items>
                            <dx:GridViewToolbarItem Command="ExportToPdf" />
                            <dx:GridViewToolbarItem Command="ExportToDocx" />
                            <dx:GridViewToolbarItem Command="ExportToRtf" />
                            <dx:GridViewToolbarItem Command="ExportToCsv" />
                            <dx:GridViewToolbarItem Command="ExportToXls" />
                        </Items>
                        <Image IconID="actions_download_16x16office2013"></Image>
                    </dx:GridViewToolbarItem>
                    <%--<dx:GridViewToolbarItem BeginGroup="true">
                        <ItemStyle Width="250px" />
                        <Template>
                            <dx:ASPxButtonEdit ID="tbToolbarSearch" runat="server" NullText="Search..." Height="100%" Width="250px">
                                <Buttons>
                                    <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                </Buttons>
                            </dx:ASPxButtonEdit>
                        </Template>
                    </dx:GridViewToolbarItem>--%>
                </Items>
            </dx:GridViewToolbar>
        </Toolbars>
        <SettingsBehavior AllowFocusedRow="true" />
        <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
        <ClientSideEvents EndCallback="function(s, e) {hiddenFileName.Clear();}" />
        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
        </SettingsContextMenu>
        <SettingsResizing ColumnResizeMode="Control" />
        <SettingsFilterControl AllowHierarchicalColumns="true" ></SettingsFilterControl>
        <Templates>
            <DetailRow>
                <dx:ASPxPageControl ID="pageControlDetails" runat="server" ActiveTabIndex="0" OnLoad="pageControlDetails_Load" Width="100%">
                    <TabPages>
                        <dx:TabPage Text="Preview">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <div runat="server" id="documentDownloadLink">
                                    </div>
                                    <dx:ASPxButton ID="btnDownloadFile" runat="server" RenderMode="Link" AutoPostBack="false" ImagePosition="Right" Text="Download File" OnClick="btnDownloadFile_Click" ToolTip="Download File">
                                        <Image IconID="actions_download_16x16">
                                        </Image>
                                    </dx:ASPxButton>
                                    <dx:ASPxRichEdit ID="richDetailsPreview" runat="server" RibbonMode="None" WorkDirectory="~\App_Data\WorkDirectory" Visible="False" ReadOnly="True" Width="100%">
                                        <Settings>
                                            <RangePermissions Visibility="Auto" />
                                        </Settings>
                                    </dx:ASPxRichEdit>
                                    <dx:ASPxSpreadsheet ID="spreadSheetPreview" runat="server" WorkDirectory="~/App_Data/WorkDirectory" Visible="false" RibbonMode="None" ReadOnly="True" Width="100%">
                                    </dx:ASPxSpreadsheet>
                                    <br />
                                    <br />
                                    <div runat="server" id="pdfPreview" visible="false" style="width: 100%;">
                                        PDF Preview
                                    </div>
                                    <div runat="server" id="previewNotAvailableText" visible="false">
                                        Preview for the File Not Available
                                    </div>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Details">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <dx:ASPxHtmlEditor ID="ASPxHtmlEditor2" runat="server" ActiveView="Preview" Html='<%# Bind("Description") %>'>
                                        <Settings AllowDesignView="False" AllowHtmlView="False">
                                        </Settings>
                                    </dx:ASPxHtmlEditor>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Attachments">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <dx:ASPxGridView ID="gridAttachements" runat="server" KeyFieldName="Id" AutoGenerateColumns="False" OnBeforePerformDataSelect="ArtifactAttachment_BeforePerformDataSelect" Width="100%">
                                        <Columns>
                                            <dx:GridViewDataTextColumn Caption="ID" FieldName="Id" ShowInCustomizationForm="True" VisibleIndex="0" Visible="False">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Title" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Name" FieldName="Name" ShowInCustomizationForm="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Type" FieldName="Type" ShowInCustomizationForm="True" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>

                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />

                                                    <dx:GridViewToolbarItem BeginGroup="true">
                                                        <ItemStyle Width="250px" />
                                                        <Template>
                                                            <dx:ASPxButtonEdit ID="tbToolbarSearch" runat="server" NullText="Search..." Height="100%" Width="250px">
                                                                <Buttons>
                                                                    <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                                                </Buttons>
                                                            </dx:ASPxButtonEdit>
                                                        </Template>
                                                    </dx:GridViewToolbarItem>
                                                </Items>
                                            </dx:GridViewToolbar>
                                        </Toolbars>
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <SettingsPager Mode="ShowAllRecords">
                                        </SettingsPager>
                                        <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                                        <SettingsBehavior AllowFocusedRow="true" />
                                        <SettingsSearchPanel CustomEditorID="tbToolbarSearch"  />
                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsBehavior AutoExpandAllGroups="True" />
                                        <SettingsDataSecurity AllowEdit="False" />
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Artifact History">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <dx:ASPxGridView ID="gridArtifactHistory" runat="server" AutoGenerateColumns="False" KeyFieldName="his_id" OnBeforePerformDataSelect="ArtifactHistory_BeforePerformDataSelect" Width="100%">
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>

                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />

                                                    <dx:GridViewToolbarItem BeginGroup="true">
                                                        <ItemStyle Width="250px" />
                                                        <Template>
                                                            <dx:ASPxButtonEdit ID="tbToolbarSearch" runat="server" NullText="Search..." Height="100%" Width="250px">
                                                                <Buttons>
                                                                    <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                                                </Buttons>
                                                            </dx:ASPxButtonEdit>
                                                        </Template>
                                                    </dx:GridViewToolbarItem>
                                                </Items>
                                            </dx:GridViewToolbar>
                                        </Toolbars>
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <SettingsPager Mode="ShowAllRecords">
                                        </SettingsPager>
                                        <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                                        <SettingsBehavior AllowFocusedRow="true" />
                                        <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsBehavior AutoExpandAllGroups="True" />
                                        <SettingsDataSecurity AllowEdit="False" />
                                        <Columns>
                                            <dx:GridViewCommandColumn ShowClearFilterButton="True" ShowInCustomizationForm="True" VisibleIndex="0">
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn Caption="Title" FieldName="his_title" ShowInCustomizationForm="True" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Type" FieldName="his_type" ShowInCustomizationForm="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Home" FieldName="his_home" ShowInCustomizationForm="True" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="FileName" FieldName="his_filename" ShowInCustomizationForm="True" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataDateColumn Caption="Changed Date" FieldName="his_changeddate" ShowInCustomizationForm="True" VisibleIndex="5">
                                            </dx:GridViewDataDateColumn>
                                            <dx:GridViewDataTextColumn Caption="Changed By" FieldName="his_changeby" ShowInCustomizationForm="True" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Change Type" FieldName="his_changetype" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="7">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:ASPxGridView>

                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                    </TabPages>
                </dx:ASPxPageControl>
            </DetailRow>
        </Templates>
        <SettingsPager Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsEditing Mode="EditForm">
        </SettingsEditing>
        <Settings ShowFilterRow="True" ShowFilterBar="Visible" ShowFilterRowMenu="True" ShowStatusBar="Hidden" />
        <SettingsBehavior AllowEllipsisInText="True" ConfirmDelete="True" />
        <SettingsResizing ColumnResizeMode="NextColumn" />
        <SettingsCommandButton RenderMode="Image">
            <NewButton ButtonType="Image" RenderMode="Image">
                <Image AlternateText="New" IconID="actions_add_16x16" ToolTip="New">
                </Image>
            </NewButton>
            <UpdateButton ButtonType="Image" RenderMode="Image">
                <Image AlternateText="Save" IconID="actions_apply_16x16" ToolTip="Save">
                </Image>
            </UpdateButton>
            <CancelButton ButtonType="Image" RenderMode="Image" Text="Cancel">
                <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                </Image>
            </CancelButton>
            <EditButton ButtonType="Image" RenderMode="Image">
                <Image AlternateText="Edit" IconID="actions_editname_16x16" ToolTip="Edit">
                </Image>
            </EditButton>
            <DeleteButton ButtonType="Image" RenderMode="Image">
                <Image AlternateText="Delete" IconID="actions_trash_16x16" ToolTip="Delete">
                </Image>
            </DeleteButton>
            <RecoverButton>
                <Image AlternateText="Recover" IconID="actions_reset2_16x16" ToolTip="Recover">
                </Image>
            </RecoverButton>
        </SettingsCommandButton>
        <SettingsSearchPanel Visible="True" />
        <SettingsExport EnableClientSideExportAPI="True" FileName="Artifacts">
        </SettingsExport>
        <EditFormLayoutProperties ColCount="2">
            <Items>
                <dx:GridViewColumnLayoutItem ColumnName="Title" Caption="Title" ColSpan="2" Width="100%">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Type">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Home">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="Select a file" ColSpan="2" HorizontalAlign="Left" Name="FileUploader" ShowCaption="True" Width="100%">
                    <Template>
                        <dx:ASPxUploadControl ID="ArtifactUploader" runat="server" ShowProgressPanel="True" UploadMode="Auto" Width="100%"
                            OnFileUploadComplete="ArtifactUploader_FileUploadComplete" FileUploadMode="OnPageLoad"
                            UploadStorage="Azure" ClientInstanceName="uploader">
                            <%--<AzureSettings AccountName="UploadAzureAccount" />--%>
                            <AzureSettings AccountName="UploadAzureAccount" BlobEndpoint="https://rcxstorage.blob.core.usgovcloudapi.net/"  />
                            <ClientSideEvents FileUploadComplete="function(s, e) { OnUploadComplete(e); }" TextChanged="checkDuplicates" />
                        </dx:ASPxUploadControl>
                    </Template>
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Visible="False">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="filename"  ColumnName="filename" ClientVisible="False" Visible="False" >
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="fileNameInStorage" ColumnName="filestoragename" ClientVisible="False" Visible="False">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="Description" ColSpan="2" ColumnName="Description" ShowCaption="True">
                    <Template>
                        <dx:ASPxHtmlEditor ID="HTMLDesc" runat="server" Width="100%" Html='<%# Bind("Description") %>'>
                            <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False">
                            </Settings>

                        </dx:ASPxHtmlEditor>
                    </Template>
                    <CaptionSettings Location="Top" />
                </dx:GridViewColumnLayoutItem>
                <dx:EditModeCommandLayoutItem HorizontalAlign="Right" ColSpan="2" Visible="False">
                </dx:EditModeCommandLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="" ColSpan="2" HorizontalAlign="Right">
                    <Template>
                        <dx:ASPxButton ID="EditFormUpdateButton" runat="server" RenderMode="Link" AutoPostBack="false" ToolTip="Save">
                            <ClientSideEvents Click="function(s,e){OnSubmit();}" />
                            <Image IconID="actions_apply_16x16">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="EditFormCancelButton" runat="server" RenderMode="Link" AutoPostBack="false" ToolTip="Cancel">
                            <ClientSideEvents Click="function(s,e){OnCancel();}" />
                            <Image IconID="actions_cancel_16x16">
                            </Image>
                            <Paddings PaddingLeft="15px" />
                        </dx:ASPxButton>
                    </Template>
                </dx:GridViewColumnLayoutItem>
            </Items>
        </EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="75px">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="ArtifactID" VisibleIndex="1" ReadOnly="True" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="filename" VisibleIndex="2" Caption="File Name">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="3" Caption="Title">
                <PropertiesTextEdit Width="100%">
                    <ValidationSettings ErrorDisplayMode="ImageWithText">
                        <RequiredField ErrorText="Please enter Title" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="Type" VisibleIndex="4">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Home" FieldName="Home" VisibleIndex="5" Width="100px">
                <PropertiesComboBox>
                    <Items>
                        <dx:ListEditItem Selected="True" Text="Project" Value="P"></dx:ListEditItem>
                        <dx:ListEditItem Text="Enterprise" Value="E"></dx:ListEditItem>
                        <dx:ListEditItem Text="Global" Value="G"></dx:ListEditItem>
                    </Items>
                    <ValidationSettings>
                        <RequiredField ErrorText="Please choose a library home" IsRequired="True"></RequiredField>
                    </ValidationSettings>
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="6" Caption="Description" Visible="False">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField ErrorText="" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="filestoragename" Visible="False" VisibleIndex="7">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Upload Date" FieldName="DateUploaded" VisibleIndex="8" Width="100px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Uploaded By" VisibleIndex="9" FieldName="UploadedByName">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="filetext" VisibleIndex="10" Width="0px">
                <Settings AllowFilterBySearchPanel="True" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Uploaded By Id" FieldName="UploadedBy" Visible="False" VisibleIndex="11" Width="0">
            </dx:GridViewDataTextColumn>            
        </Columns>
    </dx:ASPxGridView>
    <dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel"
        Modal="True">
    </dx:ASPxLoadingPanel>
</asp:Content>
