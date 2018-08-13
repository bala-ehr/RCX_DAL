<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_roadmap.aspx.cs" Inherits="RC_X.rc_enterprise.ent_roadmap" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxPageControl ID="tabRoadmap" runat="server" ActiveTabIndex="0" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Text="Tasks">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridTasks" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridTasks" KeyFieldName="Id" PreviewFieldName="Description" OnRowDeleting="gridTasks_RowDeleting" OnRowInserting="gridTasks_RowInserting" OnRowUpdating="gridTasks_RowUpdating" Width="100%">
                            
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
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

                                    </Items>
                                </dx:GridViewToolbar>
                            </Toolbars>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                            <SettingsBehavior AllowFocusedRow="true" AutoExpandAllGroups="True" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                            <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsBehavior ConfirmDelete="True" />
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxPageControl ID="tabTasksItems" runat="server" ActiveTabIndex="0" Width="100%">
                                        <TabPages>
                                            <dx:TabPage Name="GapsGoals" Text="Associated Gaps and Goals">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="sqlGapandGoals" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlGapandGoals_Init"
                                                            SelectCommand="select gap_id, gap_title, gap_type from rc_roadmap_gapsgoals where gap_id not in (select distinct rmxref_gapid from [dbo].[rc_roadmap_xref] xref where rmxref_rmid = @TaskID )">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="TaskID" SessionField="TaskID" DbType="String" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>
                                                        <asp:SqlDataSource ID="sqlAssociatedGapandGoals" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlAssociatedGapandGoals_Init"
                                                            SelectCommand="select rmxref_id [Id], gap_title [Title], gap_type [Type] from [dbo].[rc_roadmap_xref] cp inner join [dbo].[rc_roadmap_gapsgoals] gp on cp.rmxref_gapid = gap_id  where cp.rmxref_rmid = @TaskID AND gp.gap_open= 1">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="TaskID" SessionField="TaskID" DbType="String" />
                                                            </SelectParameters>

                                                        </asp:SqlDataSource>
                                                        <dx:ASPxGridView ID="gridAssociatedGapsGoals" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" DataSourceID="sqlAssociatedGapandGoals"
                                                            OnBeforePerformDataSelect="gridAssociatedGapsGoals_BeforePerformDataSelect" OnRowInserting="gridAssociatedGapsGoals_RowInserting" OnCellEditorInitialize="gridAssociatedGapsGoals_CellEditorInitialize" Width="100%">
                                                            <Toolbars>
                                                                <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                                    <Items>
                                                                        <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                                                        <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
                                                                        <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />

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
                                                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                            </SettingsContextMenu>
                                                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                            </SettingsAdaptivity>
                                                            <SettingsPager Mode="ShowAllRecords">
                                                            </SettingsPager>
                                                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                                                            <SettingsBehavior AllowFocusedRow="true" />
                                                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                                                            <%--CustomEditorID="tbToolbarSearch"--%>
                                                            <SettingsBehavior ConfirmDelete="True" />
                                                            <SettingsBehavior AutoExpandAllGroups="True" />
                                                            <SettingsCommandButton RenderMode="Image">
                                                                <NewButton>
                                                                    <Image IconID="actions_add_16x16" ToolTip="Add">
                                                                    </Image>
                                                                </NewButton>
                                                                <UpdateButton ButtonType="Link" RenderMode="Link">
                                                                    <Image IconID="actions_apply_16x16">
                                                                    </Image>
                                                                </UpdateButton>
                                                                <CancelButton ButtonType="Link" RenderMode="Link">
                                                                    <Image IconID="actions_cancel_16x16" ToolTip="Cancel">
                                                                    </Image>
                                                                </CancelButton>
                                                                <DeleteButton>
                                                                    <Image IconID="actions_trash_16x16">
                                                                    </Image>
                                                                </DeleteButton>
                                                                <RecoverButton>
                                                                    <Image IconID="actions_reset2_16x16" ToolTip="Reset">
                                                                    </Image>
                                                                </RecoverButton>
                                                            </SettingsCommandButton>
                                                            <SettingsDataSecurity AllowEdit="False" />
                                                            <EditFormLayoutProperties>
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption=" ">
                                                                        <Template>
                                                                            <dx:ASPxGridView ID="gridGapandGoals" runat="server" DataSourceID="sqlGapandGoals" AutoGenerateColumns="False" KeyFieldName="gap_id" Width="100%">
                                                                                <SettingsPager Mode="ShowAllRecords">
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
                                                                                    <dx:GridViewDataTextColumn Caption="Title" FieldName="gap_title" VisibleIndex="2">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                    <dx:GridViewDataTextColumn Caption="Type" FieldName="gap_type" VisibleIndex="3">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                    <dx:GridViewDataTextColumn FieldName="gap_id" Visible="False" VisibleIndex="1">
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
                                                                <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="75px">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataComboBoxColumn FieldName="Title" ShowInCustomizationForm="True" SortIndex="2" SortOrder="Ascending" VisibleIndex="3">
                                                                </dx:GridViewDataComboBoxColumn>
                                                                <dx:GridViewDataTextColumn FieldName="Id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="Type" GroupIndex="0" ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" Visible="False" VisibleIndex="1">
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
                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <SettingsEditing Mode="EditForm">
                            </SettingsEditing>
                            <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" />
                            <SettingsBehavior ConfirmDelete="True" AllowFocusedRow="True" />
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
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="Name">
                                    </dx:GridViewColumnLayoutItem>

                                    <dx:GridViewColumnLayoutItem ColumnName="Start Date">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Estimated End Date">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Target Date 1">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Target Date 2">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Target Date 3">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Status">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Actual End Date">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Review Date">
                                    </dx:GridViewColumnLayoutItem>

                                    <dx:GridViewColumnLayoutItem Caption="Deliverable" ColumnName="Roadmap?">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewTabbedLayoutGroup ColSpan="2" Width="100%">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description" RowSpan="3">
                                                <CaptionSettings Location="Top" />
                                            </dx:GridViewColumnLayoutItem>
                                            <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Review Narrative">
                                            </dx:GridViewColumnLayoutItem>
                                        </Items>
                                    </dx:GridViewTabbedLayoutGroup>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>

                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="ProjectId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Name" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>

                                 <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="True" VisibleIndex="5">
                                    <PropertiesMemoEdit Rows="20">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>
                                <dx:GridViewDataMemoColumn Caption="Review Narrative" FieldName="CMStextReview" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                    <PropertiesMemoEdit Rows="20">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>
                                <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" ShowInCustomizationForm="True" VisibleIndex="7" Width="75px">
                                    <PropertiesDateEdit DisplayFormatString="" EnableFocusedStyle="False">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Estimated End Date" FieldName="EstimatedEndDate" ShowInCustomizationForm="True" VisibleIndex="8" Width="75px">
                                    <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target Date 1" FieldName="TargetDate1" ShowInCustomizationForm="True" VisibleIndex="9" Width="75px" Visible="false">
                                   
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target Date 2" FieldName="TargetDate2" ShowInCustomizationForm="True" VisibleIndex="10" Width="75px" Visible="false">
                                    
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target Date 3" FieldName="TargetDate3" ShowInCustomizationForm="True" VisibleIndex="11" Width="75px" Visible="false">
                                    
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="Status" ShowInCustomizationForm="True" VisibleIndex="12" Width="75px">
                                    <PropertiesComboBox>
                                        <Items>
                                            <dx:ListEditItem Text="Green" Value="#22EA21" />
                                            <dx:ListEditItem Text="Yellow" Value="#F2F91D" />
                                            <dx:ListEditItem Text="Red" Value="#FA3815" />
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>

                                <dx:GridViewDataDateColumn Caption="Actual End Date" FieldName="ActualEndDate" ShowInCustomizationForm="True" VisibleIndex="13" Width="75px">
                                    <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>

                                <dx:GridViewDataDateColumn Caption="Review Date" FieldName="CMSreviewDate" ShowInCustomizationForm="True" VisibleIndex="14" Width="75px">
                                    <PropertiesDateEdit DisplayFormatString="">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>

                                <dx:GridViewDataCheckColumn Caption="Roadmap?" FieldName="Roadmap" ShowInCustomizationForm="True" VisibleIndex="15" Visible="false" Width="50px">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                

                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Text="Gaps/Goals">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridGaps" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridGaps" KeyFieldName="Id" OnRowInserting="gridGaps_RowInserting" Width="100%" OnRowDeleting="gridGaps_RowDeleting" OnRowUpdating="gridGaps_RowUpdating">
                            
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
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                            <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsEditing Mode="PopupEditForm">
                            </SettingsEditing>
                            <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" />
                            <SettingsBehavior ConfirmDelete="True" AllowFocusedRow="true" />
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
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxPageControl ID="tabTasksItems" runat="server" ActiveTabIndex="0" Width="100%">
                                        <TabPages>
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
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Name">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem Caption="Open" ColumnName="Open?">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Type">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Date Identified">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Date Closed">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description" RowSpan="3">
                                        <CaptionSettings Location="Top" />
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="gap_project ID" Visible="False">
                                    </dx:GridViewColumnLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Name" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="4">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Type" FieldName="Type" ShowInCustomizationForm="True" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="ProjectId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Open?" FieldName="Open" ShowInCustomizationForm="True" VisibleIndex="6" Width="50px">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ValueGrayed="False">
                                        <ValidationSettings>
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataDateColumn Caption="Date Identified" FieldName="OpenDate" ShowInCustomizationForm="True" VisibleIndex="7" Width="75px">
                                    <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                                        <ClearButton DisplayMode="Always">
                                        </ClearButton>
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Date Closed" FieldName="CloseDate" ShowInCustomizationForm="True" VisibleIndex="8" Width="75px">
                                    <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                                        <ClearButton DisplayMode="Always">
                                        </ClearButton>
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>

                                <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="True" VisibleIndex="5">
                                    <PropertiesMemoEdit Rows="20">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>
                               
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
