using Domanin;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interface
{
  public  interface Iestudianteservices: IModel<Estudiante>
    {
        int GetLastProductoId();
    }
}
