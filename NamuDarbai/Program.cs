using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duoti du skaičiai. Parašykite programą, kuri nustatytų, ar šių skaičių skirtumas yra lygus -3
            
            Console.WriteLine("Iveskite g:");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite h:");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine((g - h == -3) ? "Skirtumas -3" : "Skirtumas ne -3");
            Console.ReadLine();


            //Parašykite programą, kuri išvestų į ekraną duotą skaičių x pakeltą kvadratu, jei jis didesnis už 5 
            //arba padalintą iš 10, jei jis mažesnis už 5.

            Console.WriteLine("Iveskite skaiciu:");
            int skaic = int.Parse(Console.ReadLine());

            if (skaic > 5)
            {
                Console.WriteLine(Math.Pow(skaic, 2));
            }
            else if (skaic < 5)
            {
                Console.WriteLine(skaic / 10);
            }

            Console.ReadLine();


            //Duotas keturženklis skaičius x. Parašykite programą, kuri nustatytų jo pirmų dviejų skaitmenų sumą

            Console.WriteLine("Iveskite keturzenkli skaiciu:");
            int keturzenklis = int.Parse(Console.ReadLine());

            if (keturzenklis < 1000 || keturzenklis > 9999)
            {
                Console.WriteLine("skaicius ne keturzenklis");
                return;
            }

            int pirmasSk = keturzenklis / 1000;

            int antrasSk = (keturzenklis / 100) % 10;

            Console.WriteLine(pirmasSk + antrasSk);
            Console.ReadLine();


            //Parašykite programą, kuri nustatytų, ar tarp trijų skaičių yra neigiamų skaičių

            Console.WriteLine("Iveskite skaiciu:");
            int sk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu:");
            int sk2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu:");
            int sk3 = int.Parse(Console.ReadLine());

            if (sk1 < 0 || sk2 < 0 || sk3 < 0)
            {
                Console.WriteLine("yra neigiamu skaiciu");
            }

            Console.ReadLine();


            //Laurynas žino, kad mokytoja jam gali duoti spręsti vieną iš trijų kontrolinio darbo variantų. 
            //Atlikdamas užduotį jis gaus du skaičius a ir b, o jam reikės apskaičiuoti x reikšmę pagal vieną iš trijų formulių:
            //Pirmas variantas: x = ab + 3;
            //Antras variantas: x = 2a + b;
            //Trečias variantas: x = a - 3b.
            //Parašykite programą, kuri padėtų Laurynui pasitikrinti, ar jis teisingai skaičiuoja x reikšmę spręsdamas kiekvieno varianto užduotį.
            
            Console.WriteLine("Iveskite a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite kontrolinio varianta:");
            int variantas = int.Parse(Console.ReadLine());

            double x;

            switch (variantas)
            {
                case 1:
                    x = a * b + 3;
                    break;
                case 2:
                    x = 2 * a + b;
                    break;
                case 3:
                    x = a - 3 * b;
                    break;
                default:
                    return;
            }

            Console.WriteLine($"x = {x}");
            Console.ReadLine();
           

            // Parašykite programą, kuri nuskaito skaičių x ir atspausdina, kiek rado lyginių skaičių intervale [1 ; z]           

            Console.WriteLine("Iveskite x:");
            int z = int.Parse(Console.ReadLine());

            int kiekLyginiu = 0;

            while (z > 1)
            {
                if (z % 2 == 0)
                {
                    kiekLyginiu++;
                }

                z--;
            }

            Console.WriteLine(kiekLyginiu);
            Console.ReadLine();
            

            // Parašykite programą, kuri nuskaito skaičių ir atspausdina visus skaičius nuo jo iki 1-o

            Console.WriteLine("Iveskite skaiciu:");
            int skaicius = int.Parse(Console.ReadLine());

            if (skaicius > 0)
            {
                while (skaicius >= 1)
                {
                    Console.Write($"{skaicius} ");
                    skaicius--;
                }
            }
            else
            {
                while (skaicius <= 1)
                {
                    Console.Write($"{skaicius} ");
                    skaicius++;
                }
            }
            
            Console.ReadLine();


            // Nurodytas natūralusis skaičius n. Parašykite programą, nustatančią, ar jis lygus iš eilės einančių natūraliųjų skaičių 
            //(pradedant vienetu) sumai. Pvz.: jei n = 15, tai turi būti išvesta: TAIP. Jei n =12, tai turi būti išvesta: NE

            Console.WriteLine("Iveskite n:");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            int skc = 1;

            while (suma < n)
            {
                suma = suma + skc;
                skc++;
            }

            Console.WriteLine((suma == n) ? "Taip" : "Ne");
            Console.ReadLine();


            // Parašykite programą, kuri šimtą kartų atspausdina tą pačią frazę kartu su jos eilės numeriu

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine($"{i}) Labas");
            }

            Console.ReadLine();


            // Parašykite programą, kuri išves kas trečią skaičių nuo 1 iki 30

            for (int i = 1; i <= 30; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


            // Kiekvieną dieną Petriukas, eidamas į mokyklą, skaičiuoja kiekvieną savo žingsnį ir žaidžia tokį žaidimą: 
            //kai žingsnių skaičius baigiasi nuliu, Petriukas suploja rankomis, o kai penketu - spragteli pirštais. 
            //Parašykite programą, kuri suskaičiuotų, kiek kartų Petriukas suplos rankomis ir kiek – spragtels pirštais, 
            //jei jam iki mokyklos yra lygiai n žingsnių

            Console.WriteLine("Iveskite kiek zingsniu iki mokyklos:");
            int zingsniai = int.Parse(Console.ReadLine());

            int suplojimai = 0;
            int spragtelejimai = 0;

            for (int i = 1; i <= zingsniai; i++)
            {
                if (i % 10 == 0)
                {
                    suplojimai++;
                }
                else if (i % 5 == 0)
                {
                    spragtelejimai++;
                }
            }

            Console.WriteLine($"suplos {suplojimai}kart; spragteles {spragtelejimai}kart");
            Console.ReadLine();
                       

            // Deklaruokite skaičių masyvą, kuriame bus 15a skaičių - neigiamų ir teigiamų

            int[] masyvas = { 2, -5, 6, 18, -102, 95, 14, -7, 55, -4, 0, 16, 3, 98, -45 };


            //Atspausdinkite masyvą vienoje eilutėje palikdami tarpus tarp skaičių

            foreach (int v in masyvas)
            {
                Console.Write($"{v} ");
            }

            Console.ReadLine();


            // Raskite masyve didžiausią skaičių ir atspausdinkite jo indeksą
                        
            int maxIndex = 0;

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] > masyvas[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxIndex);
            Console.ReadLine();


            //Suskaičiuokite, kiek masyve yra neigiamų skaičių

            //int neigiamu = masyvas.Count(el => el < 0);

            int neigiamu = 0;

            foreach (int v in masyvas)
            {
                if (v < 0)
                {
                    neigiamu++;
                }
            }

            Console.WriteLine(neigiamu);
            Console.ReadLine();


            // Paverskite masyve visus neigiamus skaičius teigiamais, o teigiamus - neigiamais
            
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] *= -1;
                Console.Write($"{masyvas[i]} ");
            }

            Console.ReadLine();


            // Masyve įrašyti n žmonių gimimo metai. Sudarykite programą, kuri nustatytų didžiausią žmonių amžiaus skirtumą.
            //Duomenys: 1989, 1988, 2010, 2007, 1999, 1994, 1974, 1963, 1932, 1950, 1967, 2003, 2000.

            /*int[] gimimoMetai = { 1989, 1988, 2010, 2007, 1999, 1994, 1974, 1963, 1932, 1950, 1967, 2003, 2000 };

            gimimoMetai = gimimoMetai.OrderByDescending(elementas => elementas).ToArray();

            int skirtumas = gimimoMetai[0] - gimimoMetai[gimimoMetai.Length - 1];

            Console.WriteLine(skirtumas);
            Console.ReadLine();*/

            int[] gimimoMetai = { 1989, 1988, 2010, 2007, 1999, 1994, 1974, 1963, 1932, 1950, 1967, 2003, 2000 };

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < gimimoMetai.Length; i++)
            {
                if (gimimoMetai[i] > max)
                {
                    max = gimimoMetai[i];
                }
                else if (gimimoMetai[i] < min)
                {
                    min = gimimoMetai[i];
                }
            }

            int skirtumas = max - min;

            Console.WriteLine(skirtumas);
            Console.ReadLine();

        }
    }
}