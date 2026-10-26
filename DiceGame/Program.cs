namespace DiceGameLogic
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenDiceNumber diceNumber = new GenDiceNumber();
            Console.WriteLine($"You rolled: {diceNumber.result}");
        }
    }
}
