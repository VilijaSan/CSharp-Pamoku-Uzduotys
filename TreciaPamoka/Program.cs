using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {

            // cw + 2xTAB --> Console.WriteLine()
            

            //nuskaito iš Consolės 10 skaičių į masyvą ir jį atspausdina.

            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                 Console.WriteLine(array1[i]);
            }
            
            Console.ReadLine();


            //atspausdina kas antrą masyvo elementą

            int[] array2 = new int[10];

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                array2[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i += 2)
            {
                    Console.WriteLine(array2[i]);
            }

            Console.ReadLine();


            //Atspausdina tik tuos skaičius, kurie yra teigiami ir mažesni už 10

            int[] array3 = new int[10];

            for (int j = 0; j < array3.Length; j++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                array3[j] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] > 0 && array3[i] < 10)
                {
                    Console.WriteLine(array3[i]);
                }
            }
            
            Console.ReadLine();


            //Suskaičiuoja visų elementų sumą ir ją atspausdina

            int[] array4 = new int[10];

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                array4[j] = int.Parse(Console.ReadLine());
            }

            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma = suma + array4[i];
            }

            Console.WriteLine($"Visu elementu suma yra: {suma}");
            Console.ReadLine();


            //Parašyti programą, kuri prašo įvesti masyvo dydį ir tada nuskaito n elementų į masyvą ir atspausdina jį atvirkščiai.

            Console.WriteLine("Iveskite masyvo dydi:");
            int dydis = int.Parse(Console.ReadLine());

            int[] masyvas = new int[dydis];

            for (int i = 0; i < dydis; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                masyvas[i] = int.Parse(Console.ReadLine());
            }

            for (int j = dydis - 1; j >= 0; j--)
            {
                Console.WriteLine(masyvas[j]);
            }
            Console.ReadLine();


            //Apibrėžti ir priskirti reikšmes dvimačiam bool masyvui, kuris turi 4 eilutes ir 7 stulpelius 
            //ir atspausdinti jį ekrane. (Jei elemento reikšmė true - tai *, jei false, tai -).

            bool[,] array = new bool[4, 7]
                {
                    { false, false, false, true, false, false, false },
                    { false, false, true, false, true, false, false },
                    { false, true, false, true, false, true, false },
                    { true, false, true, false, true, false, true },
                };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (array[i, j] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            

            // CTRL + K + T formatuoja


            //Sukurti programą, kuri nuskaitinėja eilutes tol, kol negauna tuščios (while) ir deda eilutes į daugiausiai 10 elementų masyvą. 
            // Naudojant foreach ciklą atspausdinti tą masyvą.

            string[] eilutes = new string[10];
            int indeksas = 0;
            string eilute;

            bool arTuscia = false;

            Console.WriteLine("Iveskite eilutes:");

            while (!arTuscia && indeksas < 10)
            {
                eilute = Console.ReadLine();

                if (eilute.Length > 0)
                {
                    eilutes[indeksas] = eilute;
                    indeksas++;
                }
                else
                {
                    arTuscia = true;
                }
            }

            foreach (var item in eilutes)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
                       
        }
    }
}
