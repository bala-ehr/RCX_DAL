<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="rc_components.aspx.cs" Inherits="RC_X.rc_enterprise.rc_components" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function OnCallbackComplete(s, e) {
            gridProjectLevel.PerformCallback('databind');
        }
    </script>

    <dx:ASPxPageControl ID="tabRTM" runat="server" ActiveTabIndex="0" Height="100%" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Name="Enterprise Components" Text="Enterprise Level">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlComponentType" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT type_title FROM rc_types where type_home = 'com_type' "></asp:SqlDataSource>
                        <asp:SqlDataSource ID="sqlComponentMode" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT type_title FROM rc_types where type_home = 'com_mode' "></asp:SqlDataSource>
                        <asp:SqlDataSource ID="sqlComponentLocation" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT type_title FROM rc_types where type_home = 'com_loc'  "></asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridEnterpriseLevel" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ComponentId" PreviewFieldName="Notes"
                            OnRowInserting="gridEnterpriseLevel_RowInserting" OnRowUpdating="gridEnterpriseLevel_RowUpdating" OnRowDeleting="gridEnterpriseLevel_RowDeleting">
                            <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                            <ClientSideEvents EndCallback="OnCallbackComplete"></ClientSideEvents>
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                                        <TabPages>
                                            <dx:TabPage Text="Component Projects">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="sqlProjects" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlProjects_Init"
                                                            SelectCommand="select pro_ID, pro_name from rc_projects where pro_ID not in (select distinct rc_comp_project_projectId from [dbo].[rc_component_project] cp where rc_comp_project_compId = @ComponentId AND rc_comp_project_deleted = 0)">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>
                                                       
                                                        <dx:ASPxGridView ID="gridEnterpriseLevelProjects" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="rc_comp_project_id"
                                                             OnBeforePerformDataSelect="gridEnterpriseLevelProjects_BeforePerformDataSelect"
                                                            OnRowInserting="gridEnterpriseLevelProjects_RowInserting">

                                                            <Settings ShowPreview="true" />
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
                                                            <EditFormLayoutProperties>
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption=" ">
                                                                        <Template>
                                                                            <dx:ASPxGridView ID="gridprojects" runat="server" DataSourceID="sqlProjects" AutoGenerateColumns="False" KeyFieldName="pro_ID" Width="100%">
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
                                                                                    <dx:GridViewDataTextColumn Caption="ProjectName" FieldName="pro_name" VisibleIndex="2">
                                                                                    </dx:GridViewDataTextColumn>

                                                                                    <dx:GridViewDataTextColumn FieldName="pro_ID" Visible="False" VisibleIndex="1">
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
                                                                <dx:GridViewCommandColumn ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                                                </dx:GridViewCommandColumn>

                                                                <dx:GridViewDataTextColumn Caption="Projects" FieldName="pro_name" ShowInCustomizationForm="True" VisibleIndex="1">
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
                            <Columns>
                                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                </dx:GridViewCommandColumn>

                                <dx:GridViewDataTextColumn FieldName="ComponentName" Caption="Component Name" ShowInCustomizationForm="True" VisibleIndex="1">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="ComponentType" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesComboBox DataSourceID="sqlComponentType" TextField="type_title" ValueField="type_title">

                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                    <EditFormSettings Caption="Choose Type" />
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Mode" FieldName="ComponentMode" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesComboBox DataSourceID="sqlComponentMode" TextField="type_title" ValueField="type_title">

                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                    <EditFormSettings Caption="Choose Type" />
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataDateColumn FieldName="StartDate" Caption="Start Date" VisibleIndex="4" Visible="false">
                                    <PropertiesDateEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn FieldName="EndDate" Caption="End Date" Visible="false" VisibleIndex="5">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Location" FieldName="ComponentLocation" ShowInCustomizationForm="True" Visible="false" VisibleIndex="6">
                                    <PropertiesComboBox DataSourceID="sqlComponentLocation" TextField="type_title" ValueField="type_title">

                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                    <EditFormSettings Caption="Choose Type" />
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="SerialNumber" Caption="Serial/Version Number" Visible="false" VisibleIndex="7">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Test" FieldName="ComponentTest" ShowInCustomizationForm="True" Visible="false" VisibleIndex="8">
                                    <PropertiesComboBox TextField="Test" ValueField="ComponentTest">
                                        <Items>
                                            <dx:ListEditItem Text="Contingency" Value="0" />
                                            <dx:ListEditItem Text="Disaster Recovery" Value="1" /> 
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>

                            </Columns>
                            <Settings ShowPreview="true" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
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

                                                <dx:GridViewToolbarItem Command="ExportToXls" />
                                            </Items>
                                            <Image IconID="actions_download_16x16office2013"></Image>
                                        </dx:GridViewToolbarItem>
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
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewLayoutGroup ColCount="2" GroupBoxDecoration="None">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColumnName="ComponentName" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="ComponentType" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="ComponentMode" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="ComponentLocation" Width="100%" />
                                        </Items>
                                    </dx:GridViewLayoutGroup>
                                    <dx:GridViewLayoutGroup GroupBoxDecoration="None">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColumnName="Test" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="SerialNumber" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="StartDate" />
                                            <dx:GridViewColumnLayoutItem ColumnName="EndDate" />
                                        </Items>
                                    </dx:GridViewLayoutGroup>
                                    <dx:GridViewColumnLayoutItem Caption="Notes" Width="100%" VerticalAlign="Top" ColumnName="Notes">
                                        <Template>
                                            <dx:ASPxMemo ID="notes" runat="server" Width="100%" Height="253" Text='<%# Bind("Notes") %>' />
                                        </Template>
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                </Items>
                                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                            </EditFormLayoutProperties>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>

            <dx:TabPage Name="Project Components" Text="Project Level">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridProjectLevel" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="ComponentId"
                            PreviewFieldName="Notes" OnCustomCallback="gridProjectLevel_CustomCallback">
                            <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                                        <TabPages>
                                            <dx:TabPage Text="Component BA">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="sqlBArea" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlArea_Init"
                                                            SelectCommand="SELECT [area_id],[area_identifier] ,[area_name] FROM [dbo].[rc_assessment_areas] where area_deleted = 0 AND [area_id] not in (select distinct rc_comp_area_areaId from [dbo].[rc_component_area] cp where rc_comp_area_compId = @ComponentId AND rc_comp_area_deleted = 0 )">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>
                                                        
                                                        <dx:ASPxGridView ID="gridComponentArea" runat="server" AutoGenerateColumns="False"  KeyFieldName="rc_comp_area_id" Width="100%"
                                                            ClientInstanceName="gridComponentArea" OnBeforePerformDataSelect="gridComponentArea_BeforePerformDataSelect" OnRowInserting="gridComponentArea_RowInserting">
                                                            <Settings ShowPreview="true" />
                                                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                                            <SettingsBehavior AllowFocusedRow="true" />
                                                            <%--<SettingsSearchPanel CustomEditorID="tbToolbarSearch" />--%>
                                                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                                            
                                                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                            </SettingsContextMenu>
                                                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                            </SettingsAdaptivity>
                                                            <Toolbars>
                                                                <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                                    <Items>

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
                                                            <EditFormLayoutProperties>
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption=" ">
                                                                        <Template>
                                                                            <dx:ASPxGridView ID="gridArea" runat="server" DataSourceID="sqlBArea" AutoGenerateColumns="False" KeyFieldName="area_id" Width="100%">
                                                                                <SettingsPager PageSize="15">
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
                                                                                    <dx:GridViewDataTextColumn Caption="UniqueId" FieldName="area_identifier" VisibleIndex="2">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                    <dx:GridViewDataTextColumn Caption="Area Name" FieldName="area_name" VisibleIndex="3">
                                                                                    </dx:GridViewDataTextColumn>

                                                                                    <dx:GridViewDataTextColumn FieldName="area_id" Visible="False" VisibleIndex="1">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                </Columns>
                                                                            </dx:ASPxGridView>
                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                    <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                                                </Items>
                                                                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                                                            </EditFormLayoutProperties>
                                                            <Columns>
                                                                <dx:GridViewDataTextColumn FieldName="rc_comp_area_id" Visible="false" VisibleIndex="1" />

                                                                <dx:GridViewDataTextColumn Caption="UniqueID" FieldName="area_identifier" ShowInCustomizationForm="True" VisibleIndex="1">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Area Name" FieldName="area_name" ShowInCustomizationForm="True" VisibleIndex="1">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                                </dx:GridViewCommandColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </dx:ContentControl>
                                                </ContentCollection>
                                            </dx:TabPage>
                                            <dx:TabPage Text="Component BPM">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="SqlBusinessProcesses" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlProcesses_Init"
                                                            SelectCommand="SELECT  [bp_id] ,[bp_identifier] ,[bp_name] FROM [dbo].[rc_assessment_processes] where bp_deleted = 0 AND [bp_id] not in (select distinct rc_comp_process_processId from [dbo].[rc_component_process] cp where rc_comp_process_compId = @ComponentId AND rc_comp_process_deleted = 0)">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>

                                                        
                                                        <dx:ASPxGridView ID="gridComponentProcesses" runat="server" AutoGenerateColumns="False"  KeyFieldName="rc_comp_process_id" Width="100%"
                                                            ClientInstanceName="gridComponentProcesses" OnBeforePerformDataSelect="gridComponentProcesses_BeforePerformDataSelect" OnRowInserting="gridComponentProcesses_RowInserting">
                                                            <Settings ShowPreview="true" />
                                                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                                            <SettingsBehavior AllowFocusedRow="true" />
                                                            <%--<SettingsSearchPanel CustomEditorID="tbToolbarSearch" />--%>
                                                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                                            
                                                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                            </SettingsContextMenu>
                                                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                            </SettingsAdaptivity>
                                                            <Toolbars>
                                                                <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                                    <Items>

                                                                        <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />

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
                                                            <EditFormLayoutProperties>
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption=" ">
                                                                        <Template>
                                                                            <dx:ASPxGridView ID="gridProcesses" runat="server" DataSourceID="SqlBusinessProcesses" AutoGenerateColumns="False" KeyFieldName="bp_id" Width="100%">
                                                                                <SettingsPager PageSize="15">
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
                                                                                    <dx:GridViewDataTextColumn Caption="UniqueId" FieldName="bp_identifier" VisibleIndex="2">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                    <dx:GridViewDataTextColumn Caption="BP Name" FieldName="bp_name" VisibleIndex="3">
                                                                                    </dx:GridViewDataTextColumn>

                                                                                    <dx:GridViewDataTextColumn FieldName="bp_id" Visible="False" VisibleIndex="1">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                </Columns>
                                                                            </dx:ASPxGridView>
                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                    <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                                                </Items>
                                                                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                                                            </EditFormLayoutProperties>
                                                            <Columns>
                                                                <dx:GridViewDataTextColumn FieldName="rc_comp_process_id" Visible="false" VisibleIndex="1" />

                                                                <dx:GridViewDataTextColumn Caption="UniqueID" FieldName="bp_identifier" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="BP Name" FieldName="bp_name" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                                </dx:GridViewCommandColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </dx:ContentControl>
                                                </ContentCollection>
                                            </dx:TabPage>
                                            <dx:TabPage Text="Component RTM">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="SqlRTM" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlRTM_Init"
                                                            SelectCommand="SELECT  [src_id],[src_title]  FROM [dbo].[rc_rtm_criteria] where src_deleted = 0 AND [src_id] not in (select distinct rc_comp_criteria_criteriaId from [dbo].[rc_component_criteria] cp where rc_comp_criteria_compId = @ComponentId AND rc_comp_criteria_deleted = 0)">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>
                                                        <asp:SqlDataSource ID="sqlComponentRTMItem" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>"
                                                            SelectCommand="select rc_comp_criteria_id,src_title  from [dbo].[rc_component_criteria] cc inner join [dbo].[rc_rtm_criteria] bp on cc.rc_comp_criteria_criteriaId = src_id  where cc.rc_comp_criteria_compId = @ComponentId AND rc_comp_criteria_deleted = 0"
                                                            InsertCommand="INSERT INTO [dbo].[rc_component_process] VALUES(NEWID(), @componentId, @RTMId)">
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                            </SelectParameters>
                                                            <InsertParameters>
                                                                <asp:SessionParameter Name="ComponentId" SessionField="ComponentId" DbType="String" />
                                                                <asp:Parameter Name="RTMId" />
                                                            </InsertParameters>

                                                        </asp:SqlDataSource>
                                                        <dx:ASPxGridView ID="gridComponentRTMItem" runat="server" AutoGenerateColumns="False" KeyFieldName="rc_comp_criteria_id" Width="100%"
                                                            ClientInstanceName="gridComponentRTMItem" OnBeforePerformDataSelect="gridComponentRTMItem_BeforePerformDataSelect" OnRowInserting="gridComponentRTMItem_RowInserting" OnInit="gridComponentRTMItem_Init">
                                                            <Settings ShowPreview="true" />
                                                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                                            <SettingsBehavior AllowFocusedRow="true" />
                                                           <%-- <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />--%>
                                                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                                           
                                                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                                            </SettingsContextMenu>
                                                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                                            </SettingsAdaptivity>
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
                                                            <EditFormLayoutProperties>
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption=" ">
                                                                        <Template>
                                                                            <dx:ASPxGridView ID="gridRTMItem" runat="server" DataSourceID="SqlRTM" AutoGenerateColumns="False" KeyFieldName="src_id" Width="100%">
                                                                                <SettingsPager PageSize="15">
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
                                                                                    <dx:GridViewDataTextColumn Caption="SRC ID" FieldName="src_title" VisibleIndex="2">
                                                                                    </dx:GridViewDataTextColumn>


                                                                                    <dx:GridViewDataTextColumn FieldName="src_id" Visible="False" VisibleIndex="1">
                                                                                    </dx:GridViewDataTextColumn>
                                                                                </Columns>
                                                                            </dx:ASPxGridView>
                                                                        </Template>
                                                                    </dx:GridViewColumnLayoutItem>
                                                                    <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                                                </Items>
                                                                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                                                            </EditFormLayoutProperties>
                                                            <Columns>
                                                                <dx:GridViewDataTextColumn FieldName="rc_comp_criteria_id" Visible="false" VisibleIndex="1" />

                                                                <dx:GridViewDataTextColumn Caption="SRC ID" FieldName="src_title" ShowInCustomizationForm="True" VisibleIndex="2">
                                                                </dx:GridViewDataTextColumn>

                                                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                                                </dx:GridViewCommandColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </dx:ContentControl>
                                                </ContentCollection>
                                            </dx:TabPage>

                                        </TabPages>
                                    </dx:ASPxPageControl>
                                </DetailRow>
                            </Templates>
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
                            <Columns>
                                <dx:GridViewCommandColumn ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="False" VisibleIndex="0" Width="100px" Visible="false">
                                </dx:GridViewCommandColumn>

                                <dx:GridViewDataTextColumn FieldName="ComponentName" Caption="Component Name" ShowInCustomizationForm="True" VisibleIndex="1">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Type" FieldName="ComponentType" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesComboBox>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Mode" FieldName="ComponentMode" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesComboBox>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataDateColumn FieldName="StartDate" Caption="Start Date" VisibleIndex="4" Visible="false">
                                    <PropertiesDateEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn FieldName="EndDate" Caption="End Date" Visible="false" VisibleIndex="5">
                                    <PropertiesDateEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesDateEdit>
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Location" FieldName="ComponentLocation" ShowInCustomizationForm="True" Visible="false" VisibleIndex="6">
                                    <PropertiesComboBox>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="SerialNumber" Caption="Serial/Version Number" ShowInCustomizationForm="True" Visible="false" VisibleIndex="7">
                                    <PropertiesTextEdit>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Test" FieldName="ComponentTest" ShowInCustomizationForm="True" Visible="false" VisibleIndex="8">
                                    <PropertiesComboBox TextField="Test" ValueField="TeComponentTestst">
                                        <Items>
                                            <dx:ListEditItem Text="Contingency" Value="0" />
                                            <dx:ListEditItem Text="Disaster Recovery" Value="1" />
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField ErrorText="* Required" IsRequired="True"></RequiredField>
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>


                            </Columns>
                            <Settings ShowPreview="true" />
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
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewLayoutGroup ColCount="2" GroupBoxDecoration="None">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColumnName="ComponentName" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="Type" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="Mode" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="Location" Width="100%" />
                                        </Items>
                                    </dx:GridViewLayoutGroup>
                                    <dx:GridViewLayoutGroup GroupBoxDecoration="None">
                                        <Items>
                                            <dx:GridViewColumnLayoutItem ColumnName="Test" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="SerialNumber" Width="100%" />
                                            <dx:GridViewColumnLayoutItem ColumnName="StartDate" />
                                            <dx:GridViewColumnLayoutItem ColumnName="EndDate" />
                                        </Items>
                                    </dx:GridViewLayoutGroup>
                                    <dx:GridViewColumnLayoutItem Caption="Notes" Width="100%" VerticalAlign="Top" ColumnName="Notes">
                                        <Template>
                                            <dx:ASPxMemo ID="notes" runat="server" Width="100%" Height="253" Text='<%# Bind("Notes") %>' />
                                        </Template>
                                    </dx:GridViewColumnLayoutItem>

                                    <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                                </Items>
                                <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                            </EditFormLayoutProperties>
                        </dx:ASPxGridView>
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
