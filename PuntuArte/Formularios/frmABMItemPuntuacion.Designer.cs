namespace PuntuArte.Formularios
{
    partial class frmABMItemPuntuacion
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
            this.tNombreItemPuntuacion = new System.Windows.Forms.TextBox();
            this.tDetalleItemPuntuacion = new System.Windows.Forms.TextBox();
            this.bAltaItemPuntuacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tIdItemPuntuacion = new System.Windows.Forms.TextBox();
            this.bEliminarItemPuntuacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tNombreItemPuntuacion
            // 
            this.tNombreItemPuntuacion.Location = new System.Drawing.Point(233, 86);
            this.tNombreItemPuntuacion.Name = "tNombreItemPuntuacion";
            this.tNombreItemPuntuacion.Size = new System.Drawing.Size(301, 20);
            this.tNombreItemPuntuacion.TabIndex = 0;
            // 
            // tDetalleItemPuntuacion
            // 
            this.tDetalleItemPuntuacion.Location = new System.Drawing.Point(233, 122);
            this.tDetalleItemPuntuacion.Multiline = true;
            this.tDetalleItemPuntuacion.Name = "tDetalleItemPuntuacion";
            this.tDetalleItemPuntuacion.Size = new System.Drawing.Size(301, 62);
            this.tDetalleItemPuntuacion.TabIndex = 1;
            // 
            // bAltaItemPuntuacion
            // 
            this.bAltaItemPuntuacion.Location = new System.Drawing.Point(233, 224);
            this.bAltaItemPuntuacion.Name = "bAltaItemPuntuacion";
            this.bAltaItemPuntuacion.Size = new System.Drawing.Size(98, 31);
            this.bAltaItemPuntuacion.TabIndex = 7;
            this.bAltaItemPuntuacion.Text = "Guardar";
            this.bAltaItemPuntuacion.UseVisualStyleBackColor = true;
            this.bAltaItemPuntuacion.Click += new System.EventHandler(this.bAltaItemPuntuacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalle";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(395, 224);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(98, 31);
            this.bCancelar.TabIndex = 14;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(101, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 37);
            this.label7.TabIndex = 21;
            this.label7.Text = "Datos del Item de puntuacion";
            // 
            // tIdItemPuntuacion
            // 
            this.tIdItemPuntuacion.Location = new System.Drawing.Point(540, 85);
            this.tIdItemPuntuacion.Name = "tIdItemPuntuacion";
            this.tIdItemPuntuacion.Size = new System.Drawing.Size(60, 20);
            this.tIdItemPuntuacion.TabIndex = 22;
            this.tIdItemPuntuacion.Visible = false;
            // 
            // bEliminarItemPuntuacion
            // 
            this.bEliminarItemPuntuacion.BackColor = System.Drawing.Color.Brown;
            this.bEliminarItemPuntuacion.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bEliminarItemPuntuacion.FlatAppearance.BorderSize = 0;
            this.bEliminarItemPuntuacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarItemPuntuacion.ForeColor = System.Drawing.Color.White;
            this.bEliminarItemPuntuacion.Location = new System.Drawing.Point(76, 224);
            this.bEliminarItemPuntuacion.Name = "bEliminarItemPuntuacion";
            this.bEliminarItemPuntuacion.Size = new System.Drawing.Size(98, 31);
            this.bEliminarItemPuntuacion.TabIndex = 23;
            this.bEliminarItemPuntuacion.Text = "Eliminar";
            this.bEliminarItemPuntuacion.UseVisualStyleBackColor = false;
            this.bEliminarItemPuntuacion.Visible = false;
            this.bEliminarItemPuntuacion.Click += new System.EventHandler(this.bEliminarItemPuntuacion_Click);
            // 
            // frmABMItemPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(630, 296);
            this.Controls.Add(this.bEliminarItemPuntuacion);
            this.Controls.Add(this.tIdItemPuntuacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAltaItemPuntuacion);
            this.Controls.Add(this.tDetalleItemPuntuacion);
            this.Controls.Add(this.tNombreItemPuntuacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmABMItemPuntuacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaItemPuntuacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombreItemPuntuacion;
        private System.Windows.Forms.TextBox tDetalleItemPuntuacion;
        private System.Windows.Forms.Button bAltaItemPuntuacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tIdItemPuntuacion;
        private System.Windows.Forms.Button bEliminarItemPuntuacion;
    }
}