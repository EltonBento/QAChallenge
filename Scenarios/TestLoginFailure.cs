using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Scenarios
{
    class TestFailure
    {

        public TestFailure()
        {
        }

        [OneTimeSetUp]
        public void InicializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void LoginFailure()
        {
            Actions.LoginFailure();
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > h1")).Text, "AUTHENTICATION");
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
