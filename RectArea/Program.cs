Console.WriteLine("What is the length of the room in feet?");
int lengthFeet = Int32.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the room in feet?");
int widthFeet = Int32.Parse(Console.ReadLine());

Console.WriteLine("You entered the dimensions of {0} feet by {1} feet", lengthFeet, widthFeet);

int areaFeet = lengthFeet * widthFeet;

System.Console.WriteLine("The area is");
System.Console.WriteLine("{0} square feet", areaFeet);

double areaSquareMeters = areaFeet*0.09290304;

System.Console.WriteLine("{0} square meters", Math.Round(areaSquareMeters, 3));