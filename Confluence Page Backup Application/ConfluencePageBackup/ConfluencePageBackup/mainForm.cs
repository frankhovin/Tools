using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfluencePageBackup.Validators;
using ConfluencePageBackup.OS;
using ConfluencePageBackup.Page;

namespace ConfluencePageBackup {
    public partial class mainForm : Form {
        private string  browser,
                        confluenceurl,
                        username,
                        password;
        Site site = new Site();

        public mainForm () {
            InitializeComponent();

            PopulateBrowserList();

            //
            browserComboBox.Text = "Google Chrome";
            urlTextBox.Text = "http://ræva.no:8090";
            usernameBox.Text = "frank";
            passwordBox.Text = "vriceI29!";
            //
        }

        /**
         * Populate the combobox with the browsers installed on the system:
         */
        public void PopulateBrowserList () {
            BrowserInfo t_bi = new BrowserInfo();

            // Get the list of installed browsers:
            var dataSource = t_bi.GetInstalledBrowsers();
            //Setup data binding:
            this.browserComboBox.DataSource = dataSource;
            // Make it readonly:

            this.browserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void goButton_Click (object sender, EventArgs e) {
            bottomStatusLabel.Text = "";

            // FIND THE EMPTY FIELDS:
            List<string> empties = new List<string>();

            foreach (Control c in this.Controls) {
                if (c is TextBox) {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty) {
                        empties.Add(textBox.Name.ToString());
                    }
                } else if (c is ComboBox) {
                    ComboBox comboBox = c as ComboBox;
                    if (comboBox.Text == string.Empty) {
                        empties.Add(comboBox.Name.ToString());
                    }
                }
            }
           
            //foreach (var item in empties)
            //    Console.Write(item + ", ");

            if (browserComboBox.Text == string.Empty ||
                urlTextBox.Text == string.Empty ||
                usernameBox.Text == string.Empty ||
                passwordBox.Text == string.Empty) {
                    SetBottomStatus("Missing information. Please insert all information.");
            } else  if (UrlValidator.IsValid(urlTextBox.Text)) {
                // Hent browser, url, brukernavn og passord:
                browser        = browserComboBox.Text;
                confluenceurl  = urlTextBox.Text;
                username       = usernameBox.Text;
                password       = passwordBox.Text;

                if (browser.Contains("Opera")) {
                    SetBottomStatus("Opera is not yet supported. Please select a different browser.");
                } else if (browser.Contains("FIREFOX")) {
                    SetBottomStatus("Firefox is not yet supported. Please select a different browser.");
                } else if (browser.Contains("IEXPLORE")) {
                    SetBottomStatus("Internet Explorer is not yet supported. Please select a different browser.");
                } else if (browser.Contains("Chrome")) {
                    // KJØR SELENIUM!
                    SetBottomStatus("Klar");
                    Selenium.GCDriver.Initialize();
                    site.GoTo(confluenceurl);
                    site.LogIn(username, password);
                    site.GetSpaces();

                    
                    site.Close();

                }
            } else {
                SetBottomStatus("Invalid or malformed URL.Please enter a valid URL.");
            }

        }

        private void browserComboBox_SelectedIndexChanged (object sender, EventArgs e) {
            

        }

        private void urlTextBox_TextChanged (object sender, EventArgs e) {

        }

        /**
         * Post a string to the bottom status bar.
         */
        public void SetBottomStatus (string status) {
            bottomStatusLabel.Text = status;
        }

        /*
         * Methods for reporting on the status of the information fields.
         * Returns false and sets an error message in the bottom bar if information is missing.
         * Else they return true.
         **/

        /*private bool browserInfoPresent () {
            if (browserComboBox.Text.Equals("")) {
                bottomStatusLabel.Text = "No browser selected. Please select a browser from the dropdown list.";
                return false;
            } else {
                browser = browserComboBox.Text;
                return true;
            }
        }*/

        /*private bool urlInfoPresent() {
            if (urlTextBox.Text.Equals("")) {
                bottomStatusLabel.Text = "Missing URL. Please insert an url in the URL field.";
                return false;
            }
            else {
                confluenceurl = urlTextBox.Text;
                return true;
            }
        }*/

        /*private bool usernameInfoPresent () {
            if (usernameBox.Text.Equals("")) {
                bottomStatusLabel.Text = "Missing username. Please insert a valid username.";
                return false;
            } else {
                username = usernameBox.Text;
                return true;
            }            
        }*/



    }

   
}
