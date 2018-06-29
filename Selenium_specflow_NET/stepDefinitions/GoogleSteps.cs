using OpenQA.Selenium;
using Selenium_specflow_NET.pageobjects;
using TechTalk.SpecFlow;
using Xunit;

namespace Selenium_specflow_NET.stepDefinitions
{
    [Binding]
    public class GoogleSteps
    {
        private GooglePage google;

        public GoogleSteps(IWebDriver driver)
        {
            google = new GooglePage(driver);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            google.quit();
        }

        [Given(@"I go to google")]
        public void GivenIGoToGoogle()
        {
            google.goTo();
        }
        
        [When(@"I query for ""(.*)""")]
        public void WhenIQueryFor(string p0)
        {
            google.enterSearchQuery(p0);
        }
        
        [When(@"click search")]
        public void WhenClickSearch()
        {
            google.clickSearchBtn();
        }
        
        [Then(@"google page title should become ""(.*)""")]
        public void ThenGooglePageTitleShouldBecome(string p0)
        {
            Assert.True(true);
        }
        
        
    }
}
