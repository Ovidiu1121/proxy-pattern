using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration2
{
    public class ConcreteSubject : Subject
    {

        public override void doSomeWork(string user)
        {
            Console.WriteLine(user+ " invokes the method-doSomeWork().");
        }
    }
}
