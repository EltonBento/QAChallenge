﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Scenarios
{
    class TestPurchaseByCheck
    {
        public TestPurchaseByCheck()
        {
                
        }


        [OneTimeSetUp]
        public void InicializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void PurchaseByCheck()
        {
            Actions.LoginSucess();
            Actions.PurchaseByCheck();
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > p.alert.alert-success")).Text, "Your order on My Store is complete.");
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}
