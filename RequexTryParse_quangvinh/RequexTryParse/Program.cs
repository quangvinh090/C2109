using System.Text;
using System.Text.RegularExpressions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string? str = null;
Console.WriteLine("Vui long nhap so: ");
str = Console.ReadLine();

var formula = new Regex("^[0-9]+$ "); //\\d
if (formula.IsMatch(str))
{
    //int result = int.Parse(str);
    int result = Convert.ToInt32(str);
    Console.WriteLine(++result);

}
if (int.TryParse(str, out int i))
{
    Console.WriteLine($"i la so: {i}");
}


Console.WriteLine("vui long nhap so luowng");
string? amount = Console.ReadLine();
// dung try catch
// menh de "guard clause"
if (string.IsNullOrEmpty(amount)) 
{
    return;
}
//if (amount != null)
//{
//    // lam gi do
//}
try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("phai lon hon 0");
    Console.WriteLine($"{nameof(total)}= {total}");
}
catch (Exception) when (amount.Contains("$"))
{
    Console.WriteLine("chuoi ko duoc co dau $");
}
catch(Exception e)
{
    Console.WriteLine($"{e.GetType}.{e.Message}");
}
