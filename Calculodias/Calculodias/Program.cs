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
    class Program
    {
        /*Clase que reccibe y interpreta los calculos y los datos impuestos por el usuario*/


        public static int dia, mes, año;
        static Calculos cal = new Calculos();

        static void Main(string[] args)
        {
            String dato = null;

            /*Entrada de datos por el usuario*/

            /*Dia*/
            Console.WriteLine("escribe el dia que naciste");
            dato = Console.ReadLine();
            dia = int.Parse(dato);

            /*mes*/
            Console.WriteLine("escribe el mes que naciste ¡¡con numero¡¡");
            dato = Console.ReadLine();
            mes = int.Parse(dato);

            /*año*/
            Console.WriteLine("escribe el año que naciste");
            dato = Console.ReadLine();
            año = int.Parse(dato);

            /*comenzamos a calcular*/

            int resultado1 = cal.calculo1(mes);
            int resultado2 = cal.calculo2(año);
            int resultado3 = cal.calculo3(año);
            int resultado4 = cal.calculo4(año);
            int resultado5 = cal.calculo5(dia, mes, año, resultado1, resultado2, resultado3, resultado4);
            int resultado6 = cal.calculo6(resultado5);
            int resultadoFIN = cal.calculo7(resultado5, resultado6);

            /*interprete de resultado*/
            switch (resultadoFIN)
            {
                case 0:
                    /*nacio el sabado*/
                    Console.WriteLine("naciste el dia sabado");
                    Console.ReadLine();
                    break;

                case 1:
                    /*nacio el domingo*/
                    Console.WriteLine("naciste el domingo");
                    Console.ReadLine();
                    break;

                case 2:
                    /*nacio el lunes*/
                    Console.WriteLine("nacite el lunes");
                    Console.ReadLine();
                    break;

                case 3:
                    /*nacio el martes*/
                    Console.WriteLine("naciste el martes");
                    Console.ReadLine();
                    break;

                case 4:
                    /*nacio el miercoles*/
                    Console.WriteLine("naciste el miercoles");
                    Console.ReadLine();
                    break;

                case 5:
                    /*nacio el jueves*/
                    Console.WriteLine("naciste el Jueves");
                    Console.ReadLine();
                    break;

                case 6:
                    /*nacio el viernes*/
                    Console.WriteLine("naciste el viernes");
                    Console.ReadLine();
                    break;

                    
                
            }
        }
    }
}
