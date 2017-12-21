using NUnit.Framework;
using OpenQA.Selenium;
using QAChallenge.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Scenarios
{
    class TestRegistration
    {
        public TestRegistration()
        {
        }


        [OneTimeSetUp]
        public void InicializeDriver()
        {
            Actions.InitializeDriver();
        }


        [Test]
        public void Registration()
        {
            Actions.Registration();
            MyAccountPage myAcc = new MyAccountPage();
            myAcc.OptionMyAddress.Click();
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > div.addresses > div > div > ul > li:nth-child(4) > span.address_address1")).Text, Config.RegistrationValues.address);
            Assert.AreEqual(Driver.driver.FindElement(By.CssSelector("#center_column > div.addresses > div > div > ul > li:nth-child(5) > span:nth-child(3)")).Text, Config.RegistrationValues.zipcode);
            MyAddress myAddress = new MyAddress();
            myAddress.BtnBackToAccount.Click();
            myAcc.OptionMyPersonalInformation.Click();
            Assert.AreEqual(Driver.driver.FindElement(By.Id("firstname")).GetAttribute("value"), Config.RegistrationValues.firstName);
            Assert.AreEqual(Driver.driver.FindElement(By.Id("lastname")).GetAttribute("value"), Config.RegistrationValues.lastName);
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
