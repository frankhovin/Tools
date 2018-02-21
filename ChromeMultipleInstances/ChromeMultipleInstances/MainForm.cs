using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChromeMultipleInstances.Selenium;

namespace ChromeMultipleInstances {
    public partial class MainForm : Form {
        MetroFramework.Controls.MetroTextBox addr1Textbox;
        MetroFramework.Controls.MetroTextBox usernameTextbox1,
                                             usernameTextbox2,
                                             usernameTextbox3,
                                             passwordTextbox1,
                                             passwordTextbox2,
                                             passwordTextbox3;

        MetroFramework.Controls.MetroTextBox[] logins;

        private void populateLogins () {
            logins[0] = usernameTextbox1;
        }


        public MainForm() {
            InitializeComponent();

            if (Properties.Settings.Default.rowcount == 0) {
                Properties.Settings.Default.rowcount = 3;
            }



        }

        private void funcSelector_SelectedIndexChanged(object sender, EventArgs e) {
            if (funcSelector.Text.Equals("One website, multiple logins")) {
                ShowSSMLPanel();
            }
        }

        private void ShowSSMLPanel() {
            //
            // Address label
            //
            MetroFramework.Controls.MetroLabel addr1Label = new MetroFramework.Controls.MetroLabel();
            ssMultipleLoginsPanel.Controls.Add(addr1Label);
            addr1Label.AutoSize = true;
            addr1Label.Location = new System.Drawing.Point(4, 12);
            addr1Label.Name = "adr1Label";
            addr1Label.Size = new System.Drawing.Size(55, 20);
            addr1Label.Text = "Address:";
            //
            // Address textfield
            //
            addr1Textbox = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(addr1Textbox);
            addr1Textbox.Location = new System.Drawing.Point(70, 10);
            addr1Textbox.Size = new System.Drawing.Size(290, 23);
            addr1Textbox.Style = MetroFramework.MetroColorStyle.White;
            addr1Textbox.TabIndex = 2;
            addr1Textbox.Text = "Website address";
            //
            // usernameLabel
            //
            MetroFramework.Controls.MetroLabel usernameLabel = new MetroFramework.Controls.MetroLabel();
            ssMultipleLoginsPanel.Controls.Add(usernameLabel);
            usernameLabel.Location = new System.Drawing.Point(70, 43);
            usernameLabel.Size = new System.Drawing.Size(73, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            MetroFramework.Controls.MetroLabel passwordLabel = new MetroFramework.Controls.MetroLabel();
            ssMultipleLoginsPanel.Controls.Add(passwordLabel);
            passwordLabel.Location = new System.Drawing.Point(220, 43);
            passwordLabel.Size = new System.Drawing.Size(73, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            //
            // usernameTextbox1
            //
            usernameTextbox1 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(usernameTextbox1);
            usernameTextbox1.Location = new System.Drawing.Point(70, 65);
            usernameTextbox1.Size = new System.Drawing.Size(140, 23);
            usernameTextbox1.TabIndex = 5;
            //
            // passwordTextbox1
            //
            passwordTextbox1 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(passwordTextbox1);
            passwordTextbox1.Location = new System.Drawing.Point(220, 65);
            passwordTextbox1.Size = new System.Drawing.Size(140, 22);
            passwordTextbox1.TabIndex = 6;
            //
            // usernameTextbox2
            //
            usernameTextbox2 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(usernameTextbox2);
            usernameTextbox2.Location = new System.Drawing.Point(70, 92);
            usernameTextbox2.Size = new System.Drawing.Size(140, 23);
            usernameTextbox2.TabIndex = 7;
            //
            // passwordTextbox2
            //
            passwordTextbox2 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(passwordTextbox2);
            passwordTextbox2.Location = new System.Drawing.Point(220, 92);
            passwordTextbox2.Size = new System.Drawing.Size(140, 22);
            usernameTextbox2.TabIndex = 8;
            //
            // usernameTextbox3
            //
            usernameTextbox3 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(usernameTextbox3);
            usernameTextbox3.Location = new System.Drawing.Point(70, 119);
            usernameTextbox3.Size = new System.Drawing.Size(140, 23);
            usernameTextbox3.TabIndex = 9;
            //
            // passwordTextbox3
            //
            passwordTextbox3 = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(passwordTextbox3);
            passwordTextbox3.Location = new System.Drawing.Point(220, 119);
            passwordTextbox3.Size = new System.Drawing.Size(140, 22);
            usernameTextbox3.TabIndex = 10;
        }

        private void launchChromeButton_Click(object sender, EventArgs e) {
            string adr = addr1Textbox.Text.ToString();
        }

        private void killChromeButton_Click(object sender, EventArgs e) {

        }
    }
}
