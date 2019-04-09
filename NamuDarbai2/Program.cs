using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite prieš tai sukurtų Darbutojų sąrašą. 
            //Atspausdinkite visų darbuotojų informaciją
            //Suraskite sąraše darbuotoją su didžiausia alga ir suraskite darbuotoją su didžiausiu stažu. Atspausdinkite jų algų ir stažų skirtumą
            
            var darbuotojas0 = new Darbuotojas { Vardas = "Abajs", Pavarde = "Akjdka", Stazas = 2.5f, Alga = 2500 };
            var darbuotojas1 = new Darbuotojas { Vardas = "Dfjgh", Pavarde = "Asfdfg", Stazas = 20.6f, Alga = 5500 };
            var darbuotojas2 = new Darbuotojas { Vardas = "Wdfh", Pavarde = "Ggjg", Stazas = 0.5f, Alga = 1100 };
            var darbuotojas3 = new Darbuotojas { Vardas = "Jhjdsh", Pavarde = "Ijsdf", Stazas = 12f, Alga = 3500 };
            var darbuotojas4 = new Darbuotojas { Vardas = "Uhfsj", Pavarde = "Iakd", Stazas = 5f, Alga = 6500 };

            List<Darbuotojas> darbuotojai = new List<Darbuotojas> { darbuotojas0, darbuotojas1, darbuotojas2, darbuotojas3, darbuotojas4 };

            darbuotojai.ForEach(d => d.AtspausdinkInformacija());

            var zmogusSuDidziausiaAlga = darbuotojai.OrderBy(d => d.Alga).Last();
            var zmogusSuDidziausiuStazu = darbuotojai.OrderBy(d => d.Stazas).Last();

            Console.WriteLine($"Algu skirtumas: {zmogusSuDidziausiaAlga.Alga - zmogusSuDidziausiuStazu.Alga}");
            Console.WriteLine($"Stazo skirtumas: {zmogusSuDidziausiaAlga.Stazas - zmogusSuDidziausiuStazu.Stazas}");


            //Sukurkite apskritimų sąrašą
            //Suraskite apskritimą su didžiausiu plotu ir atspausdinkite jo spindulį.
            
            var apskritimas0 = new Apskritimas(5);
            var apskritimas1 = new Apskritimas(2);
            var apskritimas2 = new Apskritimas(3);
            var apskritimas3 = new Apskritimas(6);

            List<Apskritimas> apskritimai = new List<Apskritimas> { apskritimas0, apskritimas1, apskritimas2, apskritimas3 };

            Console.WriteLine(apskritimai.OrderBy(a => a.PaskaiciuokPlota()).Last().Spindulys);
            // apskritimai.Max(a => a.PaskaiciuokPlota());


            //Panaudokite Viktorina ir ViktorinosKlausimas

            var klausimas0 = new ViktorinosKlausimas("Kokia Dainiaus pavarde?", new string[] { "1. Luksa", "2. Luksas", "3. Luka" }, 0);
            var klausimas1 = new ViktorinosKlausimas("Ka Dainius megsta valgyti?", new string[] { "1. Garzgarstes", "2. Salierus", "3. Susi" }, 2);

            var viktorina = new Viktorina(new List<ViktorinosKlausimas> { klausimas0, klausimas1 });

            viktorina.PradekZaidima();
            viktorina.ParodykRezultata();

            Console.ReadLine();
        }
    }
}
