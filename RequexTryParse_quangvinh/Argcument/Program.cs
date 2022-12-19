using Argcument;
//pure OOP
//Argcument argu = new Argcument();

//use var
//var argu = new Argument();

//target-type
Argument argu = new();


//named argument
argu.Display(4,5,6);
argu.Display(a:4, b:5, c:6);
argu.Display(a:4, b:5, 6);
argu.Display(c:4, a:5, b:6);



argu.Show();
argu.Show(10);
argu.Show(10, 5);
argu.Show(10, 5, 4);
argu.Show(b: 10, c: 5);


argu.SumParam(1);
argu.SumParam(1,2,3);

int[] mang = {1,2,3,4,5};
argu.SumParam(mang);