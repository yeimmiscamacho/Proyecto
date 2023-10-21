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
using System.Net.Mail;

namespace ProyectoMotoZoneGUI
{
    public partial class FrmRegistroClientes : Form, Irecepcion
    {
        ClienteService clienteService;
        public FrmRegistroClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultar = new FrmConsultaClientes(this);
            frmConsultar.Show();
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Fecha = Convert.ToDateTime(TxtFechaCliente.Text);
            cliente.Identificacion = TxtIdentificacion.Text;
            cliente.Nombre = TxtNombre.Text;
            cliente.Apellido = TxtApellido.Text;
           cliente.Genero = CmbGenero.Text;
            cliente.Telefono = TxtTelefono.Text;
            cliente.Celular = TxtCelular.Text;
            cliente.Direccion = TxtDireccion.Text;
            cliente.Barrio = TxtBarrio.Text;
            cliente.Email = new MailAddress(TxtCorreo.Text.Trim());
            string mensaje = clienteService.GuardarCliente(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CmbGenero.Text = "";
            TxtTelefono.Text = "";
            TxtCelular.Text = "";
            TxtDireccion.Text = "";
            TxtBarrio.Text = "";
            TxtCorreo.Text = "";

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;

            if (identificacion != "")
            {

                Cliente cliente = clienteService.Buscar(identificacion);
                if (cliente != null)
                {
                    TxtFechaCliente.Text = cliente.Fecha.ToShortDateString();
                    TxtNombre.Text = cliente.Nombre;
                    TxtApellido.Text = cliente.Apellido;
                   CmbGenero.Text = cliente.Genero;
                    TxtTelefono.Text = cliente.Telefono;
                    TxtCelular.Text = cliente.Celular;
                    TxtDireccion.Text = cliente.Direccion;
                    TxtBarrio.Text = cliente.Barrio;
                    TxtCorreo.Text = cliente.Email.ToString();
                }
                else
                {
                    MessageBox.Show("el cliente no se encuentra en el sistema");

                }
            }
            else
            {
                MessageBox.Show("Por favor digite la identificacion a buscar");

            }
            TxtIdentificacion.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;
            if (identificacion != "")
            {

                Cliente cliente = clienteService.Buscar(identificacion);
                if (cliente != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar esta persona?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = clienteService.Eliminar(identificacion);
                        MessageBox.Show(mensaje, "Mesaje de Eliminacion", MessageBoxButtons.OKCancel);
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show($" la identificacion {identificacion} no esta en el sistema");
                    }

                }
                else
                {
                    MessageBox.Show($" Digite la identificacion por favor ");
                    TxtIdentificacion.Focus();
                }
            }
        }

        public void RecibirProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void RecibirProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;
            if (identificacion != "")
            {

                Cliente cliente = clienteService.Buscar(identificacion);
                if (cliente != null)
                {

                    cliente.Nombre = TxtNombre.Text;
                    cliente.Apellido = TxtApellido.Text;
                    cliente.Genero = CmbGenero.Text;
                    cliente.Telefono = TxtTelefono.Text;
                    cliente.Celular = TxtCelular.Text;
                    cliente.Direccion = TxtDireccion.Text;
                    cliente.Barrio = TxtBarrio.Text;
                    cliente.Email = new MailAddress(TxtCorreo.Text.ToString());
                    var respuestaa = MessageBox.Show("Esta seguro que desea modificar al cliente?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = clienteService.Modificar(cliente);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }

                }
            }
        }
        public void Recibir (Cliente cliente)
        {
            if (cliente != null)
            {
                TxtFechaCliente.Text = cliente.Fecha.ToShortDateString();
                TxtIdentificacion.Text = cliente.Identificacion;
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                CmbGenero.Text = cliente.Genero;
                TxtTelefono.Text = cliente.Telefono;
                TxtCelular.Text = cliente.Celular;
                TxtDireccion.Text = cliente.Direccion;
                TxtBarrio.Text = cliente.Barrio;
                TxtCorreo.Text = cliente.Email.ToString();
            }
        }
    }
    
}

