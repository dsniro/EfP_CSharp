Console.WriteLine("What is the length of the room in feet?");
int lengthFeet = Int32.Parse(Console.ReadLine());    


Console.WriteLine("What is the width of the room in feet?");
int widthFeet = Int32.Parse(Console.ReadLine());


int areaFeet = lengthFeet * widthFeet;

//System.Console.WriteLine(areaFeet);

int diffArea = areaFeet / 350;

if (diffArea < 1)
{
    Console.WriteLine("You will need one gallon of paint to cover {0} square feet.", areaFeet);
}
else if (diffArea > 1 && (diffArea % 350 == 0))
{
    //int multiplier = Math.Floor(diffArea);
    System.Console.WriteLine("You will need {0} gallons of paint to cover {1} square feet.", diffArea, areaFeet);
}
else
{
    int maxPaint = diffArea + 1;
    System.Console.WriteLine("You will need {0} gallons of paint to cover {1} square feet.", maxPaint, areaFeet);
}