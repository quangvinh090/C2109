using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopEncapsulation;

namespace OopEncapsulationCOnt;

internal class Weed : Plant
{
    static void Main(string[] args)
    {
        Weed w = new Weed();
        w.ProtectedInternail();
        w.Protected();
    }
}
