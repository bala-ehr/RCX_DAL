<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_essa.aspx.cs" Inherits="RC_X.rc_enterprise.ent_essa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <dx:ASPxComboBox ID="comboESSA" runat="server" Caption="Choose a project to download your E-SSA" OnButtonClick="comboESSA_ButtonClick" Width="400px">
        <Items>
            <dx:ListEditItem Text="2015 SS-A" Value="Scorecard_Templates_Ohio2015SS-A.xlsm" />
            <dx:ListEditItem Text="2018 SS-A" Value="Scorecard_Templates_Ohio2018SS-A.xlsm" />
            <dx:ListEditItem Text="RCX MITA 3.0" Value="Scorecard_Templates_OhioRCXMITA30.xlsm" />
        </Items>
        <buttons>
            <dx:EditButton Text="Download">
                <image iconid="actions_download_16x16">
                </image>
            </dx:EditButton>
        </buttons>
    </dx:ASPxComboBox>
</asp:Content>
