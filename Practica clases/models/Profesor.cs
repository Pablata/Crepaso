using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_clases.models
{
    class Profesor:Persona
    {
        private float sueldo;

        public float Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }


        }

        public void Reparar(string reparar) {
        }
    }
}
