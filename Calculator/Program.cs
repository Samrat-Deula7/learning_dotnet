Console.WriteLine("Hello!");
Console.WriteLine("Input the first number");
string first = Console.ReadLine();
int firstNum = int.Parse(first);
Console.WriteLine("Input the second number");
string second = Console.ReadLine();
int secondNum = int.Parse(second);


Console.WriteLine("What do you want to do ?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine().ToLower();

if (userChoice == "a")
{
    doCalculation("+");
}
else if (userChoice == "s")
{
    doCalculation("-");
}
else
{
    doCalculation("*");
}

Console.WriteLine("Press any key to close ....");

Console.ReadLine();


void doCalculation(string choice)
{
    int result;

    if (choice == "+")
    {
        result = firstNum + secondNum;
    }
    else if (choice == "-")
    {
        result = firstNum - secondNum;
    }
    else
    {
        result = firstNum * secondNum;
    }
    Console.WriteLine(firstNum + " " + choice + " " + secondNum + " = " + result);
}