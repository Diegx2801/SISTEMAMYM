using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class MantenedorObra : Form
    {
        public MantenedorObra()
        {
            InitializeComponent();
            listar();
            groupBoxDatos.Enabled = false;
            txtObraID.Enabled = false;
        }

        private void listar()
        {
            dgvObra.DataSource = logObra.Instancia.ListarObra();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiar();
            chkEstadoObra.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entObra o = new entObra
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Estado = chkEstadoObra.Checked
                };

                logObra.Instancia.InsertarObra(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar obra: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void dgvObra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvObra.Rows[e.RowIndex];

                
                txtObraID.Text = filaActual.Cells[0].Value.ToString(); 
                txtCodigo.Text = filaActual.Cells[1].Value.ToString();
                txtNombre.Text = filaActual.Cells[2].Value.ToString();
                txtDireccion.Text = filaActual.Cells[3].Value.ToString();
                chkEstadoObra.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObraID.Text))
            {
                MessageBox.Show("Selecciona una obra primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entObra o = new entObra
                {
                    ObraID = int.Parse(txtObraID.Text.Trim()),
                    Codigo = txtCodigo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Estado = chkEstadoObra.Checked
                };

                logObra.Instancia.EditarObra(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar obra: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObraID.Text))
            {
                MessageBox.Show("Selecciona una obra primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entObra o = new entObra
                {
                    ObraID = int.Parse(txtObraID.Text.Trim())
                };

                logObra.Instancia.DeshabilitarObra(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar obra: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            txtObraID.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            chkEstadoObra.Checked = false;
        }
    }
}
