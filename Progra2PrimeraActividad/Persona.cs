using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2PrimeraActividad
{
    class Persona
    {
        
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor de la clase
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
