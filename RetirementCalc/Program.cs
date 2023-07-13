Console.WriteLine("What is your current age?");
string currAge = Console.ReadLine();
int currAgeInt = Int32.Parse(currAge);
Console.WriteLine("What age would you like to retire?");
string retire = Console.ReadLine();
int retireInt = Int32.Parse(retire);
int diff = retireInt - currAgeInt;

Console.WriteLine("You have {0} years left until you can retire.", diff);

int currYear = DateTime.Now.Year;
int retYear = currYear + diff;

Console.WriteLine("It is {0}, so you can retire in {1}", currYear, retYear);