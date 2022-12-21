using ExtentionMethod;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Vui long nhap 1 so: ");
int i = int.TryParse(Console.ReadLine(), out var result) ? result : 0; //

// ktra xem i co lon hon 100 ko?
CheckNumber.Check(i, 100);

//extention method
// khong thong qua doi tuong cua class dang chua maf thong qua cai muon su dung
i.isGreaterThan(100);

int abc = 500;
abc.isGreaterThan(200);