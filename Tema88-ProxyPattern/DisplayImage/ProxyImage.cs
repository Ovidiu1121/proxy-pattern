using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema88_ProxyPattern.DisplayImage
{
    public class ProxyImage:Image
    {
        public Image image;
        public string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;

            if (image==null)
            {
                image=new ConcreteImage(this.filename);
            }

        }

        public override void display()
        {
            Console.WriteLine("\n The proxy call is happening now.");
            image.display();

        }
    }
}
