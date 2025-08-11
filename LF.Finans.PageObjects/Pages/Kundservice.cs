using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LF.Finans.PageObjects.Pages
{

    // Klass **********************************************
    public class Kundservice
    {
        private readonly By kundservice = By.XPath ("//*[@id=\"nav-dropdown-12832\"]");
      
        /*   Flyttat till HoePage
        private readonly By lanapengar = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[1]/a/strong");
        private readonly By utakalan = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[2]/a/strong");
        private readonly By samlalan = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[3]/a/strong");
        private readonly By ansokkreditkkort = By.XPath("//*[@id=\"top\"]/div[2]/main/section/div[2]/div/div[4]/a/strong");
        */
        private IWebDriver driver;
        private HomePage homepage;
        private WebDriverBase driverbase;

        // Constructor ****************************************
        public Kundservice(IWebDriver driver)
    {
            this.driver = driver;
            homepage = new HomePage(driver);
            driverbase = new WebDriverBase(driver);

    }

        public void kundserviceClick()
        {
            driverbase.ElementVisibility(kundservice);
            driverbase.ClickElement(kundservice);
        }

        //*****************************************************

            public enum KundserviceVal
        {
            LanaPengar, UtokaLan, SamlaLan, AnsokKreditkort
        }

        // Flyttat till HomePage ****************************************
       /*
        public void klickaPåKundserviceVal(KundserviceVal val)
        {
            kundserviceClick();

            switch (val)
            {
                case KundserviceVal.LanaPengar:

                    driverbase.ElementVisibility(lanapengar);
                    driverbase.ClickElement(lanapengar);

                    break;


                case KundserviceVal.UtokaLan:

                    driverbase.ElementVisibility(utakalan);
                    driverbase.ClickElement(utakalan);

                    break;


                case KundserviceVal.SamlaLan:

                    driverbase.ElementVisibility(samlalan);
                    driverbase.ClickElement(samlalan);

                    break;


                case KundserviceVal.AnsokKreditkort:

                    driverbase.ElementVisibility(ansokkreditkkort);
                    driverbase.ClickElement(ansokkreditkkort);

                    break;
            }
        }
        
        */
        // Slut ***********************************************
    }
}
   

