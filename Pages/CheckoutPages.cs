using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAChallenge.Pages
{
    class CheckoutPages
    {
        public CheckoutPages()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span")]
        public IWebElement BtnSummaryCheckout { get; set; }


        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement BtnAddressCheckout { get; set; }

        [FindsBy(How = How.Name, Using = "cgv")]
        public IWebElement CheckboxTermsOfService { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement BtnShippingCheckout { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#HOOK_PAYMENT > div:nth-child(2) > div > p > a")]
        public IWebElement BtnPayByCheck { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#HOOK_PAYMENT > div:nth-child(1) > div > p > a")]
        public IWebElement BtnPayByBankWire { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#cart_navigation > button")]
        public IWebElement BtnConfirmPurchase { get; set; }


    }
}
