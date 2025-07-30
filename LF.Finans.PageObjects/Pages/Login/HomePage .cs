using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;

namespace LF.Finans.PageObjects.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverBase baseActions;

        private readonly By acceptCookiesButton = By.XPath("//*[@id=\"CybotCookiebotDialogBodyButtonDecline\"]");
        private readonly By loginButton = By.XPath("//*[@id=\"site-header\"]/div[1]/div/div/div/button");

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
    }
}
