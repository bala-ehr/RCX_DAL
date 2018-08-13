<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="widget_scorecard.ascx.cs" Inherits="RC_X.controls.widget_scorecard" %>
<dx:ASPxCallbackPanel ID="callScorecard" runat="server" Width="100%" ClientEnabled="true" ClientInstanceName="callScorecard" EnableClientSideAPI="true" OnCallback="callScorecard_Callback">
   <ClientSideEvents EndCallback="ScoreCallbackEnd" />
    <PanelCollection>
<dx:PanelContent runat="server">
   <script type="text/javascript">
       function ScoreCallbackEnd(s, e){
           ddlScorecards.SetText(paramScorecard.Get("CardName"));
       }
       function ScoreCol1(s, e) {
           var indices = gridScorecardWidget.batchEditApi.GetRowVisibleIndices();
           var Score = s.GetSelectedItem().value;
           var ColumnName = "ScoreCol1";
           //var ColumnNumber = 11;


           for (var i = 0; i < indices.length; i++) {
               gridScorecardWidget.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
           }
       }

       function ScoreCol2(s, e) {
           var indices = gridScorecardWidget.batchEditApi.GetRowVisibleIndices();
           var Score = s.GetSelectedItem().value;
           var ColumnName = "ScoreCol2";
           //var ColumnNumber = 12;


           for (var i = 0; i < indices.length; i++) {
               gridScorecardWidget.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
           }
       }
       function ScoreCol3(s, e) {
           var indices = gridScorecardWidget.batchEditApi.GetRowVisibleIndices();
           var Score = s.GetSelectedItem().value;
           var ColumnName = "ScoreCol3";
           //var ColumnNumber = 13;


           for (var i = 0; i < indices.length; i++) {
               gridScorecardWidget.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
           }
       }
       function ScoreCol4(s, e) {
           var indices = gridScorecardWidget.batchEditApi.GetRowVisibleIndices();
           var Score = s.GetSelectedItem().value;
           var ColumnName = "ScoreCol4";
           //var ColumnNumber = 14;


           for (var i = 0; i < indices.length; i++) {
               gridScorecardWidget.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
           }
       }
       function ScoreCol5(s, e) {
           var indices = gridScorecardWidget.batchEditApi.GetRowVisibleIndices();
           var Score = s.GetSelectedItem().value;
           var ColumnName = "ScoreCol5";
           //var ColumnNumber = 15;


           for (var i = 0; i < indices.length; i++) {
               gridScorecardWidget.batchEditApi.SetCellValue(indices[i], ColumnName, Score, Score, false);
           }
       }
       function QuickSave(s, e) {
           gridScorecardWidget.UpdateEdit();

       }
       function SaveScoreDescription(s, e) { btSaveScoreDescription.PerformCallback(); }
       function CancelDescription(s, e) {
           txScoreDescription.PerformDataCallback();
       }

       function xButtonAttachScorecard(s, e) {
           switch (e.buttonID) {

               case "actionAttach":

                   gridScorecardWidget.GetRowValues(gridScorecard.GetFocusedRowIndex(), "stan_id", OnGetRowValues);
                   break;
           }
       }
       function OnGetRowValues(standardKey) {

           OpenWidget("RefreshAttach", standardKey);
       }



