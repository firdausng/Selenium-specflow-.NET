using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_specflow_NET.pageobjects
{
    public abstract class BasePage
    {
        public IWebDriver WebDriver { get; }

        protected WebDriverWait wait;

        public BasePage(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            this.wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            this.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public String getPageTitle()
        {
            return WebDriver.Title;
        }

        public void quit()
        {
            WebDriver.Quit();
        }


        

    }
}
