using OpenQA.Selenium;

namespace OnlineStore.POM.PageObjects
{
    public class DesignerPage
    {
        IWebDriver driver;

        public DesignerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
