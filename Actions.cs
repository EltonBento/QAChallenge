using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QAChallenge.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QAChallenge
{
    class Actions
    {


        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.URL);
        }



        public static void Registration()
        {

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));

            HomePage hp = new HomePage();
            hp.BtnSignIn.Click();

            AuthenticationPage ap = new AuthenticationPage();
            ap.Email.SendKeys(Config.RegistrationValues.email);
            ap.BtnCreateAnAccount.Click();

            wait.Until(ExpectedConditions.ElementExists(By.Id("account-creation_form")));
            CreateAccountPage createAcP = new CreateAccountPage();
            createAcP.GenderMR.Click();
            createAcP.FirstName.SendKeys(Config.RegistrationValues.firstName);
            createAcP.LastName.SendKeys(Config.RegistrationValues.lastName);
            createAcP.Password.SendKeys(Config.RegistrationValues.password);
            createAcP.Address.SendKeys(Config.RegistrationValues.address);
            createAcP.City.SendKeys(Config.RegistrationValues.city);
            createAcP.StateIllinois.Click();
            createAcP.ZipCode.SendKeys(Config.RegistrationValues.zipcode);
            createAcP.MobilePhone.SendKeys(Config.RegistrationValues.MobilePhoneNumer);
            createAcP.BtnRegister.Click();



        }


        public static void LoginSucess()
        {
            HomePage hp = new HomePage();
            hp.BtnSignIn.Click();

            AuthenticationPage ap = new AuthenticationPage();
            ap.EmailLogin.SendKeys(Config.RegistrationValues.email);
            ap.Password.SendKeys(Config.RegistrationValues.password);
            ap.BtnLogin.Click();
        }

        public static void LoginFailure()
        {
            HomePage hp = new HomePage();
            hp.BtnSignIn.Click();

            AuthenticationPage ap = new AuthenticationPage();
            ap.EmailLogin.SendKeys(Config.RegistrationValues.email);
            ap.Password.SendKeys("12345");
            ap.BtnLogin.Click();
        }

        public static void PurchaseByCheck()
        {
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));

            MyAccountPage myAcc = new MyAccountPage();
            myAcc.MenuWomen.Click();

            WomenPage wp = new WomenPage();
            wp.Product1AddToCart.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("layer_cart")));
            wp.ProceedToCheckout.Click();

            CheckoutPages checkout = new CheckoutPages();
            checkout.BtnSummaryCheckout.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("processAddress")));
            checkout.BtnAddressCheckout.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("processCarrier")));
            checkout.CheckboxTermsOfService.Click();
            checkout.BtnShippingCheckout.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("HOOK_PAYMENT")));
            checkout.BtnPayByCheck.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#center_column > form")));
            checkout.BtnConfirmPurchase.Click();
            Thread.Sleep(3000);


            
        }




    }
}
