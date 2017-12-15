using log4net;
using System;

namespace Log4NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Log4NetLogger(LogManager.GetLogger(typeof(Log4NetLogger)));

            Log4NetConfigurer.ConfigureLogger();

            logger.WriteError("Context", "Error");

            Console.ReadLine();
        }
    }
}
