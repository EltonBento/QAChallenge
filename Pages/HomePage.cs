using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class HomePage
    {

        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#header > div.nav > div > div > nav > div.header_user_info > a")]
        public IWebElement BtnSignIn { get; set; }
        

    }
}
