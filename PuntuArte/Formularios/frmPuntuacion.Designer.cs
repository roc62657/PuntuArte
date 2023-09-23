using System.Drawing;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    partial class frmPuntuacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgPuntuaciones = new System.Windows.Forms.DataGridView();
            this.JuradoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuradoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbComp = new System.Windows.Forms.Label();
            this.lbCompania = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompania = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPuntuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Puntuaciones";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(175, 91);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(329, 21);
            this.cbCategorias.TabIndex = 13;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(59, 94);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(110, 13);
            this.lbCategoria.TabIndex = 14;
            this.lbCategoria.Text = "Seleccione categoria:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 811);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // dgPuntuaciones
            // 
            this.dgPuntuaciones.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgPuntuaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPuntuaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPuntuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPuntuaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JuradoId,
            this.JuradoNombre});
            this.dgPuntuaciones.Location = new System.Drawing.Point(490, 284);
            this.dgPuntuaciones.Name = "dgPuntuaciones";
            this.dgPuntuaciones.Size = new System.Drawing.Size(482, 276);
            this.dgPuntuaciones.TabIndex = 16;
            // 
            // JuradoId
            // 
            this.JuradoId.Frozen = true;
            this.JuradoId.HeaderText = "JuradoId";
            this.JuradoId.Name = "JuradoId";
            this.JuradoId.Visible = false;
            // 
            // JuradoNombre
            // 
            this.JuradoNombre.Frozen = true;
            this.JuradoNombre.HeaderText = "Jurado";
            this.JuradoNombre.Name = "JuradoNombre";
            this.JuradoNombre.ReadOnly = true;
            // 
            // lbComp
            // 
            this.lbComp.AutoSize = true;
            this.lbComp.Location = new System.Drawing.Point(39, 176);
            this.lbComp.Name = "lbComp";
            this.lbComp.Size = new System.Drawing.Size(13, 13);
            this.lbComp.TabIndex = 19;
            this.lbComp.Text = "0";
            this.lbComp.Visible = false;
            // 
            // lbCompania
            // 
            this.lbCompania.AutoSize = true;
            this.lbCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompania.Location = new System.Drawing.Point(59, 175);
            this.lbCompania.Name = "lbCompania";
            this.lbCompania.Size = new System.Drawing.Size(0, 31);
            this.lbCompania.TabIndex = 20;
            // 
            // btEnviar
            // 
            this.btEnviar.Location = new System.Drawing.Point(478, 625);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(125, 27);
            this.btEnviar.TabIndex = 21;
            this.btEnviar.Text = "Enviar Puntuacion";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Seleccione compañia:";
            // 
            // cbCompania
            // 
            this.cbCompania.FormattingEnabled = true;
            this.cbCompania.Location = new System.Drawing.Point(174, 132);
            this.cbCompania.Name = "cbCompania";
            this.cbCompania.Size = new System.Drawing.Size(329, 21);
            this.cbCompania.TabIndex = 23;
            this.cbCompania.SelectedIndexChanged += new System.EventHandler(this.cbCompania_SelectedIndexChanged);
            // 
            // frmPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.cbCompania);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.lbCompania);
            this.Controls.Add(this.lbComp);
            this.Controls.Add(this.dgPuntuaciones);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntuacion";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmPuntuacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPuntuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private ComboBox cbCategorias;
        private Label lbCategoria;
        private Splitter splitter1;
        private DataGridView dgPuntuaciones;
        private Label lbComp;
        private Label lbCompania;
        private Button btEnviar;
        private Label label1;
        private ComboBox cbCompania;
        private DataGridViewTextBoxColumn JuradoId;
        private DataGridViewTextBoxColumn JuradoNombre;
    }
}