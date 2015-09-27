using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CongeturaCollazt
{
    /*
      @author: jorge andres costa ribeiro 
      @date: 26/09/2015

      Una aplicación en la que debemos demostrar la conjetura de Collatz.        
     */
    
    class CongeturaCollazt
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("digame un nuemro ¡¡POSITIVO¡¡ para la congetura");
            numero = int.Parse(Console.ReadLine());

           
            if (numero > 0)
            {
                while (numero != 1){

                    /*	Si el número es par, debemos dividirlo entre dos.*/
                    if (numero%2 == 0)
                    {
                        numero = numero / 2;
                        Console.WriteLine(numero);

                    }

                    /*Si el número es impar, debemos multiplicarlo por 3 y sumarle uno.*/
                    else {

                        numero = (numero * 3) + 1;
                        Console.WriteLine(numero); 
                    }

                }

                Console.WriteLine("Se acabo la congetura");
                Console.ReadLine();

           /*si el nuemero es negativo no se puede realizar los calculos*/ 
           } else {

                Console.WriteLine("el numero no se  puede calcular porque no es positivo");
            }
        }
    }
}
