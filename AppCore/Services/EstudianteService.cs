using AppCore.Interface;
using Domanin;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class EstudianteService : Iestudianteservices
    {
        private Estudiante[] estudiante;
        public void create(Estudiante t)
        {
            throw new NotImplementedException();
        }

        public Estudiante[] FinAll()
        {
            throw new NotImplementedException();
        }

        public int GetLastProductoId()
        {
            return estudiante== null ? 0 : estudiante[estudiante.Length - 1].id;
        }
    }
}
