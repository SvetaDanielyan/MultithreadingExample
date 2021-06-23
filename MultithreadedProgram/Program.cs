using System;

namespace MultithreadedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.InputHeader);
            int threadCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < threadCount; i++)
            {
                ThreadBuilder.BuildThread();
            }
        }
    }
}
