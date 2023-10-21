using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public string CodigoRegistro { get; set; }
        public string CodigoDetalle { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal { get; set; }
        public double TotalIva { get; set; }
        public string IdentificacionCliente { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string CodigoProducto { get; set; }

        public double Total { get; set; }
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }


        public DetalleFactura()
        {

        }
        public DetalleFactura(Producto producto, int cantidad, string codigodetalle, string identificacion, string nombre, string marca, Factura factura)
        {
            CodigoDetalle = codigodetalle;
            Producto = producto;
            Cantidad = cantidad;
            IdentificacionCliente = identificacion;
            Nombre = nombre;
            Marca = marca;
            Factura = factura;
        }


        public void CalcularSubTotal()
        {

            SubTotal = Cantidad * Producto.Costo;

        }
        public void CalcularIva()
        {

            TotalIva = SubTotal * (Producto.Iva / 100);
        }

        public double CalcularTotal()
        {
            CalcularSubTotal();
            CalcularIva();
            return Total = SubTotal + TotalIva;

        }
    }
}
