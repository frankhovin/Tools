using System;
using System.Windows.Forms;
using System.Collections;
using ChromeMullog.Selenium;
using WindowsOperations.Authentication;

namespace ChromeMullog {
    public partial class MainForm : Form {
        string      website;
        ArrayList   instances;

        public MainForm() {
            InitializeComponent();

            if (Properties.Settings.Default.rowcount == 0) {
                Properties.Settings.Default.rowcount = 3;
            }
            for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                userPanel.Controls.Add(new Label() { Text = "Login" });
                userPanel.Controls.Add(new TextBox());
                userPanel.Controls.Add(new TextBox());
            }

            // For troubleshooting:
            //ShowRowsAndEntries();

            PopulateForm();
        }

        /**
         * Populate form with default values.
         */
        private void PopulateForm() {
            // Clear the staus bar:
            SetStatus("");

            // Load the url value from the application.settings file:
            websiteTextBox.Text = Properties.Settings.Default.lasturl;

            // Load the username and password values from the application.settings file:
            int y = 0;
            try {
                for (int i = 0; i < Properties.Settings.Default.users.Count / 2; i++) {
                    userPanel.GetControlFromPosition(1, i).Text = Properties.Settings.Default.users[y];
                    y++;
                    userPanel.GetControlFromPosition(2, i).Text = Properties.Settings.Default.users[y];
                    y++;
                }
            } catch (NullReferenceException) { }
        }

        /**
         * Handler for performing actions when the application quits.
         */
        protected override void OnFormClosing(FormClosingEventArgs e) {
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
            // Add the contents of the url text box to the settings file (replacing the existing value):
            Properties.Settings.Default.lasturl = websiteTextBox.Text;

            // Clear the existing collection of usernames/passwords:
            // If the users StringCollection exists, just clear it of all contents.
            // If it doesn't exist, create it.
            if (Properties.Settings.Default.users != null) {
                Properties.Settings.Default.users.Clear();
            } else {
                Properties.Settings.Default.users = new System.Collections.Specialized.StringCollection();
            }

            // Save the contents of the username/password rows (including blank entries):
            for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                if (Properties.Settings.Default.users != null) {
                    Properties.Settings.Default.users.Add(userPanel.GetControlFromPosition(1, i).Text);
                    Properties.Settings.Default.users.Add(userPanel.GetControlFromPosition(2, i).Text);
                }
            }

            // For troubleshooting: Show a message box with the state of the users StringCollection (null or not):
            ShowRowsAndEntries();
            //if (Properties.Settings.Default.users == null)
            //    ShowMessageBox("NULL");
            //if (Properties.Settings.Default.users != null)
            //    ShowMessageBox("NOT NULL");

            // Save the settings file:
            Properties.Settings.Default.Save();
        }

        private void addRowButton_Click(object sender, EventArgs e) {
            userPanel.RowCount++;

            // Add a new row, up to 6 total:
            if (userPanel.RowCount < 7) {
                userPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                userPanel.Controls.Add(new Label() { Text = "Login" });
                userPanel.Controls.Add(new TextBox());
                userPanel.Controls.Add(new TextBox());
            }

            // Update the row count in the settings:
            Properties.Settings.Default.rowcount++;

            // If the number of rows reaches 6, disable the button:
            if (userPanel.RowCount > 5) {
                addRowButton.Enabled = false;
            }

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }

        private void removeRowButton_Click(object sender, EventArgs e) {
            userPanel.RowCount--;
            // Remove the last row (the 3 last controls - Label, TextBox, TextBox):
            userPanel.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 1);
            userPanel.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 2);
            userPanel.Controls.RemoveAt(Properties.Settings.Default.rowcount * 3 - 3);

            // Update the row count in the settings:
            Properties.Settings.Default.rowcount--;

            // For troubleshooting: Show the saved usernames/passwords (from the last startup) and the new number of rows:
            //ShowRowsAndEntries();
        }

        private void openChromeButton_Click(object sender, EventArgs e) {
            website = websiteTextBox.Text.ToString();
            instances = new ArrayList();

            for (int i = 0; i < userPanel.RowCount * userPanel.RowCount - 1; i++) {
                try {
                    if (!string.IsNullOrWhiteSpace(userPanel.GetControlFromPosition(1, i).Text)) {
                        instances.Add(new GCDriver(websiteTextBox.Text.ToString()));
                        SiteLogin.AuthWindow.LoginUser(userPanel.GetControlFromPosition(1, i).Text.ToString(),
                                                       userPanel.GetControlFromPosition(2, i).Text.ToString());
                    }
                }
                catch (NullReferenceException) { }
            }

            SetStatus(instances.Count + " chromedriver.exe processes started.");
        }

        private void killButton_Click(object sender, EventArgs e) {
            killChromeProcesses();

            SetStatus("Open chromedriver.exe processes killed.");
        }

        private void killChromeProcesses() {
            if (instances != null) {
                foreach (GCDriver instance in instances) {
                    instance.Close();
                }
            }
        }

        /**
         * Show the stored row count and number of usernames/passwords in the Properties.Settings.Default file.
         */
        private void ShowRowsAndEntries () {
            SetStatus("Stored row count: " + Properties.Settings.Default.rowcount.ToString());

            if (Properties.Settings.Default.users != null)
                AppendStatus(" Stored u/p count: " + Properties.Settings.Default.users.Count.ToString());
            else
                AppendStatus(" No stored u/p");
        }

        /**
         *  Show a message on the status strip.
         */
        private void SetStatus (string text) {
            toolStripStatusLabel.Text = text;
        }

        /**
         *  Append a message to the status strip.
         */
        private void AppendStatus (string text) {
            toolStripStatusLabel.Text += text;
        }

        /* Show a message box: */
        private void ShowMessageBox (string message) {
            MessageBox.Show(message);
        }
    }
}