</script>
    <dx:ASPxHiddenField ID="paramScorecard" runat="server" ClientInstanceName="paramScorecard">
    </dx:ASPxHiddenField>
        <dx:ASPxComboBox ID="comboCards" runat="server" ClientInstanceName="ddlScorecards" EnableClientSideAPI="True" TextField="CardName" ValueField="CardId" Width="100%" ValueType="System.String" DropDownRows="15" OnDataBound="comboCards_DataBound">
            <ClientSideEvents SelectedIndexChanged="ChangeScorecard" /> 
    </dx:ASPxComboBox>
    <br />
    <dx:ASPxGridView ID="gridScorecardWidget" runat="server" AutoGenerateColumns="False" ClientInstanceName="gridScorecardWidget" KeyFieldName="ScoreId" OnBatchUpdate="gridScorecard_BatchUpdate" OnCellEditorInitialize="Grid_CellEditorInitialize" OnDataBound="gridScorecard_DataBound" OnRowUpdated="gridScorecard_RowUpdated" Visible="False" Width="100%">
        <ClientSideEvents BatchEditChangesSaving="ResetHiddenField" BatchEditStartEditing="loadStandardValues" CustomButtonClick="xGridButton" />
        <SettingsPager Mode="ShowAllRecords" PageSize="100">
        </SettingsPager>
        <SettingsEditing Mode="Batch">
            <BatchEditSettings EditMode="Row" />
        </SettingsEditing>
        <Settings ShowFilterRow="True" ShowHeaderFilterBlankItems="False" />
        <SettingsBehavior AllowFocusedRow="True" />
        <SettingsResizing ColumnResizeMode="Control" />
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
        <SettingsFilterControl ViewMode="VisualAndText">
        </SettingsFilterControl>
        <Columns>
            <dx:GridViewDataTextColumn Caption="Standard" FieldName="StandardName" ReadOnly="True" ShowInCustomizationForm="True" SortIndex="0" SortOrder="Ascending" VisibleIndex="5" Width="150px">
                <EditFormSettings Visible="True" />
                <FilterTemplate>
                    Quick Score
                </FilterTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ItemId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Measure1" ShowInCustomizationForm="True" VisibleIndex="7" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Measure2" ShowInCustomizationForm="True" VisibleIndex="9" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Measure3" ShowInCustomizationForm="True" VisibleIndex="11" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Measure4" ShowInCustomizationForm="True" VisibleIndex="13" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="StandardId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ScoreId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Measure5" ShowInCustomizationForm="True" VisibleIndex="15" Visible="False">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataComboBoxColumn FieldName="ScoreCol1" ShowInCustomizationForm="True" VisibleIndex="6">
                <PropertiesComboBox ClientInstanceName="ddlStndValues" EnableClientSideAPI="True" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                    <ItemStyle Wrap="True" />
                </PropertiesComboBox>
                <FilterTemplate>
                      <dx:ASPxComboBox ID="ComboHeader1" runat="server" ClientInstanceName="ComboHeader1" EnableClientSideAPI="True" ValueType="System.Int32"  Width="50px">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol1" />
                            <Items>
                                 <dx:ListEditItem  Value="0" Text="0"/>
                                <dx:ListEditItem  Value="1" Text="1"/>
                                <dx:ListEditItem  Value="2" Text="2"/>
                                <dx:ListEditItem  Value="3" Text="3"/>
                                <dx:ListEditItem  Value="4" Text="4"/>
                                <dx:ListEditItem  Value="5" Text="5"/>
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                </FilterTemplate>
            
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="ScoreCol2" ShowInCustomizationForm="True" VisibleIndex="8">
                <PropertiesComboBox ClientInstanceName="ddlStndValues1" EnableClientSideAPI="True" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                    <ItemStyle Wrap="True" />
                </PropertiesComboBox>
                 <FilterTemplate>
                      <dx:ASPxComboBox ID="ComboHeader2" runat="server" ClientInstanceName="ComboHeader2" EnableClientSideAPI="True" ValueType="System.Int32"  Width="50px">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol2" />
                            <Items>
                                 <dx:ListEditItem  Value="0" Text="0"/>
                                <dx:ListEditItem  Value="1" Text="1"/>
                                <dx:ListEditItem  Value="2" Text="2"/>
                                <dx:ListEditItem  Value="3" Text="3"/>
                                <dx:ListEditItem  Value="4" Text="4"/>
                                <dx:ListEditItem  Value="5" Text="5"/>
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                </FilterTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="ScoreCol3" ShowInCustomizationForm="True" VisibleIndex="10">
                <PropertiesComboBox ClientInstanceName="ddlStndValues2" EnableClientSideAPI="True" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                    <ItemStyle Wrap="True" />
                </PropertiesComboBox>
                    <FilterTemplate>
                      <dx:ASPxComboBox ID="ComboHeader3" runat="server" ClientInstanceName="ComboHeader3" EnableClientSideAPI="True"  ValueType="System.Int32" Width="50px">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol3" />
                            <Items>
                                 <dx:ListEditItem  Value="0" Text="0"/>
                                <dx:ListEditItem  Value="1" Text="1"/>
                                <dx:ListEditItem  Value="2" Text="2"/>
                                <dx:ListEditItem  Value="3" Text="3"/>
                                <dx:ListEditItem  Value="4" Text="4"/>
                                <dx:ListEditItem  Value="5" Text="5"/>
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                </FilterTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="ScoreCol4" ShowInCustomizationForm="True" VisibleIndex="12">
                <PropertiesComboBox ClientInstanceName="ddlStndValues3" EnableClientSideAPI="True" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                    <ItemStyle Wrap="True" />
                </PropertiesComboBox>
                    <FilterTemplate>
                      <dx:ASPxComboBox ID="ComboHeader4" runat="server" ClientInstanceName="ComboHeader4" EnableClientSideAPI="True" ValueType="System.Int32"   Width="50px">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol4" />
                            <Items>
                                 <dx:ListEditItem  Value="0" Text="0"/>
                                <dx:ListEditItem  Value="1" Text="1"/>
                                <dx:ListEditItem  Value="2" Text="2"/>
                                <dx:ListEditItem  Value="3" Text="3"/>
                                <dx:ListEditItem  Value="4" Text="4"/>
                                <dx:ListEditItem  Value="5" Text="5"/>
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                </FilterTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewDataComboBoxColumn FieldName="ScoreCol5" ShowInCustomizationForm="True" VisibleIndex="14">
                <PropertiesComboBox ClientInstanceName="ddlStndValues4" EnableClientSideAPI="True" TextField="score_display_text" ValueField="value_score" ValueType="System.Int32">
                    <ItemStyle Wrap="True" />
                </PropertiesComboBox>
                      <FilterTemplate>
                      <dx:ASPxComboBox ID="ComboHeader5" runat="server" ClientInstanceName="ComboHeader5" EnableClientSideAPI="True" ValueType="System.Int32"  Width="50px">
                        <ClientSideEvents SelectedIndexChanged="ScoreCol5" />
                            <Items>
                                 <dx:ListEditItem  Value="0" Text="0"/>
                                <dx:ListEditItem  Value="1" Text="1"/>
                                <dx:ListEditItem  Value="2" Text="2"/>
                                <dx:ListEditItem  Value="3" Text="3"/>
                                <dx:ListEditItem  Value="4" Text="4"/>
                                <dx:ListEditItem  Value="5" Text="5"/>
                            </Items>
                        <ItemStyle Wrap="True" />
                    </dx:ASPxComboBox>
                </FilterTemplate>
            </dx:GridViewDataComboBoxColumn>
            <dx:GridViewCommandColumn ButtonRenderMode="Link" ButtonType="Link" Caption="Artifacts" ShowInCustomizationForm="True" Visible="True" VisibleIndex="16" Width="100px">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="scorecardStandardAttach" Text="Artifacts">
                        <Image IconID="mail_attachment_16x16">
                        </Image>
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="CardId" ShowInCustomizationForm="True" Visible="False" VisibleIndex="17">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
        </dx:PanelContent>
</PanelCollection>
</dx:ASPxCallbackPanel>


