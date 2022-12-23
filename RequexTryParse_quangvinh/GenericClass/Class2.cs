using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;

internal class Class2<B, C>
{
    public B Field1 { get; set; }
    public C Field2 { get; set; }
    public void Show() => Console.WriteLine($"{Field1}, {Field2}");
}
