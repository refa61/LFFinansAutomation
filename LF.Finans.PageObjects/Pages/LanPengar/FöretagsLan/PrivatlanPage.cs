using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;

namespace LF.Finans.PageObjects.Pages.Privatlan
{
    public class PrivatlanPage
    {

        private WebDriverBase baseActions;
        private IWebDriver driver;
        private HomePage homepage;
        private By privatlanButton;

        //Constructor ***************************************************************
        public PrivatlanPage(IWebDriver driver)
        {
            this.driver = driver;

            this.baseActions = new WebDriverBase(driver);

            this.homepage = new HomePage(driver);
        }

        //***************************************************************

        public void ClickPrivatLanButton()
        {
            privatlanButton = By.XPath("//*[@id=\"nav-dropdown-12026\"]");
            baseActions.ElementVisibility(privatlanButton);
            baseActions.ClickElement(privatlanButton);
        }

        //***************************************************************
    }
}
