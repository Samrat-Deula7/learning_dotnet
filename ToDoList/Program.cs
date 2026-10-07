Console.WriteLine("Hello! bro what's up !!!");
Console.WriteLine("What do you want to do my guy?");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

bool isUserInputAbc = userChoice == "ABC";

if (userChoice == "S")
{
    PrintSelectedOption("Selected option: See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Selected option: Add all TODOs");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Selected option: Remove a TODOs");
}
else
{
    PrintSelectedOption("Selected option: Exit");
}
Console.WriteLine(isUserInputAbc);

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}