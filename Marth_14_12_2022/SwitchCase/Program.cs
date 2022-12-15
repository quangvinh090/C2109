using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int number1 = Random.Shared.Next(0,9);
int number2 = Random.Shared.Next(0,9);
Console.WriteLine($"{nameof(number1)} = {number1}");
Console.WriteLine($"{nameof(number2)} = {number2}");

Console.WriteLine("vui long nhap dau");
var pheptoan = Console.ReadLine();
//switch(pheptoan)
//{
//    case "+" when number1 > 0 && number2 >number1: 
//        Console.WriteLine(number1+ number2); 
//        break;
//    case "-" when number2 <= number1:
//        Console.WriteLine(number1 - number2);
//        break;
//    case "*":
//        Console.WriteLine(number2 * number1);
//        break;
//    case "/" when number2 != 0:
//        Console.WriteLine(number1 / number2);
//        break;
//    default: Console.WriteLine("I can't do it");
//        break;
//}

Console.WriteLine(
    pheptoan switch
    {
        "+" when number1 > 0 && number2 > number1   => number1 + number2,
        "-" when number2 <= number1                 => number2 * number1,
        "*"                                         => number1 * number2,
        "/" when number2 != 0                       => number1 / number2,
        _ => "I can't do it"
    }
    ) ;