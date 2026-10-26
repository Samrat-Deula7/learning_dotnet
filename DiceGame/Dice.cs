namespace DiceGameLogic
{
    class GenDiceNumber
    {
        public int result { get; private set; }

        Random randomNum = new Random();

        public GenDiceNumber()
        {
            result = randomNum.Next(1, 7);
        }
    }
}