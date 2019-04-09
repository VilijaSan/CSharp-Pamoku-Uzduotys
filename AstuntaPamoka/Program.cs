using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Paskaičiuokite skaičių bendrą sumą
            //Grąžinkite min ir max reikšmes
            //Grąžinkite skaičių vidurkį
            //Grąžinkite pirmą ir paskutinį elementą

            List<int> skaiciai = new List<int> { 10, 5, -2, 3, -4 };
            
            Console.WriteLine(skaiciai.Sum());
            Console.WriteLine(skaiciai.Max());
            Console.WriteLine(skaiciai.Min());
            Console.WriteLine(skaiciai.Average());
            Console.WriteLine(skaiciai.First());
            Console.WriteLine(skaiciai.Last());


            //Padarykite taip, kad sąraše nebebūtų pasikartojančių skaičių

            int[] skaiciai1 = { 1, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };

            skaiciai1.Distinct().ToList().ForEach(r => Console.Write(r + " "));


            //Grąžinkite sąrašo dalį nuo 5-o iki 9-o el-o

            var dalis = skaiciai.Skip(4).Take(5);


            //Parašykite programą, kuri iš sąrašo išrenka tik lyginius skaičius ir tą naują sąrašą atspausdina.

            List<int> skaiciai2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var tikLyginiai = skaiciai2.Where(skaicius => skaicius % 2 == 0).ToList();

            SpausdintiSarasa(tikLyginiai);
            

            //Parašykite programą, kuri išrenka iš duoto sąrašo tik skaičius didesnius už 10, bet mažesnius už 20

            List<int> skaiciai3 = new List<int> { 1, 20, 13, 4, 15, 46, 87, 18 };

            var atrinktiSk = skaiciai3.Where(skaicius => skaicius > 10 && skaicius < 20).ToList();

            SpausdintiSarasa(atrinktiSk);


            //Parašykite programą, kuri surūšiuoja gautą masyvą mažėjančia tvarka ir atspausdina kiekvienam skaičiui jo kvadratą

            int[] skaiciai4 = { 10, -5, 98, 2, 3, 7, -100 };

            var surikiuoti = skaiciai4.OrderByDescending(skaicius => skaicius);

            surikiuoti.Select(x => $"skaicius = {x}, kvadratas = {x * x} \n").ToList().ForEach(t => Console.WriteLine(t));

            /*foreach (var item in surikiuoti)
            {
                Console.WriteLine($"skaicius = {item}, kvadratas = {item * item}");
            }*/


            //Parašykite programą, kuri turi miestų pavadinimų (string) masyvą ir iš jo išrenka tinkamą miesto pavadinimą 
            //pagal duotą pirmą ir paskutinę raides

            string[] miestai = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABIM", "PARIS" };

            Console.WriteLine("Iveskite pirma raide:");
            string pirmaRaide = Console.ReadLine().ToUpper();

            Console.WriteLine("Iveskite paskutine raide:");
            string paskutineRaide = Console.ReadLine().ToUpper();

            //var miestas = miestai.Where(m => m.StartsWith(pirmaRaide) && m.EndsWith(paskutineRaide)).First();
            //Console.WriteLine($"Miestas, kuris prasideda {pirmaRaide} ir baigiasi {paskutineRaide} yra: {miestas}");

            var miestas = miestai.Where(m => m.StartsWith(pirmaRaide) && m.EndsWith(paskutineRaide)).ToList();

            foreach (var m in miestas)
            {
                Console.WriteLine($"Miestas, kuris prasideda {pirmaRaide} ir baigiasi {paskutineRaide} yra: {m}");
            }
            
            Console.ReadLine();
        }


        //Parašyti metodą, kuris nieko negrąžina ir atspausdina skaičius nuo 100 iki 1.

        public static void NuoSimtoIkiVieno()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Parašyti metodą, kuris nieko negrąžina, bet gauna sveiką skaičių x ir atspausdina skaičius vienoje eilutėje su tarpais nuo 1 iki x.

        public static void AtspausdinkSkaicius(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Write(i + " ");
            }
        }


        //Parašyti metodą, kuris gauna du sveikus skaičius ir grąžina jų sandaugą.

        public static int Sandauga(int a, int b)
        {
            return a * b;
        }


        //Parašyti metodą, kuris gauna du tekstus ir grąžina juos sujungtus į vieną

        public static string SujunkDuTekstus(string a, string b)
        {
            return a + b;
        }


        //Sukurti metodą, kuris nieko negrąžina ir atspausdina gautą tekstų masyvą, kiekvienas elementas turi būti atskirtas kableliais.

        public static void AtspausdinkTekstuMasyva(string[] masyvas)
        {
            foreach (var item in masyvas)
            {
                Console.Write(item + ", ");
            }
        }


        //Sukurti metodą, kuris nieko negrąžina ir atspausdiną gautą skaičių masyvą, kiekvienas elementas turi būti atskirtas kableliais

        public static void AtspausdinkSkaiciuMasyva(int[] masyvas)
        {
            foreach (var item in masyvas)
            {
                Console.Write(item + ", ");
            }
        }


        //Sukurti metodą, kuris gauna tekstų masyvą ir grąžina tuos tekstus suklijuotus į vieną ir atskirtus kableliais.

        public static string GrazinkTekstusSuklijuotusIViena(string[] masyvas)
        {
            string suklijuoti = null;

            foreach (var item in masyvas)
            {
                suklijuoti = suklijuoti + item + ", ";
            }

            return suklijuoti;
        }


        //Sukurti metodą, kuris grąžina integer sąrašo elementų sumą

        public static int Suma(List<int> sarasas)
        {
            int suma = 0;
            foreach (var item in sarasas)
            {
                suma += item;
            }
            return suma;
        }


        //Sukurti metodą, kuris grąžina sąrašo elementų vidurkį

        public static double Vidurkis(List<int> sarasas)
        {
            return (double)Suma(sarasas) / sarasas.Count;
        }


        //Sukurti metodą, kuris surūšiuoja sąrašo elementus mažėjimo tvarka

        public static void SurusiuokMazejimoTvarka(List<int> sarasas)
        {
            sarasas.Sort();
            sarasas.Reverse();
        }

    }
}
