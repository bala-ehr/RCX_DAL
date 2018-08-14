<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="workflow.ascx.cs" Inherits="RC_X.controls.workflow" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.State" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web.Designer" tagprefix="dxchartdesigner" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHtmlEditor" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.Bootstrap.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.Bootstrap" tagprefix="dx" %>


    <dx:ASPxGridView ID="gridWorkflow" runat="server" AutoGenerateColumns="False" KeyFieldName="Id" Width="100%" OnRowInserting="gridWorkflow_RowInserting">
        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
        <Templates>
            <DetailRow>
                <dx:ASPxHtmlEditor ID="txDetails" runat="server" Html='<%# Eval("Comments") %>' Width="100%">
                    <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False">
                    </Settings>
                </dx:ASPxHtmlEditor>
            </DetailRow>
        </Templates>
        <SettingsEditing Mode="EditForm">
        </SettingsEditing>
        <Settings ShowFilterBar="Auto" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowPreview="True" UseFixedTableLayout="True" />

        <SettingsResizing ColumnResizeMode="Control" />
     
        <SettingsCookies Enabled="True" />
     
        <SettingsCommandButton RenderMode="Link">
            <NewButton>
                <Image AlternateText="Change Status" IconID="actions_add_16x16">
                </Image>
            </NewButton>
            <UpdateButton ButtonType="Link" RenderMode="Link">
                <Image AlternateText="Save" IconID="actions_apply_16x16" ToolTip="Save">
                </Image>
            </UpdateButton>
            <CancelButton ButtonType="Link" RenderMode="Link">
                <Image AlternateText="Cancel" IconID="actions_cancel_16x16" ToolTip="Cancel">
                </Image>
            </CancelButton>
        </SettingsCommandButton>
        <SettingsDataSecurity AllowDelete="False" />
        <EditFormLayoutProperties ColCount="2">
            <Items>
                <dx:GridViewColumnLayoutItem ColumnName="Status" Caption="Choose New Status" ColSpan="2">
                    <Template>
                        <dx:ASPxComboBox ID="dropStatus" runat="server" TextField="Name" ValueField="Description" ValueType="System.String" Width="100%" OnInit="dropStatus_Init">
                        </dx:ASPxComboBox>
                    </Template>
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem Caption="Choose User" ColumnName="wf_to">
                    <Template>
                        <dx:ASPxComboBox ID="dropUser" runat="server" TextField="Email" ValueField="UserID" ValueType="System.String"  OnInit="dropUser_Init">
                        </dx:ASPxComboBox>
                    </Template>
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColumnName="Due Date">
                </dx:GridViewColumnLayoutItem>
                <dx:GridViewColumnLayoutItem ColSpan="2" ColumnName="Comments">
                    <Template>
                        <dx:ASPxHtmlEditor ID="txComments" runat="server" Width="100%">
                            <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False">
                                <SettingsRibbonToolbar OneLineMode="True" />
                            </Settings>
                            <SettingsResize AllowResize="True" />
                        </dx:ASPxHtmlEditor>
                    </Template>
                </dx:GridViewColumnLayoutItem>
                <dx:EditModeCommandLayoutItem ColSpan="2" ShowUpdateButton="true" ShowCancelButton="true" HorizontalAlign="Right">
                </dx:EditModeCommandLayoutItem>
            </Items>
        </EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px" ButtonRenderMode="Image" ButtonType="Image">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ItemKey" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="wf_comments" ShowInCustomizationForm="True" Visible="False" VisibleIndex="11" Caption="Comments">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Assigned By" FieldName="Manager" ShowInCustomizationForm="True" VisibleIndex="9">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" ShowInCustomizationForm="True" VisibleIndex="8">
                <PropertiesDateEdit>
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn FieldName="StatusDate" ShowInCustomizationForm="True" VisibleIndex="10" Caption="Date Changed" ReadOnly="True">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataProgressBarColumn Caption="Progress" FieldName="StatusValue" ShowInCustomizationForm="True" VisibleIndex="4" Width="100px">
                <PropertiesProgressBar DisplayFormatString="" Maximum="3" displaymode="Position">
                </PropertiesProgressBar>
                <EditFormSettings Visible="False" />
            </dx:GridViewDataProgressBarColumn>
            <dx:GridViewDataTextColumn Caption="Status" FieldName="Status" VisibleIndex="5">
             
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
             
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Assigned To" FieldName="Worker" VisibleIndex="7">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
                <EditFormSettings Caption="Choose Assessor" />
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>



