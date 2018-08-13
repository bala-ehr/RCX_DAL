<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="superadmin.aspx.cs" Inherits="RC_X.superadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="sqlEnterprises" runat="server" ConnectionString="<%$ ConnectionStrings:RCXidentity %>" SelectCommand="SELECT * FROM [rc_enterprise]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="sqlSecurity" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" InsertCommand="INSERT INTO rc_security_user_roles_enterprise(entrole_user, entrole_roleID) VALUES (@entrole_user, @entrole_roleID)" SelectCommand="SELECT AspNetUsers.* FROM AspNetUsers">
                <InsertParameters>
                    <asp:Parameter Name="entrole_user" />
                    <asp:Parameter Name="entrole_roleID" />
                </InsertParameters>
            </asp:SqlDataSource>
            <dx:ASPxComboBox ID="comboEnterprises" runat="server" DataSourceID="sqlEnterprises" TextField="en_name" ValueField="en_id" Width="400px">
            </dx:ASPxComboBox>
            <dx:ASPxTextBox ID="txUsername" runat="server" Width="400px">
            </dx:ASPxTextBox>
            <dx:ASPxButton ID="btCreate" runat="server" OnClick="btCreate_Click" Text="Create User">
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lbResult" runat="server">
            </dx:ASPxLabel>
        </div>
    </form>
</body>
</html>
