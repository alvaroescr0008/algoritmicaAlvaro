using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            Elementos = new List<Disco>();
        }




        public Pila(uint numeroPila)
        {


            Elementos = new List<Disco>();




            Disco iter;
            for (int i = (int)numeroPila; i >= 1; --i)
            {
                iter = new Disco(i);
                Elementos.Add(iter);
                Top = iter.Valor;
                Size++;
            }
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Top = d.Valor;
            Size++;
        }

        public Disco pop()
        {
            if (isEmpty() == false)
            {
                Disco d = Elementos.Last<Disco>();


                Elementos.Remove(Elementos.Last<Disco>());
                this.Size -= 1;


                if (Elementos.Count > 0)
                {
                    this.Top = Elementos.Last<Disco>().Valor;
                }
                else
                {
                    this.Top = 10;
                }

                return d;
            }
            else
            {
                return null;
            }

        }

        public bool isEmpty()
        {
            return (Elementos.Count == 0 || Size <= 0);
        }
    }
}
