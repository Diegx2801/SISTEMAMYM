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
    public partial class MantenedorTipoMaterial : Form
    {
        public MantenedorTipoMaterial()
        {
            InitializeComponent();
            listar();
            groupBoxDatos.Enabled = false;
            txtTipomaterialID.Enabled = false;
        }

        private void listar()
        {
            dgvTipoMaterial.DataSource = logTipomaterial.Instancia.ListarTipomaterial();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiar();
            chkEstado.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipomaterial t = new entTipomaterial
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                logTipomaterial.Instancia.InsertarTipomaterial(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tipo material: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void dgvTipoMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTipoMaterial.Rows[e.RowIndex];

                txtTipomaterialID.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(fila.Cells[3].Value);
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
            if (string.IsNullOrWhiteSpace(txtTipomaterialID.Text))
            {
                MessageBox.Show("Seleccione un registro primero.");
                return;
            }

            try
            {
                entTipomaterial t = new entTipomaterial
                {
                    TipomaterialID = int.Parse(txtTipomaterialID.Text.Trim()),
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chkEstado.Checked
                };

                logTipomaterial.Instancia.EditarTipomaterial(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipomaterialID.Text))
            {
                MessageBox.Show("Seleccione un registro primero.");
                return;
            }

            try
            {
                entTipomaterial t = new entTipomaterial
                {
                    TipomaterialID = int.Parse(txtTipomaterialID.Text.Trim())
                };

                logTipomaterial.Instancia.DeshabilitarTipomaterial(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar: " + ex.Message);
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
            txtTipomaterialID.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
        }
    }
}