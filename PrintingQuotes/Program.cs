Console.WriteLine("Please enter your quote: ");
String quote = Console.ReadLine();

Console.WriteLine("Who said it? ");
String person = Console.ReadLine();

Console.WriteLine("{0} said \"{1}\"", person, quote);

// alternative version:
// Console.WriteLine($"{person} said \"{quote}\"");