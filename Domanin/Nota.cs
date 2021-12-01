using System;
using System.Collections.Generic;
using System.Text;

namespace Domanin
{
  public   class Nota
    {
        public Estudiante estudiante;

        public Nota(Estudiante estudiante, int sistematico, int primerparcial, int segundoParcial, int notafinal)
        {
            this.estudiante = estudiante;
            Sistematico = sistematico;
            Primerparcial = primerparcial;
            SegundoParcial = segundoParcial;
            Notafinal = notafinal;
        }

        public int Sistematico { get; set; }
        public int Primerparcial { get; set; }
        public int SegundoParcial { get; set; }
        public int Notafinal { get; set; }

    }
}
