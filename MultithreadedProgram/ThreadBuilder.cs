using System;
using System.Threading;

namespace MultithreadedProgram
{
    public class ThreadBuilder
    {
        public static void BuildThread()
        {
            while (true)
            {
                char randomSymbol = RandomHelper.GetRandomSymbol();
                ConsoleColor randomColor = RandomHelper.GetRandomColor();
                int randomDelay = RandomHelper.GetRandomDelay();

                Writer writer = new Writer(randomSymbol, randomColor);
                Thread thread = new Thread(writer.Write);
                thread.Start();
                Thread.Sleep(randomDelay);
            }

        }
    }
}
