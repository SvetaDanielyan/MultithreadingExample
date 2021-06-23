using System;

namespace MultithreadedProgram
{
    public static class ConvertHelper
    {
        public static ConsoleColor ConvertIntToConsoleColor(int value)
        {
            return (ConsoleColor)value;
        }
    }
}
