using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_specflow_NET.support.browser
{
    public class ChromeBrowser : AbstractBrowser
    {
        public ChromeBrowser(string method) : base(method)
        {
        }

        public override IWebDriver LocalDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            var webDriver = new ChromeDriver((ChromeOptions)Options());
            return webDriver;
        }

        public override DriverOptions Options()
        {
            ChromeOptions options = new ChromeOptions();

            //options.AddArguments("headless", "disable-gpu", "renderer");
            options.AddArgument("disable-translate");
            options.AddArgument("no-default-browser-check");
            options.AddArgument("site-per-process");
            options.AddArgument("disable-3d-apis");
            options.AddArgument("disable-background-mode");
            options.AddArgument("site-per-process");
            options.AddArgument("--test-type");
            options.AddArgument("start-maximized");
            options.AddArgument("disable-popup-blocking");
            options.AddArgument("--disable-plugins");

            options.AddUserProfilePreference("profile.managed_default_content_settings.images", 2);
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.default_content_settings.popups", 0);
            options.AddUserProfilePreference("profile.content_settings.pattern_pairs.*.multiple-automatic-downloads", 1);
            options.AddUserProfilePreference("download.prompt_for_download", false);

            return options;
        }

    }
}
