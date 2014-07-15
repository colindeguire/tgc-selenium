using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Model
{
    public class ProductDetail : BasePageModel
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ProductDetail(IWebDriver driver) : base(driver) { }

        public void ChooseFormatDVD()
        {

            WaitUntilElementIsPresent(By.CssSelector("h1.product-name"));

            logger.Info("PDP: waiting for format options\t{0}", Environment.TickCount);
            WaitUntilElementIsPresent(By.CssSelector("input[name='media-format-radio']"));

            logger.Info("PDP: clicking DVD format\t{0}", Environment.TickCount);
            driver.FindElement(By.CssSelector("label[for='12']")).Click();
        }

        public void AddToCart()
        {
            By addToCartBtn = By.CssSelector("button#add-to-cart-btn");
            WaitUntilElementIsPresent(addToCartBtn);

            logger.Info("PDP: clicking 'Add To Cart'\t{0}", Environment.TickCount);
            driver.FindElement(addToCartBtn).Click();

            logger.Info("Waiting for mini-cart to update\t{0}", Environment.TickCount);
            WaitUntilElementIsPresent(By.CssSelector("div.mini-cart-js.highLighted"));
        }
    }
}
