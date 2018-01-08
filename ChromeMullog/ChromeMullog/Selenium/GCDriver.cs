/**
 * Author: Frank H.
 */
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ChromeMullog.Selenium {
    public class GCDriver {
        IWebDriver driver;
        public GCDriver(string url) {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverService, new ChromeOptions());
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
            driver.Quit();
        }
    }
}