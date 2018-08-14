<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_rtmplanning_reports.aspx.cs" Inherits="RC_X.rc_enterprise.ent_rtmplanning_reports" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <dx:ASPxPivotGrid ID="pivotGrid" runat="server" ClientInstanceName="pivotGrid" DataSourceID="sqlRTMPlanning" Width="100%">
        <Fields>
            <dx:PivotGridField Area="RowArea" AreaIndex="0" FieldName="ChecklistType" ID="fieldChecklistType" Caption="CheckList Type" />
            <dx:PivotGridField Area="RowArea" AreaIndex="1" FieldName="SRCTitle" ID="fieldSRCTitle" Caption="SRCTitle" />
            <dx:PivotGridField Area="RowArea" AreaIndex="2" FieldName="Criteria" ID="fieldCriteria" Caption="Criteria" />
            <dx:PivotGridField Area="ColumnArea" AreaIndex="1" FieldName="Projectname" ID="fieldProjectName" Caption="Project" ValueFormat-FormatString="Project {0}" />
            <dx:PivotGridField Area="DataArea" AreaIndex="0" FieldName="score" ID="fieldScore" Caption="Score" />
        </Fields>

        <OptionsView HorizontalScrollBarMode="Auto" />
        <OptionsFilter NativeCheckBoxes="False" />
        <OptionsPager Position="Bottom" RowsPerPage="25" ColumnsPerPage="15" AlwaysShowPager="True">
            <Summary Visible="False" />
        </OptionsPager>
    </dx:ASPxPivotGrid>
    <asp:SqlDataSource ID="sqlRTMPlanning" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" 
        SelectCommand="select prj.project_Id, prj.project_name Projectname, prj.project_color, 
		                chk.ch_id, chk.ch_title ChecklistType, cri.src_id, cri.src_title SRCTitle, cri.src_criteria Criteria,
		                rtm.plan_isActive score
                        from [dbo].[rc_preplaning_project] prj
                        cross join [dbo].[rc_rtm_criteria] cri
                        inner join [dbo].[rc_rtm_objectives] obj ON cri.src_objective = obj.bo_id
                        inner join [dbo].[rc_rtm_checklists] chk ON obj.bo_checklist = chk.ch_id
                        left join [dbo].[rc_RTM_Planning] rtm ON prj.project_Id = rtm.plan_projectId and cri.src_id = rtm.plan_criteriaId
                        order by chk.ch_id, prj.project_Id">

    </asp:SqlDataSource>
    <br/>
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="pivotGrid" Visible="False" />
    <dx:ASPxFormLayout runat="server" ID="OptionsFormLayout" ClientInstanceName="optionsFormLayout">
        <Items>
            <dx:LayoutGroup Caption="Export Selection">
                <Items>
                    <dx:LayoutItem Caption="Export Mode">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxComboBox ID="listExportFormat" runat="server" Style="vertical-align: middle" SelectedIndex="0"
                                    ValueType="System.String" Width="220px" Height="23px">
                                    <Items>
                                       
                                        <dx:ListEditItem Text="Excel" Value="0" />
                                       
                                    </Items>
                                   
                                </dx:ASPxComboBox>
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                    <dx:LayoutItem Caption="">
                        <LayoutItemNestedControlCollection>
                            <dx:LayoutItemNestedControlContainer>
                                <dx:ASPxButton ID="ASPxButton3" ClientInstanceName=" " runat="server" ToolTip="Export and Save"
                                    OnClick="ASPxButton3_Click1" Text="Export" Width="220px" />
                            </dx:LayoutItemNestedControlContainer>
                        </LayoutItemNestedControlCollection>
                    </dx:LayoutItem>
                   </Items>
            </dx:LayoutGroup>
            
           
        </Items>
    </dx:ASPxFormLayout>
</asp:Content>
