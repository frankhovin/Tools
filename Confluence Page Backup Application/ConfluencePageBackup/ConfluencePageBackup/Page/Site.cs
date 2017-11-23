using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ConfluencePageBackup.Selenium;

namespace ConfluencePageBackup.Page {
    public class Site {
        public void GoTo(string url) {
            GCDriver.Instance.Navigate().GoToUrl(url);
            WaitForSeconds(3);
        }
        public void LogIn (string user, string pass) {
            var userfield = GCDriver.Instance.FindElement(By.Id("os_username"));
            var passfield = GCDriver.Instance.FindElement(By.Id("os_password"));
            var loginbttn = GCDriver.Instance.FindElement(By.Id("loginButton"));

            userfield.SendKeys(user);
            passfield.SendKeys(pass);
            loginbttn.Click();

            WaitForSeconds(3);
        }

        public void GetSpaces () {
            GCDriver.Instance.FindElement(By.Id("space-menu-link")).Click();
            WaitForSeconds(1);
            GCDriver.Instance.FindElement(By.XPath(".//*[@id='view-all-spaces-link']")).Click();
            

            WaitForSeconds(3);
        }

        public void WaitForSeconds(int seconds) {
            GCDriver.Wait(TimeSpan.FromSeconds(seconds));
        }

        public void Close () {
            GCDriver.Close();
        }
    }
}
