using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RefOut;

internal class UseRefOut
{
        //expression boddy
        //khi 1 phuong thuc chi co 1 cau lenh
        public void ShowInfor() =>
            Console.WriteLine("thong tin ve class nay");
        public static void ChangeNum(ref int a, ref int b)
        //public static void ChangeNum(out int a, out int b)
    {
    //    a = 5;

    //b = 10;
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"ChangeNumber: {nameof(a)}={a},{ nameof(b)}={b}");
    }
}

