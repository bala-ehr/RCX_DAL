<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="scorecard.ascx.cs" Inherits="RC_X.controls.scorecard" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dx" %>
<%--<dx:ASPxCallbackPanel ID="callScore" runat="server" ClientInstanceName="callScore" EnableClientSideAPI="True" OnCallback="callScore_Callback" Width="100%" HideContentOnCallback="false">
    <PanelCollection>
<dx:PanelContent runat="server">--%>
<script type="text/javascript">
    function ScoreCol1(s, e) {
        var indices = gridScorecard.batchEditApi.GetRowVisibleIndices();
        var Score = s.GetSelectedItem().value;
        var ColumnName = "score_col1";
        var ColumnNumber = 11;


        for (var i = 0; i < indices.length; i++) {
            gridScorecard.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
        }
    }

    function ScoreCol2(s, e) {
        var indices = gridScorecard.batchEditApi.GetRowVisibleIndices();
        var Score = s.GetSelectedItem().value;
        var ColumnName = "score_col2";
        var ColumnNumber = 12;


        for (var i = 0; i < indices.length; i++) {
            gridScorecard.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
        }
    }
    function ScoreCol3(s, e) {
        var indices = gridScorecard.batchEditApi.GetRowVisibleIndices();
        var Score = s.GetSelectedItem().value;
        var ColumnName = "score_col3";
        var ColumnNumber = 13;


        for (var i = 0; i < indices.length; i++) {
            gridScorecard.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
        }
    }
    function ScoreCol4(s, e) {
        var indices = gridScorecard.batchEditApi.GetRowVisibleIndices();
        var Score = s.GetSelectedItem().value;
        var ColumnName = "score_col4";
        var ColumnNumber = 14;


        for (var i = 0; i < indices.length; i++) {
            gridScorecard.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
        }
    }
    function ScoreCol5(s, e) {
        var indices = gridScorecard.batchEditApi.GetRowVisibleIndices();
        var Score = s.GetSelectedItem().value;
        var ColumnName = "score_col5";
        var ColumnNumber = 15;


        for (var i = 0; i < indices.length; i++) {
            gridScorecard.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
        }
    }
    function QuickSave(s, e) {
        gridScorecard.UpdateEdit();

    }
    function SaveScoreDescription(s, e) { btSaveScoreDescription.PerformCallback(); }
    function CancelDescription(s, e) {
        txScoreDescription.PerformDataCallback();
    }

    function xButtonAttachScorecard(s, e)
    {
        switch (e.buttonID)
        {
            
            case "actionAttach":
                
                gridScorecard.GetRowValues(gridScorecard.GetFocusedRowIndex(), "stan_id", OnGetRowValues);
                break;
        }
    }
    function OnGetRowValues(standardKey) {
        
        OpenWidget("RefreshAttach", standardKey);
    }



