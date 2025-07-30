using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;

namespace TestAutomation.UnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Login")]
    [AllureOwner("Alex")]
    public class LoginTests
    {
        private IWebDriver driver;
        private HomePage homePage;
        private LoginChoicePage loginChoicePage;
        private WebDriverBase driverBase;
        private string actualTitle;

        [SetUp]
        public void Setup()
        {
            // driver = new ChromeDriver();

                var options = new ChromeOptions(); // <-- Du behöver skapa options
                driver = new ChromeDriver(@"C:\Tools\Visual Studion\chromedriver-win64", options);

                homePage = new HomePage(driver);
                driverBase = new WebDriverBase(driver);

        }

        [Test]
        [AllureFeature("Inloggning")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("smoke", "UI")]
        public void login()
        {
            homePage.OpenUrl();
            homePage.AcceptCookies();
            homePage.ClickLoginButton();

            loginChoicePage = new LoginChoicePage(driver);
            loginChoicePage.ClickPrivat();
            loginChoicePage.ClickMobiltBankID();
            loginChoicePage.ClickCancel();

            actualTitle = driverBase.GetPageTitle();
            TestContext.WriteLine($"1- Aktuell titel med TestContext: {actualTitle}");

            string expectedTitle = "Inloggning - LF Finans";
            Assert.AreEqual(expectedTitle, actualTitle, "Sidadtitel stämmer inte");

            TestContext.WriteLine($"2- Aktuell titel med TestContext: {actualTitle}");
            Console.WriteLine($"3- Aktuell titel med Console: {actualTitle}");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
