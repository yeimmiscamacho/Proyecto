using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   public class Factura
    {
        public int CodigoFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public double TotalFactura { get; set; }
        public Cliente Cliente { get; set; }
        public double SubTotalFactura { get; set; }
        public double TotalIvaFactura { get; set; }

        public static List<DetalleFactura> Detalles = new List<DetalleFactura>();





        public List<DetalleFactura> AgregarDetalles(Producto producto, int cantidad, string codigodetalle, string identificacion, string nombre, string marca, Factura factura)
        {
            DetalleFactura detalleFactura = new DetalleFactura(producto, cantidad, codigodetalle, identificacion, nombre, marca, factura);
            detalleFactura.Producto.CodigoProducto = producto.CodigoProducto;
            detalleFactura.Cantidad = cantidad;
            detalleFactura.IdentificacionCliente = identificacion;
            detalleFactura.Nombre = nombre;
            detalleFactura.Marca = marca;
            detalleFactura.Factura.SubTotalFactura = factura.SubTotalFactura;
            detalleFactura.Factura.TotalIvaFactura = factura.TotalIvaFactura;
            detalleFactura.Factura.TotalIvaFactura = factura.TotalFactura;
            detalleFactura.CalcularTotal();
            Detalles.Add(detalleFactura);
            return Detalles;

        }
        public List<DetalleFactura> EnviarDetalle()
        {
            return Detalles;
        }
        public double CalcularSubTotalFactura()
        {
            return SubTotalFactura = (Detalles.Sum(p => p.SubTotal));
        }
        public double CalcularTotalIva()
        {

            return TotalIvaFactura = (Detalles.Sum(p => p.TotalIva));

        }
        public double CalcularTotalFactura()
        {

            return TotalFactura = SubTotalFactura + TotalIvaFactura;

        }
    }
}
