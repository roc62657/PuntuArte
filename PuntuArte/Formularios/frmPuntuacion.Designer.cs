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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.listaItemsJurados = new System.Windows.Forms.DataGridView();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.cbCompanias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsJurados)).BeginInit();
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
            // listaItemsJurados
            // 
            this.listaItemsJurados.AllowUserToAddRows = false;
            this.listaItemsJurados.AllowUserToDeleteRows = false;
            this.listaItemsJurados.AllowUserToResizeColumns = false;
            this.listaItemsJurados.AllowUserToResizeRows = false;
            this.listaItemsJurados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listaItemsJurados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaItemsJurados.BackgroundColor = System.Drawing.Color.MistyRose;
            this.listaItemsJurados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaItemsJurados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsJurados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaItemsJurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaItemsJurados.EnableHeadersVisualStyles = false;
            this.listaItemsJurados.GridColor = System.Drawing.Color.Indigo;
            this.listaItemsJurados.Location = new System.Drawing.Point(40, 290);
            this.listaItemsJurados.MultiSelect = false;
            this.listaItemsJurados.Name = "listaItemsJurados";
            this.listaItemsJurados.ReadOnly = true;
            this.listaItemsJurados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaItemsJurados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listaItemsJurados.RowHeadersVisible = false;
            this.listaItemsJurados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.listaItemsJurados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.listaItemsJurados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.listaItemsJurados.Size = new System.Drawing.Size(1523, 483);
            this.listaItemsJurados.TabIndex = 12;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(175, 136);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(329, 21);
            this.cbCategorias.TabIndex = 13;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // cbCompanias
            // 
            this.cbCompanias.FormattingEnabled = true;
            this.cbCompanias.Location = new System.Drawing.Point(590, 136);
            this.cbCompanias.Name = "cbCompanias";
            this.cbCompanias.Size = new System.Drawing.Size(121, 21);
            this.cbCompanias.TabIndex = 14;
            this.cbCompanias.SelectedIndexChanged += new System.EventHandler(this.cbCompanias_SelectedIndexChanged);
            // 
            // frmPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1617, 811);
            this.Controls.Add(this.cbCompanias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.listaItemsJurados);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntuacion";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmPuntuacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaItemsJurados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private DataGridView listaItemsJurados;
        private ComboBox cbCategorias;
        private ComboBox cbCompanias;
    }
}