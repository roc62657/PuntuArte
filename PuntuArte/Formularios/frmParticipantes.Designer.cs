using System.Drawing;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    partial class frmParticipantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarParticipante = new System.Windows.Forms.Button();
            this.btnActualizarParticipante = new System.Windows.Forms.Button();
            this.btnCrearJurado = new System.Windows.Forms.Button();
            this.gbParticipantes = new System.Windows.Forms.GroupBox();
            this.tdIdCategoria = new System.Windows.Forms.TextBox();
            this.labelCatAg = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.tbTipoDocParticipante = new System.Windows.Forms.TextBox();
            this.leyendaHabCateg = new System.Windows.Forms.Label();
            this.listaCategoriasDeJurado = new System.Windows.Forms.DataGridView();
            this.bABMCategoriasPart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIdParticipante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefonoParticipante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNroDocParticipante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreParticipante = new System.Windows.Forms.TextBox();
            this.guardarParticipante = new System.Windows.Forms.Button();
            this.tbApellidoParticipante = new System.Windows.Forms.TextBox();
            this.tbNacionalidadParticipante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaParticipantes = new System.Windows.Forms.DataGridView();
            this.bEliminarCategoriaJurado = new System.Windows.Forms.Button();
            this.gbParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasDeJurado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarParticipante
            // 
            this.btnEliminarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarParticipante.Enabled = false;
            this.btnEliminarParticipante.Location = new System.Drawing.Point(1090, 473);
            this.btnEliminarParticipante.Name = "btnEliminarParticipante";
            this.btnEliminarParticipante.Size = new System.Drawing.Size(260, 23);
            this.btnEliminarParticipante.TabIndex = 18;
            this.btnEliminarParticipante.Text = "Eliminar";
            this.btnEliminarParticipante.UseVisualStyleBackColor = false;
            this.btnEliminarParticipante.Click += new System.EventHandler(this.btnEliminarParticipante_Click);
            // 
            // btnActualizarParticipante
            // 
            this.btnActualizarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarParticipante.Enabled = false;
            this.btnActualizarParticipante.Location = new System.Drawing.Point(659, 473);
            this.btnActualizarParticipante.Name = "btnActualizarParticipante";
            this.btnActualizarParticipante.Size = new System.Drawing.Size(260, 23);
            this.btnActualizarParticipante.TabIndex = 17;
            this.btnActualizarParticipante.Text = "Actualizar seleccionado";
            this.btnActualizarParticipante.UseVisualStyleBackColor = false;
            this.btnActualizarParticipante.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnCrearJurado
            // 
            this.btnCrearJurado.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearJurado.Location = new System.Drawing.Point(248, 473);
            this.btnCrearJurado.Name = "btnCrearJurado";
            this.btnCrearJurado.Size = new System.Drawing.Size(260, 23);
            this.btnCrearJurado.TabIndex = 16;
            this.btnCrearJurado.Text = "Crear nuevo";
            this.btnCrearJurado.UseVisualStyleBackColor = false;
            this.btnCrearJurado.Click += new System.EventHandler(this.btnCrearJurado_Click);
            // 
            // gbParticipantes
            // 
            this.gbParticipantes.Controls.Add(this.bEliminarCategoriaJurado);
            this.gbParticipantes.Controls.Add(this.tdIdCategoria);
            this.gbParticipantes.Controls.Add(this.labelCatAg);
            this.gbParticipantes.Controls.Add(this.cbCategorias);
            this.gbParticipantes.Controls.Add(this.tbTipoDocParticipante);
            this.gbParticipantes.Controls.Add(this.leyendaHabCateg);
            this.gbParticipantes.Controls.Add(this.listaCategoriasDeJurado);
            this.gbParticipantes.Controls.Add(this.bABMCategoriasPart);
            this.gbParticipantes.Controls.Add(this.label9);
            this.gbParticipantes.Controls.Add(this.tbIdParticipante);
            this.gbParticipantes.Controls.Add(this.label8);
            this.gbParticipantes.Controls.Add(this.tbTelefonoParticipante);
            this.gbParticipantes.Controls.Add(this.label5);
            this.gbParticipantes.Controls.Add(this.label7);
            this.gbParticipantes.Controls.Add(this.tbNroDocParticipante);
            this.gbParticipantes.Controls.Add(this.label1);
            this.gbParticipantes.Controls.Add(this.label2);
            this.gbParticipantes.Controls.Add(this.label3);
            this.gbParticipantes.Controls.Add(this.tbNombreParticipante);
            this.gbParticipantes.Controls.Add(this.guardarParticipante);
            this.gbParticipantes.Controls.Add(this.tbApellidoParticipante);
            this.gbParticipantes.Controls.Add(this.tbNacionalidadParticipante);
            this.gbParticipantes.Enabled = false;
            this.gbParticipantes.Location = new System.Drawing.Point(37, 502);
            this.gbParticipantes.Name = "gbParticipantes";
            this.gbParticipantes.Size = new System.Drawing.Size(1533, 297);
            this.gbParticipantes.TabIndex = 15;
            this.gbParticipantes.TabStop = false;
            this.gbParticipantes.Text = "Altas / Modificaciones";
            // 
            // tdIdCategoria
            // 
            this.tdIdCategoria.Location = new System.Drawing.Point(1452, 51);
            this.tdIdCategoria.Name = "tdIdCategoria";
            this.tdIdCategoria.Size = new System.Drawing.Size(75, 20);
            this.tdIdCategoria.TabIndex = 34;
            this.tdIdCategoria.Visible = false;
            // 
            // labelCatAg
            // 
            this.labelCatAg.AutoSize = true;
            this.labelCatAg.Enabled = false;
            this.labelCatAg.Location = new System.Drawing.Point(720, 217);
            this.labelCatAg.Name = "labelCatAg";
            this.labelCatAg.Size = new System.Drawing.Size(158, 13);
            this.labelCatAg.TabIndex = 33;
            this.labelCatAg.Text = "Seleccione categoria a agregar:";
            // 
            // cbCategorias
            // 
            this.cbCategorias.Enabled = false;
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(884, 214);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(272, 21);
            this.cbCategorias.TabIndex = 11;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged_1);
            // 
            // tbTipoDocParticipante
            // 
            this.tbTipoDocParticipante.Location = new System.Drawing.Point(211, 124);
            this.tbTipoDocParticipante.Name = "tbTipoDocParticipante";
            this.tbTipoDocParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbTipoDocParticipante.TabIndex = 7;
            // 
            // leyendaHabCateg
            // 
            this.leyendaHabCateg.AutoSize = true;
            this.leyendaHabCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leyendaHabCateg.Location = new System.Drawing.Point(720, 198);
            this.leyendaHabCateg.Name = "leyendaHabCateg";
            this.leyendaHabCateg.Size = new System.Drawing.Size(429, 13);
            this.leyendaHabCateg.TabIndex = 26;
            this.leyendaHabCateg.Text = "* Se habilitará la carga una vez guardados los datos personales del jurado";
            this.leyendaHabCateg.Visible = false;
            // 
            // listaCategoriasDeJurado
            // 
            this.listaCategoriasDeJurado.AllowUserToAddRows = false;
            this.listaCategoriasDeJurado.AllowUserToDeleteRows = false;
            this.listaCategoriasDeJurado.AllowUserToResizeColumns = false;
            this.listaCategoriasDeJurado.AllowUserToResizeRows = false;
            this.listaCategoriasDeJurado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCategoriasDeJurado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCategoriasDeJurado.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaCategoriasDeJurado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaCategoriasDeJurado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasDeJurado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaCategoriasDeJurado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategoriasDeJurado.GridColor = System.Drawing.Color.Indigo;
            this.listaCategoriasDeJurado.Location = new System.Drawing.Point(708, 39);
            this.listaCategoriasDeJurado.MultiSelect = false;
            this.listaCategoriasDeJurado.Name = "listaCategoriasDeJurado";
            this.listaCategoriasDeJurado.ReadOnly = true;
            this.listaCategoriasDeJurado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasDeJurado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listaCategoriasDeJurado.RowHeadersVisible = false;
            this.listaCategoriasDeJurado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.listaCategoriasDeJurado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listaCategoriasDeJurado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCategoriasDeJurado.Size = new System.Drawing.Size(449, 157);
            this.listaCategoriasDeJurado.TabIndex = 21;
            // 
            // bABMCategoriasPart
            // 
            this.bABMCategoriasPart.BackColor = System.Drawing.SystemColors.Control;
            this.bABMCategoriasPart.Location = new System.Drawing.Point(1050, 239);
            this.bABMCategoriasPart.Name = "bABMCategoriasPart";
            this.bABMCategoriasPart.Size = new System.Drawing.Size(107, 22);
            this.bABMCategoriasPart.TabIndex = 12;
            this.bABMCategoriasPart.Text = "Agregar Categoria";
            this.bABMCategoriasPart.UseVisualStyleBackColor = false;
            this.bABMCategoriasPart.Visible = false;
            this.bABMCategoriasPart.Click += new System.EventHandler(this.bABMCategoriasPart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(705, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Categorias por calificar:";
            // 
            // tbIdParticipante
            // 
            this.tbIdParticipante.Location = new System.Drawing.Point(1452, 26);
            this.tbIdParticipante.Name = "tbIdParticipante";
            this.tbIdParticipante.Size = new System.Drawing.Size(75, 20);
            this.tbIdParticipante.TabIndex = 19;
            this.tbIdParticipante.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número de Teléfono";
            // 
            // tbTelefonoParticipante
            // 
            this.tbTelefonoParticipante.Location = new System.Drawing.Point(211, 198);
            this.tbTelefonoParticipante.Name = "tbTelefonoParticipante";
            this.tbTelefonoParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbTelefonoParticipante.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Número Documento*";
            // 
            // tbNroDocParticipante
            // 
            this.tbNroDocParticipante.Location = new System.Drawing.Point(211, 162);
            this.tbNroDocParticipante.Name = "tbNroDocParticipante";
            this.tbNroDocParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbNroDocParticipante.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais Origen*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido*";
            // 
            // tbNombreParticipante
            // 
            this.tbNombreParticipante.Location = new System.Drawing.Point(211, 23);
            this.tbNombreParticipante.Name = "tbNombreParticipante";
            this.tbNombreParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbNombreParticipante.TabIndex = 4;
            // 
            // guardarParticipante
            // 
            this.guardarParticipante.BackColor = System.Drawing.Color.White;
            this.guardarParticipante.Enabled = false;
            this.guardarParticipante.Location = new System.Drawing.Point(549, 233);
            this.guardarParticipante.Name = "guardarParticipante";
            this.guardarParticipante.Size = new System.Drawing.Size(105, 34);
            this.guardarParticipante.TabIndex = 10;
            this.guardarParticipante.Text = "Guardar Datos Personales";
            this.guardarParticipante.UseVisualStyleBackColor = false;
            this.guardarParticipante.Click += new System.EventHandler(this.guardarCategoria_Click);
            // 
            // tbApellidoParticipante
            // 
            this.tbApellidoParticipante.Location = new System.Drawing.Point(211, 55);
            this.tbApellidoParticipante.Name = "tbApellidoParticipante";
            this.tbApellidoParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbApellidoParticipante.TabIndex = 5;
            // 
            // tbNacionalidadParticipante
            // 
            this.tbNacionalidadParticipante.Location = new System.Drawing.Point(211, 90);
            this.tbNacionalidadParticipante.Name = "tbNacionalidadParticipante";
            this.tbNacionalidadParticipante.Size = new System.Drawing.Size(443, 20);
            this.tbNacionalidadParticipante.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Jurados";
            // 
            // listaParticipantes
            // 
            this.listaParticipantes.AllowUserToAddRows = false;
            this.listaParticipantes.AllowUserToDeleteRows = false;
            this.listaParticipantes.AllowUserToResizeColumns = false;
            this.listaParticipantes.AllowUserToResizeRows = false;
            this.listaParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaParticipantes.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaParticipantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaParticipantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaParticipantes.GridColor = System.Drawing.Color.Indigo;
            this.listaParticipantes.Location = new System.Drawing.Point(37, 111);
            this.listaParticipantes.MultiSelect = false;
            this.listaParticipantes.Name = "listaParticipantes";
            this.listaParticipantes.ReadOnly = true;
            this.listaParticipantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listaParticipantes.RowHeadersVisible = false;
            this.listaParticipantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.listaParticipantes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listaParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaParticipantes.Size = new System.Drawing.Size(1533, 339);
            this.listaParticipantes.TabIndex = 19;
            this.listaParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaParticipantes_CellClick);
            // 
            // bEliminarCategoriaJurado
            // 
            this.bEliminarCategoriaJurado.BackColor = System.Drawing.SystemColors.Control;
            this.bEliminarCategoriaJurado.Location = new System.Drawing.Point(1163, 39);
            this.bEliminarCategoriaJurado.Name = "bEliminarCategoriaJurado";
            this.bEliminarCategoriaJurado.Size = new System.Drawing.Size(107, 22);
            this.bEliminarCategoriaJurado.TabIndex = 35;
            this.bEliminarCategoriaJurado.Text = "Quitar Categoria";
            this.bEliminarCategoriaJurado.UseVisualStyleBackColor = false;
            this.bEliminarCategoriaJurado.Visible = false;
            this.bEliminarCategoriaJurado.Click += new System.EventHandler(this.bEliminarCategoriaJurado_Click);
            // 
            // frmParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaParticipantes);
            this.Controls.Add(this.btnEliminarParticipante);
            this.Controls.Add(this.btnActualizarParticipante);
            this.Controls.Add(this.btnCrearJurado);
            this.Controls.Add(this.gbParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParticipantes";
            this.Text = "frmParticipantes";
            this.Load += new System.EventHandler(this.frmParticipantes_Load);
            this.gbParticipantes.ResumeLayout(false);
            this.gbParticipantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasDeJurado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEliminarParticipante;
        private Button btnActualizarParticipante;
        private Button btnCrearJurado;
        private GroupBox gbParticipantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombreParticipante;
        private Button guardarParticipante;
        private TextBox tbApellidoParticipante;
        private TextBox tbNacionalidadParticipante;
        private Label label4;
        private DataGridView listaParticipantes;
        private Label label8;
        private TextBox tbTelefonoParticipante;
        private Label label5;
        private Label label7;
        private TextBox tbNroDocParticipante;
        private TextBox tbIdParticipante;
        private Label label9;
        private Button bABMCategoriasPart;
        private DataGridView listaCategoriasDeJurado;
        private Label leyendaHabCateg;
        private TextBox tbTipoDocParticipante;
        private Label labelCatAg;
        private ComboBox cbCategorias;
        private TextBox tdIdCategoria;
        private Button bEliminarCategoriaJurado;
    }
}