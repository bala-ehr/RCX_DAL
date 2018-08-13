<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="ChangePassword.aspx.cs" Inherits="RC_X.ChangePassword" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
<%--    <div class="accountHeader">
    <h2 runat="server" ID="PageHeader">Change password</h2>
    <p runat="server" ID="PageDescription">Use the form below to change your password.</p>
    <p style="color:red">
      <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
</div>

<dx:ASPxTextBox ID="tbCurrentPassword" runat="server" Caption="Old Password" Password="true" Width="200px">
    <CaptionSettings Position="Top" />
    <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
          <RequiredField ErrorText="Old Password is required." IsRequired="true" />
      </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Caption="Password" Password="true" runat="server"
      Width="200px">
    <CaptionSettings Position="Top" />
      <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
          <RequiredField ErrorText="Password is required." IsRequired="true" />
      </ValidationSettings>
</dx:ASPxTextBox>
<dx:ASPxTextBox ID="tbConfirmPassword" Password="true" Caption="Confirm password" runat="server" Width="200px">
    <CaptionSettings Position="Top" />
      <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
          <RequiredField ErrorText="Confirm Password is required." IsRequired="true" />
      </ValidationSettings>
      <ClientSideEvents Validation="function(s, e) {
        var originalPasswd = Password.GetText();
        var currentPasswd = s.GetText();
        e.isValid = (originalPasswd  == currentPasswd );
        e.errorText = 'The Password and Confirmation Password must match.';
    }" />
</dx:ASPxTextBox>
<br />
<dx:ASPxButton ID="btnChangePassword" runat="server" Text="Change Password" ValidationGroup="ChangeUserPasswordValidationGroup"
    OnClick="btnChangePassword_Click">
</dx:ASPxButton>
<dx:ASPxButton ID="btnSetPassword" runat="server" Text="Set Password" Visible="false" ValidationGroup="ChangeUserPasswordValidationGroup"
    OnClick="btnSetPassword_Click">
</dx:ASPxButton>--%>

<dx:ASPxPopupControl ID="popLogin" runat="server" CloseAction="None" Height="350px" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="False" ShowHeader="False" ShowOnPageLoad="True" ShowSizeGrip="False" Width="350px">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <div align="center">
                    <br />

                    <dx:ASPxImage ID="imgLogo" ImageUrl="~/Content/Images/logo.png" Width="200" Height="151" runat="server" ShowLoadingImage="true"></dx:ASPxImage>
                
                    <br />
                    <br />
                    <br />
                    <h2 runat="server" id="PageHeader">Change password</h2>
                    <p runat="server" id="PageDescription">
                        Use the form below to change your password
                    </p>
                    <p style="color: red">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <dx:ASPxTextBox ID="tbCurrentPassword" runat="server" Caption="Old Password" Password="true" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="Old Password is required." IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbPassword" ClientInstanceName="Password" Caption="Password" Password="true" runat="server"
                        Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="Password is required." IsRequired="true" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbConfirmPassword" Password="true" Caption="Confirm password" runat="server" Width="200px">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings ValidationGroup="ChangeUserPasswordValidationGroup" Display="Dynamic" ErrorTextPosition="Bottom" ErrorDisplayMode="Text">
                            <RequiredField ErrorText="Confirm Password is required." IsRequired="true" />
                        </ValidationSettings>
                        <ClientSideEvents Validation="function(s, e) {
                            var originalPasswd = Password.GetText();
                            var currentPasswd = s.GetText();
                            e.isValid = (originalPasswd  == currentPasswd );
                            e.errorText = 'The Password and Confirmation Password must match.';
                        }" />
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxButton ID="btnChangePassword" runat="server" Text="Change Password" ValidationGroup="ChangeUserPasswordValidationGroup"
                        OnClick="btnChangePassword_Click">
                    </dx:ASPxButton>
                    <dx:ASPxButton ID="btnSetPassword" runat="server" Text="Set Password" Visible="false" ValidationGroup="ChangeUserPasswordValidationGroup"
                        OnClick="btnSetPassword_Click">
                    </dx:ASPxButton>
                    
                    <dx:ASPxHyperLink ID="linkCancel" runat="server" Text="Cancel" NavigateUrl="Manage.aspx" Width="80px" AutoPostBack="False" Style="float: left; margin-right: 8px" >
                  </dx:ASPxHyperLink>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
</asp:Content>