using OpenQA.Selenium;
using System;

namespace Selenium_specflow_NET.support.browser
{
    public class BrowserFactory
    {
        private String browser;
        private String method;

        public BrowserFactory(String browser="chrome", String method="local")
        {
            this.browser = browser;
            this.method = method;
        }

        public IWebDriver getBrowser()
        {
            IBrowser ibrowser;

            switch (browser)
            {
                case "chrome":
                    {
                        ibrowser = new ChromeBrowser(method);
                        return ibrowser.getDriver(false);
                    }
                case "firefox":
                    {
                        //ibrowser = new Firefox(method);
                        //return ibrowser.getBrowser();
                        return null;
                    }
                case "ie":
                    {
                        //ibrowser = new InternetExplorer(method);
                        //return ibrowser.getBrowser();
                        return null;
                    }
                default:
                    {
                        throw new Exception("Browser " + browser + " is not recognized");
                        //throw new Error("Browser " + browser + " is not recognized");
                    }
            }
        }

    }
}
