using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SestaPamoka
{
    public class Metodai
    {
        //Parašykite metodą Pasisveikink, kuris nepriima jokių parametrų, nieko negrąžina, tiesiog išveda į Console pasisveikinimą

        public static void Pasisveikink()
        {
            Console.WriteLine("Labas");
        }


        //Patobulinkite metodą Pasisveikink, kuris priimtų pasisveikinimo tekstą ir jį išvestų

        public static void PasisveikinkSuTekstu(string pasveikinimoTekstas)
        {
            Console.WriteLine(pasveikinimoTekstas);
        }


        //Parašykite metodą Suma, kuris priima du skaičius ir grąžina jų sumą

        public static int Suma(int a, int b)
        {
            //int sum = a + b;
            return a + b;
        }


        //Parašykite metodą PatikrinkSkaiciu, kuris priima skaičių ir išveda į Console, ar jis teigiamas, ar neigiamas, ar nulinis.

        public static void PatikrinkSkaiciu(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"{a} teigiamas");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} neigiamas");
            }
            else
            {
                Console.WriteLine($"{a} nulinis");
            }
        }


        //Parašykite metodą PakelkKvadartu, kuris priimtų skaičių ir grąžintų jo kvadratą

        public static double PakelkKvadratu(int a)
        {
            return a * a; // Math.Pow(a, 2);
        }


        //Parašyti metodą, kuris suskaičiuoja žmogaus kūno masės indeksą ir grąžina. Priima du parametrus - svorį ir ūgį.

        public static double KunoMasesIndeksas(double ugisM, double svorisKg)
        {
            return svorisKg / (ugisM * ugisM);
        }


        //Papildyti programą parašant metodą, kuris pagal gautą KMI nustato žmogaus fizinę būseną 
        //(Šis metodas savyje turi iškviesti KMI skaičiuojantį metodą)

        public static void FizinesBuklesNustatymas(double ugisM, double svorisKg)
        {
            double kmi = KunoMasesIndeksas(ugisM, svorisKg);

            Console.WriteLine($"KMI = {kmi}");

            if (kmi < 15)
            {
                Console.WriteLine("Badaujantis zmogus");
            }
            else if (kmi < 18.5)
            {
                Console.WriteLine("Liesas zmogus");
            }
            else if (kmi < 25)
            {
                Console.WriteLine("Normalaus svorio zmogus");
            }
            else if (kmi < 30)
            {
                Console.WriteLine("Turintis virssvorio zmogus");
            }
            else if (kmi < 40)
            {
                Console.WriteLine("Nutukes zmogus");
            }
            else
            {
                Console.WriteLine("Ligotai nutukes zmogus");
            }
        }


        //Parašykite metodą, kuris atspausdina gautą skaičių masyvą į vieną eilutę su tarpais

        public static void AtspausdinkMasyvaEilutej(int[] masyvas)
        {
            foreach (int v in masyvas)
            {
                Console.Write($"{v} ");
            }
        }


        //Parašykite metodą Max, kuris priima skaičių masyvą ir grąžiną didžiausią skaičių. 
        //(reikės naudoti for ciklą ir sąlygas, bet ne Math biblioteką!)

        public static int Max(int[] masyvas)
        {
            int max = int.MinValue;

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                }
            }

            return max;
        }


        //Parašyti metodą, kuris atspausdina, kokia dabar savaitės diena ir suskaičiuoja už kiek dienų bus penktadienis. 
        //Rezultato pvz.: „Today is Thursday, Friday is in 1 day“.

        public static void UzKiekDienuPenktadienis()
        {
            int siandienDienosNr = (int)DateTime.Now.DayOfWeek;

            string siandienDiena = DateTime.Now.DayOfWeek.ToString();

            int poKiekDienu = 5 - siandienDienosNr;

            if (poKiekDienu < 0)
            {
                poKiekDienu = poKiekDienu + 7;
            }

            Console.WriteLine($"Today is {siandienDiena}; Friday is in {poKiekDienu} days");
        }
    }
}
