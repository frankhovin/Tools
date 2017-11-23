using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfluencePageBackup.OS;
using ConfluencePageBackup.Page;
using ConfluencePageBackup.Selenium;
using ConfluencePageBackup.Validators;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTests {
    [TestClass]
    public class UnitTests {
        [TestMethod]
        public void Verify_retrieved_browsers_info () {
            BrowserInfo t_bi = new BrowserInfo();
            //System.String[] t_browsers = t_bi.GetInstalledBrowsers();
            List<string> t_browsers= t_bi.GetInstalledBrowsers();

            foreach (var values in t_browsers)
                Console.WriteLine(values);


        }

        [TestMethod]
        public void Verify_url_valid () {
            string validurl = "www.nrk.no";

            Assert.IsTrue(UrlValidator.IsValid(validurl), "Error: " + validurl + " is not a valid URL.");
        }

        [TestMethod]
        public void Verify_url_invalid () {
            string validurl = "http://www.nrk.no...";

            Assert.IsFalse(UrlValidator.IsValid(validurl), "Error: " + validurl + "");
        }

        [TestMethod]
        public void Verify_get_spaces_list () {
            GCDriver.Initialize();
            Site tsite = new Site();
            tsite.GoTo("http://ræva.no:8090");
            tsite.LogIn("frank", "vriceI29!");
            tsite.GoTo("http://ræva.no:8090/rest/api/space");

            GCDriver.Close();
        }

        [TestMethod]
        public void Verify_get_spaces_pages () {
            

        }
    }
}
