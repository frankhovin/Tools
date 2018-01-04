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

        /*private void websiteTextbox_TextChanged(object sender, EventArgs e) {

        }

        private void MainForm_Load(object sender, EventArgs e) {

        }*/

        private void addRowButton_Click(object sender, EventArgs e) {
            userPanel.RowCount = userPanel.RowCount + 1;

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

            //toolStripStatusLabel.Text = userPanel.RowCount.ToString();
            //toolStripStatusLabel.Text = userPanel.Controls.Count.ToString();
            //toolStripStatusLabel.Text = userPanel.GetType().ToString();
            //toolStripStatusLabel.Text = userPanel.GetControlFromPosition(2, 0).Text;
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            //userPanel.RowCount = userPanel.RowCount - 1;
            // Need to redraw the table.
            //this.Refresh();

        }

        public MainForm() {
            InitializeComponent();

            // This works; The string is added to application.Default.usernames.Add.
            // However, it's not saved to the settings (the application.Default.Save in OnFormClosing->SaveEntries).
            // (Tested by removing the .Add( line - if it's saved, it should be there on the next run when the .Add is not run.

            //application.Default.usernames = new System.Collections.Specialized.StringCollection();
            //application.Default.usernames.Add("First user 4");
            //application.Default.usernames.Clear();

            toolStripStatusLabel.Text = application.Default.usernames.Count.ToString();
            toolStripStatusLabel.Text = userPanel.RowCount.ToString();
            //toolStripStatusLabel.Text = application.Default.usernames[0];

            // Create the initial rows of username/password:
            for (int i = 0; i < userPanel.RowCount; i++) {
                userPanel.Controls.Add(new Label() { Text = "Login"});
                userPanel.Controls.Add(new TextBox() /*{ Text = application.Default.username1 }*/);
                userPanel.Controls.Add(new TextBox() /*{ Text = application.Default.password1 }*/);
            }

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
            for (int i = 0; i < application.Default.usernames.Count / 2; i++) {
                userPanel.GetControlFromPosition(1, i).Text = application.Default.usernames[y];
                y++;
                userPanel.GetControlFromPosition(2, i).Text = application.Default.usernames[y];
                y++;
            }

            toolStripStatusLabel.Text = application.Default.usernames.Count.ToString();

            /*try {
                toolStripStatusLabel.Text = toolStripStatusLabel.Text + " " +
                                            application.Default.usernames[0] + " " +
                                            application.Default.usernames[1] + " " +
                                            application.Default.usernames[2] + " " +
                                            application.Default.usernames[3] + " " +
                                            application.Default.usernames[4] + " " +
                                            application.Default.usernames[5];
            }
            catch (ArgumentOutOfRangeException) { }*/
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

            // Save the first 3 rows of username/password (INCLUDING blank entries):
            for (int i = 0; i < 3; i++) {
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
    }
}
