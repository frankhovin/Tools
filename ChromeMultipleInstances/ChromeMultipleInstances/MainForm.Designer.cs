namespace ChromeMultipleInstances {
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
            this.funcSelector = new MetroFramework.Controls.MetroComboBox();
            this.ssMultipleLoginsPanel = new MetroFramework.Controls.MetroPanel();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.ssMultipleLoginsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // funcSelector
            //
            this.funcSelector.FormattingEnabled = true;
            this.funcSelector.ItemHeight = 24;
            this.funcSelector.Items.AddRange(new object[] {
            "One website, multiple logins"});
            this.funcSelector.Location = new System.Drawing.Point(25, 1);
            this.funcSelector.Name = "funcSelector";
            this.funcSelector.Size = new System.Drawing.Size(490, 30);
            this.funcSelector.TabIndex = 0;
            this.funcSelector.SelectedIndexChanged += new System.EventHandler(this.funcSelector_SelectedIndexChanged);
            //
            // ssMultipleLoginsPanel
            //
            this.ssMultipleLoginsPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ssMultipleLoginsPanel.Controls.Add(this.passwordTextbox);
            this.ssMultipleLoginsPanel.Controls.Add(this.usernameTextbox);
            this.ssMultipleLoginsPanel.Controls.Add(this.passwordLabel);
            this.ssMultipleLoginsPanel.Controls.Add(this.usernameLabel);
            this.ssMultipleLoginsPanel.HorizontalScrollbarBarColor = true;
            this.ssMultipleLoginsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ssMultipleLoginsPanel.HorizontalScrollbarSize = 10;
            this.ssMultipleLoginsPanel.Location = new System.Drawing.Point(25, 49);
            this.ssMultipleLoginsPanel.Name = "ssMultipleLoginsPanel";
            this.ssMultipleLoginsPanel.Size = new System.Drawing.Size(490, 292);
            this.ssMultipleLoginsPanel.TabIndex = 1;
            this.ssMultipleLoginsPanel.VerticalScrollbarBarColor = true;
            this.ssMultipleLoginsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ssMultipleLoginsPanel.VerticalScrollbarSize = 10;
            //
            // usernameTextbox
            //
            this.usernameTextbox.Location = new System.Drawing.Point(90, 90);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(190, 25);
            this.usernameTextbox.TabIndex = 4;
            //
            // passwordTextbox
            //
            this.passwordTextbox.Location = new System.Drawing.Point(290, 90);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(190, 25);
            this.passwordTextbox.TabIndex = 5;
            //
            // usernameLabel
            //
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(90, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(290, 60);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(66, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.ssMultipleLoginsPanel);
            this.Controls.Add(this.funcSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ssMultipleLoginsPanel.ResumeLayout(false);
            this.ssMultipleLoginsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox funcSelector;
        private MetroFramework.Controls.MetroPanel ssMultipleLoginsPanel;
        private MetroFramework.Controls.MetroTextBox address1Textbox;
        private MetroFramework.Controls.MetroLabel adr1Label;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private MetroFramework.Controls.MetroTextBox usernameTextbox;
    }
}

