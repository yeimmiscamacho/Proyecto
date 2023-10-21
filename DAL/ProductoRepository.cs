using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class ProductoRepository
    {
        SqlConnection connection;
        List<Producto> productos;
        public ProductoRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            productos = new List<Producto>();
        }

        public void GuardarProducto(Producto producto)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into Producto ( Fecha,Codigoproducto,Marca,Color,Cantidad,Costo,Iva,Idproveedor)" +
                   "Values(@fecha,@codigoproducto,@marca,@color,@cantidad,@costo,@iva,@idproveedor)";
                comando.Parameters.AddWithValue("@fecha", producto.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@codigoproducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@marca", producto.Marca);
                comando.Parameters.AddWithValue("@color", producto.Color);
                comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                comando.Parameters.AddWithValue("@costo", producto.Costo);
                comando.Parameters.AddWithValue("@iva", producto.Iva);
                comando.Parameters.AddWithValue("@idproveedor", producto.IdProveedor);

                comando.ExecuteNonQuery();
            }
        }

        public Producto Buscar(string codigo)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Producto where Codigoproducto =@codigoproducto";
                Comando.Parameters.AddWithValue("@codigoproducto", codigo);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Producto producto = new Producto();
                        producto = Mapear(Reader);
                        return producto;
                    }
                }
            }
            return null;
        }
        public Producto Mapear(SqlDataReader reader)
        {
            Producto producto = new Producto();
            producto.Fecha = Convert.ToDateTime((string)reader["fecha"]);
            producto.CodigoProducto = (string)reader["Codigoproducto"];
            producto.Marca = (string)reader["Marca"];
            producto.Color = (string)reader["Color"];
            producto.Cantidad = (int)reader["Cantidad"];
            producto.Costo = (double)reader["Costo"];
            producto.Iva = (double)reader["Iva"];
            producto.IdProveedor = (string)reader["Idproveedor"];


            return producto;
        }

        public void Eliminar(string Codigo)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from Producto where Codigoproducto = @codigoproducto";
                comando.Parameters.AddWithValue("@codigoproducto", Codigo);
                comando.ExecuteNonQuery();
            }

        }

        public void Modificar(Producto producto)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update Producto set  fecha=@fecha,codigoproducto=@codigoproducto,marca=@marca,color=@color,cantidad=@cantidad,costo=@costo,iva=@iva,idproveedor=@idproveedor,estado=@estado where codigoproducto = @codigoproducto ";
                comando.Parameters.AddWithValue("@fecha", producto.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@codigoproducto", producto.CodigoProducto);
                comando.Parameters.AddWithValue("@marca", producto.Marca);
                comando.Parameters.AddWithValue("@color", producto.Color);
                comando.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                comando.Parameters.AddWithValue("@costo", producto.Costo);
                comando.Parameters.AddWithValue("@iva", producto.Iva);
                comando.Parameters.AddWithValue("@idproveedor", producto.IdProveedor);
                comando.ExecuteNonQuery();
            }
        }

        public List<Producto> Consultar()
        {
            productos.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from Producto";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Producto producto = new Producto();
                    producto = Mapear(Reader);
                    productos.Add(producto);

                }
            }
            return productos;
        }

        public void Modificarcantidad(string id, int cantidad)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update Producto set  cantidad=@cantidad where codigoproducto = @codigoproducto ";
                comando.Parameters.AddWithValue("@codigoproducto", id);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.ExecuteNonQuery();
            }
        }

    }
}
