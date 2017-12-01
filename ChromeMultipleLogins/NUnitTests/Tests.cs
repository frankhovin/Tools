using System;
using System.Windows.Forms;
using NUnit.Extensions.Forms;   // NuGet: NUnitForms.Framework.
using ChromeMultipleLogins;

namespace NUnitTests {
    //[TestFixture]
    public class Tests {
        [TestMethod]
        public void TestMethod1 () {
            Form mainform = new Form();
            mainform.Show();

            ButtonTester openChromeButton = new ButtonTester("buttonName");

        }
    }
}