<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_security.aspx.cs" Inherits="RC_X.rc_enterprise.ent_security" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT AspNetUsers.Email, rc_security_user_roles_enterprise.entrole_roleID, rc_security_user_roles_enterprise.entrole_user, rc_security_user_roles_enterprise.entrole_id FROM AspNetUsers INNER JOIN rc_security_user_roles_enterprise ON AspNetUsers.Id = rc_security_user_roles_enterprise.entrole_user" UpdateCommand="UPDATE rc_security_user_roles_enterprise SET entrole_roleID = @entrole_roleID WHERE (entrole_id = @entrole_id)" ID="sqlEnterpriseRoleAssigner">
        <UpdateParameters>
            <asp:Parameter Name="entrole_roleID"></asp:Parameter>
            <asp:Parameter Name="entrole_id"></asp:Parameter>
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlRolesDropDown" runat="server" SelectCommand="SELECT [roles_id], [roles_name] FROM [rc_security_project_roles]" ConnectionString="<%$ ConnectionStrings:DevDB %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlProjects" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT pro_name, pro_ID FROM rc_projects"></asp:SqlDataSource>
    <asp:SqlDataSource ID="sqlEnterpriseRolesDropDown" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT roles_id, roles_name, roles_description FROM rc_security_enterprise_roles"></asp:SqlDataSource>
    <dx:ASPxPageControl ID="tabSecurity" runat="server" ActiveTabIndex="0" TabPosition="Left" Width="100%">
        <TabPages>
            <dx:TabPage Name="enterpriseroles" Text="Edit Enterprise Roles">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlEnterpriseRoles" runat="server" DeleteCommand="DELETE FROM rc_security_enterprise_roles WHERE (roles_id = @roles_id)" InsertCommand="INSERT INTO rc_security_enterprise_roles(roles_name, roles_description) VALUES (@roles_name, @roles_description)" SelectCommand="SELECT roles_id, roles_name, roles_description FROM rc_security_enterprise_roles" UpdateCommand="UPDATE rc_security_enterprise_roles SET roles_name = @roles_name, roles_description = @roles_description WHERE (roles_id = @roles_id)" ConnectionString="<%$ ConnectionStrings:DevDB %>">
                            <DeleteParameters>
                                <asp:Parameter Name="roles_id" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="roles_name" />
                                <asp:Parameter Name="roles_description" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="roles_name" />
                                <asp:Parameter Name="roles_description" />
                                <asp:Parameter Name="roles_id" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridEnterpriseLevelRoles" runat="server" AutoGenerateColumns="False" DataSourceID="sqlEnterpriseRoles" KeyFieldName="roles_id" OnDetailRowExpandedChanged="gridEnterpriseLevelRoles_DetailRowExpandedChanged" Width="100%">
                            <Templates>
                                <DetailRow>
                                    <asp:Label ID="lbEnterpriseRoleID" runat="server" Text='<%# Eval("roles_id") %>' Visible="False"></asp:Label>
                                    <asp:SqlDataSource ID="sqlEnterpriseDefinitions" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" InsertCommand="INSERT INTO rc_security_role_permissions(perm_name, perm_description, perm_roleID, perm_code) VALUES (@perm_name, @perm_description, @perm_roleID, @perm_code)" OnDataBinding="sqlDefinitions_DataBinding" 
                                        SelectCommand="SELECT rc_security_role_permissions.perm_authorized, rc_security_role_permissions.perm_id, rc_security_enterprise_roles.roles_id, rc_enterprise_permission_definitions.permdef_id, rc_enterprise_permission_definitions.permdef_group2, rc_enterprise_permission_definitions.permdef_group1, rc_enterprise_permission_definitions.permdef_name, rc_enterprise_permission_definitions.permdef_desc, rc_enterprise_permission_definitions.permdef_code, rc_enterprise_permission_definitions.permdef_order FROM rc_security_role_permissions INNER JOIN rc_security_enterprise_roles ON rc_security_role_permissions.perm_roleID = rc_security_enterprise_roles.roles_id INNER JOIN rc_enterprise_permission_definitions ON rc_security_role_permissions.perm_code = rc_enterprise_permission_definitions.permdef_code WHERE (rc_security_enterprise_roles.roles_id = @roles_id)" UpdateCommand="UPDATE rc_security_role_permissions SET perm_authorized = @perm_authorized WHERE (perm_id = @perm_id)">
                                        <InsertParameters>
                                            <asp:Parameter Name="perm_name" />
                                            <asp:Parameter Name="perm_description" />
                                            <asp:Parameter Name="perm_roleID" />
                                            <asp:Parameter Name="perm_code" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lbEnterpriseRoleID" Name="roles_id" PropertyName="Text" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="perm_authorized" />
                                            <asp:Parameter Name="perm_id" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                                    <dx:ASPxGridView ID="gridEnterpriseRolePermissions" runat="server" AutoGenerateColumns="False" DataSourceID="sqlEnterpriseDefinitions" KeyFieldName="perm_id" OnInit="gridEnterpriseRolePermissions_Init" Width="100%">
                                        <SettingsPager PageSize="50">
                                        </SettingsPager>
                                        <SettingsEditing Mode="Batch">
                                            <BatchEditSettings StartEditAction="Click" />
                                        </SettingsEditing>
                                        <SettingsBehavior AllowEllipsisInText="True" AllowFixedGroups="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                                        <SettingsResizing ColumnResizeMode="Control" />
                                         <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                        <SettingsBehavior AllowFocusedRow="true" />
                                       <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                                        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                       <%-- <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />--%>
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>
                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
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
                                            <NewButton>
                                                <Image AlternateText="New" IconID="actions_add_16x16" ToolTip="New">
                                                </Image>
                                            </NewButton>
                                            <UpdateButton>
                                                <Image AlternateText="Update" IconID="actions_apply_16x16" ToolTip="Update">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton>
                                                <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                                                </Image>
                                            </CancelButton>
                                            <EditButton>
                                                <Image AlternateText="Edit" IconID="actions_editname_16x16" ToolTip="Edit">
                                                </Image>
                                            </EditButton>
                                            <DeleteButton>
                                                <Image AlternateText="Delete" IconID="actions_trash_16x16" ToolTip="Delete">
                                                </Image>
                                            </DeleteButton>
                                        </SettingsCommandButton>
                                       
                                        <Columns>
                                            <dx:GridViewDataTextColumn Caption="Area" FieldName="permdef_group1" GroupIndex="0" ReadOnly="True" SortIndex="0" SortOrder="Ascending" VisibleIndex="0">
                                                <Columns>
                                                    <dx:GridViewDataTextColumn Caption="Feature" FieldName="permdef_group2" GroupIndex="1" SortIndex="1" SortOrder="Ascending" VisibleIndex="0">
                                                    </dx:GridViewDataTextColumn>
                                                </Columns>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Permission" FieldName="permdef_name" ReadOnly="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Description" FieldName="permdef_desc" ReadOnly="True" Visible="True" VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_code" ReadOnly="True" Visible="False" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_order" ReadOnly="True" SortIndex="0" SortOrder="Ascending" Visible="False" VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="roles_id" ReadOnly="True" Visible="False" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataCheckColumn Caption="Authorized" FieldName="perm_authorized" VisibleIndex="7" Width="100px">
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataCheckColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_id" Visible="False" VisibleIndex="8">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="perm_id" ReadOnly="True" Visible="False" VisibleIndex="9">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:ASPxGridView>
                                </DetailRow>
                            </Templates>
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
                            <SettingsEditing Mode="PopupEditForm">
                            </SettingsEditing>
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <SettingsCommandButton>
                                <NewButton>
                                    <Image AlternateText="New" IconID="actions_add_16x16" ToolTip="New">
                                    </Image>
                                </NewButton>
                                <UpdateButton Text="Save">
                                    <Image AlternateText="Update" IconID="actions_apply_16x16" ToolTip="Update">
                                    </Image>
                                </UpdateButton>
                                <CancelButton Text="Cancel">
                                    <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                                    </Image>
                                </CancelButton>
                                <EditButton>
                                    <Image AlternateText="Edit" IconID="actions_editname_16x16" ToolTip="Edit">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image AlternateText="Delete" IconID="actions_trash_16x16" ToolTip="Delete">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
                            
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="name" ShowCaption="True">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="roles_description">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn Caption="Title" FieldName="roles_id" Name="roles_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Name" FieldName="roles_name" Name="name" ShowInCustomizationForm="True" VisibleIndex="2" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Description" FieldName="roles_description" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="enterpriseuserroles" Text="Assign Enterprise Roles">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gridEnterpriseRoles" runat="server" AutoGenerateColumns="False" KeyFieldName="entrole_id" Width="100%" DataSourceID="sqlEnterpriseRoleAssigner">
                            <SettingsEditing Mode="Batch">
                                <BatchEditSettings StartEditAction="DblClick" />
                            </SettingsEditing>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                                <dx:GridViewDataTextColumn Caption="Email" FieldName="Email" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="5" Width="50%">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Role" FieldName="entrole_roleID" ShowInCustomizationForm="True" VisibleIndex="6">
                                    <PropertiesComboBox DataSourceID="sqlEnterpriseRolesDropDown" TextField="roles_name" ValueField="roles_id">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn Caption="RoleAssignmentID" FieldName="entrole_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="projectroles" Text="Edit Project Roles">

                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlProjectRoles" runat="server" DeleteCommand="DELETE FROM rc_security_project_roles WHERE (roles_id = @roles_id)" InsertCommand="INSERT INTO rc_security_project_roles(roles_name, roles_description) VALUES (@roles_name, @roles_description)" SelectCommand="SELECT roles_id, roles_name, roles_description FROM rc_security_project_roles" UpdateCommand="UPDATE rc_security_project_roles SET roles_name = @roles_name, roles_description = @roles_description WHERE (roles_id = @roles_id)">
                            <DeleteParameters>
                                <asp:Parameter Name="roles_id" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="roles_name" />
                                <asp:Parameter Name="roles_description" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="roles_name" />
                                <asp:Parameter Name="roles_description" />
                                <asp:Parameter Name="roles_id" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridProjectLevelRoles" runat="server" AutoGenerateColumns="False" DataSourceID="sqlProjectRoles" KeyFieldName="roles_id" OnDetailRowExpandedChanged="gridProjectLevelRoles_DetailRowExpandedChanged" Width="100%">
                            <Templates>
                                <DetailRow>
                                    <asp:Label ID="lbRoleID" runat="server" Text='<%# Eval("roles_id") %>' Visible="False"></asp:Label>
                                    <asp:SqlDataSource ID="sqlDefinitions" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" InsertCommand="INSERT INTO rc_security_role_permissions(perm_name, perm_description, perm_roleID, perm_code) VALUES (@perm_name, @perm_description, @perm_roleID, @perm_code)" OnDataBinding="sqlDefinitions_DataBinding" SelectCommand="SELECT rc_security_project_roles.roles_id, rc_security_role_permissions.perm_authorized, rc_security_role_permissions.perm_id, rc_project_permission_definitions.permdef_id, rc_project_permission_definitions.permdef_group1, rc_project_permission_definitions.permdef_group2, rc_project_permission_definitions.permdef_name, rc_project_permission_definitions.permdef_desc, rc_project_permission_definitions.permdef_code, rc_project_permission_definitions.permdef_order FROM rc_security_role_permissions INNER JOIN rc_security_project_roles ON rc_security_role_permissions.perm_roleID = rc_security_project_roles.roles_id INNER JOIN rc_project_permission_definitions ON rc_security_role_permissions.perm_code = rc_project_permission_definitions.permdef_code WHERE (rc_security_project_roles.roles_id = @roles_id)" UpdateCommand="UPDATE rc_security_role_permissions SET perm_authorized = @perm_authorized WHERE (perm_id = @perm_id)">
                                        <InsertParameters>
                                            <asp:Parameter Name="perm_name" />
                                            <asp:Parameter Name="perm_description" />
                                            <asp:Parameter Name="perm_roleID" />
                                            <asp:Parameter Name="perm_code" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lbRoleID" Name="roles_id" PropertyName="Text" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="perm_authorized" />
                                            <asp:Parameter Name="perm_id" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                                    <dx:ASPxGridView ID="gridRolePermissions" runat="server" AutoGenerateColumns="False" DataSourceID="sqlDefinitions" KeyFieldName="perm_id" OnInit="gridRolePermissions_Init" Width="100%">
                                        <SettingsPager PageSize="50">
                                        </SettingsPager>
                                        <SettingsEditing Mode="Batch">
                                            <BatchEditSettings StartEditAction="Click" />
                                        </SettingsEditing>
                                        <SettingsBehavior AllowEllipsisInText="True" AllowFixedGroups="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                                        <SettingsResizing ColumnResizeMode="Control" />
                                         <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                                        <SettingsBehavior AllowFocusedRow="true" />
                                       <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                                        <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                                        </SettingsContextMenu>
                                        <SettingsAdaptivity AdaptivityMode="HideDataCells">
                                        </SettingsAdaptivity>
                                        <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />
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
                                        <SettingsCommandButton>
                                            <NewButton>
                                                <Image AlternateText="New" IconID="actions_add_16x16" ToolTip="New">
                                                </Image>
                                            </NewButton>
                                            <UpdateButton>
                                                <Image AlternateText="Update" IconID="actions_apply_16x16" ToolTip="Update">
                                                </Image>
                                            </UpdateButton>
                                            <CancelButton>
                                                <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                                                </Image>
                                            </CancelButton>
                                            <EditButton>
                                                <Image AlternateText="Edit" IconID="actions_editname_16x16" ToolTip="Edit">
                                                </Image>
                                            </EditButton>
                                            <DeleteButton>
                                                <Image AlternateText="Delete" IconID="actions_trash_16x16" ToolTip="Delete">
                                                </Image>
                                            </DeleteButton>
                                        </SettingsCommandButton>
                                        
                                        <Columns>
                                            <dx:GridViewDataTextColumn Caption="Area" FieldName="permdef_group1" GroupIndex="0" ReadOnly="True" SortIndex="0" SortOrder="Ascending" VisibleIndex="0">
                                                <Columns>
                                                    <dx:GridViewDataTextColumn Caption="Feature" FieldName="permdef_group2" GroupIndex="1" SortIndex="1" SortOrder="Ascending" VisibleIndex="0">
                                                    </dx:GridViewDataTextColumn>
                                                </Columns>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Permission" FieldName="permdef_name" ReadOnly="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Description" FieldName="permdef_desc" ReadOnly="True"  VisibleIndex="3">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_code" ReadOnly="True" Visible="False" VisibleIndex="4">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_order" ReadOnly="True" SortIndex="0" SortOrder="Ascending" Visible="False" VisibleIndex="5">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="roles_id" ReadOnly="True" Visible="False" VisibleIndex="6">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataCheckColumn Caption="Authorized" FieldName="perm_authorized" VisibleIndex="7" Width="100px">
                                                <CellStyle HorizontalAlign="Center">
                                                </CellStyle>
                                            </dx:GridViewDataCheckColumn>
                                            <dx:GridViewDataTextColumn FieldName="permdef_id" Visible="False" VisibleIndex="8">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="perm_id" ReadOnly="True" Visible="False" VisibleIndex="9">
                                            </dx:GridViewDataTextColumn>
                                        </Columns>
                                    </dx:ASPxGridView>
                                </DetailRow>
                            </Templates>
                            <SettingsEditing Mode="PopupEditForm">
                            </SettingsEditing>
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
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <SettingsCommandButton>
                                <NewButton>
                                    <Image AlternateText="New" IconID="actions_add_16x16" ToolTip="New">
                                    </Image>
                                </NewButton>
                                <UpdateButton Text="Save">
                                    <Image AlternateText="Update" IconID="actions_apply_16x16" ToolTip="Update">
                                    </Image>
                                </UpdateButton>
                                <CancelButton Text="Cancel">
                                    <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                                    </Image>
                                </CancelButton>
                                <EditButton>
                                    <Image AlternateText="Edit" IconID="actions_editname_16x16" ToolTip="Edit">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image AlternateText="Delete" IconID="actions_trash_16x16" ToolTip="Delete">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
                            
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="name" ShowCaption="True">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="roles_description">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn Caption="Title" FieldName="roles_id" Name="roles_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Name" FieldName="roles_name" Name="name" ShowInCustomizationForm="True" VisibleIndex="2" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Description" FieldName="roles_description" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="projectuserroles" Text="Assign Project Roles">

                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxComboBox ID="ddlProjects" runat="server" AutoPostBack="True" Caption="Select a Project" IncrementalFilteringMode="StartsWith" OnSelectedIndexChanged="ddlProjects_SelectedIndexChanged" TextField="pro_name" ValueField="pro_ID" Width="100%" DataSourceID="sqlProjects">
                        </dx:ASPxComboBox>
                        <asp:SqlDataSource ID="sqlProjectRoleAssigner" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT AspNetUsers.Email, rc_projects.pro_name, rc_security_project_roles.roles_name, rc_projects.pro_ID, rc_security_user_roles.usrole_id, rc_security_user_roles.usrole_roleID, rc_security_user_roles.usrole_projectID FROM rc_projects INNER JOIN rc_security_user_roles ON rc_projects.pro_ID = rc_security_user_roles.usrole_projectID RIGHT OUTER JOIN AspNetUsers ON rc_security_user_roles.usrole_user = AspNetUsers.Id LEFT OUTER JOIN rc_security_project_roles ON rc_security_user_roles.usrole_roleID = rc_security_project_roles.roles_id WHERE (rc_security_user_roles.usrole_projectID = @usrole_projectID)" UpdateCommand="UPDATE rc_security_user_roles SET usrole_roleID = @usrole_roleID WHERE (usrole_id = @usrole_id)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlProjects" Name="usrole_projectID" PropertyName="Value" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="usrole_roleID" />
                                <asp:Parameter Name="usrole_id" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <br />
                        <dx:ASPxGridView ID="gridProjectRoles" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="usrole_id" DataSourceID="sqlProjectRoleAssigner">
                            <SettingsEditing Mode="Batch">
                                <BatchEditSettings StartEditAction="DblClick" />
                            </SettingsEditing>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <Columns>
                                <dx:GridViewDataTextColumn Caption="ProjectID" FieldName="pro_ID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Email" FieldName="Email" ShowInCustomizationForm="True" VisibleIndex="5" Width="50%" ReadOnly="True">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Role" FieldName="usrole_roleID" ShowInCustomizationForm="True" VisibleIndex="6" Name="Role">
                                    <PropertiesComboBox DataSourceID="sqlRolesDropDown" TextField="roles_name" ValueField="roles_id">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn Caption="RoleAssignmentID" FieldName="usrole_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                            </Columns>

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

                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="users" Text="Manage Users">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlUserProjects" runat="server" SelectCommand="SELECT pro_ID, pro_name, pro_color, pro_description FROM rc_projects"></asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridUsers" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridUsers" KeyFieldName="Id" OnRowInserting="gridUsers_RowInserting" Width="100%" OnRowDeleting="gridUsers_RowDeleting">
                            <SettingsEditing Mode="PopupEditForm">
                            </SettingsEditing>
                             <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <SettingsCommandButton>
                                <NewButton>
                                    <Image IconID="actions_add_16x16">
                                    </Image>
                                </NewButton>
                                <UpdateButton ButtonType="Button" RenderMode="Button">
                                </UpdateButton>
                                <CancelButton ButtonType="Button" RenderMode="Button">
                                </CancelButton>
                                <EditButton>
                                    <Image IconID="mail_editcontact_16x16">
                                    </Image>
                                </EditButton>
                                <DeleteButton>
                                    <Image IconID="actions_cancel_16x16">
                                    </Image>
                                </DeleteButton>
                            </SettingsCommandButton>
                           
                            <EditFormLayoutProperties>
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="Email">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Phone Number">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Default Project">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowClearFilterButton="True" ShowDeleteButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="1" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="Email" ShowInCustomizationForm="True" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Email Confirmed?" FieldName="EmailConfirmed" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn FieldName="PhoneNumber" ShowInCustomizationForm="True" VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Default Project" FieldName="project" ShowInCustomizationForm="True" VisibleIndex="6">
                                    <PropertiesComboBox DataSourceID="sqlUserProjects" TextField="pro_name" ValueField="pro_ID" ValueType="System.Guid">
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataTextColumn FieldName="Id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="usersStatistics" Text="User Log">
                <ContentCollection>
                    <dx:ContentControl runat="server">

                        <dx:ASPxGridView ID="gvUsersStatistics" runat="server" AutoGenerateColumns="False" ClientInstanceName="gvUsersStatistics" KeyFieldName="UserStatisticsID" Width="100%">
                             <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                            </SettingsContextMenu>
                            <SettingsAdaptivity AdaptivityMode="HideDataCells">
                            </SettingsAdaptivity>
                            <SettingsBehavior AllowEllipsisInText="True" AutoExpandAllGroups="True" ConfirmDelete="True" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsExport EnableClientSideExportAPI="True" FileName="UserStatistics">
                            </SettingsExport>
                            <SettingsPager PageSize="100">
                            </SettingsPager>
                           
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="UserStatisticsID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="UserName" ShowInCustomizationForm="True" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Project Name" FieldName="ProjectName" ShowInCustomizationForm="True" VisibleIndex="2">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Event Name" FieldName="EventName" ShowInCustomizationForm="True" VisibleIndex="3">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Event Time" FieldName="EventTime" ShowInCustomizationForm="True" VisibleIndex="4">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Notes" FieldName="Notes" ShowInCustomizationForm="True" VisibleIndex="5">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="IPAddress" FieldName="IPAddress" ShowInCustomizationForm="True" VisibleIndex="6">
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>
</asp:Content>
