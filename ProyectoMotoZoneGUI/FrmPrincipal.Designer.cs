namespace ProyectoMotoZoneGUI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnFacturar = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(759, 484);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Location = new System.Drawing.Point(248, 1);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(778, 568);
            this.panelContenedor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnInventario);
            this.groupBox1.Controls.Add(this.BtnProveedor);
            this.groupBox1.Controls.Add(this.BtnReportes);
            this.groupBox1.Controls.Add(this.BtnFacturar);
            this.groupBox1.Controls.Add(this.BtnProducto);
            this.groupBox1.Controls.Add(this.BtnCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 331);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // BtnInventario
            // 
            this.BtnInventario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.Location = new System.Drawing.Point(17, 287);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(176, 43);
            this.BtnInventario.TabIndex = 5;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.Location = new System.Drawing.Point(18, 151);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(176, 38);
            this.BtnProveedor.TabIndex = 2;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Location = new System.Drawing.Point(17, 243);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(176, 38);
            this.BtnReportes.TabIndex = 4;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Location = new System.Drawing.Point(17, 195);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(176, 42);
            this.BtnFacturar.TabIndex = 3;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.UseVisualStyleBackColor = true;
            this.BtnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click_1);
            // 
            // BtnProducto
            // 
            this.BtnProducto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.Location = new System.Drawing.Point(18, 105);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(175, 40);
            this.BtnProducto.TabIndex = 1;
            this.BtnProducto.Text = "Productos";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(17, 61);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(176, 38);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Clientes";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(57, 482);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(60, 24);
            this.LblHora.TabIndex = 9;
            this.LblHora.Text = "label1";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(26, 520);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(35, 13);
            this.LblFecha.TabIndex = 10;
            this.LblFecha.Text = "label1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 573);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelContenedor);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnFacturar;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
    }
}