</script>
<%----%>
<dx:ASPxHiddenField ID="paramScore" runat="server" ClientInstanceName="paramScore" OnCustomCallback="paramScore_CustomCallback" >
</dx:ASPxHiddenField>
<asp:SqlDataSource ID="sqlScores" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT rc_scorecards_standards.stan_standard, rc_scorecards_standards.stan_id, rc_scorecards_standards.stan_card, rc_scorecards_scores.score_projectid, rc_scorecards_scores.score_itemid, rc_scorecards_scores.score_col1, rc_scorecards_scores.score_colmeasure1, rc_scorecards_scores.score_col2, rc_scorecards_scores.score_colmeasure2, rc_scorecards_scores.score_col3, rc_scorecards_scores.score_colmeasure3, rc_scorecards_scores.score_col4, rc_scorecards_scores.score_colmeasure4, rc_scorecards_scores.score_col5, rc_scorecards_scores.score_colmeasure5, rc_scorecards.card_id, rc_scorecards.card_name, rc_scorecards_scores.score_id FROM rc_scorecards_standards LEFT OUTER JOIN rc_scorecards_scores ON rc_scorecards_standards.stan_id = rc_scorecards_scores.score_standard FULL OUTER JOIN rc_scorecards ON rc_scorecards_standards.stan_card = rc_scorecards.card_id WHERE (rc_scorecards_scores.score_projectid = @score_projectid) AND (rc_scorecards.card_id = @card_id) AND (rc_scorecards_scores.score_itemid = @score_itemid)" UpdateCommand="UPDATE rc_scorecards_scores SET score_col1 = @score_col1, score_colmeasure1 = @score_colmeasure1, score_col2 = @score_col2, score_colmeasure2 = @score_colmeasure2, score_col3 = @score_col3, score_colmeasure3 = @score_colmeasure3, score_col4 = @score_col4, score_colmeasure4 = @score_colmeasure4, score_col5 = @score_col5, score_colmeasure5 = @score_colmeasure5 WHERE (score_id = @score_id)">
    <SelectParameters>
        <asp:Parameter Name="score_projectid" />
        <asp:Parameter Name="card_id" />
        <asp:Parameter Name="score_itemid" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="score_col1" />
        <asp:Parameter Name="score_colmeasure1" />
        <asp:Parameter Name="score_col2" />
        <asp:Parameter Name="score_colmeasure2" />
        <asp:Parameter Name="score_col3" />
        <asp:Parameter Name="score_colmeasure3" />
        <asp:Parameter Name="score_col4" />
        <asp:Parameter Name="score_colmeasure4" />
        <asp:Parameter Name="score_col5" />
        <asp:Parameter Name="score_colmeasure5" />
        <asp:Parameter Name="score_id" />
    </UpdateParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="sqlValues" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>"  
    SelectCommand="SELECT value_id, value_standard, value_score, value_scoretext, value_measures FROM rc_scorestandard_values WHERE (value_standard = @stan_id) ORDER BY value_score">
    <SelectParameters>
        <asp:Parameter Name="stan_id" DbType="Guid" />
    </SelectParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="sqlCards" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT rc_scorecards.card_id, rc_scorecards.card_name, rc_scorecards.card_measure, rc_scorecards.card_measure_notes, rc_scorecards.card_desc, rc_scorecards.card_col1, rc_scorecards.card_measure1, rc_scorecards.card_colenabled1, rc_scorecards.card_col2, rc_scorecards.card_measure2, rc_scorecards.card_colenabled2, rc_scorecards.card_col3, rc_scorecards.card_measure3, rc_scorecards.card_colenabled3, rc_scorecards.card_col4, rc_scorecards.card_measure4, rc_scorecards.card_colenabled4, rc_scorecards.card_col5, rc_scorecards.card_measure5, rc_scorecards.card_colenabled5, rc_scorecards_matrix.matrix_itemkey FROM rc_scorecards INNER JOIN rc_scorecards_matrix ON rc_scorecards.card_id = rc_scorecards_matrix.matrix_card WHERE (rc_scorecards_matrix.matrix_itemkey = @matrix_itemkey)">
    <SelectParameters>
        <asp:SessionParameter Name="matrix_itemkey" SessionField="score_itemid" />
    </SelectParameters>
</asp:SqlDataSource>
Select a scorecard:<dx:ASPxComboBox ID="dropScorecard" ClientInstanceName="dropScorecard" runat="server" DataSourceID="sqlCards" TextField="card_name" ValueField="card_id" Width="100%" ForceDataBinding="True" OnSelectedIndexChanged="dropScorecard_SelectedIndexChanged">
    <ClientSideEvents SelectedIndexChanged="ScorecardSelected" />
    <Columns>
        <dx:ListBoxColumn Caption="card_id" FieldName="card_id" Name="card_id" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn Caption="Scorecard" FieldName="card_name" Name="scorecard" Width="30%">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn Caption="Description" FieldName="card_desc" Name="score">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_col1" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_col2" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_col3" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_col4" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_col5" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_colenabled1" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_colenabled2" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_colenabled3" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_colenabled4" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_colenabled5" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure1" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure2" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure3" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure4" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure5" Visible="False">
        </dx:ListBoxColumn>
        <dx:ListBoxColumn FieldName="card_measure" Visible="False">
        </dx:ListBoxColumn>
    </Columns>
</dx:ASPxComboBox>

