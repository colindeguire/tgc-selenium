using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC-Selenium.Tests
{
    abstract public class BaseTest
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        protected string baseURL;

        protected IWebDriver driver;

        protected Model.Header header;
        protected Model.Footer footer;
        protected Model.HomePage homePage;
        protected Model.CategoryBrowse categoryBrowse;
        protected Model.ProductDetail productDetail;
        protected Model.ShoppingCart shoppingCart;

        public void Setup()
        {
            baseURL = "http://www.tgcmag.com";

            driver = new FirefoxDriver();

            header = new Model.Header(driver);
            footer = new Model.Footer(driver);
            homePage = new Model.HomePage(driver);
            categoryBrowse = new Model.CategoryBrowse(driver);
            productDetail = new Model.ProductDetail(driver);
            shoppingCart = new Model.ShoppingCart(driver);

            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(0));
            //driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(0));
            driver.Manage().Window.Maximize();

        }

        public void Teardown()
        {
            logger.Info("script finished\t{0}", Environment.TickCount);
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        protected void NavHomePage()
        {
            logger.Info("Requesting home page\t{0}", Environment.TickCount);
            driver.Url = baseURL;
        }

    }
}
