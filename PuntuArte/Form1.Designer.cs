namespace PuntuArte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreCategoria = new System.Windows.Forms.TextBox();
            this.ritmoMusical = new System.Windows.Forms.TextBox();
            this.detalleCategoria = new System.Windows.Forms.TextBox();
            this.guardarCategoria = new System.Windows.Forms.Button();
            this.obtenerCategoria = new System.Windows.Forms.Button();
            this.listaCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ritmo Musical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Location = new System.Drawing.Point(239, 54);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(100, 20);
            this.nombreCategoria.TabIndex = 4;
            // 
            // ritmoMusical
            // 
            this.ritmoMusical.Location = new System.Drawing.Point(239, 95);
            this.ritmoMusical.Name = "ritmoMusical";
            this.ritmoMusical.Size = new System.Drawing.Size(100, 20);
            this.ritmoMusical.TabIndex = 5;
            // 
            // detalleCategoria
            // 
            this.detalleCategoria.Location = new System.Drawing.Point(239, 131);
            this.detalleCategoria.Name = "detalleCategoria";
            this.detalleCategoria.Size = new System.Drawing.Size(100, 20);
            this.detalleCategoria.TabIndex = 6;
            // 
            // guardarCategoria
            // 
            this.guardarCategoria.Location = new System.Drawing.Point(125, 189);
            this.guardarCategoria.Name = "guardarCategoria";
            this.guardarCategoria.Size = new System.Drawing.Size(75, 23);
            this.guardarCategoria.TabIndex = 7;
            this.guardarCategoria.Text = "Guardar";
            this.guardarCategoria.UseVisualStyleBackColor = true;
            this.guardarCategoria.Click += new System.EventHandler(this.guardarCategoria_Click);
            // 
            // obtenerCategoria
            // 
            this.obtenerCategoria.Location = new System.Drawing.Point(264, 189);
            this.obtenerCategoria.Name = "obtenerCategoria";
            this.obtenerCategoria.Size = new System.Drawing.Size(115, 23);
            this.obtenerCategoria.TabIndex = 8;
            this.obtenerCategoria.Text = "ObtenerCategoria";
            this.obtenerCategoria.UseVisualStyleBackColor = true;
            // 
            // listaCategorias
            // 
            this.listaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategorias.Location = new System.Drawing.Point(77, 232);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(489, 150);
            this.listaCategorias.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaCategorias);
            this.Controls.Add(this.obtenerCategoria);
            this.Controls.Add(this.guardarCategoria);
            this.Controls.Add(this.detalleCategoria);
            this.Controls.Add(this.ritmoMusical);
            this.Controls.Add(this.nombreCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreCategoria;
        private System.Windows.Forms.TextBox ritmoMusical;
        private System.Windows.Forms.TextBox detalleCategoria;
        private System.Windows.Forms.Button guardarCategoria;
        private System.Windows.Forms.Button obtenerCategoria;
        private System.Windows.Forms.DataGridView listaCategorias;
    }
}

