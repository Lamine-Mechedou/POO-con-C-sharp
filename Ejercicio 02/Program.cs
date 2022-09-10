using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //AMBITO: o "scope" en ingles,es la region del programa donde es conocida la variable,el metodo o hasta incluso una clase
            // Hay tres tipos de ambito:
            //1--ambito local:se usa solamente en el mismo metodo
            //2-ambito a nivel objeto:lo pueden usar todos los metodos de la misma clase
            //3-ambito this (de clase):para indicar que se quiere usar el ambito de objeto de la clase y no del metodo,porque dentro del metodo siempre se prioriza las variables que estan dentro de el.

            //Esta clase solo se conoce en main
            int a = 5; //Variable se puede solo usar en la clase main

            a = a * 5;
            Console.WriteLine($"a = {a}");   //A estas variables solo las puedo llamar en esta clase main y no otra como en CMiClase

            //Tratamos de usar directamente el dato de la clase
            //No se puede
            //b = 30;
            //Console.WriteLine("b = {b}");

            //Instanciamos ahora
            CMiClase objeto = new CMiClase();

            objeto.Muestra();
            objeto.Multiplicador();
            objeto.Muestra();
            Console.ReadLine();
        }
    }
}
