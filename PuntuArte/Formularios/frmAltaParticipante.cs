using PuntuArte.Modelo;
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
    public partial class frmAltaParticipante : Form
    {
        public delegate void agregarParticipante(Participantes participante);
        public event agregarParticipante crearParticipante;
        public frmAltaParticipante()
        {
            InitializeComponent();
        }

        private void bAltaParticipante_Click(object sender, EventArgs e)
        {
            if (tNombreParticipante.Text != "" &&
                tApellidoParticipante.Text != "" &&
                tTipoDocParticipante.Text != "" &&
                tNroDocParticipante.Text != "" &&
                tNacionalidadParticipante.Text != "" &&
                tNroTelefonoParticipante.Text != "" 
                )
            {
                Participantes participantes = new Participantes()
                {
                    Nombre = tNombreParticipante.Text,
                    Apellido = tApellidoParticipante.Text,
                    TipoDocumento = tTipoDocParticipante.Text,
                    NroDocumento = tNroDocParticipante.Text,
                    Nacionalidad = tNacionalidadParticipante.Text,
                    NroTelefono = tNroTelefonoParticipante.Text,
                    Rol = "Participante"
                };
                crearParticipante(participantes);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos de participantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
