using System.Drawing;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    partial class frmCompanias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bActualizarCompania = new System.Windows.Forms.Button();
            this.lNacionalidadDesc = new System.Windows.Forms.Label();
            this.lDetalleDesc = new System.Windows.Forms.Label();
            this.lNacionalidadTitulo = new System.Windows.Forms.Label();
            this.lDetalleTitulo = new System.Windows.Forms.Label();
            this.tbIdCompania = new System.Windows.Forms.TextBox();
            this.bGuardarCompania = new System.Windows.Forms.Button();
            this.lNacionalidadNuevoTitulo = new System.Windows.Forms.Label();
            this.lDetalleNuevoTitulo = new System.Windows.Forms.Label();
            this.lNombreNuevoTitulo = new System.Windows.Forms.Label();
            this.tbNacionalidadCompania = new System.Windows.Forms.TextBox();
            this.tbDetalleCompania = new System.Windows.Forms.TextBox();
            this.tbNombreCompania = new System.Windows.Forms.TextBox();
            this.lCompaniaTitulo = new System.Windows.Forms.Label();
            this.cbCompanias = new System.Windows.Forms.ComboBox();
            this.rbCrearActualizarCompania = new System.Windows.Forms.RadioButton();
            this.rbSeleccionarCompania = new System.Windows.Forms.RadioButton();
            this.gbSeleccionCategorias = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaCategoriasAgregadas = new System.Windows.Forms.DataGridView();
            this.listaCategoriasDisponibles = new System.Windows.Forms.DataGridView();
            this.bQuitarCategoria = new System.Windows.Forms.Button();
            this.bAgregarCategoria = new System.Windows.Forms.Button();
            this.gbSelectionParticipantesPorCategoria = new System.Windows.Forms.GroupBox();
            this.bQuitarParticipante = new System.Windows.Forms.Button();
            this.bAgregarParticipante = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listaParticipantesSeleccionadosParaCategoria = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.listaParticipantesInscriptos = new System.Windows.Forms.DataGridView();
            this.lDetalleCategoriaDesc = new System.Windows.Forms.Label();
            this.lDetalleParticipante = new System.Windows.Forms.Label();
            this.lRitmoMusicalDesc = new System.Windows.Forms.Label();
            this.lRitmoMusicalTitulo = new System.Windows.Forms.Label();
            this.lCategoriaTitulo = new System.Windows.Forms.Label();
            this.cbCategoriasPorCompania = new System.Windows.Forms.ComboBox();
            this.bAltaParticipante = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSeleccionCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasAgregadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasDisponibles)).BeginInit();
            this.gbSelectionParticipantesPorCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantesSeleccionadosParaCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantesInscriptos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Compañias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bActualizarCompania);
            this.groupBox1.Controls.Add(this.lNacionalidadDesc);
            this.groupBox1.Controls.Add(this.lDetalleDesc);
            this.groupBox1.Controls.Add(this.lNacionalidadTitulo);
            this.groupBox1.Controls.Add(this.lDetalleTitulo);
            this.groupBox1.Controls.Add(this.tbIdCompania);
            this.groupBox1.Controls.Add(this.bGuardarCompania);
            this.groupBox1.Controls.Add(this.lNacionalidadNuevoTitulo);
            this.groupBox1.Controls.Add(this.lDetalleNuevoTitulo);
            this.groupBox1.Controls.Add(this.lNombreNuevoTitulo);
            this.groupBox1.Controls.Add(this.tbNacionalidadCompania);
            this.groupBox1.Controls.Add(this.tbDetalleCompania);
            this.groupBox1.Controls.Add(this.tbNombreCompania);
            this.groupBox1.Controls.Add(this.lCompaniaTitulo);
            this.groupBox1.Controls.Add(this.cbCompanias);
            this.groupBox1.Controls.Add(this.rbCrearActualizarCompania);
            this.groupBox1.Controls.Add(this.rbSeleccionarCompania);
            this.groupBox1.Location = new System.Drawing.Point(43, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1520, 140);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su compañia";
            // 
            // bActualizarCompania
            // 
            this.bActualizarCompania.BackColor = System.Drawing.SystemColors.Control;
            this.bActualizarCompania.Location = new System.Drawing.Point(466, 106);
            this.bActualizarCompania.Name = "bActualizarCompania";
            this.bActualizarCompania.Size = new System.Drawing.Size(121, 23);
            this.bActualizarCompania.TabIndex = 16;
            this.bActualizarCompania.Text = "Modificar compañia";
            this.bActualizarCompania.UseVisualStyleBackColor = false;
            this.bActualizarCompania.Click += new System.EventHandler(this.bActualizarCompania_Click);
            // 
            // lNacionalidadDesc
            // 
            this.lNacionalidadDesc.AutoSize = true;
            this.lNacionalidadDesc.Location = new System.Drawing.Point(146, 117);
            this.lNacionalidadDesc.Name = "lNacionalidadDesc";
            this.lNacionalidadDesc.Size = new System.Drawing.Size(0, 13);
            this.lNacionalidadDesc.TabIndex = 15;
            // 
            // lDetalleDesc
            // 
            this.lDetalleDesc.AutoSize = true;
            this.lDetalleDesc.Location = new System.Drawing.Point(146, 82);
            this.lDetalleDesc.Name = "lDetalleDesc";
            this.lDetalleDesc.Size = new System.Drawing.Size(0, 13);
            this.lDetalleDesc.TabIndex = 14;
            // 
            // lNacionalidadTitulo
            // 
            this.lNacionalidadTitulo.AutoSize = true;
            this.lNacionalidadTitulo.Location = new System.Drawing.Point(33, 114);
            this.lNacionalidadTitulo.Name = "lNacionalidadTitulo";
            this.lNacionalidadTitulo.Size = new System.Drawing.Size(78, 13);
            this.lNacionalidadTitulo.TabIndex = 13;
            this.lNacionalidadTitulo.Text = "Nacionalidad:  ";
            // 
            // lDetalleTitulo
            // 
            this.lDetalleTitulo.AutoSize = true;
            this.lDetalleTitulo.Location = new System.Drawing.Point(33, 82);
            this.lDetalleTitulo.Name = "lDetalleTitulo";
            this.lDetalleTitulo.Size = new System.Drawing.Size(49, 13);
            this.lDetalleTitulo.TabIndex = 12;
            this.lDetalleTitulo.Text = "Detalle:  ";
            // 
            // tbIdCompania
            // 
            this.tbIdCompania.Location = new System.Drawing.Point(1027, 19);
            this.tbIdCompania.Name = "tbIdCompania";
            this.tbIdCompania.Size = new System.Drawing.Size(100, 20);
            this.tbIdCompania.TabIndex = 11;
            this.tbIdCompania.Visible = false;
            // 
            // bGuardarCompania
            // 
            this.bGuardarCompania.BackColor = System.Drawing.SystemColors.Control;
            this.bGuardarCompania.Location = new System.Drawing.Point(1425, 106);
            this.bGuardarCompania.Name = "bGuardarCompania";
            this.bGuardarCompania.Size = new System.Drawing.Size(75, 23);
            this.bGuardarCompania.TabIndex = 10;
            this.bGuardarCompania.Text = "Guardar";
            this.bGuardarCompania.UseVisualStyleBackColor = false;
            this.bGuardarCompania.Click += new System.EventHandler(this.bGuardarCompania_Click);
            // 
            // lNacionalidadNuevoTitulo
            // 
            this.lNacionalidadNuevoTitulo.AutoSize = true;
            this.lNacionalidadNuevoTitulo.Location = new System.Drawing.Point(936, 116);
            this.lNacionalidadNuevoTitulo.Name = "lNacionalidadNuevoTitulo";
            this.lNacionalidadNuevoTitulo.Size = new System.Drawing.Size(69, 13);
            this.lNacionalidadNuevoTitulo.TabIndex = 9;
            this.lNacionalidadNuevoTitulo.Text = "Nacionalidad";
            // 
            // lDetalleNuevoTitulo
            // 
            this.lDetalleNuevoTitulo.AutoSize = true;
            this.lDetalleNuevoTitulo.Location = new System.Drawing.Point(936, 81);
            this.lDetalleNuevoTitulo.Name = "lDetalleNuevoTitulo";
            this.lDetalleNuevoTitulo.Size = new System.Drawing.Size(40, 13);
            this.lDetalleNuevoTitulo.TabIndex = 8;
            this.lDetalleNuevoTitulo.Text = "Detalle";
            // 
            // lNombreNuevoTitulo
            // 
            this.lNombreNuevoTitulo.AutoSize = true;
            this.lNombreNuevoTitulo.Location = new System.Drawing.Point(936, 46);
            this.lNombreNuevoTitulo.Name = "lNombreNuevoTitulo";
            this.lNombreNuevoTitulo.Size = new System.Drawing.Size(44, 13);
            this.lNombreNuevoTitulo.TabIndex = 7;
            this.lNombreNuevoTitulo.Text = "Nombre";
            // 
            // tbNacionalidadCompania
            // 
            this.tbNacionalidadCompania.Location = new System.Drawing.Point(1027, 109);
            this.tbNacionalidadCompania.Name = "tbNacionalidadCompania";
            this.tbNacionalidadCompania.Size = new System.Drawing.Size(364, 20);
            this.tbNacionalidadCompania.TabIndex = 6;
            // 
            // tbDetalleCompania
            // 
            this.tbDetalleCompania.Location = new System.Drawing.Point(1027, 74);
            this.tbDetalleCompania.Name = "tbDetalleCompania";
            this.tbDetalleCompania.Size = new System.Drawing.Size(364, 20);
            this.tbDetalleCompania.TabIndex = 5;
            // 
            // tbNombreCompania
            // 
            this.tbNombreCompania.Location = new System.Drawing.Point(1027, 39);
            this.tbNombreCompania.Name = "tbNombreCompania";
            this.tbNombreCompania.Size = new System.Drawing.Size(364, 20);
            this.tbNombreCompania.TabIndex = 4;
            // 
            // lCompaniaTitulo
            // 
            this.lCompaniaTitulo.AutoSize = true;
            this.lCompaniaTitulo.Location = new System.Drawing.Point(33, 27);
            this.lCompaniaTitulo.Name = "lCompaniaTitulo";
            this.lCompaniaTitulo.Size = new System.Drawing.Size(54, 13);
            this.lCompaniaTitulo.TabIndex = 3;
            this.lCompaniaTitulo.Text = "Compañia";
            // 
            // cbCompanias
            // 
            this.cbCompanias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanias.FormattingEnabled = true;
            this.cbCompanias.Location = new System.Drawing.Point(33, 46);
            this.cbCompanias.Name = "cbCompanias";
            this.cbCompanias.Size = new System.Drawing.Size(554, 21);
            this.cbCompanias.TabIndex = 2;
            this.cbCompanias.SelectedValueChanged += new System.EventHandler(this.cbCompanias_SelectedValueChanged);
            // 
            // rbCrearActualizarCompania
            // 
            this.rbCrearActualizarCompania.AutoSize = true;
            this.rbCrearActualizarCompania.Location = new System.Drawing.Point(783, 19);
            this.rbCrearActualizarCompania.Name = "rbCrearActualizarCompania";
            this.rbCrearActualizarCompania.Size = new System.Drawing.Size(147, 17);
            this.rbCrearActualizarCompania.TabIndex = 1;
            this.rbCrearActualizarCompania.TabStop = true;
            this.rbCrearActualizarCompania.Text = "Crear/Modificar compañia";
            this.rbCrearActualizarCompania.UseVisualStyleBackColor = true;
            this.rbCrearActualizarCompania.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbCrearActualizarCompania_MouseClick);
            // 
            // rbSeleccionarCompania
            // 
            this.rbSeleccionarCompania.AutoSize = true;
            this.rbSeleccionarCompania.Checked = true;
            this.rbSeleccionarCompania.Location = new System.Drawing.Point(611, 19);
            this.rbSeleccionarCompania.Name = "rbSeleccionarCompania";
            this.rbSeleccionarCompania.Size = new System.Drawing.Size(121, 17);
            this.rbSeleccionarCompania.TabIndex = 0;
            this.rbSeleccionarCompania.TabStop = true;
            this.rbSeleccionarCompania.Text = "Selección compañia";
            this.rbSeleccionarCompania.UseVisualStyleBackColor = true;
            this.rbSeleccionarCompania.Click += new System.EventHandler(this.cbCompanias_SelectedValueChanged);
            this.rbSeleccionarCompania.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSeleccionarCompania_MouseClick);
            // 
            // gbSeleccionCategorias
            // 
            this.gbSeleccionCategorias.Controls.Add(this.label2);
            this.gbSeleccionCategorias.Controls.Add(this.label1);
            this.gbSeleccionCategorias.Controls.Add(this.listaCategoriasAgregadas);
            this.gbSeleccionCategorias.Controls.Add(this.listaCategoriasDisponibles);
            this.gbSeleccionCategorias.Controls.Add(this.bQuitarCategoria);
            this.gbSeleccionCategorias.Controls.Add(this.bAgregarCategoria);
            this.gbSeleccionCategorias.Enabled = false;
            this.gbSeleccionCategorias.Location = new System.Drawing.Point(43, 256);
            this.gbSeleccionCategorias.Name = "gbSeleccionCategorias";
            this.gbSeleccionCategorias.Size = new System.Drawing.Size(1520, 240);
            this.gbSeleccionCategorias.TabIndex = 22;
            this.gbSeleccionCategorias.TabStop = false;
            this.gbSeleccionCategorias.Text = "Seleccione todas las categorías en las que competirá la compañia seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(858, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categorias en las que compite esta compañia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Categorias disponibles";
            // 
            // listaCategoriasAgregadas
            // 
            this.listaCategoriasAgregadas.AllowUserToAddRows = false;
            this.listaCategoriasAgregadas.AllowUserToDeleteRows = false;
            this.listaCategoriasAgregadas.AllowUserToResizeColumns = false;
            this.listaCategoriasAgregadas.AllowUserToResizeRows = false;
            this.listaCategoriasAgregadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCategoriasAgregadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCategoriasAgregadas.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaCategoriasAgregadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCategoriasAgregadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasAgregadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.listaCategoriasAgregadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategoriasAgregadas.GridColor = System.Drawing.Color.Indigo;
            this.listaCategoriasAgregadas.Location = new System.Drawing.Point(861, 43);
            this.listaCategoriasAgregadas.Name = "listaCategoriasAgregadas";
            this.listaCategoriasAgregadas.ReadOnly = true;
            this.listaCategoriasAgregadas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasAgregadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.listaCategoriasAgregadas.RowHeadersVisible = false;
            this.listaCategoriasAgregadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.listaCategoriasAgregadas.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.listaCategoriasAgregadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCategoriasAgregadas.Size = new System.Drawing.Size(639, 173);
            this.listaCategoriasAgregadas.TabIndex = 11;
            // 
            // listaCategoriasDisponibles
            // 
            this.listaCategoriasDisponibles.AllowUserToAddRows = false;
            this.listaCategoriasDisponibles.AllowUserToDeleteRows = false;
            this.listaCategoriasDisponibles.AllowUserToResizeColumns = false;
            this.listaCategoriasDisponibles.AllowUserToResizeRows = false;
            this.listaCategoriasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCategoriasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaCategoriasDisponibles.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaCategoriasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCategoriasDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.listaCategoriasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCategoriasDisponibles.GridColor = System.Drawing.Color.Indigo;
            this.listaCategoriasDisponibles.Location = new System.Drawing.Point(33, 43);
            this.listaCategoriasDisponibles.Name = "listaCategoriasDisponibles";
            this.listaCategoriasDisponibles.ReadOnly = true;
            this.listaCategoriasDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaCategoriasDisponibles.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.listaCategoriasDisponibles.RowHeadersVisible = false;
            this.listaCategoriasDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.listaCategoriasDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.listaCategoriasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCategoriasDisponibles.Size = new System.Drawing.Size(653, 173);
            this.listaCategoriasDisponibles.TabIndex = 10;
            // 
            // bQuitarCategoria
            // 
            this.bQuitarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.bQuitarCategoria.Location = new System.Drawing.Point(729, 179);
            this.bQuitarCategoria.Name = "bQuitarCategoria";
            this.bQuitarCategoria.Size = new System.Drawing.Size(87, 43);
            this.bQuitarCategoria.TabIndex = 3;
            this.bQuitarCategoria.Text = "<< Quitar";
            this.bQuitarCategoria.UseVisualStyleBackColor = false;
            this.bQuitarCategoria.Click += new System.EventHandler(this.bQuitarCategoria_Click);
            // 
            // bAgregarCategoria
            // 
            this.bAgregarCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.bAgregarCategoria.Location = new System.Drawing.Point(729, 99);
            this.bAgregarCategoria.Name = "bAgregarCategoria";
            this.bAgregarCategoria.Size = new System.Drawing.Size(87, 43);
            this.bAgregarCategoria.TabIndex = 2;
            this.bAgregarCategoria.Text = "Agregar >>";
            this.bAgregarCategoria.UseVisualStyleBackColor = false;
            this.bAgregarCategoria.Click += new System.EventHandler(this.bAgregarCategoria_Click);
            // 
            // gbSelectionParticipantesPorCategoria
            // 
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.bAltaParticipante);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.bQuitarParticipante);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.bAgregarParticipante);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.label7);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.listaParticipantesSeleccionadosParaCategoria);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.label6);
            this.gbSelectionParticipantesPorCategoria.Controls.Add(this.listaParticipantesInscriptos);
            this.gbSelectionParticipantesPorCategoria.Enabled = false;
            this.gbSelectionParticipantesPorCategoria.Location = new System.Drawing.Point(43, 550);
            this.gbSelectionParticipantesPorCategoria.Name = "gbSelectionParticipantesPorCategoria";
            this.gbSelectionParticipantesPorCategoria.Size = new System.Drawing.Size(1520, 249);
            this.gbSelectionParticipantesPorCategoria.TabIndex = 23;
            this.gbSelectionParticipantesPorCategoria.TabStop = false;
            this.gbSelectionParticipantesPorCategoria.Text = "Seleccione la categoría y a cada uno de los participantes de cada compañia";
            // 
            // bQuitarParticipante
            // 
            this.bQuitarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.bQuitarParticipante.Enabled = false;
            this.bQuitarParticipante.Location = new System.Drawing.Point(732, 137);
            this.bQuitarParticipante.Name = "bQuitarParticipante";
            this.bQuitarParticipante.Size = new System.Drawing.Size(87, 43);
            this.bQuitarParticipante.TabIndex = 24;
            this.bQuitarParticipante.Text = "<< Quitar";
            this.bQuitarParticipante.UseVisualStyleBackColor = false;
            this.bQuitarParticipante.Click += new System.EventHandler(this.bQuitarParticipante_Click);
            // 
            // bAgregarParticipante
            // 
            this.bAgregarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.bAgregarParticipante.Enabled = false;
            this.bAgregarParticipante.Location = new System.Drawing.Point(732, 57);
            this.bAgregarParticipante.Name = "bAgregarParticipante";
            this.bAgregarParticipante.Size = new System.Drawing.Size(87, 43);
            this.bAgregarParticipante.TabIndex = 23;
            this.bAgregarParticipante.Text = "Agregar >>";
            this.bAgregarParticipante.UseVisualStyleBackColor = false;
            this.bAgregarParticipante.Click += new System.EventHandler(this.bAgregarParticipante_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(861, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Participantes seleccionados por la compañia para esta categoría";
            // 
            // listaParticipantesSeleccionadosParaCategoria
            // 
            this.listaParticipantesSeleccionadosParaCategoria.AllowUserToAddRows = false;
            this.listaParticipantesSeleccionadosParaCategoria.AllowUserToDeleteRows = false;
            this.listaParticipantesSeleccionadosParaCategoria.AllowUserToResizeColumns = false;
            this.listaParticipantesSeleccionadosParaCategoria.AllowUserToResizeRows = false;
            this.listaParticipantesSeleccionadosParaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaParticipantesSeleccionadosParaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaParticipantesSeleccionadosParaCategoria.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaParticipantesSeleccionadosParaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaParticipantesSeleccionadosParaCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantesSeleccionadosParaCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.listaParticipantesSeleccionadosParaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaParticipantesSeleccionadosParaCategoria.GridColor = System.Drawing.Color.Indigo;
            this.listaParticipantesSeleccionadosParaCategoria.Location = new System.Drawing.Point(864, 57);
            this.listaParticipantesSeleccionadosParaCategoria.Name = "listaParticipantesSeleccionadosParaCategoria";
            this.listaParticipantesSeleccionadosParaCategoria.ReadOnly = true;
            this.listaParticipantesSeleccionadosParaCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantesSeleccionadosParaCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.listaParticipantesSeleccionadosParaCategoria.RowHeadersVisible = false;
            this.listaParticipantesSeleccionadosParaCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.listaParticipantesSeleccionadosParaCategoria.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.listaParticipantesSeleccionadosParaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaParticipantesSeleccionadosParaCategoria.Size = new System.Drawing.Size(639, 162);
            this.listaParticipantesSeleccionadosParaCategoria.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Participantes inscriptos";
            // 
            // listaParticipantesInscriptos
            // 
            this.listaParticipantesInscriptos.AllowUserToAddRows = false;
            this.listaParticipantesInscriptos.AllowUserToDeleteRows = false;
            this.listaParticipantesInscriptos.AllowUserToResizeColumns = false;
            this.listaParticipantesInscriptos.AllowUserToResizeRows = false;
            this.listaParticipantesInscriptos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaParticipantesInscriptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaParticipantesInscriptos.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listaParticipantesInscriptos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaParticipantesInscriptos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantesInscriptos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.listaParticipantesInscriptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaParticipantesInscriptos.GridColor = System.Drawing.Color.Indigo;
            this.listaParticipantesInscriptos.Location = new System.Drawing.Point(36, 57);
            this.listaParticipantesInscriptos.Name = "listaParticipantesInscriptos";
            this.listaParticipantesInscriptos.ReadOnly = true;
            this.listaParticipantesInscriptos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaParticipantesInscriptos.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.listaParticipantesInscriptos.RowHeadersVisible = false;
            this.listaParticipantesInscriptos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.listaParticipantesInscriptos.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.listaParticipantesInscriptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaParticipantesInscriptos.Size = new System.Drawing.Size(653, 162);
            this.listaParticipantesInscriptos.TabIndex = 19;
            // 
            // lDetalleCategoriaDesc
            // 
            this.lDetalleCategoriaDesc.AutoSize = true;
            this.lDetalleCategoriaDesc.Enabled = false;
            this.lDetalleCategoriaDesc.Location = new System.Drawing.Point(921, 523);
            this.lDetalleCategoriaDesc.Name = "lDetalleCategoriaDesc";
            this.lDetalleCategoriaDesc.Size = new System.Drawing.Size(0, 13);
            this.lDetalleCategoriaDesc.TabIndex = 18;
            // 
            // lDetalleParticipante
            // 
            this.lDetalleParticipante.AutoSize = true;
            this.lDetalleParticipante.Enabled = false;
            this.lDetalleParticipante.Location = new System.Drawing.Point(863, 523);
            this.lDetalleParticipante.Name = "lDetalleParticipante";
            this.lDetalleParticipante.Size = new System.Drawing.Size(43, 13);
            this.lDetalleParticipante.TabIndex = 17;
            this.lDetalleParticipante.Text = "Detalle:";
            // 
            // lRitmoMusicalDesc
            // 
            this.lRitmoMusicalDesc.AutoSize = true;
            this.lRitmoMusicalDesc.Enabled = false;
            this.lRitmoMusicalDesc.Location = new System.Drawing.Point(740, 523);
            this.lRitmoMusicalDesc.Name = "lRitmoMusicalDesc";
            this.lRitmoMusicalDesc.Size = new System.Drawing.Size(0, 13);
            this.lRitmoMusicalDesc.TabIndex = 16;
            // 
            // lRitmoMusicalTitulo
            // 
            this.lRitmoMusicalTitulo.AutoSize = true;
            this.lRitmoMusicalTitulo.Enabled = false;
            this.lRitmoMusicalTitulo.Location = new System.Drawing.Point(651, 523);
            this.lRitmoMusicalTitulo.Name = "lRitmoMusicalTitulo";
            this.lRitmoMusicalTitulo.Size = new System.Drawing.Size(76, 13);
            this.lRitmoMusicalTitulo.TabIndex = 15;
            this.lRitmoMusicalTitulo.Text = "Ritmo Musical:";
            // 
            // lCategoriaTitulo
            // 
            this.lCategoriaTitulo.AutoSize = true;
            this.lCategoriaTitulo.Enabled = false;
            this.lCategoriaTitulo.Location = new System.Drawing.Point(76, 523);
            this.lCategoriaTitulo.Name = "lCategoriaTitulo";
            this.lCategoriaTitulo.Size = new System.Drawing.Size(54, 13);
            this.lCategoriaTitulo.TabIndex = 4;
            this.lCategoriaTitulo.Text = "Categoría";
            // 
            // cbCategoriasPorCompania
            // 
            this.cbCategoriasPorCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriasPorCompania.Enabled = false;
            this.cbCategoriasPorCompania.FormattingEnabled = true;
            this.cbCategoriasPorCompania.Location = new System.Drawing.Point(136, 515);
            this.cbCategoriasPorCompania.Name = "cbCategoriasPorCompania";
            this.cbCategoriasPorCompania.Size = new System.Drawing.Size(494, 21);
            this.cbCategoriasPorCompania.TabIndex = 3;
            this.cbCategoriasPorCompania.SelectedValueChanged += new System.EventHandler(this.cbCategoriasPorCompania_SelectedValueChanged);
            // 
            // bAltaParticipante
            // 
            this.bAltaParticipante.Location = new System.Drawing.Point(665, 28);
            this.bAltaParticipante.Name = "bAltaParticipante";
            this.bAltaParticipante.Size = new System.Drawing.Size(24, 23);
            this.bAltaParticipante.TabIndex = 25;
            this.bAltaParticipante.Text = "+";
            this.bAltaParticipante.UseVisualStyleBackColor = true;
            this.bAltaParticipante.Click += new System.EventHandler(this.bAltaParticipante_Click);
            // 
            // frmCompanias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.gbSelectionParticipantesPorCategoria);
            this.Controls.Add(this.gbSeleccionCategorias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lCategoriaTitulo);
            this.Controls.Add(this.cbCategoriasPorCompania);
            this.Controls.Add(this.lDetalleCategoriaDesc);
            this.Controls.Add(this.lRitmoMusicalTitulo);
            this.Controls.Add(this.lDetalleParticipante);
            this.Controls.Add(this.lRitmoMusicalDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanias";
            this.Text = "frmCompanias";
            this.Load += new System.EventHandler(this.frmCompanias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSeleccionCategorias.ResumeLayout(false);
            this.gbSeleccionCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasAgregadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasDisponibles)).EndInit();
            this.gbSelectionParticipantesPorCategoria.ResumeLayout(false);
            this.gbSelectionParticipantesPorCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantesSeleccionadosParaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantesInscriptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbCrearActualizarCompania;
        private RadioButton rbSeleccionarCompania;
        private Label lCompaniaTitulo;
        private ComboBox cbCompanias;
        private Label lNacionalidadNuevoTitulo;
        private Label lDetalleNuevoTitulo;
        private Label lNombreNuevoTitulo;
        private TextBox tbNacionalidadCompania;
        private TextBox tbDetalleCompania;
        private TextBox tbNombreCompania;
        private Button bGuardarCompania;
        private TextBox tbIdCompania;
        private Label lNacionalidadTitulo;
        private Label lDetalleTitulo;
        private Label lNacionalidadDesc;
        private Label lDetalleDesc;
        private Button bActualizarCompania;
        private GroupBox gbSeleccionCategorias;
        private Button bQuitarCategoria;
        private Button bAgregarCategoria;
        private DataGridView listaCategoriasAgregadas;
        private DataGridView listaCategoriasDisponibles;
        private Label label1;
        private Label label2;
        private GroupBox gbSelectionParticipantesPorCategoria;
        private ComboBox cbCategoriasPorCompania;
        private Label lCategoriaTitulo;
        private Label lRitmoMusicalDesc;
        private Label lRitmoMusicalTitulo;
        private Label lDetalleCategoriaDesc;
        private Label lDetalleParticipante;
        private Button bQuitarParticipante;
        private Button bAgregarParticipante;
        private Label label7;
        private DataGridView listaParticipantesSeleccionadosParaCategoria;
        private Label label6;
        private DataGridView listaParticipantesInscriptos;
        private Button bAltaParticipante;
    }
}