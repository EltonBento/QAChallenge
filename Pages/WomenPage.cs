using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class WomenPage
    {
        public WomenPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#center_column > ul > li:nth-child(1) > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default")]
        public IWebElement Product1AddToCart { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a")]
        public IWebElement ProceedToCheckout { get; set; }

    }
}
