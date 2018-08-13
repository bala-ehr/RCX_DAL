<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="attacher.ascx.cs" Inherits="RC_X.controls.attacher" %>
<%@ Register Assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRichEdit" TagPrefix="dx" %>

<script type="text/javascript">


</script>
<dx:aspxcallbackpanel id="callAttach" clientenabled="true" clientinstancename="callAttach" runat="server" cssclass="left:0;right:0;top:0;bottom:0;position:absolute;" oncallback="callAttach_Callback" hidecontentoncallback="false">
   <ClientSideEvents EndCallback="AttachingDone" />  
    <PanelCollection>
<dx:PanelContent runat="server">

<dx:ASPxHiddenField ID="paramUpload" runat="server" ClientInstanceName="paramUpload" >
</dx:ASPxHiddenField>
<%--<asp:SqlDataSource ID="sqlArtifactTypes" runat="server" ConnectionString="<%$ ConnectionStrings:DevDB %>" SelectCommand="SELECT type_home, type_title, type_value FROM rc_types WHERE (type_home = N'artifact')"></asp:SqlDataSource>--%>
<dx:ASPxPageControl ID="tabRepository" runat="server" ActiveTabIndex="0" ShowTabs="False" Width="100%" ClientInstanceName="tabRepository" EnableClientSideAPI="True">
    <TabPages>
        <dx:TabPage Name="attached" Text="attached">
            <ActiveTabStyle Border-BorderStyle="None" Border-BorderWidth="0px">
            </ActiveTabStyle>
            <TabStyle>
                <Paddings Padding="0px" />
            </TabStyle>
            <ContentCollection>
                <dx:ContentControl runat="server">
                    <dx:ASPxMenu ID="menuAttached" runat="server" ClientInstanceName="menuAttached" EnableClientSideAPI="True" Width="100%">
                         <ClientSideEvents ItemClick="xRepositoryButton" />
                        <Items>
                          <%--  <dx:MenuItem Name="upload" Text="Upload New Artifact">
                                <Image IconID="navigation_up_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>--%>
                            <dx:MenuItem Name="attach" Text="Attach from Repository">
                                <Image IconID="mail_attachment_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>
                        </Items>
                    </dx:ASPxMenu>
                    <dx:ASPxGridView ID="gridAttached" runat="server" AutoGenerateColumns="False" KeyFieldName="AttachmentID" Width="100%" ClientInstanceName="gridAttached" OnRowDeleting="gridAttached_RowDeleting">
                        <SettingsContextMenu EnableColumnMenu="True" Enabled="True" EnableGroupFooterMenu="False" EnableGroupPanelMenu="False" EnableRowMenu="False">
                        </SettingsContextMenu>
                        
                        <SettingsAdaptivity>
                            <AdaptiveDetailLayoutProperties>
                                <Items>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_id">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_projectID">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_title">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_type">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_home">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_filename">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_storagename">
                                    </dx:GridViewColumnLayoutItem>
                                    <dx:GridViewColumnLayoutItem ColumnName="lib_textsearch">
                                    </dx:GridViewColumnLayoutItem>
                                </Items>
                            </AdaptiveDetailLayoutProperties>
                        </SettingsAdaptivity>
                        <Settings AutoFilterCondition="Contains" EnableFilterControlPopupMenuScrolling="True" ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowTitlePanel="True" />
                        <SettingsBehavior ConfirmDelete="True" />
                        <SettingsResizing ColumnResizeMode="Control" />
                
                        <SettingsCommandButton>
                            <DeleteButton Text="unattach">
                                <Image IconID="actions_removeitem_16x16">
                                </Image>
                            </DeleteButton>
                        </SettingsCommandButton>
                        <SettingsSearchPanel ShowApplyButton="True" ShowClearButton="True" />
                        <SettingsText ConfirmDelete="Are you sure you want to unattach this artifact?" />
                        <Columns>
                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowDeleteButton="True" ShowInCustomizationForm="True" VisibleIndex="0" Width="50px">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="ArtifactID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Name" FieldName="ArtifactTitle" ShowInCustomizationForm="True" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Type" FieldName="ArtifactType" ShowInCustomizationForm="True" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Level" FieldName="ArtifactHome" ShowInCustomizationForm="True" Visible="False" VisibleIndex="4">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PageReference" ShowInCustomizationForm="True" VisibleIndex="7" Caption="Reference">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:ASPxGridView>
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
        <dx:TabPage Name="upload" Text="upload">
            <ActiveTabStyle Border-BorderStyle="None" Border-BorderWidth="0px">
            </ActiveTabStyle>
            <ContentCollection>
                <dx:ContentControl runat="server">
                     <dx:ASPxMenu ID="menuUpload" runat="server" ClientInstanceName="menuUpload" EnableClientSideAPI="True" Width="100%">
                         <ClientSideEvents ItemClick="xRepositoryButton" />
                        <Items>
                            <dx:MenuItem Name="cancel" Text="Cancel Upload">
                                <Image IconID="actions_cancel_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>
                            <dx:MenuItem Name="sendfile" Text="Upload and Attach">
                                <Image IconID="save_save_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>
                        </Items>
                    </dx:ASPxMenu>
                     <br />
                      <dx:ASPxFormLayout ID="formUpload" runat="server" AlignItemCaptionsInAllGroups="True" Width="100%">
                         <Items>
                             <dx:LayoutItem Caption="Choose File" Name="fileArea">
                                 <LayoutItemNestedControlCollection>
                                     <dx:LayoutItemNestedControlContainer runat="server">
                                         <dx:ASPxUploadControl ID="fileUP" runat="server" AddUploadButtonsSpacing="5px" ClientInstanceName="fileUP" OnFileUploadComplete="fileUP_FileUploadComplete" ShowProgressPanel="True" UploadMode="Auto" UploadStorage="Azure" Width="100%">
                                             <ClientSideEvents FileUploadComplete="xUploadDone" />
                                             <AdvancedModeSettings EnableDragAndDrop="True">
                                             </AdvancedModeSettings>
                                             <AzureSettings AccountName="UploadAzureAccount" BlobEndpoint="https://rcxstorage.blob.core.usgovcloudapi.net/"  />
                                         </dx:ASPxUploadControl>
                                     </dx:LayoutItemNestedControlContainer>
                                 </LayoutItemNestedControlCollection>
                             </dx:LayoutItem>
                             <dx:LayoutItem Caption="Artifact Title" Name="title">
                                 <LayoutItemNestedControlCollection>
                                     <dx:LayoutItemNestedControlContainer runat="server">
                                         <dx:ASPxTextBox ID="txTitle" runat="server" Width="100%" ClientInstanceName="txTitle" EnableClientSideAPI="True">
                                         </dx:ASPxTextBox>
                                     </dx:LayoutItemNestedControlContainer>
                                 </LayoutItemNestedControlCollection>
                             </dx:LayoutItem>
                             <dx:LayoutItem Caption="Type">
                                 <LayoutItemNestedControlCollection>
                                     <dx:LayoutItemNestedControlContainer runat="server">
                                         <dx:ASPxComboBox ID="dropType" runat="server" Width="100%" ValueType="System.String" TextField="Name" ValueField="Name" ClientInstanceName="dropType" EnableClientSideAPI="True">
                                         </dx:ASPxComboBox>
                                     </dx:LayoutItemNestedControlContainer>
                                 </LayoutItemNestedControlCollection>
                             </dx:LayoutItem>
                             <dx:LayoutItem Caption="Description">
                                 <LayoutItemNestedControlCollection>
                                     <dx:LayoutItemNestedControlContainer runat="server">
                                         <dx:ASPxMemo ID="txDesc" runat="server" Height="150px" Width="100%" ClientInstanceName="txDesc" EnableClientSideAPI="True"></dx:ASPxMemo>
                                     </dx:LayoutItemNestedControlContainer>
                                 </LayoutItemNestedControlCollection>
                             </dx:LayoutItem>
                         </Items>
                         <SettingsItemCaptions Location="Left" />
                     </dx:ASPxFormLayout>
                 
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
        <dx:TabPage Name="repository" Text="repository">
            <ActiveTabStyle Border-BorderStyle="None" Border-BorderWidth="0px">
            </ActiveTabStyle>
            <ContentCollection>
                <dx:ContentControl runat="server">
                      <dx:ASPxMenu ID="menuRepository" runat="server" ClientInstanceName="menuRepository" EnableClientSideAPI="True" Width="100%">
                         <ClientSideEvents ItemClick="xRepositoryButton" />
                        <Items>
                            <dx:MenuItem Name="cancel" Text="Cancel">
                                <Image IconID="actions_cancel_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>
                            <dx:MenuItem Name="attachselected" Text="Attach Selected Items">
                                <Image IconID="mail_attachment_16x16">
                                </Image>
                                <ItemStyle Border-BorderWidth="1px" HorizontalAlign="Center" />
                            </dx:MenuItem>
                        </Items>
                    </dx:ASPxMenu>
                         <dx:ASPxGridView ID="gridRepository" runat="server" AutoGenerateColumns="False" KeyFieldName="ArtifactID" Width="100%" ClientInstanceName="gridRepository">
              
                        <Settings AutoFilterCondition="Contains" EnableFilterControlPopupMenuScrolling="True" ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFilterRowMenuLikeItem="True" ShowTitlePanel="True" />
                        <SettingsBehavior ConfirmDelete="True" />
                        <SettingsResizing ColumnResizeMode="NextColumn" />
                        <SettingsCookies Enabled="True" StoreControlWidth="True" />
                             <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        <SettingsSearchPanel ShowApplyButton="True" ShowClearButton="True" Visible="True" />
                        <Columns>
                            <dx:GridViewCommandColumn ButtonRenderMode="Image" ButtonType="Image" Caption=" " ShowInCustomizationForm="True" VisibleIndex="0" Width="50px" SelectAllCheckboxMode="Page" ShowSelectCheckbox="True">
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="ArtifactID" Name="ArtifactID" ReadOnly="True" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ProjectID" ShowInCustomizationForm="True" Visible="False" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Name" FieldName="Title" ShowInCustomizationForm="True" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Type" FieldName="Type" ShowInCustomizationForm="True" VisibleIndex="4">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Level" FieldName="Home" ShowInCustomizationForm="True" Visible="False" VisibleIndex="6">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="FileName" ShowInCustomizationForm="True" Visible="False" VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="StorageName" ShowInCustomizationForm="True" Visible="False" VisibleIndex="8">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="FullText" ShowInCustomizationForm="True" Visible="False" VisibleIndex="9">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Page Reference" ShowInCustomizationForm="True" VisibleIndex="5">
                                <DataItemTemplate>
                                    <dx:ASPxTextBox ID="txPage" runat="server" Width="100%">
                                        <ClientSideEvents LostFocus="GetBoxName" />
                                        <Border BorderStyle="None" />
                                    </dx:ASPxTextBox>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                        </Columns>
                    </dx:ASPxGridView>

                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
    </TabPages>
    <Paddings Padding="0px" />
    <ActiveTabStyle Border-BorderStyle="None" Border-BorderWidth="0px">
    </ActiveTabStyle>
    <TabStyle Border-BorderStyle="None" Border-BorderWidth="0px">
    </TabStyle>
    <Border BorderStyle="None" BorderWidth="0px" BorderColor="White" />
    <BorderLeft BorderStyle="None" />
    <BorderTop BorderStyle="None" />
    <BorderRight BorderStyle="None" />
    <BorderBottom BorderStyle="None" />
    <DisabledStyle Border-BorderStyle="None">
    </DisabledStyle>
</dx:ASPxPageControl>


    </dx:PanelContent>
</PanelCollection>
    </dx:aspxcallbackpanel>


<%--<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>



