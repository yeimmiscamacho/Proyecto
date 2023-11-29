using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMotoZoneGUI
{
    public partial class FrmInventario : Form
    {
        List<Factura> fechas;
        public FrmInventario()
        {
            InitializeComponent();

        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            FacturaService facturaService = new FacturaService(ConfigConnection.connectionString);
            RespuestaConsultar respuesta = new RespuestaConsultar();
            respuesta = facturaService.Consultar();
            pintarfacturas(respuesta.facturas);
        }
        private void pintarfacturas(IList<Factura> facturas)
        {
            DtgFacturas.Rows.Clear();
            int n = 0;
            if (facturas != null)
            {
                foreach (var item in facturas)
                {

                    DtgFacturas.Rows.Add();

                    DtgFacturas.Rows[n].Cells[0].Value = item.CodigoFactura;
                    DtgFacturas.Rows[n].Cells[1].Value = item.FechaFactura;
                    DtgFacturas.Rows[n].Cells[2].Value = item.Identificacion;
                    DtgFacturas.Rows[n].Cells[3].Value = item.Nombre;
                    DtgFacturas.Rows[n].Cells[4].Value = item.SubTotalFactura;
                    DtgFacturas.Rows[n].Cells[5].Value = item.TotalIvaFactura;
                    DtgFacturas.Rows[n].Cells[6].Value = item.TotalFactura;

                    n++;
                }
            }
            else
            {
                MessageBox.Show("no hay facturas para mostrar");
            }



        }

        private void BtnfiltrarFactura_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombrefiltrar.Text;
            if (nombre != "")
            {
                FacturaService facturaService = new FacturaService(ConfigConnection.connectionString);
                RespuestaBuscarContiene respuestaBuscar = new RespuestaBuscarContiene();
                respuestaBuscar = facturaService.BuscarContiene(nombre);
                pintarfacturas(respuestaBuscar.facturas);

            }
        }
         private void pintarDetalles( List<DetalleFactura> detalles)
        {
            DtgDetalles.Rows.Clear();
            int n = 0;
            foreach (var item in detalles)
            {

                DtgDetalles.Rows.Add();
                DtgDetalles.Rows[n].Cells[0].Value = item.CodigoDetalle;
                DtgDetalles.Rows[n].Cells[1].Value = item.CodigoFactura;
                DtgDetalles.Rows[n].Cells[2].Value = item.CodigoProducto;
                DtgDetalles.Rows[n].Cells[3].Value = item.Marca;
                DtgDetalles.Rows[n].Cells[4].Value = item.Cantidad;
                DtgDetalles.Rows[n].Cells[5].Value = item.SubTotal;
                DtgDetalles.Rows[n].Cells[6].Value = item.TotalIva;
                DtgDetalles.Rows[n].Cells[7].Value = item.Total;


                n++;
            }

         }
        private void BtnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(TxtFechainventario.Text);
            if (TxtFechainventario.Text != "")

            {
                FacturaService facturaService = new FacturaService(ConfigConnection.connectionString);
                fechas = facturaService.ListarFecha(fecha);
                pintarfacturas(fechas);


            }
        }
        private void DtgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleFacturaService detalleFacturaService = new DetalleFacturaService(ConfigConnection.connectionString);
            string codigofactura = DtgFacturas.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            detalles = detalleFacturaService.Buscar(codigofactura);
            pintarDetalles(detalles);
        }

        private void TxtNombrefiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
