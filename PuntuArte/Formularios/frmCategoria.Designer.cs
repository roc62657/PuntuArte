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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gbItemsPuntuacion = new System.Windows.Forms.GroupBox();
            this.bModificacionItem = new System.Windows.Forms.Button();
            this.bAltaItem = new System.Windows.Forms.Button();
            this.bQuitarItem = new System.Windows.Forms.Button();
            this.bAgregarItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listaItemsAsociados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.listaItemsDisponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategorias)).BeginInit();
            this.gbCategorias.SuspendLayout();
            this.gbItemsPuntuacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsAsociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ritmo Musical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Location = new System.Drawing.Point(26, 55);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new System.Drawing.Size(502, 20);
            this.nombreCategoria.TabIndex = 4;
            // 
            // ritmoMusical
            // 
            this.ritmoMusical.Location = new System.Drawing.Point(26, 110);
            this.ritmoMusical.Name = "ritmoMusical";
            this.ritmoMusical.Size = new System.Drawing.Size(502, 20);
            this.ritmoMusical.TabIndex = 5;
            // 
            // detalleCategoria
            // 
            this.detalleCategoria.Location = new System.Drawing.Point(26, 172);
            this.detalleCategoria.Multiline = true;
            this.detalleCategoria.Name = "detalleCategoria";
            this.detalleCategoria.Size = new System.Drawing.Size(502, 43);
            this.detalleCategoria.TabIndex = 6;
            // 
            // guardarCategoria
            // 
            this.guardarCategoria.BackColor = System.Drawing.Color.White;
            this.guardarCategoria.Enabled = false;
            this.guardarCategoria.Location = new System.Drawing.Point(453, 237);
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
            this.listaCategorias.BackgroundColor = System.Drawing.Color.MistyRose;
            this.listaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.listaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategorias.EnableHeadersVisualStyles = false;
            this.listaCategorias.GridColor = System.Drawing.Color.Indigo;
            this.listaCategorias.Location = new System.Drawing.Point(50, 111);
            this.listaCategorias.MultiSelect = false;
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.ReadOnly = true;
            this.listaCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.listaCategorias.RowHeadersVisible = false;
            this.listaCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.listaCategorias.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.listaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCategorias.Size = new System.Drawing.Size(899, 337);
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
            this.gbCategorias.Location = new System.Drawing.Point(993, 169);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(564, 279);
            this.gbCategorias.TabIndex = 11;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "Altas / Modificaciones";
            // 
            // tbIdCategoria
            // 
            this.tbIdCategoria.Location = new System.Drawing.Point(453, 29);
            this.tbIdCategoria.Name = "tbIdCategoria";
            this.tbIdCategoria.Size = new System.Drawing.Size(75, 20);
            this.tbIdCategoria.TabIndex = 8;
            this.tbIdCategoria.Visible = false;
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearCategoria.Location = new System.Drawing.Point(993, 111);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(173, 23);
            this.btnCrearCategoria.TabIndex = 12;
            this.btnCrearCategoria.Text = "Crear nuevo";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCategoria.Enabled = false;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(1192, 111);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(173, 23);
            this.btnActualizarCategoria.TabIndex = 13;
            this.btnActualizarCategoria.Text = "Actualizar seleccionado";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCategoria.Enabled = false;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(1386, 111);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(173, 23);
            this.btnEliminarCategoria.TabIndex = 14;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // gbItemsPuntuacion
            // 
            this.gbItemsPuntuacion.Controls.Add(this.bModificacionItem);
            this.gbItemsPuntuacion.Controls.Add(this.bAltaItem);
            this.gbItemsPuntuacion.Controls.Add(this.bQuitarItem);
            this.gbItemsPuntuacion.Controls.Add(this.bAgregarItem);
            this.gbItemsPuntuacion.Controls.Add(this.label7);
            this.gbItemsPuntuacion.Controls.Add(this.listaItemsAsociados);
            this.gbItemsPuntuacion.Controls.Add(this.label6);
            this.gbItemsPuntuacion.Controls.Add(this.listaItemsDisponibles);
            this.gbItemsPuntuacion.Enabled = false;
            this.gbItemsPuntuacion.Location = new System.Drawing.Point(50, 484);
            this.gbItemsPuntuacion.Name = "gbItemsPuntuacion";
            this.gbItemsPuntuacion.Size = new System.Drawing.Size(1507, 296);
            this.gbItemsPuntuacion.TabIndex = 15;
            this.gbItemsPuntuacion.TabStop = false;
            this.gbItemsPuntuacion.Text = "Asignacion de Items de puntuación";
            // 
            // bModificacionItem
            // 
            this.bModificacionItem.BackColor = System.Drawing.SystemColors.Control;
            this.bModificacionItem.Enabled = false;
            this.bModificacionItem.Location = new System.Drawing.Point(649, 38);
            this.bModificacionItem.Name = "bModificacionItem";
            this.bModificacionItem.Size = new System.Drawing.Size(24, 23);
            this.bModificacionItem.TabIndex = 34;
            this.bModificacionItem.Text = "/";
            this.bModificacionItem.UseVisualStyleBackColor = false;
            this.bModificacionItem.Click += new System.EventHandler(this.bModificacionItem_Click);
            // 
            // bAltaItem
            // 
            this.bAltaItem.BackColor = System.Drawing.SystemColors.Control;
            this.bAltaItem.Location = new System.Drawing.Point(619, 38);
            this.bAltaItem.Name = "bAltaItem";
            this.bAltaItem.Size = new System.Drawing.Size(24, 23);
            this.bAltaItem.TabIndex = 33;
            this.bAltaItem.Text = "+";
            this.bAltaItem.UseVisualStyleBackColor = false;
            this.bAltaItem.Click += new System.EventHandler(this.bAltaItem_Click);
            // 
            // bQuitarItem
            // 
            this.bQuitarItem.BackColor = System.Drawing.SystemColors.Control;
            this.bQuitarItem.Enabled = false;
            this.bQuitarItem.Location = new System.Drawing.Point(716, 185);
            this.bQuitarItem.Name = "bQuitarItem";
            this.bQuitarItem.Size = new System.Drawing.Size(87, 43);
            this.bQuitarItem.TabIndex = 32;
            this.bQuitarItem.Text = "<< Quitar";
            this.bQuitarItem.UseVisualStyleBackColor = false;
            this.bQuitarItem.Click += new System.EventHandler(this.bQuitarItem_Click);
            // 
            // bAgregarItem
            // 
            this.bAgregarItem.BackColor = System.Drawing.SystemColors.Control;
            this.bAgregarItem.Enabled = false;
            this.bAgregarItem.Location = new System.Drawing.Point(716, 107);
            this.bAgregarItem.Name = "bAgregarItem";
            this.bAgregarItem.Size = new System.Drawing.Size(87, 43);
            this.bAgregarItem.TabIndex = 31;
            this.bAgregarItem.Text = "Agregar >>";
            this.bAgregarItem.UseVisualStyleBackColor = false;
            this.bAgregarItem.Click += new System.EventHandler(this.bAgregarItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Participantes seleccionados por la compañia para esta categoría";
            // 
            // listaItemsAsociados
            // 
            this.listaItemsAsociados.AllowUserToAddRows = false;
            this.listaItemsAsociados.AllowUserToDeleteRows = false;
            this.listaItemsAsociados.AllowUserToResizeColumns = false;
            this.listaItemsAsociados.AllowUserToResizeRows = false;
            this.listaItemsAsociados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaItemsAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaItemsAsociados.BackgroundColor = System.Drawing.Color.MistyRose;
            this.listaItemsAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaItemsAsociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.listaItemsAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaItemsAsociados.EnableHeadersVisualStyles = false;
            this.listaItemsAsociados.GridColor = System.Drawing.Color.Indigo;
            this.listaItemsAsociados.Location = new System.Drawing.Point(848, 67);
            this.listaItemsAsociados.Name = "listaItemsAsociados";
            this.listaItemsAsociados.ReadOnly = true;
            this.listaItemsAsociados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listaItemsAsociados.RowHeadersVisible = false;
            this.listaItemsAsociados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.listaItemsAsociados.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.listaItemsAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaItemsAsociados.Size = new System.Drawing.Size(639, 203);
            this.listaItemsAsociados.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Participantes inscriptos";
            // 
            // listaItemsDisponibles
            // 
            this.listaItemsDisponibles.AllowUserToAddRows = false;
            this.listaItemsDisponibles.AllowUserToDeleteRows = false;
            this.listaItemsDisponibles.AllowUserToResizeColumns = false;
            this.listaItemsDisponibles.AllowUserToResizeRows = false;
            this.listaItemsDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaItemsDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaItemsDisponibles.BackgroundColor = System.Drawing.Color.MistyRose;
            this.listaItemsDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaItemsDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.listaItemsDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaItemsDisponibles.EnableHeadersVisualStyles = false;
            this.listaItemsDisponibles.GridColor = System.Drawing.Color.Indigo;
            this.listaItemsDisponibles.Location = new System.Drawing.Point(20, 67);
            this.listaItemsDisponibles.Name = "listaItemsDisponibles";
            this.listaItemsDisponibles.ReadOnly = true;
            this.listaItemsDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsDisponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.listaItemsDisponibles.RowHeadersVisible = false;
            this.listaItemsDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.listaItemsDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.listaItemsDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaItemsDisponibles.Size = new System.Drawing.Size(653, 203);
            this.listaItemsDisponibles.TabIndex = 27;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.gbItemsPuntuacion);
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
            this.gbItemsPuntuacion.ResumeLayout(false);
            this.gbItemsPuntuacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsAsociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsDisponibles)).EndInit();
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
        private System.Windows.Forms.GroupBox gbItemsPuntuacion;
        private System.Windows.Forms.Button bModificacionItem;
        private System.Windows.Forms.Button bAltaItem;
        private System.Windows.Forms.Button bQuitarItem;
        private System.Windows.Forms.Button bAgregarItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView listaItemsAsociados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView listaItemsDisponibles;
    }
}

