using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 @author: jorge andres da costa ribeiro
 @date: 24/09/2015
 * 
 * descricion: Clase que calculara que dia de la semana naciste al introducir tu fecha completa
 */
namespace ConsoleApplication1
{
    class CalculoDia
    {
        

        public int dia, mes, año;

        public void main() {
            
            /*
             * ejecucion principal del programa que contiene los datos introducidos por el usuario como dia; año y mes.
             * 
             * jorge andres da costa ribeiro
             * 24/29/2015
             */

            String datos = null;

            //entrada de datos 1 (dia)
            Console.WriteLine("introduzca el dia en que nacio");
            datos = Console.ReadLine();
            dia = int.Parse(datos);

            //entrada de datos 2 (mes)
            Console.WriteLine("introduzca el mes en que nacio !!!! CON NUMERO !!!!!");
            datos = Console.ReadLine();
            mes = int.Parse(datos);

            //entrada de datos 3 (año)
            Console.WriteLine("introduzca el año en que nacio");
            datos = Console.ReadLine();
            año = int.Parse(datos);


        
        
        }
        private int calculo1() {

            int resultado;

            resultado = ((mes + 1) * 3) / 5;

            return resultado;
        }
        private int calculo2() {

            int resultado2;

            resultado2 = (año / 4);

            return resultado2;
        
        }
        private int calcule3() {

            int resultado3;

            resultado3 = (año / 400);

            return resultado3;
        }

     }
}
