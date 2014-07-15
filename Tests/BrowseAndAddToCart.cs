using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using NLog;

namespace TGC-Selenium.Tests
{
    public class BrowseAndAddToCart : BaseTest
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            new BrowseAndAddToCart();
        }

        public BrowseAndAddToCart()
        {
            Setup();

            logger.Info("Browse And Add To Cart\t{0}", Environment.TickCount);

            NavHomePage();

            header.clickCoursesLink();
            categoryBrowse.ClickProductImage(7);
            productDetail.ChooseFormatDVD();
            productDetail.AddToCart();
            header.ViewCart();
            shoppingCart.Checkout();

            Teardown();
        }
    }
}
