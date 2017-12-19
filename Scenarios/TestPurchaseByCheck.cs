using NUnit.Framework;
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
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }


    }
}
