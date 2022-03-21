using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("¿Con que numero de disco desea jugar?: \n");




            string keyStroke = Console.ReadLine();//leer valor que se introduce

            uint numDiscos = 0;

            while (!UInt32.TryParse(keyStroke, out numDiscos) && keyStroke != "0")
            {//si no meten un numero correcto haz esto

                Console.WriteLine("Introduzca un numero positivo y entero");

                keyStroke = Console.ReadLine();

            }
            //declaracion de pilas, dos de ellas con constructor vacio y una llena
            Pila ini = new Pila(numDiscos);
            Pila aux = new Pila();
            Pila fin = new Pila();

            Hanoi hanoiJuego = new Hanoi();

            uint numMovimientos = 0;

            numMovimientos = hanoiJuego.iterativo(numDiscos, ini, aux, fin);//aqui cambiar la parte de interativo por recursivo y ya
            
            Console.WriteLine(numMovimientos.ToString() + " movimientos han sido necesarios.");

            Console.ReadKey();
        }
    }
}
