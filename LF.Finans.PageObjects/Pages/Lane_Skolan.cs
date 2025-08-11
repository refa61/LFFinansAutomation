using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace LF.Finans.PageObjects.Pages
{
    public class Lane_Skolan
    {
        private readonly IWebDriver driver;
        private readonly WebDriverBase driverbase;

        private readonly By Laneskolan = By.XPath("//*[@id=\"nav-dropdown-12699\"]");
        private readonly By langrunder = By.XPath("//*[@id=\"nav-dropdown-15713\"]");
        private readonly By laninfo = By.XPath("//*[@id=\"top\"]/div[1]/main/article/section[1]/div/div/div[1]/div/div/div/div[2]/a");

        // Constructor **********************************************
        public Lane_Skolan(IWebDriver driver)
        {
            this.driver = driver;
            driverbase = new WebDriverBase(driver);
        }

        // Click "Låneskolan" ***************************************
        public void LaneSkolanClick()
        {
            WaitUntilClickable(Laneskolan);
            driverbase.ClickElement(Laneskolan);
        }

        // Click "Grundläggande för lån" ****************************
        public void LanGrunderClick()
        {
            WaitUntilClickable(langrunder);
            driverbase.ClickElement(langrunder);
        }

        // Click "Låneinformation" **********************************
        public void LanInfoClick()
        {
            WaitUntilClickable(laninfo);
            driverbase.ClickElement(laninfo);
        }

        // Privat hjälpmetod för återanvändning *********************
        private void WaitUntilClickable(By locator)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
