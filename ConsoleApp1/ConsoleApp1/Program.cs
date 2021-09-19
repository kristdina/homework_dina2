using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kāds ir Tavs vārds?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiki, " + userName + "!");


            // --------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Kāds ir Tavs vecums?");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int nextYearAge = age + 1;

            Console.WriteLine("Sveiki, Tev nākamgad būs: " + nextYearAge);


            // --------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Kurš vecuma skailtis ir lielāks?");

            int maxNumber1 = age;
            int maxNumber2 = nextYearAge;
            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine("Lielākais skaitlis ir: " + maxResult);

            // --------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kurš vecuma skailtis ir mazākais?");

            int minNumber1 = age;
            int minNumber2 = nextYearAge;
            int minResult = Math.Min(minNumber1, minNumber2);

            Console.WriteLine("Mazākais skaitlis ir: " + minResult);

            // --------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kāda atzīme Tev bija matemātikā, beidzot 12.klasi?");

            string gradeText = Console.ReadLine();
            int grade = int.Parse(gradeText);

            Console.WriteLine();
            Console.WriteLine("Kāda atzīme Tev bija latviešu valodā, beidzot 12.klasi?");

            string gradelvText = Console.ReadLine();
            int gradelv = int.Parse(gradelvText);

            Console.WriteLine();
            Console.WriteLine("Pēc matemātikas un latviešu valodas atzīmes izdalīšanas pārpalikums skaitļiem ir: " + gradelv % grade);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Paldies. Jauku vakaru!");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
