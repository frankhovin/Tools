namespace ChromeMultipleLogins {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.websiteLabel = new System.Windows.Forms.Label();
            this.openChromeButton = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.websiteTextbox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(13, 16);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(63, 17);
            this.websiteLabel.TabIndex = 0;
            this.websiteLabel.Text = "Website:";
            // 
            // openChromeButton
            // 
            this.openChromeButton.Location = new System.Drawing.Point(82, 67);
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Size = new System.Drawing.Size(132, 27);
            this.openChromeButton.TabIndex = 12;
            this.openChromeButton.Text = "Open Chrome";
            this.openChromeButton.UseVisualStyleBackColor = true;
            this.openChromeButton.Click += new System.EventHandler(this.OpenChromeButton_Click);
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(244, 67);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(133, 27);
            this.killButton.TabIndex = 14;
            this.killButton.Text = "Kill Chrome";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // userPanel
            // 
            this.userPanel.AutoSize = true;
            this.userPanel.ColumnCount = 3;
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.Location = new System.Drawing.Point(9, 153);
            this.userPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userPanel.Name = "userPanel";
            this.userPanel.RowCount = 3;
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.Size = new System.Drawing.Size(392, 103);
            this.userPanel.TabIndex = 15;
            // 
            // removeRowButton
            // 
            this.removeRowButton.Enabled = false;
            this.removeRowButton.Location = new System.Drawing.Point(301, 115);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(75, 23);
            this.removeRowButton.TabIndex = 16;
            this.removeRowButton.Text = "Remove";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(244, 115);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(51, 23);
            this.addRowButton.TabIndex = 17;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // websiteTextbox
            // 
            this.websiteTextbox.Location = new System.Drawing.Point(82, 16);
            this.websiteTextbox.Name = "websiteTextbox";
            this.websiteTextbox.Size = new System.Drawing.Size(294, 22);
            this.websiteTextbox.TabIndex = 18;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 268);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(406, 24);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(406, 292);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.websiteTextbox);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.openChromeButton);
            this.Controls.Add(this.websiteLabel);
            this.Name = "MainForm";
            this.Text = "Chrome Multiple Logins";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Button openChromeButton;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.TableLayoutPanel userPanel;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.TextBox websiteTextbox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

