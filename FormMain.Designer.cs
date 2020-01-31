namespace SuplaBatteryOnOff
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonTestOn = new System.Windows.Forms.Button();
            this.buttonTestOff = new System.Windows.Forms.Button();
            this.labelDirectLinkOn = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxDirectLinkOn = new System.Windows.Forms.TextBox();
            this.textBoxDirectLinkOff = new System.Windows.Forms.TextBox();
            this.labelDirectLinkOff = new System.Windows.Forms.Label();
            this.timerGetBatteryInfo = new System.Windows.Forms.Timer(this.components);
            this.textBoxChargeStatus = new System.Windows.Forms.TextBox();
            this.groupBoxBatteryInfo = new System.Windows.Forms.GroupBox();
            this.textBoxLineStatus = new System.Windows.Forms.TextBox();
            this.textBoxLifeRemaining = new System.Windows.Forms.TextBox();
            this.textBoxFullLifeTime = new System.Windows.Forms.TextBox();
            this.labelLineStatus = new System.Windows.Forms.Label();
            this.labelLifeRemaining = new System.Windows.Forms.Label();
            this.labelFullLifeTime = new System.Windows.Forms.Label();
            this.textBoxCharge = new System.Windows.Forms.TextBox();
            this.labelCharge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonActionStop = new System.Windows.Forms.Button();
            this.buttonActionStart = new System.Windows.Forms.Button();
            this.numericUpDownBatteryActionOff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBatteryActionOn = new System.Windows.Forms.NumericUpDown();
            this.labelBatteryActionOff = new System.Windows.Forms.Label();
            this.labelBatteryActionOn = new System.Windows.Forms.Label();
            this.timerDirectLink = new System.Windows.Forms.Timer(this.components);
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxMinimalizeOnStart = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.groupBoxBatteryInfo.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryActionOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryActionOn)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTestOn
            // 
            this.buttonTestOn.Location = new System.Drawing.Point(539, 313);
            this.buttonTestOn.Name = "buttonTestOn";
            this.buttonTestOn.Size = new System.Drawing.Size(75, 23);
            this.buttonTestOn.TabIndex = 3;
            this.buttonTestOn.Text = "Test ON";
            this.buttonTestOn.UseVisualStyleBackColor = true;
            this.buttonTestOn.Click += new System.EventHandler(this.buttonTestOn_Click);
            // 
            // buttonTestOff
            // 
            this.buttonTestOff.Location = new System.Drawing.Point(539, 366);
            this.buttonTestOff.Name = "buttonTestOff";
            this.buttonTestOff.Size = new System.Drawing.Size(75, 23);
            this.buttonTestOff.TabIndex = 4;
            this.buttonTestOff.Text = "Test OFF";
            this.buttonTestOff.UseVisualStyleBackColor = true;
            this.buttonTestOff.Click += new System.EventHandler(this.buttonTestOff_Click);
            // 
            // labelDirectLinkOn
            // 
            this.labelDirectLinkOn.AutoSize = true;
            this.labelDirectLinkOn.Location = new System.Drawing.Point(12, 298);
            this.labelDirectLinkOn.Name = "labelDirectLinkOn";
            this.labelDirectLinkOn.Size = new System.Drawing.Size(73, 13);
            this.labelDirectLinkOn.TabIndex = 2;
            this.labelDirectLinkOn.Text = "Direct link ON";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(626, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBoxDirectLinkOn
            // 
            this.textBoxDirectLinkOn.Location = new System.Drawing.Point(12, 315);
            this.textBoxDirectLinkOn.Name = "textBoxDirectLinkOn";
            this.textBoxDirectLinkOn.Size = new System.Drawing.Size(471, 20);
            this.textBoxDirectLinkOn.TabIndex = 12;
            this.textBoxDirectLinkOn.Text = "https://svr7.supla.org/direct/661/MxWjZRMY4jT/turn-on";
            this.textBoxDirectLinkOn.TextChanged += new System.EventHandler(this.textBoxDirectLinkOn_TextChanged);
            // 
            // textBoxDirectLinkOff
            // 
            this.textBoxDirectLinkOff.Location = new System.Drawing.Point(12, 366);
            this.textBoxDirectLinkOff.Name = "textBoxDirectLinkOff";
            this.textBoxDirectLinkOff.Size = new System.Drawing.Size(471, 20);
            this.textBoxDirectLinkOff.TabIndex = 13;
            this.textBoxDirectLinkOff.Text = "https://svr7.supla.org/direct/661/MxWjZRMY4jT/turn-off";
            this.textBoxDirectLinkOff.TextChanged += new System.EventHandler(this.textBoxDirectLinkOff_TextChanged);
            // 
            // labelDirectLinkOff
            // 
            this.labelDirectLinkOff.AutoSize = true;
            this.labelDirectLinkOff.Location = new System.Drawing.Point(12, 350);
            this.labelDirectLinkOff.Name = "labelDirectLinkOff";
            this.labelDirectLinkOff.Size = new System.Drawing.Size(77, 13);
            this.labelDirectLinkOff.TabIndex = 6;
            this.labelDirectLinkOff.Text = "Direct link OFF";
            // 
            // timerGetBatteryInfo
            // 
            this.timerGetBatteryInfo.Interval = 1000;
            this.timerGetBatteryInfo.Tick += new System.EventHandler(this.timerGetBatteryInfo_Tick);
            // 
            // textBoxChargeStatus
            // 
            this.textBoxChargeStatus.Location = new System.Drawing.Point(6, 41);
            this.textBoxChargeStatus.Name = "textBoxChargeStatus";
            this.textBoxChargeStatus.Size = new System.Drawing.Size(177, 20);
            this.textBoxChargeStatus.TabIndex = 5;
            // 
            // groupBoxBatteryInfo
            // 
            this.groupBoxBatteryInfo.Controls.Add(this.textBoxLineStatus);
            this.groupBoxBatteryInfo.Controls.Add(this.textBoxLifeRemaining);
            this.groupBoxBatteryInfo.Controls.Add(this.textBoxFullLifeTime);
            this.groupBoxBatteryInfo.Controls.Add(this.labelLineStatus);
            this.groupBoxBatteryInfo.Controls.Add(this.labelLifeRemaining);
            this.groupBoxBatteryInfo.Controls.Add(this.labelFullLifeTime);
            this.groupBoxBatteryInfo.Controls.Add(this.textBoxCharge);
            this.groupBoxBatteryInfo.Controls.Add(this.textBoxChargeStatus);
            this.groupBoxBatteryInfo.Controls.Add(this.labelCharge);
            this.groupBoxBatteryInfo.Controls.Add(this.label1);
            this.groupBoxBatteryInfo.Location = new System.Drawing.Point(15, 35);
            this.groupBoxBatteryInfo.Name = "groupBoxBatteryInfo";
            this.groupBoxBatteryInfo.Size = new System.Drawing.Size(189, 228);
            this.groupBoxBatteryInfo.TabIndex = 8;
            this.groupBoxBatteryInfo.TabStop = false;
            this.groupBoxBatteryInfo.Text = "Battery Info";
            // 
            // textBoxLineStatus
            // 
            this.textBoxLineStatus.Location = new System.Drawing.Point(6, 197);
            this.textBoxLineStatus.Name = "textBoxLineStatus";
            this.textBoxLineStatus.Size = new System.Drawing.Size(177, 20);
            this.textBoxLineStatus.TabIndex = 9;
            // 
            // textBoxLifeRemaining
            // 
            this.textBoxLifeRemaining.Location = new System.Drawing.Point(6, 158);
            this.textBoxLifeRemaining.Name = "textBoxLifeRemaining";
            this.textBoxLifeRemaining.Size = new System.Drawing.Size(177, 20);
            this.textBoxLifeRemaining.TabIndex = 8;
            // 
            // textBoxFullLifeTime
            // 
            this.textBoxFullLifeTime.Location = new System.Drawing.Point(6, 80);
            this.textBoxFullLifeTime.Name = "textBoxFullLifeTime";
            this.textBoxFullLifeTime.Size = new System.Drawing.Size(177, 20);
            this.textBoxFullLifeTime.TabIndex = 6;
            // 
            // labelLineStatus
            // 
            this.labelLineStatus.AutoSize = true;
            this.labelLineStatus.Location = new System.Drawing.Point(6, 181);
            this.labelLineStatus.Name = "labelLineStatus";
            this.labelLineStatus.Size = new System.Drawing.Size(60, 13);
            this.labelLineStatus.TabIndex = 8;
            this.labelLineStatus.Text = "Line Status";
            // 
            // labelLifeRemaining
            // 
            this.labelLifeRemaining.AutoSize = true;
            this.labelLifeRemaining.Location = new System.Drawing.Point(6, 142);
            this.labelLifeRemaining.Name = "labelLifeRemaining";
            this.labelLifeRemaining.Size = new System.Drawing.Size(103, 13);
            this.labelLifeRemaining.TabIndex = 8;
            this.labelLifeRemaining.Text = "Life Remaining (sec)";
            // 
            // labelFullLifeTime
            // 
            this.labelFullLifeTime.AutoSize = true;
            this.labelFullLifeTime.Location = new System.Drawing.Point(6, 64);
            this.labelFullLifeTime.Name = "labelFullLifeTime";
            this.labelFullLifeTime.Size = new System.Drawing.Size(95, 13);
            this.labelFullLifeTime.TabIndex = 8;
            this.labelFullLifeTime.Text = "Full Life Time (sec)";
            // 
            // textBoxCharge
            // 
            this.textBoxCharge.Location = new System.Drawing.Point(6, 119);
            this.textBoxCharge.Name = "textBoxCharge";
            this.textBoxCharge.Size = new System.Drawing.Size(177, 20);
            this.textBoxCharge.TabIndex = 7;
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(6, 103);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(41, 13);
            this.labelCharge.TabIndex = 2;
            this.labelCharge.Text = "Charge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Charge status";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonActionStop);
            this.groupBoxAction.Controls.Add(this.buttonActionStart);
            this.groupBoxAction.Controls.Add(this.numericUpDownBatteryActionOff);
            this.groupBoxAction.Controls.Add(this.numericUpDownBatteryActionOn);
            this.groupBoxAction.Controls.Add(this.labelBatteryActionOff);
            this.groupBoxAction.Controls.Add(this.labelBatteryActionOn);
            this.groupBoxAction.Location = new System.Drawing.Point(210, 35);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(183, 228);
            this.groupBoxAction.TabIndex = 9;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Action";
            // 
            // buttonActionStop
            // 
            this.buttonActionStop.Location = new System.Drawing.Point(51, 181);
            this.buttonActionStop.Name = "buttonActionStop";
            this.buttonActionStop.Size = new System.Drawing.Size(75, 36);
            this.buttonActionStop.TabIndex = 2;
            this.buttonActionStop.Text = "Stop";
            this.buttonActionStop.UseVisualStyleBackColor = true;
            this.buttonActionStop.Click += new System.EventHandler(this.buttonActionStop_Click);
            // 
            // buttonActionStart
            // 
            this.buttonActionStart.Location = new System.Drawing.Point(9, 142);
            this.buttonActionStart.Name = "buttonActionStart";
            this.buttonActionStart.Size = new System.Drawing.Size(160, 36);
            this.buttonActionStart.TabIndex = 1;
            this.buttonActionStart.Text = "Start";
            this.buttonActionStart.UseVisualStyleBackColor = true;
            this.buttonActionStart.Click += new System.EventHandler(this.buttonActionStart_Click);
            // 
            // numericUpDownBatteryActionOff
            // 
            this.numericUpDownBatteryActionOff.Location = new System.Drawing.Point(9, 81);
            this.numericUpDownBatteryActionOff.Name = "numericUpDownBatteryActionOff";
            this.numericUpDownBatteryActionOff.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownBatteryActionOff.TabIndex = 11;
            this.numericUpDownBatteryActionOff.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownBatteryActionOff.ValueChanged += new System.EventHandler(this.numericUpDownBatteryActionOff_ValueChanged);
            // 
            // numericUpDownBatteryActionOn
            // 
            this.numericUpDownBatteryActionOn.Location = new System.Drawing.Point(9, 41);
            this.numericUpDownBatteryActionOn.Name = "numericUpDownBatteryActionOn";
            this.numericUpDownBatteryActionOn.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownBatteryActionOn.TabIndex = 10;
            this.numericUpDownBatteryActionOn.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownBatteryActionOn.ValueChanged += new System.EventHandler(this.numericUpDownBatteryActionOn_ValueChanged);
            // 
            // labelBatteryActionOff
            // 
            this.labelBatteryActionOff.AutoSize = true;
            this.labelBatteryActionOff.Location = new System.Drawing.Point(6, 64);
            this.labelBatteryActionOff.Name = "labelBatteryActionOff";
            this.labelBatteryActionOff.Size = new System.Drawing.Size(95, 13);
            this.labelBatteryActionOff.TabIndex = 0;
            this.labelBatteryActionOff.Text = "Battery action OFF";
            // 
            // labelBatteryActionOn
            // 
            this.labelBatteryActionOn.AutoSize = true;
            this.labelBatteryActionOn.Location = new System.Drawing.Point(6, 25);
            this.labelBatteryActionOn.Name = "labelBatteryActionOn";
            this.labelBatteryActionOn.Size = new System.Drawing.Size(91, 13);
            this.labelBatteryActionOn.TabIndex = 0;
            this.labelBatteryActionOn.Text = "Battery action ON";
            // 
            // timerDirectLink
            // 
            this.timerDirectLink.Interval = 60000;
            this.timerDirectLink.Tick += new System.EventHandler(this.timerDirectLink_Tick);
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "Supla Battery On Off";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTray_MouseDoubleClick);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxMinimalizeOnStart);
            this.groupBoxSettings.Location = new System.Drawing.Point(399, 35);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(215, 228);
            this.groupBoxSettings.TabIndex = 12;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // checkBoxMinimalizeOnStart
            // 
            this.checkBoxMinimalizeOnStart.AutoSize = true;
            this.checkBoxMinimalizeOnStart.Location = new System.Drawing.Point(7, 20);
            this.checkBoxMinimalizeOnStart.Name = "checkBoxMinimalizeOnStart";
            this.checkBoxMinimalizeOnStart.Size = new System.Drawing.Size(116, 17);
            this.checkBoxMinimalizeOnStart.TabIndex = 0;
            this.checkBoxMinimalizeOnStart.Text = "Minimize on startup";
            this.checkBoxMinimalizeOnStart.UseVisualStyleBackColor = true;
            this.checkBoxMinimalizeOnStart.CheckedChanged += new System.EventHandler(this.checkBoxMinimalizeOnStart_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 412);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxBatteryInfo);
            this.Controls.Add(this.labelDirectLinkOff);
            this.Controls.Add(this.textBoxDirectLinkOff);
            this.Controls.Add(this.textBoxDirectLinkOn);
            this.Controls.Add(this.labelDirectLinkOn);
            this.Controls.Add(this.buttonTestOff);
            this.Controls.Add(this.buttonTestOn);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Supla Battery On Off - Direct Links";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxBatteryInfo.ResumeLayout(false);
            this.groupBoxBatteryInfo.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryActionOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBatteryActionOn)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTestOn;
        private System.Windows.Forms.Button buttonTestOff;
        private System.Windows.Forms.Label labelDirectLinkOn;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxDirectLinkOn;
        private System.Windows.Forms.TextBox textBoxDirectLinkOff;
        private System.Windows.Forms.Label labelDirectLinkOff;
        private System.Windows.Forms.Timer timerGetBatteryInfo;
        private System.Windows.Forms.TextBox textBoxChargeStatus;
        private System.Windows.Forms.GroupBox groupBoxBatteryInfo;
        private System.Windows.Forms.TextBox textBoxFullLifeTime;
        private System.Windows.Forms.Label labelFullLifeTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLifeRemaining;
        private System.Windows.Forms.Label labelLifeRemaining;
        private System.Windows.Forms.TextBox textBoxCharge;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.TextBox textBoxLineStatus;
        private System.Windows.Forms.Label labelLineStatus;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonActionStop;
        private System.Windows.Forms.Button buttonActionStart;
        private System.Windows.Forms.NumericUpDown numericUpDownBatteryActionOff;
        private System.Windows.Forms.NumericUpDown numericUpDownBatteryActionOn;
        private System.Windows.Forms.Label labelBatteryActionOff;
        private System.Windows.Forms.Label labelBatteryActionOn;
        private System.Windows.Forms.Timer timerDirectLink;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxMinimalizeOnStart;
    }
}

