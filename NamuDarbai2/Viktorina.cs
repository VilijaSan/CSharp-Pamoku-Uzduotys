using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai2
{
    public class Viktorina
    {
        //Sukurti klasę Viktorina, kuri turėtų:
        //Tokias savybes:
        //Klausimai, kuri saugotų sąrašą su ViktorinosKlausimas tipo objektais - List<ViktorinosKlausimas>
        //Taskai, kuris saugotų surinktų taškų skaičių(kiek teisingų klausimų buvo atsakyta) int
        //Konstruktorių, kuriam reikėtų perduoti viktorinos klausimus- List<ViktorinosKlausimas>
        //PradetiZaidima - kuris pereitų per visus viktorinos klausimus, juos paeiliui išvestų, nuskaitytų atsakymą ir padidintų taškų skaičių, 
        //jeigu atsakymas buvo teisingas
        //ParodykRezultata - kuris nieko negrąžina, bet išveda surinktų taškų skaičių

        private List<ViktorinosKlausimas> Klausimai { get; set; }
        public int Taskai { get; set; }

        public Viktorina(List<ViktorinosKlausimas> klausimai)
        {
            Klausimai = klausimai;
            Taskai = 0;
        }

        public void PradekZaidima()
        {
            Klausimai.ForEach(klausimas =>
            {
                klausimas.AtspausdinkKlausima();

                if (klausimas.NuskaitykIrPatikrink())
                {
                    Console.WriteLine("Valioooo");
                    Taskai++;
                }
                else
                {
                    Console.WriteLine("Neteisingas atsakymas");
                }
            });
        }

        public void ParodykRezultata()
        {
            Console.WriteLine($"Rezultatas: {Taskai}");
        }
    }
}
