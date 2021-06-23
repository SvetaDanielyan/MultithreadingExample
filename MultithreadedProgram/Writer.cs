using System;

namespace MultithreadedProgram
{
    public class Writer
    {
        private char Symbol { get; set; }
        private ConsoleColor Color { get; set; }

        public Writer(char symbol, ConsoleColor color)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Write()
        {
            Console.ForegroundColor = Color;
            Console.Write(Symbol);
        }
    }
}
