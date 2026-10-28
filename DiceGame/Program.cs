namespace DiceGameLogic
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int sidesCount = 6;
            GenDiceNumber diceNumber = new GenDiceNumber(sidesCount);

            ValidateNum isValid = new ValidateNum();


            Console.WriteLine("Dice roll game. Guess the number in 3 tries");

            int count = 0;
            bool isCorrect = false;

            do
            {
                Console.WriteLine("Enter a number");
                var userNumber = Console.ReadLine();

                if (isValid.Checking(userNumber!))
                {
                    if (int.Parse(userNumber!) == diceNumber.result)
                    {
                        isCorrect = true;
                        break;
                    }

                    count++;
                }
                else
                {
                    Console.WriteLine("String is not valid");
                }

            } while (count < 3);

            if (isCorrect == true)
            {
                Console.WriteLine("Congratulations you gussed right !!!");
            }
            else
            {
                Console.WriteLine("The guess was wrong");
            }
        }
    }
}
