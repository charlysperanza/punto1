using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1aplicaciones
{
      /**
     * Confeccionar una clase persona que debe tener los siguientes atributos:
        o Nombre
        o Edad
    La clase debe tener los siguientes métodos:
        o Constructor: Para inicializar el objeto 
        o mostrarDatos: Que muestre el nombre y la edad
        o esMayor: Que informe si la persona es o no mayor de edad
        */
    class Persona
    {
        string nombre;
        int edad;

        public Persona(string nom, int e)
        {
            nombre = nom; //this.nombre -> atributo de la clase nombre->variable que recibo por parametro
            edad = e;
        }

        public int esMayor()
        {
            //devolvemos 0 si no es mayor y 1 si es mayor
            if (edad >= 18)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //mostrarDatos la hacen ustedes

    }
}
