/**
 * Author: Frank H.
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ChromeMullog.Selenium {
    public class GCDriver {
        IWebDriver driver;
        public GCDriver(string url) {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            try {
                driver = new ChromeDriver(driverService, new ChromeOptions());
            }
            //catch (NullReferenceException) { }
            //catch (System.Net.Sockets.SocketException) { }
            catch (Exception ex) {
                if (ex is NullReferenceException || ex is System.Net.Sockets.SocketException || ex is OpenQA.Selenium.WebDriverException) {
                    return;
                }
                throw;
            }

            driver.Navigate().GoToUrl(url);
        }

        /**
         *  Open an URL address.
         */
        public void OpenUrl(string url) {
            driver.Navigate().GoToUrl(url);
        }

        /**
         *  Close/quit the chromedriver.
         */
        public void Close() {
            try {
                driver.Quit();
            } catch (OpenQA.Selenium.WebDriverException) { }
        }
    }
}