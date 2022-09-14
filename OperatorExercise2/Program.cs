//Exercise 1:
//Write out the results of addition, subtraction, multiplication, division, and modulus operations.

using OperatorExercise2;
Console.WriteLine("-----------------Exercise 1--------------");
Console.WriteLine();

int a = 17;
int b = 4;

int c = a + b;

int d = a - b;

int e = a * b;

int quotient = a / b;

int remainder = a % b;

Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

Console.WriteLine();
Console.WriteLine();
//Exercise 2:
//Create a method that will Calculate the area of a circle based on its radius
Console.WriteLine("-----------------Exercise 2--------------");
Console.WriteLine();
Console.WriteLine();

Methods.AreaOfCircle();


Console.WriteLine();
Console.WriteLine();
///Thought Exercise
Console.WriteLine("-----------------Thought Exercise --------------");
Console.WriteLine();
Console.WriteLine();
//What is the value of k?

var i = 3;
var j = 4;
var k = ++i * j++;

Console.WriteLine(k);


//k should equal 16.  j++ doesn't change in value unless the equation is run more than one time.  This isn't a loop
// so it doesn't run more than one time.  When the code reads it says increase i by one to make 4 and then multiple
//by j so 4*4=16

