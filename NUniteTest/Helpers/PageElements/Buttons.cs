using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUniteTest.Helpers.PageElements
{
    class Buttons
    {
        public static IWebElement LoginButton(IWebDriver driver)
        {
            //return driver.FindElement(By.XPath("//*[@id='loginbutton']"));
            return driver.FindElement(By.CssSelector("form#loginForm button[type='submit']"));

        }

        public static IWebElement Apply(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("# header > div > div:nth-child(3) > ul > li:nth-child(1) > form > button"));
        }




    }
}
