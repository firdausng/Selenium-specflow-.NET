using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Selenium_specflow_NET.support.browser
{
    public abstract class AbstractBrowser : IBrowser
    {
        protected IWebDriver Driver {
            get;
            set;
        }

        protected String method;

        public AbstractBrowser(String method)
        {
            this.method = method;
        }

        public abstract DriverOptions Options();

        public ICapabilities Capabilities()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();

            //TODO:

            return desiredCapabilities;
        }

        public IWebDriver getDriver(bool remote)
        {
            if (remote)
            {
                return RemoteDriver();
            }
            else
            {
                return LocalDriver();
            }
        }

        public abstract IWebDriver LocalDriver();

        public IWebDriver RemoteDriver()
        {
            string seleniumGrid = "";
            Driver = new RemoteWebDriver(new Uri(seleniumGrid), Capabilities());
            return Driver;
        }

    }
}
