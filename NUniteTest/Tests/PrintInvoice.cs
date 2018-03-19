using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUniteTest.Helpers.Primitives;
using NUniteTest.Helpers.PageElements;
using OpenQA.Selenium.Support.UI;

namespace NUniteTest.Tests
{
    class PrintInvoice :Base
    {
        [Test, Combinatorial]

        public void invoice()
        {
            
            Login(User.UserID, User.PASSWORD);
            Wait(Links.TEN_SECONDS);

            Click(Buttons.LoginButton(driver));
           // Wait(Links.TEN_SECONDS);

            SelectElement branch =  new SelectElement(DropDowns.selectBranch(driver));
            branch.SelectByText("SG");

            Wait(Links.TEN_SECONDS);

            Click(Buttons.Apply(driver));

            SelectElement invoice = new SelectElement(DropDowns.selectInvoice(driver));
            invoice.SelectByText("Invoice");

            Wait(Links.TEN_SECONDS);

        }

    }
}
