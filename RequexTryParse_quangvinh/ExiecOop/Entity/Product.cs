using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExiecOop.Entity;


internal class Product
{
    public string ProId { get; set; }
    public string ProName { get; set; }
    public string ProPrice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set; }



    public override string ToString()
    {
        return $"{{{nameof(ProId)}={ProId}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice}, {nameof(ProQuantity)}={ProQuantity}, {nameof(ProDate)}={ProDate.ToString("dd/MM/yyyy h:m:s")}}}";
    }
}
