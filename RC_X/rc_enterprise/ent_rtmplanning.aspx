<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_rtmplanning.aspx.cs" Inherits="RC_X.rc_enterprise.ent_rtmplanning" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
     <script type="text/javascript">
         function ShowNewProjectWindow() {
             addNewProject.Show();
             tbProjectname.Focus();
         }
         function hideModal() {
             addNewProject.Hide();
         }
         function OnBatchEditEndEditing(s, e) {
             CalculateSummary(s, e.rowValues, e.visibleIndex, false);
         }
    </script>
    <div style="margin: 16px auto; width: 160px;">
        <dx:ASPxButton ID="btShowModal" runat="server" Text="New Project Window" AutoPostBack="False" UseSubmitBehavior="false" Width="100%">
            <ClientSideEvents Click="function(s, e) { ShowNewProjectWindow(); }" />
        </dx:ASPxButton>
    </div>
    <dx:ASPxPopupControl ID="addNewProject" runat="server" Width="320" CloseAction="CloseButton" CloseOnEscape="true"
            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="addNewProject"
            HeaderText="Add New Project" AllowDragging="True" Modal="True" PopupAnimationType="Fade"
            EnableViewState="False" PopupHorizontalOffset="40" PopupVerticalOffset="40" AutoUpdatePosition="true">
            <ClientSideEvents PopUp="function(s, e) { ASPxClientEdit.ClearGroup('addNewProject'); }" />
            <SizeGripImage Width="11px" />
            <ContentCollection>
                <dx:PopupControlContentControl runat="server">
                    <dx:ASPxPanel ID="Panel2" runat="server" DefaultButton="btCreate">
                        <PanelCollection>
                            <dx:PanelContent runat="server">
                                <dx:ASPxFormLayout runat="server" ID="NewProjectFormLayout" Width="100%" Height="100%">
                                    <Items>
                                        <dx:LayoutItem Caption="Project Name">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer>
                                                    <dx:ASPxTextBox ID="tbProjectname" runat="server" Width="150px" ClientInstanceName="tbProjectname">
                                                        <ValidationSettings EnableCustomValidation="True" ValidationGroup="addNewProject"
                                                        SetFocusOnError="True" ErrorDisplayMode="Text" ErrorTextPosition="Bottom">
                                                        <RequiredField IsRequired="True" ErrorText="Project Name is required" />
                                                        <ErrorFrameStyle Font-Size="10px">
                                                            <ErrorTextPaddings PaddingLeft="0px" />
                                                        </ErrorFrameStyle>
                                                    </ValidationSettings>
                                                    </dx:ASPxTextBox>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                        <dx:LayoutItem ShowCaption="False">
                                            <LayoutItemNestedControlCollection>
                                                <dx:LayoutItemNestedControlContainer>
                                                    <dx:ASPxButton ID="btCreate" runat="server" Text="OK" Width="80px" AutoPostBack="False" OnClick="btCreate_Click" Style="float: left; margin-right: 8px">
                                                       <ClientSideEvents Click="hideModal" />
                                                    </dx:ASPxButton>
                                                    <dx:ASPxButton ID="btCancel2" runat="server" Text="Cancel" Width="80px" AutoPostBack="False" Style="float: left; margin-right: 8px">
                                                        <ClientSideEvents Click="function(s, e) { addNewProject.Hide(); }" />
                                                    </dx:ASPxButton>
                                                </dx:LayoutItemNestedControlContainer>
                                            </LayoutItemNestedControlCollection>
                                        </dx:LayoutItem>
                                    </Items>
                                </dx:ASPxFormLayout>
                            </dx:PanelContent>
                        </PanelCollection>
                    </dx:ASPxPanel>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>

    <dx:ASPxGridView ID="gridRTMPlaning" runat="server" KeyFieldName="src_id" AutoGenerateColumns="True" Width="100%"
        ClientInstanceName="gridRTMPlaning" OnBatchUpdate="gridRTMPlaning_BatchUpdate">
        <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row" BatchEditSettings-HighlightDeletedRows="true"
            BatchEditSettings-StartEditAction="DblClick">
            <BatchEditSettings EditMode="Row" StartEditAction="DblClick"></BatchEditSettings>
        </SettingsEditing>
        <Settings ShowGroupedColumns="False" ShowGroupPanel="False" />
        <SettingsBehavior AllowFixedGroups="True" AutoExpandAllGroups="True" />
        <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
        <SettingsPager EnableAdaptivity="true" PageSize="50"></SettingsPager>
         <settingscontextmenu enablecolumnmenu="True" enabled="True" enablegrouppanelmenu="True" enablerowmenu="True">
        </settingscontextmenu>
        <settingsadaptivity adaptivitymode="HideDataCells">
        </settingsadaptivity>
        <SettingsSearchPanel Visible="true" ShowApplyButton="true" ShowClearButton="true" AllowTextInputTimer="false"/> <%--CustomEditorID="tbToolbarSearch"--%>
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
        
    </dx:ASPxGridView>
</asp:Content>
