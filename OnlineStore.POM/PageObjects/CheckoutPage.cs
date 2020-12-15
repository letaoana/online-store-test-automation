using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OnlineStore.POM.PageObjects
{
    public class CheckoutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(3));
        }
    }
}
