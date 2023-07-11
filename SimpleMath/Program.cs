System.Console.WriteLine("Enter the first number: ");
string firstNumber = Console.ReadLine();
int firstInt = Int32.Parse(firstNumber);
//Console.WriteLine("The number is: {0}", firstInt);

System.Console.WriteLine("Enter the second number: ");
string secondNumber = Console.ReadLine();
int secondInt = Int32.Parse(secondNumber);
//Console.WriteLine("The number is: {0}", secondInt);

int Adder(int a, int b)
{
    return a + b;
}

int Subtractor(int a, int b)
{
    return a - b;
}

int Mux(int a, int b)
{
    return a * b;
}

float? Divider(int a, int b)
{
    if (b == 0)
        return null;
    
    else 
        return (float)a / (float)b;
}

// output block
System.Console.WriteLine($"\n{firstInt} + {secondInt} = {Adder(firstInt, secondInt)}" + 
                         $"\n{firstInt} - {secondInt} = {Subtractor(firstInt, secondInt)}" +
                         $"\n{firstInt} * {secondInt} = {Mux(firstInt, secondInt)}" +
                         $"\n{firstInt} / {secondInt} = {Divider(firstInt, secondInt)} ");