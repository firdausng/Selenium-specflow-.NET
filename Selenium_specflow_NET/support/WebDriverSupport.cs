using BoDi;
using OpenQA.Selenium;
using Selenium_specflow_NET.support.browser;
using TechTalk.SpecFlow;

namespace Selenium_specflow_NET.support
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDriver = new BrowserFactory().getBrowser();
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        
    }
}
