using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class ShoesPage
    {
        IWebDriver driver;

        public ShoesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
