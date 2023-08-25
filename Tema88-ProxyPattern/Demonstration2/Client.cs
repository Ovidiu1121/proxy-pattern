using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration2
{
    public class Client
    {

        public Client()
        {

            Console.WriteLine("***Modified Proxy Pattern Demonstration.***");
            // Admin is an authorized user
            Subject proxy = new ProxySubject();
            proxy.doSomeWork("Admin");
            // Robin is an unauthorized user
            proxy.doSomeWork("Robin");

        }

    }
}
