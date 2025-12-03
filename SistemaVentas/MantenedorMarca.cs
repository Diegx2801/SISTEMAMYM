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
    public partial class MantenedorMarca : Form
    {
        public MantenedorMarca()
        {
            InitializeComponent();
            listarMarca();
            grupBoxDatos.Enabled = false;
            txtMarcaID.Enabled = false;
        }

        private void listarMarca()
        {
            dgvMarca.DataSource = logMarca.Instancia.ListarMarca();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariables();
            cbkEstadoMarca.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca m = new entMarca();
                m.Nombre = txtNombre.Text.Trim();
                m.Descripcion = txtDescripcion.Text.Trim();
                m.Estado = cbkEstadoMarca.Checked;

                logMarca.Instancia.InsertarMarca(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar marca: " + ex.Message);
            }

            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMarca();
        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex];

                txtMarcaID.Text = filaActual.Cells[0].Value.ToString();
                txtNombre.Text = filaActual.Cells[1].Value.ToString();
                txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
                cbkEstadoMarca.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca m = new entMarca();
                m.MarcaID = int.Parse(txtMarcaID.Text.Trim());
                m.Nombre = txtNombre.Text.Trim();
                m.Descripcion = txtDescripcion.Text.Trim();
                m.Estado = cbkEstadoMarca.Checked;

                logMarca.Instancia.EditarMarca(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar marca: " + ex.Message);
            }

            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMarca();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMarca m = new entMarca();
                m.MarcaID = int.Parse(txtMarcaID.Text.Trim());
                cbkEstadoMarca.Checked = false;
                m.Estado = cbkEstadoMarca.Checked;

                logMarca.Instancia.DeshabilitarMarca(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar marca: " + ex.Message);
            }

            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarMarca();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarVariables()
        {
            txtMarcaID.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbkEstadoMarca.Checked = false;
        }
    }
}
