using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
@author: jorge andres da costa ribeiro
@date: 27/09/2015

    programa que representa la serie fibonacci a traves de un tope establecido por el usuario
*/
namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*La serie fibonacci es la seria formada por la consecucion de un numero + en numero anterior*/

            String datos = null;

            Console.WriteLine("digame el numero tope de la serie");
            datos = Console.ReadLine();

            int tope = int.Parse(datos);

            int numero1 = 1;
            int numero2 = 1;

            int suma = numero1 + numero2;

            while (suma < tope)
            {
                
                numero1 = numero2;
                numero2 = suma;
                Console.WriteLine(suma);
                suma = numero1 + numero2;
            }

            Console.ReadLine();

        }
    }
}
