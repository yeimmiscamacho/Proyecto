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
using ENTITY;
using BLL;
namespace ProyectoMotoZoneGUI
{
    public partial class FrmConsultaClientes : Form
    {
        Irecepcion frmirepcion;
        List<Cliente> clientes;
        private readonly ClienteService clienteService;


        public FrmConsultaClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
            clientes = new List<Cliente>();


        }
        public FrmConsultaClientes(Irecepcion irepcion)
        {
            InitializeComponent();
            frmirepcion = irepcion;

        }



        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            FrmRegistroClientes frmRegistroClientes = new FrmRegistroClientes();
            frmRegistroClientes.Show();
        }



        private void BtnFiltarClientes_Click(object sender, EventArgs e)
        {
            string nombre = TxtFiltarClientes.Text;
            if (TxtFiltarClientes.Text != "")
            {
                ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
                DtgClientes.DataSource = clienteService.BuscarContiene(nombre);

            }
        }

        private void BtnCargarClientes_Click(object sender, EventArgs e)
        {

            ClienteService clienteServi = new ClienteService(ConfigConnection.connectionString);
            DtgClientes.DataSource = clienteServi.Consultar();
            RespuestaTotal total = new RespuestaTotal();
            total = clienteServi.TotalClientes();
            TxtTotalClientes.Text = total.Total.ToString();



        }

        private void BtnFiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(TxtFechaClientes.Text);
            if (TxtFechaClientes.Text != "")

            {
                ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
                DtgClientes.DataSource = clienteService.ListarFecha(fecha);

            }
        }



        private void DtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmirepcion != null)
            {
                Cliente cliente = (Cliente)DtgClientes.CurrentRow.DataBoundItem;
                frmirepcion.Recibir(cliente);
                this.Hide();

            }
        }
    }
}

