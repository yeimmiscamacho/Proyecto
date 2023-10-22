using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFacturaService
    {
        private ConnectionManager conexion;
        private DetalleFacturaRepository detalleFacturaRepository;
        List<DetalleFactura> detalles;
        DetalleFactura detalleFactura;
        public DetalleFacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            detalleFacturaRepository = new DetalleFacturaRepository(conexion);
            detalles = new List<DetalleFactura>();
        }
        public string GuardarDetalle(List<DetalleFactura> detalle)
        {
            try
            {
                conexion.Open();
                detalleFacturaRepository.GuardarDetalleFactura(detalle);
                return $" se  han sido guardados satiafactoriamente";
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


        public List<DetalleFactura> Buscar(string codigo)
        {

            try
            {
                conexion.Open();
                List<DetalleFactura> detalles = new List<DetalleFactura>();
                detalles = detalleFacturaRepository.Buscar(codigo);
                return detalles;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }

        public RespuestConsulta Consultar()
        {
            RespuestConsulta respuesta = new RespuestConsulta();
            try
            {
                conexion.Open();
                respuesta.Error = false;
                respuesta.detalles = detalleFacturaRepository.Consultar();
                respuesta.Mensaje = "Datos consultados";

            }
            catch (Exception e)
            {

                respuesta.Error = true;
                respuesta.Mensaje = "error  de datos " + e.Message;


            }
            finally
            {
                conexion.Close();
            }

            return respuesta;

        }
    }
}
public class RespuestConsulta
{
    public string Mensaje { get; set; }
    public List<DetalleFactura> detalles { get; set; }
    public bool Error { get; set; }
}
public class RespuestaBusqueda
{
    public string Mensaje { get; set; }
    //public De detalles { get; set; }
    public bool Error { get; set; }
}

