using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace ProyectoMotoZoneGUI
{
    public interface Irecepcion
    {
        void Recibir(Cliente cliente);
        void RecibirProducto(Producto producto);

        void RecibirProveedor(Proveedor proveedor);
    }
}
