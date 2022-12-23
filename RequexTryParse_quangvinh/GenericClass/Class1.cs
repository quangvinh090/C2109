using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;

internal class Class1<T>
{
    public T Feild { get; set; }
    public void Show() => Console.WriteLine(Feild);
}
