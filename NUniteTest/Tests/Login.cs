using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUniteTest.Helpers.Primitives;
using NUniteTest.Helpers.PageElements;
using OpenQA.Selenium;

namespace NUniteTest.Tests
{
    class Login : Base
    {
        [Test, Combinatorial]
        public void LoginTest()
        {
            Login(User.UserID, User.PASSWORD);
            Wait(10);

            Click(Buttons.LoginButton(driver));

          /*IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("alert('Shows notifications')");

            System.Threading.Thread.Sleep(2000);
               
            IAlert alert = driver.SwitchTo().Alert();
            String t = alert.Text;
            alert.Accept();
            Console.WriteLine("Text on alert in " + alert.Text);
            
            driver.Navigate().Refresh(); */
          

        }


    }
}

