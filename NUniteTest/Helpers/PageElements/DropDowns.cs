using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUniteTest.Helpers.PageElements
{
    class DropDowns
    {
        public static IWebElement selectBranch(IWebDriver driver)

        {
            return driver.FindElement(By.CssSelector("#header > div > div:nth-child(3) > ul > li:nth-child(1) > form > div:nth-child(2) > div"));
        }

        public static IWebElement selectInvoice(IWebDriver driver)

        {
            return driver.FindElement(By.CssSelector("#top-menu > ul > li.has-sub.active"));
        }







    }
}
