bool isRunning = true;
List<string> dataStorage = new List<string>();

void options()
{
    Console.WriteLine("");
    Console.WriteLine("What do you want to do my guy?");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    string userChoice = Console.ReadLine();

    switch (userChoice.ToUpper())
    {
        case "S":
            seeAllTodos();
            break;

        case "A":
            addTodo();
            break;

        case "R":
            removeTodo();
            break;

        case "E":
            isRunning = false;
            break;

        default:
            Console.WriteLine("Wrong options bro .");
            break;

    }
}

void seeAllTodos()
{
    for (int i = 0; i < dataStorage.Count(); i++)
    {
        Console.WriteLine($"{i + 1}. {dataStorage[i]}");
    }
}

void addTodo()
{
    Console.WriteLine("Describe the todo to add.");
    string toAdd = Console.ReadLine();

    if (toAdd == "")
    {
        Console.WriteLine("Invalid description shouldn't be empty.");
    }

    foreach (string todo in dataStorage)
    {
        if (toAdd == todo)
        {
            Console.WriteLine("The description should be unique.");
            return;
        }
    }
    dataStorage.Add(toAdd);
}

void removeTodo()
{
    Console.WriteLine("Which number do you wanna delete");
    seeAllTodos();
    string indexToDeletefrom = Console.ReadLine();
    int numbertoDelete;
    bool isParsingSuccessful = int.TryParse(indexToDeletefrom, out numbertoDelete);

    if (indexToDeletefrom == "" || indexToDeletefrom == "0" || numbertoDelete > dataStorage.Count() || !isParsingSuccessful)
    {
        Console.WriteLine("Invalid index try again");
        removeTodo();
    }
    else
    {
        dataStorage.RemoveAt(numbertoDelete - 1);
        Console.WriteLine("Deleted successfully!");
    }
}

Console.WriteLine("Hello! bro what's up !!!");

do
{
    options();
}
while (isRunning);
