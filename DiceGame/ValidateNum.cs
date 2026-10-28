namespace DiceGameLogic
{
    class ValidateNum
    {
        public bool Checking(dynamic numToValidate)
        {
            string input = Convert.ToString(numToValidate);

            return int.TryParse(input, out _);
        }
    }
}