<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_projects.aspx.cs" Inherits="RC_X.rc_enterprise.ent_projects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxGridView ID="gridProjects" runat="server" AutoGenerateColumns="False" KeyFieldName="ProjectID" Width="100%" OnCellEditorInitialize="gridProjects_CellEditorInitialize"
        OnRowInserting="gridProjects_RowInserting" OnRowUpdating="gridProjects_RowUpdating" OnRowDeleting="gridProjects_RowDeleting">
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
        <settingscontextmenu enablecolumnmenu="True" enabled="True" enablegrouppanelmenu="True" enablerowmenu="True">
        </settingscontextmenu>
        <settingsadaptivity adaptivitymode="HideDataCells">
        </settingsadaptivity>
        <SettingsPager Mode="ShowAllRecords">
        </SettingsPager>
        <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
         <SettingsBehavior AllowFocusedRow="true" />
        <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
        <SettingsBehavior ConfirmDelete="True" />
        <SettingsText ConfirmDelete="Are you sure you really want to delete this project permanently, all data associated with it will be non recoverable" />
        <EditFormLayoutProperties ColCount="2">
            <Items>
                <dx:GridViewColumnLayoutItem ColumnName="ProjectName">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Color ID">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Milestone" />
                <dx:GridViewColumnLayoutItem ColumnName="Start Date">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Target Date 1">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Target Date 2">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Target Date 3">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Estimated End Date">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="CertificationDate">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Actual End Date">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="Roadmap" ColumnName="Roadmap?">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Project Manager">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Status">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Description">
                </dx:GridViewColumnLayoutItem>
                <dx:EditModeCommandLayoutItem ColSpan="2" HorizontalAlign="Right">
                </dx:EditModeCommandLayoutItem>
            </Items>
        </EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowEditButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="ProjectID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="ProjectName" FieldName="ProjectName" ShowInCustomizationForm="True" VisibleIndex="2">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColorEditColumn Caption="Color ID" FieldName="ProjectColor" ShowInCustomizationForm="True" VisibleIndex="3" Width="50px">
                <PropertiesColorEdit EnableCustomColors="True">
                </PropertiesColorEdit>
            </dx:GridViewDataColorEditColumn>
            <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                <PropertiesMemoEdit Rows="20">
                </PropertiesMemoEdit>
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataComboBoxColumn Caption="Milestone" FieldName="MilestoneName" VisibleIndex="5" Width="150px">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" ShowInCustomizationForm="True" VisibleIndex="6" Width="75px">
                <PropertiesDateEdit DisplayFormatString="" EnableFocusedStyle="False">
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Estimated End Date" FieldName="EstimatedEndDate" ShowInCustomizationForm="True" VisibleIndex="7" Width="75px">
                <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 1" FieldName="TargetDate1" ShowInCustomizationForm="True" VisibleIndex="8" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 2" FieldName="TargetDate2" ShowInCustomizationForm="True" VisibleIndex="9" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 3" FieldName="TargetDate3" ShowInCustomizationForm="True" VisibleIndex="10" Width="75px">
                <PropertiesDateEdit AllowNull="True" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="Status" ShowInCustomizationForm="True" VisibleIndex="11" Width="75px">
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

            <dx:GridViewDataDateColumn Caption="Actual End Date" FieldName="ActualEndDate" ShowInCustomizationForm="True" VisibleIndex="12" Width="75px">
                <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>

            <dx:GridViewDataDateColumn Caption="CertificationDate" FieldName="CertificationDate" ShowInCustomizationForm="True" VisibleIndex="13" Width="75px">
                <PropertiesDateEdit DisplayFormatString="">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn Caption="Project Manager" FieldName="PMName" ShowInCustomizationForm="True" VisibleIndex="14" Width="75px">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
           
            <dx:GridViewDataCheckColumn Caption="Roadmap?" FieldName="Roadmap" ShowInCustomizationForm="True" VisibleIndex="15" Visible="false" Width="50px">
                <PropertiesCheckEdit AllowGrayedByClick="False" ValueGrayed="False">
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesCheckEdit>
            </dx:GridViewDataCheckColumn>
        </Columns>
    </dx:ASPxGridView>
</asp:Content>
