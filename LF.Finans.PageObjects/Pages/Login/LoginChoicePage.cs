using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;

namespace LF.Finans.PageObjects.Pages
{
   public class LoginChoicePage
    {
        private IWebDriver driver;
        private WebDriverBase baseActions;
        private By Privat, Företag, MobiltBankID, BankIDPåDennaEnhet, Cancel;

        //private By loginButton = By.XPath("//*[@id=\"site-header\"]/div[1]/div/div/div/button");

        // Konstructor ************************************************************
        //public LoginChoicePage(IWebDriver driver)
        //{
        //    this.driver = driver;

        //    baseActions = new WebDriverBase(baseActions);

        //}

        public LoginChoicePage(IWebDriver driver)
        {
            this.driver = driver;
            this.baseActions = new WebDriverBase(driver);  // ✅ viktigt!
        }



        //************************************************************************
        // Använd ElementVisibility() på Privat-knappen och sedan ClickElement().
        public void ClickPrivat()
        {

            //Privat = By.XPath("//a[text()='Privat']");
            // Privat = By.LinkText("Privat");
            // Privat = By.XPath("//a[contains(text(),'Privat')]");
            Privat = By.XPath("//*[@id=\"site-header\"]/div[1]/div/div/div/div/a[1]");

            baseActions.ElementVisibility(Privat);
            baseActions.ClickElement(Privat);
        }

        //*************************************************************************
        // kolla synlighet och klicka MobiltBankID
        public void ClickMobiltBankID()
        {
            MobiltBankID = By.XPath("//*[@id=\"login-box\"]/div/form/div/ul[1]/input");
            baseActions.ElementVisibility(MobiltBankID);
            baseActions.ClickElement(MobiltBankID);
        }

        //*************************************************************************
        // kolla synlighet och klicka Cancel.
       
        public void ClickCancel()
        {
            Cancel = By.XPath("//*[@id=\"body-content\"]/div/div/button[2]");
            baseActions.ElementVisibility(Cancel);
            baseActions.ClickElement(Cancel);
        }
        
    }
}
