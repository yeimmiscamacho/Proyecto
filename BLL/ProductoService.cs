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
    public class ProductoService
    {
        private ConnectionManager connection;

        ProductoRepository productoRepository;
        List<Producto> productos;
        Producto producto;
        public ProductoService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            productoRepository = new ProductoRepository(connection);
        }
        public string GuardarProducto(Producto producto)
        {
            try
            {
                connection.Open();
                productoRepository.GuardarProducto(producto);
                return $"Los datos del producto {producto.CodigoProducto} han sido guardados satiafactoriamente";
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


        public string Modificarcantidad(string id, int cantidad)
        {
            try
            {

                connection.Open();
                productoRepository.Modificarcantidad(id, cantidad);


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


        public List<Producto> Consultar()
        {
            try
            {
                connection.Open();
                productos = new List<Producto>();
                productos = productoRepository.Consultar();

                return productos;

            }
            catch (Exception e)
            {

                string Mensaje = $"error de datos" + e.Message.ToString();

            }
            finally
            {
                connection.Close();
            }
            return null;
        }


        public Producto Buscar(string codigo)
        {

            try
            {
                connection.Open();
                producto = new Producto();
                producto = productoRepository.Buscar(codigo);

                return producto;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
        public string Eliminar(string codigo)
        {
            try
            {
                connection.Open();
                productoRepository.Eliminar(codigo);
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
        public string Modificar(Producto producto)

        {
            try
            {
                connection.Open();
                productoRepository.Modificar(producto);


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
    public class RespuestaTotal1
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public int Total { get; set; }
    }

}