using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamuDarbai2
{
    public class Apskritimas
    {
        //Sukurkite klasę Apskritimas, kuri:
        //Turės savybę  - Spindulys
        //Nebus galima sukurti apskritimo objekto neperdavus spindulio
        //Turės du metodus - PaskaiciuokIlgi ir PaskaiciuokPlota

        public double Spindulys;

        public Apskritimas(double spindulys)
        {
            Spindulys = spindulys;
        }

        public double PaskaiciuokIlgi()
        {
            return 2 * Math.PI * Spindulys;
        }

        public double PaskaiciuokPlota()
        {
            return Math.PI * Spindulys * Spindulys;
        }
    }
}
