using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Scenarios
{
    class TestPurchaseByBankWire
    {
        public TestPurchaseByBankWire()
        {
                
        }


        [OneTimeSetUp]
        public void InicializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void PurchaseByBankWire()
        {
            Actions.LoginSucess();
            Actions.PurchaseByBankWire();
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > h1")).Text, "ORDER CONFIRMATION");

        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
