using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Scenarios
{
    class TestLoginFailure
    {

        public TestLoginFailure()
        {
        }

        [OneTimeSetUp]
        public void InicializeDriver()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void LoginSucess()
        {
            Actions.LoginSucess();
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > h1")).Text, "MY ACCOUNT");
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
