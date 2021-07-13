using OpenQA.Selenium;

namespace Studies.DesignPatterns.BuilderDirector.Builder
{
    public interface IWebDriverBuilder
    {        
        void NoUseBrowser();
        void NoUseGpu();
        void NoUseSandbox();
        void WindowSize(int width, int height);
        void AcceptInsecureCertificates();
        void PageLoadStrategy(PageLoadStrategy pageLoadStrategy);
    }
}