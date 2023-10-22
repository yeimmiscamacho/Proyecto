using BLL;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void Btncargarproductos_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService(ConfigConnection.connectionString);
            Dtgproductos.DataSource = productoService.Consultar();
        }
    }
}
