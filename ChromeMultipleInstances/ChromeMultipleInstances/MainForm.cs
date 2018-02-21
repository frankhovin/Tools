using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeMultipleInstances {
    public partial class MainForm : Form {



        public MainForm() {
            InitializeComponent();


            //this.funcSelector = new MetroFramework.Controls.MetroComboBox();
            //this.ssMultipleLoginsPanel = new MetroFramework.Controls.MetroPanel();


        }

        private void funcSelector_SelectedIndexChanged(object sender, EventArgs e) {
            if (funcSelector.Text.Equals("One website, multiple logins")) {
                GetSSMLPanel();
            }
        }


        private void GetSSMLPanel() {
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
            MetroFramework.Controls.MetroTextBox addr1Textbox = new MetroFramework.Controls.MetroTextBox();
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
            // usernameTextbox
            //
            MetroFramework.Controls.MetroTextBox usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(usernameTextbox);
            usernameTextbox.Location = new System.Drawing.Point(70, 65);
            usernameTextbox.Size = new System.Drawing.Size(140, 23);
            usernameTextbox.TabIndex = 3;
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
            // passwordTextbox
            //
            MetroFramework.Controls.MetroTextBox passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(passwordTextbox);
            passwordTextbox.Location = new System.Drawing.Point(220, 65);
            passwordTextbox.Size = new System.Drawing.Size(140, 23);
            passwordTextbox.TabIndex = 5;


        }


    }
}
