internal class Program
{
    //   delegate void Display();
    public static int Addd(int a, int b) => a - b;
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

        Action<int, int> ac = Sub;
        ac(5,6);
        //Action a = Add;  local function ko xai dc 
        //a(5,6);


        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Func<int, int, int> fu = Addd;
        Console.WriteLine(fu(10,5));

        Action action = () =>
        {
            Console.WriteLine("ahihi");
        };
        action();

        //Action string action = (str) =>
        //{
        //    Console.WriteLine(str);
        //};
        //action("hello");
        //        action.Invoke();
    }
}