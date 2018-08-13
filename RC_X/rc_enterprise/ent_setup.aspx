<%@ Page Title="Enterprise Setup" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_setup.aspx.cs" Inherits="RC_X.ent_setup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxPageControl ID="pageSetup" runat="server" ActiveTabIndex="0" Height="100%" TabPosition="Left" Width="100%">
        <TabPages>

            <dx:TabPage Name="Milestones" Text="Milestones">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxGridView ID="gvMilestone" runat="server" ClientInstanceName="gvMilestone" AutoGenerateColumns="False" KeyFieldName="Id" Width="100%"
                            OnRowInserting="gvMilestone_RowInserting" OnRowUpdating="gvMilestone_RowUpdating">
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
                            <Settings ShowGroupedColumns="False" />
                            <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager PageSize="25"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                            <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                                    <dx:GridViewColumnLayoutItem ColumnName="Name">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="MilestoneType">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="Date" />
                                    <dx:GridViewColumnLayoutItem ColumnName="IsStatic">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Milestone Name" FieldName="Name" ShowInCustomizationForm="True" VisibleIndex="2" Width="200px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataComboBoxColumn Caption="Milestone Type" FieldName="MilestoneType" ShowInCustomizationForm="True" VisibleIndex="3" Width="100px" Visible="false">
                                    <PropertiesComboBox>
                                        <Items>
                                            <dx:ListEditItem Text="Please Select one" Value="" />
                                            <dx:ListEditItem Text="R1" Value="R1" />
                                            <dx:ListEditItem Text="R2" Value="R2" />
                                            <dx:ListEditItem Text="R3" Value="R3" />
                                            <dx:ListEditItem Text="As-Is" Value="As-Is" />
                                            <dx:ListEditItem Text="To-Be" Value="To-Be" />
                                            <dx:ListEditItem Text="Summary" Value="Summary" />
                                        </Items>
                                        <ValidationSettings>
                                            <RequiredField IsRequired="True" />
                                        </ValidationSettings>
                                    </PropertiesComboBox>
                                </dx:GridViewDataComboBoxColumn>
                                <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" VisibleIndex="4">
                                    <PropertiesMemoEdit Rows="20">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>
                                <dx:GridViewDataDateColumn Caption="Milestone Date" FieldName="Date" ShowInCustomizationForm="True" VisibleIndex="5" Width="200px">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataCheckColumn Caption="IsStatic" FieldName="IsStatic" ShowInCustomizationForm="True" VisibleIndex="6" Width="200px">
                                </dx:GridViewDataCheckColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="scorecards" Text="Scorecards">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlScorecards" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlScorecards_Init"
                            DeleteCommand="DELETE FROM [rc_scorecards] WHERE [card_id] = @card_id"
                            InsertCommand="INSERT INTO [rc_scorecards] ([card_name], [card_measure], [card_measure_notes], [card_desc], [card_col1], [card_measure1], [card_colenabled1], [card_col2], [card_measure2], [card_colenabled2], [card_col3], [card_measure3], [card_colenabled3], [card_col4], [card_measure4], [card_colenabled4], [card_col5], [card_measure5], [card_colenabled5]) VALUES (@card_name, @card_measure, @card_measure_notes, @card_desc, @card_col1, @card_measure1, @card_colenabled1, @card_col2, @card_measure2, @card_colenabled2, @card_col3, @card_measure3, @card_colenabled3, @card_col4, @card_measure4, @card_colenabled4, @card_col5, @card_measure5, @card_colenabled5)"
                            SelectCommand="SELECT * FROM [rc_scorecards]"
                            UpdateCommand="UPDATE [rc_scorecards] SET [card_name] = @card_name, [card_measure] = @card_measure, [card_measure_notes] = @card_measure_notes, [card_desc] = @card_desc, [card_col1] = @card_col1, [card_measure1] = @card_measure1, [card_colenabled1] = @card_colenabled1, [card_col2] = @card_col2, [card_measure2] = @card_measure2, [card_colenabled2] = @card_colenabled2, [card_col3] = @card_col3, [card_measure3] = @card_measure3, [card_colenabled3] = @card_colenabled3, [card_col4] = @card_col4, [card_measure4] = @card_measure4, [card_colenabled4] = @card_colenabled4, [card_col5] = @card_col5, [card_measure5] = @card_measure5, [card_colenabled5] = @card_colenabled5 WHERE [card_id] = @card_id">
                            <DeleteParameters>
                                <asp:Parameter Name="card_id" Type="Object" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="card_name" Type="String" />
                                <asp:Parameter Name="card_measure" Type="Boolean" />
                                <asp:Parameter Name="card_measure_notes" Type="String" />
                                <asp:Parameter Name="card_desc" Type="String" />
                                <asp:Parameter Name="card_col1" Type="String" />
                                <asp:Parameter Name="card_measure1" Type="String" />
                                <asp:Parameter Name="card_colenabled1" Type="Boolean" />
                                <asp:Parameter Name="card_col2" Type="String" />
                                <asp:Parameter Name="card_measure2" Type="String" />
                                <asp:Parameter Name="card_colenabled2" Type="Boolean" />
                                <asp:Parameter Name="card_col3" Type="String" />
                                <asp:Parameter Name="card_measure3" Type="String" />
                                <asp:Parameter Name="card_colenabled3" Type="Boolean" />
                                <asp:Parameter Name="card_col4" Type="String" />
                                <asp:Parameter Name="card_measure4" Type="String" />
                                <asp:Parameter Name="card_colenabled4" Type="Boolean" />
                                <asp:Parameter Name="card_col5" Type="String" />
                                <asp:Parameter Name="card_measure5" Type="String" />
                                <asp:Parameter Name="card_colenabled5" Type="Boolean" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="card_name" Type="String" />
                                <asp:Parameter Name="card_measure" Type="Boolean" />
                                <asp:Parameter Name="card_measure_notes" Type="String" />
                                <asp:Parameter Name="card_desc" Type="String" />
                                <asp:Parameter Name="card_col1" Type="String" />
                                <asp:Parameter Name="card_measure1" Type="String" />
                                <asp:Parameter Name="card_colenabled1" Type="Boolean" />
                                <asp:Parameter Name="card_col2" Type="String" />
                                <asp:Parameter Name="card_measure2" Type="String" />
                                <asp:Parameter Name="card_colenabled2" Type="Boolean" />
                                <asp:Parameter Name="card_col3" Type="String" />
                                <asp:Parameter Name="card_measure3" Type="String" />
                                <asp:Parameter Name="card_colenabled3" Type="Boolean" />
                                <asp:Parameter Name="card_col4" Type="String" />
                                <asp:Parameter Name="card_measure4" Type="String" />
                                <asp:Parameter Name="card_colenabled4" Type="Boolean" />
                                <asp:Parameter Name="card_col5" Type="String" />
                                <asp:Parameter Name="card_measure5" Type="String" />
                                <asp:Parameter Name="card_colenabled5" Type="Boolean" />
                                <asp:Parameter Name="card_id" Type="Object" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridScorecards" OnRowInserted="gridScorecards_RowInserted" runat="server" AutoGenerateColumns="False" DataSourceID="sqlScorecards" KeyFieldName="card_id" Width="100%" OnParseValue="gridScorecards_ParseValue" OnRowInserting="gridScorecards_RowInserting">
                            <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                            <Templates>
                                <DetailRow>
                                    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                                        <TabPages>
                                            <dx:TabPage Text="Assessment Items">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="sqlMatrix" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlMatrix_Init"
                                                            DeleteCommand="DELETE FROM rc_scorecards_matrix WHERE (matrix_id = @matrix_id)"
                                                            InsertCommand="INSERT INTO rc_scorecards_matrix(matrix_itemkey, matrix_card) VALUES (@matrix_itemkey, @matrix_card)"
                                                            SelectCommand="SELECT view_all_assessment.RC_ID, view_all_assessment.RC_NAME, view_all_assessment.RC_TYPE, rc_scorecards_matrix.matrix_id, rc_scorecards_matrix.matrix_card, rc_scorecards_matrix.matrix_itemkey FROM rc_scorecards_matrix INNER JOIN view_all_assessment ON rc_scorecards_matrix.matrix_itemkey = view_all_assessment.id WHERE (rc_scorecards_matrix.matrix_card = @matrix_card)">
                                                            <DeleteParameters>
                                                                <asp:Parameter Name="matrix_id" Type="Object" />
                                                            </DeleteParameters>
                                                            <InsertParameters>
                                                                <asp:Parameter Name="matrix_itemkey" />
                                                                <asp:Parameter Name="matrix_card" />
                                                            </InsertParameters>
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="matrix_card" SessionField="card_id" />
                                                            </SelectParameters>
                                                        </asp:SqlDataSource>
                                                        <asp:SqlDataSource ID="sqlAllAssess" runat="server" OnInit="sqlAllAssess_Init"
                                                            ConnectionString="<%$ ConnectionStrings:DevDB %>"
                                                            SelectCommand="SELECT RC_ID, RC_NAME, RC_TYPE, id FROM view_all_assessment"></asp:SqlDataSource>
                                                        <dx:ASPxGridView ID="gridMatrix" runat="server" OnInit="gridMatrix_Init" AutoGenerateColumns="False" DataSourceID="sqlMatrix" KeyFieldName="matrix_id" OnRowInserting="gridMatrix_RowInserting" Width="100%">
                                                            <SettingsPager Mode="ShowAllRecords" />
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
                                                                <dx:GridViewDataTextColumn FieldName="matrix_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="matrix_card" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="matrix_itemkey" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Name" FieldName="RC_NAME" ShowInCustomizationForm="True" SortIndex="2" SortOrder="Ascending" VisibleIndex="4">
                                                                </dx:GridViewDataTextColumn>
                                                            </Columns>
                                                        </dx:ASPxGridView>
                                                    </dx:ContentControl>
                                                </ContentCollection>
                                            </dx:TabPage>
                                            <dx:TabPage Name="standards" Text="Standards">
                                                <ContentCollection>
                                                    <dx:ContentControl runat="server">
                                                        <asp:SqlDataSource ID="sqlStandards" OnInit="sqlStandards_Init" runat="server"
                                                            ConnectionString="<%$ ConnectionStrings:DevDB %>"
                                                            DeleteCommand="DELETE FROM [rc_scorecards_standards] WHERE [stan_id] = @stan_id"
                                                            InsertCommand="INSERT INTO [rc_scorecards_standards] ( [stan_card], [stan_standard], [stan_capabilityquality]) VALUES (CONVERT(uniqueidentifier,@stan_card), @stan_standard, @stan_capabilityquality)"
                                                            SelectCommand="SELECT * FROM [rc_scorecards_standards] WHERE ([stan_card] = @stan_card)"
                                                            UpdateCommand="UPDATE [rc_scorecards_standards] SET  [stan_standard] = @stan_standard, [stan_capabilityquality] = @stan_capabilityquality WHERE [stan_id] = @stan_id">
                                                            <DeleteParameters>
                                                                <asp:Parameter Name="stan_id" Type="Object" />
                                                            </DeleteParameters>
                                                            <InsertParameters>
                                                                <asp:SessionParameter Name="stan_card" SessionField="card_id" Type="Object" />
                                                                <asp:Parameter Name="stan_standard" Type="String" />
                                                                <asp:Parameter Name="stan_capabilityquality" Type="String" />
                                                            </InsertParameters>
                                                            <SelectParameters>
                                                                <asp:SessionParameter Name="stan_card" SessionField="card_id" Type="Object" />
                                                            </SelectParameters>
                                                            <UpdateParameters>
                                                                <asp:Parameter Name="stan_standard" Type="String" />
                                                                <asp:Parameter Name="stan_capabilityquality" Type="String" />
                                                                <asp:Parameter Name="stan_id" Type="Object" />
                                                            </UpdateParameters>
                                                        </asp:SqlDataSource>
                                                        <dx:ASPxGridView ID="gridStandards" runat="server" AutoGenerateColumns="False" DataSourceID="sqlStandards" KeyFieldName="stan_id" OnBeforePerformDataSelect="gridStandards_BeforePerformDataSelect" OnInit="gridStandards_Init" OnRowInserted="gridStandards_RowInserted">
                                                            <SettingsDetail ShowDetailRow="True" />
                                                            <Templates>
                                                                <DetailRow>
                                                                    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
                                                                        <TabPages>
                                                                            <dx:TabPage Name="values" Text="Score Values">
                                                                                <ContentCollection>
                                                                                    <dx:ContentControl runat="server">
                                                                                        <asp:SqlDataSource ID="sqlValues" OnInit="sqlValues_Init" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>"
                                                                                            DeleteCommand="DELETE FROM [rc_scorestandard_values] WHERE [value_id] = @value_id"
                                                                                            SelectCommand="sp_scoreStandard_getvalues" SelectCommandType="StoredProcedure"
                                                                                            UpdateCommand="UPDATE [rc_scorestandard_values] SET [value_score] = @value_score, [value_scoretext] = @value_scoretext, [value_measures] = @value_measures WHERE [value_id] = @value_id">
                                                                                            <DeleteParameters>
                                                                                                <asp:Parameter Name="value_id" Type="Object" />
                                                                                            </DeleteParameters>

                                                                                            <SelectParameters>
                                                                                                <asp:ControlParameter Name="stan_id" ControlID="hdnStandardID" PropertyName="Value" DbType="Guid" />
                                                                                            </SelectParameters>
                                                                                            <UpdateParameters>
                                                                                                <asp:Parameter Name="value_score" Type="Int32" />
                                                                                                <asp:Parameter Name="value_scoretext" Type="String" />
                                                                                                <asp:Parameter Name="value_measures" Type="String" />
                                                                                                <asp:Parameter Name="value_id" Type="Object" />
                                                                                            </UpdateParameters>
                                                                                        </asp:SqlDataSource>
                                                                                        <dx:ASPxGridView ID="gridValues" runat="server" AutoGenerateColumns="False" DataSourceID="sqlValues" KeyFieldName="value_id" Width="100%"
                                                                                            OnBeforePerformDataSelect="gridValues_BeforePerformDataSelect" OnRowInserting="gridValues_RowInserting" OnInit="gridValues_Init">
                                                                                            <SettingsEditing Mode="Batch">
                                                                                            </SettingsEditing>
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
                                                                                            <EditFormLayoutProperties AlignItemCaptionsInAllGroups="True" ColCount="2">
                                                                                                <Items>
                                                                                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="value_score" HelpText="An integer value for a score that the user can assign to this standard">
                                                                                                    </dx:GridViewColumnLayoutItem>
                                                                                                    <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="value_scoretext" HelpText="Text explaining to the user the meaning of this score, or when it shopuld be applied">
                                                                                                    </dx:GridViewColumnLayoutItem>
                                                                                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                                                                                    </dx:EditModeCommandLayoutItem>
                                                                                                </Items>
                                                                                            </EditFormLayoutProperties>
                                                                                            <Columns>
                                                                                                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                                                                                </dx:GridViewCommandColumn>
                                                                                                <dx:GridViewDataTextColumn FieldName="value_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                                                </dx:GridViewDataTextColumn>
                                                                                                <dx:GridViewDataTextColumn FieldName="value_standard" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                                                                </dx:GridViewDataTextColumn>
                                                                                                <dx:GridViewDataTextColumn Caption="Score Value" FieldName="value_score" ShowInCustomizationForm="True" VisibleIndex="3" Width="100px" SortIndex="0" SortOrder="Ascending">
                                                                                                </dx:GridViewDataTextColumn>
                                                                                                <dx:GridViewDataTextColumn FieldName="value_measures" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                                                                                </dx:GridViewDataTextColumn>
                                                                                                <dx:GridViewDataMemoColumn Caption="Score Explanation" FieldName="value_scoretext" ShowInCustomizationForm="True" VisibleIndex="4">
                                                                                                    <PropertiesMemoEdit Rows="5"></PropertiesMemoEdit>
                                                                                                </dx:GridViewDataMemoColumn>
                                                                                            </Columns>
                                                                                        </dx:ASPxGridView>
                                                                                    </dx:ContentControl>
                                                                                </ContentCollection>
                                                                            </dx:TabPage>
                                                                        </TabPages>
                                                                    </dx:ASPxPageControl>
                                                                </DetailRow>
                                                            </Templates>
                                                            <SettingsEditing Mode="Batch">
                                                            </SettingsEditing>
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
                                                            <EditFormLayoutProperties ColCount="2">
                                                                <Items>
                                                                    <dx:GridViewColumnLayoutItem Caption="Standard Name" ColSpan="2" ColumnName="stan_standard">
                                                                    </dx:GridViewColumnLayoutItem>
                                                                    <dx:GridViewColumnLayoutItem Caption="Capability Quality" ColSpan="2" ColumnName="stan_capabilityquality">
                                                                    </dx:GridViewColumnLayoutItem>
                                                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                                                    </dx:EditModeCommandLayoutItem>
                                                                </Items>
                                                            </EditFormLayoutProperties>
                                                            <Columns>
                                                                <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                                                </dx:GridViewCommandColumn>
                                                                <dx:GridViewDataTextColumn FieldName="stan_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn FieldName="stan_card" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Standard" FieldName="stan_standard" ShowInCustomizationForm="True" VisibleIndex="3">
                                                                </dx:GridViewDataTextColumn>
                                                                <dx:GridViewDataTextColumn Caption="Capability Quality" FieldName="stan_capabilityquality" ShowInCustomizationForm="True" VisibleIndex="4">
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
                            <Settings ShowFilterRow="True" ShowFilterRowMenu="True" />
                            <SettingsBehavior ConfirmDelete="True" />
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
                            <Settings ShowGroupedColumns="False" />
                            <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager PageSize="25"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                           <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <EditFormLayoutProperties ColCount="2">
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="card_name" HelpText="A name for your scorecard" ColSpan="2">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure" HelpText="Choose whether this scorecard should allow users to enter performance measures, or simply hide measure columns" ColSpan="2">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem Caption="Scorecard Description" ColSpan="2" ColumnName="Scorecard Description" HelpText="General description of the scorecard, as well as instructions for users on how to use it">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem Caption="Measure Description" ColSpan="2" ColumnName="Performance Measures Description" HelpText="Provide instructions to users on how to rate performance measures and how they should be recorded">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewTabbedLayoutGroup ColSpan="2" Width="100%">
                                        <Items>
                                            <dx:GridViewLayoutGroup Caption="Score 1">
                                                <Items>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_col1" HelpText="A name for this score column (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure1" HelpText="A name for the type of performance measure associated with this score (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_colenabled1" HelpText="Enable or disable this score column">
                                                    </dx:GridViewColumnLayoutItem>
                                                </Items>
                                            </dx:GridViewLayoutGroup>
                                            <dx:GridViewLayoutGroup Caption="Score 2">
                                                <Items>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_col2" HelpText="A name for this score column (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure2" HelpText="A name for the type of performance measure associated with this score (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_colenabled2" HelpText="Enable or disable this score column">
                                                    </dx:GridViewColumnLayoutItem>
                                                </Items>
                                            </dx:GridViewLayoutGroup>
                                            <dx:GridViewLayoutGroup Caption="Score 3">
                                                <Items>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_col3" HelpText="A name for this score column (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure3" HelpText="A name for the type of performance measure associated with this score (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_colenabled3" HelpText="Enable or disable this score column">
                                                    </dx:GridViewColumnLayoutItem>
                                                </Items>
                                            </dx:GridViewLayoutGroup>
                                            <dx:GridViewLayoutGroup Caption="Score 4">
                                                <Items>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_col4" HelpText="A name for this score column (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure4" HelpText="A name for the type of performance measure associated with this score (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_colenabled4" HelpText="Enable or disable this score column">
                                                    </dx:GridViewColumnLayoutItem>
                                                </Items>
                                            </dx:GridViewLayoutGroup>
                                            <dx:GridViewLayoutGroup Caption="Score 5">
                                                <Items>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_col5" HelpText="A name for this score column (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_measure5" HelpText="A name for the type of performance measure associated with this score (users will see it at the header of the column when scoring)">
                                                    </dx:GridViewColumnLayoutItem>
                                                    <dx:GridViewColumnLayoutItem ColumnName="card_colenabled5" HelpText="Enable or disable this score column">
                                                    </dx:GridViewColumnLayoutItem>
                                                </Items>
                                            </dx:GridViewLayoutGroup>
                                        </Items>
                                    </dx:GridViewTabbedLayoutGroup>
                                    <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                                    </dx:EditModeCommandLayoutItem>
                                </Items>
                            </EditFormLayoutProperties>
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" ShowDeleteButton="True" Width="100px" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="card_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Scorecard" FieldName="card_name" ShowInCustomizationForm="True" VisibleIndex="2" Width="150px">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Performance Measures Enabled" FieldName="card_measure" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Score 1 Name" FieldName="card_col1" ShowInCustomizationForm="True" VisibleIndex="6">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Measure" FieldName="card_measure1" ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Enabled" FieldName="card_colenabled1" ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Score 2 Name" FieldName="card_col2" ShowInCustomizationForm="True" VisibleIndex="9">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Measure" FieldName="card_measure2" ShowInCustomizationForm="True" Visible="False" VisibleIndex="10">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Enabled" FieldName="card_colenabled2" ShowInCustomizationForm="True" Visible="False" VisibleIndex="11">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Score 3 Name" FieldName="card_col3" ShowInCustomizationForm="True" VisibleIndex="12">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Measure" FieldName="card_measure3" ShowInCustomizationForm="True" Visible="False" VisibleIndex="13">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Enabled" FieldName="card_colenabled3" ShowInCustomizationForm="True" Visible="False" VisibleIndex="14">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Score 4 Name" FieldName="card_col4" ShowInCustomizationForm="True" VisibleIndex="15">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Measure" FieldName="card_measure4" ShowInCustomizationForm="True" Visible="False" VisibleIndex="16">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Enabled" FieldName="card_colenabled4" ShowInCustomizationForm="True" Visible="False" VisibleIndex="17">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataTextColumn Caption="Score 5 Name" FieldName="card_col5" ShowInCustomizationForm="True" VisibleIndex="18">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Measure" FieldName="card_measure5" ShowInCustomizationForm="True" Visible="False" VisibleIndex="19">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataCheckColumn Caption="Enabled" FieldName="card_colenabled5" ShowInCustomizationForm="True" Visible="False" VisibleIndex="20">
                                    <PropertiesCheckEdit AllowGrayedByClick="False" ConvertEmptyStringToNull="False" ValueGrayed="False">
                                    </PropertiesCheckEdit>
                                </dx:GridViewDataCheckColumn>
                                <dx:GridViewDataMemoColumn Caption="Performance Measures Description" FieldName="card_measure_notes" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                                    <PropertiesMemoEdit Rows="5">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>
                                <dx:GridViewDataMemoColumn Caption="Scorecard Description" FieldName="card_desc" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
                                    <PropertiesMemoEdit Rows="5">
                                    </PropertiesMemoEdit>
                                </dx:GridViewDataMemoColumn>

                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="types" Text="Value Types">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <asp:SqlDataSource ID="sqlGlobalTypes" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlGlobalTypes_Init" DeleteCommand="DELETE FROM rc_types WHERE (type_id = @type_id)" InsertCommand="INSERT INTO rc_types(type_home, type_title, type_value) VALUES (@type_home, @type_title, @type_value)" SelectCommand="SELECT DISTINCT type_id, type_home, type_title, type_value FROM rc_types WHERE (type_home &lt;&gt; 'assessment') AND (type_home &lt;&gt; 'rtm')" UpdateCommand="UPDATE rc_types SET type_home = @type_home, type_title = @type_title, type_value = @type_value WHERE (type_id = @type_id)">
                            <DeleteParameters>
                                <asp:Parameter Name="type_id" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="type_home" />
                                <asp:Parameter Name="type_title" />
                                <asp:Parameter Name="type_value" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="type_home" />
                                <asp:Parameter Name="type_title" />
                                <asp:Parameter Name="type_value" />
                                <asp:Parameter Name="type_id" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <dx:ASPxGridView ID="gridTypes" runat="server" AutoGenerateColumns="False" DataSourceID="sqlGlobalTypes" KeyFieldName="type_id">
                            <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" />
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsPager Mode="ShowAllRecords"></SettingsPager>
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
                            <Settings ShowGroupedColumns="False" />
                            <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True" />
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                            <SettingsPager PageSize="25"></SettingsPager>
                            <SettingsBehavior AllowFocusedRow="true" />
                          <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
                            <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
                            <SettingsResizing ColumnResizeMode="Control" />
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
                            <SettingsSearchPanel Visible="True" />
                            <Columns>
                                <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                                </dx:GridViewCommandColumn>
                                <dx:GridViewDataTextColumn FieldName="type_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Value Type" FieldName="type_home" ShowInCustomizationForm="True" VisibleIndex="2">
                                    <PropertiesTextEdit>

                                        <ValidationSettings CausesValidation="True">

                                            <RequiredField ErrorText="Value Type is required (e.g.: Document. Compliance)" IsRequired="True" />

                                        </ValidationSettings>

                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="String Value" FieldName="type_title" ShowInCustomizationForm="True" VisibleIndex="3">
                                    <PropertiesTextEdit>

                                        <ValidationSettings>

                                            <RequiredField ErrorText="Text is required - this is the value displayed to users" IsRequired="True" />

                                        </ValidationSettings>

                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn Caption="Data Value" FieldName="type_value" ShowInCustomizationForm="True" VisibleIndex="4">
                                    <PropertiesTextEdit>

                                        <ValidationSettings CausesValidation="True">

                                            <RequiredField ErrorText="Data Value required. This is the value saved in the database" IsRequired="True" />

                                        </ValidationSettings>

                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                            </Columns>
                        </dx:ASPxGridView>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
             <dx:TabPage Name="about" Text="About">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        ReadyCert® Copyright © 2012-2018 - Electronic Health Resources, LLC. All Rights Reserved.<br />
Version - 4.2.1.3<br />
ReadyCert is a cloud-based Compliance platform produced, owned and operated by Electronic Health Resources LLC (<a href="http://ehr-llc.com" target="_blank">http://ehr-llc.com</a>). <br />For support, send an email to <a href="mailto:support@readycert.net">support@readycert.net</a>. <br/>For sales related information, send an email to <a href="mailto:info@ehr-llc.com">info@ehr-llc.com</a>.<br /> Reference information can be found at <a href="http://wiki.readycert.net" target="_blank">http://wiki.readycert.net</a>
                        
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <TabStyle Font-Bold="False" Font-Size="Small">
            <Paddings PaddingBottom="10px" PaddingTop="10px" />
        </TabStyle>
        <ContentStyle HorizontalAlign="Center" VerticalAlign="Top">
        </ContentStyle>
        <SpaceBeforeTabsTemplateStyle>
            <Paddings PaddingTop="20px" />
        </SpaceBeforeTabsTemplateStyle>
        <ClientSideEvents ActiveTabChanging="function(s, e) {
            //console.log(e.tab);
            if (e.tab.name == 'Milestones')
                gvMilestone.PerformCallback('');
        }" />
    </dx:ASPxPageControl>
    <asp:HiddenField ID="hdnStandardID" runat="server" />
    <br />
</asp:Content>
