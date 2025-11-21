namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int rows = int.Parse(Console.ReadLine()); // The number of rows in the triangle
            int i = 1; // Outer loop counter for rows

            while (i <= rows)
            {
                int j = 1; // Inner loop counter for columns (stars)
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine(); // Move to the next line after printing a row
                i++;

                //otsida internetist While koodiga kolmnurga kujundeid e tegemise viise
                //kui kood on leitud, siis kirjutada see siia alla
                //teha vooskeem
            }
        }
    }
}
