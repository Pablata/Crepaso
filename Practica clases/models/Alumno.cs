using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_clases.models
{
    class Alumno:Persona
    {
        private String nMatricula;
        private float nota;

        public string NMatricula
        {
            get
            {
                return nMatricula;
            }

            set
            {
                nMatricula = value;
            }
        }

        public float Nota
        {
            get
            {
                return nota;
            }

            set
            {
                nota = value;
            }




        }

        public void Quejarse(string quejarse)
        {

        }
    }
}
