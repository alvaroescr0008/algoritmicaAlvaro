using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        private uint numMovimientos = 0;

        /*TODO: Implementar métodos*/
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

            numMovimientos++;
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
