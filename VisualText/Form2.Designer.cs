
using System.Drawing;

namespace VisualText
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.titleTTSL = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openfileTTSL = new System.Windows.Forms.ToolStripLabel();
            this.lightdarkTTSB = new System.Windows.Forms.ToolStripButton();
            this.runBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.minTTSB = new System.Windows.Forms.ToolStripButton();
            this.maxTTSB = new System.Windows.Forms.ToolStripButton();
            this.closeTTSB = new System.Windows.Forms.ToolStripButton();
            this.closeTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.minimiseTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.maximiseTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.homeDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.basicDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.printlnTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mathTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.subSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.divSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.modSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sqrtSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pwrSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.randomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.rIntSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.rDoubleSTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.stringVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.intVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.longVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedListVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionaryVTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.logicDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileioDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.oopDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.useriDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Form2.resLabel = new System.Windows.Forms.Label();
            Form2.codeEditor = new System.Windows.Forms.RichTextBox();
            Form2.codeOutput = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleTTSL,
            this.toolStripSeparator4,
            this.openfileTTSL,
            this.lightdarkTTSB,
            this.runBtn,
            this.stopBtn,
            this.toolStripSeparator5,
            this.minTTSB,
            this.maxTTSB,
            this.closeTTSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1217, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMove);
            // 
            // titleTTSL
            // 
            this.titleTTSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.titleTTSL.Name = "titleTTSL";
            this.titleTTSL.Size = new System.Drawing.Size(123, 32);
            this.titleTTSL.Text = "VisualText Alpha v0.10";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // openfileTTSL
            // 
            this.openfileTTSL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openfileTTSL.Name = "openfileTTSL";
            this.openfileTTSL.Size = new System.Drawing.Size(102, 32);
            this.openfileTTSL.Text = "Current open file: ";
            // 
            // lightdarkTTSB
            // 
            this.lightdarkTTSB.Image = ((System.Drawing.Image)(resources.GetObject("lightdarkTTSB.Image")));
            this.lightdarkTTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lightdarkTTSB.Name = "lightdarkTTSB";
            this.lightdarkTTSB.Size = new System.Drawing.Size(100, 32);
            this.lightdarkTTSB.Text = "Light mode";
            this.lightdarkTTSB.Click += new System.EventHandler(this.lightdarkSwitch);
            // 
            // runBtn
            // 
            this.runBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runBtn.Image = ((System.Drawing.Image)(resources.GetObject("runBtn.Image")));
            this.runBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(32, 32);
            this.runBtn.Text = "toolStripButton1";
            this.runBtn.Click += new System.EventHandler(this.runProgram);
            // 
            // stopBtn
            // 
            this.stopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(32, 32);
            this.stopBtn.Text = "toolStripButton1";
            this.stopBtn.Click += new System.EventHandler(this.drawBlocks);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // minTTSB
            // 
            this.minTTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minTTSB.Image = global::VisualText.Properties.Resources.Minimize_transparent;
            this.minTTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minTTSB.Name = "minTTSB";
            this.minTTSB.Size = new System.Drawing.Size(32, 32);
            this.minTTSB.Text = "toolStripButton1";
            this.minTTSB.Click += new System.EventHandler(this.minW);
            // 
            // maxTTSB
            // 
            this.maxTTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maxTTSB.Image = global::VisualText.Properties.Resources.Windowed_transparent;
            this.maxTTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maxTTSB.Name = "maxTTSB";
            this.maxTTSB.Size = new System.Drawing.Size(32, 32);
            this.maxTTSB.Text = "toolStripButton2";
            this.maxTTSB.Click += new System.EventHandler(this.maxW);
            // 
            // closeTTSB
            // 
            this.closeTTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTTSB.Image = global::VisualText.Properties.Resources.X_transparent2;
            this.closeTTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTTSB.Name = "closeTTSB";
            this.closeTTSB.Size = new System.Drawing.Size(32, 32);
            this.closeTTSB.Text = "toolStripButton3";
            this.closeTTSB.Click += new System.EventHandler(this.closeW);
            // 
            // closeTSB
            // 
            this.closeTSB.Name = "closeTSB";
            this.closeTSB.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // minimiseTSB
            // 
            this.minimiseTSB.Name = "minimiseTSB";
            this.minimiseTSB.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // maximiseTSB
            // 
            this.maximiseTSB.Name = "maximiseTSB";
            this.maximiseTSB.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // homeDDB
            // 
            this.homeDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMI,
            this.openTSMI,
            this.saveTSMI,
            this.closeTSMI});
            this.homeDDB.Image = ((System.Drawing.Image)(resources.GetObject("homeDDB.Image")));
            this.homeDDB.ImageTransparentColor = System.Drawing.Color.Azure;
            this.homeDDB.Name = "homeDDB";
            this.homeDDB.Size = new System.Drawing.Size(76, 27);
            this.homeDDB.Text = "Home";
            // 
            // newTSMI
            // 
            this.newTSMI.Name = "newTSMI";
            this.newTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTSMI.Size = new System.Drawing.Size(155, 22);
            this.newTSMI.Text = "New...";
            this.newTSMI.Click += new System.EventHandler(this.newTSMIF);
            // 
            // openTSMI
            // 
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openTSMI.Size = new System.Drawing.Size(155, 22);
            this.openTSMI.Text = "Open...";
            this.openTSMI.Click += new System.EventHandler(this.openTSMIF);
            // 
            // saveTSMI
            // 
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTSMI.Size = new System.Drawing.Size(155, 22);
            this.saveTSMI.Text = "Save";
            this.saveTSMI.Click += new System.EventHandler(this.saveTSMIF);
            // 
            // closeTSMI
            // 
            this.closeTSMI.Name = "closeTSMI";
            this.closeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeTSMI.Size = new System.Drawing.Size(155, 22);
            this.closeTSMI.Text = "Close";
            this.closeTSMI.Click += new System.EventHandler(this.closeTSMIF);
            // 
            // basicDDB
            // 
            this.basicDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printlnTSMI,
            this.printTSMI,
            this.inputTSMI,
            this.mathTSMI,
            this.randomTSMI});
            this.basicDDB.Image = ((System.Drawing.Image)(resources.GetObject("basicDDB.Image")));
            this.basicDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.basicDDB.Name = "basicDDB";
            this.basicDDB.Size = new System.Drawing.Size(70, 27);
            this.basicDDB.Text = "Basic";
            this.basicDDB.Click += new System.EventHandler(this.basicDDBF);
            // 
            // printlnTSMI
            // 
            this.printlnTSMI.Name = "printlnTSMI";
            this.printlnTSMI.Size = new System.Drawing.Size(197, 22);
            this.printlnTSMI.Text = "Output (to new line)";
            this.printlnTSMI.Click += new System.EventHandler(this.printlnTSMIF);
            // 
            // printTSMI
            // 
            this.printTSMI.Name = "printTSMI";
            this.printTSMI.Size = new System.Drawing.Size(197, 22);
            this.printTSMI.Text = "Output (to current line)";
            this.printTSMI.Click += new System.EventHandler(this.printTSMIF);
            // 
            // inputTSMI
            // 
            this.inputTSMI.Name = "inputTSMI";
            this.inputTSMI.Size = new System.Drawing.Size(197, 22);
            this.inputTSMI.Text = "Input";
            this.inputTSMI.Click += new System.EventHandler(this.inputTSMIF);
            // 
            // mathTSMI
            // 
            this.mathTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSTSMI,
            this.subSTSMI,
            this.multiSTSMI,
            this.divSTSMI,
            this.modSTSMI,
            this.sqrtSTSMI,
            this.pwrSTSMI});
            this.mathTSMI.Name = "mathTSMI";
            this.mathTSMI.Size = new System.Drawing.Size(197, 22);
            this.mathTSMI.Text = "Math operations";
            // 
            // addSTSMI
            // 
            this.addSTSMI.Name = "addSTSMI";
            this.addSTSMI.Size = new System.Drawing.Size(162, 22);
            this.addSTSMI.Text = "Add";
            this.addSTSMI.Click += new System.EventHandler(this.addSTSMIF);
            // 
            // subSTSMI
            // 
            this.subSTSMI.Name = "subSTSMI";
            this.subSTSMI.Size = new System.Drawing.Size(162, 22);
            this.subSTSMI.Text = "Subtract";
            this.subSTSMI.Click += new System.EventHandler(this.subSTSMIF);
            // 
            // multiSTSMI
            // 
            this.multiSTSMI.Name = "multiSTSMI";
            this.multiSTSMI.Size = new System.Drawing.Size(162, 22);
            this.multiSTSMI.Text = "Multiply";
            this.multiSTSMI.Click += new System.EventHandler(this.multiSTSMIF);
            // 
            // divSTSMI
            // 
            this.divSTSMI.Name = "divSTSMI";
            this.divSTSMI.Size = new System.Drawing.Size(162, 22);
            this.divSTSMI.Text = "Divide";
            this.divSTSMI.Click += new System.EventHandler(this.divSTSMIF);
            // 
            // modSTSMI
            // 
            this.modSTSMI.Name = "modSTSMI";
            this.modSTSMI.Size = new System.Drawing.Size(162, 22);
            this.modSTSMI.Text = "Modulo";
            this.modSTSMI.Click += new System.EventHandler(this.modSTSMIF);
            // 
            // sqrtSTSMI
            // 
            this.sqrtSTSMI.Name = "sqrtSTSMI";
            this.sqrtSTSMI.Size = new System.Drawing.Size(162, 22);
            this.sqrtSTSMI.Text = "Square root";
            this.sqrtSTSMI.Click += new System.EventHandler(this.sqrtSTSMIF);
            // 
            // pwrSTSMI
            // 
            this.pwrSTSMI.Name = "pwrSTSMI";
            this.pwrSTSMI.Size = new System.Drawing.Size(162, 22);
            this.pwrSTSMI.Text = "Power/Exponent";
            this.pwrSTSMI.Click += new System.EventHandler(this.pwrSTSMIF);
            // 
            // randomTSMI
            // 
            this.randomTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rIntSTSMI,
            this.rDoubleSTSMI});
            this.randomTSMI.Name = "randomTSMI";
            this.randomTSMI.Size = new System.Drawing.Size(197, 22);
            this.randomTSMI.Text = "Random";
            // 
            // rIntSTSMI
            // 
            this.rIntSTSMI.Name = "rIntSTSMI";
            this.rIntSTSMI.Size = new System.Drawing.Size(166, 22);
            this.rIntSTSMI.Text = "Integer";
            this.rIntSTSMI.Click += new System.EventHandler(this.rIntSTSMIF);
            // 
            // rDoubleSTSMI
            // 
            this.rDoubleSTSMI.Name = "rDoubleSTSMI";
            this.rDoubleSTSMI.Size = new System.Drawing.Size(166, 22);
            this.rDoubleSTSMI.Text = "Decimal (Double)";
            this.rDoubleSTSMI.Click += new System.EventHandler(this.rDoubleSTSMIF);
            // 
            // dataDDB
            // 
            this.dataDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringVTSMI,
            this.intVTSMI,
            this.longVTSMI,
            this.doubleVTSMI,
            this.booleanVTSMI,
            this.arrayVTSMI,
            this.linkedListVTSMI,
            this.dictionaryVTSMI});
            this.dataDDB.Image = ((System.Drawing.Image)(resources.GetObject("dataDDB.Image")));
            this.dataDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dataDDB.Name = "dataDDB";
            this.dataDDB.Size = new System.Drawing.Size(67, 27);
            this.dataDDB.Text = "Data";
            this.dataDDB.Click += new System.EventHandler(this.dataDDBF);
            // 
            // stringVTSMI
            // 
            this.stringVTSMI.Name = "stringVTSMI";
            this.stringVTSMI.Size = new System.Drawing.Size(212, 22);
            this.stringVTSMI.Text = "Variable (String)";
            this.stringVTSMI.Click += new System.EventHandler(this.stringVTSMIF);
            // 
            // intVTSMI
            // 
            this.intVTSMI.Name = "intVTSMI";
            this.intVTSMI.Size = new System.Drawing.Size(212, 22);
            this.intVTSMI.Text = "Variable (Integer)";
            this.intVTSMI.Click += new System.EventHandler(this.intVTSMIF);
            // 
            // longVTSMI
            // 
            this.longVTSMI.Name = "longVTSMI";
            this.longVTSMI.Size = new System.Drawing.Size(212, 22);
            this.longVTSMI.Text = "Variable (Large number)";
            this.longVTSMI.Click += new System.EventHandler(this.longVTSMIF);
            // 
            // doubleVTSMI
            // 
            this.doubleVTSMI.Name = "doubleVTSMI";
            this.doubleVTSMI.Size = new System.Drawing.Size(212, 22);
            this.doubleVTSMI.Text = "Variable (Decimal/Double)";
            this.doubleVTSMI.Click += new System.EventHandler(this.doubleVTSMIF);
            // 
            // booleanVTSMI
            // 
            this.booleanVTSMI.Name = "booleanVTSMI";
            this.booleanVTSMI.Size = new System.Drawing.Size(212, 22);
            this.booleanVTSMI.Text = "Variable (Boolean)";
            this.booleanVTSMI.Click += new System.EventHandler(this.booleanVTSMIF);
            // 
            // arrayVTSMI
            // 
            this.arrayVTSMI.Name = "arrayVTSMI";
            this.arrayVTSMI.Size = new System.Drawing.Size(212, 22);
            this.arrayVTSMI.Text = "Array";
            this.arrayVTSMI.Click += new System.EventHandler(this.arrayVTSMIF);
            // 
            // linkedListVTSMI
            // 
            this.linkedListVTSMI.Name = "linkedListVTSMI";
            this.linkedListVTSMI.Size = new System.Drawing.Size(212, 22);
            this.linkedListVTSMI.Text = "LinkedList";
            this.linkedListVTSMI.Click += new System.EventHandler(this.linkedListVTSMIF);
            // 
            // dictionaryVTSMI
            // 
            this.dictionaryVTSMI.Name = "dictionaryVTSMI";
            this.dictionaryVTSMI.Size = new System.Drawing.Size(212, 22);
            this.dictionaryVTSMI.Text = "Dictionary";
            this.dictionaryVTSMI.Click += new System.EventHandler(this.dictionaryVTSMIF);
            // 
            // logicDDB
            // 
            this.logicDDB.Image = ((System.Drawing.Image)(resources.GetObject("logicDDB.Image")));
            this.logicDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logicDDB.Name = "logicDDB";
            this.logicDDB.Size = new System.Drawing.Size(72, 27);
            this.logicDDB.Text = "Logic";
            this.logicDDB.Click += new System.EventHandler(this.logicDDBF);
            // 
            // fileioDDB
            // 
            this.fileioDDB.Image = ((System.Drawing.Image)(resources.GetObject("fileioDDB.Image")));
            this.fileioDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileioDDB.Name = "fileioDDB";
            this.fileioDDB.Size = new System.Drawing.Size(76, 27);
            this.fileioDDB.Text = "File IO";
            this.fileioDDB.Click += new System.EventHandler(this.fileioDDBF);
            // 
            // oopDDB
            // 
            this.oopDDB.Image = ((System.Drawing.Image)(resources.GetObject("oopDDB.Image")));
            this.oopDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oopDDB.Name = "oopDDB";
            this.oopDDB.Size = new System.Drawing.Size(68, 27);
            this.oopDDB.Text = "OOP";
            this.oopDDB.Click += new System.EventHandler(this.drawBlocks);
            // 
            // useriDDB
            // 
            this.useriDDB.Image = ((System.Drawing.Image)(resources.GetObject("useriDDB.Image")));
            this.useriDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.useriDDB.Name = "useriDDB";
            this.useriDDB.Size = new System.Drawing.Size(115, 27);
            this.useriDDB.Text = "User Interface";
            this.useriDDB.Click += new System.EventHandler(this.startScan);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeDDB,
            this.basicDDB,
            this.dataDDB,
            this.logicDDB,
            this.fileioDDB,
            this.oopDDB,
            this.useriDDB});
            this.toolStrip2.Location = new System.Drawing.Point(0, 35);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1217, 30);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "6";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SizerMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SizerMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SizerMouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton homeDDB;
        private System.Windows.Forms.ToolStripMenuItem newTSMI;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveTSMI;
        private System.Windows.Forms.ToolStripMenuItem closeTSMI;
        private System.Windows.Forms.ToolStripDropDownButton basicDDB;
        private System.Windows.Forms.ToolStripDropDownButton logicDDB;
        private System.Windows.Forms.ToolStripDropDownButton fileioDDB;
        private System.Windows.Forms.ToolStripDropDownButton oopDDB;
        private System.Windows.Forms.ToolStripDropDownButton useriDDB;
        private System.Windows.Forms.ToolStripMenuItem printTSMI;
        private System.Windows.Forms.ToolStripMenuItem printlnTSMI;
        private System.Windows.Forms.ToolStripMenuItem inputTSMI;
        private System.Windows.Forms.ToolStripMenuItem mathTSMI;
        private System.Windows.Forms.ToolStripDropDownButton dataDDB;
        private System.Windows.Forms.ToolStripMenuItem stringVTSMI;
        private System.Windows.Forms.ToolStripMenuItem intVTSMI;
        private System.Windows.Forms.ToolStripMenuItem doubleVTSMI;
        private System.Windows.Forms.ToolStripMenuItem booleanVTSMI;
        private System.Windows.Forms.ToolStripMenuItem arrayVTSMI;
        private System.Windows.Forms.ToolStripMenuItem linkedListVTSMI;
        private System.Windows.Forms.ToolStripMenuItem dictionaryVTSMI;
        private System.Windows.Forms.ToolStripMenuItem addSTSMI;
        private System.Windows.Forms.ToolStripMenuItem subSTSMI;
        private System.Windows.Forms.ToolStripMenuItem multiSTSMI;
        private System.Windows.Forms.ToolStripMenuItem divSTSMI;
        private System.Windows.Forms.ToolStripMenuItem modSTSMI;
        private System.Windows.Forms.ToolStripMenuItem sqrtSTSMI;
        private System.Windows.Forms.ToolStripMenuItem pwrSTSMI;
        private System.Windows.Forms.ToolStripMenuItem randomTSMI;
        private System.Windows.Forms.ToolStripMenuItem rIntSTSMI;
        private System.Windows.Forms.ToolStripMenuItem rDoubleSTSMI;
        public static System.Windows.Forms.RichTextBox codeEditor;
        public static System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton minimiseTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton maximiseTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton closeTSB;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton minTTSB;
        private System.Windows.Forms.ToolStripButton maxTTSB;
        private System.Windows.Forms.ToolStripButton closeTTSB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel titleTTSL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel openfileTTSL;
        private System.Windows.Forms.ToolStripButton lightdarkTTSB;
        private System.Windows.Forms.ToolStripMenuItem longVTSMI;
        private System.Windows.Forms.RichTextBox code;
        public static System.Windows.Forms.RichTextBox codeOutput;
        private System.Windows.Forms.ToolStripButton runBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}