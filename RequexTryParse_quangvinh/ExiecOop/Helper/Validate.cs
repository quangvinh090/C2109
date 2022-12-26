using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExiecOop.Helper;

internal class Validate<T>
{
    public static T CheckReadline()
    {
        var typeCode = Type.GetTypeCode(typeof(T));
        object obj = new();
        bool flag;
        do
        {
            flag = true;
            try
            {
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("error, null or emty");
                }
                switch(typeCode)
                {
                    case TypeCode.Boolean:
                        obj = str;
                        break;
                    case TypeCode.Int32: 
                        obj = Convert.ToInt32(str);
                        if ((double)obj < 0) throw new Exception("value must be greate than 0");
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[] { "d/M/yyyy", "d-m-yyyy" }, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t)?t: throw new Exception
                            ("date wrong (d/M/yyyy, d-m-yyyy)");
                        obj = date.Add(DateTime.Now.TimeOfDay);
                        break;
                    default:
                        obj = null;
                        break;
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()}:{ e.Message}, please enter again");
                flag= false;
            }
        } while (!flag);
        return (T)obj;
    }
}
