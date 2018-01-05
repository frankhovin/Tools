using System;
using System.Windows.Forms;
//using Selenium;
//using ChromeMultipleLogins.Properties;
//using WindowsOperations.Authentication;
using System.Diagnostics;
using System.Collections;

namespace ChromeMullog {
    public partial class MainForm : Form {
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

            //toolStripStatusLabel.Text = "FAEN!";
            toolStripStatusLabel.Text = "Stored row count: " + Properties.Settings.Default.rowcount.ToString();
            // DETTE VISER INGENTING, FORDI DET IKKE BLIR LAGRET NOE I users NÅR SaveEntries() KJØRER!
            if (Properties.Settings.Default.users != null)
                toolStripStatusLabel.Text += "Stored u/p count: " + Properties.Settings.Default.users.Count.ToString();

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
        }





        private void killChromeProcesses() {

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

            // For troubleshooting: Show a message box with the state of the users StringCollection (null or not):
            /*String usersstatus = "";
            if (Properties.Settings.Default.users == null)
                usersstatus = "NULL";
            if (Properties.Settings.Default.users != null)
                usersstatus = "IKKE NULL";
            MessageBox.Show(usersstatus);*/

            // Save the contents of the username/password rows (including blank entries):
            // SER UT TIL AT IKKE Properties.Settings.Default.users ER INITIALISERT? MULIG DERFOR DET FEILER MED NullReferenceException HER:
            // ER DET EN IDÉ Å GI Properties.Settings.Default.users EN DEFAULT VERDI? I SÅFALL, HVORDAN? PÅ SAMME MÅTE SOM ROWCOUNT?
            // DET FUNGERER IKKE Å LAGRE NOE I users!
            //for (int i = 0; i < userPanel.RowCount; i++) {
            for (int i = 0; i < Properties.Settings.Default.rowcount; i++) {
                if (Properties.Settings.Default.users != null) {
                    Properties.Settings.Default.users.Add(userPanel.GetControlFromPosition(1, i).Text);
                    Properties.Settings.Default.users.Add(userPanel.GetControlFromPosition(2, i).Text);
                }
            }



            // Save the settings file:
            Properties.Settings.Default.Save();
        }
    }
}
