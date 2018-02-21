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
            this.ssMultipleLoginsPanel.Size = new System.Drawing.Size(490, 304);
            this.ssMultipleLoginsPanel.TabIndex = 1;
            this.ssMultipleLoginsPanel.VerticalScrollbarBarColor = true;
            this.ssMultipleLoginsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ssMultipleLoginsPanel.VerticalScrollbarSize = 10;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox funcSelector;
        private MetroFramework.Controls.MetroTextBox address1Textbox;
        private MetroFramework.Controls.MetroLabel adr1Label;
        private MetroFramework.Controls.MetroPanel ssMultipleLoginsPanel;
    }
}

