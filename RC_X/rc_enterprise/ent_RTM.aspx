<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_RTM.aspx.cs" Inherits="RC_X.rc_enterprise.ent_RTM" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        var postponedCallbackRequired = false;
        function OnDropdownIndexChanged(s, e) {
            if (CallbackPanel.InCallback())
                postponedCallbackRequired = true;
            else
                CallbackPanel.PerformCallback();
        }
        function OnEndCallback(s, e) {
            if (postponedCallbackRequired) {
                CallbackPanel.PerformCallback();
                postponedCallbackRequired = false;
            }
        }
        // javascript for RTM Mass Load
        var uploadInProgress = false,
            submitInitiated = false,
            uploadErrorOccurred = false,
            uploadedFiles = [];
        function onFileUploadComplete(s, e) {
            var callbackData = e.callbackData.split("|"),
                uploadedFileName = callbackData[0],
                isSubmissionExpired = callbackData[1] === "True";
            uploadedFiles.push(uploadedFileName);
            if (e.errorText.length > 0 || !e.isValid)
                uploadErrorOccurred = true;
            if (isSubmissionExpired && UploadedFilesTokenBox.GetText().length > 0) {
                var removedAfterTimeoutFiles = UploadedFilesTokenBox.GetTokenCollection().join("\n");
                UploadedFilesTokenBox.ClearTokenCollection();
            }
        }
        function onFilesUploadComplete(s, e) {
            uploadInProgress = false;
            for (var i = 0; i < uploadedFiles.length; i++)
                UploadedFilesTokenBox.AddToken(uploadedFiles[i]);
            updateTokenBoxVisibility();
            uploadedFiles = [];
            if (submitInitiated) {
                SubmitButton.SetEnabled(true);
                SubmitButton.DoClick();
            }
        }
        function onFileUploadStart(s, e) {
            uploadInProgress = true;
            uploadErrorOccurred = false;
            UploadedFilesTokenBox.SetIsValid(true);
        }
        function onSubmitButtonInit(s, e) {
            s.SetEnabled(true);
        }
        function onSubmitButtonClick(s, e) {
            ASPxClientEdit.ValidateGroup();
            if (!formIsValid())
                e.processOnServer = false;
            else if (uploadInProgress) {
                s.SetEnabled(false);
                submitInitiated = true;
                e.processOnServer = false;
            }
        }
        function onTokenBoxValidation(s, e) {
            var isValid = DocumentsUploadControl.GetText().length > 0 || UploadedFilesTokenBox.GetText().length > 0;
            e.isValid = isValid;
            if (!isValid) {
                e.errorText = "No files have been uploaded. Upload at least one file.";
            }
        }
        function onTokenBoxValueChanged(s, e) {
            updateTokenBoxVisibility();
        }
        function updateTokenBoxVisibility() {
            var isTokenBoxVisible = UploadedFilesTokenBox.GetTokenCollection().length > 0;
            UploadedFilesTokenBox.SetVisible(isTokenBoxVisible);
        }
        function formIsValid() {
            return !ValidationSummary.IsVisible() && DescriptionTextBox.GetIsValid() && UploadedFilesTokenBox.GetIsValid() && !uploadErrorOccurred;
        }
    </script>

    <dx:ASPxPageControl ID="tabRTM" runat="server" ActiveTabIndex="0" Height="100%" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Name="checklists" Text="Checklists">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <div>
                            <h3 style="color: coral">Please Select a Project From the Dropdown 
                            </h3>
                        </div>
                        <dx:ASPxComboBox ID="ddlProjects" runat="server" DropDownStyle="DropDown" AutoPostBack="true" TextField="Name" ValueField="Id" OnSelectedIndexChanged="ddlProjects_SelectedIndexChanged">
                            <ClientSideEvents SelectedIndexChanged="OnDropdownIndexChanged" />
                        </dx:ASPxComboBox>
                        <br />

                        <dx:ASPxGridView ID="gridCheckList" runat="server" KeyFieldName="Id" AutoGenerateColumns="False" Width="100%" OnBatchUpdate="Grid_BatchUpdate"
                            ClientInstanceName="gridCheckList">
                            <SettingsCommandButton>
                                <NewButton Text="New">
                                    <Image IconID="actions_add_16x16" ToolTip="New">
                                    </Image>
                                </NewButton>
                                <UpdateButton Text="Save">
                                    <Image IconID="actions_apply_16x16" ToolTip="Save">
                                    </Image>
                                </UpdateButton>
                                <CancelButton Text="Cancel">
                                    <Image IconID="actions_cancel_16x16" ToolTip="Cancel">
                                    </Image>
                                </CancelButton>
                                <EditButton>
                                    <Image IconID="actions_editname_16x16" ToolTip="Edit">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image IconID="edit_delete_16x16" ToolTip="Delete">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                           
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <Toolbars>
                                <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                    <Items>

                                        <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
                                        <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                        <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
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
                            <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
                                <BatchEditSettings EditMode="Row" StartEditAction="DblClick"></BatchEditSettings>
                            </SettingsEditing>

                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Checklist Title" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="2" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Checklist Type" FieldName="Type" ShowInCustomizationForm="True" VisibleIndex="2" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>

                                <dx:GridViewDataCheckColumn FieldName="IsActive" Width="200px">
                                    <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="False" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                            </Columns>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>
                            <%--<ClientSideEvents EndCallback="function(s, e) {grid.Refresh();}" />--%>
                        </dx:ASPxGridView>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="objectives" Text="Business Objectives">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <%-- <dx:ASPxCallbackPanel runat="server" ID="ObjectivesCallbackPanel" ClientInstanceName="CallbackPanel" RenderMode="Div">
                                        <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                                        <PanelCollection>
                                            <dx:PanelContent ID="PanelContent1" runat="server">--%>

                        <dx:ASPxGridView ID="gridObjectives" runat="server" KeyFieldName="Id" Width="100%" AutoGenerateColumns="false" OnBatchUpdate="GridObjective_BatchUpdate">
                            <Settings ShowGroupedColumns="False" ShowGroupPanel="True" />
                            <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="true" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                           
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
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
                                       <%-- <dx:GridViewToolbarItem BeginGroup="true">
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
                            <SettingsCommandButton>
                                <UpdateButton Text="Save">
                                    <Image IconID="actions_apply_16x16" ToolTip="Save">
                                    </Image>
                                </UpdateButton>
                                <CancelButton Text="Cancel">
                                    <Image IconID="actions_cancel_16x16" ToolTip="Cancel">
                                    </Image>
                                </CancelButton>
                                <EditButton>
                                    <Image IconID="actions_editname_16x16" ToolTip="Edit">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image IconID="edit_delete_16x16" ToolTip="Delete">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
                            <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
                                <BatchEditSettings EditMode="Row" StartEditAction="DblClick" />
                            </SettingsEditing>

                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Id" Visible="false" Width="200px" />
                                <dx:GridViewDataTextColumn Caption="CheckList Type" FieldName="ChecklistType" Width="200px" GroupIndex="0">                                                                 
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="CheckList Title" FieldName="ChecklistTitle" Width="200px" GroupIndex="1" />
                                <dx:GridViewDataTextColumn Caption="UniqueId" FieldName="UniqueId" Width="200px" />
                                <dx:GridViewDataTextColumn Caption="Business Objective Name" FieldName="Name" />
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="False" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                            </Columns>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>
                        </dx:ASPxGridView>

                        <%--</dx:PanelContent>
                                        </PanelCollection>
                                    </dx:ASPxCallbackPanel>--%>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="criteria" Text="System Review Criteria">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxCallbackPanel runat="server" ID="CriteriaCallbackPanel" ClientInstanceName="CallbackPanel" RenderMode="Div">
                            <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                            <PanelCollection>
                                <dx:PanelContent ID="PanelContent2" runat="server">

                                    <dx:ASPxGridView ID="gridCriteria" runat="server" KeyFieldName="Id" Width="100%" AutoGenerateColumns="false" OnBatchUpdate="gridCriteria_BatchUpdate">

                                        <Settings ShowGroupedColumns="False" ShowGroupPanel="True" />
                                        <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True"  />
                                        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                        
                                        <SettingsPager PageSize="25"></SettingsPager>
                                        <SettingsBehavior AllowFocusedRow="true"  />
                                       <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                                        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                        <SettingsResizing ColumnResizeMode="Control"/>
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>

                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
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
                                        <SettingsCommandButton>
                                            <UpdateButton Text="Save">
                                                <Image IconID="actions_apply_16x16" ToolTip="Save">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton Text="Cancel">
                                                <Image IconID="actions_cancel_16x16" ToolTip="Cancel">
                                                </Image>
                                            </CancelButton>
                                            <EditButton>
                                                <Image IconID="actions_editname_16x16" ToolTip="Edit">
                                                </Image>
                                            </EditButton>
                                            <DeleteButton>
                                                <Image IconID="edit_delete_16x16" ToolTip="Delete">
                                                </Image>
                                            </DeleteButton>
                                        </SettingsCommandButton>
                                        <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
                                            <BatchEditSettings EditMode="Row" StartEditAction="DblClick" />
                                        </SettingsEditing>

                                        <Columns>
                                            <dx:GridViewDataTextColumn FieldName="Id" Visible="false" Width="100px" />
                                            <dx:GridViewDataTextColumn Caption="CheckList Type" FieldName="ChecklistType" Width="200px" GroupIndex="0">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="CheckList Title" FieldName="ChecklistTitle" Width="200px" GroupIndex="1" />
                                            <dx:GridViewDataTextColumn Caption="Objective Name" FieldName="ObjectiveUniqueId" GroupIndex="2" />
                                            <dx:GridViewDataTextColumn Caption="Title" FieldName="Title" Width="100px" />
                                            <dx:GridViewDataTextColumn Caption="Unique Name" FieldName="Name" Width="100px" />
                                            <dx:GridViewDataTextColumn Caption="Criteria" FieldName="Criteria" />
                                            <dx:GridViewDataTextColumn Caption="Compliance" FieldName="Complaince" Width="100px" Visible="false" />
                                            <dx:GridViewDataTextColumn Caption="Source" FieldName="Source" Width="100px" />
                                            <dx:GridViewDataCheckColumn Caption="Critical" FieldName="Critical" Width="100px">
                                                <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
                                            </dx:GridViewDataCheckColumn>
                                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="False" VisibleIndex="0" Width="50px">
                                            </dx:GridViewCommandColumn>
                                        </Columns>
                                        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                        <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>

                                    </dx:ASPxGridView>

                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxCallbackPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="rtmMassLoad" Text="Mass Load">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxHiddenField runat="server" ID="hdbSubmissionID" ClientInstanceName="hdbSubmissionID" />
                        <div class="anc-button-container">
                            <span>
                                <a href="../Content/SpreadSheetTemplate/Book2.xlsx" target="_blank" class="anc-download">Download Spreadsheet Template for RTM Data Load</a>
                                <a href="../Content/SpreadSheetTemplate/ProjectRTMMassload.xlsx" target="_blank" class="anc-download2">Download Spreadsheet Template for RTM Responses Data Load</a>
                            </span>
                            
                        </div>
                        <br />
                        <dx:ASPxFormLayout ID="FormLayout" runat="server" Width="100%" ColCount="2" UseDefaultPaddings="false">
                            <Items>
                                <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" Width="80%" UseDefaultPaddings="false">
                                    <Items>
                                        <dx:LayoutGroup Caption="SpreadSheet Upload">
                                            <Items>
                                                <dx:LayoutItem ShowCaption="False">
                                                    <LayoutItemNestedControlCollection>
                                                        <dx:LayoutItemNestedControlContainer>
                                                            <div id="dropZone">
                                                                <dx:ASPxUploadControl runat="server" ID="DocumentsUploadControl" ClientInstanceName="DocumentsUploadControl" CssClass="float-left bottom-mrgn30"
                                                                    AutoStartUpload="true" ShowProgressPanel="True" ShowTextBox="false" BrowseButton-Text="Add SpreadSheet" FileUploadMode="OnPageLoad"
                                                                    OnFileUploadComplete="DocumentsUploadControl_FileUploadComplete" Width="200px">
                                                                    <BrowseButton Text="Add SpreadSheet"></BrowseButton>
                                                                    <AdvancedModeSettings EnableMultiSelect="false" EnableDragAndDrop="true" />
                                                                    <ValidationSettings AllowedFileExtensions=" .xls, .xlsx" MaxFileSize="4194304">
                                                                    </ValidationSettings>
                                                                    <ClientSideEvents
                                                                        FileUploadComplete="onFileUploadComplete"
                                                                        FilesUploadComplete="onFilesUploadComplete"
                                                                        FilesUploadStart="onFileUploadStart" />
                                                                </dx:ASPxUploadControl>
                                                                <dx:ASPxTokenBox runat="server" ID="UploadedFilesTokenBox" ClientInstanceName="UploadedFilesTokenBox" CssClass="float-left"
                                                                    NullText="Select the documents to submit" AllowCustomTokens="false" ClientVisible="false" Width="60%">
                                                                    <ClientSideEvents Init="updateTokenBoxVisibility" ValueChanged="onTokenBoxValueChanged" Validation="onTokenBoxValidation" />
                                                                    <ValidationSettings EnableCustomValidation="true" />
                                                                </dx:ASPxTokenBox>
                                                                <br />
                                                                <dx:ASPxValidationSummary runat="server" ID="ValidationSummary" ClientInstanceName="ValidationSummary"
                                                                    RenderMode="Table" Width="100%" ShowErrorAsLink="false" />
                                                                <br />
                                                                <dx:ASPxCallbackPanel runat="server" ID="ASPxCallbackPanel1" ClientInstanceName="CallbackPanel" RenderMode="Div">
                                                                    <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                                                                    <PanelCollection>
                                                                        <dx:PanelContent ID="PanelContent1" runat="server">

                                                                            <dx:ASPxGridView ID="gvRtmUpload" runat="server" Width="100%" AutoGenerateColumns="true" Visible="false" >
                                                                                
                                                                            </dx:ASPxGridView>

                                                                        </dx:PanelContent>
                                                                    </PanelCollection>
                                                                </dx:ASPxCallbackPanel>
                                                            </div>
                                                        </dx:LayoutItemNestedControlContainer>
                                                    </LayoutItemNestedControlCollection>
                                                </dx:LayoutItem>
                                            </Items>
                                        </dx:LayoutGroup>
                                        <dx:LayoutItem ShowCaption="False" HorizontalAlign="Right">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer>
                                                    <dx:ASPxButton runat="server" ID="SubmitButton" ClientInstanceName="SubmitButton" Text="Submit" AutoPostBack="True"
                                                        OnClick="SubmitButton_Click" ValidateInvisibleEditors="true">
                                                        <%--<ClientSideEvents Init="onSubmitButtonInit" Click="onSubmitButtonClick" />--%>
                                                    </dx:ASPxButton>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:EmptyLayoutItem Height="5" />
                                    </Items>
                                </dx:LayoutGroup>

                            </Items>
                            <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="600" />
                        </dx:ASPxFormLayout>



                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <TabStyle Font-Bold="False" Font-Size="Small">
            <Paddings PaddingBottom="10px" PaddingTop="10px" />
        </TabStyle>
        <ContentStyle HorizontalAlign="Left" VerticalAlign="Top">
        </ContentStyle>
        <SpaceBeforeTabsTemplateStyle>
            <Paddings PaddingTop="20px" />
        </SpaceBeforeTabsTemplateStyle>
    </dx:ASPxPageControl>


</asp:Content>
