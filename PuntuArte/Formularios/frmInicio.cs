using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    public partial class frmInicio : Form
    {
        Panel p = new Panel();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromName("Indigo");
            p.Size = new Size(140, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmParticipantes());
            abrirCerrarMenuABM();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirCerrarMenuABM();
        }

        private void abrirCerrarMenuABM()
        {
            if (pABM.Visible)
                pABM.Visible = false;
            else
                pABM.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void abrirFormHijo(object formHijo)
        {
            //if para que no cierre el menu de ABM
            if (this.pVisualizador.Controls.Count > 0)
            {
                foreach (Control iControl in this.pVisualizador.Controls)
                {
                    if (iControl.Name != this.pABM.Name)
                        this.pVisualizador.Controls.Remove(iControl);
                }
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pVisualizador.Controls.Add(fh);
            this.pVisualizador.Tag = fh;
            fh.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCompanias());
            abrirCerrarMenuABM();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCategoria());
            abrirCerrarMenuABM();
        }

    }
}
