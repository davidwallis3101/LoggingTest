using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    internal class AnotherThing
    {
        internal AnotherThing(string something, int somethingElse, ILogger logger)
        {
            logger?.LogInformation("Another thing logging some info");
        }

    }
}
