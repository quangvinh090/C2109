using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphinsInterface;

internal interface IBinaryFile
{
    //Có kiểu trả về và tên phương thức 
    void WriteBinaryFile();
    void ReadFile();
    //phương thức mặc định của interface
    void ShowInfor() => Console.WriteLine("this is binary file");

}
