namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course a = new Course("hej", 85);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}