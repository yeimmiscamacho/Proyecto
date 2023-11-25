namespace ProyectoMotoZoneGUI
{
    partial class FrmRegistroProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroProveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Txtcelular = new System.Windows.Forms.TextBox();
            this.Txttelefono = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtbarrio = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGuardarProveedor = new System.Windows.Forms.Button();
            this.BtnModificarProveedor = new System.Windows.Forms.Button();
            this.BtnEliminarProveedor = new System.Windows.Forms.Button();
            this.BtnConsultarProveedores = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.Txtcelular);
            this.groupBox1.Controls.Add(this.Txttelefono);
            this.groupBox1.Controls.Add(this.TxtIdentificacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PROVEEDOR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(154, 73);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(111, 20);
            this.TxtNombre.TabIndex = 7;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // Txtcelular
            // 
            this.Txtcelular.Location = new System.Drawing.Point(154, 161);
            this.Txtcelular.Name = "Txtcelular";
            this.Txtcelular.Size = new System.Drawing.Size(111, 20);
            this.Txtcelular.TabIndex = 6;
            this.Txtcelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcelular_KeyPress);
            // 
            // Txttelefono
            // 
            this.Txttelefono.Location = new System.Drawing.Point(154, 117);
            this.Txttelefono.Name = "Txttelefono";
            this.Txttelefono.Size = new System.Drawing.Size(111, 20);
            this.Txttelefono.TabIndex = 5;
            this.Txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(154, 31);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(111, 20);
            this.TxtIdentificacion.TabIndex = 4;
            this.TxtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdentificacion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CELULAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFONO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDENTIFICACION:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txtbarrio);
            this.groupBox2.Controls.Add(this.TxtDireccion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(327, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DIRECCION PROVEEDOR";
            // 
            // Txtbarrio
            // 
            this.Txtbarrio.Location = new System.Drawing.Point(149, 71);
            this.Txtbarrio.Name = "Txtbarrio";
            this.Txtbarrio.Size = new System.Drawing.Size(100, 20);
            this.Txtbarrio.TabIndex = 3;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(149, 33);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "BARRIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "DIRECCION:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 196);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGuardarProveedor
            // 
            this.BtnGuardarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProveedor.Location = new System.Drawing.Point(53, 401);
            this.BtnGuardarProveedor.Name = "BtnGuardarProveedor";
            this.BtnGuardarProveedor.Size = new System.Drawing.Size(94, 28);
            this.BtnGuardarProveedor.TabIndex = 3;
            this.BtnGuardarProveedor.Text = "Guardar";
            this.BtnGuardarProveedor.UseVisualStyleBackColor = true;
            this.BtnGuardarProveedor.Click += new System.EventHandler(this.BtnGuardarProveedor_Click);
            // 
            // BtnModificarProveedor
            // 
            this.BtnModificarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarProveedor.Location = new System.Drawing.Point(188, 401);
            this.BtnModificarProveedor.Name = "BtnModificarProveedor";
            this.BtnModificarProveedor.Size = new System.Drawing.Size(104, 28);
            this.BtnModificarProveedor.TabIndex = 4;
            this.BtnModificarProveedor.Text = "Modificar";
            this.BtnModificarProveedor.UseVisualStyleBackColor = true;
            this.BtnModificarProveedor.Click += new System.EventHandler(this.BtnModificarProveedor_Click);
            // 
            // BtnEliminarProveedor
            // 
            this.BtnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProveedor.Location = new System.Drawing.Point(345, 400);
            this.BtnEliminarProveedor.Name = "BtnEliminarProveedor";
            this.BtnEliminarProveedor.Size = new System.Drawing.Size(104, 31);
            this.BtnEliminarProveedor.TabIndex = 5;
            this.BtnEliminarProveedor.Text = "Eliminar";
            this.BtnEliminarProveedor.UseVisualStyleBackColor = true;
            this.BtnEliminarProveedor.Click += new System.EventHandler(this.BtnEliminarProveedor_Click);
            // 
            // BtnConsultarProveedores
            // 
            this.BtnConsultarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarProveedores.Location = new System.Drawing.Point(484, 400);
            this.BtnConsultarProveedores.Name = "BtnConsultarProveedores";
            this.BtnConsultarProveedores.Size = new System.Drawing.Size(104, 31);
            this.BtnConsultarProveedores.TabIndex = 6;
            this.BtnConsultarProveedores.Text = "Consultar";
            this.BtnConsultarProveedores.UseVisualStyleBackColor = true;
            this.BtnConsultarProveedores.Click += new System.EventHandler(this.BtnConsultarProveedores_Click);
            // 
            // FrmRegistroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 454);
            this.Controls.Add(this.BtnConsultarProveedores);
            this.Controls.Add(this.BtnEliminarProveedor);
            this.Controls.Add(this.BtnModificarProveedor);
            this.Controls.Add(this.BtnGuardarProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistroProveedores";
            this.Text = "FrmRegistroProveedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox Txtcelular;
        private System.Windows.Forms.TextBox Txttelefono;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txtbarrio;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGuardarProveedor;
        private System.Windows.Forms.Button BtnModificarProveedor;
        private System.Windows.Forms.Button BtnEliminarProveedor;
        private System.Windows.Forms.Button BtnConsultarProveedores;
    }
}