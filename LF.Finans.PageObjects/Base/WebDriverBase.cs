using System;
using LF.Finans.PageObjects.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LF.Finans.PageObjects.Base
{
   public class WebDriverBase
    {
        private IWebDriver driver;
        private WebDriverBase baseActions;

        public WebDriverBase(IWebDriver driver)
        {
            this.driver = driver;
        }

        // *******************************************************************

        // OpenUrl ska ta emot en URL‑adress (t.ex. https://www.google.se)
        // och säga åt Seleniums WebDriver att öppna den sidan i webbläsaren.

        public void OpenUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        // ***********************************************************************************

        // Metod för att hämta sidtitel (ex: GetPageTitle() ***

        public string GetPageTitle()
        {
            string title = driver.Title;

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Title är tom");
            }
            else
            {
                Console.WriteLine($"Sidans title är: {title}");
            }

            return title;
        }


        // internal void ClickElement(HomePage lanpengarButton)-metod som döljer public void ClickElement(By element)
        /*
        internal void ClickElement(HomePage lanpengarButton)
        {
            throw new NotImplementedException();
        }

        */

        // ***********************************************************************************

        // Metod för att klicka på ett element (ex: ClickElement(By locator)

        public void ClickElement(By element)
        {

            driver.FindElement(element).Click();

        }

    // ***********************************************************************************

        //  Metod för att vänta på att ett element blir synligt

        public IWebElement ElementVisibility(By element)
        {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));

                IWebElement visibleElement = wait.Until(drv =>
                {
                    var el = drv.FindElement(element);
                    return (el.Displayed) ? el : null;
                });

                return visibleElement;
            }


            /*
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement visibleElement = wait.Until(ExpectedConditions.ElementIsVisible(element));
            return visibleElement;
            */
        }
        // ***********************************************************************************

    }