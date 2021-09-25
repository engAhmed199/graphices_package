namespace PROJECT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRESENHAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDPOINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIRCLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cENTERPOINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tWOPOINTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLLIPSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOLYGONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSLATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TX = new System.Windows.Forms.ToolStripTextBox();
            this.TY = new System.Windows.Forms.ToolStripTextBox();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rOTATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aROUND00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angle = new System.Windows.Forms.ToolStripTextBox();
            this.sTARTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCALINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SX = new System.Windows.Forms.ToolStripTextBox();
            this.SY = new System.Windows.Forms.ToolStripTextBox();
            this.sATRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pp = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lINEToolStripMenuItem,
            this.mIDPOINTToolStripMenuItem,
            this.pOLYGONToolStripMenuItem,
            this.tRANSLATIONToolStripMenuItem,
            this.rOTATIONToolStripMenuItem,
            this.sCALINGToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lINEToolStripMenuItem
            // 
            this.lINEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bRESENHAMToolStripMenuItem});
            this.lINEToolStripMenuItem.Name = "lINEToolStripMenuItem";
            this.lINEToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.lINEToolStripMenuItem.Text = "LINE";
            this.lINEToolStripMenuItem.Click += new System.EventHandler(this.lINEToolStripMenuItem_Click_1);
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bRESENHAMToolStripMenuItem
            // 
            this.bRESENHAMToolStripMenuItem.Name = "bRESENHAMToolStripMenuItem";
            this.bRESENHAMToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.bRESENHAMToolStripMenuItem.Text = "BRESENHAM";
            this.bRESENHAMToolStripMenuItem.Click += new System.EventHandler(this.bRESENHAMToolStripMenuItem_Click);
            // 
            // mIDPOINTToolStripMenuItem
            // 
            this.mIDPOINTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIRCLEToolStripMenuItem,
            this.eLLIPSEToolStripMenuItem});
            this.mIDPOINTToolStripMenuItem.Name = "mIDPOINTToolStripMenuItem";
            this.mIDPOINTToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.mIDPOINTToolStripMenuItem.Text = "MIDPOINT";
            this.mIDPOINTToolStripMenuItem.Click += new System.EventHandler(this.mIDPOINTToolStripMenuItem_Click_1);
            // 
            // cIRCLEToolStripMenuItem
            // 
            this.cIRCLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cENTERPOINTToolStripMenuItem,
            this.tWOPOINTSToolStripMenuItem});
            this.cIRCLEToolStripMenuItem.Name = "cIRCLEToolStripMenuItem";
            this.cIRCLEToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.cIRCLEToolStripMenuItem.Text = "CIRCLE";
            // 
            // cENTERPOINTToolStripMenuItem
            // 
            this.cENTERPOINTToolStripMenuItem.Name = "cENTERPOINTToolStripMenuItem";
            this.cENTERPOINTToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.cENTERPOINTToolStripMenuItem.Text = "CENTER&POINT";
            this.cENTERPOINTToolStripMenuItem.Click += new System.EventHandler(this.cENTERPOINTToolStripMenuItem_Click_1);
            // 
            // tWOPOINTSToolStripMenuItem
            // 
            this.tWOPOINTSToolStripMenuItem.Name = "tWOPOINTSToolStripMenuItem";
            this.tWOPOINTSToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.tWOPOINTSToolStripMenuItem.Text = "TWO POINTS";
            this.tWOPOINTSToolStripMenuItem.Click += new System.EventHandler(this.tWOPOINTSToolStripMenuItem_Click);
            // 
            // eLLIPSEToolStripMenuItem
            // 
            this.eLLIPSEToolStripMenuItem.Name = "eLLIPSEToolStripMenuItem";
            this.eLLIPSEToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.eLLIPSEToolStripMenuItem.Text = "ELLIPSE";
            this.eLLIPSEToolStripMenuItem.Click += new System.EventHandler(this.eLLIPSEToolStripMenuItem_Click);
            // 
            // pOLYGONToolStripMenuItem
            // 
            this.pOLYGONToolStripMenuItem.Name = "pOLYGONToolStripMenuItem";
            this.pOLYGONToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.pOLYGONToolStripMenuItem.Text = "UNFORMED_SHAPE";
            this.pOLYGONToolStripMenuItem.Click += new System.EventHandler(this.pOLYGONToolStripMenuItem_Click);
            // 
            // tRANSLATIONToolStripMenuItem
            // 
            this.tRANSLATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TX,
            this.TY,
            this.sTARTToolStripMenuItem});
            this.tRANSLATIONToolStripMenuItem.Name = "tRANSLATIONToolStripMenuItem";
            this.tRANSLATIONToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.tRANSLATIONToolStripMenuItem.Text = "TRANSLATION";
            this.tRANSLATIONToolStripMenuItem.Click += new System.EventHandler(this.tRANSLATIONToolStripMenuItem_Click);
            // 
            // TX
            // 
            this.TX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(100, 27);
            this.TX.Text = "X";
            // 
            // TY
            // 
            this.TY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TY.Name = "TY";
            this.TY.Size = new System.Drawing.Size(100, 27);
            this.TY.Text = "Y";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.sTARTToolStripMenuItem_Click);
            // 
            // rOTATIONToolStripMenuItem
            // 
            this.rOTATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aROUND00ToolStripMenuItem});
            this.rOTATIONToolStripMenuItem.Name = "rOTATIONToolStripMenuItem";
            this.rOTATIONToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
            this.rOTATIONToolStripMenuItem.Text = "ROTATION";
            this.rOTATIONToolStripMenuItem.Click += new System.EventHandler(this.rOTATIONToolStripMenuItem_Click);
            // 
            // aROUND00ToolStripMenuItem
            // 
            this.aROUND00ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angle,
            this.sTARTToolStripMenuItem1});
            this.aROUND00ToolStripMenuItem.Name = "aROUND00ToolStripMenuItem";
            this.aROUND00ToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aROUND00ToolStripMenuItem.Text = "AROUND(0,0)";
            // 
            // angle
            // 
            this.angle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(100, 27);
            this.angle.Text = "ANGLE";
            // 
            // sTARTToolStripMenuItem1
            // 
            this.sTARTToolStripMenuItem1.Name = "sTARTToolStripMenuItem1";
            this.sTARTToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.sTARTToolStripMenuItem1.Text = "START";
            this.sTARTToolStripMenuItem1.Click += new System.EventHandler(this.sTARTToolStripMenuItem1_Click);
            // 
            // sCALINGToolStripMenuItem
            // 
            this.sCALINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SX,
            this.SY,
            this.sATRTToolStripMenuItem});
            this.sCALINGToolStripMenuItem.Name = "sCALINGToolStripMenuItem";
            this.sCALINGToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.sCALINGToolStripMenuItem.Text = "SCALING";
            this.sCALINGToolStripMenuItem.Click += new System.EventHandler(this.sCALINGToolStripMenuItem_Click);
            // 
            // SX
            // 
            this.SX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SX.Name = "SX";
            this.SX.Size = new System.Drawing.Size(100, 27);
            this.SX.Text = "X";
            // 
            // SY
            // 
            this.SY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SY.Name = "SY";
            this.SY.Size = new System.Drawing.Size(100, 27);
            this.SY.Text = "Y";
            // 
            // sATRTToolStripMenuItem
            // 
            this.sATRTToolStripMenuItem.Name = "sATRTToolStripMenuItem";
            this.sATRTToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.sATRTToolStripMenuItem.Text = "SATRT";
            this.sATRTToolStripMenuItem.Click += new System.EventHandler(this.sATRTToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // pp
            // 
            this.pp.BackColor = System.Drawing.Color.White;
            this.pp.Location = new System.Drawing.Point(76, 32);
            this.pp.Margin = new System.Windows.Forms.Padding(4);
            this.pp.Name = "pp";
            this.pp.Size = new System.Drawing.Size(1010, 805);
            this.pp.TabIndex = 1;
            this.pp.TabStop = false;
            this.pp.Click += new System.EventHandler(this.pp_Click);
            this.pp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 564);
            this.Controls.Add(this.pp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "IMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lINEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRESENHAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIDPOINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIRCLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cENTERPOINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tWOPOINTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLLIPSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOLYGONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSLATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TX;
        private System.Windows.Forms.ToolStripTextBox TY;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rOTATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aROUND00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox angle;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sCALINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SX;
        private System.Windows.Forms.ToolStripTextBox SY;
        private System.Windows.Forms.ToolStripMenuItem sATRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pp;
    }
}

