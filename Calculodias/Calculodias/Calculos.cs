using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
@author: Jorge Andres Da Costa Ribeiro
@date: 27/09/2015
*/
namespace Calculodias
{
    class Calculos
    {
        /*clase que realixa todos los calculos matematicos necesarios para que se obtenga el dia*/
        
        /*Multiplicar el Mes más 1 por 3 y dividirlo entre 5*/
        public int calculo1( int mes)
        {
            int resultado = ((mes + 1) * 3) / 5;
            
            return resultado;
        }

        /*Dividir el año entre 4*/
        public int calculo2( int año) {

            int resultado2 = año / 4;

            return resultado2;
        }

        /*Dividir el año entre 100*/
        public int calculo3(int año) {

            int resultado3 = año / 100;

            return resultado3;
        }

        /*Dividir el año entre 400*/
        public int calculo4(int año) {

            int resultado4 = año / 400;

            return resultado4;
        }

        /*Sumar el dia, el doble del mes, el año, el resultado de la operación 1, 
        el resultado de la operación 2, menos el resultado de la operación 3 más la operación 4 más 2.*/
        public int calculo5(int dia, int mes, int año, int resultado1, int resultado2, int resultado3, int resultado4) {

            int resultado5 = dia + (mes * 2) + año + resultado1 + resultado2 - resultado3 + resultado4 + 2;


            return resultado5;
        }

        /*Dividir el resultado5  entre 7.*/
        public int calculo6(int resultado5) {

            int resultado6 = resultado5 / 7;

            return resultado6;
        }

        /*Restar el número del paso 5 con el número del paso 6 por 7.*/
        public int calculo7(int resultado5, int resultado6) {

            int resultado7 = resultado5 - (resultado6 * 7);

            return resultado7;
        }
    }
}
 