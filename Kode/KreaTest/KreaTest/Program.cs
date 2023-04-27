namespace KreaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller control = new Controller();

            //string navn = null;
            //while (navn == null)
            //{
            //    Console.WriteLine("Navn: ");
            //    navn = Console.ReadLine();
            //}
            //navn = navn.Replace(navn.Substring(0, 1), navn.Substring(0, 1).ToUpper());

            //Console.WriteLine("Du har indtastet følgende:");
            //Console.WriteLine($"{navn}, {Sprog.Dansk}, {Type.Strikkeopskrift}, {(int)Værdikode.Kode60}");
            //Console.WriteLine("\nTryk en tast for at tilføje til listen");
            //Console.ReadLine();

            //control.AddOpskriftToList(navn, Sprog.Dansk, Type.Strikkeopskrift, Værdikode.Kode60);

            //Console.WriteLine("Listen ser nu sådan ud: ");

            control.AddOpskriftToList("test a", Sprog.Dansk, Type.Strikkeopskrift, Værdikode.Kode20);
            control.AddOpskriftToList("test b", Sprog.Dansk, Type.Hækleopskrift, Værdikode.Kode30);
            control.AddOpskriftToList("test c", Sprog.Engelsk, Type.Strikkeopskrift, Værdikode.Kode40);
            control.AddOpskriftToList("test d", Sprog.Engelsk, Type.Hækleopskrift, Værdikode.Kode60);
            control.AddOpskriftToList("test e", Sprog.Engelsk, Type.Hækleopskrift, Værdikode.Kode20);
            control.AddOpskriftToList("test f", Sprog.Engelsk, Type.Strikkeopskrift, Værdikode.Kode30);
            control.AddOpskriftToList("test g", Sprog.Dansk, Type.Hækleopskrift, Værdikode.Kode40);
            control.AddOpskriftToList("test h", Sprog.Dansk, Type.Strikkeopskrift, Værdikode.Kode60);

            control.ShowList("", Sprog.Alle, Type.Alle, Værdikode.Alle);

            Console.ReadLine();
        }
    }
}