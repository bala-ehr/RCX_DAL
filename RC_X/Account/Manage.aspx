<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Light.master" CodeBehind="Manage.aspx.cs" Inherits="RC_X.Manage" %>

<asp:content id="ClientArea" contentplaceholderid="MainContent" runat="server">
     
<p><%: SuccessMessage %></p>
<div  class="accountHeader">
   <%-- <h2>Change your account settings</h2>--%>
</div>
<%--<ul>
    <li>
        <%--Password:--%>
 
       <%-- <dx:ASPxHyperLink NavigateUrl="/Account/ChangePassword.aspx" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />--%>
        <%--<dx:ASPxHyperLink NavigateUrl="/Account/ChangePassword.aspx" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />--%>
 
    <%--</li>--%>
   <%-- <li>
        External Logins: <%: LoginsCount %> 
 
        <dx:ASPxHyperLink NavigateUrl="/Account/ManageLogins.aspx" Text="[Manage]" runat="server" />
 
    </li>--%>
    <%-- 
        Phone Numbers can used as a second factor of verification in a two-factor authentication system.
        See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
        for details on setting up this ASP.NET application to support two-factor authentication using SMS.
        Uncomment the following blocks after you have set up two-factor authentication
    --%> 
    <%-- 
    <li>
        Phone Number:
 
    <% if (HasPhoneNumber) { %> 
        <dx:ASPxHyperLink NavigateUrl="/Account/AddPhoneNumber.aspx" runat="server" Text="[Add]" />
    <% } else { %> 
        <dx:ASPxLabel Text="" ID="PhoneNumber" runat="server" />
        <dx:ASPxHyperLink NavigateUrl="/Account/AddPhoneNumber.aspx" runat="server" Text="[Change]" /> &nbsp;|&nbsp;
        <dx:ASPxButton runat="server" ID="RemovePhone" RenderMode="Link" Text="[Remove]" OnClick="RemovePhone_Click" />
    <% } %> 
 
    </li> 
    --%> 
   <%-- <li>
        Two-Factor Authentication:
        There are no two-factor authentication providers configured. See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
        for details on setting up this ASP.NET application to support two-factor authentication.
 
        <% if (TwoFactorEnabled) { %> 
        <%--
        Enabled
        <dx:ASPxButton runat="server" id="TwoFactorDisable" RenderMode="Link" Text="[Disable]" CommandArgument="false" OnClick="TwoFactorDisable_Click" />
        --%>
        <%--<% } else { %>--%>          
        <%--
        Disabled
        <dx:ASPxButton runat="server" id="TwoFactorEnable" RenderMode="Link" Text="[Enable]" CommandArgument="true" OnClick="TwoFactorEnable_Click" />
        --%>
<%--        <% } %> --%>
    <%--</li>--%>
<%--</ul>--%>
    <script type="text/javascript">
        function ShowLoginWindow()
        {
            pcLogin.Show();
        }

    </script>
