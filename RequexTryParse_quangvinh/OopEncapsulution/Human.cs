

namespace OopEncapsulution;

internal class Human
{
    private string fullname;
    

    //thuc tính address
    public string Address { private get; set; } /// xài trên web, app
                                        /// </summary>
    public int Age { get; set; }

    //phương thức geter,seter
    //public void SetFullname(string fullname)
    //{
    //    this.fullname = fullname;
    //}

    //public string GetFullname()
    //{
    //    return fullname;
    //}


    //property theo C# cũ
    public string FullName //xài cho IOS
    {
        set => fullname = value;
        get => fullname;
        
    }
    public void ShowProper()
    {
        Console.WriteLine($"{nameof(Address)}={Address}");
        Console.WriteLine($"{nameof(fullname)}={fullname}");
    }

}
