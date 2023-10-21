namespace ProyectoMotoZoneGUI
{
    partial class FrmConsutaProveedores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnFiltarProveedores = new System.Windows.Forms.Button();
            this.BtnCargarProveedores = new System.Windows.Forms.Button();
            this.DtgProveedores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra Clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // BtnFiltarProveedores
            // 
            this.BtnFiltarProveedores.Location = new System.Drawing.Point(261, 45);
            this.BtnFiltarProveedores.Name = "BtnFiltarProveedores";
            this.BtnFiltarProveedores.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltarProveedores.TabIndex = 2;
            this.BtnFiltarProveedores.Text = "Filtar";
            this.BtnFiltarProveedores.UseVisualStyleBackColor = true;
            // 
            // BtnCargarProveedores
            // 
            this.BtnCargarProveedores.Location = new System.Drawing.Point(440, 48);
            this.BtnCargarProveedores.Name = "BtnCargarProveedores";
            this.BtnCargarProveedores.Size = new System.Drawing.Size(134, 23);
            this.BtnCargarProveedores.TabIndex = 3;
            this.BtnCargarProveedores.Text = "Cargar Proveedores";
            this.BtnCargarProveedores.UseVisualStyleBackColor = true;
            this.BtnCargarProveedores.Click += new System.EventHandler(this.BtnCargarProveedores_Click);
            // 
            // DtgProveedores
            // 
            this.DtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProveedores.Location = new System.Drawing.Point(25, 85);
            this.DtgProveedores.Name = "DtgProveedores";
            this.DtgProveedores.Size = new System.Drawing.Size(663, 213);
            this.DtgProveedores.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total proveedores";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 344);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // FrmConsutaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 398);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtgProveedores);
            this.Controls.Add(this.BtnCargarProveedores);
            this.Controls.Add(this.BtnFiltarProveedores);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsutaProveedores";
            this.Text = "FrmConsutaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.DtgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnFiltarProveedores;
        private System.Windows.Forms.Button BtnCargarProveedores;
        private System.Windows.Forms.DataGridView DtgProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}