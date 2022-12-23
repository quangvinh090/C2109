using ListAndLINQ;
using System.Collections;
using System.Diagnostics;

List<Student> list = new();
{
    new Student() { RollNumber = 1, FullName = "Vinh", Section = "so 1", HostelNumber = 1};
    new Student() { RollNumber = 2, FullName = "Vinh2", Section = "so 1", HostelNumber = 2 };
    new Student() { RollNumber = 3, FullName = "Vinh3", Section = "so 2", HostelNumber = 4 };
    new Student() { RollNumber = 4, FullName = "Vinh4", Section = "so 2", HostelNumber = 3 };
    new Student() { RollNumber = 5, FullName = "Vinh5", Section = "so 4", HostelNumber = 5 };
    new Student() { RollNumber = 6, FullName = "Vinh6", Section = "so 5", HostelNumber = 6 };
    new Student() { RollNumber = 7, FullName = "Vinh7", Section = "so 6", HostelNumber = 1 };
    new Student() { RollNumber = 8, FullName = "Vinh8", Section = "so 1", HostelNumber = 1 };
    new Student() { RollNumber = 9, FullName = "Vinh9", Section = "so 1", HostelNumber = 2 };

}
//Stopwatch sw = new Stopwatch();
//sw.Restart();   
//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//// tat ca ca dang cua collection deu co mau de duyet qua du lieu ma ko su dung for hay foreach => ienumarator
//IEnumerator<Student> enu = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//linq = language Intergrated query
//linq to sql
//linq to object 
// linq to xml, json
// parallel linq => pling
//from where group by having order => select

//linq to object co 2 dang
// style 1) thep truong phai sql=> query syntax, de hoc, de hieu
// style 2) theo truong phai lamda => method syntax, kho hoc, rat kho hieu

//liet ke tat ca sinh vien voi ma sinh vien lon hon 2


//foreach (var stu in list)
//{
//    if(stu.RollNumber > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//linq to obj style 1
//var liststu = from t in list   // var = IEnumerable
//              where t.RollNumber > 2
//              select t;
//Tinh tong so sih vien

//Console.WriteLine(liststu.Count());
/////////////////////////////////

//foreach (var stu in from stu in list
//                    where stu.RollNumber > 2
//                    select stu)
//{

//        Console.WriteLine(stu);

//}

//linq to object style 2
//var liststu2 = list.Where(stu=>stu.RollNumber > 2);
//foreach(var st in liststu2)
//{
//    Console.WriteLine(st);
//}


////linq 2 rut gon
//foreach (var st in list.Where(stu => stu.RollNumber > 2))
//{
//    Console.WriteLine(st);
//}
////Cac phuong thuc co san trong list
//list.ForEach(Console.WriteLine);
//list.ForEach(stu => Console.WriteLine(stu));

//list.ForEach(
// stu =>
// {
//     if (stu.RollNumber > 2)
//     {
//         Console.WriteLine(stu);
//     }
// }
//);

//// ket hop voi phuong thuc co san cua list
//list.Where (stu => stu.RollNumber > 2)
//    .ToList()
//    .ForEach(Console.WriteLine);

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // anonymous type
//        {
//            stu.RollNumber,
//            stu.FullName
//        };

//r.ToList().ForEach(Console.WriteLine);

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // anonymous type
//        {
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        };

//r.ToList().ForEach(Console.WriteLine);

//list.Select(stu=> new
//{
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//             StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        }).ToList().ForEach(Console.WriteLine);

foreach(var stu in list)
{
    Console.WriteLine(stu);
}

IEnumerator enu = list.GetEnumerator();
while (enu.MoveNext())
{

}

//Tu khi co linq

var t = from stu in list
        select stu;
//Lần đầu thực thi trên server và trả về bộ nhớ
//select * from líst where rollnumber > 2
IEnumerable<Student> i = from stu in list
                         where stu.RollNumber>2
                         select stu;
// IEnumerator lon hown able no laf vongf lawp foreach
i = i.Take(2);
//========================== phân trang
//Lần đầu thực thi trên server và trả về bộ nhớ.
// select * from list where rollnumber > 2
IQueryable<Student> u = from stu in list.AsQueryable()
                        where stu.RollNumber >2 
               select stu;
//select top (2) * from list where rollnumber > 2
// sẽ chạy lên server lần nữa 
u = u.Take(2);

//============ 
var  k = from stu in list 
         where stu.RollNumber >2
         select stu;
k.ToList().ForEach(Console.WriteLine);

// sắp xếp 
//list.Order(); // OrderDescending 
var obj1 = from stu in list
           where stu.RollNumber >5
           orderby stu.Section descending, stu.HostelNumber ascending
          select stu;

//method
var obj2 = list.Where(stu=> stu.RollNumber>5).OrderByDescending(stu => stu.Section).OrderBy(stu => stu.HostelNumber); // sai
var obj3 = list.OrderByDescending(stu => stu.Section).ThenBy(stu => stu.HostelNumber);




