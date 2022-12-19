using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride
{
    internal class Child:Parent 
    {
        public override void Display()
        {
            Console.WriteLine("child display");
        }
        public void Show()
        {
            Console.WriteLine("child show");
        }
    }
}
