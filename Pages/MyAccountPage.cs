using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class MyAccountPage
    {
        public MyAccountPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(3) > a")]
        public IWebElement OptionMyAddress { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#center_column > div > div:nth-child(1) > ul > li:nth-child(4) > a")]
        public IWebElement OptionMyPersonalInformation { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1)")]
        public IWebElement MenuWomen { get; set; }

    }
}
