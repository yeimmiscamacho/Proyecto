﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace ProyectoMotoZoneGUI
{
 
   public interface IrecepcionFactura
    {

        void RecibirDetalle(Factura factura);
    }
}
