using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data.SqlClient; 

namespace BLL
{
    public class ProveedorService
    {

        private ConnectionManager connection;
        ProveedorRepository proveedorRepository;
        List<Proveedor> proveedores;
        Proveedor proveedor;
        public ProveedorService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            proveedorRepository = new ProveedorRepository(connection);
        }


        public string GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                connection.Open();
                proveedorRepository.GuardarProveedor(proveedor);
                return $"Los datos de la persona {proveedor.Nombre} han sido guardados satiafactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de base de datos: {e.Message}";
            }
            finally
            {
                connection.Close();
            }


        }

        public List<Proveedor> Consultar()
        {
            try
            {
                connection.Open();
                proveedores = new List<Proveedor>();
                proveedores = proveedorRepository.Consultar();
                connection.Close();
                return proveedores;

            }
            catch (Exception e)
            {

                string Mensaje = $"error de datos" + e.Message;

            }
            return null;
        }


        public Proveedor Buscar(string identificacion)
        {

            try
            {
                connection.Open();
                proveedor = new Proveedor();
                proveedor = proveedorRepository.Buscar(identificacion);
                connection.Close();
                return proveedor;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message;
            }
            return null;
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                connection.Open();
                proveedorRepository.Eliminar(identificacion);
                return $"Los datos del cliente han sido eliminados satiafactoriamente";


            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally
            {
                connection.Close();
            }
        }
        public string Modificar(Proveedor proveedor)

        {
            try
            {
                connection.Open();
                proveedorRepository.Modificar(proveedor);
                connection.Close();

                return "Registro Modificado correctamente";
            }
            catch (Exception e)
            {

                return $"Error de base de datos {e.Message.ToString()}";
            }
            finally
            {
                connection.Close();
            }

        }
    }
}

 