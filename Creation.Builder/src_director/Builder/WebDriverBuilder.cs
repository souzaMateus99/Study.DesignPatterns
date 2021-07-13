using OpenQA.Selenium;

namespace Studies.DesignPatterns.BuilderDirector.Builder
{
    public abstract class WebDriverBuilder<TDriverOptions> : IWebDriverBuilder
    {
        protected const string HEADLESS_ARGUMENT_VALUE = "--headless";
        protected const string NO_SANDBOX_ARGUMENT_VALUE = "--no-sandbox";
        protected const string DISABLE_GPU_ARGUMENT_VALUE = "--disable-gpu";
        protected const string WINDOW_SIZE_ARGUMENT_VALUE = "--window-size={0}, {1}";
        protected readonly TDriverOptions options;
        
        public WebDriverBuilder()
        { }
        
        public abstract void AcceptInsecureCertificates();
        public abstract void NoUseBrowser();
        public abstract void NoUseGpu();
        public abstract void NoUseSandbox();
        public abstract void PageLoadStrategy(PageLoadStrategy pageLoadStrategy);
        public abstract void WindowSize(int width, int height);        
        public abstract IWebDriver GetDriver(string path = "");
    }
}