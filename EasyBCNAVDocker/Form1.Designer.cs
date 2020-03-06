﻿namespace EasyBCNAVDocker
{
    partial class main
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
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.cbImageSelector = new System.Windows.Forms.ComboBox();
            this.cbLocalization = new System.Windows.Forms.ComboBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.lblImageSelector = new System.Windows.Forms.Label();
            this.lblLocalization = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.lblNotificationTxt = new System.Windows.Forms.Label();
            this.pnlNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.BackColor = System.Drawing.Color.Black;
            this.btnCreateContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContainer.Location = new System.Drawing.Point(227, 197);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(147, 23);
            this.btnCreateContainer.TabIndex = 0;
            this.btnCreateContainer.Text = "Create Container!";
            this.btnCreateContainer.UseVisualStyleBackColor = false;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // cbImageSelector
            // 
            this.cbImageSelector.BackColor = System.Drawing.Color.Black;
            this.cbImageSelector.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbImageSelector.FormattingEnabled = true;
            this.cbImageSelector.Items.AddRange(new object[] {
            "BC On-premises",
            "BC Sandbox",
            "NAV"});
            this.cbImageSelector.Location = new System.Drawing.Point(157, 34);
            this.cbImageSelector.Name = "cbImageSelector";
            this.cbImageSelector.Size = new System.Drawing.Size(217, 22);
            this.cbImageSelector.TabIndex = 1;
            // 
            // cbLocalization
            // 
            this.cbLocalization.BackColor = System.Drawing.Color.Black;
            this.cbLocalization.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbLocalization.FormattingEnabled = true;
            this.cbLocalization.Location = new System.Drawing.Point(157, 88);
            this.cbLocalization.Name = "cbLocalization";
            this.cbLocalization.Size = new System.Drawing.Size(217, 22);
            this.cbLocalization.TabIndex = 2;
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.Black;
            this.cbVersion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(157, 136);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(217, 22);
            this.cbVersion.TabIndex = 3;
            // 
            // lblImageSelector
            // 
            this.lblImageSelector.AutoSize = true;
            this.lblImageSelector.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblImageSelector.Location = new System.Drawing.Point(92, 36);
            this.lblImageSelector.Name = "lblImageSelector";
            this.lblImageSelector.Size = new System.Drawing.Size(48, 17);
            this.lblImageSelector.TabIndex = 4;
            this.lblImageSelector.Text = "Image";
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblLocalization.Location = new System.Drawing.Point(36, 90);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(104, 17);
            this.lblLocalization.TabIndex = 5;
            this.lblLocalization.Text = "Localization";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblVersion.Location = new System.Drawing.Point(76, 138);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(64, 17);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version";
            // 
            // pnlNotification
            // 
            this.pnlNotification.BackColor = System.Drawing.Color.Red;
            this.pnlNotification.Controls.Add(this.lblNotificationTxt);
            this.pnlNotification.ForeColor = System.Drawing.Color.White;
            this.pnlNotification.Location = new System.Drawing.Point(0, 225);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(428, 25);
            this.pnlNotification.TabIndex = 7;
            this.pnlNotification.Visible = false;
            // 
            // lblNotificationTxt
            // 
            this.lblNotificationTxt.AutoSize = true;
            this.lblNotificationTxt.Location = new System.Drawing.Point(9, 5);
            this.lblNotificationTxt.Name = "lblNotificationTxt";
            this.lblNotificationTxt.Size = new System.Drawing.Size(63, 14);
            this.lblNotificationTxt.TabIndex = 0;
            this.lblNotificationTxt.Text = "dummytxt";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(428, 250);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLocalization);
            this.Controls.Add(this.lblImageSelector);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbLocalization);
            this.Controls.Add(this.cbImageSelector);
            this.Controls.Add(this.btnCreateContainer);
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBCNAVDocker";
            this.Load += new System.EventHandler(this.main_Load);
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.ComboBox cbImageSelector;
        private System.Windows.Forms.ComboBox cbLocalization;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label lblImageSelector;
        private System.Windows.Forms.Label lblLocalization;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Label lblNotificationTxt;
    }
}
