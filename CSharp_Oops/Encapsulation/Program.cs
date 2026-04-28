namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Practice e = new Practice();
            e.setdata(22, "satyarth");
            Console.WriteLine("name is " + e.getname());
            Console.WriteLine("age is " + e.getage());

        }
    }
}
