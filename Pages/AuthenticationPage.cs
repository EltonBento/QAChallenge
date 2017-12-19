using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class AuthenticationPage
    {

        public AuthenticationPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement Email { get; set; }


        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement BtnCreateAnAccount { get; set; }


        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailLogin { get; set; }


        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement BtnLogin { get; set; }




    }
}
