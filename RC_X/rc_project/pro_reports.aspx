<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pro_reports.aspx.cs" Inherits="RC_X.rc_project.pro_reports" %>

<%@ Register Assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%-- <script type="text/javascript">
        function documentViewer_Init(sender, e) {
            var scaleFactorEditor = sender.GetToolbar().GetItemTemplateControl("ScaleFactor");
            scaleFactorEditor.SetValue("75");
        }

  
    </script>--%>
    <asp:XmlDataSource ID="dataReports" runat="server" DataFile="~/rc_dashboard/pro_reports.xml"></asp:XmlDataSource>
    <dx:ASPxComboBox ID="comboReports" runat="server" Caption="Choose a Report" DataSourceID="dataReports" OnSelectedIndexChanged="comboReports_SelectedIndexChanged" ValueField="id" Width="100%" AutoPostBack="True" DropDownRows="50">
        <Columns>
            <dx:ListBoxColumn Caption="Name" FieldName="type" Width="150px">
            </dx:ListBoxColumn>
            <dx:ListBoxColumn Caption="Description" FieldName="description" width="500px">
            </dx:ListBoxColumn>
        </Columns>
    </dx:ASPxComboBox>
    
    <dx:ASPxComboBox ID="comboChecklistName" runat="server" Caption="Choose a Checklist" OnSelectedIndexChanged="comboChecklistName_SelectedIndexChanged" TextField="Title" ValueField="Id" Width="100%" AutoPostBack="True" Visible="false">
    </dx:ASPxComboBox>
    <dx:ASPxWebDocumentViewer ID="reportViewer" runat="server">
     <%--     <ClientSideEvents Init="function(s, e) {
                                s.previewModel.reportPreview.zoom(.75);
                            }" />--%>
         <%--<ClientSideEvents Init="documentViewer_Init"/>--%>
    </dx:ASPxWebDocumentViewer>
</asp:Content>
