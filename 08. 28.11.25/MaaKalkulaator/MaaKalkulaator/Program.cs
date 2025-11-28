namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            //Meil on münt, mille diameeter on 25,75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            //Mündi diameeter on 25,27 mm
            //Maa raadius on 6371 km

            double coindiameter = 25.75; //mm
            double earthradius = 6378100000;
            double aroundEarth = 2 * Math.PI * earthradius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / coindiameter;

            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}",howManyCoins
        }
    }
}