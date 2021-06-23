using System;

namespace MultithreadedProgram
{
    public class RandomHelper
    {
        public static ConsoleColor GetRandomColor()
        {
            Random random = new Random();
            int num = random.Next(Constants.LenghtOfConsoleColorEnum);
            return ConvertHelper.ConvertIntToConsoleColor(num);
        }

        public static char GetRandomSymbol()
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
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
