using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenktaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą, kuri išvestų į ekraną 5 kartus tą patį žodį.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Labas");
            }
            Console.ReadLine();


            //Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki 100.

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki įvesto skaičiaus z.

            Console.WriteLine("Iveskite skaiciu:");
            int z = int.Parse(Console.ReadLine());

            for (int i = 1; i <= z; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //Parašykite programą, kuri išveda į ekraną skaičius nuo įvesto skaičiaus x iki x+10

            Console.WriteLine("Iveskite skaiciu:");
            int x = int.Parse(Console.ReadLine());

            for (int i = x; i <= x + 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //Parašykite programą, kuri išvestų skaičius nuo l iki k.

            Console.WriteLine("Iveskite skaiciu:");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu:");
            int k = int.Parse(Console.ReadLine());

            for (int i = l; i <= k; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //Parašykite programą, kuri suskaičiuotų skaičių nuo m iki n sumą (s = m + (m + 1) +... + n)

            Console.WriteLine("Iveskite skaiciu:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu:");
            int n = int.Parse(Console.ReadLine());

            int skSuma = 0;

            for (int i = m; i <= n; i++)
            {
                skSuma += i;
            }

            Console.WriteLine(skSuma);
            Console.ReadLine();


            //Parašykite programą, kuri suskaičiuotų skaičiaus b faktorialą

            Console.WriteLine("Iveskite skaiciu:");
            int b = int.Parse(Console.ReadLine());

            int faktorialas = 1;

            for (int i = 1; i <= b; i++)
            {
                faktorialas *= i;
            }

            Console.WriteLine(faktorialas);
            Console.ReadLine();


            //Parašykite programą, kuri suskaičiuotų, kiek yra triženklių skaičių, besidalinančių iš keturių ir išvestų juos į ekraną

            int kiekDalinasi = 0;

            for (int i = 100; i < 1000; i++)
            {
                if (i % 4 == 0)
                {
                    kiekDalinasi++;
                }
            }

            Console.WriteLine(kiekDalinasi);
            Console.ReadLine();


            // Parašykite programą, kuri:
            //paprašytų įvesti 5 skaičius naudojantis ciklu;
            //Suskaičiuotų skaičių sumą;
            //Suskaičiuotų skaičių  aritmetinį vidurkį;
            //Surastų, kiek buvo neigiamų skaičių ir kiek teigiamų

            double skcSuma = 0;
            int teigiamu = 0;
            int neigiamu = 0;
            int sk;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                sk = int.Parse(Console.ReadLine());

                if (sk > 0)
                {
                    teigiamu++;
                }
                else
                {
                    neigiamu++;
                }

                skcSuma = skcSuma + sk;
            }

            Console.WriteLine($"skaiciu suma: {skcSuma}; skaiciu vidurkis {skcSuma / 5}");
            Console.WriteLine($"teigiamu skaiciu buvo: {teigiamu}; neigiamu skaiciu buvo: {neigiamu}");
            Console.ReadLine();


            // Klaviatūra renkama skaičių seka. Jos ilgis nurodomas. 
            //Parašykite programą, didžiausiam ir mažiausiam sekos skaičiui išrinkti.

            Console.WriteLine("Iveskite sekos ilgi:");
            int ilgis = int.Parse(Console.ReadLine());

            int max = 0;
            int min = int.MaxValue;
            int skaicius;

            for (int i = 0; i < ilgis; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                skaicius = int.Parse(Console.ReadLine());

                if (skaicius > max)
                {
                    max = skaicius;
                }
                if (skaicius < min)
                {
                    min = skaicius;
                }
            }

            Console.WriteLine($"Didziausias skaicius yra {max}, maziausias skaicius yra {min}");
            Console.ReadLine();


            // Architektas suprojektavo salę, kurioje bus n eilių. Pirmoje eilėje stovės k kėdžių, o kiekvienoje kitoje – 2 kėdėmis daugiau, 
            //negu prieš tai buvusioje. Parašykite programą, kuri apskaičiuotų, kiek iš viso kėdžių s reikia užsakyti, 
            //kad architekto sumanymas būtų įgyvendintas.

            Console.WriteLine("Iveskite kiek eiliu bus saleje:");
            int eiles = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite kiek kedziu stoves pirmoje eileje:");
            int kedesPirmoj = int.Parse(Console.ReadLine());

            int kedesEilej = kedesPirmoj;
            int visoKedziu = kedesPirmoj;

            for (int i = 1; i < eiles; i++)
            {
                kedesEilej = kedesEilej + 2;
                visoKedziu = visoKedziu + kedesEilej;
            }

            Console.WriteLine(visoKedziu);

            Console.ReadLine();


            // Deklaruokite sveikų skaičių masyvą kuriame bus 10 skaičių.
            //Įdėkite į masyvą skaičius, šitaip masyvas[0] = 10;

            int[] masyvas1 = new int[10];

            masyvas1[0] = 10;
            masyvas1[1] = 9;
            masyvas1[2] = 8;
            masyvas1[3] = 7;
            masyvas1[4] = 6;
            masyvas1[5] = 5;
            masyvas1[6] = 4;
            masyvas1[7] = 3;
            masyvas1[8] = 2;
            masyvas1[9] = 1;


            // Deklaruokite tekstų masyvą, kuriame bus 5 tekstai (string).
            //Deklaruojant iš karto ir nurodykite šių tekstų reikšmes(tarp riestinių skliaustų)

            string[] masyvas2 = new string[5] { "a", "b", "c", "d", "e" };


            //Atspausdinkite kiekvieną tekstų masyvo elementą naudojantis for ciklu.

            for (int i = 0; i < masyvas2.Length; i++)
            {
                Console.WriteLine(masyvas2[i]);
            }

            Console.ReadLine();


            // Atspausdinkite kiekvieną skaičių masyvo elementą pakeltą kvadratu

            for (int i = 0; i < masyvas1.Length; i++)
            {
                Console.WriteLine(Math.Pow(masyvas1[i], 2));
            }

            Console.ReadLine();


            // Lietuvos hidrometeorologijos tarnyba kaupia įvairiose Lietuvos vietovėse vasarą iškritusių kritulių stebėjimo duomenis. 
            //Parenkite programą, kuri pateiktų informaciją apie lietingas dienas:
            //Kiek mm iškrito kiekvieną iš dienų;
            //Kiek mm kritulių iškrito iš viso;
            //Kiek dienų nelijo;
            //Kiek mm kritulių vidutiniškai iškrito tomis dienomis, kai lijo.;
            //Duomenys: 10, 20, 0, 0, 0, 45, 25, 30, 50, 25.

            int[] krituliai = { 10, 20, 0, 0, 0, 45, 25, 30, 50, 25 };

            int suma = 0;
            int kiekNelijo = 0;
            int kiekPrilijo = 0;
            int dienaLijo = 0;

            for (int i = 0; i < krituliai.Length; i++)
            {
                suma = suma + krituliai[i];

                if (krituliai[i] == 0)
                {
                    kiekNelijo++;
                }
                else
                {
                    kiekPrilijo = kiekPrilijo + krituliai[i];
                    dienaLijo++;
                }

                Console.WriteLine($"{i + 1} diena iskrito {krituliai[i]} mm krituliu");
            }

            Console.WriteLine($"Is viso iskrito {suma} mm krituliu");
            Console.WriteLine($"Nelijo dienu: {kiekNelijo}");
            Console.WriteLine($"Vidutiniskai per lietingas dienas prilijo {kiekPrilijo/dienaLijo} mm krituliu");
            Console.ReadLine();


            // Duoti klasės mokinių ūgiai centimetrais, merginų ūgiai - teigiami, o vaikinų - neigiami.
            //Parašykite tokią programą, kuri remdamasi duotais duomenimis:
            //Paskaičiuotų klasės mokinių ūgių vidurkį
            //Paskaičiuotų merginų ugių vidurkį
            //Paskaičiuotų vaikinų ūgių vidurkį
            //Išvestų pranešimą, ar galima sudaryti iš klasės merginų ir vaikinų krepšinio komandas. Reikalavimai krepšinio komandai: 
            //ūgis ne mažesnis nei 175cm, komandoje turi būti 7 žaidėjai(5 pagrindiniai ir 2 atsarginiai).
            //Duomenys: -178, 175, -186, 172, 173, 175, -185, -180, -169, 165, 176, 172, -180, 176, -190, 176, -174, 177, -172, 178

            //double vidutinis = ugiai.Average();
            //Console.WriteLine(vidutinis);

            int[] ugiai = { -178, 175, -186, 172, 173, 175, -185, -180, -169, 165, 176, 172, -180, 176, -190, 176, -174, 177, -172, 178 };

            double ugiuSuma = 0;
            int vaikinai = 0;
            int merginos = 0;
            double vaikUgiai = 0;
            double mergUgiai = 0;
            int vaikKomanda = 0;
            int mergKomanda = 0;

            for (int i = 0; i < ugiai.Length; i++)
            {
                if (ugiai[i] < 0)
                {
                    ugiai[i] *= -1;
                    vaikinai++;
                    vaikUgiai = vaikUgiai + ugiai[i];

                    if (ugiai[i] >= 175)
                    {
                        vaikKomanda++;
                    }
                }
                else
                {
                    merginos++;
                    mergUgiai = mergUgiai + ugiai[i];

                    if (ugiai[i] >= 175)
                    {
                        mergKomanda++;
                    }
                }

                ugiuSuma = ugiuSuma + ugiai[i];
            }

            Console.WriteLine($"Klases ugiu vidurkis yra {ugiuSuma/ugiai.Length:N2}");
            Console.WriteLine($"Klases vaikinu ugiu vidurkis yra {vaikUgiai / vaikinai:N2}");
            Console.WriteLine($"Klases merginu ugiu vidurkis yra {mergUgiai / merginos:N2}");

            if (vaikKomanda >= 7)
            {
                Console.WriteLine("Vaikinu komanda galima");
            }

            if (mergKomanda >= 7)
            {
                Console.WriteLine("Merginu komanda galima");
            }

            Console.ReadLine();


            // Keliamieji metai turi 366 dienas, paprastieji – 365.  Jeigu metai nėra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 4; 
            //Jeigu metai yra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 400 
            //Parašykite programą, kuri ekrane parodytų keliamuosius metus laikotarpio, kuris prasideda m-aisiais, o baigiasi n-aisiais metais.

            Console.WriteLine("Iveskite pradzios metus:");
            int pirmiMetai = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite pabaigos metus:");
            int paskutiniaiMetai = int.Parse(Console.ReadLine());

            Console.Write("Keliamieji metai yra ");

            for (int i = pirmiMetai; i <= paskutiniaiMetai; i++)
            {
                if (i % 100 != 0 && i % 4 == 0)
                {
                    Console.Write($"{i}, ");
                }
                else if (i % 100 == 0 && i % 400 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }

            Console.ReadLine();
        }
    }
}
