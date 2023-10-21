using ENTITY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteRepository
    {

        SqlConnection connection;
        List<Cliente> clientes;
        public ClienteRepository(ConnectionManager Connection)
        {
            connection = Connection.connection;
            clientes = new List<Cliente>();
        }

        public void GuardarCliente(Cliente cliente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = " Insert  Into cliente ( Fecha,Identificacion,Nombre,Apellido,Genero,Telefono,Celular,Direccion,Barrio,Correo)" +
                   "Values(@fecha,@identificacion,@Nombre,@apellido,@genero,@telefono,@celular,@direccion,@barrio,@correo)";
                comando.Parameters.AddWithValue("@fecha", cliente.Fecha.ToShortDateString());
                comando.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@genero", cliente.Genero);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@celular", cliente.Celular);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@barrio", cliente.Barrio);
                comando.Parameters.AddWithValue("@correo", cliente.Email.Address);
                comando.ExecuteNonQuery();
            }
        }
        public Cliente Buscar(string identificacion)
        {
            using (var Comando = connection.CreateCommand())
            {
                Comando.CommandText = "Select * from cliente where Identificacion =@identificacion";
                Comando.Parameters.AddWithValue("@Identificacion", identificacion);
                var Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente = Mapear(Reader);
                        return cliente;
                    }
                }
            }
            return null;
        }
        public Cliente Mapear(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Fecha = Convert.ToDateTime((string)reader["fecha"]);
            cliente.Identificacion = (string)reader["identificacion"];
            cliente.Nombre = (string)reader["nombre"];
            cliente.Apellido = (string)reader["apellido"];
            cliente.Genero = (string)reader["genero"];
            cliente.Telefono = (string)reader["telefono"];
            cliente.Celular = (string)reader["celular"];
            cliente.Direccion = (string)reader["direccion"];
            cliente.Barrio = (string)reader["barrio"];
            cliente.Email = new MailAddress((string)reader["correo"]);

            return cliente;
        }


        public void Eliminar(string identificacion)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Delete from cliente where identificacion = @Identificacion";
                comando.Parameters.AddWithValue("@Identificacion", identificacion);
                comando.ExecuteNonQuery();
            }

        }

        public void Modificar(Cliente cliente)
        {
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Update cliente set  nombre=@nombre,apellido=@apellido,genero=@genero,telefono=@telefono,celular=@celular,direccion=@direccion,barrio=@barrio where identificacion = @Identificacion";
                comando.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@genero", cliente.Genero);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@celular", cliente.Celular);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.Parameters.AddWithValue("@barrio", cliente.Barrio);
                comando.ExecuteNonQuery();
            }
        }
        public List<Cliente> Consultar()
        {
            clientes.Clear();
            using (var comando = connection.CreateCommand())
            {
                comando.CommandText = "Select * from cliente";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = Mapear(Reader);
                    clientes.Add(cliente);

                }
            }
            return clientes;
        }

        public List<Cliente> ListarFecha(DateTime fecha)
        {

            clientes = Consultar();
            return clientes.Where(p => p.Fecha.Equals(fecha)).ToList();
        }

        public List<Cliente> BuscarContiene(string nombre)
        {
            clientes = Consultar();
            return clientes.Where(p => p.Nombre.Contains(nombre)).ToList();
        }

        public int TotalClientes()
        {
            clientes = Consultar();
            return clientes.Count();
        }

    }
}
