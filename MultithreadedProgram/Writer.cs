using System;
using System.Threading;

namespace MultithreadedProgram
{
    public class Writer
    {
        private char Symbol { get; set; }
        private ConsoleColor Color { get; set; }
        private int Delay { get; set; }
        public Writer(char symbol, ConsoleColor color, int delay)
        {
            Symbol = symbol;
            Color = color;
            Delay = delay;
        }

        public void Write()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Symbol);
            Thread.Sleep(Delay);
        }
    }
}
