using System;

namespace MultithreadedProgram
{
    public static class ConvertHelper
    {
        public static ConsoleColor ConvertIntToConsoleColor(this int value)
        {
            return (ConsoleColor)value;
        }
    }
}
