using ExiecOop.Entity;
using ExiecOop.Helper;

Product pro = new();
//Console.WriteLine("Vui long nhap Id");
//pro.ProId = Validate<string>.CheckReadline();
//Console.WriteLine("Vui long nhap so luong");
//pro.ProQuantity = Validate<int>.CheckReadline();
Console.WriteLine("Vui long nhap ngay");
pro.ProDate = Validate<DateTime>.CheckReadline();
Console.WriteLine(pro);
