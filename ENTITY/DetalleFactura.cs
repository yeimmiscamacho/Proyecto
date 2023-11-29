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
        public int CodigoDetalle { get; set; }
        public string CodigoFactura { get; set; }
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
        public DetalleFactura(Producto producto, int cantidad, int codigodetalle, string codigofactura, string identificacion, string nombre, string marca, Factura factura)
        {
            CodigoDetalle = codigodetalle;
            Producto = producto;
            CodigoFactura = codigofactura;
            Cantidad = cantidad;
            IdentificacionCliente = identificacion;
            Nombre = nombre;
            Marca = marca;
            Factura = factura;
        }


        public DetalleFactura(Producto producto, int cantidad, string identificacion, string nombre, string marca, Factura factura)
        {
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
