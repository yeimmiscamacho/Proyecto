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
    public partial class FrmRegistroProveedores : Form
    {
        ProveedorService proveedorService;
        public FrmRegistroProveedores()
        {
            InitializeComponent();
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
        }
        public void Recibir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void RecibirProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void RecibirProveedor(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                TxtIdentificacion.Text = proveedor.Identificacion;
                TxtNombre.Text = proveedor.Nombre;
                Txttelefono.Text = proveedor.Telefono;
                Txtcelular.Text = proveedor.Celular;
                TxtDireccion.Text = proveedor.Direccion;
                Txtbarrio.Text = proveedor.Barrio;
            }
        }

        private void BtnConsultarProveedores_Click(object sender, EventArgs e)
        {
            FrmConsutaProveedores frmConsultaProveedores = new FrmConsutaProveedores();
            frmConsultaProveedores.Show();
        }

        private void BtnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Identificacion = TxtIdentificacion.Text;
            proveedor.Nombre = TxtNombre.Text;
            proveedor.Telefono = Txttelefono.Text;
            proveedor.Celular = Txtcelular.Text;
            proveedor.Direccion = TxtDireccion.Text;
            proveedor.Barrio = Txtbarrio.Text;
            string mensaje = proveedorService.GuardarProveedor(proveedor);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            Txttelefono.Text = "";
            Txtcelular.Text = "";
            TxtDireccion.Text = "";
            Txtbarrio.Text = "";
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;
            if (identificacion != "")
            {

                Proveedor proveedor = proveedorService.Buscar(identificacion);
                if (proveedor != null)
                {
                    proveedor.Nombre = TxtNombre.Text;
                    proveedor.Telefono = Txttelefono.Text;
                    proveedor.Celular = Txtcelular.Text;
                    proveedor.Direccion = TxtDireccion.Text;
                    proveedor.Barrio = Txtbarrio.Text;
                   

                    var respuestaa = MessageBox.Show("Esta seguro que desea modificar el proveedor?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = proveedorService.Modificar(proveedor);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }

                }
            }
        }

        private void BtnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;
            if (identificacion != "")
            {

                Proveedor proveedor = proveedorService.Buscar(identificacion);  
                if (proveedor != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar esta persona?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = proveedorService.Eliminar(identificacion);
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
    }
}
