namespace PuntuArte.Formularios
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreCategoria = new System.Windows.Forms.TextBox();
            this.ritmoMusical = new System.Windows.Forms.TextBox();
            this.detalleCategoria = new System.Windows.Forms.TextBox();
            this.guardarCategoria = new System.Windows.Forms.Button();
            this.listaCategorias = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.tbIdCategoria = new System.Windows.Forms.TextBox();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).BeginInit();
            this.gbCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ritmo Musical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Location = new System.Drawing.Point(211, 23);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(611, 20);
            this.nombreCategoria.TabIndex = 4;
            this.nombreCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreCategoria_KeyPress);
            // 
            // ritmoMusical
            // 
            this.ritmoMusical.Location = new System.Drawing.Point(211, 57);
            this.ritmoMusical.Name = "ritmoMusical";
            this.ritmoMusical.Size = new System.Drawing.Size(611, 20);
            this.ritmoMusical.TabIndex = 5;
            this.ritmoMusical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ritmoMusical_KeyPress);
            // 
            // detalleCategoria
            // 
            this.detalleCategoria.Location = new System.Drawing.Point(211, 90);
            this.detalleCategoria.Name = "detalleCategoria";
            this.detalleCategoria.Size = new System.Drawing.Size(611, 20);
            this.detalleCategoria.TabIndex = 6;
            this.detalleCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detalleCategoria_KeyPress);
            // 
            // guardarCategoria
            // 
            this.guardarCategoria.BackColor = System.Drawing.Color.White;
            this.guardarCategoria.Enabled = false;
            this.guardarCategoria.Location = new System.Drawing.Point(884, 85);
            this.guardarCategoria.Name = "guardarCategoria";
            this.guardarCategoria.Size = new System.Drawing.Size(75, 23);
            this.guardarCategoria.TabIndex = 7;
            this.guardarCategoria.Text = "Guardar";
            this.guardarCategoria.UseVisualStyleBackColor = false;
            this.guardarCategoria.Click += new System.EventHandler(this.guardarCategoria_Click);
            // 
            // listaCategorias
            // 
            this.listaCategorias.AllowUserToAddRows = false;
            this.listaCategorias.AllowUserToDeleteRows = false;
            this.listaCategorias.AllowUserToResizeColumns = false;
            this.listaCategorias.AllowUserToResizeRows = false;
            this.listaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCategorias.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategorias.GridColor = System.Drawing.Color.Indigo;
            this.listaCategorias.Location = new System.Drawing.Point(62, 111);
            this.listaCategorias.MultiSelect = false;
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.ReadOnly = true;
            this.listaCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaCategorias.RowHeadersVisible = false;
            this.listaCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.listaCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCategorias.Size = new System.Drawing.Size(1483, 427);
            this.listaCategorias.TabIndex = 9;
            this.listaCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaCategorias_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categorias";
            // 
            // gbCategorias
            // 
            this.gbCategorias.Controls.Add(this.tbIdCategoria);
            this.gbCategorias.Controls.Add(this.label1);
            this.gbCategorias.Controls.Add(this.label2);
            this.gbCategorias.Controls.Add(this.label3);
            this.gbCategorias.Controls.Add(this.nombreCategoria);
            this.gbCategorias.Controls.Add(this.guardarCategoria);
            this.gbCategorias.Controls.Add(this.ritmoMusical);
            this.gbCategorias.Controls.Add(this.detalleCategoria);
            this.gbCategorias.Enabled = false;
            this.gbCategorias.Location = new System.Drawing.Point(62, 605);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(1483, 152);
            this.gbCategorias.TabIndex = 11;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Altas / Modificaciones";
            // 
            // tbIdCategoria
            // 
            this.tbIdCategoria.Location = new System.Drawing.Point(872, 19);
            this.tbIdCategoria.Name = "tbIdCategoria";
            this.tbIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbIdCategoria.TabIndex = 8;
            this.tbIdCategoria.Visible = false;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearCategoria.Location = new System.Drawing.Point(273, 576);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(260, 23);
            this.btnCrearCategoria.TabIndex = 12;
            this.btnCrearCategoria.Text = "Crear nuevo";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCategoria.Enabled = false;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(689, 576);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(260, 23);
            this.btnActualizarCategoria.TabIndex = 13;
            this.btnActualizarCategoria.Text = "Actualizar seleccionado";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCategoria.Enabled = false;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(1117, 576);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(260, 23);
            this.btnEliminarCategoria.TabIndex = 14;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.gbCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).EndInit();
            this.gbCategorias.ResumeLayout(false);
            this.gbCategorias.PerformLayout();
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
        private System.Windows.Forms.DataGridView listaCategorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.Button btnCrearCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.TextBox tbIdCategoria;
    }
}

