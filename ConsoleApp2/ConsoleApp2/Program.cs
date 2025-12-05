namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 0;

            //kui on 10 rida konsoolis, siis lõpetab ära
            //kasutada breik;
            for (; ; )
            {
                Console.WriteLine("väärtus on " + i);
                i++;
                if (i == 11)
                break;
            }
        }
    }
}