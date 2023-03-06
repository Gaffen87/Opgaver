namespace ex06_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age =
            {
                21, 23, 34, 35, 38
            };

            Console.WriteLine("Indtast alder du vil søge efter: ");
            int search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i < age.Length; i++)
            {
                if (age[i] == search)
                {
                    Console.WriteLine("Alder({0}) fundet!", search);
                    Console.ReadKey();
                    return;
                }                
            }
            Console.WriteLine("Alder({0}) ikke fundet!", search);
            Console.ReadKey();
        }
    }
}