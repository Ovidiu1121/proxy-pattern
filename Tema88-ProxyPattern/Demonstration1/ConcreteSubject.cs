using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration1
{
    public class ConcreteSubject:Subject
    {

        public ConcreteSubject() {
        
        }

        public override void doSomeWork()
        {
            Console.WriteLine("The doSomeWork() is executed.");
        }
    }
}
