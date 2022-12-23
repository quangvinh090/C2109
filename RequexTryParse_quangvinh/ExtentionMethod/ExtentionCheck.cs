using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
//bien class thanh eextention method
//=> class buoc phai la static
// 1 class la static thi toan bo ben trong no phai la static
internal static class ExtentionCheck
{
    public static void isGreaterThan(this int i, int value)
    {
        if (i > value)
        {
            Console.WriteLine($"{i}dung la lon hon {value}");
        }
        
    }
    public static void Hi(this Program obj) => Console.WriteLine("ahihi");
}
