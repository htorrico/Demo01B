using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Persona persona = new Persona();
            persona.Nombres = "Hugo Felipe";
            persona.Apellidos = "Torrico Márquez";

            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);


            Persona persona1 = new Persona("Reyna", "Torrico");

            Persona persona2 = new Persona
            {
                Nombres = "Dérek",
                Apellidos = "Torrico",
                //Edad=5
            };


            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 4;
            triangulo.Base = 5;
            Console.WriteLine(triangulo.CalcularArea());


            Estudiante estudiante = new Estudiante
            {
                Nombres = "Dave",
                Apellidos = "Santivañez",
                Nota = 20
            };
            /*
             [0,2000>     8%
             [2000,5000> 14%
             [5000,+00>  30%             
            
             SueldoNeto=Sueldo - Descuento
             */



            Console.WriteLine("Hola Mundo");
            Console.Read();

        }
    }
}
