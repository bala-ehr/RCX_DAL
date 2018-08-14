<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pro_deliverable_schedule.aspx.cs" Inherits="RC_X.rc_project.pro_deliverable_schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxGridView ID="gridTasks" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridTasks" KeyFieldName="Id" Width="100%">
        <ClientSideEvents CustomButtonClick="xGridButton" FocusedRowChanged="xGridFocus" />
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
        <SettingsBehavior ConfirmDelete="True" />
        <SettingsPager Mode="ShowAllRecords">
        </SettingsPager>
        <SettingsEditing Mode="EditForm">
        </SettingsEditing>
        <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" />
        <SettingsBehavior ConfirmDelete="True" AllowFocusedRow="True" />
        <Templates>
            <DetailRow>
                <dx:ASPxPageControl ID="tabTasksItems" runat="server" ActiveTabIndex="0" Width="100%">
                    <TabPages>
                        <dx:TabPage Name="GapsGoals" Text="Associated Gaps and Goals">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <asp:SqlDataSource ID="sqlAssociatedGapandGoals" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlAssociatedGapandGoals_Init"
                                        SelectCommand="select rmxref_id [Id], gap_title [Title], gap_type [Type] from [dbo].[rc_roadmap_xref] cp inner join [dbo].[rc_roadmap_gapsgoals] gp on cp.rmxref_gapid = gap_id  where cp.rmxref_rmid = @TaskID AND gp.gap_open= 1">
                                        <SelectParameters>
                                            <asp:SessionParameter Name="TaskID" SessionField="TaskID" DbType="String" />
                                        </SelectParameters>

                                    </asp:SqlDataSource>
                                    <dx:ASPxGridView ID="gridAssociatedGapsGoals" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" DataSourceID="sqlAssociatedGapandGoals"
                                        OnBeforePerformDataSelect="gridAssociatedGapsGoals_BeforePerformDataSelect" Width="100%">
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>
                                                    <dx:GridViewToolbarItem Command="FullExpand" Image-IconID="spreadsheet_expandfieldpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="FullCollapse" Image-IconID="spreadsheet_collapsefieldpivottable_16x16" />
                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
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

                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsBehavior AutoExpandAllGroups="True" />

                                        <SettingsDataSecurity AllowEdit="False" />
                                        <Columns>
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
                        <dx:TabPage Text="Artifacts">
                            <ContentCollection>
                                <dx:ContentControl runat="server">
                                    <asp:SqlDataSource ID="SqlTasksAttachments" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="SqlTasksAttachments_Init"
                                        SelectCommand="SELECT att_id, lib_title, lib_type, att_pageref FROM rc_repository_attachments ra INNER JOIN rc_repository rep ON ra.att_artifact = rep.lib_id WHERE (ra.att_itemid = @TaskID)">
                                        <SelectParameters>
                                            <asp:SessionParameter Name="TaskID" SessionField="TaskID" DbType="String" />
                                        </SelectParameters>

                                    </asp:SqlDataSource>
                                    <dx:ASPxGridView ID="gvTasksAttachments" runat="server" AutoGenerateColumns="False" DataSourceID="SqlTasksAttachments" KeyFieldName="att_id" OnBeforePerformDataSelect="gvTasksAttachments_BeforePerformDataSelect" Width="100%">
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>
                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
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

                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsBehavior AutoExpandAllGroups="True" />
                                        <SettingsDataSecurity AllowEdit="False" />
                                        <Columns>
                                            <dx:GridViewDataTextColumn FieldName="att_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                                            </dx:GridViewDataTextColumn>

                                            <dx:GridViewDataTextColumn Caption="Name" FieldName="lib_title" ShowInCustomizationForm="True" VisibleIndex="1">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn Caption="Type" FieldName="lib_type" ShowInCustomizationForm="True" VisibleIndex="2">
                                            </dx:GridViewDataTextColumn>

                                            <dx:GridViewDataTextColumn FieldName="att_pageref" ShowInCustomizationForm="True" VisibleIndex="3" Caption="Reference">
                                            </dx:GridViewDataTextColumn>

                                        </Columns>
                                    </dx:ASPxGridView>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Text="Workflow">
                            <ContentCollection>
                                <dx:ContentControl runat="server">

                                    <dx:ASPxGridView ID="workflow" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" OnBeforePerformDataSelect="workflow_BeforePerformDataSelect" Width="100%">
                                        <Toolbars>
                                            <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                                                <Items>
                                                    <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
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

                                        <SettingsBehavior ConfirmDelete="True" />
                                        <SettingsBehavior AutoExpandAllGroups="True" />
                                        <SettingsDataSecurity AllowEdit="False" />
                                        <Columns>
                                           
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
                    </TabPages>
                </dx:ASPxPageControl>
            </DetailRow>
        </Templates>
        <Columns>
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
            <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="False" VisibleIndex="5">
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
            <dx:GridViewDataDateColumn Caption="Target Date 1" FieldName="TargetDate1" ShowInCustomizationForm="True" VisibleIndex="9" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 2" FieldName="TargetDate2" ShowInCustomizationForm="True" VisibleIndex="10" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 3" FieldName="TargetDate3" ShowInCustomizationForm="True" VisibleIndex="11" Width="75px">
                <PropertiesDateEdit AllowNull="True" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
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
            <%-- <dx:GridViewBandColumn VisibleIndex="16" Caption="Actions" Name="Actions">
                <HeaderStyle HorizontalAlign="Center" />
                <Columns>
                    <dx:GridViewCommandColumn ButtonRenderMode="Link" ButtonType="Link" Caption="Response" VisibleIndex="0" Width="150px">
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="projectTasksAttach" Text="Artifacts">
                                <Image IconID="tasks_edittask_16x16">
                                </Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewCommandColumn ButtonRenderMode="Link" ButtonType="Link" Caption="Workflow" VisibleIndex="1" Width="150px">
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="projectTasksworkflow" Text="Workflow">
                                <Image IconID="layout_flowlayout_16x16">
                                </Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                </Columns>
            </dx:GridViewBandColumn>--%>
        </Columns>
    </dx:ASPxGridView>
</asp:Content>
