<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="unauthorized.aspx.cs" Inherits="RC_X.controls.unauthorized" %>
<%@ Register assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.Bootstrap" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <dx:ASPxPopupControl ID="popUnauthorized" runat="server" CloseAction="CloseButton" CloseOnEscape="True" HeaderText="Unauthorized access" Height="700px" Modal="True" PopupVerticalAlign="WindowCenter" ShowOnPageLoad="True" Width="700px" PopupHorizontalAlign="WindowCenter"> 
        <ContentCollection>
<dx:PopupControlContentControl runat="server">
<%--    <dx:ASPxImage ID="imgGif" runat="server" Height="100%" ImageUrl="~/Content/Images/unauthorized.gif" ShowLoadingImage="True" Width="100%">
    </dx:ASPxImage>--%>
    <br />
    <br />
    <br />
    <br />
    <br />
    You do not have security clearances for this page. Please contact your administrator to request access.

            </dx:PopupControlContentControl>
</ContentCollection>
    </dx:ASPxPopupControl>


</asp:Content>
