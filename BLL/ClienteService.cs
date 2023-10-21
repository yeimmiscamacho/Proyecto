using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Net.Mail;




namespace BLL
{
    public class ClienteService
    {
        private ConnectionManager conexion;
        private ClienteRepository clienteRepository;
        List<Cliente> clientes;
        Cliente cliente;
      
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);

            clienteRepository = new ClienteRepository(conexion);
        }

        public string GuardarCliente(Cliente cliente)
        {
            try
            {
                conexion.Open();
               
                clienteRepository.GuardarCliente(cliente);

                return $"Los datos del cliente  {cliente.Nombre} han sido guardados satiafactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de base de datos: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }

        }
            //public string GuardarCliente(Cliente cliente)
            //{
            //    try
            //    {
            //        conexion.Open();
            //        clienteRepository.GuardarCliente(cliente);


            //        return $"Los datos del cliente  {cliente.Nombre} han sido guardados satiafactoriamente";
            //    }
            //    catch (Exception e)
            //    {
            //        return $"Error de base de datos: {e.Message}";
            //    }
            //    finally
            //    {
            //        conexion.Close();
            //    }


            //}
            public List<Cliente> Consultar()
        {
            try
            {
                clientes = new List<Cliente>();
                conexion.Open();
                clientes = clienteRepository.Consultar();
                return clientes;

            }
            catch (Exception e)
            {

                string Mensaje = $"error de datos" + e.Message.ToString();


            }
            finally
            {
                conexion.Close();
            }
            return null;
        }


        public Cliente Buscar(string identificacion)
        {

            try
            {
                conexion.Open();
                cliente = new Cliente();
                cliente = clienteRepository.Buscar(identificacion);
                conexion.Close();
                return cliente;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            return null;
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                clienteRepository.Eliminar(identificacion);
                return $"Los datos del cliente han sido eliminados satiafactoriamente";


            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }
        public string Modificar(Cliente cliente)

        {
            try
            {
                conexion.Open();
                clienteRepository.Modificar(cliente);


                return "Registro Modificado correctamente";
            }
            catch (Exception e)
            {

                return $"Error de base de datos {e.Message.ToString()}";
            }
            finally
            {
                conexion.Close();
            }

        }
        public List<Cliente> ListarFecha(DateTime fecha)
        {
            try
            {
                List<Cliente> clientes;
                conexion.Open();
                clientes = clienteRepository.ListarFecha(fecha);

                return clientes;


            }
            catch (Exception e)
            {
                string mensaje = $"error de datos{e.Message.ToString()}";


            }
            finally
            {
                conexion.Close();
            }

            return clientes;
        }

        public List<Cliente> BuscarContiene(string nombre)
        {
            try
            {
                conexion.Open();
                List<Cliente> clientes;
                clientes = clienteRepository.BuscarContiene(nombre);

                return clientes;
            }
            catch (Exception e)
            {

                string mensaje = $"error de datos{e.Message.ToString()}";
            }
            finally
            {
                conexion.Close();
            }
            return clientes;

        }

        public RespuestaTotal TotalClientes()
        {
            RespuestaTotal respuesta = new RespuestaTotal();
            try
            {
                conexion.Open();
                respuesta.Error = false;
                respuesta.Total = clienteRepository.TotalClientes();

                if (respuesta.Total == 0)
                {
                    respuesta.Mensaje = "No hay datos, no se puede totalizar";
                }
                conexion.Close();
            }
            catch (Exception e)
            {

                respuesta.Error = true;
                respuesta.Mensaje = "total facturas encontradas correctamente" + e.Message;

            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }


    }

    public class RespuestaTotal
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public double Total { get; set; }
    }

}

