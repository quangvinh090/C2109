using ExiecOop.Entity;
using ExiecOop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExiecOop.Dal;


internal class DalProduct: IProduct
{
    public List<Product> Products { get; set;} = new List<Product>();
    public void AddProduct()
    {

    }
}
