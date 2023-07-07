System.Console.WriteLine("Enter a string:");

String myInput = Console.ReadLine();

int count = 0;

foreach (char c in myInput)
{
    count++;
}

Console.WriteLine("You entered: {0}", myInput);
System.Console.WriteLine("It has {0} characters.", count);