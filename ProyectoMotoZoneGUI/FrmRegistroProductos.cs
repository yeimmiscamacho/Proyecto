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
    public partial class FrmRegistroProductos : Form, Irecepcion
    {
        ProductoService productoService;
        public FrmRegistroProductos()
        {
            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.connectionString);
        }

        private void BtnConsultarProductos_Click(object sender, EventArgs e)
        {
            FrmConsultarProductos frmConsultar = new FrmConsultarProductos(this);
            frmConsultar.Show();
        }

        private void BtnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmConsutaProveedores frmConsultaProveedores = new FrmConsutaProveedores(this);
            frmConsultaProveedores.Show();
        }

        private void BtnGuardarProdcuto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Fecha = Convert.ToDateTime(TxtFechaProducto.Text);
            producto.CodigoProducto = TxtCodigoProducto.Text;
            producto.Marca = TxtMarca.Text;
            producto.Color = TxtColor.Text;
            producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            producto.Costo = Convert.ToDouble(TxtCosto.Text);
            producto.Iva = Convert.ToDouble(TxtIva.Text);
            producto.IdProveedor = TxtCodigoProveedor.Text;

            string mensaje = productoService.GuardarProducto(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }
        public void Recibir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void RecibirProducto (Producto producto)
        {
            if (producto != null)
            {
                TxtFechaProducto.Text = producto.Fecha.ToShortDateString();
                TxtCodigoProducto.Text = producto.CodigoProducto;
                TxtMarca.Text = producto.Marca;
                TxtColor.Text = producto.Color;
                TxtCantidad.Text = producto.Cantidad.ToString();
                TxtCosto.Text = producto.Costo.ToString();
                TxtIva.Text = producto.Iva.ToString();
                TxtCodigoProveedor.Text = producto.IdProveedor;

            }
        }
        public void RecibirProveedor(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                TxtCodigoProveedor.Text = proveedor.Identificacion;
            }
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigoProducto.Text;
            if (codigo != "")
            {

                Producto producto = productoService.Buscar(codigo);
                if (producto != null)
                {

                    producto.Fecha = Convert.ToDateTime(TxtFechaProducto.Text);
                    producto.Marca = TxtMarca.Text;
                    producto.Color = TxtColor.Text;
                    producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                    producto.Costo = Convert.ToDouble(TxtCosto.Text);
                    producto.Iva = Convert.ToDouble(TxtIva.Text);
                    producto.IdProveedor = TxtCodigoProveedor.Text;

                    var respuestaa = MessageBox.Show("Esta seguro que desea modificar al cliente?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = productoService.Modificar(producto);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }

                }
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigoProducto.Text;
            if (codigo != "")
            {

                Producto producto = productoService.Buscar(codigo);
                if (producto != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar esta persona?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = productoService.Eliminar(codigo);
                        MessageBox.Show(mensaje, "Mesaje de Eliminacion", MessageBoxButtons.OKCancel);
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show($" el codigo  {codigo} no esta en el sistema");
                    }

                }
                else
                {
                    MessageBox.Show($" Digite  el codigo por favor ");
                    TxtCodigoProducto.Focus();
                }
            }
        }
        public void Limpiar()
        {
            TxtCodigoProducto.Text = "";
            TxtMarca.Text = "";
            TxtColor.Text = "";
            TxtCantidad.Text = "";
            TxtCosto.Text = "";
            TxtIva.Text = "";
            TxtCodigoProveedor.Text = "";

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodigoProducto.Text;

            if (codigo != "")
            {

                Producto producto = productoService.Buscar(codigo);
                if (producto != null)
                {
                    TxtFechaProducto.Text = producto.Fecha.ToShortDateString();
                    TxtMarca.Text = producto.Marca;
                    TxtColor.Text = producto.Color;
                    TxtCantidad.Text = producto.Cantidad.ToString();
                    TxtCosto.Text = producto.Costo.ToString();
                    TxtIva.Text = producto.Iva.ToString();
                    TxtCodigoProveedor.Text = producto.IdProveedor;

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
            TxtCodigoProducto.Focus();
        }
    }
    

}


