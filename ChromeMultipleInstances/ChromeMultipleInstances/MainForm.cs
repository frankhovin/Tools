﻿using System;
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
            MetroFramework.Controls.MetroLabel addr1Label = new MetroFramework.Controls.MetroLabel();
            ssMultipleLoginsPanel.Controls.Add(addr1Label);
            addr1Label.AutoSize = true;
            addr1Label.Location = new System.Drawing.Point(4, 10);
            addr1Label.Name = "adr1Label";
            addr1Label.Size = new System.Drawing.Size(55, 20);
            addr1Label.TabIndex = 2;
            addr1Label.Text = "Address:";

            MetroFramework.Controls.MetroTextBox addr1Textbox = new MetroFramework.Controls.MetroTextBox();
            ssMultipleLoginsPanel.Controls.Add(addr1Textbox);
            addr1Textbox.Location = new System.Drawing.Point(70, 10);
            //addr1Textbox.Name = "address1Textbox";
            addr1Textbox.Size = new System.Drawing.Size(290, 23);
            addr1Textbox.Style = MetroFramework.MetroColorStyle.White;
            addr1Textbox.TabIndex = 4;
            addr1Textbox.Text = "Website address";


        }


    }
}