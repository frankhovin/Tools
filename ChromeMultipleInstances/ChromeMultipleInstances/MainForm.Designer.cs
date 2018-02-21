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
            this.components = new System.ComponentModel.Container();
            this.funcSelector = new MetroFramework.Controls.MetroComboBox();
            this.ssMultipleLoginsPanel = new MetroFramework.Controls.MetroPanel();
            this.actionButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.killChromeButton = new MetroFramework.Controls.MetroButton();
            this.launchChromeButton = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.actionButtonsPanel.SuspendLayout();
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
            this.ssMultipleLoginsPanel.HorizontalScrollbarBarColor = true;
            this.ssMultipleLoginsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ssMultipleLoginsPanel.HorizontalScrollbarSize = 10;
            this.ssMultipleLoginsPanel.Location = new System.Drawing.Point(25, 48);
            this.ssMultipleLoginsPanel.Name = "ssMultipleLoginsPanel";
            this.ssMultipleLoginsPanel.Size = new System.Drawing.Size(490, 237);
            this.ssMultipleLoginsPanel.TabIndex = 1;
            this.ssMultipleLoginsPanel.VerticalScrollbarBarColor = true;
            this.ssMultipleLoginsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ssMultipleLoginsPanel.VerticalScrollbarSize = 10;
            // 
            // actionButtonsPanel
            // 
            this.actionButtonsPanel.Controls.Add(this.killChromeButton);
            this.actionButtonsPanel.Controls.Add(this.launchChromeButton);
            this.actionButtonsPanel.HorizontalScrollbarBarColor = true;
            this.actionButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.actionButtonsPanel.HorizontalScrollbarSize = 10;
            this.actionButtonsPanel.Location = new System.Drawing.Point(25, 292);
            this.actionButtonsPanel.Name = "actionButtonsPanel";
            this.actionButtonsPanel.Size = new System.Drawing.Size(490, 45);
            this.actionButtonsPanel.TabIndex = 2;
            this.actionButtonsPanel.VerticalScrollbarBarColor = true;
            this.actionButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.actionButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // killChromeButton
            // 
            this.killChromeButton.Location = new System.Drawing.Point(147, 4);
            this.killChromeButton.Name = "killChromeButton";
            this.killChromeButton.Size = new System.Drawing.Size(132, 38);
            this.killChromeButton.TabIndex = 3;
            this.killChromeButton.Text = "Kill Chrome";
            this.killChromeButton.Click += new System.EventHandler(this.killChromeButton_Click);
            // 
            // launchChromeButton
            // 
            this.launchChromeButton.Location = new System.Drawing.Point(4, 4);
            this.launchChromeButton.Name = "launchChromeButton";
            this.launchChromeButton.Size = new System.Drawing.Size(132, 38);
            this.launchChromeButton.TabIndex = 2;
            this.launchChromeButton.Text = "Launch Chrome";
            this.launchChromeButton.Click += new System.EventHandler(this.launchChromeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 389);
            this.Controls.Add(this.actionButtonsPanel);
            this.Controls.Add(this.ssMultipleLoginsPanel);
            this.Controls.Add(this.funcSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.actionButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox funcSelector;
        private MetroFramework.Controls.MetroPanel ssMultipleLoginsPanel;
        private MetroFramework.Controls.MetroPanel actionButtonsPanel;
        private MetroFramework.Controls.MetroButton launchChromeButton;
        private MetroFramework.Controls.MetroButton killChromeButton;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}

