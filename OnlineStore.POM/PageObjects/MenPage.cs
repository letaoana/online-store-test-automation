using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OnlineStore.POM.PageObjects
{
    public class MenPage
    {
        readonly IWebDriver driver;
        readonly WebDriverWait wait;
        IWebElement Shirts => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c0191")));
        IWebElement Footwear => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01104")));
        IWebElement Jeans => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01117")));
        IWebElement TShirts => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01130")));
        IWebElement SweatTops => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01143")));
        IWebElement Accessories => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01156")));
        IWebElement AllNewArrivals => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".c01467")));
        public MenPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public void OpenShirts()
        {
            Shirts.Click();
        }
        public void OpenTShirts()
        {
            TShirts.Click();
        }
        public void OpenJeans()
        {
            Jeans.Click();
        }
        public void OpenSweatTops()
        {
            SweatTops.Click();
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
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://www.theiconic.com.au/men/")); ;
        }
        public bool IsShirtsImageLinkDisplayed()
        {
            return Shirts.Displayed;
        }
        public bool IsTShirtsImageLinkDisplayed()
        {
            return TShirts.Displayed;
        }
        public bool IsJeansImageLinkDisplayed()
        {
            return Jeans.Displayed;
        }
        public bool IsSweatTopsImageLinkDisplayed()
        {
            return SweatTops.Displayed;
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
