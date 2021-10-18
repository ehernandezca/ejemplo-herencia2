using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using.Sysem.Threading.Tasks;
namespace ejemplo_herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = newPersona();
            persona.FechadeNacimiento = 04 / 12 / 20;
            persona.Nombre = "";
            Alumno Alm = newAlumno();
            Console.WriteLine(Alm.ToString());
        }
    }
}
