using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUniteTest.Helpers.PageElements
{
    class TextBox
    {
        #region Login Page
        public static IWebElement UserName(IWebDriver driver)
        {
            //return driver.FindElement(By.CssSelector("input#email"));
            return driver.FindElement(By.CssSelector("#emailAddress"));

        }

        public static IWebElement Password(IWebDriver driver)
        {
            //return driver.FindElement(By.CssSelector("input#pass"));
            return driver.FindElement(By.CssSelector("#password"));

        }

        #endregion
    }
}