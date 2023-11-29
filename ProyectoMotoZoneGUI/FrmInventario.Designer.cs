namespace ProyectoMotoZoneGUI
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFiltrarFecha = new System.Windows.Forms.Button();
            this.TxtFechainventario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.DtgFacturas = new System.Windows.Forms.DataGridView();
            this.CodigoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnfiltrarFactura = new System.Windows.Forms.Button();
            this.TxtNombrefiltrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFiltrarFecha);
            this.groupBox1.Controls.Add(this.TxtFechainventario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtgDetalles);
            this.groupBox1.Controls.Add(this.BtnCargar);
            this.groupBox1.Controls.Add(this.DtgFacturas);
            this.groupBox1.Controls.Add(this.BtnfiltrarFactura);
            this.groupBox1.Controls.Add(this.TxtNombrefiltrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVENTARIO";
            // 
            // BtnFiltrarFecha
            // 
            this.BtnFiltrarFecha.Location = new System.Drawing.Point(694, 44);
            this.BtnFiltrarFecha.Name = "BtnFiltrarFecha";
            this.BtnFiltrarFecha.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrarFecha.TabIndex = 11;
            this.BtnFiltrarFecha.Text = "Filtrar";
            this.BtnFiltrarFecha.UseVisualStyleBackColor = true;
            this.BtnFiltrarFecha.Click += new System.EventHandler(this.BtnFiltrarFecha_Click);
            // 
            // TxtFechainventario
            // 
            this.TxtFechainventario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechainventario.Location = new System.Drawing.Point(578, 45);
            this.TxtFechainventario.Name = "TxtFechainventario";
            this.TxtFechainventario.Size = new System.Drawing.Size(99, 22);
            this.TxtFechainventario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Codigo_Factura,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.DtgDetalles.Location = new System.Drawing.Point(34, 296);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.Size = new System.Drawing.Size(779, 150);
            this.DtgDetalles.TabIndex = 8;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(34, 267);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(122, 23);
            this.BtnCargar.TabIndex = 7;
            this.BtnCargar.Text = "Cargar Facturas";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // DtgFacturas
            // 
            this.DtgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoFactura,
            this.Fecha,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DtgFacturas.Location = new System.Drawing.Point(34, 99);
            this.DtgFacturas.Name = "DtgFacturas";
            this.DtgFacturas.Size = new System.Drawing.Size(751, 150);
            this.DtgFacturas.TabIndex = 6;
            this.DtgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgFacturas_CellContentClick);
            // 
            // CodigoFactura
            // 
            this.CodigoFactura.HeaderText = "CodigoFactura";
            this.CodigoFactura.Name = "CodigoFactura";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificacion";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Subtotal";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Iva";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // BtnfiltrarFactura
            // 
            this.BtnfiltrarFactura.Location = new System.Drawing.Point(242, 45);
            this.BtnfiltrarFactura.Name = "BtnfiltrarFactura";
            this.BtnfiltrarFactura.Size = new System.Drawing.Size(122, 23);
            this.BtnfiltrarFactura.TabIndex = 4;
            this.BtnfiltrarFactura.Text = "Filtrar facturas";
            this.BtnfiltrarFactura.UseVisualStyleBackColor = true;
            this.BtnfiltrarFactura.Click += new System.EventHandler(this.BtnfiltrarFactura_Click);
            // 
            // TxtNombrefiltrar
            // 
            this.TxtNombrefiltrar.Location = new System.Drawing.Point(134, 46);
            this.TxtNombrefiltrar.Name = "TxtNombrefiltrar";
            this.TxtNombrefiltrar.Size = new System.Drawing.Size(91, 22);
            this.TxtNombrefiltrar.TabIndex = 2;
            this.TxtNombrefiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombrefiltrar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo Detalle";
            this.Column6.Name = "Column6";
            // 
            // Codigo_Factura
            // 
            this.Codigo_Factura.HeaderText = "Codigo Factura";
            this.Codigo_Factura.Name = "Codigo_Factura";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo Producto";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Marca";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cantidad";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Subtotal";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Total Iva";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total";
            this.Column12.Name = "Column12";
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombrefiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnfiltrarFactura;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.DataGridView DtgFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.DateTimePicker TxtFechainventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFiltrarFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}