<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_assessment.aspx.cs" Inherits="RC_X.rc_enterprise.ent_assessment" %>

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
        // javascript for Assessment Mass Load
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

    <dx:ASPxPageControl ID="tabRTM" runat="server" ActiveTabIndex="2" Height="100%" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Name="Business Area" Text="Business Area">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <%-- <dx:ASPxCallbackPanel runat="server" ID="ObjectivesCallbackPanel" ClientInstanceName="CallbackPanel" RenderMode="Div">
                                        <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                                        <PanelCollection>
                                            <dx:PanelContent ID="PanelContent1" runat="server">--%>

                        <dx:ASPxGridView ID="gridArea" runat="server" KeyFieldName="Id" Width="100%" AutoGenerateColumns="false" OnBatchUpdate="GridArea_BatchUpdate">

                            <SettingsCommandButton>
                                <NewButton Text="New">
                                    <Image IconID="actions_add_16x16" ToolTip="New" AlternateText="New">
                                    </Image>
                                </NewButton>
                                <UpdateButton Text="Save">
                                    <Image IconID="actions_apply_16x16" ToolTip="Save" AlternateText="Save">
                                    </Image>
                                </UpdateButton>
                                <CancelButton Text="Cancel">
                                    <Image IconID="actions_cancel_16x16" ToolTip="Cancel" AlternateText="Cancel">
                                    </Image>
                                </CancelButton>
                                <EditButton>
                                    <Image IconID="actions_editname_16x16" ToolTip="Edit" AlternateText="Edit">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image IconID="edit_delete_16x16" ToolTip="Delete" AlternateText="Delete">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
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
                                        <%--  <dx:GridViewToolbarItem BeginGroup="true">
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
                                <BatchEditSettings EditMode="Row" StartEditAction="DblClick" />
                            </SettingsEditing>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                            <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Id" Visible="false" Width="200px" />
                                <dx:GridViewDataTextColumn Caption="ID" FieldName="UniqueID" Width="200px">
                                    <%--<Settings AllowGroup="True" SortMode="DisplayText" />--%>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Area Title" FieldName="AreaTitle" Width="200px" />
                                <dx:GridViewDataTextColumn Caption="Description" FieldName="Description" />
                                <dx:GridViewDataTextColumn Caption="Source" FieldName="Source" Width="200px" />
                                <dx:GridViewDataDateColumn Caption="Source Date" FieldName="Date" ShowInCustomizationForm="True" VisibleIndex="4" Width="200px">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                            </Columns>
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                        </dx:ASPxGridView>

                        <%--</dx:PanelContent>
                                        </PanelCollection>
                                    </dx:ASPxCallbackPanel>--%>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="Business Category" Text="Business Category">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxCallbackPanel runat="server" ID="CategoryCallbackPanel" ClientInstanceName="CallbackPanel" RenderMode="Div">
                            <ClientSideEvents EndCallback="OnEndCallback"></ClientSideEvents>
                            <PanelCollection>
                                <dx:PanelContent ID="PanelContent2" runat="server">

                                    <dx:ASPxGridView ID="gridCategory" runat="server" KeyFieldName="Id" Width="100%" AutoGenerateColumns="false" OnBatchUpdate="GridCategory_BatchUpdate">

                                        <Settings ShowGroupedColumns="False" ShowGroupPanel="True" />
                                        <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True" />

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
                                        <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
                                            <BatchEditSettings EditMode="Row" StartEditAction="DblClick" />
                                        </SettingsEditing>
                                        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                        <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                                        <%--CustomEditorID="tbToolbarSearch"--%>
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <Columns>
                                            <dx:GridViewDataTextColumn FieldName="Id" Visible="false" Width="100px" />
                                            <%--<dx:GridViewDataTextColumn Caption="Area Title" FieldName="AreaTitle" GroupIndex="0" />--%>
                                            <dx:GridViewDataComboBoxColumn VisibleIndex="1" FieldName="AreaID" Caption="Area Title">
                                                <PropertiesComboBox DataSourceID="sqlArea" ValueField="area_id" TextField="area_name">
                                                </PropertiesComboBox>
                                            </dx:GridViewDataComboBoxColumn>
                                            <dx:GridViewDataTextColumn Caption="ID" FieldName="UniqueID" Width="100px" />
                                            <dx:GridViewDataTextColumn Caption="Title" FieldName="CategoryTitle" Width="100px" />
                                            <dx:GridViewDataTextColumn Caption="Description" FieldName="Description" />
                                            <dx:GridViewDataTextColumn Caption="Source" FieldName="Source" Width="100px" />
                                            <dx:GridViewDataDateColumn Caption="Source Date" FieldName="Date" ShowInCustomizationForm="True" Width="200px">
                                            </dx:GridViewDataDateColumn>
                                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                            </dx:GridViewCommandColumn>
                                        </Columns>
                                        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                        <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>

                                    </dx:ASPxGridView>
                                    <asp:SqlDataSource ID="sqlArea" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT area_id, area_name FROM rc_assessment_areas where [area_deleted] = 0" OnInit="sqlArea_Init"></asp:SqlDataSource>

                                </dx:PanelContent>
                            </PanelCollection>
                        </dx:ASPxCallbackPanel>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="Business Process" Text="Business process">
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

                        <dx:ASPxGridView ID="gridProcess" runat="server" KeyFieldName="Id" AutoGenerateColumns="False" Width="100%" OnBatchUpdate="GridProcess_BatchUpdate"
                            ClientInstanceName="gridProcess">
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
                            <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
                                <BatchEditSettings EditMode="Row" StartEditAction="DblClick"></BatchEditSettings>
                            </SettingsEditing>
                            <Settings ShowGroupedColumns="False" ShowGroupPanel="True" />
                            <SettingsBehavior AllowFixedGroups="False" AutoExpandAllGroups="True" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                            <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>

                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Id" Visible="false" Width="100px" />
                                <dx:GridViewDataTextColumn Caption="Area Title" FieldName="AreaTitle" />
                                <%--<dx:GridViewDataTextColumn Caption="Category Title" FieldName="CategoryTitle" />--%>
                                <dx:GridViewDataComboBoxColumn VisibleIndex="1" FieldName="CategoryId" Caption="Category Title">
                                    <PropertiesComboBox DataSourceID="SqlCategory" ValueField="cat_id" TextField="cat_name">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn Caption="ID" FieldName="UniqueID" Width="100px" />
                                <dx:GridViewDataTextColumn Caption="Title" FieldName="ProcessTitle" Width="100px" />
                                <dx:GridViewDataTextColumn Caption="Description" FieldName="Description" />
                                <dx:GridViewDataTextColumn Caption="Source" FieldName="Source" Width="100px" />
                                <dx:GridViewDataDateColumn Caption="Source Date" FieldName="Date" ShowInCustomizationForm="True" Width="200px">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataCheckColumn FieldName="IsActive" Width="200px">
                                    <PropertiesCheckEdit AllowGrayed="true" AllowGrayedByClick="false" />
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                            </Columns>
                            <%--<ClientSideEvents EndCallback="function(s, e) {grid.Refresh();}" />--%>
                        </dx:ASPxGridView>
                        <asp:SqlDataSource ID="SqlCategory" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="SqlCategory_Init" SelectCommand="SELECT [cat_id], [cat_name] FROM rc_assessment_categories where [cat_deleted] = 0"></asp:SqlDataSource>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="assessmentMassLoad" Text="Mass Load">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxHiddenField runat="server" ID="hdbSubmissionID" ClientInstanceName="hdbSubmissionID" />
                        <div class="anc-button-container">
                            <span>
                                <a href="../Content/SpreadSheetTemplate/ProjectAssessmentBAMassload.xlsx" target="_blank" class="anc-download">Download Spreadsheet Template for Assessment BA Responses Data Load</a>
                                <a href="../Content/SpreadSheetTemplate/ProjectAssessmentBPMassload.xlsx" target="_blank" class="anc-download2">Download Spreadsheet Template for Assessment BP Responses Data Load</a>
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

                                                                            <dx:ASPxGridView ID="gvAssesmentUpload" runat="server" Width="100%" AutoGenerateColumns="true" Visible="false">
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
