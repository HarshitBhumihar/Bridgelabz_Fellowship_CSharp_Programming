namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DefaultConstructor d=new DefaultConstructor();
            //Parameterized p = new Parameterized(1,"harsh");
            //p.display();
            Copy c = new Copy(1, "harshit", 23);
            c.display();

        }
    }
}
