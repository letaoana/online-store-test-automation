using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class SneakerHubPage
    {
        IWebDriver driver;

        public SneakerHubPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
