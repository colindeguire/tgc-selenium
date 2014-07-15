using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC-Selenium.Model
{
    public class Header : BasePageModel
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Header(IWebDriver driver) : base(driver) { }

        public void clickMainLogo()
        {
            driver.FindElement(By.CssSelector("div.logo-wrapper")).Click();
        }

        public void clickCoursesLink()
        {
            By allCoursesLink = By.CssSelector("a.nav-text-link");
            WaitUntilElementIsPresent(allCoursesLink);

            logger.Info("Clicking \"Courses\"\t{0}", Environment.TickCount);
            driver.FindElement(allCoursesLink).Click();
        }

        public void ViewCart()
        {
            By viewCart = By.CssSelector("div#mini-cart a.nav-text-link");
            WaitUntilElementIsPresent(viewCart);

            logger.Info("View Cart\t{0}", Environment.TickCount);
            driver.FindElement(viewCart).Click();
        }
    }
}
