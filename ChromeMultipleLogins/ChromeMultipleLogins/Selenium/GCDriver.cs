/**
 * Author: Frank H.
 */
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

using System.Linq;

namespace Selenium {
    public class GCDriver {
        IWebDriver driver;
        public GCDriver (string url) {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions());
            driver.Navigate().GoToUrl(url);
        }

        public void OpenUrl (string url) {
            driver.Navigate().GoToUrl(url);
        }

        /**
         *  Close/quit the chromedriver.
         */
        public void Close() {
            driver.Quit();
        }
    }
}
