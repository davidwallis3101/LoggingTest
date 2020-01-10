using System;
using ClassLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // https://visualstudiomagazine.com/articles/2019/03/22/logging-in-net-core.aspx

            
            // Setting up dependency injection
            var serviceProvider = new ServiceCollection()
                .AddLogging(builder => builder.AddConsole())
                .AddTransient<MyThing>() // Don't want to have to do this for things within the class library which the consumer wont be aware of if a nuget package - rather than this example in a soloution.
                .BuildServiceProvider();

            // get a logger for use in the console app - correct way?? 
            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogInformation("Message from Main");

            // Get an instance of the service
            var myService = serviceProvider.GetService<MyThing>();

            // Call the service (logs are made from within here and ideally with the class / method details)
            myService.TestDoingSomething();

            // Logging doesnt show in console output unless you have a breakpoint or something to stop the program exiting in this example.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
