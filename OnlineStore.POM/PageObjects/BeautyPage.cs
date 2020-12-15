using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class BeautyPage
    {
        IWebDriver driver;

        public BeautyPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
