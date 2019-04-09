using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    public class Kvadratas : IFigura
    {
        private readonly double a;

        public Kvadratas(double a)
        {
            this.a = a;
        }

        public double PaskaiciuokPlota()
        {
            double plotas = a * a;
            return plotas;
        }

        public void IšveskInformacija()
        {
            Console.WriteLine($"As esu kvadratas, mano plotas {PaskaiciuokPlota()}");
        }
    }
}
