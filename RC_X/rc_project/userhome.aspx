<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="userhome.aspx.cs" Inherits="RC_X.UserHome" %>
<%@ Register assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  

    <dx:ASPxDashboard ID="dashWorkflow" OnConfigureDataConnection="dashWorkflow_ConfigureDataConnection" OnCustomParameters="dashWorkflow_CustomParameters" DashboardXmlPath="~/rc_dashboard/dashboard_xml/dash_workflow.xml"  runat="server" DashboardSource="~/rc_dashboard/dashboard_xml/dash_workflow.xml" WorkingMode="ViewerOnly">
    </dx:ASPxDashboard>
</asp:Content>
