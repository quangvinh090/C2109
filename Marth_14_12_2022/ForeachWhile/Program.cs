using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string[] arrs = { "op", "na", "co", "fai" };
foreach(var t in arrs)
{
    Console.WriteLine($"{t} cos chieu dai {t.Length}");
}

//int i = 0;
//while(i < arrs.Length)
//{
//    Console.WriteLine($"{arrs[i]} co chieu dai la {arrs[i].Length}");
//   i++;
//}
IEnumerator e = arrs.GetEnumerator();
while ( e.MoveNext())
{
    String s = (string)e.Current;
    Console.WriteLine($"{s} co chieu dai {s.Length}");
}
