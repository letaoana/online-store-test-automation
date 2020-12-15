using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class BrandsPage
    {
        IWebDriver driver;

        public BrandsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
