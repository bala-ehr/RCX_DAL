<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_workflow_multiassign.aspx.cs" Inherits="RC_X.rc_enterprise.ent_workflow_multiassign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <dx:ASPxFormLayout runat="server" ID="FL" UseDefaultPaddings="false" Width="100%">
        <Items>
            <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" ColCount="5" UseDefaultPaddings="false">
                <Items>
                    <dx:LayoutItem Caption="Project">
                        <Paddings PaddingBottom="0" />
                        <ParentContainerStyle>
                            <Paddings PaddingLeft="0" PaddingBottom="20" />
                        </ParentContainerStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="ddlProjects" runat="server" DropDownStyle="DropDown" AutoPostBack="false" TextField="Name" ValueField="Id">
                                    <%--<ClientSideEvents SelectedIndexChanged="OnDropdownIndexChanged" />--%>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Assigning To">
                        <Paddings PaddingBottom="0" />
                        <ParentContainerStyle>
                            <Paddings PaddingLeft="0" PaddingBottom="20" />
                        </ParentContainerStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="cmbUser" runat="server" TextField="Email" ValueField="UserID" AutoPostBack="false">
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Area for Assignment">
                        <Paddings PaddingTop="0" />
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="cmbArea" runat="server" DropDownStyle="DropDown" AutoPostBack="true" TextField="Name" ValueField="Id" OnSelectedIndexChanged="cmbArea_SelectedIndexChanged">
                                    <Items>
                                        <dx:ListEditItem Text="Business Area" Value="BusinessArea" />
                                        <dx:ListEditItem Text="Business Category" Value="BusinessCategory" />
                                        <dx:ListEditItem Text="Business Processess" Value="BusinessProcessess" />
                                        <dx:ListEditItem Text="RTM" Value="RTM" />
                                        <dx:ListEditItem Text="Project Management" Value="ProjectManagement" />
                                        <dx:ListEditItem Text="Tasks" Value="Tasks" />
                                        <dx:ListEditItem Text="Gaps/Goals" Value="Gaps/Goals" />
                                    </Items>
                                    <%-- <ClientSideEvents SelectedIndexChanged="OnDropdownIndexChanged" />--%>
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>

                    <dx:LayoutItem Caption="Due Date">
                        <Paddings PaddingBottom="0" />
                        <ParentContainerStyle>
                            <Paddings PaddingLeft="0" PaddingBottom="20" />
                        </ParentContainerStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxDateEdit ID="dateEdit" runat="server">
                                    <CalendarProperties>
                                        <FastNavProperties DisplayMode="Inline" />
                                    </CalendarProperties>
                                </dx:ASPxDateEdit>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="Status">
                        <Paddings PaddingBottom="0" />
                        <ParentContainerStyle>
                            <Paddings PaddingLeft="0" PaddingBottom="20" />
                        </ParentContainerStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="dropStatus" runat="server" AutoPostBack="false" TextField="Name" ValueField="Description" ValueType="System.String">
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxFormLayout runat="server" ID="ASPxFormLayout1" UseDefaultPaddings="false" Width="100%">
        <Items>
            <dx:LayoutGroup ShowCaption="False" GroupBoxDecoration="None" UseDefaultPaddings="false">
                <Items>

                    <dx:LayoutItem Caption="Area Items" Width="100%">
                        <Paddings PaddingBottom="0" />
                        <ParentContainerStyle>
                            <Paddings PaddingLeft="0" PaddingBottom="20" />
                        </ParentContainerStyle>
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                               
                                <dx:ASPxGridView ID="gridMultiAssign" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" OnRowInserting="gridMultiAssign_RowInserting" OnRowDeleting="gridMultiAssign_RowDeleting" Width="100%">
                                    <SettingsPager Mode="ShowAllRecords" />
                                    <SettingsBehavior AutoExpandAllGroups="true" />
                                    <Settings ShowFilterRow="True" />
                                    <SettingsCommandButton RenderMode="Image">
                                        <NewButton>
                                            <Image IconID="actions_add_16x16">
                                            </Image>
                                        </NewButton>
                                        <UpdateButton>
                                            <Image IconID="actions_apply_16x16">
                                            </Image>
                                        </UpdateButton>
                                        <CancelButton>
                                            <Image IconID="actions_cancel_16x16">
                                            </Image>
                                        </CancelButton>
                                        <DeleteButton>
                                            <Image IconID="actions_trash_16x16">
                                            </Image>
                                        </DeleteButton>
                                    </SettingsCommandButton>
                                    <EditFormLayoutProperties>
                                        <Items>
                                            <dx:GridViewColumnLayoutItem Caption=" ">
                                                <Template>
                                                    <dx:ASPxGridView ID="gridAssessItems" runat="server" AutoGenerateColumns="False" KeyFieldName="ID" Width="100%" OnInit="gridAssessItems_Init1">
                                                        <SettingsPager Mode="ShowAllRecords">
                                                        </SettingsPager>
                                                        <Settings ShowFilterRow="True" />
                                                        <SettingsCommandButton>
                                                            <NewButton>
                                                                <Image IconID="actions_add_16x16">
                                                                </Image>
                                                            </NewButton>
                                                            <CancelButton>
                                                                <Image IconID="actions_cancel_16x16">
                                                                </Image>
                                                            </CancelButton>
                                                            <DeleteButton>
                                                                <Image IconID="actions_trash_16x16">
                                                                </Image>
                                                            </DeleteButton>
                                                        </SettingsCommandButton>
                                                        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                        <Columns>
                                                             <dx:GridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                                                            </dx:GridViewCommandColumn>
                                                            <dx:GridViewDataTextColumn Caption="Item Name" FieldName="Name" VisibleIndex="2">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn Caption="Identifier" FieldName="Identifier" VisibleIndex="1">
                                                            </dx:GridViewDataTextColumn>
                                                            <dx:GridViewDataTextColumn FieldName="ID" Visible="False" VisibleIndex="4">
                                                            </dx:GridViewDataTextColumn>
                                                        </Columns>
                                                    </dx:ASPxGridView>
                                                </Template>
                                            </dx:GridViewColumnLayoutItem>
                                            <dx:EditModeCommandLayoutItem HorizontalAlign="Right">
                                            </dx:EditModeCommandLayoutItem>
                                        </Items>
                                    </EditFormLayoutProperties>
                                    <Columns>
                                        <dx:GridViewCommandColumn Caption=" " ShowDeleteButton="True" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="100px">
                                        </dx:GridViewCommandColumn>
                                        <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn FieldName="Item" ShowInCustomizationForm="True"  VisibleIndex="2">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Assigned By" FieldName="Manager" ShowInCustomizationForm="True" VisibleIndex="9">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" ShowInCustomizationForm="True" VisibleIndex="8">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataDateColumn FieldName="StatusDate" ShowInCustomizationForm="True" VisibleIndex="10" Caption="Date Changed" ReadOnly="True">
                                        </dx:GridViewDataDateColumn>
                                        <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataProgressBarColumn Caption="Progress" FieldName="StatusValue" ShowInCustomizationForm="True" VisibleIndex="4" Width="100px">
                                        </dx:GridViewDataProgressBarColumn>
                                        <dx:GridViewDataTextColumn Caption="Status" FieldName="Status" VisibleIndex="5">
                                        </dx:GridViewDataTextColumn>
                                        <dx:GridViewDataTextColumn Caption="Assigned To" FieldName="Worker" VisibleIndex="7">
                                        </dx:GridViewDataTextColumn>
                                    </Columns>
                                </dx:ASPxGridView>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>

                </Items>
            </dx:LayoutGroup>
        </Items>
    </dx:ASPxFormLayout>



</asp:Content>
