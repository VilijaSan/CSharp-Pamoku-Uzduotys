using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesimtaPamoka
{
    public class StatusTrikampis : IFigura
    {
        private readonly double a;
        private readonly double b;

        public StatusTrikampis(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double PaskaiciuokPlota()
        {
            double plotas = a * b / 2;
            return plotas;
        }

        public void IšveskInformacija()
        {
            Console.WriteLine($"As esu status trikampis, mano plotas {PaskaiciuokPlota()}");
        }

    }
}
