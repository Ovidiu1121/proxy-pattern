using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.DisplayImage
{
    public class ConcreteImage : Image
    {
        public string filename;

        public ConcreteImage(string filename)
        {
            this.filename = filename;   
        }

        public override void display()
        {
            Console.WriteLine("Displaying image: "+this.filename);
        }
    }
}
