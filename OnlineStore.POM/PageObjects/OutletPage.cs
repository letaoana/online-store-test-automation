using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class OutletPage
    {
        IWebDriver driver;

        public OutletPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
