using Studies.DesignPatterns.BuilderDirector.Builder;

namespace Studies.DesignPatterns.BuilderDirector.Director
{
    public class WebDriverDirector
    {
        private readonly IWebDriverBuilder _driverBuilder;
        
        public WebDriverDirector(IWebDriverBuilder driverBuilder)
        {
            _driverBuilder = driverBuilder;
        }

        public void MakeChromeDriver()
        {
            _driverBuilder.AcceptInsecureCertificates();
            _driverBuilder.NoUseBrowser();
            _driverBuilder.NoUseGpu();
        }

        public void MakeEdgeDriver()
        {
            _driverBuilder.AcceptInsecureCertificates();
            _driverBuilder.NoUseGpu();
        }
    }
}