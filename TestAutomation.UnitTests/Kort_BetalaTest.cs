using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.Commons;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System;
using System.Threading;

namespace TestAutomation.UnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Kort Betala")]


    // ****************************************************************

    public class Kort_BetalaTest
    {
        private IWebDriver driver;
        private HomePage homepage;
        private WebDriverBase webdriverbase;
        private Kort_Betala kortbetala;


    // ****************************************************************
        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(@"C:\Tools\Visual Studion\chromedriver-win64", options);

            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();

            webdriverbase = new WebDriverBase(driver);
            homepage = new HomePage(driver);
            kortbetala = new Kort_Betala(driver);
        }


        // ****************************************************************

        [Test]
        [AllureSubSuite("Kreditkort - flöde")]
        [AllureTag("regression", "ui")]
        [AllureDescription("Verifierar navigering och klickflöde för kreditkortsansökan.")]
        public void KortBetalaTest()
        {
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                homepage.OpenUrl();
                Thread.Sleep(1000);
                homepage.AcceptCookies();
            }, "Öppna startsidan och acceptera cookies");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                kortbetala.KortBetalaButtonClick();
                TestContext.WriteLine("kortbetala.KortBetalaButtonClick() har körts");
            }, "Klicka på 'Kort & Betala'");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                kortbetala.KriditkortButtonClick();
                TestContext.WriteLine("kortbetala.KriditkortButtonClick() har körts");
            }, "Klicka på 'Kreditkort'");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Thread.Sleep(1000);
                kortbetala.AnsokKridikorttButtonClick();
                TestContext.WriteLine("kortbetala.AnsokKridikorttButtonClick() har körts");
            }, "Klicka på 'Ansök om kreditkort'");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                kortbetala.ScrollTillGavidare();
            }, "Scrolla till knappen 'Gå vidare'");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                kortbetala.GavidareButtonClick();
                TestContext.WriteLine("kortbetala.GavidareButtonClick() har körts");
            }, "Klicka på 'Gå vidare'");

            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Console.WriteLine("Current URL: " + driver.Url);
                TestContext.WriteLine("Current Title: " + driver.Title);

                string actualTitle = webdriverbase.GetPageTitle();
                string expectedTitle = "Inloggning - LF Finans";
                Assert.AreEqual(expectedTitle, actualTitle);
            }, "Verifiera sidtitel");
        }


    // ****************************************************************
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
            Console.WriteLine("Efter Quit metod");
        }

    // ****************************************************************
    }
}
