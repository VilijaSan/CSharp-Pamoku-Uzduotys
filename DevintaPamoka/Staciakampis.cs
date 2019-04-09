using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    public class Staciakampis
    {
        //Sukurti klasę Stačiakampis, kuris:
        //Turės savybes kraštinių ilgiams saugoti a ir b.
        //Stačiakampį kuriant bus būtina perduoti kraštinių ilgius.
        //Turės du metodus, kurie mokins grąžinti jo plotą ir perimetrą

        private float A { get; set; }
        private float B { get; set; }

        public Staciakampis(float a, float b)
        {
            A = a;
            B = b;
        }

        public float Plotas()
        {
            return A * B;
        }

        public float Perimetras()
        {
            return 2 * (A + B);
        }
    }
}
