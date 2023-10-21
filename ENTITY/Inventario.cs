using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   public class Inventario
    {
        public decimal TotalVentas { get; set; }
        public DateTime FechaInventario { get; set; }
        public int CodigoInventario { get; set; }
        public List<Factura> facturas { get; set; }

        public decimal CalcularTotalVentas()
        {
            foreach (var item in facturas)
            {
                TotalVentas = Convert.ToUInt64(facturas.Sum(p => p.TotalFactura));
            }
            return TotalVentas;
        }
    }
}
