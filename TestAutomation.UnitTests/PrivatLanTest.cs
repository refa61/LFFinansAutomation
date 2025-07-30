using LF.Finans.PageObjects.Base;
using LF.Finans.PageObjects.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;

namespace TestAutomation.UnitTests.LanTest
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Privatlån")]
    [AllureOwner("Alex")]
    public class PrivatLanTest
    {
        private IWebDriver driver;
        private HomePage homePage;
        private PrivatLanPage privatLanPage;
        private WebDriverBase driverBase;

        [SetUp]
        public void Setup()
        {
            //driver = new ChromeDriver();
            var options = new ChromeOptions(); // <-- Du behöver skapa options
            driver = new ChromeDriver(@"C:\Tools\Visual Studion\chromedriver-win64", options);

            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            driverBase = new WebDriverBase(driver);
        }


        [Test]
        [AllureFeature("Ansök om Privatlån")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureTag("UI", "Selenium", "Smoke")]

        public void ApplyForPrivatlan()
        {
            TestContext.WriteLine($"Testar CI/ CD");
            try
            {
                homePage.OpenUrl();
                Thread.Sleep(2000);
                homePage.AcceptCookies();

                privatLanPage = new PrivatLanPage(driver);
                privatLanPage.ClickLanpengarButton();
                Thread.Sleep(3000);
                privatLanPage.ClickPrivatLanButton();
                Thread.Sleep(3000);
                privatLanPage.AnsökPrivatlan();
                Thread.Sleep(3000);

                new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(d => d.Url.Contains("privatlan") || d.Title.Contains("Privatlån"));

                foreach (string handle in driver.WindowHandles)
                {
                    if (handle != driver.CurrentWindowHandle)
                    {
                        driver.SwitchTo().Window(handle);
                        break;
                    }
                }

                privatLanPage.LanAndamal();
                Thread.Sleep(2000);
                privatLanPage.GoForwardButton();
                Thread.Sleep(2000);

                string actualTitle = driverBase.GetPageTitle();
                string expectedTitle = "Ansök om lån enkelt online - LF Finans";

                Assert.AreEqual(expectedTitle, actualTitle);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"Fel under testutförande: {ex.Message}");
                throw;
            }
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
