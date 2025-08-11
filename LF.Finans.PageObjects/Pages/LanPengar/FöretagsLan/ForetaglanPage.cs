using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;


namespace LF.Finans.PageObjects.Pages.LanPengar.FöretagsLan
{
  public class ForetaglanPage
    {
        private IWebDriver driver;
        private By foretag = By.XPath("//*[@id=\"site-header\"]/div/div/nav/ul/li[2]/a");
        private By leasing = By.XPath("//*[@id=\"top\"]/div[1]/main/section/div[2]/div/div[1]/a/strong");
        private By hallfinansiering = By.XPath("//*[@id=\"top\"]/div[1]/main/section/div[2]/div/div[2]/a/strong");
        private By delbetalningbutik = By.XPath("//*[@id=\"top\"]/div[1]/main/section/div[2]/div/div[3]/a/strong");
        private By mashin_finansiering = By.XPath("//*[@id=\"top\"]/div[1]/main/section/div[2]/div/div[4]/a/strong");
        private HomePage homepage;
        private WebDriverBase driverbase;

// Constructor *****************************************
      public ForetaglanPage(IWebDriver driver)
        {

            this.driver = driver;
            homepage = new HomePage(driver);
            driverbase = new WebDriverBase(driver);

        }

        // Företag ******************************************
        public void foretagClick()
        {
            driverbase.ElementVisibility(foretag);
            driverbase.ClickElement(foretag);
        }

        // Leasing ******************************************
        public void LeasingClick()
        {
            driverbase.ElementVisibility(leasing);
            driverbase.ClickElement(leasing);
        }


        // Finansiering *************************************
        public void HallbarFinansieringClick()
        {
            driverbase.ElementVisibility(hallfinansiering);
            driverbase.ClickElement(hallfinansiering);
        }

        // Delbetalningbutik ********************************
        public void DelbetalningbutikClick()
        {
            driverbase.ElementVisibility(delbetalningbutik);
            driverbase.ClickElement(delbetalningbutik);
        }

        // Delbetalningbutik ********************************
        public void Mashin_finansieringkClick()
        {
            driverbase.ElementVisibility(mashin_finansiering);
            driverbase.ClickElement(mashin_finansiering);
        }

        // End **********************************************
    }
}
