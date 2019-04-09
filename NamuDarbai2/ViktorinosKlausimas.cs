using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai2
{
    public class ViktorinosKlausimas
    {
        //Sukurti klasę ViktorinosKlausimas, kuri turėtų:
        //Tokias savybes:
        //Klausimas, kuri saugotų patį klausimą(string)
        //GalimiAtsakymai -Masyvą iš trijų string elementų, kuris saugotų galimus atsakymus(string[])
        //TeisingasAtsakymas - skaičių, kuris saugotų teisingąjį atsakymo indeksą(int)
        //Vieną konstruktorių, kuriam, kuriant objektą, reikėtų perduoti klausimą, galimus atsakymus ir teisingą atsakymą
        //Tokius viešus metodus:
        //AtspausdinkKlausima - kuris mokėtų išvesti į console klausimą su galimais atsakymais ir nieko negrąžintų
        //NuskaitykIrPatikrink - kuris paprašytų įvesti atsakymą, jį nuskaitytų ir patikrintų, ar jis teisingas - grąžintų true arba false.

        public string Klausimas { get; set; }
        public string[] GalimiAtsakymai { get; set; }
        public int TeisingasAtsakymas { get; set; }

        public ViktorinosKlausimas(string klausimas, string[] galimiAts, int teisingoAtsIndeksas)
        {
            Klausimas = klausimas;
            GalimiAtsakymai = galimiAts;
            TeisingasAtsakymas = teisingoAtsIndeksas;
        }

        public void AtspausdinkKlausima()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Klausimas);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Variantai: ");

            foreach (var galimasAtsakymas in GalimiAtsakymai)
            {
                Console.Write($"{galimasAtsakymas} ");
            }

            Console.WriteLine();
        }

        public bool NuskaitykIrPatikrink()
        {
            Console.WriteLine("Pasirinkite atsakyma:");

            int pasirinkimas = int.Parse(Console.ReadLine());
            int pasirinktoIndeksas = pasirinkimas - 1;

            return pasirinktoIndeksas == TeisingasAtsakymas;
        }
    }
}
