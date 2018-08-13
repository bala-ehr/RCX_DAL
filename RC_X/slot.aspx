<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slot.aspx.cs" Inherits="RC_X.slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       table, th, td {
   border: 1px solid black;
}
    </style>
</head>
<body>
      
    <form id="form1" runat="server">
        <div>
            Version and slot information: <br />
            <table>
                <tr >
                    <td >Deployment Slot:   </td>
                    <td > <asp:Label ID="CurrentSlot" runat="server" Text=" <%$ appSettings: CurrentSlot %>"></asp:Label><br /></td>
                </tr>
                <tr>
                    <td>Build ID:   </td>
                    <td><asp:Label ID="BuildID" runat="server" Text=" <%$ appSettings: rcx_build_name %>"/></td>
                </tr>
                <tr>
                    <td>Current Code Branch:  </td>
                    <td><asp:Label ID="Label1" runat="server" Text=" <%$ appSettings: rcx_branch %>"/></td>
                </tr>
                <tr>
                    <td>Git Commit ID:  </td>
                    <td><asp:Label ID="Label2" runat="server" Text=" <%$ appSettings: rcx_commit_short %>"/></td>
                </tr>
                <tr>
                    <td>Current Code Branch:  </td>
                    <td><asp:Label ID="Label3" runat="server" Text=" <%$ appSettings: rcx_branch %>"/></td>
                </tr>
                <tr>
                    <td>Pull Request ID:  </td>
                    <td><asp:Label ID="Label4" runat="server" Text=" <%$ appSettings: rcx_repo_pull %>"/></td>
                </tr>
                <tr>
                    <td>PR from:  </td>
                    <td><asp:Label ID="Label5" runat="server" Text=" <%$ appSettings: rcx_repo_pullfrom %>"/></td>
                </tr>
                <tr>
                    <td>PR to:  </td>
                    <td><asp:Label ID="Label6" runat="server" Text=" <%$ appSettings: rcx_repo_pullto %>"/></td>
                </tr>
                <tr>
                    <td>Git Repository Home:  </td>
                    <td><asp:Label ID="Label7" runat="server" Text=" <%$ appSettings: rcx_repo_origin %>"/></td>
                </tr>
                <tr>
                    <td>Full Commit SHA:  </td>
                    <td><asp:Label ID="Commit" runat="server" Text=" <%$ appSettings: rcx_commit %>"/></td>
                </tr>
            </table>
            <br />
            <dx:ASPxHyperLink ID="linkGit" runat="server" NavigateUrl="https://github.com/ffcruz85/RCX/commit/" Target="_blank" Text="View Commit on Github" />
            <br />
            <br />
            <dx:ASPxMemo ID="txCommitMessage" runat="server" Caption="Commit Message" Rows="10" Text="<%$ appSettings: rcx_commit_message %>" Width="100%">
            </dx:ASPxMemo>
            <br />
            <br />
            
     
        </div>
        <dx:ASPxButton ID="btCallback" runat="server" AutoPostBack="False" ClientInstanceName="btcallback" EnableClientSideAPI="True" Text="Throw Callback Error">
            <ClientSideEvents Click="function(s, e) {
callPanel.PerformCallback();	
}" />
        </dx:ASPxButton>
        <dx:ASPxButton ID="btPostBack" runat="server" OnClick="btPostBack_Click" Text="Throw Postback error">
        </dx:ASPxButton>
        <dx:ASPxCallbackPanel ID="ASPxCallbackPanel1" runat="server" ClientInstanceName="callPanel" EnableClientSideAPI="True" OnCallback="ASPxCallbackPanel1_Callback" Width="200px">
        </dx:ASPxCallbackPanel>
    </form>
</body>
</html>
