/**
 * Author: Frank H.
 */
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace ChromeMultipleInstances.Selenium {
    public class GCDriver {
        public static IWebDriver Instance { get; set; }

        public static void Initialize() {
            var driverService = ChromeDriverService.CreateDefaultService();     // Create a ChromeDriverService for specifying options to the ChromeDriver.
            driverService.HideCommandPromptWindow = true;                       // Set the option to hide the command prompt window to true.
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("headless", "disable-gpu", "remote-debugging-port=9222", "window-size=1440,900", "disable-infobars", "--disable-extensions");

            Instance = new ChromeDriver(driverService/*, new ChromeOptions()options*/);    // Include the ChromeDriverService and options when creating the driver instance.
        }


        /**
         *  Set a cookie. Name and value.
         */
        public static void SetCookie(string cname, string cvalue) {
            Cookie c = new Cookie(cname, cvalue);
            Instance.Manage().Cookies.AddCookie(c);
        }

        /**
         *  Get the value of a specific cookie.
         */
        public static string GetCookieValue(string cname) {
            return Instance.Manage().Cookies.AllCookies.Any(c => c.Name.Equals(cname, StringComparison.OrdinalIgnoreCase)).ToString();
        }

        /**
         *  Explicit wait. Used via the Navigation -> Wait class.
         */
        public static void Wait(TimeSpan timeSpan) {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }
    }
}