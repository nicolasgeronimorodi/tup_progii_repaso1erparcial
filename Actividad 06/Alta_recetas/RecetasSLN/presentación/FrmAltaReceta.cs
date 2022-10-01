using RecetasSLN.dominio;
using RecetasSLN.servicios.implementaciones;
using RecetasSLN.servicios.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmAltaReceta : Form
    {

        private IServicio servicio;
        private Receta receta;
        public FrmAltaReceta()
        {
            InitializeComponent();
            servicio = new RecetaService();
            receta = new Receta();
        }

        private void FrmAltaReceta_Load(object sender, EventArgs e)
        {
            cargarCboIngredientes();
            lblRecetaNro.Text = "Recetra Nro# " + Convert.ToString(servicio.proximaReceta());
        }

        private void cargarCboIngredientes()
        {
            cboIngrediente.DataSource = servicio.obtenerIngredientes();
            cboIngrediente.DisplayMember = "Nombre";
            cboIngrediente.ValueMember = "IngredienteId";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboIngrediente.SelectedIndex!= -1)
            {


                if(!existe(cboIngrediente.Text))
                {
                    DetalleReceta detalle = new DetalleReceta();
                    detalle.Cantidad = (int)npdCantidad.Value;
                    detalle.Ingrediente = (Ingrediente)cboIngrediente.SelectedItem;
                    receta.AgregarDetalle(detalle);
                    dgvDetalles.Rows.Add(new object[] { detalle.Ingrediente.IngredienteId, detalle.Ingrediente.Nombre, detalle.Cantidad });
                    lblCantidadIngredientes.Text = "Total ingredientes: " + dgvDetalles.Rows.Count.ToString();
                        
                 }
            }


        }

        private bool existe(string selectedItem)
        {
            bool aux = false;
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {


                if (row.Cells[0].Value == null)
                {
                    aux = false;
                    return aux;
                }

                if (row.Cells["ColIngrediente"].Value.ToString().Equals(selectedItem))
                {
                    aux = true;
                    break;
                }

            }
            return aux;
        }


        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                receta.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                //click button:
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                //presupuesto.quitarDetalle();
               

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarInput())
            {
                receta.Chef=txtChef.Text;
                receta.Nombre = txtNombreReceta.Text;
                receta.TipoReceta = cboTipoReceta.SelectedIndex;
                if (servicio.guardarReceta(receta))
                {
                    MessageBox.Show("Receta guardada con éxito");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la receta.");
                }

            }

        }

        private void LimpiarCampos()
        {
            txtChef.Text = String.Empty;
            txtNombreReceta.Text = String.Empty;
            cboTipoReceta.SelectedIndex = -1;
            cboIngrediente.SelectedIndex = -1;
            npdCantidad.Value = 1;
            dgvDetalles.Rows.Clear();
            lblRecetaNro.Text = "Receta #:" + servicio.proximaReceta().ToString();
            lblCantidadIngredientes.Text = "Total de ingredientes:";
        }

        private bool validarInput()
        {
            if (txtNombreReceta.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }

            if (txtChef.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un chef");
                return false;
            }

            if (cboTipoReceta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe selecionar un tipo de receta");
                return false;
            }

            if (cboIngrediente.SelectedIndex == -1)
            {;
                MessageBox.Show("Debe seleccionar un ingrediente");
                return false;
            }

            if (npdCantidad.Value == 0)
            {
                MessageBox.Show("Debe indicar una cantidad de ingrediente");
                return false;
            }

            else if (dgvDetalles.Rows.Count < 4)
            {
                MessageBox.Show("Debe insertar al menos tres ingredientes...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }






            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            
            
          if(MessageBox.Show("¿Desea cancelar la operacion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }

              
                
            }
              
        }
    }

