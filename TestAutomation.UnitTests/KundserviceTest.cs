using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace TestAutomation.UnitTests
{

    [TestFixture]
    [AllureNUnit]
    [NUnit.Allure.Attributes.AllureSuite("Kundservice")]
    public class KundserviceTest
    {
        private IWebDriver driver;
        private HomePage homepage;
        private WebDriverBase driverbase;
        private Kundservice kundservice;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            homepage = new HomePage(driver);

            driverbase = new WebDriverBase(driver);

            kundservice = new Kundservice(driver);

        }

        [Test]
        [AllureSubSuite("Kundservice - flöde")]
        [AllureTag("regression", "ui")]
        [AllureDescription("verifierar kundservice och 4 val av hem-filken med swish")]
        public void KundServiceTest()
        {

            homepage.OpenUrl();
            Thread.Sleep(100);
            homepage.AcceptCookies();

            homepage.klickaPåKundserviceVal(HomePage.KundserviceVal.LanaPengar); // eller ett annat val


            kundservice.kundserviceClick();
            Thread.Sleep(100);

            string rubrik = driverbase.GetPageTitle();

            Console.WriteLine("Rubrik är: " + rubrik);

            string expectedtitle = "Privatlån - ansök om lån utan säkerhet - LF Finans";

            Assert.AreEqual(rubrik, expectedtitle);

         }

            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }


    }
}
