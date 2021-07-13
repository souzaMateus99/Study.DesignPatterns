using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Studies.DesignPatterns.BuilderDirector.Builder
{
    public class ChromeDriverBuilder : WebDriverBuilder<ChromeOptions>
    {
        public ChromeDriverBuilder()
            : base()
        { }

        public override void AcceptInsecureCertificates()
        {
            options.AcceptInsecureCertificates = true;
        }

        public override IWebDriver GetDriver(string path = "")
        {
            return string.IsNullOrWhiteSpace(path) ? new ChromeDriver(options) : new ChromeDriver(path, options);
        }

        public override void NoUseBrowser()
        {
            options.AddArgument(HEADLESS_ARGUMENT_VALUE);
        }

        public override void NoUseGpu()
        {
            options.AddArgument(DISABLE_GPU_ARGUMENT_VALUE);
        }

        public override void NoUseSandbox()
        {
            options.AddArgument(NO_SANDBOX_ARGUMENT_VALUE);
        }

        public override void PageLoadStrategy(PageLoadStrategy pageLoadStrategy)
        {
            options.PageLoadStrategy = pageLoadStrategy;
        }

        public override void WindowSize(int width, int height)
        {
            options.AddArgument(string.Format(WINDOW_SIZE_ARGUMENT_VALUE, width, height));
        }
    }
}