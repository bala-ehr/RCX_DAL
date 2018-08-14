using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for dump
/// </summary>
public class dump : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRTable xrTable4;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRTable xrTable3;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell8;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
    private XRTableCell xrTableCell47;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell1;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell9;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell75;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell84;
    private XRTableRow xrTableRow18;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRTableRow xrTableRow19;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableRow xrTableRow20;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTableRow xrTableRow21;
    private XRTableCell xrTableCell94;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableRow xrTableRow22;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableRow xrTableRow23;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRTableRow xrTableRow24;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTableRow xrTableRow25;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableRow xrTableRow26;
    private XRTableCell xrTableCell109;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableRow xrTableRow27;
    private XRTableCell xrTableCell112;
    private XRTableCell xrTableCell113;
    private XRTableCell xrTableCell114;
    private XRTableRow xrTableRow28;
    private XRTableCell xrTableCell115;
    private XRTableCell xrTableCell116;
    private XRTableCell xrTableCell117;
    private XRTableRow xrTableRow29;
    private XRTableCell xrTableCell118;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow30;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell123;
    private XRTableRow xrTableRow31;
    private XRTableCell xrTableCell124;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTableRow xrTableRow32;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell128;
    private XRTableCell xrTableCell129;
    private XRTableRow xrTableRow33;
    private XRTableCell xrTableCell130;
    private XRTableCell xrTableCell131;
    private XRTableCell xrTableCell132;
    private XRTableRow xrTableRow34;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRTableCell xrTableCell135;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableCell xrTableCell138;
    private XRTableRow xrTableRow36;
    private XRTableCell xrTableCell139;
    private XRTableCell xrTableCell140;
    private XRTableCell xrTableCell141;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell142;
    private XRTableCell xrTableCell143;
    private XRTableCell xrTableCell144;
    private XRTable xrTable5;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell145;
    private XRTableCell xrTableCell146;
    private XRTableCell xrTableCell147;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell148;
    private XRTableCell xrTableCell149;
    private XRTableCell xrTableCell150;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell151;
    private XRTableCell xrTableCell152;
    private XRTableCell xrTableCell153;
    private XRTableRow xrTableRow41;
    private XRTableCell xrTableCell154;
    private XRTableCell xrTableCell155;
    private XRTableCell xrTableCell156;
    private XRTableRow xrTableRow42;
    private XRTableCell xrTableCell157;
    private XRTableCell xrTableCell158;
    private XRTableCell xrTableCell159;
    private XRTableRow xrTableRow43;
    private XRTableCell xrTableCell160;
    private XRTableCell xrTableCell161;
    private XRTableCell xrTableCell162;
    private XRTableRow xrTableRow44;
    private XRTableCell xrTableCell163;
    private XRTableCell xrTableCell164;
    private XRTableCell xrTableCell165;
    private XRTableRow xrTableRow45;
    private XRTableCell xrTableCell166;
    private XRTableCell xrTableCell167;
    private XRTableCell xrTableCell168;
    private XRTableRow xrTableRow46;
    private XRTableCell xrTableCell169;
    private XRTableCell xrTableCell170;
    private XRTableCell xrTableCell171;
    private XRTableRow xrTableRow47;
    private XRTableCell xrTableCell172;
    private XRTableCell xrTableCell173;
    private XRTableCell xrTableCell174;
    private XRTableRow xrTableRow48;
    private XRTableCell xrTableCell175;
    private XRTableCell xrTableCell176;
    private XRTableCell xrTableCell177;
    private XRTableRow xrTableRow49;
    private XRTableCell xrTableCell178;
    private XRTableCell xrTableCell179;
    private XRTableCell xrTableCell180;
    private XRTableRow xrTableRow50;
    private XRTableCell xrTableCell181;
    private XRTableCell xrTableCell182;
    private XRTableCell xrTableCell183;
    private XRTableRow xrTableRow51;
    private XRTableCell xrTableCell184;
    private XRTableCell xrTableCell185;
    private XRTableCell xrTableCell186;
    private XRTableRow xrTableRow52;
    private XRTableCell xrTableCell187;
    private XRTableCell xrTableCell188;
    private XRTableCell xrTableCell189;
    private XRTableRow xrTableRow53;
    private XRTableCell xrTableCell190;
    private XRTableCell xrTableCell191;
    private XRTableCell xrTableCell192;
    private XRTableRow xrTableRow54;
    private XRTableCell xrTableCell193;
    private XRTableCell xrTableCell194;
    private XRTableCell xrTableCell195;
    private XRTableRow xrTableRow55;
    private XRTableCell xrTableCell196;
    private XRTableCell xrTableCell197;
    private XRTableCell xrTableCell198;
    private XRTableRow xrTableRow56;
    private XRTableCell xrTableCell199;
    private XRTableCell xrTableCell200;
    private XRTableCell xrTableCell201;
    private XRLabel xrLabel16;
    private XRLabel xrLabel4;
    private XRLabel xrLabel22;
    private XRLabel xrLabel1;
    private XRLabel xrLabel17;
    private XRLabel xrLabel18;
    private XRLabel xrLabel20;
    private XRLabel xrLabel21;
    private XRLabel xrLabel26;
    private XRTable xrTable6;
    private XRTableRow xrTableRow57;
    private XRTableCell xrTableCell202;
    private XRTableCell xrTableCell203;
    private XRTableCell xrTableCell204;
    private XRTableCell xrTableCell205;
    private XRPanel spacer;
    private XRLabel xrLabel2;
    private XRLabel xrLabel9;
    private XRLabel xrLabel19;
    private XRLabel xrLabel23;
    private XRTable xrTable7;
    private XRTableRow xrTableRow58;
    private XRTableCell xrTableCell206;
    private XRTableCell xrTableCell207;
    private XRTableCell xrTableCell208;
    private XRTableCell xrTableCell209;
    private XRLabel xrLabel24;
    private XRLabel xrLabel27;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    private XRLabel xrLabel15;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel10;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public dump()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dump));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell157 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell158 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow43 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell160 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow45 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow46 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell170 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell171 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow47 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell172 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell173 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell174 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow48 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell175 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell176 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell177 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow49 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell178 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell179 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow50 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell181 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell182 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow51 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell184 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell185 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell186 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow52 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell187 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell188 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell189 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow53 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell190 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell191 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell192 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow54 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell193 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell194 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell195 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow55 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell196 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell197 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell198 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow56 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell199 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell200 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell201 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow57 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell202 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell203 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell204 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell205 = new DevExpress.XtraReports.UI.XRTableCell();
            this.spacer = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow58 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell206 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell207 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell208 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell209 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrTable3,
            this.xrLabel6,
            this.xrLabel5,
            this.xrTable4});
            this.Detail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail.HeightF = 1330.108F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(55.33317F, 156.25F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow19,
            this.xrTableRow20,
            this.xrTableRow21,
            this.xrTableRow22,
            this.xrTableRow23,
            this.xrTableRow24,
            this.xrTableRow25,
            this.xrTableRow26,
            this.xrTableRow27,
            this.xrTableRow28,
            this.xrTableRow29});
            this.xrTable1.SizeF = new System.Drawing.SizeF(744.8751F, 450F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell1});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Timeliness of Process";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell2.Weight = 2.3010415641518955D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.Text = "BP As-Is > Timeliness > \"Level 1\", etc. ";
            this.xrTableCell3.Weight = 2.834791565158425D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "BP To-Be > Timliness > \"Level 1\", etc.";
            this.xrTableCell1.Weight = 2.8541665644157392D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Performance Measure";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell4.Weight = 2.3010415641518955D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.Text = "BP As-Is > Timeliness > Performance Measure";
            this.xrTableCell5.Weight = 2.834791565158425D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.Text = "BP As-Is > Timeliness > Performance Measure";
            this.xrTableCell9.Weight = 2.8541665644157392D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell58,
            this.xrTableCell75});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Supporting Evidence Reference";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell11.Weight = 2.3010415641518955D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell58.StylePriority.UseBorders = false;
            this.xrTableCell58.StylePriority.UsePadding = false;
            this.xrTableCell58.Text = "REPOSITORY >Timeliness> What\'s attached?";
            this.xrTableCell58.Weight = 2.834791565158425D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell75.StylePriority.UseBorders = false;
            this.xrTableCell75.StylePriority.UsePadding = false;
            this.xrTableCell75.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell75.Weight = 2.8541665644157392D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell76.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell76.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell76.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell76.StylePriority.UseBackColor = false;
            this.xrTableCell76.StylePriority.UseBorders = false;
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UseForeColor = false;
            this.xrTableCell76.StylePriority.UsePadding = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.Text = "Data Access and Accuracy";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell76.Weight = 2.3010415641518955D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell77.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell77.StylePriority.UseBorders = false;
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UsePadding = false;
            this.xrTableCell77.Text = "BP As-Is > Data Access > \"Level 1\", etc.";
            this.xrTableCell77.Weight = 2.834791565158425D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell78.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell78.StylePriority.UseBorders = false;
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.StylePriority.UsePadding = false;
            this.xrTableCell78.Text = "BP To-Be > Data Access > \"Level 1\", etc.";
            this.xrTableCell78.Weight = 2.8541665644157392D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell79.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell79.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell79.StylePriority.UseBackColor = false;
            this.xrTableCell79.StylePriority.UseBorders = false;
            this.xrTableCell79.StylePriority.UseFont = false;
            this.xrTableCell79.StylePriority.UsePadding = false;
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.Text = "Performance Measure";
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell79.Weight = 2.3010415641518955D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell80.StylePriority.UseBorders = false;
            this.xrTableCell80.StylePriority.UsePadding = false;
            this.xrTableCell80.Text = "BP As-Is > Data Access > Perf. Measure";
            this.xrTableCell80.Weight = 2.834791565158425D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell81.StylePriority.UseBorders = false;
            this.xrTableCell81.StylePriority.UsePadding = false;
            this.xrTableCell81.Text = "BP As-Is > Data Access > Perf. Measure";
            this.xrTableCell81.Weight = 2.8541665644157392D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell82.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell82.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell82.StylePriority.UseBackColor = false;
            this.xrTableCell82.StylePriority.UseBorders = false;
            this.xrTableCell82.StylePriority.UseFont = false;
            this.xrTableCell82.StylePriority.UsePadding = false;
            this.xrTableCell82.StylePriority.UseTextAlignment = false;
            this.xrTableCell82.Text = "Supporting Evidence Reference";
            this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell82.Weight = 2.3010415641518955D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell83.StylePriority.UseBorders = false;
            this.xrTableCell83.StylePriority.UsePadding = false;
            this.xrTableCell83.Text = "REPOSITORY>Data Access> What\'s attached?";
            this.xrTableCell83.Weight = 2.834791565158425D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell84.StylePriority.UseBorders = false;
            this.xrTableCell84.StylePriority.UsePadding = false;
            this.xrTableCell84.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell84.Weight = 2.8541665644157392D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell86,
            this.xrTableCell87});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell85.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell85.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell85.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell85.StylePriority.UseBackColor = false;
            this.xrTableCell85.StylePriority.UseBorders = false;
            this.xrTableCell85.StylePriority.UseFont = false;
            this.xrTableCell85.StylePriority.UseForeColor = false;
            this.xrTableCell85.StylePriority.UsePadding = false;
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.Text = "Cost-Effectiveness";
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell85.Weight = 2.3010415641518955D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell86.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell86.StylePriority.UseBorders = false;
            this.xrTableCell86.StylePriority.UseFont = false;
            this.xrTableCell86.StylePriority.UsePadding = false;
            this.xrTableCell86.Text = "BP As-Is > Cost-eff > \"Level 1\", etc.";
            this.xrTableCell86.Weight = 2.834791565158425D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell87.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell87.StylePriority.UseBorders = false;
            this.xrTableCell87.StylePriority.UseFont = false;
            this.xrTableCell87.StylePriority.UsePadding = false;
            this.xrTableCell87.Text = "BP To-Be > Cost-Eff > \"Level 1\", etc.";
            this.xrTableCell87.Weight = 2.8541665644157392D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Weight = 1D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell88.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell88.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell88.StylePriority.UseBackColor = false;
            this.xrTableCell88.StylePriority.UseBorders = false;
            this.xrTableCell88.StylePriority.UseFont = false;
            this.xrTableCell88.StylePriority.UsePadding = false;
            this.xrTableCell88.StylePriority.UseTextAlignment = false;
            this.xrTableCell88.Text = "Performance Measure";
            this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell88.Weight = 2.3010415641518955D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell89.StylePriority.UseBorders = false;
            this.xrTableCell89.StylePriority.UsePadding = false;
            this.xrTableCell89.Text = "BP As-Is > Cost-eff > Performance Measure";
            this.xrTableCell89.Weight = 2.834791565158425D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell90.StylePriority.UseBorders = false;
            this.xrTableCell90.StylePriority.UsePadding = false;
            this.xrTableCell90.Text = "BP As-Is > Cost-eff > Performance Measure";
            this.xrTableCell90.Weight = 2.8541665644157392D;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 1D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell91.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell91.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell91.StylePriority.UseBackColor = false;
            this.xrTableCell91.StylePriority.UseBorders = false;
            this.xrTableCell91.StylePriority.UseFont = false;
            this.xrTableCell91.StylePriority.UsePadding = false;
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.Text = "Supporting Evidence Reference";
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell91.Weight = 2.3010415641518955D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell92.StylePriority.UseBorders = false;
            this.xrTableCell92.StylePriority.UsePadding = false;
            this.xrTableCell92.Text = "REPOSITORY >Cost-eff> What\'s attached?";
            this.xrTableCell92.Weight = 2.834791565158425D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell93.StylePriority.UseBorders = false;
            this.xrTableCell93.StylePriority.UsePadding = false;
            this.xrTableCell93.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell93.Weight = 2.8541665644157392D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 1D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell94.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell94.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell94.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell94.StylePriority.UseBackColor = false;
            this.xrTableCell94.StylePriority.UseBorders = false;
            this.xrTableCell94.StylePriority.UseFont = false;
            this.xrTableCell94.StylePriority.UseForeColor = false;
            this.xrTableCell94.StylePriority.UsePadding = false;
            this.xrTableCell94.StylePriority.UseTextAlignment = false;
            this.xrTableCell94.Text = "Effort to Perform; Efficiency";
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell94.Weight = 2.3010415641518955D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell95.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell95.StylePriority.UseBorders = false;
            this.xrTableCell95.StylePriority.UseFont = false;
            this.xrTableCell95.StylePriority.UsePadding = false;
            this.xrTableCell95.Text = "BP As-Is > Effort > \"Level 1\", etc.";
            this.xrTableCell95.Weight = 2.834791565158425D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell96.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell96.StylePriority.UseBorders = false;
            this.xrTableCell96.StylePriority.UseFont = false;
            this.xrTableCell96.StylePriority.UsePadding = false;
            this.xrTableCell96.Text = "BP To-Be > Effort > \"Level 1\", etc.";
            this.xrTableCell96.Weight = 2.8541665644157392D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.Weight = 1D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell97.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell97.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell97.StylePriority.UseBackColor = false;
            this.xrTableCell97.StylePriority.UseBorders = false;
            this.xrTableCell97.StylePriority.UseFont = false;
            this.xrTableCell97.StylePriority.UsePadding = false;
            this.xrTableCell97.StylePriority.UseTextAlignment = false;
            this.xrTableCell97.Text = "Performance Measure";
            this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell97.Weight = 2.3010415641518955D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell98.StylePriority.UseBorders = false;
            this.xrTableCell98.StylePriority.UsePadding = false;
            this.xrTableCell98.Text = "BP As-Is > Effort > Performance Measure";
            this.xrTableCell98.Weight = 2.834791565158425D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell99.StylePriority.UseBorders = false;
            this.xrTableCell99.StylePriority.UsePadding = false;
            this.xrTableCell99.Text = "BP As-Is > Effort > Performance Measure";
            this.xrTableCell99.Weight = 2.8541665644157392D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 1D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell100.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell100.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell100.StylePriority.UseBackColor = false;
            this.xrTableCell100.StylePriority.UseBorders = false;
            this.xrTableCell100.StylePriority.UseFont = false;
            this.xrTableCell100.StylePriority.UsePadding = false;
            this.xrTableCell100.StylePriority.UseTextAlignment = false;
            this.xrTableCell100.Text = "Supporting Evidence Reference";
            this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell100.Weight = 2.3010415641518955D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell101.StylePriority.UseBorders = false;
            this.xrTableCell101.StylePriority.UsePadding = false;
            this.xrTableCell101.Text = "REPOSITORY >Effort> What\'s attached?";
            this.xrTableCell101.Weight = 2.834791565158425D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell102.StylePriority.UseBorders = false;
            this.xrTableCell102.StylePriority.UsePadding = false;
            this.xrTableCell102.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell102.Weight = 2.8541665644157392D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.Weight = 1D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell103.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell103.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell103.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell103.StylePriority.UseBackColor = false;
            this.xrTableCell103.StylePriority.UseBorders = false;
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.StylePriority.UseForeColor = false;
            this.xrTableCell103.StylePriority.UsePadding = false;
            this.xrTableCell103.StylePriority.UseTextAlignment = false;
            this.xrTableCell103.Text = "Accuracy of Process Results";
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell103.Weight = 2.3010415641518955D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell104.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell104.StylePriority.UseBorders = false;
            this.xrTableCell104.StylePriority.UseFont = false;
            this.xrTableCell104.StylePriority.UsePadding = false;
            this.xrTableCell104.Text = "BP As-Is > Accuracy > \"Level 1\", etc.";
            this.xrTableCell104.Weight = 2.834791565158425D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell105.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell105.StylePriority.UseBorders = false;
            this.xrTableCell105.StylePriority.UseFont = false;
            this.xrTableCell105.StylePriority.UsePadding = false;
            this.xrTableCell105.Text = "BP To-Be > Accuracy > \"Level 1\", etc.";
            this.xrTableCell105.Weight = 2.8541665644157392D;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 1D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell106.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell106.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell106.StylePriority.UseBackColor = false;
            this.xrTableCell106.StylePriority.UseBorders = false;
            this.xrTableCell106.StylePriority.UseFont = false;
            this.xrTableCell106.StylePriority.UsePadding = false;
            this.xrTableCell106.StylePriority.UseTextAlignment = false;
            this.xrTableCell106.Text = "Performance Measure";
            this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell106.Weight = 2.3010415641518955D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell107.StylePriority.UseBorders = false;
            this.xrTableCell107.StylePriority.UsePadding = false;
            this.xrTableCell107.Text = "BP As-Is > Accuracy > Performance Measure";
            this.xrTableCell107.Weight = 2.834791565158425D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell108.StylePriority.UseBorders = false;
            this.xrTableCell108.StylePriority.UsePadding = false;
            this.xrTableCell108.Text = "BP As-Is > Accuracy > Performance Measure";
            this.xrTableCell108.Weight = 2.8541665644157392D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell109,
            this.xrTableCell110,
            this.xrTableCell111});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.Weight = 1D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell109.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell109.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell109.StylePriority.UseBackColor = false;
            this.xrTableCell109.StylePriority.UseBorders = false;
            this.xrTableCell109.StylePriority.UseFont = false;
            this.xrTableCell109.StylePriority.UsePadding = false;
            this.xrTableCell109.StylePriority.UseTextAlignment = false;
            this.xrTableCell109.Text = "Supporting Evidence Reference";
            this.xrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell109.Weight = 2.3010415641518955D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell110.StylePriority.UseBorders = false;
            this.xrTableCell110.StylePriority.UsePadding = false;
            this.xrTableCell110.Text = "REPOSITORY >Accuracy> What\'s attached?";
            this.xrTableCell110.Weight = 2.834791565158425D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell111.StylePriority.UseBorders = false;
            this.xrTableCell111.StylePriority.UsePadding = false;
            this.xrTableCell111.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell111.Weight = 2.8541665644157392D;
            // 
            // xrTableRow27
            // 
            this.xrTableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell112,
            this.xrTableCell113,
            this.xrTableCell114});
            this.xrTableRow27.Name = "xrTableRow27";
            this.xrTableRow27.Weight = 1D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell112.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell112.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell112.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell112.StylePriority.UseBackColor = false;
            this.xrTableCell112.StylePriority.UseBorders = false;
            this.xrTableCell112.StylePriority.UseFont = false;
            this.xrTableCell112.StylePriority.UseForeColor = false;
            this.xrTableCell112.StylePriority.UsePadding = false;
            this.xrTableCell112.StylePriority.UseTextAlignment = false;
            this.xrTableCell112.Text = "Utility or Value to Stakeholder";
            this.xrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell112.Weight = 2.3010415641518955D;
            // 
            // xrTableCell113
            // 
            this.xrTableCell113.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell113.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell113.Name = "xrTableCell113";
            this.xrTableCell113.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell113.StylePriority.UseBorders = false;
            this.xrTableCell113.StylePriority.UseFont = false;
            this.xrTableCell113.StylePriority.UsePadding = false;
            this.xrTableCell113.Text = "BP As-Is > Utility > \"Level 1\", etc.";
            this.xrTableCell113.Weight = 2.834791565158425D;
            // 
            // xrTableCell114
            // 
            this.xrTableCell114.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell114.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell114.Name = "xrTableCell114";
            this.xrTableCell114.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell114.StylePriority.UseBorders = false;
            this.xrTableCell114.StylePriority.UseFont = false;
            this.xrTableCell114.StylePriority.UsePadding = false;
            this.xrTableCell114.Text = "BP To-Be > Utility > \"Level 1\", etc.";
            this.xrTableCell114.Weight = 2.8541665644157392D;
            // 
            // xrTableRow28
            // 
            this.xrTableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell115,
            this.xrTableCell116,
            this.xrTableCell117});
            this.xrTableRow28.Name = "xrTableRow28";
            this.xrTableRow28.Weight = 1D;
            // 
            // xrTableCell115
            // 
            this.xrTableCell115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell115.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell115.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell115.Name = "xrTableCell115";
            this.xrTableCell115.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell115.StylePriority.UseBackColor = false;
            this.xrTableCell115.StylePriority.UseBorders = false;
            this.xrTableCell115.StylePriority.UseFont = false;
            this.xrTableCell115.StylePriority.UsePadding = false;
            this.xrTableCell115.StylePriority.UseTextAlignment = false;
            this.xrTableCell115.Text = "Performance Measure";
            this.xrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell115.Weight = 2.3010415641518955D;
            // 
            // xrTableCell116
            // 
            this.xrTableCell116.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell116.Name = "xrTableCell116";
            this.xrTableCell116.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell116.StylePriority.UseBorders = false;
            this.xrTableCell116.StylePriority.UsePadding = false;
            this.xrTableCell116.Text = "BP As-Is > Utility > Performance Measure";
            this.xrTableCell116.Weight = 2.834791565158425D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell117.StylePriority.UseBorders = false;
            this.xrTableCell117.StylePriority.UsePadding = false;
            this.xrTableCell117.Text = "BP As-Is > Utility > Performance Measure";
            this.xrTableCell117.Weight = 2.8541665644157392D;
            // 
            // xrTableRow29
            // 
            this.xrTableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell118,
            this.xrTableCell119,
            this.xrTableCell120});
            this.xrTableRow29.Name = "xrTableRow29";
            this.xrTableRow29.Weight = 1D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell118.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell118.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell118.StylePriority.UseBackColor = false;
            this.xrTableCell118.StylePriority.UseBorders = false;
            this.xrTableCell118.StylePriority.UseFont = false;
            this.xrTableCell118.StylePriority.UsePadding = false;
            this.xrTableCell118.StylePriority.UseTextAlignment = false;
            this.xrTableCell118.Text = "Supporting Evidence Reference";
            this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell118.Weight = 2.3010415641518955D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell119.StylePriority.UseBorders = false;
            this.xrTableCell119.StylePriority.UsePadding = false;
            this.xrTableCell119.Text = "REPOSITORY >Utility> What\'s attached?";
            this.xrTableCell119.Weight = 2.834791565158425D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell120.StylePriority.UseBorders = false;
            this.xrTableCell120.StylePriority.UsePadding = false;
            this.xrTableCell120.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell120.Weight = 2.8541665644157392D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(17.83317F, 715.7258F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow6,
            this.xrTableRow11,
            this.xrTableRow13,
            this.xrTableRow10,
            this.xrTableRow12,
            this.xrTableRow9,
            this.xrTableRow8,
            this.xrTableRow7,
            this.xrTableRow5});
            this.xrTable3.SizeF = new System.Drawing.SizeF(838.6251F, 459.1734F);
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell59,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell10,
            this.xrTableCell12,
            this.xrTableCell8});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseBorders = false;
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell59.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell59.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell59.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell59.Multiline = true;
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell59.StylePriority.UseBackColor = false;
            this.xrTableCell59.StylePriority.UseBorderColor = false;
            this.xrTableCell59.StylePriority.UseBorders = false;
            this.xrTableCell59.StylePriority.UseFont = false;
            this.xrTableCell59.StylePriority.UsePadding = false;
            this.xrTableCell59.StylePriority.UseTextAlignment = false;
            this.xrTableCell59.Text = "Is the Process Primarily\r\nManual or Automatic? ";
            this.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell59.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell6.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorderColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Text = "The process consists primarily of manual paper-based activity to accomplish tasks" +
    ".\r\n";
            this.xrTableCell6.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell7.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.Text = " SMA uses a mix of manual and automatic processes to accomplish tasks.\r\n";
            this.xrTableCell7.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell10.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "SMA automates process to the full extent possible within the intrastate.\r\n";
            this.xrTableCell10.Weight = 1D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell12.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell12.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.StylePriority.UseBorderColor = false;
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseForeColor = false;
            this.xrTableCell12.Text = "SMA automates process to the full extent possible across the interstate.\r\n";
            this.xrTableCell12.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell8.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.StylePriority.UseBorderColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Text = "SMA automates process to the full extent possible across the nation.\r\n";
            this.xrTableCell8.Weight = 1D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell60,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.StylePriority.UseBorders = false;
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell60.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell60.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell60.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell60.StylePriority.UseBackColor = false;
            this.xrTableCell60.StylePriority.UseBorderColor = false;
            this.xrTableCell60.StylePriority.UseBorders = false;
            this.xrTableCell60.StylePriority.UseFont = false;
            this.xrTableCell60.StylePriority.UsePadding = false;
            this.xrTableCell60.StylePriority.UseTextAlignment = false;
            this.xrTableCell60.Text = "Does the State Medicaid Agency use standards in the process?";
            this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell60.Weight = 1D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell18.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.StylePriority.UseBorderColor = false;
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "SMA focuses on meeting compliance thresholds for state and federal regulations us" +
    "ing state-specific standards.\r\n";
            this.xrTableCell18.Weight = 1D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell19.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.StylePriority.UseBorderColor = false;
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.Text = "SMA applies a mix of HIPAA and statespecific standards.\r\n";
            this.xrTableCell19.Weight = 1D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell20.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell20.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBackColor = false;
            this.xrTableCell20.StylePriority.UseBorderColor = false;
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.StylePriority.UseForeColor = false;
            this.xrTableCell20.Text = "SMA adopts MITA Framework, industry standards (e.g., HIPAA, Affordable Care Act) " +
    "and other nationally recognized standards for intrastate exchange of member dise" +
    "nrollment information.\r\n";
            this.xrTableCell20.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell21.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.StylePriority.UseBorderColor = false;
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.Text = resources.GetString("xrTableCell21.Text");
            this.xrTableCell21.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell22.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBackColor = false;
            this.xrTableCell22.StylePriority.UseBorderColor = false;
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Text = resources.GetString("xrTableCell22.Text");
            this.xrTableCell22.Weight = 1D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.StylePriority.UseBorders = false;
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell61.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell61.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell61.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell61.StylePriority.UseBackColor = false;
            this.xrTableCell61.StylePriority.UseBorderColor = false;
            this.xrTableCell61.StylePriority.UseBorders = false;
            this.xrTableCell61.StylePriority.UseFont = false;
            this.xrTableCell61.StylePriority.UsePadding = false;
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.Text = "How does the State Medicaid Agency collaborate with other agencies or entities in" +
    " performing the process?";
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell61.Weight = 1D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell43.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell43.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell43.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.StylePriority.UseBackColor = false;
            this.xrTableCell43.StylePriority.UseBorderColor = false;
            this.xrTableCell43.StylePriority.UseBorders = false;
            this.xrTableCell43.StylePriority.UseFont = false;
            this.xrTableCell43.Text = "Very little collaboration occurs with other agencies to standardize information e" +
    "xchange or business tasks.\r\n";
            this.xrTableCell43.Weight = 1D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell44.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell44.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell44.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell44.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell44.Multiline = true;
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.StylePriority.UseBackColor = false;
            this.xrTableCell44.StylePriority.UseBorderColor = false;
            this.xrTableCell44.StylePriority.UseBorders = false;
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UseForeColor = false;
            this.xrTableCell44.Text = "The agency collaborates with other agencies and entities to adopt HIPAA standards" +
    " and EDI transactions.\r\n";
            this.xrTableCell44.Weight = 1D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell45.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell45.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell45.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell45.Multiline = true;
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.StylePriority.UseBackColor = false;
            this.xrTableCell45.StylePriority.UseBorderColor = false;
            this.xrTableCell45.StylePriority.UseBorders = false;
            this.xrTableCell45.StylePriority.UseFont = false;
            this.xrTableCell45.Text = "SMA collaborates with insurance affordability programs to develop and implement c" +
    "ommon disenrollment standards. The SMA documents the arrangement in an agreement" +
    ".\r\n";
            this.xrTableCell45.Weight = 1D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell46.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell46.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell46.Multiline = true;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.StylePriority.UseBackColor = false;
            this.xrTableCell46.StylePriority.UseBorderColor = false;
            this.xrTableCell46.StylePriority.UseBorders = false;
            this.xrTableCell46.StylePriority.UseFont = false;
            this.xrTableCell46.Text = resources.GetString("xrTableCell46.Text");
            this.xrTableCell46.Weight = 1D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell47.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell47.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell47.Multiline = true;
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.StylePriority.UseBackColor = false;
            this.xrTableCell47.StylePriority.UseBorderColor = false;
            this.xrTableCell47.StylePriority.UseBorders = false;
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.Text = resources.GetString("xrTableCell47.Text");
            this.xrTableCell47.Weight = 1D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell62,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.StylePriority.UseBorders = false;
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell62.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell62.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell62.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell62.StylePriority.UseBackColor = false;
            this.xrTableCell62.StylePriority.UseBorderColor = false;
            this.xrTableCell62.StylePriority.UseBorders = false;
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UsePadding = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.Text = "How timely is the end-to-end process?";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell62.Weight = 1D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell53.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell53.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell53.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell53.Multiline = true;
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBackColor = false;
            this.xrTableCell53.StylePriority.UseBorderColor = false;
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.Text = resources.GetString("xrTableCell53.Text");
            this.xrTableCell53.Weight = 1D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell54.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell54.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell54.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell54.Multiline = true;
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBackColor = false;
            this.xrTableCell54.StylePriority.UseBorderColor = false;
            this.xrTableCell54.StylePriority.UseBorders = false;
            this.xrTableCell54.StylePriority.UseFont = false;
            this.xrTableCell54.Text = "SMA improves timeliness through use of automation. Timeliness always meets legal " +
    "requirements. SMA completes disenrollment in one (1) business day.\r\n";
            this.xrTableCell54.Weight = 1D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell55.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell55.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell55.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell55.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBackColor = false;
            this.xrTableCell55.StylePriority.UseBorderColor = false;
            this.xrTableCell55.StylePriority.UseBorders = false;
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.StylePriority.UseForeColor = false;
            this.xrTableCell55.Text = "Timeliness improves via Marketplace, state and federal collaboration, use of memb" +
    "er disenrollment information sharing, and standards. Timeliness exceeds Level 2." +
    "\r\n";
            this.xrTableCell55.Weight = 1D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell56.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell56.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell56.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell56.Multiline = true;
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseBackColor = false;
            this.xrTableCell56.StylePriority.UseBorderColor = false;
            this.xrTableCell56.StylePriority.UseBorders = false;
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.Text = "Information is available in near real time. Processes that use interstate member " +
    "disenrollment information result in immediate action, response, and results.\r\n";
            this.xrTableCell56.Weight = 1D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell57.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell57.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell57.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell57.Multiline = true;
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseBackColor = false;
            this.xrTableCell57.StylePriority.UseBorderColor = false;
            this.xrTableCell57.StylePriority.UseBorders = false;
            this.xrTableCell57.StylePriority.UseFont = false;
            this.xrTableCell57.Text = resources.GetString("xrTableCell57.Text");
            this.xrTableCell57.Weight = 1D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell63,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.StylePriority.UseBorders = false;
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell63.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell63.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell63.StylePriority.UseBackColor = false;
            this.xrTableCell63.StylePriority.UseBorderColor = false;
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UsePadding = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = "How accurate is the information in the process?";
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell63.Weight = 1D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell38.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell38.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell38.Multiline = true;
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseBackColor = false;
            this.xrTableCell38.StylePriority.UseBorderColor = false;
            this.xrTableCell38.StylePriority.UseBorders = false;
            this.xrTableCell38.StylePriority.UseFont = false;
            this.xrTableCell38.Text = "Use of direct data entry for information collection is manually intensive and sus" +
    "ceptible to inconsistent or incorrect information. Stakeholders are unable to re" +
    "ly oninformation for decision-making.\r\n";
            this.xrTableCell38.Weight = 1D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell39.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell39.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell39.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell39.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell39.Multiline = true;
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.StylePriority.UseBorderColor = false;
            this.xrTableCell39.StylePriority.UseBorders = false;
            this.xrTableCell39.StylePriority.UseFont = false;
            this.xrTableCell39.StylePriority.UseForeColor = false;
            this.xrTableCell39.Text = "HIPAA standard transactions improve accuracy of information but the decision-maki" +
    "ng process may be erroneous or misleading. Accuracy is higher than at Level 1.\r\n" +
    "";
            this.xrTableCell39.Weight = 1D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell40.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell40.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell40.Multiline = true;
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.StylePriority.UseBackColor = false;
            this.xrTableCell40.StylePriority.UseBorderColor = false;
            this.xrTableCell40.StylePriority.UseBorders = false;
            this.xrTableCell40.StylePriority.UseFont = false;
            this.xrTableCell40.Text = resources.GetString("xrTableCell40.Text");
            this.xrTableCell40.Weight = 1D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell41.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell41.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell41.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell41.Multiline = true;
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.StylePriority.UseBorderColor = false;
            this.xrTableCell41.StylePriority.UseBorders = false;
            this.xrTableCell41.StylePriority.UseFont = false;
            this.xrTableCell41.Text = resources.GetString("xrTableCell41.Text");
            this.xrTableCell41.Weight = 1D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell42.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell42.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell42.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell42.Multiline = true;
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.StylePriority.UseBackColor = false;
            this.xrTableCell42.StylePriority.UseBorderColor = false;
            this.xrTableCell42.StylePriority.UseBorders = false;
            this.xrTableCell42.StylePriority.UseFont = false;
            this.xrTableCell42.Text = "SMA uses Marketplace, MITA Framework, and national standards for national disenro" +
    "llment information exchange. Decision-making is automatic using business rule en" +
    "gines. Accuracy is 90% or higher.\r\n";
            this.xrTableCell42.Weight = 1D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell64,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.StylePriority.UseBorders = false;
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell64.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell64.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell64.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell64.StylePriority.UseBackColor = false;
            this.xrTableCell64.StylePriority.UseBorderColor = false;
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.StylePriority.UseForeColor = false;
            this.xrTableCell64.StylePriority.UsePadding = false;
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.Text = "How accessible is the information in the process?";
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell64.Weight = 1D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell48.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell48.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell48.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell48.Multiline = true;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBackColor = false;
            this.xrTableCell48.StylePriority.UseBorderColor = false;
            this.xrTableCell48.StylePriority.UseBorders = false;
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.StylePriority.UseForeColor = false;
            this.xrTableCell48.Text = "SMA stores information in disparate systems including paper storage and obtains i" +
    "nformation manually. Systems experience extended scheduled and unscheduled downt" +
    "ime\r\n";
            this.xrTableCell48.Weight = 1D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell49.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell49.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell49.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseBackColor = false;
            this.xrTableCell49.StylePriority.UseBorderColor = false;
            this.xrTableCell49.StylePriority.UseBorders = false;
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.Text = "SMA stores information in disparate systems, but automation and HIPAA standards i" +
    "ncrease accessibility over Level 1. Systems experience extended scheduled and un" +
    "scheduled downtime\r\n";
            this.xrTableCell49.Weight = 1D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell50.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell50.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell50.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell50.Multiline = true;
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBackColor = false;
            this.xrTableCell50.StylePriority.UseBorderColor = false;
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.StylePriority.UseFont = false;
            this.xrTableCell50.Text = "SMA easily obtains and uses information from Marketplace and CHIP agency based on" +
    " MITA Framework and industry standards. Accessibility is greater than Level 2.\r\n" +
    "";
            this.xrTableCell50.Weight = 1D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell51.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell51.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell51.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell51.Multiline = true;
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBackColor = false;
            this.xrTableCell51.StylePriority.UseBorderColor = false;
            this.xrTableCell51.StylePriority.UseBorders = false;
            this.xrTableCell51.StylePriority.UseFont = false;
            this.xrTableCell51.Text = "SMA easily obtains and uses information from Marketplace and CHIP agency based on" +
    " MITA Framework and industry standards. Accessibility is greater than Level 3.\r\n" +
    "";
            this.xrTableCell51.Weight = 1D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell52.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell52.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell52.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBackColor = false;
            this.xrTableCell52.StylePriority.UseBorderColor = false;
            this.xrTableCell52.StylePriority.UseBorders = false;
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.Text = "SMA easily obtains and uses information from Marketplace and CHIP agency based on" +
    " MITA Framework and industry standards. Accessibility is greater than Level 4\r\n";
            this.xrTableCell52.Weight = 1D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell65,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseBorders = false;
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell65.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell65.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell65.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell65.StylePriority.UseBackColor = false;
            this.xrTableCell65.StylePriority.UseBorderColor = false;
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.StylePriority.UseFont = false;
            this.xrTableCell65.StylePriority.UseForeColor = false;
            this.xrTableCell65.StylePriority.UsePadding = false;
            this.xrTableCell65.StylePriority.UseTextAlignment = false;
            this.xrTableCell65.Text = "What is the cost of the process compared to the benefits of its results?";
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell65.Weight = 1D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell33.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell33.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell33.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell33.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell33.Multiline = true;
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseBackColor = false;
            this.xrTableCell33.StylePriority.UseBorderColor = false;
            this.xrTableCell33.StylePriority.UseBorders = false;
            this.xrTableCell33.StylePriority.UseFont = false;
            this.xrTableCell33.StylePriority.UseForeColor = false;
            this.xrTableCell33.Text = "High relative cost due to low number of automated, standardized tasks.\r\n";
            this.xrTableCell33.Weight = 1D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell34.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell34.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell34.Multiline = true;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseBackColor = false;
            this.xrTableCell34.StylePriority.UseBorderColor = false;
            this.xrTableCell34.StylePriority.UseBorders = false;
            this.xrTableCell34.StylePriority.UseFont = false;
            this.xrTableCell34.Text = "Automation improves process and allows focus on exception resolution, increasing " +
    "cost effectiveness ratio over Level 1.\r\n";
            this.xrTableCell34.Weight = 1D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell35.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell35.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell35.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell35.Multiline = true;
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.StylePriority.UseBackColor = false;
            this.xrTableCell35.StylePriority.UseBorderColor = false;
            this.xrTableCell35.StylePriority.UseBorders = false;
            this.xrTableCell35.StylePriority.UseFont = false;
            this.xrTableCell35.Text = "SMA adopts Marketplace, MITA Framework, and intrastate standard messages and othe" +
    "r nationally recognized standards further increasing cost effectiveness ratio ov" +
    "er Level 2.\r\n";
            this.xrTableCell35.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell36.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell36.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell36.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell36.Multiline = true;
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.StylePriority.UseBackColor = false;
            this.xrTableCell36.StylePriority.UseBorderColor = false;
            this.xrTableCell36.StylePriority.UseBorders = false;
            this.xrTableCell36.StylePriority.UseFont = false;
            this.xrTableCell36.Text = "SMA adopts Marketplace, MITA Framework, regional standard messages and other nati" +
    "onally recognized standards for disenrollment information exchange increasing co" +
    "st effectiveness ratio over Level 3.\r\n";
            this.xrTableCell36.Weight = 1D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell37.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell37.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell37.Multiline = true;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.StylePriority.UseBackColor = false;
            this.xrTableCell37.StylePriority.UseBorderColor = false;
            this.xrTableCell37.StylePriority.UseBorders = false;
            this.xrTableCell37.StylePriority.UseFont = false;
            this.xrTableCell37.Text = resources.GetString("xrTableCell37.Text");
            this.xrTableCell37.Weight = 1D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.StylePriority.UseBorders = false;
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell66.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell66.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell66.StylePriority.UseBackColor = false;
            this.xrTableCell66.StylePriority.UseBorderColor = false;
            this.xrTableCell66.StylePriority.UseBorders = false;
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.StylePriority.UsePadding = false;
            this.xrTableCell66.StylePriority.UseTextAlignment = false;
            this.xrTableCell66.Text = "How efficient is the process?";
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell66.Weight = 1D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell28.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell28.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseBackColor = false;
            this.xrTableCell28.StylePriority.UseBorderColor = false;
            this.xrTableCell28.StylePriority.UseBorders = false;
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.Text = " Process is labor intensive. There is wasted effort or expense to accomplish task" +
    "s. Process meets minimum state process guidelines and agency performance standar" +
    "ds. Efficiency is low.\r\n";
            this.xrTableCell28.Weight = 1D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell29.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell29.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell29.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseBackColor = false;
            this.xrTableCell29.StylePriority.UseBorderColor = false;
            this.xrTableCell29.StylePriority.UseBorders = false;
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.StylePriority.UseForeColor = false;
            this.xrTableCell29.Text = " Automation and state standards increase productivity. Efficiency is higher than " +
    "Level 1.\r\n";
            this.xrTableCell29.Weight = 1D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell30.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell30.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell30.Multiline = true;
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.StylePriority.UseBackColor = false;
            this.xrTableCell30.StylePriority.UseBorderColor = false;
            this.xrTableCell30.StylePriority.UseBorders = false;
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.Text = "SMA adopts automation of disenrollment process improving efficiency to 90% or hig" +
    "her.\r\n";
            this.xrTableCell30.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell31.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell31.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseBackColor = false;
            this.xrTableCell31.StylePriority.UseBorderColor = false;
            this.xrTableCell31.StylePriority.UseBorders = false;
            this.xrTableCell31.StylePriority.UseFont = false;
            this.xrTableCell31.Text = " SMA adopts shared enrollment services improving efficiency to 95% or higher.\r\n";
            this.xrTableCell31.Weight = 1D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell32.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell32.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell32.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell32.Multiline = true;
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseBackColor = false;
            this.xrTableCell32.StylePriority.UseBorderColor = false;
            this.xrTableCell32.StylePriority.UseBorders = false;
            this.xrTableCell32.StylePriority.UseFont = false;
            this.xrTableCell32.Text = "SMA uses shared enrollment services improving efficiency to 98% or higher.\r\n";
            this.xrTableCell32.Weight = 1D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseBorders = false;
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell67.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell67.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell67.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell67.StylePriority.UseBackColor = false;
            this.xrTableCell67.StylePriority.UseBorderColor = false;
            this.xrTableCell67.StylePriority.UseBorders = false;
            this.xrTableCell67.StylePriority.UseFont = false;
            this.xrTableCell67.StylePriority.UsePadding = false;
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.Text = "How accurate are the results of the process?";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell67.Weight = 1D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell23.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBackColor = false;
            this.xrTableCell23.StylePriority.UseBorderColor = false;
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.Text = "Manual processes results in greater opportunity for human error. Accuracy is low." +
    "\r\n";
            this.xrTableCell23.Weight = 1D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell24.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.StylePriority.UseBorderColor = false;
            this.xrTableCell24.StylePriority.UseBorders = false;
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.Text = " Automation and business rules reduce error and improve accuracy above Level 1.\r\n" +
    "";
            this.xrTableCell24.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell25.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBackColor = false;
            this.xrTableCell25.StylePriority.UseBorderColor = false;
            this.xrTableCell25.StylePriority.UseBorders = false;
            this.xrTableCell25.StylePriority.UseFont = false;
            this.xrTableCell25.Text = "SMA adopts standard messages for interacting with other state agencies and entiti" +
    "es, improving accuracy to 90% or higher.\r\n";
            this.xrTableCell25.Weight = 1D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell26.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBackColor = false;
            this.xrTableCell26.StylePriority.UseBorderColor = false;
            this.xrTableCell26.StylePriority.UseBorders = false;
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.Text = " SMA adopts standard messages for interacting with agencies and entities across s" +
    "ome states improving accuracy to 98% or higher.\r\n";
            this.xrTableCell26.Weight = 1D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell27.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell27.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell27.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseBackColor = false;
            this.xrTableCell27.StylePriority.UseBorderColor = false;
            this.xrTableCell27.StylePriority.UseBorders = false;
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.StylePriority.UseForeColor = false;
            this.xrTableCell27.Text = " SMA adopts standard messages for interacting with agencies and entities across a" +
    "ll states improving accuracy to 98% or higher.\r\n";
            this.xrTableCell27.Weight = 1D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell68,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell68.BorderColor = System.Drawing.Color.DarkGray;
            this.xrTableCell68.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell68.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell68.StylePriority.UseBackColor = false;
            this.xrTableCell68.StylePriority.UseBorderColor = false;
            this.xrTableCell68.StylePriority.UseBorders = false;
            this.xrTableCell68.StylePriority.UseFont = false;
            this.xrTableCell68.StylePriority.UsePadding = false;
            this.xrTableCell68.StylePriority.UseTextAlignment = false;
            this.xrTableCell68.Text = "Does the business process satisfy stakeholders?";
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell68.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell13.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.StylePriority.UseBorderColor = false;
            this.xrTableCell13.StylePriority.UseBorders = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.Text = "Stakeholders lack confidence in information negatively affecting stakeholder sati" +
    "sfaction with the process.\r\n";
            this.xrTableCell13.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell14.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBackColor = false;
            this.xrTableCell14.StylePriority.UseBorderColor = false;
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.Text = "Automation and standardization provides clear and useful information. Stakeholder" +
    " satisfaction is greater than Level 1.\r\n";
            this.xrTableCell14.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BackColor = System.Drawing.Color.Gold;
            this.xrTableCell15.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.StylePriority.UseBorderColor = false;
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Text = "SMA adopts standard messages for interacting with other state agencies and entiti" +
    "es, improving stakeholder satisfaction to 90% or higher.\r\n";
            this.xrTableCell15.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell16.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.StylePriority.UseBorderColor = false;
            this.xrTableCell16.StylePriority.UseBorders = false;
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.Text = "SMA adopts standard messages for interacting with agencies and entities across so" +
    "me states, improving stakeholder satisfaction to 95% or higher.\r\n";
            this.xrTableCell16.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BackColor = System.Drawing.Color.MintCream;
            this.xrTableCell17.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.xrTableCell17.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.StylePriority.UseBorderColor = false;
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseForeColor = false;
            this.xrTableCell17.Text = "SMA adopts standard messages for interacting with agencies and entities across al" +
    "l states, improving stakeholder satisfaction to 98% or higher.\r\n";
            this.xrTableCell17.Weight = 1D;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrLabel6.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(17.83316F, 412.7956F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(141.9104F, 40.03378F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "BP UNIQ ID";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(314.5251F, 412.7956F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(567.6417F, 40.03378F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "BP TITLE Field";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(41.58319F, 10.00001F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable4.SizeF = new System.Drawing.SizeF(858.4168F, 45.91733F);
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.BackColor = System.Drawing.Color.Transparent;
            this.xrTableCell69.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.StylePriority.UseBackColor = false;
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.Text = " ";
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell69.Weight = 1D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell70.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell70.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseBackColor = false;
            this.xrTableCell70.StylePriority.UseBorders = false;
            this.xrTableCell70.StylePriority.UseFont = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.Text = "Level 1";
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell70.Weight = 1D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell71.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell71.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.StylePriority.UseBackColor = false;
            this.xrTableCell71.StylePriority.UseBorders = false;
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.Text = "Level 2";
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell71.Weight = 1D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell72.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell72.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.StylePriority.UseBackColor = false;
            this.xrTableCell72.StylePriority.UseBorders = false;
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.Text = "Level 3";
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell72.Weight = 1D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell73.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell73.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseBackColor = false;
            this.xrTableCell73.StylePriority.UseBorders = false;
            this.xrTableCell73.StylePriority.UseFont = false;
            this.xrTableCell73.StylePriority.UseTextAlignment = false;
            this.xrTableCell73.Text = "Level 4";
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell73.Weight = 1D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.BackColor = System.Drawing.Color.LemonChiffon;
            this.xrTableCell74.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell74.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.StylePriority.UseBackColor = false;
            this.xrTableCell74.StylePriority.UseBorders = false;
            this.xrTableCell74.StylePriority.UseFont = false;
            this.xrTableCell74.StylePriority.UseTextAlignment = false;
            this.xrTableCell74.Text = "Level 5";
            this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell74.Weight = 1D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel4,
            this.xrLabel22,
            this.xrLabel1,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel26,
            this.xrTable6,
            this.spacer,
            this.xrLabel2,
            this.xrLabel9,
            this.xrLabel19,
            this.xrLabel23,
            this.xrTable7,
            this.xrLabel24,
            this.xrLabel27,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel15,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel10,
            this.xrTable5});
            this.TopMargin.HeightF = 1537.479F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(74.5F, 175.5208F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow38,
            this.xrTableRow39,
            this.xrTableRow40,
            this.xrTableRow41,
            this.xrTableRow42,
            this.xrTableRow43,
            this.xrTableRow44,
            this.xrTableRow45,
            this.xrTableRow46,
            this.xrTableRow47,
            this.xrTableRow48,
            this.xrTableRow49,
            this.xrTableRow50,
            this.xrTableRow51,
            this.xrTableRow52,
            this.xrTableRow53,
            this.xrTableRow54,
            this.xrTableRow55,
            this.xrTableRow56});
            this.xrTable5.SizeF = new System.Drawing.SizeF(799F, 475F);
            this.xrTable5.StylePriority.UseBorders = false;
            // 
            // xrTableRow38
            // 
            this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell145,
            this.xrTableCell146,
            this.xrTableCell147});
            this.xrTableRow38.Name = "xrTableRow38";
            this.xrTableRow38.Weight = 1D;
            // 
            // xrTableCell145
            // 
            this.xrTableCell145.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell145.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell145.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell145.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell145.Name = "xrTableCell145";
            this.xrTableCell145.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell145.StylePriority.UseBackColor = false;
            this.xrTableCell145.StylePriority.UseBorders = false;
            this.xrTableCell145.StylePriority.UseFont = false;
            this.xrTableCell145.StylePriority.UseForeColor = false;
            this.xrTableCell145.StylePriority.UsePadding = false;
            this.xrTableCell145.StylePriority.UseTextAlignment = false;
            this.xrTableCell145.Text = "Timeliness of Process";
            this.xrTableCell145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell145.Weight = 2.3010415641518955D;
            // 
            // xrTableCell146
            // 
            this.xrTableCell146.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell146.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell146.Name = "xrTableCell146";
            this.xrTableCell146.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell146.StylePriority.UseBorders = false;
            this.xrTableCell146.StylePriority.UseFont = false;
            this.xrTableCell146.StylePriority.UsePadding = false;
            this.xrTableCell146.Text = "BP As-Is > Timeliness > \"Level 1\", etc. ";
            this.xrTableCell146.Weight = 2.834791565158425D;
            // 
            // xrTableCell147
            // 
            this.xrTableCell147.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell147.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell147.Name = "xrTableCell147";
            this.xrTableCell147.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell147.StylePriority.UseBorders = false;
            this.xrTableCell147.StylePriority.UseFont = false;
            this.xrTableCell147.StylePriority.UsePadding = false;
            this.xrTableCell147.Text = "BP To-Be > Timliness > \"Level 1\", etc.";
            this.xrTableCell147.Weight = 2.8541665644157392D;
            // 
            // xrTableRow39
            // 
            this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell148,
            this.xrTableCell149,
            this.xrTableCell150});
            this.xrTableRow39.Name = "xrTableRow39";
            this.xrTableRow39.Weight = 1D;
            // 
            // xrTableCell148
            // 
            this.xrTableCell148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell148.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell148.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell148.Name = "xrTableCell148";
            this.xrTableCell148.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell148.StylePriority.UseBackColor = false;
            this.xrTableCell148.StylePriority.UseBorders = false;
            this.xrTableCell148.StylePriority.UseFont = false;
            this.xrTableCell148.StylePriority.UsePadding = false;
            this.xrTableCell148.StylePriority.UseTextAlignment = false;
            this.xrTableCell148.Text = "Performance Measure";
            this.xrTableCell148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell148.Weight = 2.3010415641518955D;
            // 
            // xrTableCell149
            // 
            this.xrTableCell149.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell149.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.xrTableCell149.Name = "xrTableCell149";
            this.xrTableCell149.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell149.StylePriority.UseBorders = false;
            this.xrTableCell149.StylePriority.UseFont = false;
            this.xrTableCell149.StylePriority.UsePadding = false;
            this.xrTableCell149.Text = "BP As-Is > Timeliness > Performance Measure";
            this.xrTableCell149.Weight = 2.834791565158425D;
            // 
            // xrTableCell150
            // 
            this.xrTableCell150.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell150.Name = "xrTableCell150";
            this.xrTableCell150.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell150.StylePriority.UseBorders = false;
            this.xrTableCell150.StylePriority.UsePadding = false;
            this.xrTableCell150.Text = "BP As-Is > Timeliness > Performance Measure";
            this.xrTableCell150.Weight = 2.8541665644157392D;
            // 
            // xrTableRow40
            // 
            this.xrTableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell151,
            this.xrTableCell152,
            this.xrTableCell153});
            this.xrTableRow40.Name = "xrTableRow40";
            this.xrTableRow40.Weight = 1D;
            // 
            // xrTableCell151
            // 
            this.xrTableCell151.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell151.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell151.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell151.Name = "xrTableCell151";
            this.xrTableCell151.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell151.StylePriority.UseBackColor = false;
            this.xrTableCell151.StylePriority.UseBorders = false;
            this.xrTableCell151.StylePriority.UseFont = false;
            this.xrTableCell151.StylePriority.UsePadding = false;
            this.xrTableCell151.StylePriority.UseTextAlignment = false;
            this.xrTableCell151.Text = "Supporting Evidence Reference";
            this.xrTableCell151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell151.Weight = 2.3010415641518955D;
            // 
            // xrTableCell152
            // 
            this.xrTableCell152.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell152.Name = "xrTableCell152";
            this.xrTableCell152.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell152.StylePriority.UseBorders = false;
            this.xrTableCell152.StylePriority.UsePadding = false;
            this.xrTableCell152.Text = "REPOSITORY >Timeliness> What\'s attached?";
            this.xrTableCell152.Weight = 2.834791565158425D;
            // 
            // xrTableCell153
            // 
            this.xrTableCell153.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell153.Name = "xrTableCell153";
            this.xrTableCell153.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell153.StylePriority.UseBorders = false;
            this.xrTableCell153.StylePriority.UsePadding = false;
            this.xrTableCell153.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell153.Weight = 2.8541665644157392D;
            // 
            // xrTableRow41
            // 
            this.xrTableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell154,
            this.xrTableCell155,
            this.xrTableCell156});
            this.xrTableRow41.Name = "xrTableRow41";
            this.xrTableRow41.Weight = 1D;
            // 
            // xrTableCell154
            // 
            this.xrTableCell154.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell154.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell154.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell154.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell154.Name = "xrTableCell154";
            this.xrTableCell154.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell154.StylePriority.UseBackColor = false;
            this.xrTableCell154.StylePriority.UseBorders = false;
            this.xrTableCell154.StylePriority.UseFont = false;
            this.xrTableCell154.StylePriority.UseForeColor = false;
            this.xrTableCell154.StylePriority.UsePadding = false;
            this.xrTableCell154.StylePriority.UseTextAlignment = false;
            this.xrTableCell154.Text = "Data Access and Accuracy";
            this.xrTableCell154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell154.Weight = 2.3010415641518955D;
            // 
            // xrTableCell155
            // 
            this.xrTableCell155.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell155.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell155.Name = "xrTableCell155";
            this.xrTableCell155.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell155.StylePriority.UseBorders = false;
            this.xrTableCell155.StylePriority.UseFont = false;
            this.xrTableCell155.StylePriority.UsePadding = false;
            this.xrTableCell155.Text = "BP As-Is > Data Access > \"Level 1\", etc.";
            this.xrTableCell155.Weight = 2.834791565158425D;
            // 
            // xrTableCell156
            // 
            this.xrTableCell156.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell156.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell156.Name = "xrTableCell156";
            this.xrTableCell156.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell156.StylePriority.UseBorders = false;
            this.xrTableCell156.StylePriority.UseFont = false;
            this.xrTableCell156.StylePriority.UsePadding = false;
            this.xrTableCell156.Text = "BP To-Be > Data Access > \"Level 1\", etc.";
            this.xrTableCell156.Weight = 2.8541665644157392D;
            // 
            // xrTableRow42
            // 
            this.xrTableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell157,
            this.xrTableCell158,
            this.xrTableCell159});
            this.xrTableRow42.Name = "xrTableRow42";
            this.xrTableRow42.Weight = 1D;
            // 
            // xrTableCell157
            // 
            this.xrTableCell157.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell157.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell157.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell157.Name = "xrTableCell157";
            this.xrTableCell157.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell157.StylePriority.UseBackColor = false;
            this.xrTableCell157.StylePriority.UseBorders = false;
            this.xrTableCell157.StylePriority.UseFont = false;
            this.xrTableCell157.StylePriority.UsePadding = false;
            this.xrTableCell157.StylePriority.UseTextAlignment = false;
            this.xrTableCell157.Text = "Performance Measure";
            this.xrTableCell157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell157.Weight = 2.3010415641518955D;
            // 
            // xrTableCell158
            // 
            this.xrTableCell158.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell158.Name = "xrTableCell158";
            this.xrTableCell158.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell158.StylePriority.UseBorders = false;
            this.xrTableCell158.StylePriority.UsePadding = false;
            this.xrTableCell158.Text = "BP As-Is > Data Access > Perf. Measure";
            this.xrTableCell158.Weight = 2.834791565158425D;
            // 
            // xrTableCell159
            // 
            this.xrTableCell159.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell159.Name = "xrTableCell159";
            this.xrTableCell159.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell159.StylePriority.UseBorders = false;
            this.xrTableCell159.StylePriority.UsePadding = false;
            this.xrTableCell159.Text = "BP As-Is > Data Access > Perf. Measure";
            this.xrTableCell159.Weight = 2.8541665644157392D;
            // 
            // xrTableRow43
            // 
            this.xrTableRow43.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell160,
            this.xrTableCell161,
            this.xrTableCell162});
            this.xrTableRow43.Name = "xrTableRow43";
            this.xrTableRow43.Weight = 1D;
            // 
            // xrTableCell160
            // 
            this.xrTableCell160.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell160.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell160.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell160.Name = "xrTableCell160";
            this.xrTableCell160.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell160.StylePriority.UseBackColor = false;
            this.xrTableCell160.StylePriority.UseBorders = false;
            this.xrTableCell160.StylePriority.UseFont = false;
            this.xrTableCell160.StylePriority.UsePadding = false;
            this.xrTableCell160.StylePriority.UseTextAlignment = false;
            this.xrTableCell160.Text = "Supporting Evidence Reference";
            this.xrTableCell160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell160.Weight = 2.3010415641518955D;
            // 
            // xrTableCell161
            // 
            this.xrTableCell161.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell161.Name = "xrTableCell161";
            this.xrTableCell161.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell161.StylePriority.UseBorders = false;
            this.xrTableCell161.StylePriority.UsePadding = false;
            this.xrTableCell161.Text = "REPOSITORY>Data Access> What\'s attached?";
            this.xrTableCell161.Weight = 2.834791565158425D;
            // 
            // xrTableCell162
            // 
            this.xrTableCell162.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell162.Name = "xrTableCell162";
            this.xrTableCell162.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell162.StylePriority.UseBorders = false;
            this.xrTableCell162.StylePriority.UsePadding = false;
            this.xrTableCell162.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell162.Weight = 2.8541665644157392D;
            // 
            // xrTableRow44
            // 
            this.xrTableRow44.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell163,
            this.xrTableCell164,
            this.xrTableCell165});
            this.xrTableRow44.Name = "xrTableRow44";
            this.xrTableRow44.Weight = 1D;
            // 
            // xrTableCell163
            // 
            this.xrTableCell163.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell163.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell163.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell163.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell163.Name = "xrTableCell163";
            this.xrTableCell163.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell163.StylePriority.UseBackColor = false;
            this.xrTableCell163.StylePriority.UseBorders = false;
            this.xrTableCell163.StylePriority.UseFont = false;
            this.xrTableCell163.StylePriority.UseForeColor = false;
            this.xrTableCell163.StylePriority.UsePadding = false;
            this.xrTableCell163.StylePriority.UseTextAlignment = false;
            this.xrTableCell163.Text = "Cost-Effectiveness";
            this.xrTableCell163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell163.Weight = 2.3010415641518955D;
            // 
            // xrTableCell164
            // 
            this.xrTableCell164.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell164.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell164.Name = "xrTableCell164";
            this.xrTableCell164.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell164.StylePriority.UseBorders = false;
            this.xrTableCell164.StylePriority.UseFont = false;
            this.xrTableCell164.StylePriority.UsePadding = false;
            this.xrTableCell164.Text = "BP As-Is > Cost-eff > \"Level 1\", etc.";
            this.xrTableCell164.Weight = 2.834791565158425D;
            // 
            // xrTableCell165
            // 
            this.xrTableCell165.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell165.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell165.Name = "xrTableCell165";
            this.xrTableCell165.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell165.StylePriority.UseBorders = false;
            this.xrTableCell165.StylePriority.UseFont = false;
            this.xrTableCell165.StylePriority.UsePadding = false;
            this.xrTableCell165.Text = "BP To-Be > Cost-Eff > \"Level 1\", etc.";
            this.xrTableCell165.Weight = 2.8541665644157392D;
            // 
            // xrTableRow45
            // 
            this.xrTableRow45.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell166,
            this.xrTableCell167,
            this.xrTableCell168});
            this.xrTableRow45.Name = "xrTableRow45";
            this.xrTableRow45.Weight = 1D;
            // 
            // xrTableCell166
            // 
            this.xrTableCell166.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell166.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell166.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell166.Name = "xrTableCell166";
            this.xrTableCell166.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell166.StylePriority.UseBackColor = false;
            this.xrTableCell166.StylePriority.UseBorders = false;
            this.xrTableCell166.StylePriority.UseFont = false;
            this.xrTableCell166.StylePriority.UsePadding = false;
            this.xrTableCell166.StylePriority.UseTextAlignment = false;
            this.xrTableCell166.Text = "Performance Measure";
            this.xrTableCell166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell166.Weight = 2.3010415641518955D;
            // 
            // xrTableCell167
            // 
            this.xrTableCell167.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell167.Name = "xrTableCell167";
            this.xrTableCell167.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell167.StylePriority.UseBorders = false;
            this.xrTableCell167.StylePriority.UsePadding = false;
            this.xrTableCell167.Text = "BP As-Is > Cost-eff > Performance Measure";
            this.xrTableCell167.Weight = 2.834791565158425D;
            // 
            // xrTableCell168
            // 
            this.xrTableCell168.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell168.Name = "xrTableCell168";
            this.xrTableCell168.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell168.StylePriority.UseBorders = false;
            this.xrTableCell168.StylePriority.UsePadding = false;
            this.xrTableCell168.Text = "BP As-Is > Cost-eff > Performance Measure";
            this.xrTableCell168.Weight = 2.8541665644157392D;
            // 
            // xrTableRow46
            // 
            this.xrTableRow46.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell169,
            this.xrTableCell170,
            this.xrTableCell171});
            this.xrTableRow46.Name = "xrTableRow46";
            this.xrTableRow46.Weight = 1D;
            // 
            // xrTableCell169
            // 
            this.xrTableCell169.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell169.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell169.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell169.Name = "xrTableCell169";
            this.xrTableCell169.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell169.StylePriority.UseBackColor = false;
            this.xrTableCell169.StylePriority.UseBorders = false;
            this.xrTableCell169.StylePriority.UseFont = false;
            this.xrTableCell169.StylePriority.UsePadding = false;
            this.xrTableCell169.StylePriority.UseTextAlignment = false;
            this.xrTableCell169.Text = "Supporting Evidence Reference";
            this.xrTableCell169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell169.Weight = 2.3010415641518955D;
            // 
            // xrTableCell170
            // 
            this.xrTableCell170.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell170.Name = "xrTableCell170";
            this.xrTableCell170.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell170.StylePriority.UseBorders = false;
            this.xrTableCell170.StylePriority.UsePadding = false;
            this.xrTableCell170.Text = "REPOSITORY >Cost-eff> What\'s attached?";
            this.xrTableCell170.Weight = 2.834791565158425D;
            // 
            // xrTableCell171
            // 
            this.xrTableCell171.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell171.Name = "xrTableCell171";
            this.xrTableCell171.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell171.StylePriority.UseBorders = false;
            this.xrTableCell171.StylePriority.UsePadding = false;
            this.xrTableCell171.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell171.Weight = 2.8541665644157392D;
            // 
            // xrTableRow47
            // 
            this.xrTableRow47.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell172,
            this.xrTableCell173,
            this.xrTableCell174});
            this.xrTableRow47.Name = "xrTableRow47";
            this.xrTableRow47.Weight = 1D;
            // 
            // xrTableCell172
            // 
            this.xrTableCell172.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell172.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell172.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell172.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell172.Name = "xrTableCell172";
            this.xrTableCell172.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell172.StylePriority.UseBackColor = false;
            this.xrTableCell172.StylePriority.UseBorders = false;
            this.xrTableCell172.StylePriority.UseFont = false;
            this.xrTableCell172.StylePriority.UseForeColor = false;
            this.xrTableCell172.StylePriority.UsePadding = false;
            this.xrTableCell172.StylePriority.UseTextAlignment = false;
            this.xrTableCell172.Text = "Effort to Perform; Efficiency";
            this.xrTableCell172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell172.Weight = 2.3010415641518955D;
            // 
            // xrTableCell173
            // 
            this.xrTableCell173.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell173.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell173.Name = "xrTableCell173";
            this.xrTableCell173.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell173.StylePriority.UseBorders = false;
            this.xrTableCell173.StylePriority.UseFont = false;
            this.xrTableCell173.StylePriority.UsePadding = false;
            this.xrTableCell173.Text = "BP As-Is > Effort > \"Level 1\", etc.";
            this.xrTableCell173.Weight = 2.834791565158425D;
            // 
            // xrTableCell174
            // 
            this.xrTableCell174.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell174.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell174.Name = "xrTableCell174";
            this.xrTableCell174.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell174.StylePriority.UseBorders = false;
            this.xrTableCell174.StylePriority.UseFont = false;
            this.xrTableCell174.StylePriority.UsePadding = false;
            this.xrTableCell174.Text = "BP To-Be > Effort > \"Level 1\", etc.";
            this.xrTableCell174.Weight = 2.8541665644157392D;
            // 
            // xrTableRow48
            // 
            this.xrTableRow48.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell175,
            this.xrTableCell176,
            this.xrTableCell177});
            this.xrTableRow48.Name = "xrTableRow48";
            this.xrTableRow48.Weight = 1D;
            // 
            // xrTableCell175
            // 
            this.xrTableCell175.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell175.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell175.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell175.Name = "xrTableCell175";
            this.xrTableCell175.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell175.StylePriority.UseBackColor = false;
            this.xrTableCell175.StylePriority.UseBorders = false;
            this.xrTableCell175.StylePriority.UseFont = false;
            this.xrTableCell175.StylePriority.UsePadding = false;
            this.xrTableCell175.StylePriority.UseTextAlignment = false;
            this.xrTableCell175.Text = "Performance Measure";
            this.xrTableCell175.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell175.Weight = 2.3010415641518955D;
            // 
            // xrTableCell176
            // 
            this.xrTableCell176.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell176.Name = "xrTableCell176";
            this.xrTableCell176.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell176.StylePriority.UseBorders = false;
            this.xrTableCell176.StylePriority.UsePadding = false;
            this.xrTableCell176.Text = "BP As-Is > Effort > Performance Measure";
            this.xrTableCell176.Weight = 2.834791565158425D;
            // 
            // xrTableCell177
            // 
            this.xrTableCell177.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell177.Name = "xrTableCell177";
            this.xrTableCell177.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell177.StylePriority.UseBorders = false;
            this.xrTableCell177.StylePriority.UsePadding = false;
            this.xrTableCell177.Text = "BP As-Is > Effort > Performance Measure";
            this.xrTableCell177.Weight = 2.8541665644157392D;
            // 
            // xrTableRow49
            // 
            this.xrTableRow49.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell178,
            this.xrTableCell179,
            this.xrTableCell180});
            this.xrTableRow49.Name = "xrTableRow49";
            this.xrTableRow49.Weight = 1D;
            // 
            // xrTableCell178
            // 
            this.xrTableCell178.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell178.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell178.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell178.Name = "xrTableCell178";
            this.xrTableCell178.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell178.StylePriority.UseBackColor = false;
            this.xrTableCell178.StylePriority.UseBorders = false;
            this.xrTableCell178.StylePriority.UseFont = false;
            this.xrTableCell178.StylePriority.UsePadding = false;
            this.xrTableCell178.StylePriority.UseTextAlignment = false;
            this.xrTableCell178.Text = "Supporting Evidence Reference";
            this.xrTableCell178.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell178.Weight = 2.3010415641518955D;
            // 
            // xrTableCell179
            // 
            this.xrTableCell179.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell179.Name = "xrTableCell179";
            this.xrTableCell179.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell179.StylePriority.UseBorders = false;
            this.xrTableCell179.StylePriority.UsePadding = false;
            this.xrTableCell179.Text = "REPOSITORY >Effort> What\'s attached?";
            this.xrTableCell179.Weight = 2.834791565158425D;
            // 
            // xrTableCell180
            // 
            this.xrTableCell180.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell180.Name = "xrTableCell180";
            this.xrTableCell180.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell180.StylePriority.UseBorders = false;
            this.xrTableCell180.StylePriority.UsePadding = false;
            this.xrTableCell180.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell180.Weight = 2.8541665644157392D;
            // 
            // xrTableRow50
            // 
            this.xrTableRow50.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell181,
            this.xrTableCell182,
            this.xrTableCell183});
            this.xrTableRow50.Name = "xrTableRow50";
            this.xrTableRow50.Weight = 1D;
            // 
            // xrTableCell181
            // 
            this.xrTableCell181.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell181.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell181.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell181.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell181.Name = "xrTableCell181";
            this.xrTableCell181.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell181.StylePriority.UseBackColor = false;
            this.xrTableCell181.StylePriority.UseBorders = false;
            this.xrTableCell181.StylePriority.UseFont = false;
            this.xrTableCell181.StylePriority.UseForeColor = false;
            this.xrTableCell181.StylePriority.UsePadding = false;
            this.xrTableCell181.StylePriority.UseTextAlignment = false;
            this.xrTableCell181.Text = "Accuracy of Process Results";
            this.xrTableCell181.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell181.Weight = 2.3010415641518955D;
            // 
            // xrTableCell182
            // 
            this.xrTableCell182.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell182.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell182.Name = "xrTableCell182";
            this.xrTableCell182.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell182.StylePriority.UseBorders = false;
            this.xrTableCell182.StylePriority.UseFont = false;
            this.xrTableCell182.StylePriority.UsePadding = false;
            this.xrTableCell182.Text = "BP As-Is > Accuracy > \"Level 1\", etc.";
            this.xrTableCell182.Weight = 2.834791565158425D;
            // 
            // xrTableCell183
            // 
            this.xrTableCell183.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell183.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell183.Name = "xrTableCell183";
            this.xrTableCell183.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell183.StylePriority.UseBorders = false;
            this.xrTableCell183.StylePriority.UseFont = false;
            this.xrTableCell183.StylePriority.UsePadding = false;
            this.xrTableCell183.Text = "BP To-Be > Accuracy > \"Level 1\", etc.";
            this.xrTableCell183.Weight = 2.8541665644157392D;
            // 
            // xrTableRow51
            // 
            this.xrTableRow51.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell184,
            this.xrTableCell185,
            this.xrTableCell186});
            this.xrTableRow51.Name = "xrTableRow51";
            this.xrTableRow51.Weight = 1D;
            // 
            // xrTableCell184
            // 
            this.xrTableCell184.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell184.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell184.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell184.Name = "xrTableCell184";
            this.xrTableCell184.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell184.StylePriority.UseBackColor = false;
            this.xrTableCell184.StylePriority.UseBorders = false;
            this.xrTableCell184.StylePriority.UseFont = false;
            this.xrTableCell184.StylePriority.UsePadding = false;
            this.xrTableCell184.StylePriority.UseTextAlignment = false;
            this.xrTableCell184.Text = "Performance Measure";
            this.xrTableCell184.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell184.Weight = 2.3010415641518955D;
            // 
            // xrTableCell185
            // 
            this.xrTableCell185.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell185.Name = "xrTableCell185";
            this.xrTableCell185.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell185.StylePriority.UseBorders = false;
            this.xrTableCell185.StylePriority.UsePadding = false;
            this.xrTableCell185.Text = "BP As-Is > Accuracy > Performance Measure";
            this.xrTableCell185.Weight = 2.834791565158425D;
            // 
            // xrTableCell186
            // 
            this.xrTableCell186.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell186.Name = "xrTableCell186";
            this.xrTableCell186.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell186.StylePriority.UseBorders = false;
            this.xrTableCell186.StylePriority.UsePadding = false;
            this.xrTableCell186.Text = "BP As-Is > Accuracy > Performance Measure";
            this.xrTableCell186.Weight = 2.8541665644157392D;
            // 
            // xrTableRow52
            // 
            this.xrTableRow52.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell187,
            this.xrTableCell188,
            this.xrTableCell189});
            this.xrTableRow52.Name = "xrTableRow52";
            this.xrTableRow52.Weight = 1D;
            // 
            // xrTableCell187
            // 
            this.xrTableCell187.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell187.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell187.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell187.Name = "xrTableCell187";
            this.xrTableCell187.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell187.StylePriority.UseBackColor = false;
            this.xrTableCell187.StylePriority.UseBorders = false;
            this.xrTableCell187.StylePriority.UseFont = false;
            this.xrTableCell187.StylePriority.UsePadding = false;
            this.xrTableCell187.StylePriority.UseTextAlignment = false;
            this.xrTableCell187.Text = "Supporting Evidence Reference";
            this.xrTableCell187.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell187.Weight = 2.3010415641518955D;
            // 
            // xrTableCell188
            // 
            this.xrTableCell188.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell188.Name = "xrTableCell188";
            this.xrTableCell188.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell188.StylePriority.UseBorders = false;
            this.xrTableCell188.StylePriority.UsePadding = false;
            this.xrTableCell188.Text = "REPOSITORY >Accuracy> What\'s attached?";
            this.xrTableCell188.Weight = 2.834791565158425D;
            // 
            // xrTableCell189
            // 
            this.xrTableCell189.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell189.Name = "xrTableCell189";
            this.xrTableCell189.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell189.StylePriority.UseBorders = false;
            this.xrTableCell189.StylePriority.UsePadding = false;
            this.xrTableCell189.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell189.Weight = 2.8541665644157392D;
            // 
            // xrTableRow53
            // 
            this.xrTableRow53.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell190,
            this.xrTableCell191,
            this.xrTableCell192});
            this.xrTableRow53.Name = "xrTableRow53";
            this.xrTableRow53.Weight = 1D;
            // 
            // xrTableCell190
            // 
            this.xrTableCell190.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell190.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell190.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell190.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell190.Name = "xrTableCell190";
            this.xrTableCell190.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell190.StylePriority.UseBackColor = false;
            this.xrTableCell190.StylePriority.UseBorders = false;
            this.xrTableCell190.StylePriority.UseFont = false;
            this.xrTableCell190.StylePriority.UseForeColor = false;
            this.xrTableCell190.StylePriority.UsePadding = false;
            this.xrTableCell190.StylePriority.UseTextAlignment = false;
            this.xrTableCell190.Text = "Utility or Value to Stakeholder";
            this.xrTableCell190.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell190.Weight = 2.3010415641518955D;
            // 
            // xrTableCell191
            // 
            this.xrTableCell191.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell191.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell191.Name = "xrTableCell191";
            this.xrTableCell191.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell191.StylePriority.UseBorders = false;
            this.xrTableCell191.StylePriority.UseFont = false;
            this.xrTableCell191.StylePriority.UsePadding = false;
            this.xrTableCell191.Text = "BP As-Is > Utility > \"Level 1\", etc.";
            this.xrTableCell191.Weight = 2.834791565158425D;
            // 
            // xrTableCell192
            // 
            this.xrTableCell192.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell192.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell192.Name = "xrTableCell192";
            this.xrTableCell192.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell192.StylePriority.UseBorders = false;
            this.xrTableCell192.StylePriority.UseFont = false;
            this.xrTableCell192.StylePriority.UsePadding = false;
            this.xrTableCell192.Text = "BP To-Be > Utility > \"Level 1\", etc.";
            this.xrTableCell192.Weight = 2.8541665644157392D;
            // 
            // xrTableRow54
            // 
            this.xrTableRow54.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell193,
            this.xrTableCell194,
            this.xrTableCell195});
            this.xrTableRow54.Name = "xrTableRow54";
            this.xrTableRow54.Weight = 1D;
            // 
            // xrTableCell193
            // 
            this.xrTableCell193.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell193.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell193.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell193.Name = "xrTableCell193";
            this.xrTableCell193.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell193.StylePriority.UseBackColor = false;
            this.xrTableCell193.StylePriority.UseBorders = false;
            this.xrTableCell193.StylePriority.UseFont = false;
            this.xrTableCell193.StylePriority.UsePadding = false;
            this.xrTableCell193.StylePriority.UseTextAlignment = false;
            this.xrTableCell193.Text = "Performance Measure";
            this.xrTableCell193.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell193.Weight = 2.3010415641518955D;
            // 
            // xrTableCell194
            // 
            this.xrTableCell194.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell194.Name = "xrTableCell194";
            this.xrTableCell194.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell194.StylePriority.UseBorders = false;
            this.xrTableCell194.StylePriority.UsePadding = false;
            this.xrTableCell194.Text = "BP As-Is > Utility > Performance Measure";
            this.xrTableCell194.Weight = 2.834791565158425D;
            // 
            // xrTableCell195
            // 
            this.xrTableCell195.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell195.Name = "xrTableCell195";
            this.xrTableCell195.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell195.StylePriority.UseBorders = false;
            this.xrTableCell195.StylePriority.UsePadding = false;
            this.xrTableCell195.Text = "BP As-Is > Utility > Performance Measure";
            this.xrTableCell195.Weight = 2.8541665644157392D;
            // 
            // xrTableRow55
            // 
            this.xrTableRow55.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell196,
            this.xrTableCell197,
            this.xrTableCell198});
            this.xrTableRow55.Name = "xrTableRow55";
            this.xrTableRow55.Weight = 1D;
            // 
            // xrTableCell196
            // 
            this.xrTableCell196.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell196.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell196.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell196.Name = "xrTableCell196";
            this.xrTableCell196.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell196.StylePriority.UseBackColor = false;
            this.xrTableCell196.StylePriority.UseBorders = false;
            this.xrTableCell196.StylePriority.UseFont = false;
            this.xrTableCell196.StylePriority.UsePadding = false;
            this.xrTableCell196.StylePriority.UseTextAlignment = false;
            this.xrTableCell196.Text = "Supporting Evidence Reference";
            this.xrTableCell196.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell196.Weight = 2.3010415641518955D;
            // 
            // xrTableCell197
            // 
            this.xrTableCell197.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell197.Name = "xrTableCell197";
            this.xrTableCell197.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell197.StylePriority.UseBorders = false;
            this.xrTableCell197.StylePriority.UsePadding = false;
            this.xrTableCell197.Text = "REPOSITORY >Utility> What\'s attached?";
            this.xrTableCell197.Weight = 2.834791565158425D;
            // 
            // xrTableCell198
            // 
            this.xrTableCell198.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell198.Name = "xrTableCell198";
            this.xrTableCell198.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell198.StylePriority.UseBorders = false;
            this.xrTableCell198.StylePriority.UsePadding = false;
            this.xrTableCell198.Text = "REPOSITORY > What\'s attached?";
            this.xrTableCell198.Weight = 2.8541665644157392D;
            // 
            // xrTableRow56
            // 
            this.xrTableRow56.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell199,
            this.xrTableCell200,
            this.xrTableCell201});
            this.xrTableRow56.Name = "xrTableRow56";
            this.xrTableRow56.Weight = 1D;
            // 
            // xrTableCell199
            // 
            this.xrTableCell199.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell199.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell199.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[stan_standard]")});
            this.xrTableCell199.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell199.Name = "xrTableCell199";
            this.xrTableCell199.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell199.StylePriority.UseBackColor = false;
            this.xrTableCell199.StylePriority.UseBorders = false;
            this.xrTableCell199.StylePriority.UseFont = false;
            this.xrTableCell199.StylePriority.UsePadding = false;
            this.xrTableCell199.StylePriority.UseTextAlignment = false;
            this.xrTableCell199.Text = "xrTableCell55";
            this.xrTableCell199.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell199.Weight = 2.3010415641518955D;
            // 
            // xrTableCell200
            // 
            this.xrTableCell200.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell200.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[score_col1]")});
            this.xrTableCell200.Name = "xrTableCell200";
            this.xrTableCell200.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell200.StylePriority.UseBorders = false;
            this.xrTableCell200.StylePriority.UsePadding = false;
            this.xrTableCell200.Text = "xrTableCell56";
            this.xrTableCell200.Weight = 2.834791565158425D;
            // 
            // xrTableCell201
            // 
            this.xrTableCell201.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell201.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[score_col2]")});
            this.xrTableCell201.Name = "xrTableCell201";
            this.xrTableCell201.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell201.StylePriority.UseBorders = false;
            this.xrTableCell201.StylePriority.UsePadding = false;
            this.xrTableCell201.Text = "xrTableCell57";
            this.xrTableCell201.Weight = 2.8541665644157392D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.HeightF = 200F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(76F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow30,
            this.xrTableRow31,
            this.xrTableRow32,
            this.xrTableRow33,
            this.xrTableRow34,
            this.xrTableRow35,
            this.xrTableRow36,
            this.xrTableRow37});
            this.xrTable2.SizeF = new System.Drawing.SizeF(796F, 200F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow30
            // 
            this.xrTableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell121,
            this.xrTableCell122,
            this.xrTableCell123});
            this.xrTableRow30.Name = "xrTableRow30";
            this.xrTableRow30.Weight = 1D;
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell121.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell121.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell121.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell121.StylePriority.UseBackColor = false;
            this.xrTableCell121.StylePriority.UseBorders = false;
            this.xrTableCell121.StylePriority.UseFont = false;
            this.xrTableCell121.StylePriority.UseForeColor = false;
            this.xrTableCell121.StylePriority.UsePadding = false;
            this.xrTableCell121.StylePriority.UseTextAlignment = false;
            this.xrTableCell121.Text = "Data Management";
            this.xrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell121.Weight = 2.3010415641518955D;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell122.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell122.StylePriority.UseBorders = false;
            this.xrTableCell122.StylePriority.UseFont = false;
            this.xrTableCell122.StylePriority.UsePadding = false;
            this.xrTableCell122.Text = "BP As-Is > DM> \"Level 1\", etc. ";
            this.xrTableCell122.Weight = 2.834791565158425D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell123.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell123.StylePriority.UseBorders = false;
            this.xrTableCell123.StylePriority.UseFont = false;
            this.xrTableCell123.StylePriority.UsePadding = false;
            this.xrTableCell123.Text = "BP To-Be > DM> \"Level 1\", etc.";
            this.xrTableCell123.Weight = 2.8541665644157392D;
            // 
            // xrTableRow31
            // 
            this.xrTableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell124,
            this.xrTableCell125,
            this.xrTableCell126});
            this.xrTableRow31.Name = "xrTableRow31";
            this.xrTableRow31.Weight = 1D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell124.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell124.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell124.StylePriority.UseBackColor = false;
            this.xrTableCell124.StylePriority.UseBorders = false;
            this.xrTableCell124.StylePriority.UseFont = false;
            this.xrTableCell124.StylePriority.UsePadding = false;
            this.xrTableCell124.StylePriority.UseTextAlignment = false;
            this.xrTableCell124.Text = "Supporting Evidence Reference";
            this.xrTableCell124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell124.Weight = 2.3010415641518955D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell125.StylePriority.UseBorders = false;
            this.xrTableCell125.StylePriority.UsePadding = false;
            this.xrTableCell125.Text = "REPOSITORY >DM> What\'s attached?";
            this.xrTableCell125.Weight = 2.834791565158425D;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell126.StylePriority.UseBorders = false;
            this.xrTableCell126.StylePriority.UsePadding = false;
            this.xrTableCell126.Text = "REPOSITORY > DM> What\'s attached?";
            this.xrTableCell126.Weight = 2.8541665644157392D;
            // 
            // xrTableRow32
            // 
            this.xrTableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell127,
            this.xrTableCell128,
            this.xrTableCell129});
            this.xrTableRow32.Name = "xrTableRow32";
            this.xrTableRow32.Weight = 1D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell127.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell127.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell127.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell127.StylePriority.UseBackColor = false;
            this.xrTableCell127.StylePriority.UseBorders = false;
            this.xrTableCell127.StylePriority.UseFont = false;
            this.xrTableCell127.StylePriority.UseForeColor = false;
            this.xrTableCell127.StylePriority.UsePadding = false;
            this.xrTableCell127.StylePriority.UseTextAlignment = false;
            this.xrTableCell127.Text = "Conceptual Data Model";
            this.xrTableCell127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell127.Weight = 2.3010415641518955D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell128.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell128.StylePriority.UseBorders = false;
            this.xrTableCell128.StylePriority.UseFont = false;
            this.xrTableCell128.StylePriority.UsePadding = false;
            this.xrTableCell128.Text = "BP As-Is > CDM > \"Level 1\", etc.";
            this.xrTableCell128.Weight = 2.834791565158425D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell129.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell129.StylePriority.UseBorders = false;
            this.xrTableCell129.StylePriority.UseFont = false;
            this.xrTableCell129.StylePriority.UsePadding = false;
            this.xrTableCell129.Text = "BP To-Be > CDM > \"Level 1\", etc.";
            this.xrTableCell129.Weight = 2.8541665644157392D;
            // 
            // xrTableRow33
            // 
            this.xrTableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell130,
            this.xrTableCell131,
            this.xrTableCell132});
            this.xrTableRow33.Name = "xrTableRow33";
            this.xrTableRow33.Weight = 1D;
            // 
            // xrTableCell130
            // 
            this.xrTableCell130.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell130.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell130.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell130.Name = "xrTableCell130";
            this.xrTableCell130.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell130.StylePriority.UseBackColor = false;
            this.xrTableCell130.StylePriority.UseBorders = false;
            this.xrTableCell130.StylePriority.UseFont = false;
            this.xrTableCell130.StylePriority.UsePadding = false;
            this.xrTableCell130.StylePriority.UseTextAlignment = false;
            this.xrTableCell130.Text = "Supporting Evidence Reference";
            this.xrTableCell130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell130.Weight = 2.3010415641518955D;
            // 
            // xrTableCell131
            // 
            this.xrTableCell131.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell131.Name = "xrTableCell131";
            this.xrTableCell131.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell131.StylePriority.UseBorders = false;
            this.xrTableCell131.StylePriority.UsePadding = false;
            this.xrTableCell131.Text = "REPOSITORY>CDM> What\'s attached?";
            this.xrTableCell131.Weight = 2.834791565158425D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell132.StylePriority.UseBorders = false;
            this.xrTableCell132.StylePriority.UsePadding = false;
            this.xrTableCell132.Text = "REPOSITORY >CDM> What\'s attached?";
            this.xrTableCell132.Weight = 2.8541665644157392D;
            // 
            // xrTableRow34
            // 
            this.xrTableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell133,
            this.xrTableCell134,
            this.xrTableCell135});
            this.xrTableRow34.Name = "xrTableRow34";
            this.xrTableRow34.Weight = 1D;
            // 
            // xrTableCell133
            // 
            this.xrTableCell133.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell133.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell133.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell133.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell133.Name = "xrTableCell133";
            this.xrTableCell133.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell133.StylePriority.UseBackColor = false;
            this.xrTableCell133.StylePriority.UseBorders = false;
            this.xrTableCell133.StylePriority.UseFont = false;
            this.xrTableCell133.StylePriority.UseForeColor = false;
            this.xrTableCell133.StylePriority.UsePadding = false;
            this.xrTableCell133.StylePriority.UseTextAlignment = false;
            this.xrTableCell133.Text = "Logical Data Model";
            this.xrTableCell133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell133.Weight = 2.3010415641518955D;
            // 
            // xrTableCell134
            // 
            this.xrTableCell134.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell134.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell134.Name = "xrTableCell134";
            this.xrTableCell134.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell134.StylePriority.UseBorders = false;
            this.xrTableCell134.StylePriority.UseFont = false;
            this.xrTableCell134.StylePriority.UsePadding = false;
            this.xrTableCell134.Text = "BP As-Is > LDM > \"Level 1\", etc.";
            this.xrTableCell134.Weight = 2.834791565158425D;
            // 
            // xrTableCell135
            // 
            this.xrTableCell135.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell135.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell135.Name = "xrTableCell135";
            this.xrTableCell135.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell135.StylePriority.UseBorders = false;
            this.xrTableCell135.StylePriority.UseFont = false;
            this.xrTableCell135.StylePriority.UsePadding = false;
            this.xrTableCell135.Text = "BP To-Be > LDM > \"Level 1\", etc.";
            this.xrTableCell135.Weight = 2.8541665644157392D;
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell136,
            this.xrTableCell137,
            this.xrTableCell138});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Weight = 1D;
            // 
            // xrTableCell136
            // 
            this.xrTableCell136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell136.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell136.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell136.Name = "xrTableCell136";
            this.xrTableCell136.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell136.StylePriority.UseBackColor = false;
            this.xrTableCell136.StylePriority.UseBorders = false;
            this.xrTableCell136.StylePriority.UseFont = false;
            this.xrTableCell136.StylePriority.UsePadding = false;
            this.xrTableCell136.StylePriority.UseTextAlignment = false;
            this.xrTableCell136.Text = "Supporting Evidence Reference";
            this.xrTableCell136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell136.Weight = 2.3010415641518955D;
            // 
            // xrTableCell137
            // 
            this.xrTableCell137.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell137.Name = "xrTableCell137";
            this.xrTableCell137.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell137.StylePriority.UseBorders = false;
            this.xrTableCell137.StylePriority.UsePadding = false;
            this.xrTableCell137.Text = "REPOSITORY >LDM> What\'s attached?";
            this.xrTableCell137.Weight = 2.834791565158425D;
            // 
            // xrTableCell138
            // 
            this.xrTableCell138.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell138.Name = "xrTableCell138";
            this.xrTableCell138.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell138.StylePriority.UseBorders = false;
            this.xrTableCell138.StylePriority.UsePadding = false;
            this.xrTableCell138.Text = "REPOSITORY >LDM> What\'s attached?";
            this.xrTableCell138.Weight = 2.8541665644157392D;
            // 
            // xrTableRow36
            // 
            this.xrTableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell139,
            this.xrTableCell140,
            this.xrTableCell141});
            this.xrTableRow36.Name = "xrTableRow36";
            this.xrTableRow36.Weight = 1D;
            // 
            // xrTableCell139
            // 
            this.xrTableCell139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell139.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell139.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell139.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell139.Name = "xrTableCell139";
            this.xrTableCell139.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell139.StylePriority.UseBackColor = false;
            this.xrTableCell139.StylePriority.UseBorders = false;
            this.xrTableCell139.StylePriority.UseFont = false;
            this.xrTableCell139.StylePriority.UseForeColor = false;
            this.xrTableCell139.StylePriority.UsePadding = false;
            this.xrTableCell139.StylePriority.UseTextAlignment = false;
            this.xrTableCell139.Text = "Data Standards";
            this.xrTableCell139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell139.Weight = 2.3010415641518955D;
            // 
            // xrTableCell140
            // 
            this.xrTableCell140.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell140.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell140.Name = "xrTableCell140";
            this.xrTableCell140.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell140.StylePriority.UseBorders = false;
            this.xrTableCell140.StylePriority.UseFont = false;
            this.xrTableCell140.StylePriority.UsePadding = false;
            this.xrTableCell140.Text = "BP As-Is > DS > \"Level 1\", etc.";
            this.xrTableCell140.Weight = 2.834791565158425D;
            // 
            // xrTableCell141
            // 
            this.xrTableCell141.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell141.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell141.Name = "xrTableCell141";
            this.xrTableCell141.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell141.StylePriority.UseBorders = false;
            this.xrTableCell141.StylePriority.UseFont = false;
            this.xrTableCell141.StylePriority.UsePadding = false;
            this.xrTableCell141.Text = "BP To-Be > Effort > \"Level 1\", etc.";
            this.xrTableCell141.Weight = 2.8541665644157392D;
            // 
            // xrTableRow37
            // 
            this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell142,
            this.xrTableCell143,
            this.xrTableCell144});
            this.xrTableRow37.Name = "xrTableRow37";
            this.xrTableRow37.Weight = 1D;
            // 
            // xrTableCell142
            // 
            this.xrTableCell142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell142.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell142.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.xrTableCell142.Name = "xrTableCell142";
            this.xrTableCell142.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell142.StylePriority.UseBackColor = false;
            this.xrTableCell142.StylePriority.UseBorders = false;
            this.xrTableCell142.StylePriority.UseFont = false;
            this.xrTableCell142.StylePriority.UsePadding = false;
            this.xrTableCell142.StylePriority.UseTextAlignment = false;
            this.xrTableCell142.Text = "Supporting Evidence Reference";
            this.xrTableCell142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell142.Weight = 2.3010415641518955D;
            // 
            // xrTableCell143
            // 
            this.xrTableCell143.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell143.Name = "xrTableCell143";
            this.xrTableCell143.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell143.StylePriority.UseBorders = false;
            this.xrTableCell143.StylePriority.UsePadding = false;
            this.xrTableCell143.Text = "REPOSITORY >DS> What\'s attached?";
            this.xrTableCell143.Weight = 2.834791565158425D;
            // 
            // xrTableCell144
            // 
            this.xrTableCell144.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell144.Name = "xrTableCell144";
            this.xrTableCell144.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell144.StylePriority.UseBorders = false;
            this.xrTableCell144.StylePriority.UsePadding = false;
            this.xrTableCell144.Text = "REPOSITORY >DS> What\'s attached?";
            this.xrTableCell144.Weight = 2.8541665644157392D;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[area_name]")});
            this.xrLabel16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(231.1457F, 1049.979F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(691.8126F, 38.79168F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Business Area Name";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[area_identifier]")});
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(55.3332F, 1072.896F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(58.18742F, 38.79169F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "BA ID";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bp_name]")});
            this.xrLabel22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(217.5835F, 1154.146F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(664.5834F, 32.37502F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UsePadding = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Business Architecture Scorecard";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Gainsboro;
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[bp_identifier]")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(55.3332F, 1166.646F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(85.41654F, 32.37502F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Business Architecture Scorecard";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Card Name]")});
            this.xrLabel17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(99.00001F, 1311.521F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(749.9999F, 30.29167F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Business Architecture Scorecard";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(98.99982F, 1341.813F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(426.5255F, 44.5F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Standard Area";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(525.5253F, 1341.813F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(107.8249F, 44.5F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "As-Is Level of \r\nStandard Area";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(633.3502F, 1341.813F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(107.8247F, 44.5F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "To-Be Level of \r\nStandard Area";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(741.1749F, 1341.813F);
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(107.8248F, 44.5F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Project \r\nImpact";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(99.00033F, 1279.146F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow57});
            this.xrTable6.SizeF = new System.Drawing.SizeF(749.9997F, 25F);
            this.xrTable6.StylePriority.UseBorders = false;
            // 
            // xrTableRow57
            // 
            this.xrTableRow57.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell202,
            this.xrTableCell203,
            this.xrTableCell204,
            this.xrTableCell205});
            this.xrTableRow57.Name = "xrTableRow57";
            this.xrTableRow57.Weight = 1D;
            // 
            // xrTableCell202
            // 
            this.xrTableCell202.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell202.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell202.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Standard]")});
            this.xrTableCell202.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell202.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell202.Name = "xrTableCell202";
            this.xrTableCell202.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell202.StylePriority.UseBackColor = false;
            this.xrTableCell202.StylePriority.UseBorders = false;
            this.xrTableCell202.StylePriority.UseFont = false;
            this.xrTableCell202.StylePriority.UseForeColor = false;
            this.xrTableCell202.StylePriority.UsePadding = false;
            this.xrTableCell202.StylePriority.UseTextAlignment = false;
            this.xrTableCell202.Text = "Data Management";
            this.xrTableCell202.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell202.Weight = 5.7452454316788053D;
            // 
            // xrTableCell203
            // 
            this.xrTableCell203.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell203.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 1]")});
            this.xrTableCell203.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell203.Name = "xrTableCell203";
            this.xrTableCell203.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell203.StylePriority.UseBorders = false;
            this.xrTableCell203.StylePriority.UseFont = false;
            this.xrTableCell203.StylePriority.UsePadding = false;
            this.xrTableCell203.StylePriority.UseTextAlignment = false;
            this.xrTableCell203.Text = "BP As-Is > DM> \"Level 1\", etc. ";
            this.xrTableCell203.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell203.Weight = 1.4523875688178942D;
            // 
            // xrTableCell204
            // 
            this.xrTableCell204.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell204.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 2]")});
            this.xrTableCell204.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell204.Name = "xrTableCell204";
            this.xrTableCell204.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell204.StylePriority.UseBorders = false;
            this.xrTableCell204.StylePriority.UseFont = false;
            this.xrTableCell204.StylePriority.UsePadding = false;
            this.xrTableCell204.StylePriority.UseTextAlignment = false;
            this.xrTableCell204.Text = "BP To-Be > DM> \"Level 1\", etc.";
            this.xrTableCell204.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell204.Weight = 1.4523875634839791D;
            // 
            // xrTableCell205
            // 
            this.xrTableCell205.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell205.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[score2_minus_score1]")});
            this.xrTableCell205.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell205.Name = "xrTableCell205";
            this.xrTableCell205.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell205.StylePriority.UseBorders = false;
            this.xrTableCell205.StylePriority.UseFont = false;
            this.xrTableCell205.StylePriority.UsePadding = false;
            this.xrTableCell205.StylePriority.UseTextAlignment = false;
            this.xrTableCell205.Text = "xrTableCell1";
            this.xrTableCell205.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell205.Weight = 1.4523859192114217D;
            // 
            // spacer
            // 
            this.spacer.BackColor = System.Drawing.Color.White;
            this.spacer.LocationFloat = new DevExpress.Utils.PointFloat(99.00007F, 1464.021F);
            this.spacer.Name = "spacer";
            this.spacer.SizeF = new System.Drawing.SizeF(749.9999F, 27.08333F);
            this.spacer.StylePriority.UseBackColor = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(98.99982F, 1394.521F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(426.5253F, 44.5F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Standard Area";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(525.525F, 1394.521F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(107.8249F, 44.5F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "As-Is Level of \r\nStandard Area";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(633.35F, 1394.521F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(107.8247F, 44.5F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "To-Be Level of \r\nStandard Area";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(741.1747F, 1394.521F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(107.8248F, 44.5F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Project \r\nImpact";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(99.00039F, 1369.521F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow58});
            this.xrTable7.SizeF = new System.Drawing.SizeF(749.9998F, 25F);
            this.xrTable7.StylePriority.UseBorders = false;
            // 
            // xrTableRow58
            // 
            this.xrTableRow58.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell206,
            this.xrTableCell207,
            this.xrTableCell208,
            this.xrTableCell209});
            this.xrTableRow58.Name = "xrTableRow58";
            this.xrTableRow58.Weight = 1D;
            // 
            // xrTableCell206
            // 
            this.xrTableCell206.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrTableCell206.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell206.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Standard]")});
            this.xrTableCell206.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell206.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrTableCell206.Name = "xrTableCell206";
            this.xrTableCell206.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 3, 0, 0, 100F);
            this.xrTableCell206.StylePriority.UseBackColor = false;
            this.xrTableCell206.StylePriority.UseBorders = false;
            this.xrTableCell206.StylePriority.UseFont = false;
            this.xrTableCell206.StylePriority.UseForeColor = false;
            this.xrTableCell206.StylePriority.UsePadding = false;
            this.xrTableCell206.StylePriority.UseTextAlignment = false;
            this.xrTableCell206.Text = "Data Management";
            this.xrTableCell206.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell206.Weight = 5.7452454316788053D;
            // 
            // xrTableCell207
            // 
            this.xrTableCell207.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell207.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 1]")});
            this.xrTableCell207.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell207.Name = "xrTableCell207";
            this.xrTableCell207.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell207.StylePriority.UseBorders = false;
            this.xrTableCell207.StylePriority.UseFont = false;
            this.xrTableCell207.StylePriority.UsePadding = false;
            this.xrTableCell207.StylePriority.UseTextAlignment = false;
            this.xrTableCell207.Text = "BP As-Is > DM> \"Level 1\", etc. ";
            this.xrTableCell207.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell207.Weight = 1.452387568817894D;
            // 
            // xrTableCell208
            // 
            this.xrTableCell208.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell208.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 2]")});
            this.xrTableCell208.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell208.Name = "xrTableCell208";
            this.xrTableCell208.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell208.StylePriority.UseBorders = false;
            this.xrTableCell208.StylePriority.UseFont = false;
            this.xrTableCell208.StylePriority.UsePadding = false;
            this.xrTableCell208.StylePriority.UseTextAlignment = false;
            this.xrTableCell208.Text = "BP To-Be > DM> \"Level 1\", etc.";
            this.xrTableCell208.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell208.Weight = 1.4523859705949391D;
            // 
            // xrTableCell209
            // 
            this.xrTableCell209.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell209.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[score2_minus_score1]")});
            this.xrTableCell209.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell209.Name = "xrTableCell209";
            this.xrTableCell209.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 3, 3, 3, 100F);
            this.xrTableCell209.StylePriority.UseBorders = false;
            this.xrTableCell209.StylePriority.UseFont = false;
            this.xrTableCell209.StylePriority.UsePadding = false;
            this.xrTableCell209.StylePriority.UseTextAlignment = false;
            this.xrTableCell209.Text = "xrTableCell1";
            this.xrTableCell209.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell209.Weight = 1.4523891563730196D;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.xrLabel24.BorderColor = System.Drawing.Color.Black;
            this.xrLabel24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.BorderWidth = 1F;
            this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Standard]")});
            this.xrLabel24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.ForeColor = System.Drawing.Color.SteelBlue;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(98.99982F, 1439.021F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(426.5253F, 25F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseBorderColor = false;
            this.xrLabel24.StylePriority.UseBorderDashStyle = false;
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseBorderWidth = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UsePadding = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Data Management";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel27.BorderColor = System.Drawing.Color.Black;
            this.xrLabel27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.BorderWidth = 1F;
            this.xrLabel27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 1]")});
            this.xrLabel27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(525.525F, 1439.021F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(107.8248F, 25F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorderColor = false;
            this.xrLabel27.StylePriority.UseBorderDashStyle = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseBorderWidth = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "BP As-Is > DM> \"Level 1\", etc. ";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel28
            // 
            this.xrLabel28.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel28.BorderColor = System.Drawing.Color.Black;
            this.xrLabel28.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.BorderWidth = 1F;
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Score Column 2]")});
            this.xrLabel28.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.ForeColor = System.Drawing.Color.Black;
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(633.3497F, 1439.021F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(107.8247F, 25F);
            this.xrLabel28.StylePriority.UseBackColor = false;
            this.xrLabel28.StylePriority.UseBorderColor = false;
            this.xrLabel28.StylePriority.UseBorderDashStyle = false;
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseBorderWidth = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseForeColor = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "BP To-Be > DM> \"Level 1\", etc.";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.BorderWidth = 1F;
            this.xrLabel29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[score2_minus_score1]")});
            this.xrLabel29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.ForeColor = System.Drawing.Color.Black;
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(741.1744F, 1439.021F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(107.825F, 25F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.StylePriority.UseBorderColor = false;
            this.xrLabel29.StylePriority.UseBorderDashStyle = false;
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseBorderWidth = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UsePadding = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "xrTableCell1";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(741.1744F, 1492.979F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(107.8248F, 44.5F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Project \r\nImpact";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(525.5249F, 1492.979F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(107.8249F, 44.5F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "As-Is Level of \r\nStandard Area";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(633.3497F, 1492.979F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(107.8247F, 44.5F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "To-Be Level of \r\nStandard Area";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.xrLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(98.99982F, 1492.979F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(426.5253F, 44.5F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Standard Area";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // dump
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.Margins = new System.Drawing.Printing.Margins(100, 52, 1537, 100);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.PaperKind = System.Drawing.Printing.PaperKind.LetterRotated;
            this.Version = "17.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