<div align="center">
 <dx:ASPxCardView ID="userProfile" ClientInstanceName="userProfile" runat="server" Width="300px"  PagerAlign="Justify" ItemSpacing="25px" EnableCardsCache="false" >
        <Columns>
            
            <dx:CardViewTextColumn FieldName="Email" VisibleIndex="1" />
            <dx:CardViewTextColumn FieldName="PhoneNumber" VisibleIndex="2" />
            <dx:CardViewTextColumn FieldName="Enterprise" VisibleIndex="3" />
            <dx:CardViewTextColumn FieldName="DefaultProject" VisibleIndex="4" />
            <dx:CardViewTextColumn FieldName="UserName" VisibleIndex="5" />
            
        </Columns>
        <CardLayoutProperties ColCount="3" UseDefaultPaddings="true" Paddings-PaddingRight="150px">
            <Items>
                 <dx:CardViewLayoutGroup Name="EnterpriseIcon" Caption="EHR" ColSpan="2" ShowCaption="False" HorizontalAlign="Center" GroupBoxDecoration="none" >
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="EnterpriseLogo" ShowCaption="False" >
                            <Template>
                              <dx:ASPxImage ID="imgCover" runat="server" ImageUrl="../Content/Images/logo.png" Width="200px" Height="200px"  />  
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                    </Items>
                </dx:CardViewLayoutGroup>
                <dx:CardViewLayoutGroup Name="Profile" Caption="Profile" ColSpan="2" GroupBoxDecoration="HeadingLine">
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="Email" />
                        <dx:CardViewColumnLayoutItem ColumnName="PhoneNumber" />
                        <dx:CardViewColumnLayoutItem ColumnName="Enterprise" />
                        <dx:CardViewColumnLayoutItem ColumnName="DefaultProject" />
                        <dx:CardViewColumnLayoutItem ColumnName="UserName" />
                    </Items>
                </dx:CardViewLayoutGroup>
                <dx:CardViewLayoutGroup Name="PasswordChange" ColSpan="2" Caption="Password Change"   GroupBoxDecoration="HeadingLine" >
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="Password" Caption="Click here to change Password:">
                            <Template>
                                <dx:ASPxHyperLink NavigateUrl="/Account/ChangePassword.aspx"  Text="[Change]"  ID="ChangePassword" runat="server" />
                               
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                        <dx:CardViewColumnLayoutItem ColumnName="UserProfile" Caption="Click here to edit your profile:">
                            <Template>
                               <dx:ASPxButton ID="btShowModal" runat="server" Text="Edit Profile" AutoPostBack="False" UseSubmitBehavior="false" Width="10px" Height="6px">
                                    <ClientSideEvents Click="function(s, e) { ShowLoginWindow(); }" />
                                </dx:ASPxButton>
                               
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                        <dx:CardViewColumnLayoutItem ColumnName="CreatePassword" Caption="Click here to create Password:" ShowCaption="False">
                            <Template>
                                <dx:ASPxHyperLink NavigateUrl="/Account/ChangePassword.aspx" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                               
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                        <dx:CardViewColumnLayoutItem ColumnName="SuccessMessage" Caption="Succuess Message" ShowCaption="False">
                            <Template>
                                
                                <p><%: SuccessMessage %></p>
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                    </Items>
                </dx:CardViewLayoutGroup>
                <dx:CardViewLayoutGroup Name="ThemeSetting" ColSpan="2" Caption="Theme Selection"   GroupBoxDecoration="HeadingLine" >
                    <Items>
                        <dx:CardViewColumnLayoutItem ColumnName="Theme" Caption="Select the theme here:">
                            <Template>
                                <dx:ASPxRadioButtonList ID="rbList" runat="server" AutoPostBack="True" SelectedIndex="0" OnSelectedIndexChanged="rbList_SelectedIndexChanged" RepeatColumns="2" RepeatLayout="Table">
                                    <ClientSideEvents SelectedIndexChanged="function(s, e) { ASPxClientUtils.SetCookie('theme', s.GetValue());}" />
                                    <Items>
                                        <dx:ListEditItem Selected="True" Text="MaterialCompact" Value="MaterialCompact" />
                                        <dx:ListEditItem Text="Aqua" Value="Aqua" />
                                        <dx:ListEditItem Text="DevEx" Value="DevEx" />
                                        <dx:ListEditItem Text="PlasticBlue" Value="PlasticBlue" />
                                        <dx:ListEditItem Text="Office2010Black" Value="Office2010Black" />
                                        <dx:ListEditItem Text="Office2003Blue" Value="Office2003Blue" />
                                        <dx:ListEditItem Text="BlackGlass" Value="BlackGlass" />
                                        <dx:ListEditItem Text="Glass" Value="Glass" />
                                        <dx:ListEditItem Text="Material" Value="Material" />
                                        <dx:ListEditItem Text="SoftOrange" Value="SoftOrange" />
                                        <dx:ListEditItem Text="Office2003Olive" Value="Office2003Olive" />
                                        <dx:ListEditItem Text="RedWine" Value="RedWine" />
                                    </Items>
                                </dx:ASPxRadioButtonList>
                               
                            </Template>
                        </dx:CardViewColumnLayoutItem>
                        
                    </Items>
                </dx:CardViewLayoutGroup>
               
            </Items>
        </CardLayoutProperties>
       
       <SettingsPager SettingsTableLayout-ColumnCount="3"  />
        <SettingsPager EnableAdaptivity="true" />
        
    </dx:ASPxCardView>
  </div>  
    <dx:ASPxPopupControl ID="pcLogin" runat="server" Width="320" CloseAction="CloseButton" CloseOnEscape="true" Modal="True" HeaderText=""
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="pcLogin"
        AllowDragging="True" PopupAnimationType="None" EnableViewState="False" AutoUpdatePosition="true">
        <ClientSideEvents PopUp="function(s, e) {  tbLogin.Focus(); }" />
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <dx:ASPxPanel ID="Panel1" runat="server" DefaultButton="btOK">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <dx:ASPxFormLayout runat="server" ID="ASPxFormLayout1" Width="100%" Height="100%">
                                <Items>
                                   
                                    <dx:LayoutItem Caption="">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                
                                                <p align="center">Please contact your Administration to update your profile</p>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem ShowCaption="False" Paddings-PaddingTop="19">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer>
                                                <dx:ASPxButton ID="btOK" runat="server" Text="OK" Width="80px" AutoPostBack="False" Style="float: right; margin-right: 8px">
                                                    <ClientSideEvents Click="function(s, e) {  pcLogin.Hide(); }" />
                                                </dx:ASPxButton>
                                                
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:ASPxFormLayout>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxPanel>
                
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ContentStyle>
            <Paddings PaddingBottom="5px" />
        </ContentStyle>
    </dx:ASPxPopupControl>
</asp:content>