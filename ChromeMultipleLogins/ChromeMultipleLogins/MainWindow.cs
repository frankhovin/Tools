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
            userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            userPanel.Controls.Add(new Label() { Text = "Login" });
            userPanel.Controls.Add(new TextBox());
            userPanel.Controls.Add(new TextBox());
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            //userPanel.RowCount = userPanel.RowCount - 1;
            // Need to redraw the table.
            //this.Refresh();

        }

        public MainForm() {
            InitializeComponent();

            for (int i = 0; i < userPanel.RowCount; i++) {
                userPanel.Controls.Add(new Label() { Text = "Login"});
                userPanel.Controls.Add(new TextBox());
                userPanel.Controls.Add(new TextBox());
            }

            PopulateForm();
        }

        /**
         * Populate form with default values.
         */
        private void PopulateForm () {
            websiteTextbox.Text = application.Default.urlhistory;   // Load the value from the application.settings file.
        }

        /**
         *  Handle the "Open Chrome" button click.
         *  This spawns a Seleniun process, and then a browser instance,
         *  for each username/password entered.
         */
        private void OpenChromeButton_Click(object sender, EventArgs e) {
            website = websiteTextbox.Text.ToString();
            instances = new ArrayList();

            for (int i = 0; i < userPanel.RowCount * userPanel.RowCount-1; i++) {
                try {
                    if (!string.IsNullOrWhiteSpace(userPanel.GetControlFromPosition(1, i).Text)) {
                        instances.Add(new GCDriver(websiteTextbox.Text.ToString()));
                        SiteLogin.AuthWindow.LoginUser(userPanel.GetControlFromPosition(1, i).Text.ToString(),
                                                       userPanel.GetControlFromPosition(2, i).Text.ToString());
                    }
                } catch (NullReferenceException nre) {
                    Console.Write(nre.StackTrace);
                }
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
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                killChromeProcesses();

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
        private void SaveEntries () {
            application.Default.urlhistory = websiteTextbox.Text;
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
