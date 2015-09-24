using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            String palabra = null;
            
            palabra =  Console.ReadLine();
            numero = int.Parse(palabra);

            if (numero > 0) {

                Console.WriteLine("el numero es positivo");

            }
            else if (numero == 0)
            {

                Console.WriteLine("el numero no es negativo ni positivo");

            }
            else {

                Console.WriteLine("el numero es negativo");

            }
            Console.ReadLine();

        }
    }
}
