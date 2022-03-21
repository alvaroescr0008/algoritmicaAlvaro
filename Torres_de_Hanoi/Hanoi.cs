using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private uint hitorialMovimientos = 0;

        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top == b.Top)
            {
                return;
            }
            else if (a.Top > b.Top)
            {
                if (b.isEmpty()) { b.push(a.pop()); }
                else { a.push(b.pop()); }
            }
            else
            {
                if (a.isEmpty()) { a.push(b.pop()); }
                else { b.push(a.pop()); }
            }

            hitorialMovimientos++;
        }

        public uint iterativo(uint n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 0) { return hitorialMovimientos; }

            else if (!esPar(n))
            {
                while (!terminado(fin, n))
                {
                    mover_disco(ini, fin);
                    if (terminado(fin, n)) { break; }
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                    if (terminado(fin, n)) { break; }
                }
            }
            else
            {
                while (!terminado(fin, n))
                {
                    mover_disco(ini, aux);


                    mover_disco(ini, fin);

                    if (terminado(fin, n)) { break; }

                    mover_disco(aux, fin);

                    if (terminado(fin, n)) { break; }
                }
            }

            return hitorialMovimientos;
        }


        public bool esPar(uint valorNum)
        {
            return (valorNum % 2 == 0);
        }

        public bool terminado(Pila p, uint n)
        {
            return (p.Size == n);
        }
    }
}
