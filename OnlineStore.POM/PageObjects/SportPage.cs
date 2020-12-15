using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class SportPage
    {
        IWebDriver driver;

        public SportPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
