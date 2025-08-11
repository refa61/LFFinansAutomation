using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestAutomation.UnitTests
{
    public class ScrollingTests
    {
        private IWebDriver driver;
        private HomePage homepage;
        private IJavaScriptExecutor js;

        //****************************************************
        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(@"C:\Tools\Visual Studion\chromedriver-win64", options);
            driver.Manage().Window.Maximize();

            homepage = new HomePage(driver);  // Om HomePage används i framtiden
        }

        //****************************************************
        [Test]
        public void ScrollTests()
        {
            driver.Navigate().GoToUrl("https://testguild.com/selenium-webdriver-visual-studio/");
            Console.WriteLine("Sidan öppnades utan fel!");

            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");

            // Vänta lite så man ser scrollen (valfritt)
            System.Threading.Thread.Sleep(2000);
        }

        //****************************************************
        [TearDown]
        public void TearDown()
        {
            driver.Quit();  // Viktigt: stäng ner webbläsaren
        }
    }
}
