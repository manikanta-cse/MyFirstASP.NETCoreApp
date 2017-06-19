using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MyFirstASP.NETCoreApp
{
    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration configuration)
        {
           _greeting= configuration["Greeting"];
        }
        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
