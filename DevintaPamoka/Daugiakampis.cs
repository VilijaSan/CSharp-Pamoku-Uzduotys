using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevintaPamoka
{
    public class Daugiakampis
    {
        //Sukurti klasę Daugiakampis, kuris:
        //Turės savyje privačią savybę - sąrašą taškų.
        //Sukuriant daugiakampį, būtina jam perduot jo taškus
        //Turės metodus: 
        //Spausdink taškus - atspausdins visus taškus.
        //Pridėk tašką - pridės naują tašką
        //Ištrink tašką - ištrins tašką iš sąrašo pagal nurodytą indeksą

        private List<Taskas> TaskuSarasas { get; set; }

        public Daugiakampis(List<Taskas> taskuSarasas)
        {
            TaskuSarasas = taskuSarasas;
        }

        public void SpausdinkTaskus()
        {
            TaskuSarasas.ForEach(t => Console.WriteLine(t.Spausdink()));
            //TaskuSarasas.ForEach(t => Console.WriteLine($"x={t.X}, y={t.Y}"));
        }

        public void PridekTaska(Taskas taskas)
        {
            TaskuSarasas.Add(taskas);
        }

        public void PridekTaska(float x, float y)
        {
            TaskuSarasas.Add(new Taskas() { X = x, Y = y });
        }

        public void IstrinkTaska(int indeksas)
        {
            TaskuSarasas.RemoveAt(indeksas);
        }
    }
}
