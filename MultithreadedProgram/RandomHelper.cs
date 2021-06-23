using System;

namespace MultithreadedProgram
{
    public static class RandomHelper
    {
        public static ConsoleColor GetRandomColor()
        {
            Random random = new Random();
            int colorEnumLength = Enum.GetNames(typeof(ConsoleColor)).Length;
            int num = random.Next(colorEnumLength);
            return ConvertHelper.ConvertIntToConsoleColor(num);
        }

        public static char GetRandomSymbol()
        {
            string chars = Constants.AllSymbols;
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        public static int GetRandomDelay()
        {
            Random random = new Random();
            return random.Next(0, 3000);
        }
    }
}
