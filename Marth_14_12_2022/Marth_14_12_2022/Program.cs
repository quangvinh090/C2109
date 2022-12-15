//ctrl + K + D

double a = 0.1;
double b = 0.2;
Console.WriteLine(a+b==0.3?"true": "false");

//float c = 0.2f;
decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c + d == 0.3M ? "true" : "false");

//?: => ternary operar

// ? nulable value type
string fullname = null;
//int i = 0;
//C# cu
//Nullable<int> i = null;
//C# new
bool? check = null;

//int length = fullname != null ? fullname.Length : 0;    
int? length = fullname is not null ? fullname.Length : null;
//var a = 10;
//if(a is 10)
//{}

// null-conditional operator ?
// ? fullname? == !=, fullname != null -> ve sau
int? lenght = fullname?.Length;

//null-coalesing operator ?? 
// tuong tu ==, fullname =  null tra ve ve sau
int? chieudai = fullname?.Length ?? 0;   