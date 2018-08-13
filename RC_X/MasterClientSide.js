///window.onbeforeunload = confirmNavigateAway;

var key = "";
var popAdd;
var popDesc;
var popAttach;
var popAssign;

window.onunload = CheckSession;
window.onload = CheckSession;
window.onerror = HandleErrors;

function ChangeScorecard(s, e) {
    //paramScorecard.Clear();
    paramScorecard.Remove("ScorecardKey");
    paramScorecard.Remove("ScorecardChanged");
    paramScorecard.Set("ScorecardKey", s.GetValue());
    paramScorecard.Set("ScorecardChanged", true);
    e.processOnServer = false;
    callScorecard.PerformCallback("");
    //gridScorecardWidgetWidget.DataBind();
}

function HandleErrors(s,e) {
    return;
}
function CheckSession() {
    if (rootParameters.Contains("TimedOut")) {
        var PageName = location.pathname;
        var IsLogin = PageName.indexOf("Login")
        if (IsLogin < 0) {

            window.location.href = "/Account/Login.aspx";
            rootParameters.Remove("TimedOut");
        }
    }

}
function GoBackAfterError(s, e) {
    window.history.go(-2);
   // return false;
}

function xGridFocus(s, e) { /// set grid client side event FocusedRowChanged to this 
  //  ASPxClientUtils.SetCookie(s.name + '_focudedIndex', s.GetFocusedRowIndex());

    var rowKey = s.GetRowKey(s.GetFocusedRowIndex());    

    /////TODO add prompt for unsave work

    RefreshWidget(rowKey);

}
function OnInit(s, e) { //Set grid client side event Init to this ------- TODO reqire on Mohan's pro_RTM.aspx
   
   // if (ASPxClientUtils.GetCookie(s.name + '_focudedIndex') != null)
      //  s.SetFocusedRowIndex(ASPxClientUtils.GetCookie(s.name + '_focudedIndex'));
    //var rowKey = s.GetRowKey(s.GetFocusedRowIndex());
    //rootParameters.Set("xkey", rowKey);    
}

function SaveDropDownIndex(s,e) {
    rootParameters.Set("SelectedMilestone", s.GetSelectedIndex());
    RefreshWidget(rootParameters.Get("xkey"));
}
function ResponseChanged(s, e) {
    var x = Boolean(false);
    rootParameters.Set("responseIsSaved", x);
}
function AssessmentChanged(s, e) {
    rootParameters.Set("AssessmentValue", s.GetValue());
    var x = Boolean(false);
    rootParameters.Set("responseIsSaved", x);
}

// When popup is closed, removes the parameter which says it is open.
// Root.Master Init checks for this and removes the session variable used to decide whether widget needs to be refreshed
function CloseWidget(s, e) {   
    //TODO add prompt for unsaved work
    //alert(s.panelUID);
            rootParameters.Remove(s.panelUID + "Open");    
}

function OpenWidget(widget, xkey) {

    rootParameters.Set("xkey", xkey);
   
    if (widget == "RefreshScoreCard") {
      //rootParameters.Set("xkey", xkey);
      //  //rootParameters.Set("currentWidget", "scorecard");
      //rootParameters.Set("widgetScoreCardOpen", true);

      paramScorecard.Set("ScorecardItemKey", xkey);
      paramScorecard.Set("ItemChanged", true);
        popDesc = RootDockManager.GetPanelByUID("widgetScoreCard");
        popDesc.SetHeaderText("Scorecard");
        popDesc.Show();
    }
    

    rootCall.PerformCallback(widget);
}

function RefreshWidget(xkey) { //TOD add check for unsave work

   

    var xCallBackString = "";
    rootParameters.Set("xkey", xkey);

    
    widgetScorecard = RootDockManager.GetPanelByUID("widgetScoreCard");
    
   
    if (widgetScorecard.IsVisible() == true) {
        //Clear Scorecard hidden field to avoid call back error
        //paramScorecard.Clear();
        //paramScorecard.Remove("ScorecardItemKey");
        //paramScorecard.Remove("ItemChanged");
        paramScorecard.Set("ScorecardItemKey", xkey);
        paramScorecard.Set("ItemChanged", true);
        xCallBackString = xCallBackString + "widgetScoreCard";
    }
    if (xCallBackString != "") {
        rootCall.PerformCallback(xCallBackString);
    }
}


function ScorecardSelected(s, e) {   ////TODO deprecated for pro_assessment as main GUI has no select scorecard dropdown
    paramScore.Clear();
    var item = s.GetSelectedItem();
    
    //var ItemKey = gridScorecardWidget.GetRowKey(gridScorecardWidget.GetFocusedRowIndex());
    rootParameters.Set("SelectScorecard", item.value);
    OpenWidget("RefreshScoreCard", rootParameters.Get("xkey"));
}
function ScorecardEditing(s, e) { ///TODO Add server-side scorecard.ascx property IsSave set to rootparameters
    if (!rootParameters.Contains("ScorecardNeedsSave")) { rootParameters.Add("ScorecardNeedsSave", true); }
}

