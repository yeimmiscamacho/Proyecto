using ENTITY;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturaRepository
    {
        SqlConnection connection;
        IList<Factura> facturas;
        public FacturaRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            facturas = new List<Factura>();
        }
        public void GuardarFactura(Factura factura)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into Factura (CODIGOFACTURA, FECHAFACTURA,IDENTIFICACION,NOMBREFACTURA,SUBTOTALFACTURA,TOTALIVAFACTURA,TOTALFACTURA)" +
                   "Values(@codigofactura,@fechafactura,@identificacion,@nombrefactura,@subtotalfactura,@totalivafactura,@totalfactura)";
                comando.Parameters.AddWithValue("codigofactura", factura.CodigoFactura.ToString());
                comando.Parameters.AddWithValue("fechafactura", factura.FechaFactura);
                comando.Parameters.AddWithValue("@identificacion", factura.Identificacion);
                comando.Parameters.AddWithValue("@nombrefactura", factura.Nombre);
                comando.Parameters.AddWithValue("@subtotalfactura", factura.SubTotalFactura);
                comando.Parameters.AddWithValue("@totalivafactura", factura.TotalIvaFactura);
                comando.Parameters.AddWithValue("@totalfactura", factura.TotalFactura);
                comando.ExecuteNonQuery();
            }
        }

        public Factura Buscar(string identificacion)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Factura where Identificacion =@identificacion";
                Comando.Parameters.AddWithValue("@Identificacion", identificacion);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Factura factura = new Factura();
                        factura = Mapear(Reader);
                        return factura;
                    }
                }
            }
            return null;

        }

        public Factura Mapear(SqlDataReader reader)
        {
            Factura factura = new Factura();
            factura.CodigoFactura = (string)reader["codigofactura"];
            factura.Identificacion = (string)reader["identificacion"];
            factura.Nombre = (string)reader["nombrefactura"];
            factura.SubTotalFactura = (double)reader["subtotalfactura"];
            factura.TotalIvaFactura = (double)reader["totalivafactura"];
            factura.TotalFactura = (double)reader["totalfactura"];

            string fechaString = (string)reader["fechafactura"];
            string formato = "MMM dd yyyy h:mmtt";

            Console.WriteLine("Cadena de fecha: " + fechaString);
            try
            {
                DateTime fecha = DateTime.ParseExact(fechaString, formato, CultureInfo.InvariantCulture);
                factura.FechaFactura = fecha;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error al analizar la fecha: " + ex.Message);
            }

            return factura;
        }

        public IList<Factura> Consultar()
        {
            facturas.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM Factura";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {

                    Factura factura = Mapear(Reader);
                    facturas.Add(factura);

                }
            }
            return facturas;
        }

        public IList<Factura> BuscarContiene(string nombre)
        {
            facturas = Consultar();
            return facturas.Where(p => p.Nombre.Contains(nombre)).ToList();
        }

        public List<Factura> ListarFecha(DateTime fecha)
        {

            facturas = Consultar();
            return facturas.Where(p => p.FechaFactura.Equals(fecha)).ToList();
        }

    }
}
    

