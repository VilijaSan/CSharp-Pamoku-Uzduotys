using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą, kuri nustatytų, ar a ir b skaičių suma yra lygi 5.
            
            Console.WriteLine("Iveskite skaiciu a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu b:");
            int b = int.Parse(Console.ReadLine());

            string atsakymas = (a + b == 5) ? "Suma lygi 5" : "Suma nelygi 5";
            Console.WriteLine(atsakymas);

            //if (a + b == 5)
            //{
            //    Console.WriteLine("Suma lygi 5");
            //}
            //else
            //{
            //    Console.WriteLine("Suma nelygi 5");
            //}

            Console.ReadLine();


            // Parašykite programą, kuri nustatytų, ar skaičius c dalijasi iš 3 be liekanos.

            Console.WriteLine("Iveskite skaiciu:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a % 3 == 0 ? $"{a} dalijasi is 3 be liekanos" : $"{a} nesidalina is 3 be liekanos");

            //if (c % 3 == 0)
            //{
            //    Console.WriteLine($"{c} dalijasi is 3 be liekanos");
            //}
            //else
            //{
            //    Console.WriteLine($"{c} nesidalina is 3 be liekanos");
            //}

            Console.ReadLine();


            //Parašykite programą, kuri išvestų į ekraną duotą skaičių x padidintą 2 kartus, jei jis didesnis už 10.

            Console.WriteLine("Iveskite skaiciu:");
            int x = int.Parse(Console.ReadLine());

            if (x > 10)
            {
                Console.WriteLine(x * 2);
            }
            else
            {
                Console.WriteLine($"{x} maziau uz 10");
            }

            Console.ReadLine();


            //Parašykite programą, kuri nustatytų, ar terminale įvestas skaičius yra teigiamas, neigiamas ar nulinis.

            Console.WriteLine("Iveskite skaiciu:");
            int e = int.Parse(Console.ReadLine());

            if (e > 0)
            {
                Console.WriteLine($"{e} teigiamas");
            }
            else if (e < 0)
            {
                Console.WriteLine($"{e} neigiamas");
            }
            else
            {
                Console.WriteLine($"{e} nulinis");
            }

            Console.ReadLine();


            // Parašykite programą, kuri nustatytų, ar keturzenklio skaičiaus pirmasis skaitmuo yra lyginis skaičius.

            Console.WriteLine("Iveskite keturzenkli skaiciu:");
            int keturzenklis = int.Parse(Console.ReadLine());

            int pirmasSkaitmuo = keturzenklis / 1000;

            if (pirmasSkaitmuo % 2 == 0)
            {
                Console.WriteLine($"pirmas skaitmuo lyginis");
            }
            else
            {
                Console.WriteLine($"pirmas skaitmuo nelyginis");
            }

            Console.ReadLine();


            //Pirmosios olimpinės ţaidynės įvyko 1896 metais ir toliau organizuojamos kas ketveri metai. 
            //Jei žaidynės neįvyksta, tie metai vis tiek laikomi olimpiniais, o žaidynėms skiriamas eilės numeris. 
            //Parašykite programą, kuri surastų m-tųjų metų olimpinių žaidynių numerį n. 
            //Jei metai neolimpiniai, turi būti spausdinama „Metai neolimpiniai“. 

            Console.WriteLine("Iveskite metus:");
            int metai = int.Parse(Console.ReadLine());

            int pirmosOlimpines = 1896;

            if (metai % 4 != 0 || metai < pirmosOlimpines)
            {
                Console.WriteLine($"metai neolimpiniai");
                return;
            }

            int numeris = (metai - pirmosOlimpines) / 4 + 1;
            Console.WriteLine($"Metai olimpiniai, žaidynių eilės numeris yra {numeris}");

            Console.ReadLine();


            //Gamtininkas registruoja likusius žiemoti paukščius. Jo tikslas yra nustatyti, kurios iš trijų paukščių rūšių atstovų 
            //liko žiemoti daugiausia. Klaviatūra įvedami trijų paukščių rūšių kiekiai, parašykite programą, 
            //kuri surikiuotų juos iš eilės nuo didžiausio iki mažiausio ir apskaičiuotų, kiek skiriasi didžiausias ir mažiausias kiekiai.

            Console.WriteLine("Iveskite pauksciu kieki:");
            int pauksciaiA = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite pauksciu kieki:");
            int pauksciaiB = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite pauksciu kieki:");
            int pauksciaiC = int.Parse(Console.ReadLine());

            int pauksciaiMax;

            if ((pauksciaiA > pauksciaiB) && (pauksciaiA > pauksciaiC))
            {
                pauksciaiMax = pauksciaiA;
            }
            else if ((pauksciaiB > pauksciaiA) && (pauksciaiB > pauksciaiC))
            {
                pauksciaiMax = pauksciaiB;
            }
            else
            {
                pauksciaiMax = pauksciaiC;
            }

            int pauksciaiMin;

            if ((pauksciaiA < pauksciaiB) && (pauksciaiA < pauksciaiC))
            {
                pauksciaiMin = pauksciaiA;
            }
            else if ((pauksciaiB < pauksciaiA) && (pauksciaiB < pauksciaiC))
            {
                pauksciaiMin = pauksciaiB;
            }
            else
            {
                pauksciaiMin = pauksciaiC;
            }

            int pauksciaiMid;

            if ((pauksciaiA != pauksciaiMin) && (pauksciaiA != pauksciaiMax))
            {
                pauksciaiMid = pauksciaiA;
            }
            else if ((pauksciaiB != pauksciaiMin) && (pauksciaiB != pauksciaiMax))
            {
                pauksciaiMid = pauksciaiB;
            }
            else
            {
                pauksciaiMid = pauksciaiC;
            }

            int skirtumas = pauksciaiMax - pauksciaiMin;

            Console.WriteLine($"{pauksciaiMax} {pauksciaiMid} {pauksciaiMin}; Skirtumas tarp didžiausio ir mažiausio kiekio: {skirtumas}");
            Console.ReadLine();

            /*
            List<int> pauksciai = new List<int>
            {
                pauksciaiA, pauksciaiB, pauksciaiC
            };

            var pauksciaiRik = pauksciai.OrderByDescending(p => p);

            var skirtumas = pauksciai.Max() - pauksciai.Min();

            Console.WriteLine($"{string.Join(" ", pauksciaiRik)}");
            Console.ReadLine();*/

            
            //Parašykite programą, kuri nustatytų, ar duotas skaičius n yra pirminis.
            
            Console.WriteLine("Iveskite skaiciu:");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("nepirminis");
                Console.ReadLine();
                return;
            }

            if (n == 2)
            {
                Console.WriteLine("pirminis");
                Console.ReadLine();
                return;
            }

            for (int i = 3; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("nepirminis");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("pirminis");
            Console.ReadLine();


            //Parašykite programą, kuri suskaičiuotų, kiek skaitmenų turi duotas skaičius.

            Console.WriteLine("Iveskite skaiciu:");
            int u = int.Parse(Console.ReadLine());

            int skaitmenys = 0;
            while (u > 0)
            {
                u = u / 10;
                skaitmenys++;
            }
            Console.WriteLine(skaitmenys);

            Console.ReadLine();


            //Martynas labai mėgsta saldainius. Mamos slėptuvėje jis rado n saldainių. 
            //Pirmą dieną jis suvalgė 1 saldainį, antrąją – 2, trečiąją – 3. 
            //Kiekvieną kitą dieną jis suvalgydavo vienu saldainiu daugiau negu prieš tai buvusią dieną. 
            //Per kelias dienas d Martynas suvalgys visus saldainius? Paskutinei dienai gali likti mažiau saldainių.

            Console.WriteLine("Iveskite saldainiu skaiciu:");
            int saldainiai = int.Parse(Console.ReadLine());

            int diena = 0;

            while (saldainiai > 0)
            {
                diena++;
                saldainiai = saldainiai - diena;

            }

            Console.WriteLine(diena);

            Console.ReadLine();


            // Parašykite programą klaviatūra renkamos skaičių sekos aritmetiniam vidurkiui rasti. Sekos pabaigos požymis – nulis

            int kelintas = 0;
            double suma = 0;

            bool arSustoti = false;

            int skaicius;

            while (!arSustoti)
            {
                Console.WriteLine("Iveskite skaiciu:");
                skaicius = int.Parse(Console.ReadLine());

                if (skaicius == 0)
                {
                    arSustoti = true;
                }
                else
                {
                    kelintas++;
                    suma = suma + skaicius;
                }
            }

            double rezultatas = suma / kelintas;

            Console.WriteLine(rezultatas);

            Console.ReadLine();
            

            // Parašykite programą klaviatūra renkamai teigiamų skaičių sekai analizuoti: suskaičiuokite, 
            //kiek yra šioje sekoje lyginių ir nelyginių skaičių. Sekos pabaigos požymis – nulis. 

            int lyginiuSk = 0;
            int nelyginiuSk = 0;
            int ivestasSk;

            Console.WriteLine("Iveskite teigiama skaiciu:");
            ivestasSk = int.Parse(Console.ReadLine());

            while (ivestasSk != 0)
            {
                if (ivestasSk > 0)
                {
                    if (ivestasSk % 2 == 0)
                    {
                        lyginiuSk++;
                    }
                    else
                    {
                        nelyginiuSk++;
                    }
                }

                Console.WriteLine("Iveskite teigiama skaiciu:");
                ivestasSk = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Lyginiu skaiciu: {lyginiuSk}");
            Console.WriteLine($"Nelyginiu skaiciu: {nelyginiuSk}");

            Console.ReadLine();


            // Sukurkite programą, kuri apskaičiuotų dvejeto laipsnį 2n, kuris yra ne didesnis už teigiamą sveikąjį skaičių y

            Console.WriteLine("Iveskite teigiama skaiciu:");
            int y = int.Parse(Console.ReadLine());

            int laipsnis = 1;
            double duLaipsniu = 2;
            double duAukstesniuLaipsniu;
           
            while (duLaipsniu <= y)
            {
                duAukstesniuLaipsniu = Math.Pow(2, laipsnis + 1);

                if (duLaipsniu == y || duAukstesniuLaipsniu > y)
                {
                    break;
                }
                else
                {
                    laipsnis++;
                    duLaipsniu = Math.Pow(2, laipsnis);  
                }                
            }

            Console.WriteLine(duLaipsniu);
            Console.ReadLine();

            
            // Bankas už indėlius moka p procentų palūkanų per metus. Metų gale palūkanos pridedamos prie indėlio. 
            //Jei indėlininkas pinigų nė kiek neišima, palūkanos skaičiuojamos nuo vis didesnės sumos. 
            //Parašykite programą, kuri apskaičiuotų, per kiek metų t pradinis indėlis ind pasieks sumą s.  

            Console.WriteLine("Iveskite pradini indeli:");
            double pradinisIndelis = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite siekiama suma s:");
            double norimaSuma = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite palukanas:");
            double palukanuProcentas = double.Parse(Console.ReadLine());

            double sukauptasIndelis = pradinisIndelis;
            int metuSk = 0;
            double sukauptaPerMetus;

            while (sukauptasIndelis < norimaSuma)
            {
                sukauptaPerMetus = sukauptasIndelis * (palukanuProcentas / 100);
                sukauptasIndelis = sukauptasIndelis + sukauptaPerMetus;
                metuSk++;
            }

            Console.WriteLine(metuSk);
            Console.ReadLine();
        }
    }
}
