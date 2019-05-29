using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptintaPamoka
{
    public class MetodaiSept
    {

        //Aprašykite metodą, kuris nieko negrąžina, tiesiog priima string parametrą - vardą ir išveda į Console “Labas, [vardas]”

        public static void PasisveikinkSuVardu(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}");
        }


        //Aprašykite metodą, kuris kaip parametrą priima skaičių masyvą, naudodamas foreach ciklą visus skaičius iš masyvo susumuoja ir grąžina sumą

        public static double SusumuokMasyva(double[] masyvas)
        {
            double suma = 0;

            foreach (var item in masyvas)
            {
                suma += item;
            }

            return suma;
        }


        //Aprašykite metodą, kuris priima skaičių int kaip parametrą - masyvo dydį ir grąžiną sukurtą tokio dydžio masyvą.

        public static int[] SukurkTokioDydzioMasyva(int dydis)
        {
            //int[] masyvas = new int[dydis];
            //return masyvas;
            return new int[dydis];
        }


        //Aprašykite metodą, kuris priima skaičių int - indeksą bei masyvą int[] kaip parametrus ir grąžina masyvą su nunulintu skaičiumi tuo indeksu

        public static int[] GrazinkNunulintaTuoIndeksu(int indeksas, int[] masyvas)
        {
            masyvas[indeksas] = 0;
            return masyvas;
        }


        // Aprašykite metodą, kuris atspausdina visus sąrašo elementą

        public static void SpausdintiSarasa(List<int> sarasas)
        {
            foreach (int v in sarasas)
            {
                Console.Write(v + " ");
            }

            Console.WriteLine();
        }


        //Aprašykite metodą suskaičiuoti vidurkį

        public static double Vidurkis(List<int> sarasas)
        {
            double suma = 0;
            foreach (var item in sarasas)
            {
                suma += item;
            }

            return suma / sarasas.Count();
        }


        //Aprašykite metodą suskaičiuoti medianą
        
        public static double Medianas(List<int> sarasas)
        {
            sarasas.Sort();

            double medianas;
            int vidurinis = sarasas.Count / 2;

            if (sarasas.Count % 2 != 0)
            {
                medianas = sarasas[vidurinis];
            }
            else
            {
                medianas = (double)(sarasas[vidurinis] + sarasas[vidurinis - 1]) / 2;
            }

            return medianas;
        }

    }
}
