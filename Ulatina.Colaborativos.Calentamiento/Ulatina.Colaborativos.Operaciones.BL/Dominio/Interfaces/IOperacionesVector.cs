﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ulatina.Colaborativos.Operaciones.BL.Dominio.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperacionesVector" in both code and config file together.
    [ServiceContract]
    public interface IOperacionesVector
    {
        [OperationContract]
        void DoWork();
    }
}