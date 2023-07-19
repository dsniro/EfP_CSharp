Console.WriteLine("How many people?");
int numPeople = Int32.Parse(Console.ReadLine());
Console.WriteLine("How many pizzas do you have?");
int numPizza = Int32.Parse(Console.ReadLine());

Console.WriteLine("{0} people with {1} pizza(s)", numPeople, numPizza);

// calculations and handling scenarios

int slices = numPizza * 8;
int leftovers;
int slicesPerPerson; 

if (slices > numPeople && slices%numPeople ==0)
{
    slicesPerPerson = slices / numPeople;    
    Console.WriteLine("Each person gets {0} slices. There are no leftovers", slicesPerPerson);
}
else if (slices > numPeople && slices%numPeople > 0 )
{
    leftovers = slices % numPeople;
    slicesPerPerson = slices / numPeople;
    if(leftovers > 1)
    {
        Console.WriteLine("Each person gets {0} slices. There are {1} leftover slices", slicesPerPerson, leftovers);
    }
    else
    {
        Console.WriteLine("Each person gets {0} slices. There is one left!", slicesPerPerson);
    }
}
else 
{
    System.Console.WriteLine("There's more people than slices, time to draw straws!");
}


