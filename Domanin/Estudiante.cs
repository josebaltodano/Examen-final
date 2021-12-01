using Domanin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domanin
{
  public   class Estudiante
    {
        public Estudiante()
        {
        }

        public Estudiante(int id, string nombre, string apellidos, string carnet, string municipio, string departamento)
        {
            this.id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Carnet = carnet;
            Municipio = municipio;
            this.departamento = departamento;
        }
        public Clases clases { get; set; }
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Municipio { get; set; }
        public string  departamento { get; set; }

    }
}
