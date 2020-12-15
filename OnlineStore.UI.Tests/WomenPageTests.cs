using Common.Utilities.Converters;
using FluentAssertions;
using NUnit.Framework;
using OnlineStore.POM.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineStore.UI.Tests
{
    public class Tests
    {
        private WomenPage womenPage;
        private HomePage homePage;
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);            
        }

        [Test]
        public void Given_UserIsOnHomePage_WHEN_UserOpenWomenPage_THEN_PageUrlShouldBeAMatch()
        {
            // given
            homePage.Open();
            // when
            womenPage = homePage.OpenWomenPage();
            // then
            womenPage.UrlMatches().Should().BeTrue();
        }


        [Test]
        public void Given_UserIsOnHomePage_WHEN_UserOpenWomenPage_THEN_AllCategoryLinksShouldBeDisplayed()
        {
            // given
            homePage.Open();
            // when
            womenPage = homePage.OpenWomenPage();
            // then
           womenPage.IsDressesImageLinkDisplayed().Should().BeTrue();
           womenPage.IsTopsAndTShirtsImageLinkDisplayed().Should().BeTrue();
           womenPage.IsShortsAndSkirtsImageLinkDisplayed().Should().BeTrue();
           womenPage.IsPantsImageLinkDisplayed().Should().BeTrue();
           womenPage.IsFootwearImageLinkDisplayed().Should().BeTrue();
           womenPage.IsAccessoriesImageLinkDisplayed().Should().BeTrue();
           womenPage.IsAllNewArrivalsButtonDisplayed().Should().BeTrue();
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