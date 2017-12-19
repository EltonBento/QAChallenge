using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class CreateAccountPage
    {

        public CreateAccountPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "id_gender1")]
        public IWebElement GenderMR { get; set; }


        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#id_state > option:nth-child(15)")]
        public IWebElement StateIllinois { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobilePhone { get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement BtnRegister { get; set; }
    }
}
