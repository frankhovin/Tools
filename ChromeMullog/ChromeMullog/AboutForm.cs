using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeMullog {
    partial class AboutForm : Form {
        private Button closeButton;
        private TextBox aboutTextBox;

        public AboutForm () {
            InitializeComponent();
        }

        public void InitializeComponent () {
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // aboutTextBox
            //
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.aboutTextBox.Location = new System.Drawing.Point(15, 10);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aboutTextBox.Size = new System.Drawing.Size(255, 218);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.TabStop = false;
            this.aboutTextBox.Text = "\r\nCML version 1.0\r\n\r\n";
            this.aboutTextBox.Text += "Jan. 9, 2018\r\n\r\nby Frank Høvin\r\n\r\n" +
                                     "Licensed exclusively for use by the\r\n\r\n Opus Team in Telecomputing.";
            this.aboutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // closeButton
            //
            this.closeButton.Location = new System.Drawing.Point(107, 200);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            //
            // AboutForm
            //
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutTextBox);
            this.Name = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
