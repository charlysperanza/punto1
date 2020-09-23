using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1aplicaciones
{
  /*
    En la clase Program con la función Main probar la clase Persona permitiéndole al usuario la
    carga del nombre y la edad de una persona, luego usar las funciones de la clase.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;

            Console.WriteLine("Ingrese el nombre de la persona");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            Persona tipito = new Persona(nombre, edad); //creamos el objeto tipito

            if (tipito.esMayor() == 1)
            {
                Console.WriteLine("La persona es mayor de edad");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad");
            }

            //tipito.mostrarDatos();

            //Console.WriteLine(tipito.mostrarDatos());

            Console.ReadKey();
        }
    }
}