//function ScorecardSaved(s, e) {
//    rootParameters.Remove("ScorecardNeedsSave");
//}

function xGridButton(s, e) {
    //TODO tie in for grid client side in pro_RTM.aspx
    var rowKey = s.GetRowKey(s.GetFocusedRowIndex());
    if (rowKey == null) { return; }

    //Scorecards need their hidden fields with standard values cleared before opening
    //if (e.buttonID.indexOf("Scorecard") >= 0) { paramScore.Clear(); }
    //if (e.buttonID.indexOf("scorecard") >= 0) { paramScore.Clear(); }

    //Now find out which widget is being called - the command buttons have different
    // names in each page to avoid client side name conflicts
    switch (e.buttonID) {
        
        case "scorecard":
            OpenWidget("RefreshScoreCard", rowKey);
            break;
        
        // Business Category
       
        case "categoryScorecard":
            OpenWidget("RefreshScoreCard", rowKey);
            break;
        
        // Business Processes
       
        case "processScorecard":
            OpenWidget("RefreshScoreCard", rowKey);
            break;
        
          // RoadmMap
        case "roadmapAttach":
            widgetAttach.SetHeaderText("Roadmap Attachments");
            OpenWidget("RefreshAttach", rowKey);
            break;
        case "gapAttach":
            widgetAttach.SetHeaderText("Gap Attachments");
            OpenWidget("RefreshAttach", rowKey);
            break;
        case "goalAttach":
            widgetAttach.SetHeaderText("Goal Attachments");
            OpenWidget("RefreshAttach", rowKey);
            break;
         
       
    }
}
///////TODO rewire
//function unloadPage() {

//    widgetAttach.SetVisible(false);
//    widgetDesc.SetVisible(false);
//    widgetWorkflow.SetVisible(false);

//    widgetAttach.SetClientVisible(false);
//    widgetDesc.SetClientVisible(false);
//    widgetWorkflow.SetClientVisible(false);
//}
function confirmNavigateAway() { ////TODO reqire to page.unload event

    if (rootParameters.Contains("DescNeedsSave") || rootParameters.Contains("WorkflowNeedsSave") || rootParameters.Contains("AttachNeedsSave")) {
        return "You have attempted to leave this page. You have unsaved changes in this page. Are you sure you want to leave?";
    }
}
function confirmExit(s, e) { ////TODO reqire to page.unload event

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
        
        case "widgetScoreCard":
            break;
       
    }

}
function xUploadDone(s, e) { /////TODO Assign IsSaved=false
   
   
    tabRepository.SetActiveTab(tabRepository.GetTab(0));
    s.ClearText()

    paramUpload.Add("xType", dropType.GetValue());
    paramUpload.Add("xDesc", txDesc.GetText());
    paramUpload.Add("xTitle", txTitle.GetText());
    var values = e.callbackData.split('|');
    paramUpload.Add("xFileName", values[0]);
    paramUpload.Add("xStorageName", values[1]);
    paramUpload.Add("xFullText", values[2]);
    //  alert(paramUpload.Get("xFileName"))

    txDesc.SetText("");
    txDesc.SetValue("");

    callAttach.PerformCallback("newartifact");
}


function xRepositoryButton(s, e) {

    switch (e.item.name) {
        case "upload":
            tabRepository.SetActiveTab(tabRepository.GetTab(1));
           // rootParameters.Set("attacherIsSelecting", false);
            break;
        case "attach":
          //  rootParameters.Set("attacherIsSelecting", false);
            tabRepository.SetActiveTab(tabRepository.GetTab(2));
            //callAttach.PerformCallback("bindrepository");
            break;
        case "sendfile":
            fileUP.Upload();
            break;
        case "cancel":
          //  rootParameters.Set("attacherIsSelecting", false);
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
            //rootParameters.Set("attacherIsSelecting", true);
           callAttach.PerformCallback("attach");
            break;
    }

}
// Gets the value of txPage control inside Gridrepository of attacher.ascx, for the purpose of saving the Page Reference
function GetBoxName(s, e) {
    var xName = s.name;
    var txRow = xName.substr(xName.length - 1);
    var xPage = s.GetText();
    paramUpload.Set("txPage" + txRow, xPage);
}

