using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUniteTest.Helpers.Primitives;
using NUniteTest.Helpers.PageElements;
using System.Threading;
using NUnit.Framework;

namespace NUniteTest.Tests
{
    public abstract class Base
    {
        #region Fields

        protected static IWebDriver driver;

        #endregion

        [SetUp]
        public void Init()
        {
            // Establish the webdriver 
            var driverservice = ChromeDriverService.CreateDefaultService(@"D:\Abhinav\");

            driverservice.HideCommandPromptWindow = true;

            driver = new ChromeDriver(driverservice, new ChromeOptions());

            //Go to the login url
            driver.Navigate().GoToUrl(Links.AppUrl);

            driver.Manage().Window.Maximize();

            Wait(5);
        }

        

        /// <summary>
        /// This runs once before any other tests are run
        /// </summary>
        /// 

        [TearDown]
        public void TeaerDown()
        {
            try
            {
                driver.Close();
                driver.Quit();
            }
            catch
            {

            }
        }

        /// <summary>
        /// This runs after all tests have been completed
        /// </summary>

        #region Login

        public void Login(string UserName, string Password)
        {

            //Authenticate--------
            //Enter credentials and login
            TextBox.UserName(driver).SendKeys(UserName);

            TextBox.Password(driver).SendKeys(Password);

            Click(Buttons.LoginButton(driver));
        }

        #endregion

        public static void Click(IWebElement WebElement)
        {
            try
            {
                WebElement.Click();
            }
            catch (TimeoutException e)
            {
                e.GetBaseException();
            }
        }

        public static void Wait(int Seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(Seconds));
        }

    }
}
