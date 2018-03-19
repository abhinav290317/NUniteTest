using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace NUniteTest
{
    [TestClass]
    public class TestPractise
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Open the Url");
        }

        [Test]
        public void BookFlight()
        {
            IWebElement Form = driver.FindElement(By.Id("hp-widget__sfrom"));
            Form.SendKeys("Mumbai, India");
            System.Threading.Thread.Sleep(4000);



        }


    }

}
