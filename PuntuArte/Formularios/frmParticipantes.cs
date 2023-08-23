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
using static System.Net.Mime.MediaTypeNames;

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

        private bool validarDatosAGuardar()
        {
            if (tbNombreParticipante.Text=="" ||
                tbApellidoParticipante.Text == ""||
                tbNacionalidadParticipante.Text == "" ||
                tbNroDocParticipante.Text == ""
                ){                
                MessageBox.Show("Los campos NOMBRE, APELLIDO, PAIS ORIGEN y NUMERO DE DOCUMENTO son obligatorios, por favor valide los mismos y vuelva a intentar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
               int idParticipante = ParticipantesConexion.Instancia.obtenerIDParticipanteJuradoPorDocumentoYNacionalidad(tbNroDocParticipante.Text,tbNacionalidadParticipante.Text);
                if( idParticipante >= 0)
                {
                    MessageBox.Show("El jurado que desea crear ya existe, por favor valide los mismos y vuelva a intentar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            
            return true;
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

                int respuestaId = 0;
            if (tbIdParticipante.Text == "") // es nuevo si no tiene ID
            {
                if (validarDatosAGuardar())
                {
                    respuestaId = ParticipantesConexion.Instancia.guardarParticipante(participante);
                    if (respuestaId > 0) //no es 0, ni -1
                    {
                        tbIdParticipante.Text = respuestaId.ToString();
                    }

                }
            }
            else
            {
                participante.IDParticipante = int.Parse(tbIdParticipante.Text);
                respuestaId = ParticipantesConexion.Instancia.actualizarParticipante(participante);
            }


            habilitarAgregadoCategorias();
                llenarListaCategorias();

                //Recarga grilla si no dio error
                if (respuestaId <= 0) //es 0 ó -1
                {
                    MessageBox.Show("Ha ocurrido un error, por favor valide los datos ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mostrarParticipantes();
                    habilitarTextBoxDatosPersonales();
                }
        }

       

        ///////Custom
        public void mostrarParticipantes()
        {
            listaParticipantes.DataSource = null;
            
            if (tbIdParticipante.Text != "")
            {
                listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
                List<Participantes> lParticipantes = ParticipantesConexion.Instancia.obtenerParticipantes();
                int indice = lParticipantes.FindIndex(a => a.IDParticipante == int.Parse(tbIdParticipante.Text));
                listaParticipantes.Rows[0].Selected = false;
                listaParticipantes.Rows[indice].Selected = true;
                btnActualizarParticipante.Enabled = true;
                btnEliminarParticipante.Enabled=true;   
            }
            else
            {    
                listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
                listaParticipantes.Rows[0].Selected = false;
            }

        }
       

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            leyendaHabCateg.Visible = false;
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                habilitarTextBoxDatosPersonales();
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                tbNombreParticipante.Text = row.Cells[1].Value.ToString();
                tbApellidoParticipante.Text = row.Cells[2].Value.ToString();
                tbTipoDocParticipante.Text = row.Cells[3].Value.ToString();
                tbNroDocParticipante.Text = row.Cells[4].Value.ToString();
                tbNacionalidadParticipante.Text = row.Cells[5].Value.ToString();
                tbTelefonoParticipante.Text = row.Cells[6].Value.ToString();
                guardarParticipante.Enabled = true;
                //cbCategorias.Text = row.Cells[7].Value.ToString();               
                List < Categorias > categorias = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(int.Parse(row.Cells[0].Value.ToString()));
                listaCategoriasDeJurado.DataSource = categorias;
                habilitarAgregadoCategorias();
                llenarListaCategorias();
            }
            else
            {
                gbParticipantes.Enabled = false;
                borrarDatosPersonales();
                btnActualizarParticipante.Enabled = false;
                guardarParticipante.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void listaParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnActualizarParticipante.Enabled = true;
            btnEliminarParticipante.Enabled = true;
            deshabilitarTextBoxDatosPersonales();
            borrarDatosPersonales();
            deshabilitarAgregadoCategorias();

        }

        //Se eliminara el Jurado seleccionado
        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {
            leyendaHabCateg.Visible = false;
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                bool respuesta = ParticipantesConexion.Instancia.eliminarJurado(int.Parse(tbIdParticipante.Text));
                if (respuesta)
                {
                    MessageBox.Show("Jurado eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, por favor intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                gbParticipantes.Enabled = false;
                borrarDatosPersonales();
                btnActualizarParticipante.Enabled = false;
                guardarParticipante.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
            gbParticipantes.Enabled = false;
            borrarDatosPersonales();
            btnActualizarParticipante.Enabled = true;
            guardarParticipante.Enabled = false;
        }
             
        private void llenarListaCategorias()
        {            
            cbCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategoriaHabilitadasParaCalificar();
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.ValueMember = "IDCategoria";
        }
        private void llenarListaCategoriasPorJurado(int idJurado)
        {
            listaCategoriasDeJurado.DataSource = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(idJurado);            
        }
        
        private void cbCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            tdIdCategoria.Text = categoriaSeleccionada.IDCategoria.ToString();
        }

        private void btnCrearJurado_Click(object sender, EventArgs e)
        {
            gbParticipantes.Enabled = true;
            borrarDatosPersonales();
            bABMCategoriasPart.Visible = true;
            bABMCategoriasPart.Enabled = false;
            bEliminarCategoriaJurado.Visible = true;
            bEliminarCategoriaJurado.Enabled = false;
            leyendaHabCateg.Visible = true;
            guardarParticipante.Enabled = true;
            labelCatAg.Enabled = false;
            cbCategorias.Enabled = false;
            listaCategoriasDeJurado.DataSource = null;
            tbIdParticipante.Text = "";
            habilitarTextBoxDatosPersonales();



        }
        private void habilitarTextBoxDatosPersonales()
        {
            gbParticipantes.Enabled = true;
            tbNombreParticipante.Enabled = true;
            tbApellidoParticipante.Enabled = true;
            tbTipoDocParticipante.Enabled = true; ;
            tbNroDocParticipante.Enabled = true;
            tbNacionalidadParticipante.Enabled = true;
            tbTelefonoParticipante.Enabled = true;
        }

        private void deshabilitarTextBoxDatosPersonales()
        {
            //Bloqueo usuario para su creacion
            guardarParticipante.Enabled = false;
            tbNombreParticipante.Enabled = false;
            tbApellidoParticipante.Enabled = false;
            tbTipoDocParticipante.Enabled = false;
            tbNroDocParticipante.Enabled = false;
            tbNacionalidadParticipante.Enabled = false;
            tbTelefonoParticipante.Enabled = false;
            cbCategorias.Text = "";
        }

        private void borrarDatosPersonales()
        {
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            tbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
        }

        private void habilitarAgregadoCategorias()
        {
            bABMCategoriasPart.Visible = true;
            bABMCategoriasPart.Enabled = true;
            bEliminarCategoriaJurado.Enabled = true;
            bEliminarCategoriaJurado.Visible = true;
            leyendaHabCateg.Visible = false;
            labelCatAg.Enabled = true;
            cbCategorias.Enabled = true;
        }

        private void deshabilitarAgregadoCategorias()
        {
            bABMCategoriasPart.Visible = false;
            bABMCategoriasPart.Enabled = false;
            bEliminarCategoriaJurado.Enabled = false;
            bEliminarCategoriaJurado.Visible = false;
            leyendaHabCateg.Visible = false;
            labelCatAg.Enabled = false;
            cbCategorias.Enabled = false;
            listaCategoriasDeJurado.DataSource = null;
        }

        private void bABMCategoriasPart_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(tdIdCategoria.Text);
            int idParticipante = int.Parse(tbIdParticipante.Text);
            JuradoCategoria juradoCategoria = new JuradoCategoria() { IDCategoria = idCategoria, IDJurado = idParticipante };
            
            bool existeCategoria = JuradoCategoriaConexion.Instancia.validoCategoriaExistente(juradoCategoria);
            if (!existeCategoria) { 
                bool result = JuradoCategoriaConexion.Instancia.guardarJuradoCategoria(juradoCategoria);
                if (result)
                {
                    listaCategoriasDeJurado.DataSource = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(idParticipante);
                }
            }
            
        }

       
        private void bEliminarCategoriaJurado_Click(object sender, EventArgs e)
        {
            int selectedRowCount = listaCategoriasDeJurado.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow row = listaCategoriasDeJurado.SelectedRows[0];
                tdIdCategoria.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoria para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            int idCategoria = int.Parse(tdIdCategoria.Text);
            int IdJurado = int.Parse(tbIdParticipante.Text);
            JuradoCategoria juradoCategoria = new JuradoCategoria();
            juradoCategoria.IDJurado = IdJurado;
            juradoCategoria.IDCategoria = idCategoria;
            JuradoCategoriaConexion.Instancia.eliminarJuradoCategoria(juradoCategoria);
            llenarListaCategoriasPorJurado(IdJurado);
        }
    }

}
