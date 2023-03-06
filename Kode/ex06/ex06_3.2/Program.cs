namespace ex06_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age =
            {
                21, 23, 34, 35, 38
            };

            double avg = 0;

            for (int i = 0; i < age.Length; i++)
            {
                avg += age[1];
            }

            Console.WriteLine(avg / age.Length);

            Console.ReadKey();
        }
    }
}