<dx:ASPxPageControl ID="pageScore" runat="server" ActiveTabIndex="0" Width="100%" OnActiveTabChanged="pageScore_ActiveTabChanged" TabAlign="Justify">
    <TabPages>
        <dx:TabPage Name="quick" Text="Quick Score">
            <ContentCollection>
                <dx:ContentControl runat="server">
                    <%--TextField="value_scoretext" TextFormatString="{0} - {1}" ValueField="value_score"--%>
                    <dx:ASPxComboBox ID="ComboHeader1" runat="server" ClientInstanceName="ComboHeader1" EnableClientSideAPI="True"   Width="100%" Visible="False">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol1" />
                            <Items>
                                 <dx:ListEditItem  Value="0"/>
                                <dx:ListEditItem  Value="1" />
                                <dx:ListEditItem  Value="2" />
                                <dx:ListEditItem  Value="3" />
                                <dx:ListEditItem  Value="4" />
                                <dx:ListEditItem  Value="5" />
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                    <dx:ASPxComboBox ID="ComboHeader2" runat="server" ClientInstanceName="ComboHeader2" EnableClientSideAPI="True"  Width="100%" Visible="False">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol2" />
                                <Items>
                                 <dx:ListEditItem  Value="0" />
                                <dx:ListEditItem  Value="1" />
                                <dx:ListEditItem  Value="2" />
                                <dx:ListEditItem  Value="3" />
                                <dx:ListEditItem  Value="4" />
                                <dx:ListEditItem  Value="5" />
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                    <dx:ASPxComboBox ID="ComboHeader3" runat="server" ClientInstanceName="ComboHeader3" EnableClientSideAPI="True"  Width="100%" Visible="False">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol3" />
                   <Items>
                                 <dx:ListEditItem  Value="0" />
                                <dx:ListEditItem  Value="1" />
                                <dx:ListEditItem  Value="2" />
                                <dx:ListEditItem  Value="3" />
                                <dx:ListEditItem  Value="4" />
                                <dx:ListEditItem  Value="5" />
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                    <dx:ASPxComboBox ID="ComboHeader4" runat="server" ClientInstanceName="ComboHeader4" EnableClientSideAPI="True"  Width="100%" Visible="False">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol4" />
                                  <Items>
                                 <dx:ListEditItem  Value="0" />
                                <dx:ListEditItem  Value="1" />
                                <dx:ListEditItem  Value="2" />
                                <dx:ListEditItem  Value="3" />
                                <dx:ListEditItem  Value="4" />
                                <dx:ListEditItem  Value="5" />
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                    <dx:ASPxComboBox ID="ComboHeader5" runat="server" ClientInstanceName="ComboHeader5" EnableClientSideAPI="True"  Width="100%" Visible="False">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol5" />
                                    <Items>
                                 <dx:ListEditItem  Value="0" />
                                <dx:ListEditItem  Value="1" />
                                <dx:ListEditItem  Value="2" />
                                <dx:ListEditItem  Value="3" />
                                <dx:ListEditItem  Value="4" />
                                <dx:ListEditItem  Value="5" />
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                    <br />
                    <div style="float: right; padding-top: 10px; padding-bottom: 10px;">
                        <dx:ASPxButton ID="btQuickSave" runat="server" AutoPostBack="False" ClientInstanceName="btQuickSave" EnableClientSideAPI="True" Text="Save" RenderMode="Link" Visible="False">
                            <ClientSideEvents Click="QuickSave" />
                            <Image IconID="actions_apply_16x16">
                            </Image>
                        </dx:ASPxButton>
                    </div>
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
        <dx:TabPage Name="detailed" Text="Detailed Scores">
            <ContentCollection>
                <dx:ContentControl runat="server">
                    <dx:ASPxGridView ID="gridScorecard" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridScorecard" 
                        DataSourceID="sqlScores" KeyFieldName="stan_id" OnBatchUpdate="gridScorecard_BatchUpdate"
                        OnDataBound="gridScorecard_DataBound" OnRowUpdated="gridScorecard_RowUpdated"
                        Visible="False" Width="100%" OnCellEditorInitialize="Grid_CellEditorInitialize">
                        <ClientSideEvents BatchEditStartEditing="loadStandardValues" CustomButtonClick="xGridButton" BatchEditChangesSaving="ResetHiddenField"  /> <%--FocusedRowChanged="xGridFocus"--%>
                        <SettingsPager Mode="ShowAllRecords" PageSize="100">
                        </SettingsPager>
                        <SettingsEditing Mode="Batch" BatchEditSettings-EditMode="Row">
                        <BatchEditSettings EditMode="Row"></BatchEditSettings>
                        </SettingsEditing>
                        <SettingsBehavior AllowFocusedRow="True" />
                        <SettingsResizing ColumnResizeMode="Control" />
                        <SettingsCookies Enabled="True" StoreControlWidth="True" />
                        <SettingsCommandButton>
                            <UpdateButton>
                                <Image IconID="actions_apply_16x16">
                                </Image>
                            </UpdateButton>
                            <CancelButton>
                                <Image IconID="actions_cancel_16x16">
                                </Image>
                            </CancelButton>
                        </SettingsCommandButton>
                        <SettingsDataSecurity AllowDelete="False" AllowInsert="False" />
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Standard" FieldName="stan_standard" ReadOnly="True" ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" VisibleIndex="5" Width="150px">
                                <EditFormSettings Visible="True" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_itemid" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_colmeasure1" ShowInCustomizationForm="True" VisibleIndex="8">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_projectid" ShowInCustomizationForm="True" Visible="False" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_colmeasure2" ShowInCustomizationForm="True" VisibleIndex="10">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_colmeasure3" ShowInCustomizationForm="True" VisibleIndex="12">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_colmeasure4" ShowInCustomizationForm="True" VisibleIndex="14">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="stan_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_id" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="score_colmeasure5" ShowInCustomizationForm="True" VisibleIndex="16">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="stan_card" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="score_col1" ShowInCustomizationForm="True" VisibleIndex="7">
                                <PropertiesComboBox ClientInstanceName="ddlStndValues" EnableClientSideAPI="true" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                             
                                    <ItemStyle Wrap="True" />
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="score_col2" ShowInCustomizationForm="True" VisibleIndex="9">
                                <PropertiesComboBox ClientInstanceName="ddlStndValues1" EnableClientSideAPI="true" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                                   
                                    <ItemStyle Wrap="True" />
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="score_col3" ShowInCustomizationForm="True" VisibleIndex="11">
                                <PropertiesComboBox ClientInstanceName="ddlStndValues2" EnableClientSideAPI="true" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                                   
                                    <ItemStyle Wrap="True" />
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="score_col4" ShowInCustomizationForm="True" VisibleIndex="13">
                                <PropertiesComboBox ClientInstanceName="ddlStndValues3" EnableClientSideAPI="true" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                                   
                                    <ItemStyle Wrap="True" />
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="score_col5" ShowInCustomizationForm="True" VisibleIndex="15">
                                <PropertiesComboBox ClientInstanceName="ddlStndValues4" EnableClientSideAPI="true" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                                  
                                    <ItemStyle Wrap="True" />
                                </PropertiesComboBox>
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewCommandColumn ButtonRenderMode="Link" ButtonType="Link" Caption="Artifacts" VisibleIndex="17" Width="100px" Visible="False">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="scorecardAttach" Text="Artifacts">
                                    <Image IconID="mail_attachment_16x16">
                                    </Image>
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
                        </Columns>
                    </dx:ASPxGridView>
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
        <dx:TabPage Name="description" Text="Description" Visible="False">
            <ContentCollection>
                <dx:ContentControl runat="server">
                        <dx:ASPxHtmlEditor ID="txScoreDescription" runat="server" Width="100%" ClientInstanceName="txScoreDescription" ClientEnabled="true">
                            <Settings AllowHtmlView="False" AllowPreview="False" AllowContextMenu="False">
                            </Settings>
                            <SettingsResize AllowResize="True" />
                        </dx:ASPxHtmlEditor>
                       <div style="float: right; padding-top: 10px; padding-bottom: 10px;">

                        <dx:ASPxButton ID="btSaveScoreDescription" OnClick="btSave_Click" ClientInstanceName="btSaveScoreDescription" runat="server" Text="Save" RenderMode="Link" EnableClientSideAPI="true" ClientEnabled="true">
                            <%--<ClientSideEvents Click="SaveScoreDescription" />--%>
                            <Image IconID="actions_apply_16x16">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btCancelScoreDescription" runat="server" Text="Cancel" RenderMode="Link" ClientInstanceName="btCancelScoreDescription" EnableClientSideAPI="true" ClientEnabled="true">
                             <%--<ClientSideEvents Click="CancelDescription" />--%>

                            <Image IconID="actions_cancel_16x16">
                            </Image>
                        </dx:ASPxButton>
                    </div>
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
    </TabPages>
</dx:ASPxPageControl>
<br />
<%--        </dx:PanelContent>
</PanelCollection>
</dx:ASPxCallbackPanel>--%>


