namespace ProyectoMotoZoneGUI
{
    partial class FrmConsultaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltarClientes = new System.Windows.Forms.TextBox();
            this.BtnFiltarClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFechaClientes = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltrarFecha = new System.Windows.Forms.Button();
            this.BtnCargarClientes = new System.Windows.Forms.Button();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotalClientes = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Palabra Clave:";
            // 
            // TxtFiltarClientes
            // 
            this.TxtFiltarClientes.Location = new System.Drawing.Point(109, 46);
            this.TxtFiltarClientes.Name = "TxtFiltarClientes";
            this.TxtFiltarClientes.Size = new System.Drawing.Size(100, 20);
            this.TxtFiltarClientes.TabIndex = 35;
            // 
            // BtnFiltarClientes
            // 
            this.BtnFiltarClientes.Location = new System.Drawing.Point(215, 43);
            this.BtnFiltarClientes.Name = "BtnFiltarClientes";
            this.BtnFiltarClientes.Size = new System.Drawing.Size(58, 24);
            this.BtnFiltarClientes.TabIndex = 36;
            this.BtnFiltarClientes.Text = "Filtrar";
            this.BtnFiltarClientes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha:";
            // 
            // TxtFechaClientes
            // 
            this.TxtFechaClientes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaClientes.Location = new System.Drawing.Point(378, 46);
            this.TxtFechaClientes.Name = "TxtFechaClientes";
            this.TxtFechaClientes.Size = new System.Drawing.Size(94, 20);
            this.TxtFechaClientes.TabIndex = 41;
            // 
            // BtnFiltrarFecha
            // 
            this.BtnFiltrarFecha.Location = new System.Drawing.Point(478, 43);
            this.BtnFiltrarFecha.Name = "BtnFiltrarFecha";
            this.BtnFiltrarFecha.Size = new System.Drawing.Size(85, 24);
            this.BtnFiltrarFecha.TabIndex = 42;
            this.BtnFiltrarFecha.Text = "Filtrar";
            this.BtnFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // BtnCargarClientes
            // 
            this.BtnCargarClientes.Location = new System.Drawing.Point(674, 39);
            this.BtnCargarClientes.Name = "BtnCargarClientes";
            this.BtnCargarClientes.Size = new System.Drawing.Size(91, 23);
            this.BtnCargarClientes.TabIndex = 44;
            this.BtnCargarClientes.Text = "Cargar Datos";
            this.BtnCargarClientes.UseVisualStyleBackColor = true;
            this.BtnCargarClientes.Click += new System.EventHandler(this.BtnCargarClientes_Click);
            // 
            // DtgClientes
            // 
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Location = new System.Drawing.Point(30, 100);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(741, 289);
            this.DtgClientes.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Total Clientes";
            // 
            // TxtTotalClientes
            // 
            this.TxtTotalClientes.Location = new System.Drawing.Point(173, 411);
            this.TxtTotalClientes.Name = "TxtTotalClientes";
            this.TxtTotalClientes.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalClientes.TabIndex = 45;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(674, 409);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(97, 23);
            this.BtnRegresar.TabIndex = 32;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtTotalClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtgClientes);
            this.Controls.Add(this.BtnCargarClientes);
            this.Controls.Add(this.BtnFiltrarFecha);
            this.Controls.Add(this.TxtFechaClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnFiltarClientes);
            this.Controls.Add(this.TxtFiltarClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaClientes";
            this.Text = "FrmConsultaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltarClientes;
        private System.Windows.Forms.Button BtnFiltarClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TxtFechaClientes;
        private System.Windows.Forms.Button BtnFiltrarFecha;
        private System.Windows.Forms.Button BtnCargarClientes;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotalClientes;
        private System.Windows.Forms.Button BtnRegresar;
    }
}