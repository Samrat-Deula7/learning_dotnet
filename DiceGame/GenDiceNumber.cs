namespace DiceGameLogic
{
    class GenDiceNumber
    {
        public int result { get; private set; }

        Random randomNum = new Random();

        public GenDiceNumber(int sidesCount)
        {
            result = randomNum.Next(1, sidesCount + 1);
        }
    }
}