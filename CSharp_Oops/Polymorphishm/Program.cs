namespace Polymorphishm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //CompileTime c = new CompileTime();
                //c.add(5, 6, 7);
                RunTime.Animal r = new RunTime.Animal2();
                r.sound();

            }

        }
    }
}
