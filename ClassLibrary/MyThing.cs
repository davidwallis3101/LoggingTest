using System;
using Microsoft.Extensions.Logging;


namespace ClassLibrary
{


    public class MyThing
    {
        private readonly ILogger<MyThing> logger;


        // constructor for DI
        public MyThing(ILogger<MyThing> logger = null)
        {
            this.logger = logger;
        }

        //public MyThing(string something, int somethingElse, ILogger<MyThing> logger)
        //{
        //    this.logger = logger;

        //    // do somthing
        //    logger?.LogInformation("Mything logging some info");
        //    Helpers.TestDoingSomething(this.logger);

        //}

        public void TestDoingSomething()
        {
            logger.LogWarning("a warning");
            logger?.LogInformation("TestDoingSomething Log Message");
        }
    }
}
