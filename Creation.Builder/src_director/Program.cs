using System;
using OpenQA.Selenium.Chrome;
using Studies.DesignPatterns.BuilderDirector.Builder;
using Studies.DesignPatterns.BuilderDirector.Director;

namespace Studies.DesignPatterns.BuilderDirector
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chromeBuilder = new ChromeDriverBuilder();
            var driverDirector = new WebDriverDirector(chromeBuilder);
            driverDirector.MakeEdgeDriver();
            
            var chromeDriver = chromeBuilder.GetDriver();

            var edgeBuilder = new EdgeDriverBuilder();
            driverDirector = new WebDriverDirector(edgeBuilder);
            driverDirector.MakeEdgeDriver();

            var edgeDriver = edgeBuilder.GetDriver();
        }
    }
}
