using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace ProyectoMotoZoneGUI
{
    public partial class FrmConsultarProductos : Form
    {
        Irecepcion frmirecepcion;
        ProductoService productoService;
        public FrmConsultarProductos()
        {
            InitializeComponent();
        }
        public FrmConsultarProductos(Irecepcion irepcion)
        {
            InitializeComponent();
            frmirecepcion = irepcion;
        }

        private void BtnCargarProductos_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService(ConfigConnection.connectionString);
            DtgProductos.DataSource = productoService.Consultar();
        }
        private void DtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmirecepcion != null)
            {
                Producto producto = (Producto)DtgProductos.CurrentRow.DataBoundItem;
                frmirecepcion.RecibirProducto(producto);
                this.Hide();

            }
        }
    }
}
