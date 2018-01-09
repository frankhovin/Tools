﻿namespace ChromeMullog {
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
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.openChromeButton = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // websiteLabel
            //
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(13, 36);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(59, 17);
            this.websiteLabel.TabIndex = 0;
            this.websiteLabel.Text = "Website";
            //
            // websiteTextBox
            //
            this.websiteTextBox.Location = new System.Drawing.Point(82, 36);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(294, 22);
            this.websiteTextBox.TabIndex = 1;
            //
            // openChromeButton
            //
            this.openChromeButton.Location = new System.Drawing.Point(82, 87);
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Size = new System.Drawing.Size(132, 27);
            this.openChromeButton.TabIndex = 2;
            this.openChromeButton.Text = "Open Chrome";
            this.openChromeButton.UseVisualStyleBackColor = true;
            this.openChromeButton.Click += new System.EventHandler(this.openChromeButton_Click);
            //
            // killButton
            //
            this.killButton.Location = new System.Drawing.Point(244, 87);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(133, 27);
            this.killButton.TabIndex = 3;
            this.killButton.Text = "Kill Chrome";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            //
            // addRowButton
            //
            this.addRowButton.Location = new System.Drawing.Point(244, 135);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(51, 23);
            this.addRowButton.TabIndex = 4;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            //
            // removeRowButton
            //
            this.removeRowButton.Location = new System.Drawing.Point(301, 135);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(75, 23);
            this.removeRowButton.TabIndex = 5;
            this.removeRowButton.Text = "Remove";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            //
            // userPanel
            //
            this.userPanel.AutoSize = true;
            this.userPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userPanel.ColumnCount = 3;
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.userPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.userPanel.Location = new System.Drawing.Point(12, 173);
            this.userPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.userPanel.Name = "userPanel";
            this.userPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userPanel.RowCount = 3;
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userPanel.Size = new System.Drawing.Size(390, 0);
            this.userPanel.TabIndex = 6;
            //
            // statusStrip
            //
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 288);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(406, 25);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            //
            // toolStripStatusLabel
            //
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            //
            // menuStrip1
            //
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            //
            // aboutToolStripMenuItem
            //
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 30, 0);
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            //
            // aboutToolStripMenuItem1
            //
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 313);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.openChromeButton);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(this.websiteLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CML 1.0";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.Button openChromeButton;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.TableLayoutPanel userPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}