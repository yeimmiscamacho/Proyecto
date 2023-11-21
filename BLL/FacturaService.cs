using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturaService
    {
        private ConnectionManager conexion;
        private FacturaRepository facturaRepository;
        List<Factura> facturas;
        Factura factura;
        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            facturaRepository = new FacturaRepository(conexion);
        }
        public string GuardarFactura(Factura factura)
        {
            try
            {
                conexion.Open();
                FacturaRepository facturaRepository = new FacturaRepository(conexion);
                facturaRepository.GuardarFactura(factura);
                return $"La factura del cliente  {factura.Nombre} han sido guardados satiafactoriamente";
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

        public RespuestaConsultar Consultar()
        {
            RespuestaConsultar consultar = new RespuestaConsultar();
            try
            {

                conexion.Open();
                consultar.Error = false;
                consultar.facturas = facturaRepository.Consultar();
                if (consultar.facturas.Count == 0)
                {
                    consultar.mensaje = " No hay datos registrados";

                }
                else
                {
                    consultar.mensaje = "Datos consultados correctamente";
                }
                return consultar;
            }
            catch (Exception e)
            {
                consultar.Error = true;
                consultar.mensaje = "Error de Archivo" + e.Message;
                return consultar;
            }
            finally
            {
                conexion.Close();
            }

        }

        public List<Factura> ListarFecha(DateTime fecha)
        {
            try
            {
                List<Factura> facturas;
                conexion.Open();
                facturas = facturaRepository.ListarFecha(fecha);

                return facturas;


            }
            catch (Exception e)
            {
                string mensaje = $"error de datos{e.Message.ToString()}";


            }
            finally
            {
                conexion.Close();
            }

            return facturas;
        }


        public RespuestaBuscarContiene BuscarContiene(string nombre)
        {
            RespuestaBuscarContiene respuestaBuscar = new RespuestaBuscarContiene();
            try
            {
                conexion.Open();
                respuestaBuscar.Error = false;
                respuestaBuscar.facturas = facturaRepository.BuscarContiene(nombre);
                respuestaBuscar.Mensaje = "Datos encontrados ";
            }
            catch (Exception e)
            {

                respuestaBuscar.Error = true;
                respuestaBuscar.Mensaje = "error de datos " + e.Message;
            }
            finally
            {
                conexion.Close();
            }

            return respuestaBuscar;
        }



        public Factura Buscar(string identificacion)
        {

            try
            {
                conexion.Open();
                factura = new Factura();
                factura = facturaRepository.Buscar(identificacion);

                return factura;
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

        
    }
}
public class RespuestaConsultar
{
    public string mensaje { get; set; }
    public IList<Factura> facturas { get; set; }
    public bool Error { get; set; }
}

public class RespuestaTotalfactura
{
    public string Mensaje { get; set; }
    public int Total { get; set; }
    public bool Error { get; set; }

}

public class RespuestaSumaTotal
{
    public string Mensaje { get; set; }
    public bool Error { get; set; }
    public double Total { get; set; }
}

public class RespuestaBuscarContiene
{
    public string Mensaje { get; set; }
    public bool Error { get; set; }
    public IList<Factura> facturas { get; set; }
}
  
