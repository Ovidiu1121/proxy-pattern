using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.Demonstration2
{
    public class ProxySubject : Subject
    {
        private Subject subject;
        string currentUser;
        List<string> registeredUsers;

        public ProxySubject()
        {
            // We need to create only one instance
            // of the ConcreteSubject.
            if (subject == null)
            {
                subject= new ConcreteSubject();
            }
            registeredUsers = new List<string>();
            registeredUsers.Add("Admin");
            registeredUsers.Add("Kate");
            registeredUsers.Add("Sam");
        }

        public override void doSomeWork(string user)
        {
            Console.WriteLine("\n The proxy call is happening now.");
            Console.WriteLine(user+" wants to invoke a proxy method.");
            if (registeredUsers.Contains(user))
            {
                // Allow the registered user to invoke the method
                subject.doSomeWork(user);
            }
            else
            {
                Console.WriteLine("Sorry, "+ user+ ",you do not have access rights.");
         }
        }
    }
}
