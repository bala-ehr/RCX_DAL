<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Login.aspx.cs" Inherits="RC_X.Login" %>
<%--MasterPageFile="~/Light.master"--%>
<%--<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">--%>
    <%--<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>--%>
 

<%--<uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />--%>
<form runat="server">
    <dx:ASPxPopupControl ID="popLogin" runat="server" CloseAction="None" Height="350px" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="False" ShowHeader="False" ShowOnPageLoad="True" ShowSizeGrip="False" Width="350px">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
              <div align="center"><br />

                    <dx:ASPxImage ID="imgLogo" ImageUrl="~/Content/Images/logo.png" width="200" height="151" runat="server" ShowLoadingImage="true"></dx:ASPxImage>
                    <%--<dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl="logo.png" ShowLoadingImage="true" Width="200px" Height="200px"></dx:ASPxImage>--%>
                      <br />
                    <br /><br />
                    <h2>Log In</h2>
                    <p>
                        Please enter your username and password.</p>
                    <dx:ASPxButton ID="ResendConfirm" runat="server" OnClick="SendEmailConfirmationToken" Text="Resend Confirmation" Visible="False" xmlns:dx="devexpress.web">
                    </dx:ASPxButton>
                    <dx:ASPxTextBox ID="tbUserName" runat="server" Caption="User Name" Width="200px" xmlns:dx="devexpress.web">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom" ValidationGroup="LoginUserValidationGroup">
                            <RequiredField ErrorText="User Name is required." IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="tbPassword" runat="server" Caption="Password" Password="True" Width="200px" xmlns:dx="devexpress.web">
                        <CaptionSettings Position="Top" />
                        <ValidationSettings Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom" ValidationGroup="LoginUserValidationGroup">
                            <RequiredField ErrorText="Password is required." IsRequired="True" />
                        </ValidationSettings>
                    </dx:ASPxTextBox>
                <br />
                    <dx:ASPxButton ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log In" ValidationGroup="LoginUserValidationGroup" xmlns:dx="devexpress.web">
                    </dx:ASPxButton>
                         <br />
                         <br />
                  <dx:ASPxHyperLink ID="linkForgot" runat="server" Text="Forgot your password?" NavigateUrl="ForgotPassword.aspx">
                  </dx:ASPxHyperLink>
                </div>
            </dx:PopupControlContentControl>
        </ContentCollection>
    </dx:ASPxPopupControl>
<br />
<%--<uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />--%>
 
<%--   
    <asp:SqlDataSource ID="sqlProjectInfo" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT pro_ID, pro_name, pro_color, pro_description FROM rc_projects WHERE (pro_ID = @pro_ID)">
        <SelectParameters>
            <asp:Parameter Name="pro_ID" />
        </SelectParameters>
    </asp:SqlDataSource>
 

 
    <asp:SqlDataSource ID="sqlEnterprise" runat="server" ConnectionString="<%$ ConnectionStrings:RCXidentity %>" SelectCommand="SELECT en_id, en_name, en_connstring FROM rc_enterprise WHERE (en_id = @en_id)">
        <SelectParameters>
            <asp:Parameter Name="en_id" />
        </SelectParameters>
    </asp:SqlDataSource>--%>
<%--     <asp:ScriptManager ID="sm" runat="server" OnInit="sm_Init" EnablePageMethods="true" EnableScriptGlobalization="True">
            <Scripts>
                <asp:ScriptReference Path="~/MasterClientSide.js?abcdefghijklzmnopqrstuv" />
            </Scripts>
        </asp:ScriptManager>--%>
    </form>
  
<%--</asp:Content>--%>