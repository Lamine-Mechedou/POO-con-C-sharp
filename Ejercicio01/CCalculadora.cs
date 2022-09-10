using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    //Esta clase es definida por nosotros
    class CCalculadora
    {
        //Declarar los atributos
        public double a; //Es primera clase por eso usamos acceso publico a nuestros atributos,posterioremente los datos siempre deben ser privados para no romper con el principio de data hiding y evitar problemas
        public double b;
        public double r;

        //Declaramos los metodos
        public void Suma()//es un metodo que no va a regresar nada
        {
            //Se lleva a cabo una accion
            r = a + b;
        }
        public void Muestra()//otro metodo para mostrar
        {
            Console.WriteLine($"a = {a} , b = {b} , r = {r}");
        }
    }

}