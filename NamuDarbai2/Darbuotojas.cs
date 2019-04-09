using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai2
{
    public class Darbuotojas
    {
        //Sukurkite klasę Darbuotojas, kuri turės:
        //Tokias savybes: Vardas, Pavardė, Stažas, Alga
        //Tokius metodus: AtspausdinkInformacija, kuris spausdins informaciją tokiu būdu: Vardas Pavarde Alga Stazas

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public float Stazas { get; set; }
        public double Alga { get; set; }

        //public Darbuotojas(string vardas, string pavarde, float stazas, double alga)
        //{
        //    Vardas = vardas;
        //    Pavarde = pavarde;
        //    Stazas = stazas;
        //    Alga = alga;
        //}

        public void AtspausdinkInformacija()
        {
            Console.WriteLine($"{Vardas} {Pavarde} {Alga} {Stazas}");
        }
    }
}
