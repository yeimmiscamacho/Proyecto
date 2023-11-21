using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProveedorRepository
    {
        SqlConnection connection;
        List<Proveedor> proveedores;
        public ProveedorRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            proveedores = new List<Proveedor>();
        }
        public void GuardarProveedor(Proveedor proveedor)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into Proveedor (Identificacion,Nombre,Telefono,Celular,Direccion,Barrio)" +
                   "Values(@identificacion,@Nombre,@telefono,@celular,@direccion,@barrio)";
                comando.Parameters.AddWithValue("@identificacion", proveedor.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                comando.Parameters.AddWithValue("@celular", proveedor.Celular);
                comando.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                comando.Parameters.AddWithValue("@barrio", proveedor.Barrio);
                comando.ExecuteNonQuery();
            }
        }

        public Proveedor Buscar(string identificacion)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from Proveedor where Identificacion =@identificacion";
                Comando.Parameters.AddWithValue("@Identificacion", identificacion);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Proveedor proveedor = new Proveedor();
                        proveedor = Mapear(Reader);
                        return proveedor;
                    }
                }
            }
            return null;
        }
        public Proveedor Mapear(SqlDataReader reader)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Identificacion = (string)reader["identificacion"];
            proveedor.Nombre = (string)reader["Nombre"];
            proveedor.Telefono = (string)reader["Telefono"];
            proveedor.Celular = (string)reader["Celular"];
            proveedor.Direccion = (string)reader["Direccion"];
            proveedor.Barrio = (string)reader["Barrio"];

            return proveedor;
        }


        public void Eliminar(string identificacion)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from Proveedor where identificacion = @Identificacion";
                comando.Parameters.AddWithValue("@Identificacion", identificacion);
                comando.ExecuteNonQuery();
            }

        }

        public void Modificar(Proveedor proveedor)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update Proveedor set  nombre=@nombre,telefono=@telefono,celular=@celular,direccion=@direccion,barrio=@barrio where identificacion = @Identificacion";
                comando.Parameters.AddWithValue("@identificacion", proveedor.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                comando.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                comando.Parameters.AddWithValue("@celular", proveedor.Celular);
                comando.Parameters.AddWithValue("@direccion", proveedor.Direccion);
                comando.Parameters.AddWithValue("@barrio", proveedor.Barrio);
                comando.ExecuteNonQuery();
            }
        }
        public List<Proveedor> Consultar()
        {
            proveedores.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from Proveedor";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor = Mapear(Reader);
                    proveedores.Add(proveedor);

                }
            }
            return proveedores;
        }
      
    }
}
