<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="pro_business.aspx.cs" Inherits="RC_X.rc_project.pro_business" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <script type="text/javascript"  >
       function TestAlert(s, e) {
           debugger;
           var clientObject = ASPxClientButton.Cast(s)
           var key = clientObject.GetText();

           rootParameters.Set("xkey", key);
           popDesc = RootDockManager.GetPanelByUID("widgetDesc");
           popDesc.SetHeaderText("Description " + key);
           popDesc.Show();
           rootCall.Perform();
       }

    </script>

    <asp:Button ID="Button2" runat="server" Text="17D76461-CE01-4BF9-9837-3B1D3AA102C3" OnClick="Button2_Click" OnClientClick="TestAlert" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="999C0D7F-1FBB-45DC-A14F-004EADF880AA" OnClientClick="TestAlert"  />
  
   
</asp:Content>
