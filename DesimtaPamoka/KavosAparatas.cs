using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    public class KavosAparatas
    {
        //Sukurti kavos aparatą:
        //Kuris turėtų atributus: Cukraus kiekis, Kavos pupelių kiekis, Vandens kiekis, Pieno kiekis, Panaudojimų skaičius
        //Panaudojimų skaičiaus riba –konstanta, kuri saugo, kas kiek panaudojimų reikia atlikti plovimą
        //Kuris mokėtų:
        //Gaminti bent trijų rūšių kavą(nustatoma pagal String parametrą ir kuri naudotų skirtingus produktų kiekius), jeigu trūksta nors vieno produkto 0 atspausdintų atitinkamą pranešimą; 
        //Taip pat atspausdintų pranešimą jeigu laikas plovimui
        //Atlikti plovimą(apnulina panaudojimų skaičių)
        //Pasakyti ar pasiruošęs(netrūksta produktų ir išsivalęs)
        //Pasakytų kokia dabar produktų būsena–atspausdintų informaciją
        //Pasakytų kokia yra aparato būsena(kiek liko produktų ir iki plovimo)


        const int MaxPanaudojimuSk = 15;

        public double CukrausKiekisKg { get; set; }
        public double KavosPupeliuKiekisKg { get; set; }
        public double VandensKiekisL { get; set; }
        public double PienoKiekisL { get; set; }
        public int PanaudojimuSk { get; set; }

        public KavosAparatas(double cukrausKiekisKg, double kavosPupeliuKiekisKg, double vandensKiekisL, double pienoKiekisL)
        {
            CukrausKiekisKg = cukrausKiekisKg;
            KavosPupeliuKiekisKg = kavosPupeliuKiekisKg;
            VandensKiekisL = vandensKiekisL;
            PienoKiekisL = pienoKiekisL;
            PanaudojimuSk = 0;
        }

        public void GaminkKava()
        {
            Console.WriteLine("Pasirinkite kava");
            string kavosPavadinimas = Console.ReadLine();

            switch (kavosPavadinimas)
            {
                case "Juoda":
                    GaminkKonkreciaKava(0.01, 0.02, 0.3, 0);
                    break;
                case "Balta":
                    GaminkKonkreciaKava(0.01, 0.02, 0.2, 0.1);
                    break;
                case "Late":
                    GaminkKonkreciaKava(0.01, 0.02, 0.1, 0.2);
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }

            if (PanaudojimuSk == MaxPanaudojimuSk)
            {
                Console.WriteLine("Laikas plovimui");
            }
        }

        public void Issiplauk()
        {
            PanaudojimuSk = 0;
        }

        public void ProduktuBusena()
        {
            Console.WriteLine($"Cukraus: {CukrausKiekisKg}kg, kavos pupeliu: {KavosPupeliuKiekisKg}kg, vandens: {VandensKiekisL}l, pieno: {PienoKiekisL}l");
        }

        public void AparatoBusena()
        {
            Console.WriteLine($"Cukraus: {CukrausKiekisKg}kg, kavos pupeliu: {KavosPupeliuKiekisKg}kg, vandens: {VandensKiekisL}l, pieno: {PienoKiekisL}l, iki plovimo liko: {MaxPanaudojimuSk - PanaudojimuSk} k.");
        }

        private void GaminkKonkreciaKava(double cukrausKiekisKg, double kavosPupeliuKiekisKg, double vandensKiekisL, double pienoKiekisL)
        {
            if (CukrausKiekisKg < cukrausKiekisKg || KavosPupeliuKiekisKg < kavosPupeliuKiekisKg || VandensKiekisL < vandensKiekisL || PienoKiekisL < pienoKiekisL)
            {
                Console.WriteLine("Nepakanka produktu");
            }
            else
            {
                CukrausKiekisKg -= cukrausKiekisKg;
                KavosPupeliuKiekisKg -= kavosPupeliuKiekisKg;
                VandensKiekisL -= vandensKiekisL;
                PienoKiekisL -= pienoKiekisL;
                Console.WriteLine("Kava paruosta");
                PanaudojimuSk++;
            }
        }


        //public void GaminkJuoda()
        //{
        //    if (CukrausKiekisKg < 0.01 || KavosPupeliuKiekisKg < 0.03 || VandensKiekisL < 0.3)
        //    {
        //        Console.WriteLine("Nepakanka produktu");
        //    }
        //    else
        //    {
        //        CukrausKiekisKg -= 0.01;
        //        KavosPupeliuKiekisKg -= 0.03;
        //        VandensKiekisL -= 0.3;
        //        Console.WriteLine("Juoda kava paruosta");
        //        PanaudojimuSk++;
        //    }
        //}

        //public void GaminkBalta()
        //{
        //    if (CukrausKiekisKg < 0.01 || KavosPupeliuKiekisKg < 0.03 || VandensKiekisL < 0.2 || PienoKiekisL < 0.1)
        //    {
        //        Console.WriteLine("Nepakanka produktu");
        //    }
        //    else
        //    {
        //        CukrausKiekisKg -= 0.01;
        //        KavosPupeliuKiekisKg -= 0.03;
        //        VandensKiekisL -= 0.2;
        //        PienoKiekisL -= 0.1;
        //        Console.WriteLine("Balta kava paruosta");
        //        PanaudojimuSk++;
        //    }
        //}

        //public void GaminkLate()
        //{
        //    if (CukrausKiekisKg < 0.02 || KavosPupeliuKiekisKg < 0.03 || VandensKiekisL < 0.1 || PienoKiekisL < 0.2)
        //    {
        //        Console.WriteLine("Nepakanka produktu");
        //    }
        //    else
        //    {
        //        CukrausKiekisKg -= 0.02;
        //        KavosPupeliuKiekisKg -= 0.03;
        //        VandensKiekisL -= 0.1;
        //        PienoKiekisL -= 0.2;
        //        Console.WriteLine("Late paruosta");
        //        PanaudojimuSk++;
        //    }
        //}

    }
}
