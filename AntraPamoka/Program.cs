using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašyti programą, kuri paprašo vartotojo įvesti du skaičius - x ir y koordinates.
            //Nuskaito šias koordinates ir išsisaugo kintamuosiuose
            //pagal gautas koordinates turi išvesti, kuriame koordinačių sistemos ketvirtyje tos koordinatės yra.

            Console.WriteLine("Iveskite x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite y:");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Koordinates yra 1 ketvirtyje");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Koordinates yra 2 ketvirtyje");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Koordinates yra 3 ketvirtyje");
            }
            else
            {
                Console.WriteLine("Koordinates yra 4 ketvirtyje");
            }

            Console.ReadLine();


            //Parašyti programą, kuri paprašo įvesti savo amžių ir pagal jį grąžina kino teatro bilieto kainą. 
            //Jei amžius yra mažesnis arba lygus 10 arba yra didesnis už 65, tai turi pranešti vartotojui, kad bilietas kainuos 5 eurus.
            //Kitu atveju, turi pranešti, kad bilietas kainuos 10 eurų.


            Console.WriteLine("Iveskite savo amziu:");
            int amzius = int.Parse(Console.ReadLine());

            if (amzius <= 10 || amzius > 65)
            {
                Console.WriteLine("Bilietas kainuos 5 eurus");
            }
            else
            {
                Console.WriteLine("Bilietas kainuos 10 euru");
            }
            Console.ReadLine();


            // Parašyti programą naudojant while ciklą, kuri 20 kartų išveda jūsų pasirinktą sakinį į Console.

            int n = 0;
            while (n < 20)
            {
                Console.WriteLine("Katukas");
                n++;
            }
            Console.ReadLine();


            //Parašykite programą naudojant while ciklą, kuri išveda į Console iš naujos eilutės skaičius nuo 1 iki 25.

            int m = 1;
            while (m <= 25)
            {
                Console.WriteLine(m);
                m++;
            }
            Console.ReadLine();


            //Parašykite programą su amžinu ciklu naudojant while ciklą, kuri amžinai išvedinėtų vis didėjanti skaičių nuo 1 iki begalybės.

            /*int p = 1;
            while (true)
            {
                Console.WriteLine(p);
                p++;
            }
            Console.ReadLine();*/


            //Parašykite programą naudojant while ciklą, 
            //kuri nuskaitinėja įvestus skaičius ir juos sumuoja tol, kol nebūna įvestas neigiamas skaičius. 
            //Programos pabaigoje turi išvesti gautą sumą.

            int s = 0;
            int suma = 0;

            while (s >= 0)
            {
                Console.WriteLine("Iveskite skaiciu:");
                s = int.Parse(Console.ReadLine());
                if (s >= 0)
                {
                    suma = suma + s;
                }
            }

            Console.WriteLine(suma);
            Console.ReadLine();


            //Parašyti programą naudojant while ciklą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau 50

            int sk = 0;
            int skSuma = 0;

            while (skSuma <= 50)
            {
                Console.WriteLine("Iveskite skaiciu:");
                sk = int.Parse(Console.ReadLine());
                skSuma = skSuma + sk;
            }

            Console.ReadLine();


            //Parašyti programą naudojant while ciklą, kuri nuskaitinėja paspaustus klavišus ir išveda jų pavadinimus tol, 
            //kol nepaspaudžiamas ESC klavišas.

            var klavisas = Console.ReadKey().Key;

            while (klavisas != ConsoleKey.Escape)
            {
                Console.WriteLine(klavisas.ToString());
                klavisas = Console.ReadKey().Key;
                Console.Write(ConsoleKey.Backspace);
            }
            Console.ReadLine();

            /*while (true)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.Write(key.ToString());
                }
            }*/


            //FOR + 2xTAB sugeneruoja


            //Parašykite programą naudojant for ciklą, kuri paprašo įvesti teigiamą skaičių n ir iš eilės atspausdina skaičius nuo 1 iki n.

            Console.WriteLine("Iveskite teigiama skaiciu:");
            int teigSkaicius = int.Parse(Console.ReadLine());

            for (int i = 1; i <= teigSkaicius; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


            //Parašyti programą naudojant for ciklą, kuri paprašo įvesti natūralųjį skaičių ir 
            //atspausdina vienoje eilutėje 10 naturaliųjų skaičių iš eilės pradedant nuo įvesto skaičiaus

            Console.WriteLine("Iveskite naturaluji skaiciu:");
            int natSkaicius = int.Parse(Console.ReadLine());

            for (int i = natSkaicius; i <= natSkaicius + 9 ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();


            //Parašyti programą naudojant for ciklą, kuri suskaičiuoja pirmų 10 natūraliųjų skaičių sumą

            int natSkSuma = 0;

            for (int i = 1; i < 11; i++)
            {
                natSkSuma = natSkSuma + i;
            }
            Console.WriteLine(natSkSuma);
            Console.ReadLine();


            //Parašyti programą naudojant for ciklą, kuri prašo įvesti natūralųjį skaičių ir 
            //atspausdina visus žemesnius natūraliuosius skaičius mažėjančia tvarka.

            Console.WriteLine("Iveskite naturaluji skaiciu:");
            int natrSkaicius = int.Parse(Console.ReadLine());

            for (int i = natrSkaicius - 1; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //Parašyti programą naudojant for ciklą, kuri prašo įvesti skaičių ir atspausdina jo daugybos lentelę.

            Console.WriteLine("Iveskite skaiciu:");
            int skaic = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int padauginta = skaic * i;
                Console.WriteLine($"{skaic} * {i} = {padauginta}");
            }
            Console.ReadLine();


            //Parašyti programą naudojant for ciklą, kuri prašo įvesti piramidės aukštį ir atspausdina skaičių piramidę

            Console.WriteLine("Iveskite piramides auksti:");
            int aukstis = int.Parse(Console.ReadLine());
            int skaicius = 1;

            //eilutes(aukstis)
            for (int i = 1; i <= aukstis; i++)
            {
                //stulpeliai(skaiciai)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{skaicius} ");
                    skaicius++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
