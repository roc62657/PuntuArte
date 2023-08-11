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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarParticipante = new System.Windows.Forms.Button();
            this.btnActualizarParticipante = new System.Windows.Forms.Button();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.gbParticipantes = new System.Windows.Forms.GroupBox();
            this.tbIdParticipante = new System.Windows.Forms.TextBox();
            this.cbTipoDocParticipante = new System.Windows.Forms.ComboBox();
            this.cbRolParticipante = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTelefonoParticipante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.gbParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarParticipante
            // 
            this.btnEliminarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarParticipante.Enabled = false;
            this.btnEliminarParticipante.Location = new System.Drawing.Point(874, 361);
            this.btnEliminarParticipante.Name = "btnEliminarParticipante";
            this.btnEliminarParticipante.Size = new System.Drawing.Size(156, 23);
            this.btnEliminarParticipante.TabIndex = 18;
            this.btnEliminarParticipante.Text = "Eliminar";
            this.btnEliminarParticipante.UseVisualStyleBackColor = false;
            // 
            // btnActualizarParticipante
            // 
            this.btnActualizarParticipante.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarParticipante.Enabled = false;
            this.btnActualizarParticipante.Location = new System.Drawing.Point(703, 361);
            this.btnActualizarParticipante.Name = "btnActualizarParticipante";
            this.btnActualizarParticipante.Size = new System.Drawing.Size(156, 23);
            this.btnActualizarParticipante.TabIndex = 17;
            this.btnActualizarParticipante.Text = "Actualizar seleccionado";
            this.btnActualizarParticipante.UseVisualStyleBackColor = false;
            this.btnActualizarParticipante.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearCategoria.Location = new System.Drawing.Point(522, 361);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(156, 23);
            this.btnCrearCategoria.TabIndex = 16;
            this.btnCrearCategoria.Text = "Crear nuevo";
            this.btnCrearCategoria.UseVisualStyleBackColor = false;
            this.btnCrearCategoria.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // gbParticipantes
            // 
            this.gbParticipantes.Controls.Add(this.tbIdParticipante);
            this.gbParticipantes.Controls.Add(this.cbTipoDocParticipante);
            this.gbParticipantes.Controls.Add(this.cbRolParticipante);
            this.gbParticipantes.Controls.Add(this.label8);
            this.gbParticipantes.Controls.Add(this.tbTelefonoParticipante);
            this.gbParticipantes.Controls.Add(this.label5);
            this.gbParticipantes.Controls.Add(this.label6);
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
            this.gbParticipantes.Location = new System.Drawing.Point(24, 390);
            this.gbParticipantes.Name = "gbParticipantes";
            this.gbParticipantes.Size = new System.Drawing.Size(1067, 152);
            this.gbParticipantes.TabIndex = 15;
            this.gbParticipantes.TabStop = false;
            this.gbParticipantes.Text = "Altas / Modificaciones";
            // 
            // tbIdParticipante
            // 
            this.tbIdParticipante.Location = new System.Drawing.Point(884, 20);
            this.tbIdParticipante.Name = "tbIdParticipante";
            this.tbIdParticipante.Size = new System.Drawing.Size(75, 20);
            this.tbIdParticipante.TabIndex = 19;
            this.tbIdParticipante.Visible = false;
            // 
            // cbTipoDocParticipante
            // 
            this.cbTipoDocParticipante.FormattingEnabled = true;
            this.cbTipoDocParticipante.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Tarjeta de residencia"});
            this.cbTipoDocParticipante.Location = new System.Drawing.Point(617, 22);
            this.cbTipoDocParticipante.Name = "cbTipoDocParticipante";
            this.cbTipoDocParticipante.Size = new System.Drawing.Size(198, 21);
            this.cbTipoDocParticipante.TabIndex = 18;
            this.cbTipoDocParticipante.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocParticipante_SelectedIndexChanged);
            // 
            // cbRolParticipante
            // 
            this.cbRolParticipante.FormattingEnabled = true;
            this.cbRolParticipante.Items.AddRange(new object[] {
            "Competidor",
            "Jurado"});
            this.cbRolParticipante.Location = new System.Drawing.Point(617, 89);
            this.cbRolParticipante.Name = "cbRolParticipante";
            this.cbRolParticipante.Size = new System.Drawing.Size(198, 21);
            this.cbRolParticipante.TabIndex = 17;
            this.cbRolParticipante.SelectedIndexChanged += new System.EventHandler(this.cbRolParticipante_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nro Tel";
            // 
            // tbTelefonoParticipante
            // 
            this.tbTelefonoParticipante.Location = new System.Drawing.Point(211, 121);
            this.tbTelefonoParticipante.Name = "tbTelefonoParticipante";
            this.tbTelefonoParticipante.Size = new System.Drawing.Size(198, 20);
            this.tbTelefonoParticipante.TabIndex = 16;
            this.tbTelefonoParticipante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefonoParticipante_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Doc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nro Doc";
            // 
            // tbNroDocParticipante
            // 
            this.tbNroDocParticipante.Location = new System.Drawing.Point(617, 55);
            this.tbNroDocParticipante.Name = "tbNroDocParticipante";
            this.tbNroDocParticipante.Size = new System.Drawing.Size(198, 20);
            this.tbNroDocParticipante.TabIndex = 13;
            this.tbNroDocParticipante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroDocParticipante_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // tbNombreParticipante
            // 
            this.tbNombreParticipante.Location = new System.Drawing.Point(211, 23);
            this.tbNombreParticipante.Name = "tbNombreParticipante";
            this.tbNombreParticipante.Size = new System.Drawing.Size(198, 20);
            this.tbNombreParticipante.TabIndex = 4;
            this.tbNombreParticipante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreParticipante_KeyPress);
            // 
            // guardarParticipante
            // 
            this.guardarParticipante.BackColor = System.Drawing.Color.White;
            this.guardarParticipante.Enabled = false;
            this.guardarParticipante.Location = new System.Drawing.Point(884, 85);
            this.guardarParticipante.Name = "guardarParticipante";
            this.guardarParticipante.Size = new System.Drawing.Size(75, 23);
            this.guardarParticipante.TabIndex = 7;
            this.guardarParticipante.Text = "Guardar";
            this.guardarParticipante.UseVisualStyleBackColor = false;
            this.guardarParticipante.Click += new System.EventHandler(this.guardarCategoria_Click);
            // 
            // tbApellidoParticipante
            // 
            this.tbApellidoParticipante.Location = new System.Drawing.Point(211, 55);
            this.tbApellidoParticipante.Name = "tbApellidoParticipante";
            this.tbApellidoParticipante.Size = new System.Drawing.Size(198, 20);
            this.tbApellidoParticipante.TabIndex = 5;
            this.tbApellidoParticipante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoParticipante_KeyPress);
            // 
            // tbNacionalidadParticipante
            // 
            this.tbNacionalidadParticipante.Location = new System.Drawing.Point(211, 90);
            this.tbNacionalidadParticipante.Name = "tbNacionalidadParticipante";
            this.tbNacionalidadParticipante.Size = new System.Drawing.Size(198, 20);
            this.tbNacionalidadParticipante.TabIndex = 6;
            this.tbNacionalidadParticipante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNacionalidadParticipante_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Participantes";
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
            this.listaParticipantes.Location = new System.Drawing.Point(38, 82);
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
            this.listaParticipantes.Size = new System.Drawing.Size(1044, 254);
            this.listaParticipantes.TabIndex = 19;
            this.listaParticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaParticipantes_CellClick);
            // 
            // frmParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1123, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaParticipantes);
            this.Controls.Add(this.btnEliminarParticipante);
            this.Controls.Add(this.btnActualizarParticipante);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.gbParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParticipantes";
            this.Text = "frmParticipantes";
            this.Load += new System.EventHandler(this.frmParticipantes_Load);
            this.gbParticipantes.ResumeLayout(false);
            this.gbParticipantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEliminarParticipante;
        private Button btnActualizarParticipante;
        private Button btnCrearCategoria;
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
        private Label label6;
        private Label label7;
        private TextBox tbNroDocParticipante;
        private ComboBox cbTipoDocParticipante;
        private ComboBox cbRolParticipante;
        private TextBox tbIdParticipante;
    }
}