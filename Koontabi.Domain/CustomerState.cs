using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koontabi.Domain
{
    
    using System;
    //Koontabi.Domain.CustomerState
    public enum CustomerState : int
    {
        ACTIVO = 1,
        INACTIVO = 2,
        BLOQUEADO = 3,
        ELIMINADO = 4
    }
}
