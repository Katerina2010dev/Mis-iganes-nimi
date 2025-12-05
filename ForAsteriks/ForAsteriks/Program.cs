namespace ForAsteriks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asteriks");

            //tuleb kasutada for loopi
            //sisestan ridade arvu ja tuleb vastav ridade arv konsooli
            //peab näitama tärne

            int nr = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nr; i++)
            {
                Console.Write("*");
            }
        }
    }
}