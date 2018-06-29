using OpenQA.Selenium;
using System;

namespace Selenium_specflow_NET.support.browser
{
    public interface IBrowser
    {
        IWebDriver LocalDriver();
        IWebDriver RemoteDriver();
        IWebDriver getDriver(Boolean remote=false);
        DriverOptions Options();
        ICapabilities Capabilities();
    }
}
