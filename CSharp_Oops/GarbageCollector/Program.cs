namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                for (int i = 0; i < 10000; i++)
                {
                    Practice emp = new Practice();
                }
                Console.WriteLine("Objects created. Press any key to continue...");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Console.WriteLine("Garbage collection completed. Press any key to exit...");
            }
        }
    }
}
