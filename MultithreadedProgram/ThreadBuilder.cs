using System;
using System.Threading;

namespace MultithreadedProgram
{
    public static class ThreadBuilder
    {
        public static void BuildThread()
        {
            char randomSymbol = RandomHelper.GetRandomSymbol();
            ConsoleColor randomColor = RandomHelper.GetRandomColor();
            int randomDelay = RandomHelper.GetRandomDelay();

            Writer writer = new Writer(randomSymbol, randomColor, randomDelay);
            Thread thread = new Thread(writer.Write);
            thread.Start();
        }
    }
}
