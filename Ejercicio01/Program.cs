using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Crear un programa que suma dos numeros interos usando objetos,clases y metodos

            //Creamos instancia(objeto)
            CCalculadora calcu1 = new CCalculadora(); //el objeto calcu1 pertenece a la clase CCalculadora(calcu1 es de tipo CCalculadora)

            //Accedemos a los atributos para colocar informacion 
            calcu1.a = 5;
            calcu1.b = 3;

            //Mostramos los datos
            calcu1.Muestra();

            //Invocamos metodo
            calcu1.Suma();

            //Mostramos nuevamente los datos
            calcu1.Muestra();

            //-----------
            Console.WriteLine("------------------");
            //Creamos otro objeto y asignamos valores
            CCalculadora miCalcu = new CCalculadora();
            miCalcu.a = 18;
            miCalcu.b = 53;
            miCalcu.Suma();

            //Comprobamos que cada objeto tiene su propia informacion

            calcu1.Muestra();
            miCalcu.Muestra();

            Console.ReadLine();
        }
        
    }
}
