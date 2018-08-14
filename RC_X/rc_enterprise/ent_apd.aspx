<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_apd.aspx.cs" Inherits="RC_X.rc_enterprise.ent_apd" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <dx:ASPxGridView ID="gridAPD" ClientInstanceName="gridAPD" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="Id" OnBatchUpdate="gridAPD_BatchUpdate">
        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
        <SettingsPager Mode="ShowAllRecords"></SettingsPager>
        <SettingsBehavior AllowFocusedRow="true" />
        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />        
       <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
        <settingscontextmenu enablecolumnmenu="True" enabled="True" enablegrouppanelmenu="True" enablerowmenu="True">
        </settingscontextmenu>
        <settingsadaptivity adaptivitymode="HideDataCells">
        </settingsadaptivity>
         <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
         <Toolbars>
         <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                <Items>
               
                    <dx:GridViewToolbarItem Command="Refresh"  Image-IconID="spreadsheet_refreshallpivottable_16x16"/>
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
                 <Image IconID="actions_trash_16x16">
                 </Image>
           </DeleteButton>
        </SettingsCommandButton>    
          <Templates>
            <DetailRow>
                <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                    <TabPages>
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
        
        <Columns>
            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn Caption="APD Type" FieldName="APDtype" ShowInCustomizationForm="True" VisibleIndex="2">
                <PropertiesComboBox TextField="APD Type" ValueField="" ValueType="System.Int32">
                    <Items>
                        <dx:ListEditItem Text="P-APD" Value="0" />
                        <dx:ListEditItem Text="I-APD" Value="1" />
                        <dx:ListEditItem Text="U-APD" Value="2" />
                    </Items>
                </PropertiesComboBox>
            </dx:GridViewDataComboBoxColumn>
             <dx:GridViewDataTextColumn Caption="APD Number" FieldName="APDNumber" ShowInCustomizationForm="True" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="APD Name" FieldName="APDName" ShowInCustomizationForm="True" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="APD Description" FieldName="Description" ShowInCustomizationForm="True" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" ShowInCustomizationForm="True" VisibleIndex="6">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="End Date" FieldName="EndDate" ShowInCustomizationForm="True" VisibleIndex="7">
            </dx:GridViewDataDateColumn>
            
        </Columns>
       
        
        <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true" BatchEditSettings-StartEditAction="DblClick">
            <BatchEditSettings EditMode="Row" StartEditAction="DblClick"></BatchEditSettings>
        </SettingsEditing>
        
        <SettingsBehavior ConfirmDelete="True" />
        <SettingsResizing ColumnResizeMode="Control" />
        
    </dx:ASPxGridView>
</asp:Content>
