<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_IVV.aspx.cs" Inherits="RC_X.rc_enterprise.ent_IVV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxPageControl ID="tabRTM" runat="server" ActiveTabIndex="0" Height="100%" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Name="GeneralInfo" Text="General Info">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridGeneralInfo" runat="server" AutoGenerateColumns="False" KeyFieldName="GeneralInfoID" Width="100%" OnCellEditorInitialize="gridGeneralInfo_CellEditorInitialize"

                            OnRowInserting="gridGeneralInfo_RowInserting" OnRowUpdating="gridGeneralInfo_RowUpdating" OnRowDeleting="gridGeneralInfo_RowDeleting"  PreviewFieldName="ExecutiveSummary">

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

                             <Settings ShowPreview="true" />
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <%--<SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>--%>

                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsText ConfirmDelete="Are you sure you really want to delete this GeneralInfo Item permanently, all data associated with it will be non recoverable" />
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="StateName">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="ProjectName">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="ProgramName" />
                                    <dx:GridViewColumnLayoutItem ColumnName="StatePrimaryPOC">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="StatePrimaryPOCEmail">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="SubmitterName">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="SubmitterRole">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="SubmitterEmail">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="SubmitterPhone">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="ConsultDate">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="RFPReleaseDate" Caption="Target or Actual IV&V RFP Relase Date">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="OnBoardDate" Caption="Target or Actual Date IV&V on Board">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="ProgressReportDate">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="NextProgressDate">
                                    </dx:GridViewColumnLayoutItem>

                                    <dx:GridViewTabbedLayoutGroup ColSpan="2" Width="100%">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="ExecutiveSummary" RowSpan="20">
                                                <CaptionSettings Location="Top" />
                                            </dx:GridViewColumnLayoutItem>

                                        </Items>
                                    </dx:GridViewTabbedLayoutGroup>

                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="GeneralInfoID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="State" FieldName="StateName" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>

                                <dx:GridViewDataTextColumn Caption="Project Name" FieldName="ProjectName" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Program Name" FieldName="ProgramName" ShowInCustomizationForm="True" VisibleIndex="4">

                                   
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="State Primary POC" FieldName="StatePrimaryPOC" ShowInCustomizationForm="True" VisibleIndex="5">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="State Primary POC Email" FieldName="StatePrimaryPOCEmail" ShowInCustomizationForm="True" VisibleIndex="6">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Submitter Name" FieldName="SubmitterName" ShowInCustomizationForm="True" VisibleIndex="7">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Submitter Title/Role" FieldName="SubmitterRole" ShowInCustomizationForm="True" VisibleIndex="8">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Submitter Email" FieldName="SubmitterEmail" ShowInCustomizationForm="True" VisibleIndex="9">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Submitter Phone" FieldName="SubmitterPhone" ShowInCustomizationForm="True" VisibleIndex="10">
                                    
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn Caption="Activity 1 Consult Date" FieldName="ConsultDate" ShowInCustomizationForm="True" VisibleIndex="11" Width="75px">
                                    
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="RFP Release Date" FieldName="RFPReleaseDate" ShowInCustomizationForm="True" VisibleIndex="12" Width="75px">
                                    <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                                        

                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target or on Board Date" FieldName="OnBoardDate" ShowInCustomizationForm="True" VisibleIndex="13" Width="75px">
                                    <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Progress Report Date" FieldName="ProgressReportDate" ShowInCustomizationForm="True" VisibleIndex="14" Width="75px">
                                    <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Next Progress Report Date" FieldName="NextProgressDate" ShowInCustomizationForm="True" VisibleIndex="15" Width="75px">
                                    <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>

                                <dx:GridViewDataMemoColumn Caption="Executive Summary" FieldName="ExecutiveSummary" ShowInCustomizationForm="True"  VisibleIndex="8">
                                    <PropertiesMemoEdit Rows="20">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>


                            </Columns>
                        </dx:ASPxGridView>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="LifeCycleStatus" Text="Life Cycle Status">
                <ContentCollection>
                    <dx:ContentControl runat="server">

                        <dx:ASPxGridView ID="gridLifeCycle" runat="server" AutoGenerateColumns="False" KeyFieldName="LifeCycleStatusID" Width="100%" OnRowInserting="gridLifeCycle_RowInserting" OnRowUpdating="gridLifeCycle_RowUpdating" OnRowDeleting="gridLifeCycle_RowDeleting" OnCellEditorInitialize="gridLifeCycle_CellEditorInitialize">
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
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>

                            <%--<SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>--%>

                            <SettingsPager Mode="ShowAllRecords">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsText ConfirmDelete="Are you sure you really want to delete this project permanently, all data associated with it will be non recoverable" />
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="Module">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="ProjectName">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Status">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="IAPDApprovalDate">
                                    </dx:GridViewColumnLayoutItem>
                                     <dx:GridViewColumnLayoutItem ColumnName="Project">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="R1Date" ClientVisible="false" Visible="false">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="R2Date" ClientVisible="false" Visible="false">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="LiveDate" ClientVisible="false" Visible="false">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="R3Date" ClientVisible="false" Visible="false">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="DevelopmentStartDate" ClientVisible="false" Visible="false">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="LifeCycleStatusID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>

                                <dx:GridViewDataComboBoxColumn Caption="Module" FieldName="Module" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesComboBox>
                                        <Items>
                                            <dx:ListEditItem Value="MITA Business-Aligned Modules" Text="MITA Business-Aligned Modules" />
                                            <dx:ListEditItem Value="MMIS Functional Modules" Text="MMIS Functional Modules" />
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>

                                <dx:GridViewDataTextColumn Caption="Project Name" FieldName="ProjectName" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="" IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Life Cycle Status" FieldName="Status" ShowInCustomizationForm="True" VisibleIndex="4" >
                                    <PropertiesComboBox>
                                        <Items>
                                            <dx:ListEditItem Text="No Plans for Development" Value="No Plans for Development" />
                                            <dx:ListEditItem Text="Pre-R1: Proj.Initiation M.R. Not Done" Value="Pre-R1: Proj.Initiation M.R. Not Done" />
                                            <dx:ListEditItem Text="R1: Proj.Initiation M.R. Completed" Value="R1: Proj.Initiation M.R. Completed" />
                                            <dx:ListEditItem Text="R2: Operational M.R. Completed" Value="R2: Operational M.R. Completed" />
                                            <dx:ListEditItem Text="R3: Cert./Post-Op M.R. Completed" Value="R3: Cert./Post-Op M.R. Completed" />
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataDateColumn Caption="Taget or Actual IAPD Approval Date" FieldName="IAPDApprovalDate" ShowInCustomizationForm="True" VisibleIndex="5">
                                    <PropertiesDateEdit>

                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                 <dx:GridViewDataComboBoxColumn Caption="Rcx Project Name" FieldName="Project" ShowInCustomizationForm="True" VisibleIndex="6">
                                    <PropertiesComboBox>

                                        
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataDateColumn Caption="Target or Actual Development Start Date" FieldName="DevelopmentStartDate" ShowInCustomizationForm="True" VisibleIndex="7">
                                    
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target or Actual Date for R1" FieldName="R1Date" ShowInCustomizationForm="True" VisibleIndex="8" Width="75px">
                                    
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target or Actual Date for R2" FieldName="R2Date" ShowInCustomizationForm="True" VisibleIndex="9" Width="75px">
                                    

                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target or Actual Go-Live Date" FieldName="LiveDate" ShowInCustomizationForm="True" VisibleIndex="10" Width="75px">
                                    <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn Caption="Target or Actual Date for R3" FieldName="R3Date" ShowInCustomizationForm="True" VisibleIndex="11" Width="75px">
                                    <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="PM" Text="IV&V Project Management">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <script type="text/javascript">
                            function OnContactMethodChanged(s, e) {
                                var selectedIndex = s.GetSelectedIndex();
                                UpdateRadioButtonListDecoration(s);
                                tabbedGroupPageControl.SetActiveTabIndex(selectedIndex);
                            }
                            function UpdateRadioButtonListDecoration(radioButtonList) {
                                var selectedIndex = radioButtonList.GetSelectedIndex();
                                for (var i = 0; i < radioButtonList.GetItemCount(); i++)
                                    radioButtonList.GetItemElement(i).parentNode.className = i === selectedIndex ? "selectedElement" : "";
                            }
                            function OnTabbedGroupPageControlInit(s, e) {
                                s.SetActiveTabIndex(radioButtonList.GetSelectedIndex());
                            }
                        </script>
                        <div class="container">
                            <dx:ASPxFormLayout runat="server" AlignItemCaptions="false" Width="100%" ShowItemCaptionColon="false">
                                <Items>
                                    <dx:LayoutItem Caption="Config IV&V Risk and Recomendations through:" CaptionSettings-Location="Top">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxRadioButtonList runat="server" ID="radioButtonList" ClientSideEvents-SelectedIndexChanged="OnContactMethodChanged" ClientSideEvents-Init="UpdateRadioButtonListDecoration" RepeatColumns="2" RepeatLayout="Table"
                                                    SelectedIndex="0" ClientInstanceName="radioButtonList" Width="100%">
                                                    <Items>
                                                        <dx:ListEditItem Text="Risks" Value="0" />
                                                        <dx:ListEditItem Text="Recommendations" Value="1" />
                                                    </Items>
                                                </dx:ASPxRadioButtonList>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:TabbedLayoutGroup Caption="TabbedGroup" ClientInstanceName="tabbedGroupPageControl" ShowGroupDecoration="false" Width="100%">
                                        <ClientSideEvents Init="OnTabbedGroupPageControlInit" />
                                        <Items>
                                            <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top">
                                                <Items>
                                                    <dx:LayoutItem Caption="">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer>
                                                                <dx:ASPxGridView ID="gridRisks" runat="server" AutoGenerateColumns="False" KeyFieldName="RisksID" Width="100%" OnRowInserting="gridRisks_RowInserting" OnRowUpdating="gridRisks_RowUpdating" OnRowDeleting="gridRisks_RowDeleting">
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
                                                                    <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                                    </SettingsContextMenu>

                                                                    <%--<SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                                    </SettingsAdaptivity>--%>

                                                                    <SettingsPager Mode="ShowAllRecords">
                                                                    </SettingsPager>
                                                                    <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                                                                    <SettingsBehavior AllowFocusedRow="true" />
                                                                    <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                                                                    <SettingsBehavior ConfirmDelete="True" />
                                                                    <SettingsText ConfirmDelete="Are you sure you really want to delete this Risk permanently, all data associated with it will be non recoverable" />
                                                                    <EditFormLayoutProperties ColCount="2">
                                                                        <Items>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="UniqueID">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="Title">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="Probability">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="Impact">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="ResolutionDate">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="Status">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            <dx:GridViewTabbedLayoutGroup ColSpan="2" Width="100%">
                                                                                <Items>
                                                                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description" RowSpan="3">
                                                                                        <CaptionSettings Location="Top" />
                                                                                    </dx:GridViewColumnLayoutItem>

                                                                                </Items>
                                                                            </dx:GridViewTabbedLayoutGroup>
                                                                            <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                                                            </dx:EditModeCommandLayoutItem>
                                                                        </Items>
                                                                    </EditFormLayoutProperties>
                                                                    <Columns>
                                                                        <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                                        </dx:GridViewCommandColumn>
                                                                        <dx:GridViewDataTextColumn FieldName="RisksID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Risls ID #" FieldName="UniqueID" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                            <PropertiesTextEdit>
                                                                                <ValidationSettings>
                                                                                    <RequiredField ErrorText="" IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesTextEdit>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Risk Title" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                            <PropertiesTextEdit>
                                                                                <ValidationSettings>
                                                                                    <RequiredField ErrorText="" IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesTextEdit>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataComboBoxColumn Caption="Probability" FieldName="Probability" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                            <PropertiesComboBox>
                                                                                <Items>
                                                                                    <dx:ListEditItem Value="Not Likely" Text="1" />
                                                                                    <dx:ListEditItem Value="Somewhat Likely" Text="2" />
                                                                                    <dx:ListEditItem Value="Likely" Text="3" />
                                                                                    <dx:ListEditItem Value="Certainly" Text="4" />
                                                                                    <dx:ListEditItem Value="Near Certainly" Text="5" />
                                                                                </Items>
                                                                                <ValidationSettings>
                                                                                    <RequiredField IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesComboBox>
                                                                        </dx:GridViewDataComboBoxColumn>
                                                                        <dx:GridViewDataComboBoxColumn Caption="Impact" FieldName="Impact" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                            <PropertiesComboBox>
                                                                                <Items>
                                                                                   <dx:ListEditItem Value="Minimal" Text="1" />
                                                                                    <dx:ListEditItem Value="Marginal" Text="2" />
                                                                                    <dx:ListEditItem Value="Somewhat Serious" Text="3" />
                                                                                    <dx:ListEditItem Value="Serious" Text="4" />
                                                                                    <dx:ListEditItem Value="Catastrophic" Text="5" />
                                                                                </Items>
                                                                                <ValidationSettings>
                                                                                    <RequiredField IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesComboBox>
                                                                        </dx:GridViewDataComboBoxColumn>
                                                                        <dx:GridViewDataDateColumn Caption="Target or Actual Resolution Date" FieldName="ResolutionDate" ShowInCustomizationForm="True" VisibleIndex="6">

                                                                        </dx:GridViewDataDateColumn>
                                                                        <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="Status" ShowInCustomizationForm="True" VisibleIndex="7">
                                                                            <PropertiesComboBox>
                                                                                <Items>
                                                                                    <dx:ListEditItem Text="Open" Value="0" />
                                                                                    <dx:ListEditItem Text="Closed" Value="1" />
                                                                                   
                                                                                </Items>

                                                                            </PropertiesComboBox>
                                                                        </dx:GridViewDataComboBoxColumn>
                                                                        <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                                                                            <PropertiesMemoEdit Rows="20">
                                                                            </PropertiesMemoEdit>
                                                                        </dx:GridViewDataMemoColumn>
                                                                    </Columns>
                                                                </dx:ASPxGridView>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                </Items>
                                            </dx:LayoutGroup>
                                            <dx:LayoutGroup GroupBoxDecoration="None" SettingsItemCaptions-Location="Top">
                                                <Items>
                                                    <dx:LayoutItem Caption="">
                                                        <LayoutItemNestedControlCollection>
                                                            <dx:LayoutItemNestedControlContainer>
                                                               <dx:ASPxGridView ID="gridRecommendations" runat="server" AutoGenerateColumns="False" KeyFieldName="RecommendationID" Width="100%" OnRowInserting="gridRecommendations_RowInserting" OnRowUpdating="gridRecommendations_RowUpdating" OnRowDeleting="gridRecommendations_RowDeleting" PreviewFieldName="Recommendation">
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
                                                                    <Settings ShowPreview="true" />
                                                                    <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                                    </SettingsContextMenu>

                                                                    <%--<SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                                    </SettingsAdaptivity>--%>

                                                                    <SettingsPager Mode="ShowAllRecords">
                                                                    </SettingsPager>
                                                                    <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
                                                                    <SettingsBehavior AllowFocusedRow="true" />
                                                                   <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                                                                    <SettingsBehavior ConfirmDelete="True" />
                                                                    <SettingsText ConfirmDelete="Are you sure you really want to delete this Recommendation permanently" />
                                                                    <EditFormLayoutProperties ColCount="2">
                                                                        <Items>
                                                                            <dx:GridViewColumnLayoutItem ColumnName="RecommendationId">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            
                                                                            <dx:GridViewColumnLayoutItem ColumnName="Resolved">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            
                                                                            <dx:GridViewColumnLayoutItem ColumnName="RecommendationDate">
                                                                            </dx:GridViewColumnLayoutItem>
                                                                            
                                                                            <dx:GridViewTabbedLayoutGroup ColSpan="2" Width="100%">
                                                                                <Items>
                                                                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Comments" RowSpan="3">
                                                                                        <CaptionSettings Location="Top" />
                                                                                    </dx:GridViewColumnLayoutItem>
                                                                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Recommendation" RowSpan="3">
                                                                                        <CaptionSettings Location="Top" />
                                                                                    </dx:GridViewColumnLayoutItem>

                                                                                </Items>
                                                                            </dx:GridViewTabbedLayoutGroup>
                                                                            <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                                                            </dx:EditModeCommandLayoutItem>
                                                                        </Items>
                                                                    </EditFormLayoutProperties>
                                                                    <Columns>
                                                                        <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                                        </dx:GridViewCommandColumn>
                                                                        <dx:GridViewDataTextColumn FieldName="RecommendationID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataTextColumn Caption="Recommendation#" FieldName="RecommendationId" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                            <PropertiesTextEdit>
                                                                                <ValidationSettings>
                                                                                    <RequiredField ErrorText="" IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesTextEdit>
                                                                        </dx:GridViewDataTextColumn>
                                                                        <dx:GridViewDataMemoColumn Caption="Recommendation" FieldName="Recommendation" ShowInCustomizationForm="True" VisibleIndex="3" Visible="false">
                                                                            <PropertiesMemoEdit Rows="20">
                                                                            </PropertiesMemoEdit>
                                                                        </dx:GridViewDataMemoColumn>
                                                                        <dx:GridViewDataComboBoxColumn Caption="Resolved?" FieldName="Resolved" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                            <PropertiesComboBox>
                                                                                <Items>
                                                                                    <dx:ListEditItem Text="Yes" Value="1" />
                                                                                    <dx:ListEditItem Text="No" Value="2" />
                                                                                    
                                                                                </Items>
                                                                                <ValidationSettings>
                                                                                    <RequiredField IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesComboBox>
                                                                        </dx:GridViewDataComboBoxColumn>
                                                                       
                                                                        <dx:GridViewDataDateColumn Caption="Date of Recommendation" FieldName="RecommendationDate" ShowInCustomizationForm="True" VisibleIndex="5">
                                                                            <PropertiesDateEdit>
                                                                                <ValidationSettings>
                                                                                    <RequiredField ErrorText="" IsRequired="True" />
                                                                                </ValidationSettings>
                                                                            </PropertiesDateEdit>
                                                                        </dx:GridViewDataDateColumn>
                                                                        
                                                                        <dx:GridViewDataMemoColumn Caption="Comments/Resolution" FieldName="Comments" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                                                            <PropertiesMemoEdit Rows="20">
                                                                            </PropertiesMemoEdit>
                                                                        </dx:GridViewDataMemoColumn>
                                                                    </Columns>
                                                                </dx:ASPxGridView>
                                                            </dx:LayoutItemNestedControlContainer>
                                                        </LayoutItemNestedControlCollection>
                                                    </dx:LayoutItem>
                                                </Items>
                                            </dx:LayoutGroup>
                                        </Items>
                                    </dx:TabbedLayoutGroup>

                                </Items>
                            </dx:ASPxFormLayout>
                        </div>
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
