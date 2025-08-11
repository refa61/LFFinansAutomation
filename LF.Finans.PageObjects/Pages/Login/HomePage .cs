using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;
using System;

namespace LF.Finans.PageObjects.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverBase baseActions;

        private readonly By acceptCookiesButton = By.XPath("//*[@id=\"CybotCookiebotDialogBodyButtonDecline\"]");
        private readonly By loginButton = By.XPath("//*[@id=\"site-header\"]/div[1]/div/div/div/button");

        // Swish val
        private readonly By lanapengar = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[1]/a/strong");
        private readonly By utakalan = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[2]/a/strong");
        private readonly By samlalan = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[3]/a/strong");
        private readonly By ansokkreditkkort = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[4]/a/strong");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.baseActions = new WebDriverBase(driver);
        }


        public void OpenUrl()
        {
            baseActions.OpenUrl("https://www.lffinans.se/");
        }

        public void AcceptCookies()
        {
            baseActions.ElementVisibility(acceptCookiesButton);
            baseActions.ClickElement(acceptCookiesButton);
        }

        public void ClickLoginButton()
        {
            baseActions.ElementVisibility(loginButton);
            baseActions.ClickElement(loginButton);
        }



        // Swish för 4 val i Hemsidan ****************

        public enum KundserviceVal
        {
            LanaPengar, UtokaLan, SamlaLan, AnsokKreditkort
        }

        public void klickaPåKundserviceVal(KundserviceVal val)
        {
           

            switch (val)
            {
                case KundserviceVal.LanaPengar:

                    baseActions.ElementVisibility(lanapengar);
                    baseActions.ClickElement(lanapengar);

                    break;


                case KundserviceVal.UtokaLan:

                    baseActions.ElementVisibility(utakalan);
                    baseActions.ClickElement(utakalan);

                    break;


                case KundserviceVal.SamlaLan:

                    baseActions.ElementVisibility(samlalan);
                    baseActions.ClickElement(samlalan);

                    break;


                case KundserviceVal.AnsokKreditkort:

                    baseActions.ElementVisibility(ansokkreditkkort);
                    baseActions.ClickElement(ansokkreditkkort);

                    break;
            }
        }
        // ********************************************

    }
}
