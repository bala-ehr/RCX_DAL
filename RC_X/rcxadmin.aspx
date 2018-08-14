<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rcxadmin.aspx.cs" Inherits="RC_X.rcxadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmrcxAdmin" runat="server" >
        <dx:ASPxPopupControl ID="popAdmin" runat="server" CloseAction="None" Height="350px" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ShowCloseButton="False" ShowHeader="False" ShowOnPageLoad="True" ShowSizeGrip="False" Width="350px">
            <ContentCollection>
                <dx:PopupControlContentControl runat="server">
                    <div align="center" style="width: 439px"><br />
                        <dx:ASPxImage ID="imgLogo" ImageUrl="~/Content/Images/logo.png" width="162px" height="151" runat="server" ShowLoadingImage="true"></dx:ASPxImage>
                        <h3>Enterprise Admin Manager</h3>
                        <p>
                            Please enter enterprise name and select the database template.
                        </p>
                        
                        <dx:ASPxTextBox ID="ASPxTxtEnterprise" runat="server" Caption="Enterprise Name" Width="200px" xmlns:dx="devexpress.web">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom" ValidationGroup="ValidationGroup">
                                 <RequiredField ErrorText="Enterprise Name is required." IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                        
                        <dx:ASPxComboBox ID="ASPxCBDB" runat="server" Caption="Database Name" Width="200px" xmlns:dx="devexpress.web">
                            <CaptionSettings Position="Top" />
                            <ValidationSettings Display="Dynamic" ErrorDisplayMode="Text" ErrorTextPosition="Bottom" ValidationGroup="ValidationGroup">
                                 <RequiredField ErrorText="Database Name selection is required." IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxComboBox>

                        <br />
                        <dx:ASPxButton ID="ASPxBtnSubmit" runat="server" Text="Generate" OnClick="ASPxBtnSubmit_Click" ValidationGroup="ValidationGroup" xmlns:dx="devexpress.web">

                        </dx:ASPxButton>

                        <br />
                        <dx:ASPxLabel ID="ASPxLblStatus" runat="server" Text="Status:" Font-Bold="True" ForeColor="Red">

                        </dx:ASPxLabel>
                        <br />
                        <dx:ASPxTextBox ID="ASPxTxtEnterpriseUserName" runat="server" Caption="Enterprise User Name:" Width="200px" xmlns:dx="devexpress.web">
                            <CaptionSettings Position="Top" />
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="ASPxTxtEnterpriseUserPwd" runat="server" Caption="Enterprise User Password:" Width="200px" xmlns:dx="devexpress.web">
                            <CaptionSettings Position="Top" />
                        </dx:ASPxTextBox>
                        <br />
                        <dx:ASPxListBox ID="aspxLogger" runat="server" ValueType="System.String" Width="404px"></dx:ASPxListBox>
                        <br />
                        <table><tr>
                        <td style="width:33.33%;">
                            <dx:ASPxButton ID="ASPxBtnCheck" runat="server" Text="Check Login" xmlns:dx="devexpress.web" OnClick="ASPxBtnCheck_Click">
                            </dx:ASPxButton>
                        </td><td style="width:33.33%;">
                            <dx:ASPxButton ID="ASPxBtnUserHome" runat="server" Text="Goto UserHome" xmlns:dx="devexpress.web" OnClick="ASPxBtnUserHome_Click">
                            </dx:ASPxButton>
                        </td> <td style="width:8%"></td><td style="width:33.33%;">
                            <dx:ASPxButton ID="ASPxBtnClearAll" runat="server" Text="Clear All" xmlns:dx="devexpress.web" OnClick="ASPxBtnClearAll_Click" >
                            </dx:ASPxButton>
                        </td>  </tr> </table>
                        <br />
                    </div>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
    </form>
</body>
</html>
