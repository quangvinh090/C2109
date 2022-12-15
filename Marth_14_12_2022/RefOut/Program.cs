
using RefOut;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int a = 10;
int b = 5;

UseRefOut.ChangeNum(ref a, ref b);
Console.WriteLine($"ChangeNumber2: {nameof(a)}={a},{nameof(b)}={b}");