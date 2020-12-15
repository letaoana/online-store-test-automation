using Common.Utilities.Converters;
using FluentAssertions;
using NUnit.Framework;
using OnlineStore.POM.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineStore.UI.Tests
{
    public class MenPageTests
    {
        private MenPage menPage;

        IWebDriver driver;
        private HomePage homePage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            
            
        }

        [Test]
        public void Given_UserIsOnHomePage_WHEN_UserOpenMenPage_THEN_PageUrlShouldBeAMatch()
        {
            // given
            homePage.Open();
            // when
            menPage = homePage.OpenMenPage();
            // then 
            menPage.UrlMatches().Should().BeTrue();
        }

        [Test]
        public void Given_UserIsOnHomePage_WHEN_UserOpenMenPage_THEN_AllCategoryLinksShouldBeDisplayed()
        {
            // given
            homePage.Open();
            // when
            menPage = homePage.OpenMenPage();
            // then 
            Assert.IsTrue(menPage.IsShirtsImageLinkDisplayed());
            Assert.IsTrue(menPage.IsTShirtsImageLinkDisplayed());
            Assert.IsTrue(menPage.IsJeansImageLinkDisplayed());
            Assert.IsTrue(menPage.IsSweatTopsImageLinkDisplayed());
            Assert.IsTrue(menPage.IsFootwearImageLinkDisplayed());
            Assert.IsTrue(menPage.IsAccessoriesImageLinkDisplayed());
            Assert.IsTrue(menPage.IsAllNewArrivalsButtonDisplayed());
        }

        [TearDown]
        public void CleanUp()
        {
            SuiteSetup.extent.CreateTest(TestContext.CurrentContext.Test.Name).Log(StatusConverter.Convert((int)TestContext.CurrentContext.Result.Outcome.Status), TestContext.CurrentContext.Result.Message);
            SuiteSetup.extent.Flush();
            driver.Quit();
        }
    }
}
