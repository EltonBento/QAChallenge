using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class MyAddress
    {

        public MyAddress()
        {
            PageFactory.InitElements(Driver.driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#center_column > ul > li:nth-child(1) > a")]
        public IWebElement BtnBackToAccount { get; set; }


    }
}
