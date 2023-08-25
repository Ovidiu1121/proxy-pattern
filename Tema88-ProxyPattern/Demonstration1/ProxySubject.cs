using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration1
{
    public class ProxySubject:Subject
    {
        private Subject subject;

        public ProxySubject()
        {
            // We create only one instance
            // of the ConcreteSubject
            if (subject == null)
            {
                subject = new ConcreteSubject();
            }
        }

        public override void doSomeWork()
        {
            Console.WriteLine("Proxy call is happening now.");
            subject.doSomeWork();
        }
    }
}
