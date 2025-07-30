using LF.Finans.PageObjects.Base;
using OpenQA.Selenium;
// using OpenQA.selenium.JavascriptExecutor;


namespace LF.Finans.PageObjects.Pages.Privatlan
{
    public class AnsokOmPrivatlanPage
    {
        private WebDriverBase baseActions;
        private IWebDriver driver;
        private By ansokprivatlanButton;

        //Constructor ***************************************************************
        public AnsokOmPrivatlanPage(IWebDriver driver)
        {
            this.driver = driver;

            this.baseActions = new WebDriverBase(driver);
        }

        //***************************************************************


        public void AnsökPrivatlan()
        {
            ansokprivatlanButton = By.XPath("//*[@id=\"top\"]/div[1]/main/article/div[1]/div/div[1]/p[2]/a");
            baseActions.ElementVisibility(ansokprivatlanButton);
            baseActions.ClickElement(ansokprivatlanButton);
        }

        // Scrolling ***************************************************************
        /*
        public void ScrollingByPixel()
        {

            js.executeScript("window.scrollBy(0,1000)");
        }
        */

        public void scrollByPage()
        {
            //This will scroll the web page till the end
        //  js.executeScript("window.scrollTo(0, document.body.scrollHeight)");
        }

    }
    }
