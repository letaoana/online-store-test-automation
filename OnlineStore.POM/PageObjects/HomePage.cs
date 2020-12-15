using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OnlineStore.POM.PageObjects
{
    public class HomePage
    {
        readonly IWebDriver driver;
        readonly WebDriverWait wait;
        private IWebElement Women => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("WOMEN")));
        private IWebElement Men => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("MEN")));
        private IWebElement Kids => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("KIDS")));
        private IWebElement Home => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("CLOTHING")));
        private IWebElement AccountDetails => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("? 0")));
        private IWebElement Wishlist => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".inline-icon--heart")));
        private IWebElement Checkout => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".inline-icon--shopping-bag")));
        private IWebElement SearchBox => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("//*[@id='search']")));
        private IWebElement Clothing => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("CLOTHING")));
        private IWebElement Shoes => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("SHOES")));
        private IWebElement Accessories => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("ACCESSORIES")));
        private IWebElement Beauty => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("BEAUTY")));
        private IWebElement Gifts => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("GIFTS")));
        private IWebElement Brands => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("BRANDS")));
        private IWebElement Sport => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("SPORT")));
        private IWebElement Designer => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("DESIGNER")));
        private IWebElement SneakerHub => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("SNEAKERHUB")));
        private IWebElement Sale => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("SALE")));
        private IWebElement Outlet => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("OUTLET")));

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(3));
        }
        public void Open()
        {
            driver.Navigate().GoToUrl("https://www.theiconic.com.au/");
        }
        public void OpenSearchBox()
        {
            SearchBox.Click();
        }
        public WomenPage OpenWomenPage()
        {
            Women.Click();
            return new WomenPage(driver);
        }
        public MenPage OpenMenPage()
        {
            Men.Click();
            return new MenPage(driver);
        }
        public KidsPage OpenKidsPage()
        {
            Kids.Click();
            return new KidsPage(driver);
        }
        public HomePage OpenHomePage()
        {
            Home.Click();
            return this;
        }
        public AccountDetailsPage OpenAccountDetailsPage()
        {
            AccountDetails.Click();
            return new AccountDetailsPage(driver);
        }
        public WishlistPage OpenWishlistPage()
        {
            Wishlist.Click();
            return new WishlistPage(driver);
        }
        public CheckoutPage OpenCheckoutPage()
        {
            Checkout.Click();
            return new CheckoutPage(driver);
        }
        public ClothingPage OpenClothingPage()
        {
            Clothing.Click();
            return new ClothingPage(driver);
        }
        public ShoesPage OpenShoesPage()
        {
            Shoes.Click();
            return new ShoesPage(driver);
        }
        public AccessoriesPage OpenAccessoriesPage()
        {
            Accessories.Click(); 
            return new AccessoriesPage(driver);
        }
        public BeautyPage OpenBeautyPage()
        {
            Beauty.Click();
            return new BeautyPage(driver);
        }
        public GiftsPage OpenGiftsPage()
        {
            Gifts.Click();
            return new GiftsPage(driver);
        }
        public BrandsPage OpenBrandsPage()
        {
            Brands.Click();
            return new BrandsPage(driver);
        }
        public SportPage OpenSportPage()
        {
            Sport.Click();
            return new SportPage(driver);
        }
        public DesignerPage OpenDesignerPage()
        {
            Designer.Click();
            return new DesignerPage(driver);
        }
        public SneakerHubPage OpenSneakerHubPage()
        {
            SneakerHub.Click();
            return new SneakerHubPage(driver);
        }
        public SalePage OpenSalePage()
        {
            Sale.Click();
            return new SalePage(driver);
        }
        public OutletPage OpenOutletPage()
        {
            Outlet.Click();
            return new OutletPage(driver);
        }
    }
}
