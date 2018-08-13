<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="evaluation.ascx.cs" Inherits="RC_X.controls.evaluation" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>

<dx:ASPxCallbackPanel ID="callEvaluation" runat="server" ClientInstanceName="callEvaluation" Width="100%">
    <PanelCollection>
        <dx:PanelContent runat="server">
            <dx:ASPxGridView ID="gridEvaluation" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="eval_id"
                OnRowInserting="gridEvaluation_RowInserting">
                <SettingsCommandButton>
                    <NewButton Text="New">
                        <Image IconID="actions_add_16x16" ToolTip="New">
                        </Image>
                    </NewButton>
                    <UpdateButton Text="Save">
                        <Image IconID="actions_apply_16x16" ToolTip="Save">
                        </Image>
                    </UpdateButton>
                    <CancelButton Text="Cancel">
                        <Image IconID="actions_cancel_16x16" ToolTip="Cancel">
                        </Image>
                    </CancelButton>
                    <EditButton>
                        <Image IconID="actions_editname_16x16" ToolTip="Edit">
                        </Image>
                    </EditButton>
                    <DeleteButton>
                        <Image IconID="edit_delete_16x16" ToolTip="Delete">
                        </Image>
                    </DeleteButton>
                </SettingsCommandButton>

                <Columns>
                    <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="False" ShowEditButton="False" ShowInCustomizationForm="True" ShowNewButtonInHeader="True" VisibleIndex="0" Width="50px">
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="eval_id" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="eval_responseID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Reviewer" FieldName="eval_by" ShowInCustomizationForm="True" VisibleIndex="3">
                       
                         <EditFormSettings Visible="False" />
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataDateColumn Caption="Reviewer Date" FieldName="eval_date" ShowInCustomizationForm="True" VisibleIndex="4">
                        <PropertiesDateEdit DisplayFormatString="yyyy/MM/dd hh:mm:ss">
                        </PropertiesDateEdit>
                    </dx:GridViewDataDateColumn>
                    <dx:GridViewDataComboBoxColumn Caption="Reviewer Assessment" FieldName="eval_reviewer_assessments" ShowInCustomizationForm="True" VisibleIndex="5">
                        <PropertiesComboBox TextField="Reviewer Assesment" ValueField="eval_reviewer_assessments">
                            <Items>
                                <dx:ListEditItem Text="Meets" Value="0" />
                                <dx:ListEditItem Text="Partialy Meets" Value="1" />
                                <dx:ListEditItem Text="Doesn't Meets" Value="2" />
                                <dx:ListEditItem Text="Not Assessed" Value="3" />
                            </Items>
                        </PropertiesComboBox>
                    </dx:GridViewDataComboBoxColumn>
                    <dx:GridViewDataTextColumn Caption="Reviewer Comments" FieldName="eval_description" ShowInCustomizationForm="True" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="eval_projectID" ShowInCustomizationForm="True" VisibleIndex="7" Visible="false">
                    </dx:GridViewDataTextColumn>
                </Columns>
                <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowFooter="true" />
                <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                <SettingsBehavior AllowFocusedRow="true" />
                <SettingsSearchPanel CustomEditorID="tbToolbarSearch" />
                <SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="DataAware" />
               
                <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupPanelMenu="True" EnableRowMenu="True">
                </SettingsContextMenu>
                <SettingsAdaptivity AdaptivityMode="HideDataCells">
                </SettingsAdaptivity>
                <Toolbars>
                    <dx:GridViewToolbar ItemAlign="Right" EnableAdaptivity="true">
                        <Items>

                            <dx:GridViewToolbarItem Command="Refresh" Image-IconID="spreadsheet_refreshallpivottable_16x16" />
                            <dx:GridViewToolbarItem Text="Export to" Image-IconID="actions_download_16x16office2013" BeginGroup="true">
                                <Items>
                                    <dx:GridViewToolbarItem Command="ExportToPdf" />
                                    <dx:GridViewToolbarItem Command="ExportToDocx" />
                                    <dx:GridViewToolbarItem Command="ExportToRtf" />
                                    <dx:GridViewToolbarItem Command="ExportToCsv" />
                                    <dx:GridViewToolbarItem Command="ExportToXls" />
                                </Items>
                                <Image IconID="actions_download_16x16office2013"></Image>
                            </dx:GridViewToolbarItem>
                            <dx:GridViewToolbarItem BeginGroup="true">
                                <ItemStyle Width="250px" />
                                <Template>
                                    <dx:ASPxButtonEdit ID="tbToolbarSearch" runat="server" NullText="Search..." Height="100%" Width="250px">
                                        <Buttons>
                                            <dx:SpinButtonExtended Image-IconID="find_find_16x16gray" />
                                        </Buttons>
                                    </dx:ASPxButtonEdit>
                                </Template>
                            </dx:GridViewToolbarItem>
                        </Items>
                    </dx:GridViewToolbar>
                </Toolbars>
                <EditFormLayoutProperties ColCount="2">
                    <Items>
                        <dx:GridViewLayoutGroup ColCount="2" GroupBoxDecoration="None">
                            <Items>
                              <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_by" Width="100%" />--%>
                                <dx:GridViewColumnLayoutItem ColumnName="eval_reviewer_assessments" Width="100%" />
                                <dx:GridViewColumnLayoutItem Caption="Reviewer Comments" Width="100%" VerticalAlign="Top" ColumnName="eval_description">
                                    <Template>
                                        <dx:ASPxMemo ID="reviewerComments" runat="server" Width="100%" Height="253" Text='<%# Bind("[eval_description]") %>' />
                                        
                                    </Template>
                                </dx:GridViewColumnLayoutItem>
                            </Items>
                        </dx:GridViewLayoutGroup>
                        <dx:GridViewLayoutGroup GroupBoxDecoration="None">
                            <Items>
                              <%--  <dx:GridViewColumnLayoutItem ColumnName="eval_date"/>--%>
                                <dx:GridViewColumnLayoutItem Caption="Reviewer Date" VerticalAlign="Top">
                                    <Template>
                                        <div>
                                           <%-- <dx:ASPxCalendar ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>' CssClass="hireDateCalendar" />--%>
                                            <dx:ASPxDateEdit ID="reviewerDate" runat="server" Value='<%# Bind("[eval_date]") %>'>
                                                <TimeSectionProperties Adaptive="true">
                                                    <TimeEditProperties EditFormatString="hh:mm tt" />
                                                </TimeSectionProperties>
                                                <CalendarProperties>
                                                    <FastNavProperties DisplayMode="Popup" />
                                                </CalendarProperties>
                                            </dx:ASPxDateEdit>
                                        </div>
                                    </Template>
                                </dx:GridViewColumnLayoutItem>
                            </Items>
                        </dx:GridViewLayoutGroup>
                        <dx:EditModeCommandLayoutItem Width="100%" HorizontalAlign="Right" />
                    </Items>
                    <SettingsAdaptivity AdaptivityMode="SingleColumnWindowLimit" SwitchToSingleColumnAtWindowInnerWidth="700" />
                </EditFormLayoutProperties>
            </dx:ASPxGridView>

        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
