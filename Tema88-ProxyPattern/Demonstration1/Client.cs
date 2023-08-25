using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration1
{
    public class Client
    {
        public Client()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            // ConcreteSubject has package-private visibility
            // So, you cannot make an instance of it here.
            //Subject cs = new ConcreteSubject();//Error
            Subject proxy = new ProxySubject();
            proxy.doSomeWork();
        }
    }
}
