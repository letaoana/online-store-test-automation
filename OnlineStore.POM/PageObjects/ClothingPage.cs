using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class ClothingPage
    {
        IWebDriver driver;

        public ClothingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
