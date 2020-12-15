using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class GiftsPage
    {
        IWebDriver driver;

        public GiftsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
