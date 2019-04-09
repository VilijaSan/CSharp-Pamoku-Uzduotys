using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    public class Zmogus
    {
        //Reikia sukurti klasę - Žmogus. 
        //Pridėti tokias savybes - Vardas, Pavardė, Telefonas
        //Turi turėti metodą - AtspausdinkInformaciją, kuris atspausdina informaciją į Console langą tokiu formatu: Vardas Pavarde Telefonas

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Telefonas { get; set; }

        public Zmogus(string vardas, string pavarde, string telefonas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Telefonas = telefonas;
        }

        public void AtspausdinkInformacija()
        {
            Console.WriteLine($"{Vardas} {Pavarde} {Telefonas}");
        }
    }
}
