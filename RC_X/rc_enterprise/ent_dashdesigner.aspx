<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_dashdesigner.aspx.cs" Inherits="RC_X.rc_enterprise.ent_dashdesigner" %>
<%@ Register assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxDashboard ID="dashDesigner" runat="server" WorkingMode="Designer" DashboardStorageFolder="~/App_Data/Dashboards/">
    </dx:ASPxDashboard>
</asp:Content>
