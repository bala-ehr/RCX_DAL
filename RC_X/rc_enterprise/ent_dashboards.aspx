﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_dashboards.aspx.cs" Inherits="RC_X.rc_enterprise.ent_dashboards" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:XmlDataSource ID="dataReports" runat="server" DataFile="~/rc_dashboard/ent_dashboards.xml"></asp:XmlDataSource>
    <dx:ASPxComboBox ID="comboDashboards" runat="server" Caption="Choose a dashboard: " DataSourceID="dataReports" OnSelectedIndexChanged="comboDashboards_SelectedIndexChanged" ValueField="id" Width="100%" AutoPostBack="True">
        <Columns>
            <dx:ListBoxColumn Caption="Name" FieldName="type"  width="150px">
            </dx:ListBoxColumn>
            <dx:ListBoxColumn Caption="Description" FieldName="description"  width="500px">
            </dx:ListBoxColumn>
        </Columns>
    </dx:ASPxComboBox>
    <dx:ASPxDashboard ID="dashViewer" runat="server" WorkingMode="ViewerOnly" OnConfigureDataConnection="dashViewer_ConfigureDataConnection"></dx:ASPxDashboard>
</asp:Content>
