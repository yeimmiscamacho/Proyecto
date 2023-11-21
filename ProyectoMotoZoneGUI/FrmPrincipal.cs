using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMotoZoneGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                formulario.BringToFront();
            }

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroClientes>();
        }

        

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void PanelTtulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmInicio>();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroProductos>();
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegistroProveedores>();
        }

       
        private void FechayHora_tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

       
        
        private void BtnFacturar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmFacturacion>();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReporte>();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            
                AbrirFormulario<FrmInventario>();
            
        }

        private void LblHora_Click(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
