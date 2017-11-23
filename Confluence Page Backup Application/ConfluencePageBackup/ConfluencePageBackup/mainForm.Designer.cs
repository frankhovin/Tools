using ConfluencePageBackup.OS;

namespace ConfluencePageBackup {
    partial class mainForm {
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
            this.browserLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.browserComboBox = new System.Windows.Forms.ComboBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.pages_label = new System.Windows.Forms.Label();
            this.backupLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bottomStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.space_label = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserLabel
            // 
            this.browserLabel.AutoSize = true;
            this.browserLabel.Location = new System.Drawing.Point(17, 16);
            this.browserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.browserLabel.Name = "browserLabel";
            this.browserLabel.Size = new System.Drawing.Size(59, 17);
            this.browserLabel.TabIndex = 0;
            this.browserLabel.Text = "Browser";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(255, 16);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(36, 17);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL";
            // 
            // browserComboBox
            // 
            this.browserComboBox.FormattingEnabled = true;
            this.browserComboBox.Location = new System.Drawing.Point(80, 14);
            this.browserComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.browserComboBox.Name = "browserComboBox";
            this.browserComboBox.Size = new System.Drawing.Size(160, 24);
            this.browserComboBox.TabIndex = 1;
            this.browserComboBox.SelectedIndexChanged += new System.EventHandler(this.browserComboBox_SelectedIndexChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(300, 14);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(332, 22);
            this.urlTextBox.TabIndex = 2;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(532, 387);
            this.goButton.Margin = new System.Windows.Forms.Padding(4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 28);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // pages_label
            // 
            this.pages_label.AutoSize = true;
            this.pages_label.Location = new System.Drawing.Point(255, 128);
            this.pages_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pages_label.Name = "pages_label";
            this.pages_label.Size = new System.Drawing.Size(41, 17);
            this.pages_label.TabIndex = 5;
            this.pages_label.Text = "Page";
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Location = new System.Drawing.Point(255, 281);
            this.backupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(63, 17);
            this.backupLabel.TabIndex = 6;
            this.backupLabel.Text = "Backup?";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(363, 57);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(364, 93);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(452, 54);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(180, 22);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(452, 91);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(180, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottomStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 11;
            // 
            // bottomStatusLabel
            // 
            this.bottomStatusLabel.Name = "bottomStatusLabel";
            this.bottomStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // space_label
            // 
            this.space_label.AutoSize = true;
            this.space_label.Location = new System.Drawing.Point(20, 128);
            this.space_label.Name = "space_label";
            this.space_label.Size = new System.Drawing.Size(48, 17);
            this.space_label.TabIndex = 12;
            this.space_label.Text = "Space";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 462);
            this.Controls.Add(this.space_label);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.backupLabel);
            this.Controls.Add(this.pages_label);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.browserComboBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.browserLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Confluence Page Backup";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label browserLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.ComboBox browserComboBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label pages_label;
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel bottomStatusLabel;
        private System.Windows.Forms.Label space_label;
    }
}

