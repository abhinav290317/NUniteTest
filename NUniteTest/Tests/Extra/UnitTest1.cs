using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace NUniteTest
{
    class NUniteTest1
    {
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Open the Url");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement firstname = driver.FindElement(By.Id("email"));
            IWebElement lastName = driver.FindElement(By.Id("pass"));
            IWebElement login = driver.FindElement(By.Id("loginbutton"));

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Find the First and Last Name");

            firstname.SendKeys("abhinav290317@gmail.com");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enter First Name");

            lastName.SendKeys("1ntellisqa");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enter Last Name");

            login.Click();
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Click on the Login button");

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

