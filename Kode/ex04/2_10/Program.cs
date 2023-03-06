namespace _2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "D3773 3r 3n t3k2t m3d t4l i 1234";
            
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] >= 48 && tekst[i] <= 57)
                {
                    Console.Write(tekst[i]);
                }
            }

            Console.ReadKey();
        }
    }
}