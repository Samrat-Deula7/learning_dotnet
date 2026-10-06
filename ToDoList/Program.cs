Console.WriteLine("Hello! bro what's up !!!");
Console.WriteLine("What do you want to do my guy?");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

bool isUserInputAbc = userChoice == "ABC";

Console.WriteLine(isUserInputAbc);