using Domanin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class EstudianteModel : IEstudiante
    {
        private Estudiante[] estudiantes;
        private Nota[] notas;
        public void create(Estudiante t)
        {
            if (estudiantes == null)
            {
                estudiantes = new Estudiante[1];
                estudiantes[0] = t;
                return;
            }

            Estudiante[] temp = new Estudiante[estudiantes.Length + 1];
            Array.Copy(estudiantes, temp, estudiantes.Length);
            temp[temp.Length - 1] = t;

            estudiantes = temp;
        }

        public Estudiante[] FinAll()
        {
            return estudiantes;
        }

        //public int promedio()
        //{
        //    for(int i = 0; notas.Length; i++)
        //    {

        //    }

        //}
        public int GetLastProductoId()
        {
            return estudiantes == null ? 0 : estudiantes[estudiantes.Length-1].id;
        }
    }
}
