namespace ProyectoMotoZoneGUI
{
    partial class FrmConsultarProductos
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
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.BtnCargarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgProductos
            // 
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Location = new System.Drawing.Point(29, 66);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.Size = new System.Drawing.Size(582, 240);
            this.DtgProductos.TabIndex = 0;
            // 
            // BtnCargarProductos
            // 
            this.BtnCargarProductos.Location = new System.Drawing.Point(471, 27);
            this.BtnCargarProductos.Name = "BtnCargarProductos";
            this.BtnCargarProductos.Size = new System.Drawing.Size(114, 33);
            this.BtnCargarProductos.TabIndex = 1;
            this.BtnCargarProductos.Text = "Cargar Productos";
            this.BtnCargarProductos.UseVisualStyleBackColor = true;
            this.BtnCargarProductos.Click += new System.EventHandler(this.BtnCargarProductos_Click);
            // 
            // FrmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 386);
            this.Controls.Add(this.BtnCargarProductos);
            this.Controls.Add(this.DtgProductos);
            this.Name = "FrmConsultarProductos";
            this.Text = "FrmConsultarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.Button BtnCargarProductos;
    }
}