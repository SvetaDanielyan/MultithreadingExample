using System.Threading;

namespace MultithreadedProgram
{
    public class ThreadBuilder
    {
        public static void BuildAThread()
        {
            Writer writer = new Writer(RandomHelper.GetRandomSymbol(), RandomHelper.GetRandomColor(), RandomHelper.GetRandomDelay());
            Thread thread = new Thread(writer.Write);
            thread.Start();
        }
    }
}
