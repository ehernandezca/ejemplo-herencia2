using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace ejemplo_herencia2
{
    class Alumno : Persona

    {
        private double matricula;
        private string Carrera;
        public string Carrera
         {
        get
             {
            return Carrera ;
            }
            set
            {
                Carrera = value;
            }
        }
            public double matricula
        {
            get
            {
                return matricula;
        }
              set
            {
                matricula = value;
            }
        }

        public Alumno()
            {
            matricula = 0.00;
            Carrera = "";
        }


