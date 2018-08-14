<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_reports.aspx.cs" Inherits="RC_X.rc_enterprise.ent_reports" %>
<%@ Register assembly="DevExpress.XtraReports.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:XmlDataSource ID="dataReports" runat="server" DataFile="~/rc_dashboard/ent_reports.xml"></asp:XmlDataSource>
    <dx:ASPxComboBox ID="comboReports" runat="server" Caption="Choose a Report: " DataSourceID="dataReports" OnSelectedIndexChanged="comboReports_SelectedIndexChanged" ValueField="id" Width="100%" AutoPostBack="True" DropDownRows="50">
        <Columns>
            <dx:ListBoxColumn Caption="Name" FieldName="type" width="150px">
            </dx:ListBoxColumn>
            <dx:ListBoxColumn Caption="Description" FieldName="description"  width="500px">
            </dx:ListBoxColumn>
        </Columns>
    </dx:ASPxComboBox>
     <dx:ASPxComboBox ID="comboIVV" runat="server" Caption="Choose a State and Project: " OnSelectedIndexChanged="comboIVV_SelectedIndexChanged" ValueField="GeneralInfoID" Width="100%" Visible="false" AutoPostBack="True" DropDownRows="20">
        <Columns>
            <dx:ListBoxColumn Caption="State Name" FieldName="StateName" width="150px">
            </dx:ListBoxColumn>
            <dx:ListBoxColumn Caption="Project Name" FieldName="ProjectName"  width="500px">
            </dx:ListBoxColumn>
        </Columns>
    </dx:ASPxComboBox>
    <div>
         <dx:ASPxFormLayout ID="OptionsFormLayout" runat="server" ShowItemCaptionColon="false" ColCount="2" Visible="false" Width="100%">
             <Items>
                 <dx:LayoutGroup Caption="Choose a Project1:" GroupBoxDecoration="HeadingLine" ColCount="1">
                     <Items>
                         <dx:LayoutItem ShowCaption="False">
                             <LayoutItemNestedControlCollection>
                                 <dx:LayoutItemNestedControlContainer runat="server">
                                     <dx:ASPxComboBox ID="comboProject1" runat="server" Caption="Choose Project 1: " OnSelectedIndexChanged="comboProject1_SelectedIndexChanged" ValueField="Id" TextField="Name" Width="100%" Visible="false" AutoPostBack="True" DropDownRows="20">
                                     </dx:ASPxComboBox>
                                 </dx:LayoutItemNestedControlContainer>
                             </LayoutItemNestedControlCollection>
                         </dx:LayoutItem>
                     </Items>
                 </dx:LayoutGroup>
                 <dx:LayoutGroup Caption="Choose a Project2:" GroupBoxDecoration="HeadingLine" ColCount="1">
                     <Items>
                         <dx:LayoutItem ShowCaption="False">
                             <LayoutItemNestedControlCollection>
                                 <dx:LayoutItemNestedControlContainer runat="server">
                                     <dx:ASPxComboBox ID="comboProject2" runat="server" Caption="Choose Project 2: " OnSelectedIndexChanged="comboProject2_SelectedIndexChanged" ValueField="Id" TextField="Name" Width="100%" Visible="false" AutoPostBack="True" DropDownRows="20">
                                     </dx:ASPxComboBox>
                                 </dx:LayoutItemNestedControlContainer>
                             </LayoutItemNestedControlCollection>
                         </dx:LayoutItem>
                     </Items>
                 </dx:LayoutGroup>
             </Items>
         </dx:ASPxFormLayout>
    </div>
     
     
    <dx:ASPxWebDocumentViewer ID="reportViewer" runat="server">
    </dx:ASPxWebDocumentViewer>
</asp:Content>