function AttachingDone(s, e) {

    //if (widgetScorecard.IsVisible() && rootParameters.Contains("xkey")) {
    //    OpenWidget("RefreshScorecard", rootParameters.Get("xkey"));
    //}
    //rootParameters.Set("attacherIsSelecting", false);
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

function loadStandardValues(s, e) {
    var stand_ID = s.GetRowKey(e.visibleIndex); // Get row id, which is standard ID
    var DropValues1;
    var DropValues2;
    var DropValues3;
    var DropValues4;
    var DropValues5;

    // Loop through all the columns to find the score columns and get their combobox editors for processing
    for (i = 0; i < gridScorecardWidget.GetColumnCount(); i++) {
                
        switch (gridScorecardWidget.GetColumn(i).fieldName) {
            case 'ScoreCol1':
                if (gridScorecardWidget.GetColumn(i).visible) { DropValues1 = ddlStndValues; }
                break;
            case 'ScoreCol2':
                if (gridScorecardWidget.GetColumn(i).visible) { DropValues2 = ddlStndValues1; }
                break;
            case 'ScoreCol3':
                if (gridScorecardWidget.GetColumn(i).visible) { DropValues3 = ddlStndValues2; }
                break;
            case 'ScoreCol4':
                if (gridScorecardWidget.GetColumn(i).visible) { DropValues4= ddlStndValues3; }
                break;
            case 'ScoreCol5':
                if (gridScorecardWidget.GetColumn(i).visible) { DropValues5 = ddlStndValues4; }
                break;
        }
    }

    //THis event is fired when a different row is being edited (batcheditsettingsmode=row)
    //So clear all the dropdowns, or else values from one standard will leak into another
    if (typeof DropValues1 !== 'undefined') { DropValues1.ClearItems(); }
    if (typeof DropValues2 !== 'undefined') { DropValues2.ClearItems(); }
    if (typeof DropValues3 !== 'undefined') { DropValues3.ClearItems(); }
    if (typeof DropValues4 !== 'undefined') { DropValues4.ClearItems(); }
    if (typeof DropValues5 !== 'undefined') { DropValues5.ClearItems(); }

    //Prevent card from being rebound in server - this is removed in server BatchUpdate event
    rootParameters.Set("ScorecardNeedsSave");

    //Get hidden field indicating how many values to expect for this standard, so limit the loop below
    var maxValues = paramScorecard.Get(stand_ID + "_" + "Max");

    for (i = 0; i < maxValues; i++)
    {        
        var StanInfo = paramScorecard.Get(stand_ID + "_" + i).split("_"); //Text to appear in tooltip of value
        var ScoreDisplay = StanInfo[0]; //String of number to appear in editor
        var ScoreInt = Number(StanInfo[0]); //Int of number to serve as value
        var ScoreText = StanInfo[0] + " - " + StanInfo[1]; // Get Number + Text to serve as guidance in tooltip of each item

        // Add DropDown Items for each visible Score Column 
        if (typeof DropValues1 !== 'undefined') {
            if (DropValues1.GetItemCount() < maxValues)
            { DropValues1.AddItem(ScoreDisplay, ScoreInt); DropValues1.SetItemTooltip(i, ScoreText);}
        }
        if (typeof DropValues2 !== 'undefined') {
            if (DropValues2.GetItemCount() < maxValues)
            { DropValues2.AddItem(ScoreDisplay, ScoreInt); DropValues2.SetItemTooltip(i, ScoreText); }
        }
        if (typeof DropValues3 !== 'undefined') {
            if (DropValues3.GetItemCount() < maxValues)
            { DropValues3.AddItem(ScoreDisplay, ScoreInt); DropValues3.SetItemTooltip(i, ScoreText); }
        }
        if (typeof DropValues4 !== 'undefined') {
            if (DropValues4.GetItemCount() < maxValues)
            { DropValues4.AddItem(ScoreDisplay, ScoreInt); DropValues4.SetItemTooltip(i, ScoreText); }
        }
        if (typeof DropValues5 !== 'undefined') {
            if (DropValues5.GetItemCount() < maxValues)
            { DropValues5.AddItem(ScoreDisplay, ScoreInt); DropValues5.SetItemTooltip(i, ScoreText); }
        }        
    }
}

// gridScorecardWidget batch edit throws call back error sue to value format of Standard Score values
// Clear it, but then perform call back to set Standard field values again
function ResetHiddenField(s, e) {
 
    //paramScorecard.Clear();
    //paramScorecard.Set("ScorecardKey", ddlScorecards.GetValue());

    //paramScore.PerformCallback();
}

function CheckControlExists(ctrl) {
    if (typeof ctrl !== 'undefined')
        if (document.getElementById(cbCustomers.name) != null) {
            return true;
        } else { return false;}

};

//function UpdateDesc(s, e) {

//    callDesc.PerformCallback();
//}

        //add function to see if widgets need to be saved. OnCHanged set to put an unsaved boolean parameter in hidden field
        // check that parameter when closing a widget or on page.onunload. Also use it to set the save buttn to red.