internal class Program
{
 //   delegate void Display();
    public static void Sub(int a, int b) => Console.WriteLine(a + b);
    public static void Show() => Console.WriteLine("C2109I1");
    public static int ReturnNumber() => 5;

    private static void Main(string[] args)
    {
        //local function
        void Add(int a, int b) => Console.WriteLine(a + b);
        //func va action => deu la delegate
        //action dung cho cac phuong thuc laf void
        //func dunf cho cac phuong thuc khac voidc
 //       Display a = Show;
   //     a();
        Action act = Show;
        act();
    }
}