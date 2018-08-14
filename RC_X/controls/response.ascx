<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="response.ascx.cs" Inherits="RC_X.controls.response" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%--<dx:ASPxCallbackPanel ID="callDesc" runat="server" Width="100%" Height="100%">
    <PanelCollection>
        <dx:PanelContent runat="server">--%>

            <dx:ASPxComboBox ID="dropMilestone" runat="server" Caption="Milestone      " Width="100%" ClientInstanceName="dropAssessment" EnableClientSideAPI="True" TextField="Name" ValueField="Id">
     
                <ClientSideEvents SelectedIndexChanged="SaveDropDownIndex" />
     
            </dx:ASPxComboBox>

            <dx:ASPxComboBox ID="dropAssessment" runat="server" Caption="Assessment" Width="100%" ClientInstanceName="dropAssessment" EnableClientSideAPI="True" TextField="Name" ValueField="Description">
     
                <ClientSideEvents SelectedIndexChanged="AssessmentChanged" />
     
            </dx:ASPxComboBox>
            <br />
            <dx:ASPxHtmlEditor ID="txResponse" runat="server" Width="100%" ClientInstanceName="txResponse">
                <ClientSideEvents HtmlChanged="ResponseChanged" />
                <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False" >
                </Settings>
                <SettingsHtmlEditing EnterMode="BR">
                </SettingsHtmlEditing>
                <SettingsResize AllowResize="True" />
            </dx:ASPxHtmlEditor>
            <div style="float: right; padding-top: 10px; padding-bottom: 10px;">
                <dx:ASPxButton ID="btSave" runat="server" Text="Save" OnClick="btSave_Click" RenderMode="Link">
                    <Image IconID="actions_apply_16x16">
                    </Image>
                </dx:ASPxButton>
                <dx:ASPxButton ID="btCancel" runat="server" Text="Cancel" OnClick="btCancel_Click" RenderMode="Link">
                    <Image IconID="actions_cancel_16x16">
                    </Image>
                </dx:ASPxButton>
            </div>

      <%--  </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>--%>




