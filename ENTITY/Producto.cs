using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public DateTime Fecha { get; set; }
        public double Iva { get; set; }
        public string CodigoProducto { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public string IdProveedor { get; set; }

        public List<Proveedor> proveedores { get; set; }

        public Proveedor AgregarProveedores(string identificacion, string nombre)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Identificacion = identificacion;
            proveedor.Nombre = nombre;
            proveedores.Add(proveedor);
            return proveedor;
        }

        public int DescontarProducto(int cantidadexistente, int cantidadllevar)
        {
            return Cantidad = cantidadexistente - cantidadllevar;

        }
    }
}
