window.onbeforeunload = confirmNavigateAway;
window.onunload = unloadPage;

function unloadPage() {

    widgetAttach.SetVisible(false);
    widgetDesc.SetVisible(false);
    widgetWorkflow.SetVisible(false);

    widgetAttach.SetClientVisible(false);
    widgetDesc.SetClientVisible(false);
    widgetWorkflow.SetClientVisible(false);

}
function confirmNavigateAway() {

    if (rootParameters.Contains("DescNeedsSave") || rootParameters.Contains("WorkflowNeedsSave") || rootParameters.Contains("AttachNeedsSave")) {
        return "You have attempted to leave this page. You have unsaved changes in this page. Are you sure you want to leave?";

    }
}
function confirmExit(s, e) {

    if (rootParameters.Contains("DescNeedsSave") || rootParameters.Contains("WorkflowNeedsSave") || rootParameters.Contains("AttachNeedsSave")) {
        var answer = confirm("You have unsaved changes in this page. Are you sure you want to leave?");
        if (answer) {
            // le widget close
        } else {
            e.cancel = true;
        }
    }

    //Also, check to see if that's the last panel to close, in which case the dockpanel should collapse'
    xHideDockZone();
}
function ResizePanelContent(s, e) {
    var xPanel = e.panel;
    switch (e.panel.name) {
        case "widgetDesc":
            callDesc.AdjustControl()
            break;
        case "widgetAttach":
            callAttach.AdjustControl();
            break;
        case "widgetWorkflow":
            break;
        case "widgetScorecard":
            break;
    }

}
function xUploadDone(s, e) {

    paramUpload.Clear();
    tabRepository.SetActiveTab(tabRepository.GetTab(0));
    s.ClearText()

    paramUpload.Add("xType", dropType.GetValue());
    paramUpload.Add("xDesc", txDesc.GetText());
    paramUpload.Add("xTitle", txTitle.GetText());
    var values = e.callbackData.split('|');
    paramUpload.Add("xFileName", values[0]);
    paramUpload.Add("xStorageName", values[1]);
    //  alert(paramUpload.Get("xFileName"))

    txDesc.SetText("");
    txDesc.SetValue("");

    callAttach.PerformCallback("newartifact");}
function xRepositoryButton(s, e) {

    switch (e.item.name) {
        case "upload":
            tabRepository.SetActiveTab(tabRepository.GetTab(1));
            break;
        case "attach":
            tabRepository.SetActiveTab(tabRepository.GetTab(2));
            break;
        case "sendfile":
            fileUP.Upload();
            break;
        case "cancel":

            tabRepository.SetActiveTab(tabRepository.GetTab(0));
            fileUP.Cancel();
            fileUP.ClearText();
            paramUpload.Clear();
            break;
        case "save":
            //run save callback to sp
            tabRepository.SetActiveTab(tabRepository.GetTab(0));
            break;
        case "attachselected":
            tabRepository.SetActiveTab(tabRepository.GetTab(0));
            callAttach.PerformCallback("attach");
            break;

    }
}
function AlreadySaved(s, e) {

    var xSenderID = s.uniqueID;
    if (xSenderID.match(/callDesc/) != null) {
        rootParameters.Remove("DescNeedsSave");
        debugger;
    }

}
function MinimizeFooter(s, e) {
    e.cancel = true;
    e.pane.SetSize("15%");
}
function MaximizeFooter(s, e) {
    e.cancel = true;
    e.pane.SetSize("50%");
}
function xShowDockZone(s, e) {
    // footerPane.SetVisible(true);
    //footerPane.SetHeight(400);
    debugger;
    var footerPane = xsplitter.GetPaneByName("footerPane");
    footerPane.Expand();


}
function xHideDockZone(s, e) {
    var footerPane = xsplitter.GetPaneByName("footerPane");
    var xPanelCount = dockZone.GetPanelCount();
    if (xPanelCount == 0) {
        //footerPane.SetVisible(false);
        //footerPane.SetHeight(75);
        footerPane.Collapse();
    }
    else {
        footerPane.Expand();
    }
    //  e.cancel = true;
}
function UpdateDesc(s, e) {

    callDesc.PerformCallback();
}

function OpenWidget(widget, xkey) {

    rootParameters.Set("xkey", xkey);
    if (widget == "RefreshDesc") {
        popDesc = RootDockManager.GetPanelByUID("widgetDesc");
        popDesc.SetHeaderText("Description");
        popDesc.Show();
    }
    if (widget == "RefreshAttach") {
        rootParameters.Set("xkey", xkey);
        popDesc = RootDockManager.GetPanelByUID("widgetAttach");
        popDesc.SetHeaderText("Attachments");
        popDesc.Show();
    }
    if (widget == "RefreshWorkflow") {
        rootParameters.Set("xkey", xkey);
        popDesc = RootDockManager.GetPanelByUID("widgetWorkflow");
        popDesc.SetHeaderText("Workflow");
        popDesc.Show();
    }
    if (widget == "RefreshScorecard") {
        rootParameters.Set("xkey", xkey);
        popDesc = RootDockManager.GetPanelByUID("widgetScorecard");
        popDesc.SetHeaderText("Scorecard");
        popDesc.Show();
    }

    rootCall.PerformCallback(widget);
}

function RefreshWidget(xkey) {

    var xCallBackString = "";
    rootParameters.Set("xkey", xkey);

    widgetDesc = RootDockManager.GetPanelByUID("widgetDesc");
    widgetAttach = RootDockManager.GetPanelByUID("widgetAttach");
    widgetWorkflow = RootDockManager.GetPanelByUID("widgetWorkflow");
    widgetScorecard = RootDockManager.GetPanelByUID("widgetScorecard");

    if (widgetDesc.IsVisible() == true) {
        xCallBackString = xCallBackString + "RefreshDesc";
    }
    if (widgetAttach.IsVisible() == true) {
        xCallBackString = xCallBackString + "RefreshAttach";
    }
    if (widgetWorkflow.IsVisible() == true) {
        xCallBackString = xCallBackString + "RefreshWorkflow";
    }
    if (widgetScorecard.IsVisible() == true) {
        xCallBackString = xCallBackString + "widgetScorecard";
    }
    if (xCallBackString != "") {
        rootCall.PerformCallback(xCallBackString);
    }
}

        //add function to see if widgets need to be saved. OnCHanged set to put an unsaved boolean parameter in hidden field
        // check that parameter when closing a widget or on page.onunload. Also use it to set the save buttn to red.