using System;

namespace MultithreadedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.ThreadNumberAsker);
            int countOfThreads = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfThreads; i++)
            {
                ThreadBuilder.BuildAThread();
            }
        }
    }
}
