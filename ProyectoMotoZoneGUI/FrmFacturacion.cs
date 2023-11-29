using BLL;
using ENTITY;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoMotoZoneGUI
{
    public partial class FrmFacturacion : Form, Irecepcion
    {
        Irecepcion frmfactura;
        public List<DetalleFactura> detalles;
        private static Producto producto = new Producto();
        private static Factura factura = new Factura();
        ProductoService productoService = new ProductoService(ConfigConnection.connectionString);
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
        DetalleFacturaService detalleService = new DetalleFacturaService(ConfigConnection.connectionString);
        private static FacturaService facturaService = new FacturaService(ConfigConnection.connectionString);
        private static RespuestaConsultar consultar = new RespuestaConsultar();


        public FrmFacturacion()
        {
            InitializeComponent();
        }
        public FrmFacturacion(Irecepcion irecepcion)
        {
            InitializeComponent();
            frmfactura = irecepcion;

        }

        private static IList<Factura> datos = new List<Factura>();

        public int GenerarCodigoFactura()
        {
            consultar = facturaService.Consultar();
            datos = consultar.facturas;
            int codigofactura = 0;
            if (datos != null)
                codigofactura = datos.Count();
            return codigofactura + 1;
        }

        public int GenerarCodigoFacturaDetalle()
        {
            RespuestConsulta respuestaConsulta = detalleService.Consultar();
           
            int codigofactura = 0;
            if (respuestaConsulta.detalles != null)
                codigofactura = respuestaConsulta.detalles.Count();
            return codigofactura;
        }


        private void BtnConsultarProductos_Click(object sender, EventArgs e)
        {
            FrmConsultarProductos frmConsultarProductos = new FrmConsultarProductos(this);
            frmConsultarProductos.Show();
        }

        private void BtnConsultarClientes_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmConsultaClientes = new FrmConsultaClientes(this);
            frmConsultaClientes.Show();
        }

        public void Recibir(Cliente cliente)
        {
            if (cliente != null)
            {
                TxtIdentificacion.Text = cliente.Identificacion;
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                TxtGenero.Text = cliente.Genero;
                TxtTelefono.Text = cliente.Telefono;
                TxtDireccion.Text = cliente.Direccion;
                TxtBarrio.Text = cliente.Barrio;
            }
        }
        public void RecibirProducto(Producto producto)
        {
            if (producto != null)
            {
                TxtcodigoProducto.Text = producto.CodigoProducto;
                TxtMarca.Text = producto.Marca;
                TxtColor.Text = producto.Color;
                TxtIva.Text = producto.Iva.ToString();
                TxtCosto.Text = producto.Costo.ToString();
                TxtProveedor.Text = producto.IdProveedor;
            }
        }
        public void RecibirProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        private void DtgDellates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmfactura != null)
            {
                Cliente cliente = (Cliente)DtgDetalles.CurrentRow.DataBoundItem;
                frmfactura.Recibir(cliente);
                this.Hide();
            }
        }

        private void DtgDellates_CellDoubleClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (frmfactura != null)
            {
                Producto producto = (Producto)DtgDetalles.CurrentRow.DataBoundItem;
                frmfactura.RecibirProducto(producto);
                this.Hide();
            }
        }
        
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(Txtcantidad.Text);
            string codigo = TxtcodigoProducto.Text;
            producto = productoService.Buscar(codigo);
            int a = producto.Cantidad - cantidad;
            if ((producto.Cantidad >= 0) && (a >= 0))
            {
                int cantidadValidar;
                //cantidadValidar = producto.DescontarProducto(producto.Cantidad, cantidad);
                //string m = productoService.Modificarcantidad(producto.CodigoProducto, cantidadValidar);
                //string codigodetalle = Convert.ToString(GenerarCodigo() + 1);
                string identificacion = TxtIdentificacion.Text;
                string nombre = TxtNombre.Text;
                string marca = TxtMarca.Text;
                

                detalles = factura.AgregarDetalles(producto, cantidad, identificacion, nombre, marca, factura);
                Txtsubtotal.Text = Convert.ToString(factura.CalcularSubTotalFactura());
                TxtTotalIva.Text = Convert.ToString(factura.CalcularTotalIva());
                TxtTotalFactura.Text = Convert.ToString(factura.CalcularTotalFactura());
           
                pintarTabla(detalles);
                LimpiarDetalle();
            }
            else
            {
                MessageBox.Show("error", "Verifique la cantidad ingresada");
            }
        }
        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtGenero.Text = "";
            TxtTelefono.Text = "";
            TxtDireccion.Text = "";
            TxtBarrio.Text = "";
            Txtsubtotal.Text = "";
            TxtTotalIva.Text = "";
            TxtTotalFactura.Text = "";
        }
        private void LimpiarDetalle()
        {
            TxtcodigoProducto.Text = "";
            TxtMarca.Text = "";
            TxtColor.Text = "";
            TxtCosto.Text = "";
            TxtIva.Text = "";
            TxtProveedor.Text = "";
            Txtcantidad.Text = "";

        }
        private void pintarTabla(List<DetalleFactura> detalles)
        {
            DtgDetalles.Rows.Clear();
            int n = 0;
            foreach (var item in detalles)
            {

                DtgDetalles.Rows.Add();
                DtgDetalles.Rows[n].Cells[0].Value = item.Producto.CodigoProducto;
                DtgDetalles.Rows[n].Cells[1].Value = item.Producto.Marca;
                DtgDetalles.Rows[n].Cells[2].Value = item.Cantidad;
                DtgDetalles.Rows[n].Cells[3].Value = item.SubTotal;
                DtgDetalles.Rows[n].Cells[4].Value = item.TotalIva;
                DtgDetalles.Rows[n].Cells[5].Value = item.Total;

                n++;
            }

        }
        private void GuardarDetalles(List<DetalleFactura> Detalles)
        {
            //Detalles = detalles;
            //detalleService.GuardarDetalle(Detalles);
            



        }

        private void GuardarFactura()
        {


            FacturaService facturaService = new FacturaService(ConfigConnection.connectionString);
            factura.FechaFactura = DateTime.Now;
            factura.SubTotalFactura = Convert.ToDouble(Txtsubtotal.Text);
            factura.TotalIvaFactura = Convert.ToDouble(TxtTotalIva.Text);
            factura.TotalFactura = Convert.ToDouble(TxtTotalFactura.Text);
            factura.Identificacion = TxtIdentificacion.Text;
            factura.Nombre = TxtNombre.Text;
            factura.CodigoFactura = GenerarCodigoFactura()+ "";
            
            
            string mensaje = facturaService.GuardarFactura(factura);

            for (int i = 0; i < detalles.Count; i++)
            {
                DetalleFactura detalle = detalles[i];
                int cantidadValidar;
                cantidadValidar = producto.DescontarProducto(producto.Cantidad, detalle.Cantidad);
                string m = productoService.Modificarcantidad(producto.CodigoProducto, cantidadValidar);
                detalles[i].CodigoFactura = factura.CodigoFactura;
                detalles[i].Factura = factura;
            }
            detalleService.GuardarDetalle(detalles);
            detalles.Clear();
            MessageBox.Show(mensaje);
           
        }
       
        private void QuitarDetalle(string id)
        {
            DetalleFactura detalle = detalles.Find(d => d.Producto.CodigoProducto == id);
            detalles.Remove(detalle);

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje, titulo, defecto;
            object valor;
            mensaje = "Digite el codigo del producto a eliminar";
            titulo = "Eliminar producto";
            defecto = "codigo ";
            valor = Interaction.InputBox(mensaje, titulo, defecto);

            if ((string)valor != "")
            {
                DetalleFactura detalle = detalles.Where(c => c.Producto.CodigoProducto == (string)valor).FirstOrDefault();
                if (detalle == null)
                {
                    MessageBox.Show("codigo no encontrado en los detalles ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    QuitarDetalle(valor.ToString());
                    pintarTabla(detalles);
                    MessageBox.Show("codigo removido de detalles", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Txtsubtotal.Text = Convert.ToString(factura.CalcularSubTotalFactura());
            TxtTotalIva.Text = Convert.ToString(factura.CalcularTotalIva());
            TxtTotalFactura.Text = Convert.ToString(factura.CalcularTotalFactura());

        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            string codigo = TxtcodigoProducto.Text;

            if (codigo != "")
            {

                Producto producto = productoService.Buscar(codigo);
                if (producto != null)
                {
                    TxtMarca.Text = producto.Marca;
                    TxtCosto.Text = producto.Costo.ToString();
                    TxtColor.Text = producto.Color;
                    TxtIva.Text = producto.Iva.ToString();
                    TxtProveedor.Text = producto.IdProveedor;
                }
                else
                {
                    MessageBox.Show("el producto  no se encuentra en el sistema");

                }
            }
            else
            {
                MessageBox.Show("Por favor digite el codigo a buscar");

            }
            TxtcodigoProducto.Focus();
        }

        private void BtnBuscarclientes_Click(object sender, EventArgs e)
        {
            string identificacion = TxtIdentificacion.Text;

            if (identificacion != "")
            {

                Cliente cliente = clienteService.Buscar(identificacion);
                if (cliente != null)
                {
                    TxtNombre.Text = cliente.Nombre;
                    TxtGenero.Text = cliente.Genero;
                    TxtDireccion.Text = cliente.Direccion;
                    TxtTelefono.Text = cliente.Telefono;
                    TxtApellido.Text = cliente.Apellido;
                    TxtBarrio.Text = cliente.Barrio;
                }
                else
                {
                    MessageBox.Show("el cliente  no se encuentra en el sistema");

                }
            }
            else
            {
                MessageBox.Show("Por favor digite la identificacion a buscar");

            }
            TxtIdentificacion.Focus();
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            //detalleService.GuardarDetalle(factura.EnviarDetalle());
            GuardarFactura();
            DtgDetalles.Rows.Clear();
            Limpiar();

        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtcodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
