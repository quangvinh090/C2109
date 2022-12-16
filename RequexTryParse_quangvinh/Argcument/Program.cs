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
