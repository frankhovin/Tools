/**
 * Author: Frank H.
 */
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConfluencePageBackup.Selenium {
    public class GCDriver {
        public static IWebDriver Instance { get; set; }

        public static void Initialize() {
            var driverService = ChromeDriverService.CreateDefaultService();     // Create a ChromeDriverService for specifying options to the ChromeDriver.
            driverService.HideCommandPromptWindow = true;                       // Set the option to hide the command prompt window to true.

            Instance = new ChromeDriver(driverService, new ChromeOptions());    // Include the ChromeDriverService and options when creating the driver instance.
        }
                
        public static void Wait(TimeSpan timeSpan) {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        public static void WaitForVisible(string xpath) {
            var wait = new WebDriverWait(GCDriver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(xpath)).Displayed);
        }

        public static void Close() {
            Instance.Quit();
        }
    }
}
