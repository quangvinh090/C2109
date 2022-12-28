using UsingTuple;


// object In
Person per = new()
{
    Id = 1,
    FirstName = "truong",
    LastName  = "nguyen"
};

Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName);

//dung valuetuple khong can den class 

ValueTuple<int, string, string> p1 = (1, "truong", "nguyen");
Console.WriteLine(p1.Item1);
Console.WriteLine(p1.Item2);

//moi hon
(int, string, string) p2 = (1, "truong", "nguyen");
Console.WriteLine(p1.Item2);
Console.WriteLine(p1.Item3);

//dung var
var p3 = (1, "quang", "vinh");

var p4 = (1); //variable int p4 = 1


//net cor dung name thay the cho cacc cai item1, item2
(int id, string firstName, string lastName) p5 = (1, "quang", "vinh");
Console.WriteLine(p5.firstName);
Console.WriteLine(p5.lastName);

//hoac dung name phia trc
var p6 = (id: 1, firstName: "Quang", lastName: "Vinh");
Console.WriteLine(p6.firstName);
Console.WriteLine(p6.lastName);


//khong phai laf tuple => anonymous type
var p7 = new { id = 1, firstName = "Quang", lastname = "Vinh" };
Console.WriteLine(p7.firstName);
Console.WriteLine(p7.lastname);