<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="RC_X.ForgotPassword" %>   <%--MasterPageFile="~/Light.master"--%>

<%--<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">--%>
<form runat="server">
     <div style="margin:auto; max-width: 400px">
<div class="accountHeader">
    <h2>Forgot password</h2>
</div>
<asp:PlaceHolder id="loginForm" runat="server">
    <h4>Enter your email</h4>
    <p><asp:Literal runat="server" ID="FailureText" /></p>
    <dx:ASPxTextBox runat="server" ID="Email" Caption="Email">
        <ValidationSettings>
            <RequiredField IsRequired="true" ErrorText="Email is required" />
        </ValidationSettings>
    </dx:ASPxTextBox><br />
    <dx:ASPxButton ID="btnSubmit" runat="server" Text="Email Link" OnClick="Forgot" />
</asp:PlaceHolder>
<asp:PlaceHolder runat="server" ID="DisplayEmail" Visible="false">
    <p>Please check your email to reset your password.</p>
</asp:PlaceHolder>
         </div></form>
<%--</asp:content>--%>