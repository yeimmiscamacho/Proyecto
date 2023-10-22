using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleFacturaRepository
    {
        SqlConnection connection;
        List<DetalleFactura> detalleFacturas;

        public DetalleFacturaRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            detalleFacturas = new List<DetalleFactura>();
        }

        public void GuardarDetalleFactura(List<DetalleFactura> detalle)
        {
            foreach (var item in detalle)
            {
                using (var comando = connection.CreateCommand())
                {
                    comando.CommandText = " Insert  Into DetalleFactura (CodigoDetalle,CodigoProducto,Marca,Cantidad,Subtotal,Total,TotalIva)" +
                       "Values(@codigodetalle,@codigoproducto,@Marca,@cantidad,@subtotal,@total,@totaliva)";
                    comando.Parameters.AddWithValue("@codigodetalle", item.CodigoDetalle);
                    comando.Parameters.AddWithValue("@codigoproducto", item.Producto.CodigoProducto);
                    comando.Parameters.AddWithValue("@Marca", item.Producto.Marca);
                    comando.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    comando.Parameters.AddWithValue("@subtotal", item.SubTotal);
                    comando.Parameters.AddWithValue("@totaliva", item.TotalIva);
                    comando.Parameters.AddWithValue("@total", item.Total);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<DetalleFactura> Consultar()
        {
            detalleFacturas.Clear();
            using (var comando = connection.CreateCommand())
            {
                var Reader = comando.ExecuteReader();
                comando.CommandText = "Select * from DetalleFactura";
                Reader = comando.ExecuteReader();

                while (Reader.Read())
                {
                    DetalleFactura detalle = new DetalleFactura();
                    detalle = Mapear(Reader);
                    detalleFacturas.Add(detalle);
                }
            }
            return detalleFacturas;
        }

        public DetalleFactura Mapear(SqlDataReader reader)
        {

            DetalleFactura detalleFactura = new DetalleFactura();
            detalleFactura.CodigoDetalle = (string)reader["codigodetalle"];
            detalleFactura.CodigoProducto = (string)reader["codigoproducto"];
            detalleFactura.Marca = (string)reader["Marca"];
            detalleFactura.Cantidad = (int)reader["cantidad"];
            detalleFactura.SubTotal = (double)reader["subtotal"];
            detalleFactura.TotalIva = (double)reader["totaliva"];
            detalleFactura.Total = (double)reader["total"];
            detalleFactura.Marca = (string)reader["Marca"];

            return detalleFactura;
        }

        public List<DetalleFactura> Buscar(string codigo)
        {
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from DETALLEFACTURA where CODIGODETALLE =@codigodetalle";
                Comando.Parameters.AddWithValue("@codigodetalle", codigo);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        DetalleFactura detalleFactura = new DetalleFactura();
                        detalleFactura = Mapear(Reader);
                        detalles.Add(detalleFactura);


                    }
                }
                return detalles;
            }
            return null;
        }
    }
}

