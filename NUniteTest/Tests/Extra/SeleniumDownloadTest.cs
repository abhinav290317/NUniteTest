using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace NUniteTest
{
    class SeleniumDownloadTest
    {
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.co.in");
            
            Console.WriteLine("Open the Url");
        }

        [Test]
        public void DownloadDriverTest()
        {
            IWebElement searchbox = driver.FindElement(By.Id("lst-ib"));


            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Find the search box");

            searchbox.SendKeys("seleniumhq");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enter text in search box");

            searchbox.SendKeys(Keys.Return);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("click on the Google search");

            driver.FindElement(By.CssSelector("h3.r > a")).Click();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("click on the selenium link after searched");

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,1200);");
            Console.Read();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Google Chrome Driver")));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            System.Threading.Thread.Sleep(1000);

            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            IWebElement elemenet = driver.FindElement(By.XPath("//a[contains(text(),'Google Chrome Driver')]"));
            //waitOnPage(5);
            ((IJavaScriptExecutor)driver).ExecuteScript("agruments[0].click();", elemenet);

            //driver.FindElement(By.LinkText("2.33")).Click();
            //driver.FindElement(By.XPath("(//div[@id='mainContent']/table[2]/tbody/tr[2]/td[2]//a)[1]")).Click();

            System.Threading.Thread.Sleep(1000);
            // Console.WriteLine("click on 2.33 to download the chrome drive");
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

