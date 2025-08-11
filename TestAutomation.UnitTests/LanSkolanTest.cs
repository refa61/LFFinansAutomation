using LF.Finans.PageObjects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using LF.Finans.PageObjects.Base;
using System;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace TestAutomation.UnitTests
{
    [TestFixture]
    [AllureNUnit]
    [NUnit.Allure.Attributes.AllureSuite("Lane_Skolan")]
    public class LanSkolTest
    {
        private IWebDriver driver;
        private HomePage homepage;
        private WebDriverBase driverbase;
        private Lane_Skolan lanskolan;

        // Setup *********************************************
        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            homepage = new HomePage(driver);
            lanskolan = new Lane_Skolan(driver);
            driverbase = new WebDriverBase(driver);
        }

        // Test **********************************************
        [Test]
        [AllureSubSuite("Kreditkort - flöde")]
        [AllureTag("regression", "ui")]
        [AllureDescription("Verifierar navigering och klickflöde för Lån.")]
        public void LanskolTest()
        {      
            homepage.OpenUrl();

            // Vänta på cookie-banner (extern väntan – detta tillhör inte PageObject, därför kvar här)
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("CybotCookiebotDialogBodyButtonDecline")));

            homepage.AcceptCookies();           // Har egen väntelogik internt om du har lagt till det
            lanskolan.LaneSkolanClick();        // Väntar och klickar
            lanskolan.LanGrunderClick();        // Väntar och klickar
            lanskolan.LanInfoClick();           // Väntar och klickar

            // Verifiera sidtitel
            string expected = "Låneskolan: Vad är ett lån? - LF Finans";
            string actual = driverbase.GetPageTitle();

            Console.WriteLine("title är: " + actual);
            Assert.AreEqual(expected, actual);
        }

        // TearDown *******************************************
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
