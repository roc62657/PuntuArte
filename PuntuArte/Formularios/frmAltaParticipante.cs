using PuntuArte.ConexionDDBB;
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
        public delegate void borrarParticipante(int participante);
        public event agregarParticipante crearModificarParticipante;
        public event borrarParticipante eliminarParticipante;
        public frmAltaParticipante()
        {
            InitializeComponent();
        }

        public frmAltaParticipante(int idParticipante)
        {
            InitializeComponent();

            Participantes participante = ParticipantesConexion.Instancia.obtenerParticipantePorId(idParticipante);
            tIdParticipante.Text = participante.IDParticipante.ToString();
            tNombreParticipante.Text = participante.Nombre;
            tApellidoParticipante.Text = participante.Apellido;
            tTipoDocParticipante.Text = participante.TipoDocumento;
            tNroDocParticipante.Text = participante.NroDocumento;
            tNacionalidadParticipante.Text = participante.Nacionalidad;
            tNroTelefonoParticipante.Text = participante.NroTelefono;

            bEliminarParticipante.Visible = true;
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
                    IDParticipante = tIdParticipante.Text == "" || tIdParticipante.Text == "0" ? 0 : int.Parse(tIdParticipante.Text),
                    Nombre = tNombreParticipante.Text,
                    Apellido = tApellidoParticipante.Text,
                    TipoDocumento = tTipoDocParticipante.Text,
                    NroDocumento = tNroDocParticipante.Text,
                    Nacionalidad = tNacionalidadParticipante.Text,
                    NroTelefono = tNroTelefonoParticipante.Text,
                    Rol = "Participante"
                };

                crearModificarParticipante(participantes);
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

        private void bEliminarParticipante_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar este participante?. En caso de aceptar, se eliminará el participante y todas las categorias asociadas", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                eliminarParticipante(int.Parse(tIdParticipante.Text));
                this.Dispose();
            }
        }
    }
}
