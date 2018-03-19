using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GPExpress.Tests
{
    class LoginSample
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Open the url");
        }

        [Test]
        public void LoginTest()
        {
            IWebElement email = driver.FindElement(By.CssSelector("input#email"));
            email.SendKeys("abhinav290317@gmail.com");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Enter the Email");

            IWebElement password = driver.FindElement(By.CssSelector("input#pass"));
            password.SendKeys("1ntellisqa");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("enter the password");

            IWebElement submit = driver.FindElement(By.XPath("//*[@id='loginbutton']"));
            submit.Click();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Click on the login");

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            Console.WriteLine("Text on alert in " + alert.Text);

            //driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(2000);
        }

        [TearDown]

        public void EndTest()
        {
            System.Threading.Thread.Sleep(2000);
            driver.Close();
            Console.WriteLine("Close the Browser");
        }





    }



}

