/**
 *  Created by Frank Høvin.
 *
 *  Fucked solution. In Debug, it complains about NullReferenceException every time
 *  application.settings.Default.usernames is accessed. In Release, it works like before.
 */
using System;
using System.Windows.Forms;
using Selenium;
using ChromeMultipleLogins.Properties;
using WindowsOperations.Authentication;
using System.Diagnostics;
using System.Collections;

namespace ChromeMultipleLogins {
    public partial class MainForm : Form {
        string website;
        ArrayList instances;

        /*private void websiteTextbox_TextChanged (object sender, EventArgs e) {

        }

        private void MainForm_Load (object sender, EventArgs e) {

        }*/

        private void addRowButton_Click(object sender, EventArgs e) {
            userPanel.RowCount = userPanel.RowCount + 1;
            application.Default.rowcount++;

            // Add a new row, up to 6 total:
            if (userPanel.RowCount < 7) {
                userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                userPanel.Controls.Add(new Label() { Text = "Login" });
                userPanel.Controls.Add(new TextBox());
                userPanel.Controls.Add(new TextBox());
            }

            // If the number of rows reaches 6, disable the button:
            if (userPanel.RowCount > 5) {
                addRowButton.Enabled = false;
            }

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            ShowRowsAndEntries();
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            // Remove the last row (the 3 last controls - Label, TextBox, TextBox):
            userPanel.Controls.RemoveAt(application.Default.rowcount * 3 - 1);
            userPanel.Controls.RemoveAt(application.Default.rowcount * 3 - 2);
            userPanel.Controls.RemoveAt(application.Default.rowcount * 3 - 3);

            // Update the row count in the settings:
            application.Default.rowcount--;

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            ShowRowsAndEntries();
        }

        public MainForm() {
            InitializeComponent();

            // Get the row count from the application.settings file and create the saved number of rows:

            for (int i = 0; i < application.Default.rowcount; i++) {
                userPanel.Controls.Add(new Label() { Text = "Login" });
                userPanel.Controls.Add(new TextBox());
                userPanel.Controls.Add(new TextBox());
            }

            // For troubleshooting: Show the saved usernames/passwords and the saved number of rows on startup:
            toolStripStatusLabel.Text = "u/p count: " + application.Default.usernames.Count.ToString() + ", " +
                                        "rows: " + application.Default.rowcount;

            PopulateForm();
        }

        /**
         * Populate form with default values.
         */
        private void PopulateForm() {
            // Load the url value from the application.settings file:
            websiteTextbox.Text = application.Default.urlhistory;
            // Load the username and password values from the application.settings file:
            int y = 0;
            try {
                for (int i = 0; i < application.Default.usernames.Count / 2; i++) {
                    userPanel.GetControlFromPosition(1, i).Text = application.Default.usernames[y];
                    y++;
                    userPanel.GetControlFromPosition(2, i).Text = application.Default.usernames[y];
                    y++;
                }
            } catch (NullReferenceException) { }
        }

        /**
         *  Handle the "Open Chrome" button click.
         *  This spawns a Seleniun process, and then a browser instance,
         *  for each username/password entered.
         */
        private void OpenChromeButton_Click (object sender, EventArgs e) {
            website = websiteTextbox.Text.ToString();
            instances = new ArrayList();

            for (int i = 0; i < userPanel.RowCount * userPanel.RowCount-1; i++) {
                try {
                    if (!string.IsNullOrWhiteSpace(userPanel.GetControlFromPosition(1, i).Text)) {
                        instances.Add(new GCDriver(websiteTextbox.Text.ToString()));
                        SiteLogin.AuthWindow.LoginUser(userPanel.GetControlFromPosition(1, i).Text.ToString(),
                                                       userPanel.GetControlFromPosition(2, i).Text.ToString());
                    }
                } catch (NullReferenceException) { }
            }
        }

        /**
         *  Kill all the Chrome processes.
         */
        private void killButton_Click(object sender, EventArgs e) {
            killChromeProcesses();
        }

        private void killChromeProcesses () {
            if (instances != null) {
                foreach (GCDriver instance in instances) {
                    instance.Close();
                }
            }
        }

        /**
         * Handler for performing actions when the application quits.
         */
        protected override void OnFormClosing (FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                killChromeProcesses();
                SaveEntries();
                Dispose(true);
                Application.Exit();
            }
            else {
                e.Cancel = true;
            }
        }

        /**
         * Save the data in the text fields to the application.settings file.
         */
        private void SaveEntries() {
            // Save the contents of the URL box:
            application.Default.urlhistory = websiteTextbox.Text;

            // Clear the existing collection of usernames/passwords:
            application.Default.usernames.Clear();

            // Save the contents of the username/password rows (including blank entries):
            for (int i = 0; i < application.Default.rowcount; i++) {
                application.Default.usernames.Add(userPanel.GetControlFromPosition(1, i).Text);
                application.Default.usernames.Add(userPanel.GetControlFromPosition(2, i).Text);
            }

            application.Default.Save();
        }

        /**
         * Quit confirmation dialog.
         */
        private DialogResult PreClosingConfirmation () {
            DialogResult res = System.Windows.Forms.MessageBox.Show(
                "Do you want to quit?",
                "Quit Chrome Multiple Logins", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        /**
         *  For troubleshooting:
         *  Show the number of saved user/pass entries and row count
         *  (from the application.settings file).
         */
        private void ShowRowsAndEntries () {
            toolStripStatusLabel.Text = "u/p count: " + application.Default.usernames.Count.ToString() + ", " +
                                        "rows: " + application.Default.rowcount;
        }
    }
}