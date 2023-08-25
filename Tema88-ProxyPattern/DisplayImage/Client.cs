using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.DisplayImage
{
    public class Client
    {

        public Client()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");

            Image image=new ProxyImage("image1.jpg");
            image.display();
        }

    }
}
