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
    public class CategoryBrowse : BasePageModel
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public CategoryBrowse(IWebDriver driver) : base(driver) { }

        public void ClickProductImage(int productNum)
        {
            By prodImage = By.CssSelector("div.category-products li:nth-child(" + productNum + ") span.product-image");
            WaitUntilElementIsPresent(prodImage);

            logger.Info("Clicking product image\t{0}", Environment.TickCount);
            driver.FindElement(prodImage).Click();
        }
    }
}
