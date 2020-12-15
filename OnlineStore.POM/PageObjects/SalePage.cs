using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class SalePage
    {
        IWebDriver driver;

        public SalePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
