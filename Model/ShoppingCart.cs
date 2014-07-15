using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC-Selenium.Model
{
    public class ShoppingCart : BasePageModel
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ShoppingCart(IWebDriver driver) : base(driver) { }

        public void Checkout()
        {
            By checkoutBtn = By.CssSelector("button.btn-proceed-checkout");
            WaitUntilElementIsPresent(checkoutBtn);

            logger.Info("Clicking 'Checkout'\t{0}", Environment.TickCount);
            driver.FindElement(checkoutBtn).Click();
        }
    }
}
