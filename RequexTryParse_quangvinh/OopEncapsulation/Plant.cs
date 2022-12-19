using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulation;
    public class Plant
    {
    //encapsulation th hien o 2 cho 
    //access modify
    //property
    private             void Private()          => Console.WriteLine("Private"); // đứng tại class đó mới đc xài
    protected           void Protected()        => Console.WriteLine("protected");// chỉ có con nó mới đc xài
    internal            void Internal()         => Console.WriteLine("internal");// trong cùng 1 project là được xài 
    private protected   void PrivateProtected() => Console.WriteLine("PrivatePrtected");//đứng tại class hoặc con là được xài
    protected internal    void ProtectedInternail () => Console.WriteLine("PrtectedIntermal");
    public              void Public()           => Console.WriteLine("public"); // ko cần điều kiện 
    }

