using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class AccessoriesPage
    {
        IWebDriver driver;

        public AccessoriesPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
