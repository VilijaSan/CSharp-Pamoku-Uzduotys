using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    public class Racoon
    {
        //Sukurkite jūsų pasirinkto gyvūno klasę, kuris turės tokias savybes:
        //Kojų skaičius, Svoris, Spalva
        //Ir turės metodą - Kalbėk.

        public string Vardas { get; set; }
        public int KojuSkaicius { get; set; } = 4;
        public float Svoris { get; set; }
        public string Spalva { get; set; }

        public Racoon(string vardas)
        {
            Vardas = vardas;
        }

        public void Kalbek()
        {
            Console.WriteLine($"Labas, as {Vardas}");
        }
    }
}
