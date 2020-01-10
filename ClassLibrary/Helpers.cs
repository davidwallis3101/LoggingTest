using System;
using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    public static class Helpers
    {
        public static void TestDoingSomething(ILogger logger)
        {
            // ILogger<T> used in a static class?
            
            // do some thing here

            
            logger?.LogInformation("static class logging some info");
            // Log something from here with class / method name
        }
    }
}
