<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="rc_error.aspx.cs" Inherits="RC_X.controls.rc_error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    <br />
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" Width="100%">
        <Items>
            <dx:LayoutItem HorizontalAlign="Center" ShowCaption="False">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxLabel ID="ASPxFormLayout1_E1" runat="server" Text="We are sorry, you have either requested a feature not yet released or encoutered an error. Our support team has been notified of this event.">
                        </dx:ASPxLabel>
                        <br />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:EmptyLayoutItem>
            </dx:EmptyLayoutItem>
            <dx:LayoutItem HorizontalAlign="Center" ShowCaption="False">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxButton ID="ASPxFormLayout1_E3" runat="server" HorizontalAlign="Center" Text="Go Back" OnClick="ASPxFormLayout1_E3_Click" AutoPostBack="True" ClientInstanceName="GoBackButton" EnableClientSideAPI="True">
                           <%-- <ClientSideEvents Click="GoBackAfterError" />--%>
                        </dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
        <SettingsItems HorizontalAlign="Center" />
    </dx:ASPxFormLayout>
    <br />
</asp:Content>
