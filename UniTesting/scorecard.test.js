"@fixture Scorecard";
"@page https://localhost:44393/rc_project/pro_assessment.aspx";

"@test"["Scorecards, save, move change"] = {
    '1.Type in input "User Name:"': function() {
        act.type("#tbUserName_I", "fcruz@ehr-llc.com");
    },
    "2.Press key TAB": function() {
        act.press("tab");
    },
    '3.Type in password input "Password:"': function() {
        act.type("#tbPassword_I", "Qwqw");
    },
    "4.Press key BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE BACKSPACE": function() {
        act.press("backspace backspace backspace backspace backspace backspace backspace backspace backspace backspace backspace backspace");
    },
    '5.Type in password input "Password:"': function() {
        act.type("#tbPassword_I", "Qw12!@ crazy rcx");
    },
    "6.Click div": function() {
        act.click("#btnLogin_CD");
    },
    '7.Click span "Scorecard"': function() {
        var actionTarget = function() {
            return $("#gridProcesses_DXCBtn0").find(":containsExcludeChildren(Scorecard)");
        };
        act.click(actionTarget);
    },
    "8.Drag div": function() {
        var actionTarget = function() {
            return $("#widgetScoreCard_PWH-1").find(".dxpc-headerContent");
        };
        act.drag(actionTarget, 804, 126, {
            offsetX: 445,
            offsetY: 18
        });
    },
    '9.Click span "Business Area"': function() {
        var actionTarget = function() {
            return $("#tabRTM_T0T").find(":containsExcludeChildren(Business Area)");
        };
        act.click(actionTarget);
    },
    "10.Drag div": function() {
        var actionTarget = function() {
            return $("#widgetScoreCard_PWH-1").find(".dxpc-headerContent");
        };
        act.drag(actionTarget, -371, 106, {
            offsetX: 166,
            offsetY: 15
        });
    },
    '11.Click span "Scorecard"': function() {
        var actionTarget = function() {
            return $("#gridArea_DXCBtn0").find(":containsExcludeChildren(Scorecard)");
        };
        act.click(actionTarget);
    },
    '12.Click input "ctl00$ctl00$rootCal..."': function() {
        act.click("#comboCards_I");
    },
    '13.Click table cell "Card A"': function() {
        act.click("#comboCards_DDD_L_LBI0T0");
    },
    '14.Click table cell "0"': function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow1").find(":containsExcludeChildren(0)");
        };
        act.click(actionTarget);
    },
    "15.Click table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow1").find(":containsExcludeChildren(0)");
        };
        act.click(actionTarget);
    },
    '16.Dblclick input "ctl00$ctl00$rootCal..."': function() {
        act.dblclick("#gridScorecardWidget_DXEditor9_I", {
            caretPos: 0
        });
    },
    '17.Click table cell "1"': function() {
        act.click("#gridScorecardWidget_DXEditor9_DDD_L_LBI1T0");
    },
    '18.Click span "Save changes"': function() {
        act.click(":containsExcludeChildren(Save changes)");
    },
    '19.Click input "ctl00$ctl00$rootCal..."': function() {
        act.click("#comboCards_I");
    },
    '20.Click table cell "Card B"': function() {
        act.click("#comboCards_DDD_L_LBI1T0");
    },
    "21.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow0").find(":containsExcludeChildren(1)");
        };
        act.dblclick(actionTarget);
    },
    "22.Click table cell": function() {
        act.click("#gridScorecardWidget_DXEditor9_B-1");
    },
    '23.Click table cell "0"': function() {
        act.click("#gridScorecardWidget_DXEditor9_DDD_L_LBI0T0");
    },
    "24.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow1").find(":containsExcludeChildren(2)").eq(1);
        };
        act.dblclick(actionTarget);
    },
    "25.Click table cell": function() {
        act.click("#gridScorecardWidget_DXEditor10_B-1");
    },
    '26.Click table cell "1"': function() {
        act.click("#gridScorecardWidget_DXEditor10_DDD_L_LBI1T0");
    },
    "27.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow2").find(":containsExcludeChildren(0)").eq(0);
        };
        act.dblclick(actionTarget);
    },
    "28.Click table cell": function() {
        act.click("..dxgv.dx-al.dxgvBatchEditCell_MaterialCompact.dxgv.dxgvFocusedCell_MaterialCompact");
    },
    "29.Click table cell": function() {
        act.click("#gridScorecardWidget_DXEditor9_B-1");
    },
    '30.Click table cell "2"': function() {
        act.click("#gridScorecardWidget_DXEditor9_DDD_L_LBI1T0");
    },
    "31.Press key TAB": function() {
        act.press("tab");
    },
    "32.Press key DOWN": function() {
        act.press("down");
    },
    "33.Press key DOWN": function() {
        act.press("down");
    },
    "34.Press key TAB": function() {
        act.press("tab");
    },
    "35.Press key DOWN": function() {
        act.press("down");
    },
    "36.Press key DOWN": function() {
        act.press("down");
    },
    "37.Press key TAB": function() {
        act.press("tab");
    },
    '38.Click image "Save changes"': function() {
        act.click("#gridScorecardWidget_DXCBtn0Img");
    },
    "39.Click table cell": function() {
        var actionTarget = function() {
            return $("#gridArea_DXDataRow1").find(".dxgv.dx-ellipsis").eq(2);
        };
        act.click(actionTarget);
    },
    '40.Click input "ctl00$ctl00$rootCal..."': function() {
        act.click("#comboCards_I");
    },
    '41.Click table cell "Card A"': function() {
        act.click("#comboCards_DDD_L_LBI0T0");
    },
    "42.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow0").find(":containsExcludeChildren(2)");
        };
        act.dblclick(actionTarget);
    },
    '43.Type in input "ctl00$ctl00$rootCal..."': function() {
        act.type("#gridScorecardWidget_DXEditor9_I", "1", {
            caretPos: 0
        });
    },
    "44.Click div": function() {
        act.click("#widgetScoreCard_PWC-1");
    },
    '45.Click span "Save changes"': function() {
        act.click(":containsExcludeChildren(Save changes)");
    },
    '46.Click span "Business process"': function() {
        var actionTarget = function() {
            return $("#tabRTM_T2T").find(":containsExcludeChildren(Business process)");
        };
        act.click(actionTarget);
    },
    '47.Click table cell "Terminate Business..."': function() {
        act.click(":containsExcludeChildren(Terminate Business Relationship)");
    },
    "48.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#comboCards").find(".dxic");
        };
        act.dblclick(actionTarget);
    },
    "49.Dblclick table cell": function() {
        act.dblclick("#comboCards_B-1");
    },
    "50.Click table cell": function() {
        act.click("#comboCards_B-1");
    },
    "51.Click link": function() {
        act.click("#tabRTM_T0T");
    },
    '52.Click table cell "Contractor..."': function() {
        var actionTarget = function() {
            return $("#gridArea_DXDataRow3").find(":containsExcludeChildren(Contractor Management)");
        };
        act.click(actionTarget);
    },
    '53.Click input "ctl00$ctl00$rootCal..."': function() {
        act.click("#comboCards_I");
    },
    '54.Click table cell "Card B"': function() {
        act.click("#comboCards_DDD_L_LBI1T0");
    },
    "55.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow0").find(":containsExcludeChildren(0)").eq(0);
        };
        act.dblclick(actionTarget);
    },
    "56.Click table cell": function() {
        act.click("#gridScorecardWidget_DXEditor9_B-1");
    },
    '57.Click table cell "1"': function() {
        act.click("#gridScorecardWidget_DXEditor9_DDD_L_LBI1T0");
    },
    "58.Dblclick table cell": function() {
        var actionTarget = function() {
            return $("#gridScorecardWidget_DXDataRow1").find(":containsExcludeChildren(0)").eq(1);
        };
        act.dblclick(actionTarget);
    },
    "59.Click table cell": function() {
        act.click("#gridScorecardWidget_DXEditor10_B-1");
    },
    '60.Click table cell "1"': function() {
        act.click("#gridScorecardWidget_DXEditor10_DDD_L_LBI1T0");
    },
    '61.Click span "Save changes"': function() {
        act.click(":containsExcludeChildren(Save changes)");
    },
    "62.Click div": function() {
        act.click("#widgetScoreCard_HCB-1");
    },
    "63.Click div": function() {
        act.click("#xsplitter_0_CC");
    }
};

