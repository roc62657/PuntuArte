using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
                TipoDocumento = tbTipoDocParticipante.Text,
                NroDocumento = tbNroDocParticipante.Text,
                Nacionalidad = tbNacionalidadParticipante.Text,
                NroTelefono = tbTelefonoParticipante.Text,
                Rol = "Jurado"
            };

            bool respuesta = false;
            if (tbIdParticipante.Text == "") // es nuevo si no tiene ID
            {
                respuesta = ParticipantesConexion.Instancia.guardarParticipante(participante);
                int idParticipanteNuevo = ParticipantesConexion.Instancia.obtenerIDParticipantePorDocumento(tbNroDocParticipante.Text);               
                tbIdParticipante.Text = idParticipanteNuevo.ToString(); 
            }
            else
            {
                participante.IDParticipante = int.Parse(tbIdParticipante.Text);
                respuesta = ParticipantesConexion.Instancia.actualizarParticipante(participante);
            }

            bABMCategoriasPart.Text = "Agregar Categorias";
            bABMCategoriasPart.Visible = true;
            leyendaHabCateg.Visible = false;
            bABMCategoriasPart.Enabled = true;
            labelCatAg.Enabled = true;
            cbCategorias.Enabled = true;
            llenarListaCategorias();

            //Recarga grilla
            if (respuesta)
                mostrarParticipantes();

            ////Limpia controles e inhabilita sector alta y modificacion
            //gbParticipantes.Enabled = false;
            //tbNombreParticipante.Text = "";
            //tbApellidoParticipante.Text = "";
            //tbTipoDocParticipante.Text = "";
            //tbNroDocParticipante.Text = "";
            //tbNacionalidadParticipante.Text = "";
            //tbTelefonoParticipante.Text = "";
            //cbCategorias.Text = "";
            //guardarParticipante.Enabled = false;
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            gbParticipantes.Enabled = true;
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            tbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
            bABMCategoriasPart.Text = "Agregar Categoria";
            bABMCategoriasPart.Visible = true;
            bABMCategoriasPart.Enabled = false;
            leyendaHabCateg.Visible = true;
            guardarParticipante.Enabled = true;
            labelCatAg.Enabled = false;
            cbCategorias.Enabled = false;
            listaCategoriasDeJurado.DataSource = null;
            tbIdParticipante.Text = "";

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

        private void tbTipoDocParticipante_SelectedIndexChanged(object sender, EventArgs e)
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
                tbTipoDocParticipante.Text != "" &&
                tbNroDocParticipante.Text != "" &&
                tbNacionalidadParticipante.Text != "" &&
                tbTelefonoParticipante.Text != "")
                //cbCategorias.Text != "")
                guardarParticipante.Enabled = true;
            else
                guardarParticipante.Enabled = false;
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            leyendaHabCateg.Visible = false;
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                tbNombreParticipante.Text = row.Cells[1].Value.ToString();
                tbApellidoParticipante.Text = row.Cells[2].Value.ToString();
                tbTipoDocParticipante.Text = row.Cells[3].Value.ToString();
                tbNroDocParticipante.Text = row.Cells[4].Value.ToString();
                tbNacionalidadParticipante.Text = row.Cells[5].Value.ToString();
                tbTelefonoParticipante.Text = row.Cells[6].Value.ToString();
                //cbCategorias.Text = row.Cells[7].Value.ToString();               
                List < Categorias > categorias = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(int.Parse(row.Cells[0].Value.ToString()));
                listaCategoriasDeJurado.DataSource = categorias;
                if (categorias.Count > 0)
                {
                    bABMCategoriasPart.Visible = true;
                    bABMCategoriasPart.Text = "Modificar Categoria";
                    bABMCategoriasPart.Enabled = true;
                    cbCategorias.Enabled = true;
                    labelCatAg.Enabled = true;
                    llenarListaCategorias();

                } else
                {
                    bABMCategoriasPart.Visible = true;
                    bABMCategoriasPart.Text = "Agregar Categoria";
                    bABMCategoriasPart.Enabled = true;
                    cbCategorias.Enabled = true;
                    labelCatAg.Enabled = true;
                    llenarListaCategorias();
                }
            }
            else
            {
                gbParticipantes.Enabled = false;
                tbNombreParticipante.Text = "";
                tbApellidoParticipante.Text = "";
                tbTipoDocParticipante.Text = "";
                tbNroDocParticipante.Text = "";
                tbNacionalidadParticipante.Text = "";
                tbTelefonoParticipante.Text = "";
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

        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {

        }

        private void listaParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
     
        private void tbIdParticipante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(tdIdCategoria.Text);
            int idParticipante = int.Parse(tdIdCategoria.Text);
            
            List<CategoriaPuntuacion> listCategoriaPuntuacion = CategoriaPuntuacionConexion.Instancia.obtenerCategoriaPuntuacionPorIDCategoria(idCategoria);
            JuradoCategoriaPuntuacion juradoCategoriaPuntuacion = new JuradoCategoriaPuntuacion();
            foreach (CategoriaPuntuacion catp in listCategoriaPuntuacion)
            {
                juradoCategoriaPuntuacion.IDCategoriaPuntuacion = catp.IDCategoriaPuntuacion;
                juradoCategoriaPuntuacion.IDParticipante = idParticipante;
                bool result = JuradoCategoriaPuntuacionConexion.Instancia.guardarJuradoCategoriaPuntuacion(juradoCategoriaPuntuacion);
                if (result)
                {
                    listaCategoriasDeJurado.DataSource = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(idParticipante);
                }
            }

            
        }

        private void llenarListaCategorias()
        {
            cbCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategorias();
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.ValueMember = "IDCategoria";
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            tdIdCategoria.Text = categoriaSeleccionada.IDCategoria.ToString();
        }
    }
    
}
