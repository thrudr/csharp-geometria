// See https://aka.ms/new-console-template for more information
using Geometric;

Console.WriteLine("GEOMETRIC");

rectangle userRectangle = new rectangle();

Console.WriteLine("Inserire dimensione base rettangolo:");
int userBase = int.Parse(Console.ReadLine());
userRectangle.baseRectangle = userBase;

Console.WriteLine("Inserire dimensione altezza rettangolo:");
int userHeight = int.Parse(Console.ReadLine());
userRectangle.heightRectangle = userHeight;

Console.WriteLine("-------------------Rectangle------------------------");
userRectangle.printRectangle();
Console.WriteLine("----------------------------------------------------");
