using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {

            //Deklaruokite main metode skaičių sąrašą.
            //Parašykite LinQ išraišką, kuri paskaičiuoja, kiek yra lyginių skaičių šiame sąraše.
            //Parašykite LinQ išraišką, kuri grąžina didesnius skaičius už 15 ir mažesnius už 40.
            //Parašykite LinQ išraišką, kuri grąžina skaičių didesnių už 40, sumą.

            List<int> skaiciai = new List<int> { 100, -5, 10, 40, 87, 13, -25, 54, 2, 9 };

            Console.WriteLine(skaiciai.Where(skaicius => skaicius % 2 == 0).Count());

            var atrinkti = skaiciai.Where(skaicius => skaicius > 15 && skaicius < 40);

            var suma = skaiciai.Where(skaicius => skaicius > 40).Sum();


            //Sukurkite kelis savo gyvūno klasės objektus main metode ir pabandykite išvesti jo savybes ir iškviesti jo metodą.

            var banditas = new Racoon("Banditas");
            banditas.Svoris = 5.6f;
            banditas.Spalva = "juoda";
            banditas.Kalbek();
            Console.WriteLine($"Mano spalva {banditas.Spalva}");

            var luosis = new Racoon("Luosis");
            luosis.KojuSkaicius = 3;
            luosis.Spalva = "pilka";
            luosis.Kalbek();
            Console.WriteLine($"As turiu {luosis.KojuSkaicius} kojas");


            //Panaudokite Taskas, Daugiakampis ir Staciakampis

            var taskelis = new Taskas();
            taskelis.X = 2;
            taskelis.Y = 5;
            Console.WriteLine(taskelis.Spausdink());

            List<Taskas> taskai = new List<Taskas> { new Taskas() { X = 10, Y = 5 }, taskelis };
            var task = new Daugiakampis(taskai);
            task.PridekTaska(taskelis);
            task.PridekTaska(1, 3);
            task.SpausdinkTaskus();
            
            var staciakampis = new Staciakampis(2, 3);
            Console.WriteLine(staciakampis.Plotas());
            Console.WriteLine(staciakampis.Perimetras());


            //Sudėkite Žmonių klasės, kurią prieš tai apibrėžėte objektus į sąrašą.
            //Pasinaudoję LinQ surūšiuokite juos pagal vardą
            //Išveskite kiekvieno žmogaus informacija, pasinaudoje Žmogaus klasės metodu
            //Su LinQ pagalba išrinkite žmogų su ilgiausia pavarde ir išveskit jo informaciją.

            var zmogus0 = new Zmogus("Jonas", "Jonaitis", "863946598");
            var zmogus1 = new Zmogus("Petras", "Petraitis", "863486598");
            var zmogus2 = new Zmogus("Lukas", "Lukaitis", "863948698");
            var zmogus3 = new Zmogus("Linas", "Linaitis", "867646598");
            var zmogus4 = new Zmogus("Dominykas", "Dominykaitis", "863941234");

            List<Zmogus> zmones = new List<Zmogus> { zmogus0, zmogus1, zmogus2, zmogus3, zmogus4 };

            zmones.OrderBy(z => z.Vardas).ToList().ForEach(z => z.AtspausdinkInformacija());

            zmones.OrderBy(z => z.Pavarde.Length).Last().AtspausdinkInformacija();

            Console.ReadLine();
        }


        //Sukurkite metodą, kuris nieko negauna ir nieko negrąžina, tik išveda skaičių nuo 1 iki 5 daugybos lenteles, 
        //kiekvienam skaičiui po vieną eilutę.

        public static void DaugybosLenteleNuo1Iki5()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }


        //Sukurkite metodą, kuris gauna stačiakampio kraštinių a ir b ilgius ir nieko negrąžina, tik atspausdina stačiakampio perimetrą

        public static void StaciakampioPerimetras(double a, double b)
        {
            Console.WriteLine(2 * (a + b));
        }


        //Sukurkite metodą, kuris gauna stačiakampio kraštinių a ir b ilgius ir grąžina jo plotą

        public static double StaciakampioPlotas(double a, double b)
        {
            return a * b;
        }
    }
}
