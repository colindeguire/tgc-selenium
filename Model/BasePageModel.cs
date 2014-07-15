using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TGC-Selenium.Model
{
    abstract public class BasePageModel
    {
        protected IWebDriver driver;

        public BasePageModel(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool WaitUntilElementIsPresent(By by, int timeout = 20)
        {
            for (var i = 0; i < timeout; i++)
            {
                if (driver.FindElements(by).Count > 0) return true;
                Thread.Sleep(200);
            }
            return false;
        }
    }
}
