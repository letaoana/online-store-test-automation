using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OnlineStore.POM.PageObjects
{
    public class WomenPage
    {
        readonly IWebDriver driver;
        readonly WebDriverWait wait;
        IWebElement Dresses => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c0191")));
        IWebElement TopsAndTShirts => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01104")));
        IWebElement ShortsAndSkirts => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01117")));
        IWebElement Pants => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01130")));
        IWebElement Footwear => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01143")));
        IWebElement Accessories => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01156")));
        IWebElement AllNewArrivals => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01445")));

        public WomenPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }
        public void OpenDresses()
        {
            Dresses.Click();
        }
        public void OpenTopsAndTShirts()
        {
            TopsAndTShirts.Click();
        }
        public void OpenShortsAndSkirts()
        {
            ShortsAndSkirts.Click();
        }
        public void OpenPants()
        {
            Pants.Click();
        }
        public void OpenFootwear()
        {
            Footwear.Click();
        }
        public void OpenAccessories()
        {
            Accessories.Click();
        }
        public void OpenAllNewArrivals()
        {
            AllNewArrivals.Click();
        }
        public bool UrlMatches()
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://www.theiconic.com.au/women/"));
        }
        public bool IsDressesImageLinkDisplayed()
        {
            return Dresses.Displayed;
        }
        public bool IsTopsAndTShirtsImageLinkDisplayed()
        {
            return TopsAndTShirts.Displayed;
        }
        public bool IsShortsAndSkirtsImageLinkDisplayed()
        {
            return ShortsAndSkirts.Displayed;
        }
        public bool IsPantsImageLinkDisplayed()
        {
            return Pants.Displayed;
        }
        public bool IsFootwearImageLinkDisplayed()
        {
            return Footwear.Displayed;
        }
        public bool IsAccessoriesImageLinkDisplayed()
        {
            return Accessories.Displayed;
        }
        public bool IsAllNewArrivalsButtonDisplayed()
        {
            return AllNewArrivals.Displayed;
        }
    }
}
