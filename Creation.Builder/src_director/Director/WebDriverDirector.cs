using System;
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

        public void MakeDefaultDriver()
        {
            _driverBuilder.AcceptInsecureCertificates();
        }

        public void MakeDriverWithoutBrowser()
        {
            _driverBuilder.AcceptInsecureCertificates();
            _driverBuilder.NoUseBrowser();
        }

        public void MakeDriverToUseContainer()
        {
            _driverBuilder.AcceptInsecureCertificates();
            _driverBuilder.NoUseBrowser();
            _driverBuilder.NoUseGpu();
            _driverBuilder.NoUseSandbox();
        }
    }
}