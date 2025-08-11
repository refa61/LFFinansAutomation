using System;
using System.Threading;
using LF.Finans.PageObjects.Base;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LF.Finans.PageObjects.Pages
{
    public class Kort_Betala
    {
        private IWebDriver driver;
        private WebDriverBase baseActions;
        private readonly By kortbetalaButton = By.XPath("//*[@id=\"nav-dropdown-12571\"]");
        private readonly By kriditkortbutton = By.XPath("//*[@id=\"nav-dropdown-12257\"]");
        private readonly By ansokkridikorttbutton = By.XPath("//*[@id=\"top\"]/div[1]/main/article/div[1]/div/div[1]/p[2]/a");
        private readonly By gavidarebutton = By.XPath("//*[@id=\"navbuttoncontainer\"]/button");
        private IJavaScriptExecutor js;

        public Kort_Betala(IWebDriver driver)
        {
            this.driver = driver;
            baseActions = new WebDriverBase(driver);
        }

        [AllureStep("Klickar på 'Kort och betala'-knappen")]
        public void KortBetalaButtonClick()
        {
            baseActions.ElementVisibility(kortbetalaButton);
            baseActions.ClickElement(kortbetalaButton);
        }

        [AllureStep("Klickar på 'Kreditkort'-knappen")]
        public void KriditkortButtonClick()
        {
            baseActions.ElementVisibility(kriditkortbutton);
            baseActions.ClickElement(kriditkortbutton);
        }

        [AllureStep("Klickar på 'Ansök om kreditkort'-knappen")]
        public void AnsokKridikorttButtonClick()
        {
            baseActions.ElementVisibility(ansokkridikorttbutton);
            baseActions.ClickElement(ansokkridikorttbutton);
        }


        [AllureStep("Scrollar ner till 'Gå vidare'-knappen")]
        public void ScrollTillGavidare()
        {
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
            Thread.Sleep(2000);
        }




        [AllureStep("Klickar på 'Gå vidare'-knappen")]
        public void GavidareButtonClick()
        {
            baseActions.ElementVisibility(gavidarebutton);
            Thread.Sleep(2000);
            baseActions.ClickElement(gavidarebutton);
        }
    }
}
