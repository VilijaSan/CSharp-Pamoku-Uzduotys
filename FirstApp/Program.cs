using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            // CTRL + K + C užkomentuoja; U atkomentuoja; /* */


            //Parašyti programą, kuri išspausdina ekrane jūsų vardą, pavardę bei amžių atskirose eilutėse. 
            // Duomenis rodyti, kol nepaspaudžiamas klaviatūros mygtukas.

            Console.WriteLine("Iveskite savo varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine(vardas);
            Console.ReadLine();


            //paskaiciavimai

            double a = 10;
            a *= 2.5;
            Console.WriteLine(a);
            Console.ReadLine();

            double b = 3;
            b /= 2;
            Console.WriteLine(b);
            Console.ReadLine();

            int c = 3;
            c %= 2;
            Console.WriteLine(c);
            Console.ReadLine();

            float d = 5.4885f;
            d /= 2;
            Console.WriteLine(d);
            Console.Read();


            //Parašyti programą, kuri prašo įvesti apskritimo spindulį ir pagal jį suskaičiuoja jo ilgį ir plotą.

            Console.WriteLine("Iveskite spinduli:");
            string spindulioTekstas = Console.ReadLine();
            double spindulys = double.Parse(spindulioTekstas);

            var plotas = spindulys * spindulys * Math.PI;
            var ilgis = 2 * Math.PI * spindulys;

            Console.WriteLine("Plotas yra: " + plotas);
            Console.WriteLine("Ilgis yra: " + ilgis);

            Console.ReadLine();


            //Parašyti programą, kuri prašo įvesti atstumą (metrais) ir laiką (sekundėmis), o iš įvestų duomenų suskaičiuoja greitį km/h formatu.

            Console.WriteLine("Iveskite atstuma metrais:");
            double atstumasMetrais = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite laika sekundemis:");
            double laikasSekundemis = double.Parse(Console.ReadLine());

            double atstumasKm = atstumasMetrais / 1000;
            double laikasH = laikasSekundemis / (60 * 60);

            double greitisKm = atstumasKm / laikasH;

            Console.WriteLine("Greitis yra: " + greitisKm + " km/h");

            Console.ReadLine();


            //Parašyti programą, kuri prašo įvesti vardą, pavardę ir gimimo vietą ir atspausdina juos ekrane tokiu formatu: 
            //“Jonas Jonaitis gime Palangoje”

            Console.WriteLine("Iveskite varda ir pavarde:");
            string vardasPavarde = Console.ReadLine();

            Console.WriteLine("Kur gimete?:");
            string gimimoVieta = Console.ReadLine();

            Console.WriteLine(vardasPavarde + " gime " + gimimoVieta);
            Console.ReadLine();


            //Parašyti programą, kuri prašo įvesti du skaičius ir patikrina ar jie lygūs

            Console.WriteLine("Iveskite pirma skaiciu:");
            int skc1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int skc2 = int.Parse(Console.ReadLine());

            string atsakymas = skc1 == skc2 ? "lygus" : "nelygus";
            Console.WriteLine("skaiciai yra " + atsakymas);

            //if (Skc1 == Skc2)
            //{
            //    Console.WriteLine("sk1 ir sk2 yra lygus");
            //}
            //else
            //{
            //    Console.WriteLine("sk1 ir sk2 yra nelygus");
            //}

            Console.ReadLine();


            // Parašyti programą, kuri prašo įvesti 3 skaičius ir nustato didžiausią iš jų

            Console.WriteLine("Iveskite pirma skaiciu:");
            int skaicius1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int skaicius2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite trecia skaiciu:");
            int skaicius3 = int.Parse(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("sk1 yra didziausias");
            } 
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("sk2 yra didziausias");
            } 
            else
            {
                Console.WriteLine("sk3 yra didziausias");
            }

            Console.ReadLine();


            //Parašyti programą, kuri prašo įvesti mokinio pažymį ir ekrane išspausdina jo apibūdinimą

            Console.WriteLine("Iveskite pazymi:");
            int pazymys = int.Parse(Console.ReadLine());

            switch(pazymys)
            {
                case 10:
                    Console.WriteLine("puiku");
                    break;
                case 9:
                case 8:
                    Console.WriteLine("labai gerai");
                    break;
                case 7:
                case 6:
                    Console.WriteLine("gerai");
                    break;
                case 5:
                    Console.WriteLine("vidutiniškai");
                    break;
                case 4:
                    Console.WriteLine("bent teigiamas");
                    break;
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("labai blogai");
                    break;
                default:
                    Console.WriteLine("Iveskite kita pazymi");
                    break;
            }
            Console.ReadLine();


            // Parašyti programą, kuri nuskaito įvestą skaičių ir patikrintų ar jis yra lyginis ar nelyginis

            Console.WriteLine("Iveskite skaiciu:");
            int skaiciusTikrinimui = int.Parse(Console.ReadLine());

            //if (skaicius % 2 == 0)
            //{
            //    Console.WriteLine("lyginis");
            //} 
            //else
            //{
            //    Console.WriteLine("nelyginis");
            //}

            string arLyginis = (skaiciusTikrinimui % 2 == 0) ? "lyginis" : "nelyginis";
            Console.WriteLine(arLyginis);
            Console.ReadLine();


            //Parašyti programą, kuri nuskaito savaitės dienos numerį ir atspausdina jos žodinį pavadinimą ekrane.

            Console.WriteLine("Iveskite savaites dienos numeri:");
            int dienosNumeris = int.Parse(Console.ReadLine());

            switch (dienosNumeris)
            {
                case 7:
                    Console.WriteLine("sekmadienis");
                    break;
                case 6:
                    Console.WriteLine("šeštadienis");
                    break;
                case 5:
                    Console.WriteLine("penktadienis");
                    break;
                case 4:
                    Console.WriteLine("ketvirtadienis");
                    break;
                case 3:
                    Console.WriteLine("trečiadienis");
                    break;
                case 2:
                    Console.WriteLine("antradienis");
                    break;
                case 1:
                    Console.WriteLine("pirmadienis");
                    break;
                default:
                    Console.WriteLine("tokio savaites dienos numerio nera");
                    Main(null);
                    break;
            }
            Console.ReadLine();


            //Parašyti programą kalkuliatorių, kuri nuskaito 2 skaičius, nuskaito matematinį veiksmą, atlieka veiksmą ir atspausdina rezultatą ekrane 
            //tokiu formatu: “{ pirmas skaicius} { matematinis veiksmas} { antras skaičius} = { rezultatas}”

            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite veiksma:");
            string veiksmas = Console.ReadLine();

            int rezultatas = 0;
            switch (veiksmas)
            {
                case "+":
                    rezultatas = sk1 + sk2;
                    break;
                case "-":
                    rezultatas = sk1 - sk2;
                    break;
                case "*":
                    rezultatas = sk1 * sk2;
                    break;
                case "/":
                    rezultatas = sk1 / sk2;
                    break;
                case "%":
                    rezultatas = sk1 % sk2;
                    break;
                default:
                    Console.WriteLine("Netinkamas matematinis veiksmas");
                    Console.ReadLine();
                    return;
            }

            Console.WriteLine($"{sk1} {veiksmas} {sk2} = {rezultatas}");
            Console.ReadLine();

        }
    }
}
