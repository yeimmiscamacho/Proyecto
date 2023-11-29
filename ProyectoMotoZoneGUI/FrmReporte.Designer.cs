namespace ProyectoMotoZoneGUI
{
    partial class FrmReporte
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
            this.Btncargarproductos = new System.Windows.Forms.Button();
            this.Dtgproductos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btncargarproductos);
            this.groupBox1.Controls.Add(this.Dtgproductos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE";
            // 
            // Btncargarproductos
            // 
            this.Btncargarproductos.Location = new System.Drawing.Point(573, 305);
            this.Btncargarproductos.Name = "Btncargarproductos";
            this.Btncargarproductos.Size = new System.Drawing.Size(173, 23);
            this.Btncargarproductos.TabIndex = 1;
            this.Btncargarproductos.Text = "Cargar productos";
            this.Btncargarproductos.UseVisualStyleBackColor = true;
            this.Btncargarproductos.Click += new System.EventHandler(this.Btncargarproductos_Click);
            // 
            // Dtgproductos
            // 
            this.Dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgproductos.Location = new System.Drawing.Point(30, 38);
            this.Dtgproductos.Name = "Dtgproductos";
            this.Dtgproductos.Size = new System.Drawing.Size(716, 211);
            this.Dtgproductos.TabIndex = 0;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 465);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReporte";
            this.Text = "FrmReporte";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dtgproductos;
        private System.Windows.Forms.Button Btncargarproductos;
    }
}