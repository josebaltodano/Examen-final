using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
public   interface IModel<T>
    {
        void create(T t);
    
        T[] FinAll();
    }
}
