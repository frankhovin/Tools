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
        string address = "";
        MetroFramework.Controls.MetroTextBox addr1Textbox;

        MetroFramework.Controls.MetroTextBox[] logins;
        MetroFramework.Controls.MetroButton addRowButton,
                                            removeRowButton;

        public MainForm() {
            InitializeComponent();

            //if (Properties.Settings.Default.rowcount == 0) { // Temp removed, to make sure we start fresh when needed.
                Properties.Settings.Default.rowcount = 3;
            //}

            PopulateForm();

        }

        /**
         * Populate form with default/saved values.
         */
        private void PopulateForm() {
            address = Properties.Settings.Default.lasturl;

            // Load the username and password values from the application.settings file:
            /*int y = 0;
            try {
                for (int i = 0; i < Properties.Settings.Default.users.Count / 2; i++) {
                    userPanel.GetControlFromPosition(1, i).Text = Properties.Settings.Default.users[y];
                    y++;
                    userPanel.GetControlFromPosition(2, i).Text = Properties.Settings.Default.users[y];
                    y++;
                }
            }
            catch (NullReferenceException) { }*/

            // Set the staus:
            //SetStatus("Ready");
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
            addr1Textbox.Text = address;
            //
            // usernameLabel
            //
            MetroFramework.Controls.MetroLabel usernameLabel = new MetroFramework.Controls.MetroLabel();
            loginsTable.Controls.Add(usernameLabel);
            //usernameLabel.Location = new System.Drawing.Point(70, 43);
            usernameLabel.Size = new System.Drawing.Size(73, 20);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            MetroFramework.Controls.MetroLabel passwordLabel = new MetroFramework.Controls.MetroLabel();
            loginsTable.Controls.Add(passwordLabel);
            passwordLabel.Size = new System.Drawing.Size(73, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            //
            // showLabel
            //
            MetroFramework.Controls.MetroLabel hideLabel = new MetroFramework.Controls.MetroLabel();
            loginsTable.Controls.Add(hideLabel);
            hideLabel.Size = new System.Drawing.Size(73, 20);
            hideLabel.TabIndex = 4;
            hideLabel.Text = "?";

            // Username/password rows:
            for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.None)});
            }

            // Add the +/- rows buttons:
            AddRowsButtons();

        }

        private void AddRowsButtons () {
            // addRowButton
            addRowButton            = new MetroFramework.Controls.MetroButton();
            loginsTable.Controls.Add(addRowButton);
            addRowButton.Size       = new System.Drawing.Size(20, 20);
            addRowButton.Text       = "+";
            addRowButton.Click      += new System.EventHandler(addRowButton_Click);
            // removeRowButton
            removeRowButton         = new MetroFramework.Controls.MetroButton();
            loginsTable.Controls.Add(removeRowButton);
            removeRowButton.Size    = new System.Drawing.Size(20, 20);
            removeRowButton.Text    = "-";
            removeRowButton.Click   += new System.EventHandler(removeRowButton_Click);
            // Place holder label:
            loginsTable.Controls.Add(new MetroFramework.Controls.MetroLabel());
        }

        private void launchChromeButton_Click (object sender, EventArgs e) {
            string adr = addr1Textbox.Text.ToString();
        }

        private void killChromeButton_Click(object sender, EventArgs e) {

        }

        private void addRowButton_Click(object sender, EventArgs e) {
            loginsTable.RowCount++;

            // First, maybe remove the row with the buttons?

            // Add a new row, up to 6 total:
            if (loginsTable.RowCount < 9) {
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroTextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
                loginsTable.Controls.Add(new MetroFramework.Controls.MetroCheckBox() { Anchor = (AnchorStyles.None) });

            }

            // Update the row count in the settings:
            Properties.Settings.Default.rowcount++;

            // If the number of rows reaches 6, disable the button:
            if (loginsTable.RowCount > 8) {
                addRowButton.Enabled = false;
            }

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            MessageBox.Show(loginsTable.RowCount.ToString());

            loginsTable.RowCount--;
            // Remove the last row (the 3 last controls - , TextBox, TextBox, CheckBox):
            loginsTable.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 1);
            loginsTable.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 2);
            loginsTable.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 3);

            // Update the row count in the settings:
            Properties.Settings.Default.rowcount--;

            // Check if the button should be disabled (the total row count is below 4 - one login row)
            RemoveRowButtonStatusCheck();

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }


        private void RemoveRowButtonStatusCheck () {
            if (loginsTable.RowCount < 4) {
                removeRowButton.Enabled = false;
            }
        }

        /* APPLICATION EXIT */

        /**
         * Handler for performing actions when the application quits.
         */
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                /*SetStatus("Closing and tidying up...");
                try {
                    if (instances.Count > 0)
                        killChromeProcesses();
                }
                catch (NullReferenceException) { }*/
                SaveEntries();
                Dispose(true);
                Application.ExitThread();
            }
            else {
                e.Cancel = true;
            }
        }

        /**
         * Quit confirmation dialog.
         */
        private DialogResult PreClosingConfirmation() {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "Do you want to quit?",
                "Quit Chrome Multiple Logins", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        /**
        * Save the data in the text fields to the application.settings file.
        */
        private void SaveEntries() {
            Properties.Settings.Default.lasturl = addr1Textbox.Text;

            // Clear the existing collection of usernames/passwords:
            // If the users StringCollection exists, just clear it of all contents. If it doesn't exist, create it.
            /*if (Properties.Settings.Default.users != null) {
                Properties.Settings.Default.users.Clear();
            }
            else {
                Properties.Settings.Default.users = new System.Collections.Specialized.StringCollection();
            }*/

            // Save the contents of the username/password rows (including blank entries):
            /*for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                if (Properties.Settings.Default.users != null) {
                    Properties.Settings.Default.users.Add(loginsTable.GetControlFromPosition(0, i).Text);
                    Properties.Settings.Default.users.Add(loginsTable.GetControlFromPosition(1, i).Text);
                }
            }*/

            // For troubleshooting: Show a message box with the state of the users StringCollection (null or not):
            // ShowRowsAndEntries();
            //if (Properties.Settings.Default.users == null)
            //    ShowMessageBox("NULL");
            //if (Properties.Settings.Default.users != null)
            //    ShowMessageBox("NOT NULL");

            // Save the settings file:
            Properties.Settings.Default.Save();
        }

        /**
         * Show the stored row count and number of usernames/passwords in the Properties.Settings.Default file.
         */
        private void ShowRowsAndEntries() {
            //SetStatus("Stored row count: " + Properties.Settings.Default.rowcount.ToString());

            //if (Properties.Settings.Default.users != null)
            //AppendStatus(" Stored u/p count: " + Properties.Settings.Default.users.Count.ToString());
            //else
            //AppendStatus(" No stored u/p");
        }
    }
}
