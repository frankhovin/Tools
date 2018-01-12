using System;
using System.Windows.Forms;
using System.Collections;
using ChromeMullog.Selenium;
using WindowsOperations.Authentication;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace ChromeMullog {
    public partial class MainForm : Form {
        string      website;
        ArrayList   instances;
        private     BackgroundWorker wrk;

        public MainForm() {
            InitializeComponent();

            if (Properties.Settings.Default.rowcount == 0) {
                Properties.Settings.Default.rowcount = 3;
            }
            for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                userPanel.Controls.Add(new Label() { Text = "Login", TextAlign = System.Drawing.ContentAlignment.MiddleLeft });
                userPanel.Controls.Add(new TextBox() { Anchor = (AnchorStyles.Left | AnchorStyles.Right) });
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

            // Set the staus:
            SetStatus("Ready");
        }

        /**
         * Handler for performing actions when the application quits.
         */
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                try {
                    if (instances.Count > 0)
                        killChromeProcesses();
                } catch (NullReferenceException) { } // DOESN'T SEEM TO HELP ON THE SLOW QUIT AFTER KILLING ChromeDriver manually.
                SaveEntries();
                Dispose(true);
                //Environment.Exit(0);
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
            // Add the contents of the url text box to the settings file (replacing the existing value):
            Properties.Settings.Default.lasturl = websiteTextBox.Text;

            // Clear the existing collection of usernames/passwords:
            // If the users StringCollection exists, just clear it of all contents. If it doesn't exist, create it.
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

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
            Form aboutform;
            aboutform = new AboutForm();
            aboutform.ShowDialog(this);
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
            SetStatus("Spawning ChromeDriver...");

            this.wrk = new BackgroundWorker();
            this.wrk.DoWork += new DoWorkEventHandler(/*wrk_DoWork*/SpawnChromeDriver);
            this.wrk.ProgressChanged += new ProgressChangedEventHandler(SpawnChromeDriver_ProgressChanged);
            this.wrk.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SpawnChromeDriver_Completed);
            this.wrk.WorkerReportsProgress = true;
            this.wrk.RunWorkerAsync();

        }

        /**
         *  Method to detect when the progress of the thread spawning the ChromeDriver instances is changed.
         */
        private void SpawnChromeDriver_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            // NOT IN USE
        }

        /**
         *  Method to detect when the thread spawning the ChromeDriver instances is completed.
         *  Updates the status bar with the number of instances created.
         */
        private void SpawnChromeDriver_Completed (object sender, RunWorkerCompletedEventArgs e) {
            SetStatus(e.Result.ToString() + " ChromeDriver instances created");
        }

        /**
         *  Start the ChromeDriver processes which spawn Chrome, navigates to the URL and logs in.
         *
         *  Returns an int with the number of ChromeDriver processes started.
         */
        private void SpawnChromeDriver(object sender, DoWorkEventArgs e) {
            BackgroundWorker work = (BackgroundWorker)sender;
            website = websiteTextBox.Text.ToString();
            instances = new ArrayList();

            //for (int i = 0; i < userPanel.RowCount * userPanel.RowCount - 1; i++) {
            // REPLACING THE ABOVEWITH THE ONE BELOW REMOVES THE NullReferenceException WHEN SPAWNING THE ChromeDriver(s).
            // I HAVE NO IDEA WHY I CHECKED AGAINST "userPanel.RowCount * userPanel.RowCount - 1" INSTEAD OF JUST "userPanel.RowCount - 1"
            for (int i = 0; i < userPanel.RowCount - 1; i++) {
                try {
                    if (!string.IsNullOrWhiteSpace(userPanel.GetControlFromPosition(1, i).Text)) {
                        instances.Add(new GCDriver(websiteTextBox.Text.ToString()));
                        SiteLogin.AuthWindow.LoginUser(userPanel.GetControlFromPosition(1, i).Text.ToString(),
                                                       userPanel.GetControlFromPosition(2, i).Text.ToString());
                    }
                }
                catch (NullReferenceException) { }
            }

            e.Result = instances.Count;
        }

        private void killButton_Click(object sender, EventArgs e) {
            killChromeProcesses();
            SetStatus(instances.Count + " open ChromeDriver instances killed.");
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
