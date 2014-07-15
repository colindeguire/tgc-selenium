using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TGC-Selenium.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.tgcmag.com/courses/science/our-night-sky.html";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
            IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
            {
                return d.FindElement(By.Id("root-wrapper"));
            });
            Console.WriteLine(myDynamicElement.TagName);
            driver.Quit();
        }
    }
}
