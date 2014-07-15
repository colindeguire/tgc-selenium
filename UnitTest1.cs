using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TGC-Selenium
{
    [TestClass]
    public class UnitTest1
    {

        private IWebDriver driver;
        private string baseURL;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.tgcmag.com";
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
        }
    }
}
