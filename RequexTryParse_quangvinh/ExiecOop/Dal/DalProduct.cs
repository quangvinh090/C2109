using ExiecOop.Entity;
using ExiecOop.Helper;
using ExiecOop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExiecOop.Dal;


internal class DalProduct: IProduct
{
    public List<Product> Products { get; set;} = new List<Product>();
    public void AddProduct()
    {
        Console.WriteLine("Enter the number of product");
        var n = Validate<int>.CheckReadline();
        for (int i = 0; i < n; i++)
        {
            Product pro = new();
            Console.WriteLine($"Product [{i+1}] => enter id product");
            pro.ProId = Validate<string>.CheckReadline();

            LisrPro.Add(pro);
        }
    }
}
