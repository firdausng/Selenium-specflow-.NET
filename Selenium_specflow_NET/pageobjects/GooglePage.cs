using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Selenium_specflow_NET.pageobjects
{
    public class GooglePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        private IWebElement searchTextBox { get; set; }

        [FindsBy(How = How.Id, Using = ".lsb")]
        private IWebElement googleSearchBtn { get; set; }

        public GooglePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void goTo()
        {
            WebDriver.Navigate().GoToUrl("https://www.google.com");
        }

        public void enterSearchQuery(string query)
        {
            WebDriver.FindElement(By.Id("lst-ib")).SendKeys(query);
        }

        public void clickSearchBtn()
        {
            wait.Until<IWebElement>((d) =>
            {
                IWebElement element = d.FindElement(By.CssSelector(".lsb"));
                if (element.Displayed &&
                    element.Enabled)
                {
                    return element;
                }

                return null;
            }).Click();
        }
    }
}
