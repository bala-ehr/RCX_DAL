<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ent_roadmap_view.aspx.cs" Inherits="RC_X.rc_enterprise.ent_roadmap_view" %>

<%@ Register Assembly="DevExpress.XtraCharts.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraCharts.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<%--<dx:ASPxDashboard ID="dashRoadmap" runat="server" WorkingMode="ViewerOnly" OnConfigureDataConnection="dashRoadmap_ConfigureDataConnection" DashboardXmlPath=""></dx:ASPxDashboard>--%>
    <asp:SqlDataSource ID="sqlChart" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" OnInit="sqlChart_Init"
        SelectCommand="SELECT rc_projects.pro_name, rc_projects.pro_color, rc_projects.pro_description, rc_projects.pro_startDate, rc_projects.pro_targetDate1, rc_projects.pro_targetDate2, rc_projects.pro_targetDate3, rc_projects.pro_endDate, rc_projects.pro_certificationDate, rc_projects.pro_actualEndDate, rc_projects.pro_roadmap, rc_projects.pro_projectManager, rc_projects.pro_status, rc_projects.pro_IsDeleted, rc_milestones.mil_name FROM rc_projects INNER JOIN rc_milestones ON rc_projects.pro_milestoneId = rc_milestones.mil_id WHERE (rc_projects.pro_IsDeleted = 0) AND (rc_projects.pro_roadmap= 1)"></asp:SqlDataSource>
    <br />

    <dx:WebChartControl ID="chartRoadmap" runat="server" CrosshairEnabled="True" DataSourceID="sqlChart" Width="1500px">
        <DiagramSerializable>
            <dx:GanttDiagram PaneDistance="5">
                <AxisX VisibleInPanesSerializable="-1">
                    <ConstantLines>
                        <dx:ConstantLine AxisValueSerializable="Enterprise ROadMap A" Name="Constant Line 1" Visible="False">
                        </dx:ConstantLine>
                    </ConstantLines>
                    <Label Angle="360" Font="Tahoma, 8pt, style=Bold">
                    </Label>
                </AxisX>
                <AxisY VisibleInPanesSerializable="-1">
                </AxisY>
            </dx:GanttDiagram>
        </DiagramSerializable>
        <Legend Name="Default Legend" Visibility="False"></Legend>
        <SeriesSerializable>
            <%--<dx:Series ArgumentDataMember="rm_title" LabelsVisibility="True" LegendName="Default Legend" Name="Start to Finish" ValueDataMembersSerializable="rm_startdate;rm_cmsreviewdate" ValueScaleType="DateTime">
                                    <ViewSerializable>
                                        <dx:OverlappedGanttSeriesView BarWidth="0.7" Color="242, 242, 242">
                                            <FillStyle FillMode="Gradient">
                                                <OptionsSerializable>
                                                    <dx:RectangleGradientFillOptions Color2="141, 179, 226" GradientMode="TopLeftToBottomRight" />
                                                </OptionsSerializable>
                                            </FillStyle>
                                        </dx:OverlappedGanttSeriesView>
                                    </ViewSerializable>
                                </dx:Series>--%>
            <dx:Series ArgumentDataMember="pro_name" ArgumentScaleType="Qualitative" LegendName="Default Legend" Name="Estimated Duration" ToolTipHintDataMember="pro_name" ValueDataMembersSerializable="pro_startDate;pro_endDate" ValueScaleType="DateTime" ColorDataMember="pro_status">
                <ViewSerializable>
                    <dx:SideBySideGanttSeriesView BarWidth="0.1" Color="0, 119, 164">
                        <LinkOptions ColorSource="OwnColor" />
                        <FillStyle FillMode="Solid">
                        </FillStyle>
                    </dx:SideBySideGanttSeriesView>
                </ViewSerializable>
            </dx:Series>
            <%--<dx:Series ArgumentDataMember="rm_title" Name="Estimate Error" ValueDataMembersSerializable="rm_estimatedend;rm_actualend" ValueScaleType="DateTime">
                                    <ViewSerializable>
                                        <dx:SideBySideGanttSeriesView BarWidth="0.5" Color="255, 111, 112">
                                            <LinkOptions ColorSource="ParentBorderColor" />
                                            <FillStyle FillMode="Solid">
                                            </FillStyle>
                                        </dx:SideBySideGanttSeriesView>
                                    </ViewSerializable>
                                </dx:Series>--%>
            <%--<dx:Series ArgumentDataMember="rm_title" ArgumentScaleType="Qualitative" LegendName="Default Legend" Name="Actual Duration" ValueDataMembersSerializable="rm_startdate;rm_actualend" ValueScaleType="DateTime">
                                    <ViewSerializable>
                                        <dx:SideBySideGanttSeriesView BarWidth="0.5" Color="161, 214, 105">
                                            <LinkOptions ColorSource="OwnColor" />
                                            <FillStyle FillMode="Solid">
                                            </FillStyle>
                                        </dx:SideBySideGanttSeriesView>
                                    </ViewSerializable>
                                </dx:Series>--%>
            <%--<dx:Series ArgumentDataMember="rm_title" ArgumentScaleType="Qualitative" Name="Review Period" ValueDataMembersSerializable="rm_actualend;rm_cmsreviewdate" ValueScaleType="DateTime">
                                    <ViewSerializable>
                                        <dx:SideBySideGanttSeriesView BarWidth="0.5" Color="255, 254, 175">
                                            <FillStyle FillMode="Solid">
                                            </FillStyle>
                                        </dx:SideBySideGanttSeriesView>
                                    </ViewSerializable>
                                </dx:Series>--%>
        </SeriesSerializable>
    </dx:WebChartControl>


    <br />

    <dx:ASPxGridView ID="gridProjects" runat="server" AutoGenerateColumns="False" KeyFieldName="ProjectID" Width="100%">
       
       
        <SettingsPager Mode="ShowAllRecords">
        </SettingsPager>
        <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="true" />
         <SettingsBehavior AllowFocusedRow="true" />
        <Columns>
            <dx:GridViewDataTextColumn FieldName="ProjectID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Project Name" FieldName="ProjectName" ShowInCustomizationForm="True" VisibleIndex="1">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColorEditColumn Caption="Color ID" FieldName="ProjectColor" ShowInCustomizationForm="True" VisibleIndex="2" Visible="false" Width="50px">
                <PropertiesColorEdit EnableCustomColors="True">
                </PropertiesColorEdit>
            </dx:GridViewDataColorEditColumn>
            <dx:GridViewDataMemoColumn Caption="Description" FieldName="Description" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                <PropertiesMemoEdit Rows="20">
                </PropertiesMemoEdit>
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataComboBoxColumn Caption="Milestone" FieldName="MilestoneName" VisibleIndex="4">
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" ShowInCustomizationForm="True" VisibleIndex="5" >
                <PropertiesDateEdit DisplayFormatString="" EnableFocusedStyle="False">
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Estimated End Date" FieldName="EstimatedEndDate" ShowInCustomizationForm="True" VisibleIndex="6" >
                <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 1" FieldName="TargetDate1" ShowInCustomizationForm="True" VisibleIndex="7" Visible="false" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 2" FieldName="TargetDate2" ShowInCustomizationForm="True" VisibleIndex="8" Visible="false" Width="75px">
                <PropertiesDateEdit AllowNull="true" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataDateColumn Caption="Target Date 3" FieldName="TargetDate3" ShowInCustomizationForm="True" VisibleIndex="9" Visible="false" Width="75px">
                <PropertiesDateEdit AllowNull="True" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataImageColumn Caption="Status" FieldName="Status" ShowInCustomizationForm="true" Visible="false">

            </dx:GridViewDataImageColumn>
            <dx:GridViewDataComboBoxColumn Caption="Status" FieldName="Status" ShowInCustomizationForm="True" VisibleIndex="10" >
                <DataItemTemplate>
                     <img id="img" runat="server" src='<%# GetImageName(Eval("Status")) %>' />
                </DataItemTemplate>
            </dx:GridViewDataComboBoxColumn>

            <dx:GridViewDataDateColumn Caption="Actual End Date" FieldName="ActualEndDate" ShowInCustomizationForm="True" VisibleIndex="11" Visible="false" Width="75px">
                <PropertiesDateEdit AllowNull="False" DisplayFormatString="MMM/d/yyyy">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>

            <dx:GridViewDataDateColumn Caption="Certification Date" FieldName="CertificationDate" ShowInCustomizationForm="True" VisibleIndex="12" Visible="false" Width="75px">
                <PropertiesDateEdit DisplayFormatString="">
                </PropertiesDateEdit>
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn Caption="Project Manager" FieldName="PMName" ShowInCustomizationForm="True" VisibleIndex="13">
                <PropertiesTextEdit>
                    <ValidationSettings>
                        <RequiredField ErrorText="" IsRequired="True" />
                    </ValidationSettings>
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
           
            <dx:GridViewDataCheckColumn Caption="Roadmap?" FieldName="Roadmap" ShowInCustomizationForm="True" VisibleIndex="14" Visible="false" Width="50px">
                <PropertiesCheckEdit AllowGrayedByClick="False" ValueGrayed="False">
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </PropertiesCheckEdit>
            </dx:GridViewDataCheckColumn>
        </Columns>
    </dx:ASPxGridView>
                        
</asp:Content>

