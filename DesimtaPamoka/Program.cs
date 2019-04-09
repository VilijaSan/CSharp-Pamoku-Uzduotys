using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Panaudokite KavosAparatas
            
            var kavosAparatas = new KavosAparatas(0, 2, 5, 1);

            kavosAparatas.GaminkKava();
            kavosAparatas.ProduktuBusena();
            kavosAparatas.AparatoBusena();

            Console.ReadLine();
            

            //Sukurkite tris skirtingu gyvunu klases, kurios visos implementuos IGyvunas interfeisą
            //Sukurkite sąrašą, kuris laikys savyje IGyvunas implementuojančių klasių objektus
            //Iteruokite per šį sąrašą ir išveskite visų gyvūnų informaciją, liepkite jiems kalbėti

            List<IGyvunas> gyvunai = new List<IGyvunas>
            {
                new Meska(), new Skruzde()
            };

            foreach (var item in gyvunai)
            {
                item.SpausdinkInfo();
                item.Kalbek();
            }


            //Sukurti klases, kurioms “implementint’ų” IFigura interfeisa
            //Sukurit sąrašą, kuris savyje galėtų laikyti šį interfeisą implementinančius objektus
            //Iteruoti per sąrašą ir išveskite į Console figūros informaciją
            
            List<IFigura> figuros = new List<IFigura>
            {
                new StatusTrikampis(4, 5), new Kvadratas(2)
            };

            figuros.ForEach(f => f.IšveskInformacija());

        }
    }
}
