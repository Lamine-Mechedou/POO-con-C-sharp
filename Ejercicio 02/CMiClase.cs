using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class CMiClase
    {
        //Estos datos se pueden ver en cualquier lugar de la clase
        //Pero no fuera de ella,ambito objeto
        private int b = 10; //este es un ambito de objeto y se puede usar en todos los metods de esta clase

        public void Muestra()
        {
            //Creamos una variable local a Muestra
            //Ambito local
            int m = 5;  //esta variable es local solo se puede usar en este metodo,no en otro aunque sea de la misma clase
                        //pero puedo tener otra variable con el mismo nombre en diferentes metodos,pero son diferentes 
            int b = 3;
            //Podemos usar la variable local
            Console.WriteLine($"m = {m}");

            //Tratamos de mostrar la variable de main
            //No se puede
            //Console.WriteLine("a = {a}");

            //Tratamos de mostrar el datos de la clase
            Console.WriteLine($"ambito local b = {b}"); //aca me va a imprimir 3 porque el ambito local es primero
            Console.WriteLine($"ambito objeto this.b = {b}", this.b); //aca imprime 10 porque le indico que quiero b de clase-->amibito this
        }
        public void Multiplicador()
        {
            //Tratamos de usar el dato  de la clase
            b = b * 5;
            //Tratamos de usar la variable local del otro metodo
            //No se puede
           // m = m * 100; 
        }
    }
}
