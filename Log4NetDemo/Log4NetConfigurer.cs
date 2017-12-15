using log4net.Config;

namespace Log4NetDemo
{
    public class Log4NetConfigurer
    {
        public static void ConfigureLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
