using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;
using System.Threading;

namespace LF.Finans.PageObjects.Pages
{
    public class PrivatLanPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverBase baseActions;

        private readonly By lanpengarButton = By.XPath("//*[@id=\"nav-dropdown-12554\"]");
        private readonly By privatlanButton = By.XPath("//*[@id=\"nav-dropdown-12026\"]");
        private readonly By ansokprivatlanButton = By.XPath("//*[@id=\"top\"]/div[1]/main/article/div[1]/div/div[1]/p[2]/a");

        //private readonly By lanandamal = By.XPath("//div[text()='Resa']/parent::div");
        private readonly By lanandamal = By.XPath("//div[text()='Resa']/parent::div");

        private readonly By goforwardButton = By.XPath("//*[@id=\"root\"]/div/div[3]/button");

        public PrivatLanPage(IWebDriver driver)
        {
            this.driver = driver;
            this.baseActions = new WebDriverBase(driver);
        }

        public void ClickLanpengarButton()
        {
            baseActions.ElementVisibility(lanpengarButton);
            baseActions.ClickElement(lanpengarButton);
        }

        public void ClickPrivatLanButton()
        {
            baseActions.ElementVisibility(privatlanButton);
            baseActions.ClickElement(privatlanButton);
        }

        public void AnsökPrivatlan()
        {
            baseActions.ElementVisibility(ansokprivatlanButton);
            baseActions.ClickElement(ansokprivatlanButton);
        }

        private void ScrollToElement(By element)
        {
            IWebElement el = driver.FindElement(element);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", el);
        }

        public void LanAndamal()
        {
            baseActions.ElementVisibility(lanandamal);

            Thread.Sleep(3000);
            ScrollToElement(lanandamal);
            Thread.Sleep(3000);

            baseActions.ClickElement(lanandamal);
        }

        public void GoForwardButton()
        {
            baseActions.ElementVisibility(goforwardButton);
            baseActions.ClickElement(goforwardButton);
        }
    }
}
