using Studies.DesignPatterns.BuilderDirector.Builder;
using Studies.DesignPatterns.BuilderDirector.Director;

namespace Studies.DesignPatterns.BuilderDirector
{
    public class Program
    {
        static void Run()
        {
            var chromeBuilder = new ChromeDriverBuilder();
            var driverDirector = new WebDriverDirector(chromeBuilder);
            driverDirector.MakeDriverToUseContainer();
            
            var chromeDriver = chromeBuilder.GetDriver();

            var edgeBuilder = new EdgeDriverBuilder();
            driverDirector = new WebDriverDirector(edgeBuilder);
            driverDirector.MakeDefaultDriver();

            var edgeDriver = edgeBuilder.GetDriver();
        }
    }
}
