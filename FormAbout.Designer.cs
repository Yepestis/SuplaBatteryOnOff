namespace SuplaBatteryOnOff
{
    partial class FormAbout
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelGSM_MODEM = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate.Location = new System.Drawing.Point(134, 127);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 15);
            this.labelDate.TabIndex = 26;
            this.labelDate.Text = "© 2020";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVersion.Location = new System.Drawing.Point(127, 72);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(31, 17);
            this.labelVersion.TabIndex = 25;
            this.labelVersion.Text = "ver";
            // 
            // labelGSM_MODEM
            // 
            this.labelGSM_MODEM.AutoSize = true;
            this.labelGSM_MODEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGSM_MODEM.Location = new System.Drawing.Point(7, 18);
            this.labelGSM_MODEM.Name = "labelGSM_MODEM";
            this.labelGSM_MODEM.Size = new System.Drawing.Size(325, 24);
            this.labelGSM_MODEM.TabIndex = 24;
            this.labelGSM_MODEM.Text = "Supla Battery On Off - Direct Links";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.ForeColor = System.Drawing.Color.Blue;
            this.labelEmail.Location = new System.Drawing.Point(229, 129);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(95, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "silar12@gmail.com";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            this.labelEmail.MouseLeave += new System.EventHandler(this.labelEmail_MouseLeave);
            this.labelEmail.MouseHover += new System.EventHandler(this.labelEmail_MouseHover);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(14, 129);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 13);
            this.labelAuthor.TabIndex = 22;
            this.labelAuthor.Text = "Yepestis";
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(121, 194);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 240);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelGSM_MODEM);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelGSM_MODEM;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAuthor;
        internal System.Windows.Forms.Button buttonClose;
    }
}