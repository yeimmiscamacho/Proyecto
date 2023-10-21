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
    public partial class FrmConsutaProveedores : Form
    {
        Irecepcion frmirepcion;
        ProveedorService proveedorService;
        IList<Proveedor> proveedores = new List<Proveedor>();
        public FrmConsutaProveedores()
        {
            InitializeComponent();
            proveedorService = new ProveedorService(ConfigConnection.connectionString);

        }
        public FrmConsutaProveedores(Irecepcion irepcion)
        {
            InitializeComponent();
            frmirepcion = irepcion;
        }

        private void BtnCargarProveedores_Click(object sender, EventArgs e)
        {
            ProveedorService proveedorService = new ProveedorService(ConfigConnection.connectionString);
            DtgProveedores.DataSource = proveedorService.Consultar();
        }
        private void DtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (frmirepcion != null)
            {
                Proveedor proveedor = (Proveedor)DtgProveedores.CurrentRow.DataBoundItem;
                frmirepcion.RecibirProveedor(proveedor);
                this.Hide();

            }
        }
    }
}
