<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_pm.aspx.cs" Inherits="RC_X.rc_enterprise.ent_pm" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function OnToolbarItemClick(s, e) {
            if(IsCustomExportToolbarCommand(e.item.name)) {
                e.processOnServer=true;
                e.usePostBack=true;
            }
        }
        function IsCustomExportToolbarCommand(command) {
            return command == "CustomExportToXLS" || command == "CustomExportToXLSX";
        }
    </script>
    <dx:ASPxGridView ID="gridPM" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridPM" Width="100%" OnCellEditorInitialize="gridPM_CellEditorInitialize" OnRowDeleting="gridPM_RowDeleting" OnRowInserting="gridPM_RowInserting" OnRowUpdating="gridPM_RowUpdating">
       
        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
        </SettingsContextMenu>
        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
        <SettingsPager Mode="ShowAllRecords"></SettingsPager>
        <SettingsBehavior AllowFocusedRow="true" ConfirmDelete="True" AutoExpandAllGroups="True" />
        <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
        <SettingsPager Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsEditing Mode="PopupEditForm">
        </SettingsEditing>
        <SettingsAdaptivity AdaptivityMode="HideDataCells">
        </SettingsAdaptivity>
        <ClientSideEvents ToolbarItemClick="OnToolbarItemClick" />
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

        <Templates>
            <DetailRow>
                <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                    <TabPages>
                        <dx:TabPage Text="Assessment Item">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <asp:SqlDataSource ID="sqlMatrix" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlMatrix_Init"
                                        DeleteCommand="DELETE FROM rc_xref WHERE (xref_id = @xref_id)"
                                        InsertCommand="INSERT INTO rc_scorecards_matrix(matrix_itemkey, matrix_card) VALUES (@matrix_itemkey, @matrix_card)"
                                        SelectCommand="SELECT rc_xref.xref_id, rc_xref.xref_referenceid, rc_xref.xref_itemkey, view_allitems.RC_NAME, view_allitems.RC_ID, view_allitems.RC_TYPE, view_allitems.id FROM rc_xref INNER JOIN view_allitems ON rc_xref.xref_itemkey = view_allitems.id WHERE (rc_xref.xref_referenceid = @xref_referenceid)">
                                        <DeleteParameters>
                                            <asp:Parameter Name="xref_id" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="matrix_itemkey" />
                                            <asp:Parameter Name="matrix_card" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:SessionParameter Name="xref_referenceid" SessionField="xref_referenceid" />
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                    <asp:SqlDataSource ID="sqlAllAssess" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlAllAssess_Init"
                                        SelectCommand="SELECT [id], [RC_ID], [RC_NAME], [RC_TYPE] FROM [view_allitems]"></asp:SqlDataSource>
                                    <dx:ASPxGridView ID="gridMatrix" runat="server" AutoGenerateColumns="False" DataSourceID="sqlMatrix" KeyFieldName="xref_id" OnBeforePerformDataSelect="gridMatrix_BeforePerformDataSelect" OnRowInserting="gridMatrix_RowInserting" Width="100%">
                                        <SettingsPager Mode="ShowAllRecords">
                                        </SettingsPager>
                                        <SettingsBehavior AutoExpandAllGroups="true" />
                                        <Settings ShowFilterRow="True" />
                                        <SettingsCommandButton RenderMode="Image">
                                            <NewButton>
                                                <Image IconID="actions_add_16x16">
                                                </Image>
                                            </NewButton>
                                            <UpdateButton>
                                                <Image IconID="actions_apply_16x16">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton>
                                                <Image IconID="actions_cancel_16x16">
                                                </Image>
                                            </CancelButton>
                                            <DeleteButton>
                                                <Image IconID="actions_trash_16x16">
                                                </Image>
                                            </DeleteButton>
                                        </SettingsCommandButton>
                                        <EditFormLayoutProperties>
                                            <Items>
                                                <dx:GridViewColumnLayoutItem Caption=" ">
                                                    <Template>
                                                        <dx:ASPxGridView ID="gridAssessItems" runat="server" AutoGenerateColumns="False" DataSourceID="sqlAllAssess" KeyFieldName="id" Width="100%">
                                                            <SettingsPager Mode="ShowAllRecords">
                                                            </SettingsPager>
                                                            <Settings ShowFilterRow="True" />
                                                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                            <Columns>
                                                                <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn Caption="Unique ID" FieldName="RC_ID" VisibleIndex="2" Width="200px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Name" FieldName="RC_NAME" VisibleIndex="3">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Type" FieldName="RC_TYPE" VisibleIndex="1" Width="100px">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="id" Visible="False" VisibleIndex="4">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </Template>
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:EditModeCommandLayoutItem HorizontalAlign="Right">
                                                </dx:EditModeCommandLayoutItem>
                                            </Items>
                                        </EditFormLayoutProperties>
                                        <Columns>
                                            <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn Caption="Unique ID" FieldName="RC_ID" ReadOnly="True" ShowInCustomizationForm="True" SortIndex="1" SortOrder="Ascending" VisibleIndex="2" Width="150px">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Type" FieldName="RC_TYPE" GroupIndex="0" ReadOnly="True" ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" VisibleIndex="1" Width="100px">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="xref_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="xref_referenceid" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="xref_itemkey" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Name" FieldName="RC_NAME" ShowInCustomizationForm="True" SortIndex="2" SortOrder="Ascending" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Workflow">
                            <ContentCollection>
                                <dx:ContentControl runat="server">

                                    <dx:ASPxGridView ID="gridWorkflow" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" Width="100%" OnBeforePerformDataSelect="gridWorkflow_BeforePerformDataSelect" OnRowInserting="gridWorkflow_RowInserting">
                                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                                        <Templates>
                                            <DetailRow>
                                                <dx:ASPxHtmlEditor ID="txDetails" runat="server" Html='<%# Eval("Comments") %>' Width="100%">
                                                    <Settings AllowHtmlView="False" AllowPreview="False">
                                                    </Settings>
                                                </dx:ASPxHtmlEditor>
                                            </DetailRow>
                                        </Templates>
                                        <SettingsEditing Mode="EditForm">
                                        </SettingsEditing>
                                        <Settings ShowFilterBar="Auto" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowPreview="True" UseFixedTableLayout="True" />

                                        <SettingsResizing ColumnResizeMode="Control" />

                                        <SettingsCookies Enabled="True" />

                                        <SettingsCommandButton RenderMode="Link">
                                            <NewButton>
                                                <Image AlternateText="Change Status" IconID="actions_add_16x16">
                                                </Image>
                                            </NewButton>
                                            <UpdateButton ButtonType="Link" RenderMode="Link">
                                                <Image AlternateText="Save" IconID="actions_apply_16x16" ToolTip="Save">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton ButtonType="Link" RenderMode="Link">
                                                <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                                                </Image>
                                            </CancelButton>
                                        </SettingsCommandButton>
                                        <SettingsDataSecurity AllowDelete="False" />
                                        <EditFormLayoutProperties ColCount="2">
                                            <Items>
                                                <dx:GridViewColumnLayoutItem ColumnName="Status" Caption="Choose New Status" ColSpan="2">
                                                    <Template>
                                                        <dx:ASPxComboBox ID="workflowDropStatus" runat="server" TextField="Name" ValueField="Description" ValueType="System.String" Width="100%" OnInit="workflowDropStatus_Init">
                                                        </dx:ASPxComboBox>
                                                    </Template>
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:GridViewColumnLayoutItem Caption="Choose User" ColumnName="wf_to">
                                                    <Template>
                                                        <dx:ASPxComboBox ID="workflowdropUser" runat="server" TextField="Email" ValueField="UserID" ValueType="System.String" OnInit="workflowdropUser_Init">
                                                        </dx:ASPxComboBox>
                                                    </Template>
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:GridViewColumnLayoutItem ColumnName="Due Date">
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Comments">
                                                    <Template>
                                                        <dx:ASPxHtmlEditor ID="txComments" runat="server" Width="100%">
                                                            <Settings AllowHtmlView="False" AllowPreview="False">
                                                                <SettingsRibbonToolbar OneLineMode="True" />
                                                            </Settings>
                                                            <SettingsResize AllowResize="True" />
                                                        </dx:ASPxHtmlEditor>
                                                    </Template>
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:EditModeCommandLayoutItem ColSpan="2" ShowUpdateButton="true" ShowCancelButton="true" HorizontalAlign="Right">
                                                </dx:EditModeCommandLayoutItem>
                                            </Items>
                                        </EditFormLayoutProperties>
                                        <Columns>
                                            <dx:GridViewCommandColumn ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px" ButtonRenderMode="Image" ButtonType="Image">
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="ItemKey" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="wf_comments" ShowInCustomizationForm="True" Visible="False" VisibleIndex="11" Caption="Comments">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Assigned By" FieldName="Manager" ShowInCustomizationForm="True" VisibleIndex="9">
                                                <EditFormSettings Visible="False" />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" ShowInCustomizationForm="True" VisibleIndex="8">
                                                <PropertiesDateEdit>
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="True" />
                                                    </ValidationSettings>
                                                </PropertiesDateEdit>
                                            </dx:GridViewDataDateColumn>
                                            <dx:GridViewDataDateColumn FieldName="StatusDate" ShowInCustomizationForm="True" VisibleIndex="10" Caption="Date Changed" ReadOnly="True">
                                            </dx:GridViewDataDateColumn>
                                            <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataProgressBarColumn Caption="Progress" FieldName="StatusValue" ShowInCustomizationForm="True" VisibleIndex="4" Width="100px">
                                                <PropertiesProgressBar DisplayFormatString="" Maximum="3" DisplayMode="Position">
                                                </PropertiesProgressBar>
                                                <EditFormSettings Visible="False" />
                                            </dx:GridViewDataProgressBarColumn>
                                            <dx:GridViewDataTextColumn Caption="Status" FieldName="Status" VisibleIndex="5">
                                                <PropertiesTextEdit>
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="True" />
                                                    </ValidationSettings>
                                                </PropertiesTextEdit>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Assigned To" FieldName="Worker" VisibleIndex="7">
                                                <PropertiesTextEdit>
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="True" />
                                                    </ValidationSettings>
                                                </PropertiesTextEdit>
                                                <EditFormSettings Caption="Choose Assessor" />
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Artifacts">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <dx:ASPxGridView ID="gridArtifacts" runat="server" AutoGenerateColumns="False" KeyFieldName="AttachmentID" OnBeforePerformDataSelect="gridArtifacts_BeforePerformDataSelect" OnRowInserting="gridArtifacts_RowInserting" OnRowDeleting="gridArtifacts_RowDeleting" OnDetailRowExpandedChanged="gridArtifacts_DetailRowExpandedChanged" Width="100%">
                                        <SettingsPager Mode="ShowAllRecords" />
                                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                                        <SettingsBehavior AutoExpandAllGroups="true" />
                                        <Settings ShowFilterRow="True" />
                                        <Settings AutoFilterCondition="Contains" EnableFilterControlPopupMenuScrolling="True" ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowTitlePanel="True" />
                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsResizing ColumnResizeMode="Control" />
                                        <SettingsSearchPanel ShowApplyButton="True" ShowClearButton="True" />
                                        <SettingsText ConfirmDelete="Are you sure you want to unattach this artifact?" />
                                        <SettingsCommandButton RenderMode="Image">
                                            <NewButton>
                                                <Image IconID="mail_attachment_16x16">
                                                </Image>
                                            </NewButton>
                                            <UpdateButton>
                                                <Image IconID="actions_apply_16x16">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton>
                                                <Image IconID="actions_cancel_16x16">
                                                </Image>
                                            </CancelButton>
                                            <DeleteButton Text="unattach">
                                                <Image IconID="actions_removeitem_16x16">
                                                </Image>
                                            </DeleteButton>
                                        </SettingsCommandButton>
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
                                                                    <br />
                                                                    <br />
                                                                    <dx:ASPxRichEdit ID="richDetailsPreview" runat="server" RibbonMode="None" WorkDirectory="~\App_Data\WorkDirectory" Visible="False" ReadOnly="True" Width="100%">
                                                                        <settings>
                                                                                                <RangePermissions Visibility="Auto" />
                                                                                            </settings>
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


                                                    </TabPages>
                                                </dx:ASPxPageControl>
                                            </DetailRow>
                                        </Templates>
                                        <EditFormLayoutProperties>
                                            <Items>
                                                <dx:GridViewColumnLayoutItem Caption=" ">
                                                    <Template>
                                                        <dx:ASPxGridView ID="gridRepository" runat="server" AutoGenerateColumns="False" KeyFieldName="ArtifactID" Width="100%" OnBeforePerformDataSelect="gridRepository_BeforePerformDataSelect">
                                                            <SettingsPager PageSize="25">
                                                            </SettingsPager>
                                                            <Settings ShowFilterRow="True" />
                                                            <SettingsCommandButton>
                                                                <NewButton>
                                                                    <Image IconID="actions_add_16x16">
                                                                    </Image>
                                                                </NewButton>
                                                                <CancelButton>
                                                                    <Image IconID="actions_cancel_16x16">
                                                                    </Image>
                                                                </CancelButton>
                                                                <DeleteButton>
                                                                    <Image IconID="actions_trash_16x16">
                                                                    </Image>
                                                                </DeleteButton>
                                                            </SettingsCommandButton>
                                                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                            <Columns>
                                                                <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn FieldName="ArtifactID" Name="ArtifactID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Name" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Type" FieldName="Type" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Level" FieldName="Home" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="FileName" ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="StorageName" ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="FullText" ShowInCustomizationForm="True" Visible="False" VisibleIndex="9">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Page Reference" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                    <DataItemTemplate>
                                                                        <dx:ASPxTextBox ID="txPage" runat="server" Width="100%">
                                                                            <ClientSideEvents LostFocus="GetBoxName" />
                                                                            <Border BorderStyle="None" />
                                                                        </dx:ASPxTextBox>
                                                                    </DataItemTemplate>
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </Template>
                                                </dx:GridViewColumnLayoutItem>
                                                <dx:EditModeCommandLayoutItem HorizontalAlign="Right">
                                                </dx:EditModeCommandLayoutItem>
                                            </Items>
                                        </EditFormLayoutProperties>
                                        <Columns>
                                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowNewButtonInHeader="true" ShowInCustomizationForm="True" VisibleIndex="0" Width="50px">
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn FieldName="ArtifactID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Name" FieldName="ArtifactTitle" ShowInCustomizationForm="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Type" FieldName="ArtifactType" ShowInCustomizationForm="True" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Level" FieldName="ArtifactHome" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="PageReference" ShowInCustomizationForm="True" VisibleIndex="7" Caption="Reference">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="filename" VisibleIndex="8" Caption="File Name" Visible="false">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="filestoragename" Visible="False" VisibleIndex="9">
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

        <SettingsResizing ColumnResizeMode="Control" />

        <SettingsCommandButton RenderMode="Image">
            <NewButton>
                <Image IconID="actions_add_16x16">
                </Image>
            </NewButton>
            <UpdateButton>
                <Image IconID="actions_apply_16x16">
                </Image>
            </UpdateButton>
            <CancelButton>
                <Image IconID="actions_cancel_16x16">
                </Image>
            </CancelButton>
            <EditButton>
                <Image IconID="actions_editname_16x16">
                </Image>
            </EditButton>
            <DeleteButton>
                <Image IconID="actions_trash_16x16">
                </Image>
            </DeleteButton>
        </SettingsCommandButton>
        <SettingsSearchPanel Visible="True" />
        <EditFormLayoutProperties AlignItemCaptionsInAllGroups="True" ColCount="2">
            <Items>
                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Title">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Type">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Home">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Unique ID">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Priority">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Status">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Area">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewTabbedLayoutGroup Caption=" " ColSpan="2" Width="100%">
                    <Items>
                        <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description" RowSpan="3">
                        </dx:GridViewColumnLayoutItem>
                        <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Solution" RowSpan="3">
                        </dx:GridViewColumnLayoutItem>
                    </Items>
                </dx:GridViewTabbedLayoutGroup>
                <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                </dx:EditModeCommandLayoutItem>
            </Items>
        </EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="Id" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Unique ID" FieldName="UniqueID" SortIndex="1" SortOrder="Ascending" VisibleIndex="3" Width="100px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="Type" GroupIndex="0" SortIndex="0" SortOrder="Ascending" VisibleIndex="2" Width="150px">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn Caption="Title" FieldName="Title" VisibleIndex="4" Width="150px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn Caption="Home" FieldName="Home" ShowInCustomizationForm="True" VisibleIndex="5" Width="75px">
                <PropertiesComboBox>
                    <Items>
                        <dx:ListEditItem Text="Global" Value="G" />
                        <dx:ListEditItem Text="Enterprise" Value="E" />
                        <dx:ListEditItem Text="Project" Value="P" />
                    </Items>
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Priority" FieldName="Priority" VisibleIndex="9" Width="100px">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="Status" VisibleIndex="10" Width="100px">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataTextColumn Caption="Created By" FieldName="CreatedBy" VisibleIndex="11">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Date Created" FieldName="CreatedDate" VisibleIndex="12">
                <PropertiesDateEdit DisplayFormatString="">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataComboBoxColumn Caption="Area" FieldName="Area" VisibleIndex="6">
            </dx:GridViewDataComboBoxColumn>
          
            <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" Visible="False" VisibleIndex="7">
                <PropertiesMemoEdit Rows="15" Width="100%">
                </PropertiesMemoEdit>
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataMemoColumn Caption="Solution" FieldName="Solution" Visible="False" VisibleIndex="8">
                <PropertiesMemoEdit Rows="15" Width="100%">
                </PropertiesMemoEdit>
            </dx:GridViewDataMemoColumn>
        </Columns>
    </dx:ASPxGridView>
</asp:Content>
