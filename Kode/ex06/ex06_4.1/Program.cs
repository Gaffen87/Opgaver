namespace ex06_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candle =
            {
                  1, 1, 2, 2, 5, 5, 5
            };

            int high = 0;
            int sum = 0;
            
            for (int i = 0; i < candle.Length; i++)
            {
                if (candle[i] > high)
                {
                    high = candle[i];
                }
            }

            for (int i = 0;i < candle.Length; i++)
            {
                if (candle[i] == high)
                {
                    sum++;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}