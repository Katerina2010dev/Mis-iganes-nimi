namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 10;

            //kui on 10 rida konsoolis, siis lõpetab ära
            //kasutada breik;
            for (; ; )
            {
                Console.WriteLine("väärtus on " + 1);
                i++;
                if (i == 10)
                 break;
            }
        }
    }
}