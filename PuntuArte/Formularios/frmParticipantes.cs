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
    public partial class frmParticipantes : Form
    {
        public frmParticipantes()
        {
            InitializeComponent();
        }

        private void frmParticipantes_Load(object sender, EventArgs e)
        {
            mostrarParticipantes();
        }

        private void guardarCategoria_Click(object sender, EventArgs e)
        {
            Participantes participante = new Participantes()
            {
                Nombre = tbNombreParticipante.Text,
                Apellido = tbApellidoParticipante.Text,
                TipoDocumento = cbTipoDocParticipante.Text,
                NroDocumento = tbNroDocParticipante.Text,
                Nacionalidad = tbNacionalidadParticipante.Text,
                NroTelefono = tbTelefonoParticipante.Text,
                Rol = cbRolParticipante.Text
            };

            bool respuesta = false;
            if (tbIdParticipante.Text == "") // es nuevo si no tiene ID
            {
                respuesta = ParticipantesConexion.Instancia.guardarParticipante(participante);
            }
            else
            {
                participante.IDParticipante = int.Parse(tbIdParticipante.Text);
                respuesta = ParticipantesConexion.Instancia.actualizarParticipante(participante);
            }

            //Recarga grilla
            if (respuesta)
                mostrarParticipantes();

            //Limpia controles e inhabilita sector alta y modificacion
            gbParticipantes.Enabled = false;
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            cbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
            cbRolParticipante.Text = "";
            guardarParticipante.Enabled = false;
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            gbParticipantes.Enabled = true;
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            cbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
            cbRolParticipante.Text = "";
        }

        private void tbNombreParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void tbApellidoParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void tbNacionalidadParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void tbTelefonoParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void cbTipoDocParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarDatosCargados();
        }

        private void tbNroDocParticipante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void cbRolParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarDatosCargados();
        }

        ///////Custom
        public void mostrarParticipantes()
        {
            listaParticipantes.DataSource = null;
            listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
        }

        private void validarDatosCargados()
        {
            if (tbNombreParticipante.Text != "" &&
                tbApellidoParticipante.Text != "" &&
                cbTipoDocParticipante.Text != "" &&
                tbNroDocParticipante.Text != "" &&
                tbNacionalidadParticipante.Text != "" &&
                tbTelefonoParticipante.Text != "" &&
                cbRolParticipante.Text != "")
                guardarParticipante.Enabled = true;
            else
                guardarParticipante.Enabled = false;
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                tbNombreParticipante.Text = row.Cells[1].Value.ToString();
                tbApellidoParticipante.Text = row.Cells[2].Value.ToString();
                cbTipoDocParticipante.Text = row.Cells[3].Value.ToString();
                tbNroDocParticipante.Text = row.Cells[4].Value.ToString();
                tbNacionalidadParticipante.Text = row.Cells[5].Value.ToString();
                tbTelefonoParticipante.Text = row.Cells[6].Value.ToString();
                cbRolParticipante.Text = row.Cells[7].Value.ToString();

            }
            else
            {
                gbParticipantes.Enabled = false;
                tbNombreParticipante.Text = "";
                tbApellidoParticipante.Text = "";
                cbTipoDocParticipante.Text = "";
                tbNroDocParticipante.Text = "";
                tbNacionalidadParticipante.Text = "";
                tbTelefonoParticipante.Text = "";
                cbRolParticipante.Text = "";
                btnActualizarParticipante.Enabled = false;
                guardarParticipante.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listaParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnActualizarParticipante.Enabled = true;
            btnEliminarParticipante.Enabled = true;
            
        }

    }
}
