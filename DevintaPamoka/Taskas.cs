using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    public class Taskas
    {
        //Sukurkite klasę Taskas, kuri butinai turės būt sukurta perduodant x ir y ir kuri:
        //Turės viešus kintamuosius x ir y
        //Metodą - Spausdinti, kuris grąžins informaciją tokiu formatu: x={0}, y={1}

        public float X { get; set; }
        public float Y { get; set; }

        public string Spausdink()
        {
            return $"x = {X}, y = {Y}";
        }
    }
}
