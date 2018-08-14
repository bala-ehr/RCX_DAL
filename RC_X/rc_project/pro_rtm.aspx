<%@ Page Title="RTM" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pro_rtm.aspx.cs" Inherits="RC_X.pro_rtm" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges.Gauges" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges.Gauges.State" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        var postponedCallbackRequired = false;
        function OnDropdownIndexChanged(s, e) {
            if (mainCallbackPanel.InCallback())
                postponedCallbackRequired = true;
            else
                mainCallbackPanel.PerformCallback();
        }
        function OnEndCallback(s, e) {
            if (postponedCallbackRequired) {
                mainCallbackPanel.PerformCallback();
                postponedCallbackRequired = false;
            }
        }
       
    </script>
    <dx:ASPxCallbackPanel ID="mainCallbackPanel" runat="server" ClientInstanceName="mainCallbackPanel" EnableClientSideAPI="True" Width="100%" HideContentOnCallback="false">
        <PanelCollection>
            <dx:PanelContent CssClass="main-content">


                <dx:ASPxGridView ID="gridRTM" ClientInstanceName="gridRTM" runat="server" AutoGenerateColumns="False" KeyFieldName="CriteriaId" Width="100%" OnDetailRowExpandedChanged="gridRTM_DetailRowExpandedChanged">
                    <Toolbars>
                        <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                            <Items>

                                <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
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
                                        <dx:ASPxButtonEdit ID="ASPxButtonEdit1" runat="server" NullText="Search..." Height="100%" Width="300px">
                                            <Buttons>
                                                <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                            </Buttons>
                                        </dx:ASPxButtonEdit>
                                    </Template>
                                </dx:GridViewToolbarItem>--%>
                            </Items>
                        </dx:GridViewToolbar>
                    </Toolbars>
                    <SettingsContextMenu Enabled="True">
                    </SettingsContextMenu>
                    <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="700" />
                    <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                    <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>
                    <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowGroupedColumns="False" ShowGroupPanel="True" />
                    <SettingsBehavior AllowFocusedRow="True" AllowSelectSingleRowOnly="True" AllowFixedGroups="True" AutoExpandAllGroups="True" EnableCustomizationWindow="False" />
                    <SettingsResizing ColumnResizeMode="Control" />
                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                    <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false" />
                    <%--CustomEditorID="tbToolbarSearch"--%>
                    <Templates>
                        <DetailRow>
                            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
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
                                                                                <br/>
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
                                    <dx:TabPage Text="Responses">
                                        <ContentCollection>
                                            <dx:ContentControl runat="server">
                                                <div>

                                                    <dx:ASPxGridView ID="gridResponse" runat="server" AutoGenerateColumns="False" KeyFieldName="ResponseID" Width="100%" OnCellEditorInitialize="gridResponse_CellEditorInitialize" OnBeforePerformDataSelect="gridResponse_BeforePerformDataSelect" OnRowInserting="gridResponse_RowInserting" OnRowUpdating="gridResponse_RowUpdating">
                                                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                                                        <%--<Templates>
                                                        <DetailRow>
                                                            <dx:ASPxHtmlEditor ID="txResponse" runat="server" Html='<%# Eval("Response") %>' Width="100%">
                                                                <settings allowhtmlview="False" allowpreview="False">
                                                                </settings>
                                                            </dx:ASPxHtmlEditor>
                                                        </DetailRow>
                                                    </Templates>--%>
                                                        <SettingsEditing Mode="EditForm">
                                                        </SettingsEditing>
                                                        <Settings ShowFilterBar="Auto" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowPreview="True" UseFixedTableLayout="True" />

                                                        <SettingsResizing ColumnResizeMode="Control" />

                                                        <SettingsCookies Enabled="True" />

                                                        <SettingsCommandButton RenderMode="Link">
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
                                                        <SettingsDataSecurity AllowDelete="False" />
                                                        <EditFormLayoutProperties ColCount="2">
                                                            <Items>
                                                                <dx:GridViewColumnLayoutItem ColumnName="Assesment" Caption="Choose New Assesment" ColSpan="2">
                                                                    <%--<Template>
                                                                    <dx:ASPxComboBox ID="dropAssessment" runat="server" Caption="Assessment" Width="100%" ClientInstanceName="dropAssessment" OnInit="dropAssessment_Init" EnableClientSideAPI="True" TextField="Name" ValueField="Description">
                                                                    </dx:ASPxComboBox>
                                                                </Template>--%>
                                                                </dx:GridViewColumnLayoutItem>

                                                                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Comments">
                                                                    <Template>
                                                                        <dx:ASPxHtmlEditor ID="txResponse" Html='<%# Eval("Response") %>' runat="server" Width="100%">
                                                                            <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False">
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
                                                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                            </dx:GridViewCommandColumn>
                                                            <dx:GridViewDataTextColumn FieldName="ResponseID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn FieldName="ItemKey" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataComboBoxColumn Caption="Compliance" FieldName="Assesment" Visible="true" VisibleIndex="5" Width="100px">
                                                                <%--<PropertiesComboBoxEdit>
                                                                <ValidationSettings>
                                                                    <RequiredField IsRequired="True" />
                                                                </ValidationSettings>
                                                            </PropertiesComboBoxEdit>--%>
                                                                <PropertiesComboBox IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList">
                                                                    <ClearButton DisplayMode="OnHover" />
                                                                </PropertiesComboBox>
                                                            </dx:GridViewDataComboBoxColumn>
                                                            <dx:GridViewDataTextColumn FieldName="Response" ShowInCustomizationForm="True" VisibleIndex="5" Caption="Description">
                                                                <PropertiesTextEdit EncodeHtml="False">
                                                                </PropertiesTextEdit>
                                                            </dx:GridViewDataTextColumn>

                                                        </Columns>
                                                    </dx:ASPxGridView>
                                                </div>
                                            </dx:ContentControl>
                                        </ContentCollection>
                                    </dx:TabPage>
                                    <dx:TabPage Text="Evaluation">
                                        <ContentCollection>
                                            <dx:ContentControl runat="server">

                                                <dx:ASPxGridView ID="gridEvaluation" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="eval_id" OnBeforePerformDataSelect="gridEvaluation_BeforePerformDataSelect" OnRowInserting="gridEvaluation_RowInserting">
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

                                                    <Columns>
                                                        <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_responseID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="eval_by" ShowInCustomizationForm="True" VisibleIndex="3">

                                                            <EditFormSettings Visible="False" />
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataDateColumn Caption="Reviewer Date" FieldName="eval_date" ShowInCustomizationForm="True" VisibleIndex="4">
                                                            <PropertiesDateEdit DisplayFormatString="yyyy/MM/dd hh:mm:ss">
                                                            </PropertiesDateEdit>
                                                        </dx:GridViewDataDateColumn>
                                                        <dx:GridViewDataComboBoxColumn Caption="Reviewer Assessment" FieldName="eval_reviewer_assessments" ShowInCustomizationForm="True" VisibleIndex="5">
                                                            <PropertiesComboBox TextField="Reviewer Assesment" ValueField="eval_reviewer_assessments">
                                                                <Items>
                                                                    <dx:ListEditItem Text="Meets" Value="0" />
                                                                    <dx:ListEditItem Text="Partialy Meets" Value="1" />
                                                                    <dx:ListEditItem Text="Doesn't Meets" Value="2" />
                                                                    <dx:ListEditItem Text="Not Assessed" Value="3" />
                                                                </Items>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataTextColumn Caption="Reviewer Comments" FieldName="eval_description" ShowInCustomizationForm="True" VisibleIndex="6">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_projectID" ShowInCustomizationForm="True" VisibleIndex="7" Visible="false">
                                                        </dx:GridViewDataTextColumn>
                                                    </Columns>
                                                    <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                                    <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                                    <SettingsBehavior AllowFocusedRow="true" />
                                                    <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
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
                                                    <EditFormLayoutProperties ColCount="2">
                                                        <Items>
                                                            <dx:GridViewLayoutGroup ColCount="2" GroupBoxDecoration="None">
                                                                <Items>
                                                                    <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_by" Width="100%" />--%>
                                                                    <dx:GridViewColumnLayoutItem ColumnName="eval_reviewer_assessments" Width="100%" />
                                                                    <dx:GridViewColumnLayoutItem Caption="Reviewer Comments" Width="100%" VerticalAlign="Top" ColumnName="eval_description">
                                                                        <Template>
                                                                            <dx:ASPxMemo ID="reviewerComments" runat="server" Width="100%" Height="253" Text='<%# Bind("[eval_description]") %>' />

                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                </Items>
                                                            </dx:GridViewLayoutGroup>
                                                            <dx:GridViewLayoutGroup GroupBoxDecoration="None">
                                                                <Items>
                                                                    <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_date"/>--%>
                                                                    <dx:GridViewColumnLayoutItem Caption="Reviewer Date" VerticalAlign="Top">
                                                                        <Template>
                                                                            <div>
                                                                                <%-- <dx:ASPxCalendar ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>' CssClass="hireDateCalendar" />--%>
                                                                                <dx:ASPxDateEdit ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>'>
                                                                                    <TimeSectionProperties Adaptive="true">
                                                                                        <TimeEditProperties EditFormatString="hh:mm tt" />
                                                                                    </TimeSectionProperties>
                                                                                    <CalendarProperties>
                                                                                        <FastNavProperties DisplayMode="Popup" />
                                                                                    </CalendarProperties>
                                                                                </dx:ASPxDateEdit>
                                                                            </div>
                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                </Items>
                                                            </dx:GridViewLayoutGroup>
                                                            <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                                        </Items>
                                                        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                                                    </EditFormLayoutProperties>
                                                </dx:ASPxGridView>

                                            </dx:ContentControl>
                                        </ContentCollection>
                                    </dx:TabPage>

                                </TabPages>
                            </dx:ASPxPageControl>
                        </DetailRow>
                    </Templates>
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="CriteriaId" Visible="false" VisibleIndex="0" />
                        <dx:GridViewDataTextColumn Caption="CheckList Type" FieldName="ChecklistType" GroupIndex="0" CellStyle-Font-Bold="true" VisibleIndex="1">
                            <CellStyle Font-Bold="True"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="CheckList Title" FieldName="ChecklistTitle" GroupIndex="1" CellStyle-Font-Bold="true" VisibleIndex="2">
                            <CellStyle Font-Bold="True"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Objective Name" FieldName="ObjectiveName" GroupIndex="2" VisibleIndex="3" />
                        <dx:GridViewDataTextColumn Caption="SRC ID" FieldName="CriteriaTitle" VisibleIndex="4" Width="100px" SortIndex="2" SortOrder="Ascending" />
                        <dx:GridViewDataTextColumn Caption="Criteria" FieldName="Criteria" VisibleIndex="5" />
                        <dx:GridViewDataTextColumn FieldName="Compliance" Caption="Compliance" VisibleIndex="8" Width="150px">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="AssignedTo" Caption="Assigned To" VisibleIndex="6" Width="150px">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="AssignedStatus" Caption="Assigned Status" VisibleIndex="7" Width="150px">
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataComboBoxColumn Caption="Reviewer Assessment" FieldName="ReviwerAssessment" ShowInCustomizationForm="True" VisibleIndex="9" Width="150px">
                            <PropertiesComboBox TextField="Reviewer Assesment" ValueField="ReviwerAssessment">
                                <Items>
                                    <dx:ListEditItem Text="Meets" Value="0" />
                                    <dx:ListEditItem Text="Partialy Meets" Value="1" />
                                    <dx:ListEditItem Text="Doesn't Meets" Value="2" />
                                    <dx:ListEditItem Text="Not Assessed" Value="3" />
                                </Items>
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>
                        <dx:GridViewDataColumn FieldName="ResponsesId" Visible="false" VisibleIndex="10" />
                        <dx:GridViewDataColumn FieldName="MilestoneId" Visible="false" VisibleIndex="11" />
                    </Columns>
                </dx:ASPxGridView>

                <dx:ASPxGridView ID="gridIVVRTM" ClientInstanceName="gridIVVRTM" runat="server" AutoGenerateColumns="False" KeyFieldName="CriteriaId" Width="100%" Visible="false">
                    <Toolbars>
                        <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                            <Items>

                                <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
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
                                <dx:GridViewToolbarItem BeginGroup="true">
                                    <ItemStyle Width="250px" />
                                    <Template>
                                        <dx:ASPxButtonEdit ID="ASPxButtonEdit1" runat="server" NullText="Search..." Height="100%" Width="300px">
                                            <Buttons>
                                                <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                            </Buttons>
                                        </dx:ASPxButtonEdit>
                                    </Template>
                                </dx:GridViewToolbarItem>
                            </Items>
                        </dx:GridViewToolbar>
                    </Toolbars>
                    <Templates>
                        <DetailRow>
                            <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
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
                                    <dx:TabPage Text="Evaluation">
                                        <ContentCollection>
                                            <dx:ContentControl runat="server">

                                                <dx:ASPxGridView ID="gridEvaluation" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="eval_id" OnBeforePerformDataSelect="gridEvaluation_BeforePerformDataSelect" OnRowInserting="gridEvaluation_RowInserting">
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

                                                    <Columns>
                                                        <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                        </dx:GridViewCommandColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_responseID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="eval_by" ShowInCustomizationForm="True" VisibleIndex="3">

                                                            <EditFormSettings Visible="False" />
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataDateColumn Caption="Reviewer Date" FieldName="eval_date" ShowInCustomizationForm="True" VisibleIndex="4">
                                                            <PropertiesDateEdit DisplayFormatString="yyyy/MM/dd hh:mm:ss">
                                                            </PropertiesDateEdit>
                                                        </dx:GridViewDataDateColumn>
                                                        <dx:GridViewDataComboBoxColumn Caption="Reviewer Assessment" FieldName="eval_reviewer_assessments" ShowInCustomizationForm="True" VisibleIndex="5">
                                                            <PropertiesComboBox TextField="Reviewer Assesment" ValueField="eval_reviewer_assessments">
                                                                <Items>
                                                                    <dx:ListEditItem Text="Meets" Value="0" />
                                                                    <dx:ListEditItem Text="Partialy Meets" Value="1" />
                                                                    <dx:ListEditItem Text="Doesn't Meets" Value="2" />
                                                                    <dx:ListEditItem Text="Not Assessed" Value="3" />
                                                                </Items>
                                                            </PropertiesComboBox>
                                                        </dx:GridViewDataComboBoxColumn>
                                                        <dx:GridViewDataTextColumn Caption="Reviewer Comments" FieldName="eval_description" ShowInCustomizationForm="True" VisibleIndex="6">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="eval_projectID" ShowInCustomizationForm="True" VisibleIndex="7" Visible="false">
                                                        </dx:GridViewDataTextColumn>
                                                    </Columns>
                                                    <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                                    <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                                    <SettingsBehavior AllowFocusedRow="true" />
                                                    <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
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
                                                    <EditFormLayoutProperties ColCount="2">
                                                        <Items>
                                                            <dx:GridViewLayoutGroup ColCount="2" GroupBoxDecoration="None">
                                                                <Items>
                                                                    <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_by" Width="100%" />--%>
                                                                    <dx:GridViewColumnLayoutItem ColumnName="eval_reviewer_assessments" Width="100%" />
                                                                    <dx:GridViewColumnLayoutItem Caption="Reviewer Comments" Width="100%" VerticalAlign="Top" ColumnName="eval_description">
                                                                        <Template>
                                                                            <dx:ASPxMemo ID="reviewerComments" runat="server" Width="100%" Height="253" Text='<%# Bind("[eval_description]") %>' />

                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                </Items>
                                                            </dx:GridViewLayoutGroup>
                                                            <dx:GridViewLayoutGroup GroupBoxDecoration="None">
                                                                <Items>
                                                                    <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_date"/>--%>
                                                                    <dx:GridViewColumnLayoutItem Caption="Reviewer Date" VerticalAlign="Top">
                                                                        <Template>
                                                                            <div>
                                                                                <%-- <dx:ASPxCalendar ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>' CssClass="hireDateCalendar" />--%>
                                                                                <dx:ASPxDateEdit ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>'>
                                                                                    <TimeSectionProperties Adaptive="true">
                                                                                        <TimeEditProperties EditFormatString="hh:mm tt" />
                                                                                    </TimeSectionProperties>
                                                                                    <CalendarProperties>
                                                                                        <FastNavProperties DisplayMode="Popup" />
                                                                                    </CalendarProperties>
                                                                                </dx:ASPxDateEdit>
                                                                            </div>
                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                </Items>
                                                            </dx:GridViewLayoutGroup>
                                                            <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                                        </Items>
                                                        <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                                                    </EditFormLayoutProperties>
                                                </dx:ASPxGridView>

                                            </dx:ContentControl>
                                        </ContentCollection>
                                    </dx:TabPage>

                                </TabPages>
                            </dx:ASPxPageControl>
                        </DetailRow>
                    </Templates>
                    <SettingsContextMenu Enabled="True">
                    </SettingsContextMenu>
                    <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                    <SettingsPager EnableAdaptivity="true" Mode="ShowAllRecords"></SettingsPager>
                     <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="700" />
                    <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowGroupedColumns="False" ShowGroupPanel="True" />
                    <SettingsBehavior AllowFocusedRow="True" AllowSelectSingleRowOnly="True" AllowFixedGroups="True" AutoExpandAllGroups="True" EnableCustomizationWindow="False" />
                    <SettingsResizing ColumnResizeMode="Control" />
                    <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="CriteriaId" Visible="false" VisibleIndex="0" />
                        <dx:GridViewDataTextColumn Caption="CheckList Type" FieldName="ChecklistType" GroupIndex="0" CellStyle-Font-Bold="true" VisibleIndex="1">
                            <CellStyle Font-Bold="True"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="CheckList Title" FieldName="ChecklistTitle" GroupIndex="1" CellStyle-Font-Bold="true" VisibleIndex="2">
                            <CellStyle Font-Bold="True"></CellStyle>
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Objective Name" FieldName="ObjectiveName" GroupIndex="1" VisibleIndex="3" />
                        <dx:GridViewDataTextColumn Caption="SRC ID" FieldName="CriteriaTitle" VisibleIndex="4" Width="100px" SortIndex="2" SortOrder="Ascending" />

                        <dx:GridViewDataTextColumn Caption="Criteria" FieldName="Criteria" VisibleIndex="5" />
                        <dx:GridViewDataTextColumn FieldName="AssignedTo" Caption="Assigned To" VisibleIndex="6" Width="150px">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="AssignedStatus" Caption="Assigned Status" VisibleIndex="7" Width="150px">
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataComboBoxColumn Caption="Reviewer Assessment" FieldName="ReviwerAssessment" ShowInCustomizationForm="True" VisibleIndex="8" Width="150px">
                            <PropertiesComboBox TextField="Reviewer Assesment" ValueField="ReviwerAssessment">
                                <Items>
                                    <dx:ListEditItem Text="Meets" Value="0" />
                                    <dx:ListEditItem Text="Partialy Meets" Value="1" />
                                    <dx:ListEditItem Text="Doesn't Meets" Value="2" />
                                    <dx:ListEditItem Text="Not Assessed" Value="3" />
                                </Items>
                            </PropertiesComboBox>
                        </dx:GridViewDataComboBoxColumn>


                        <dx:GridViewDataColumn FieldName="ResponsesId" Visible="false" VisibleIndex="9" />
                        <dx:GridViewDataColumn FieldName="MilestoneId" Visible="false" VisibleIndex="10" />

                    </Columns>
                </dx:ASPxGridView>

            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>

</asp:Content>
