using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace SistemaVentas
{
    public partial class MantenedorMaterial : Form
    {
        public MantenedorMaterial()
        {
            InitializeComponent();
            CargarCombos();
            listar();
            groupBoxDatos.Enabled = false;
            txtMaterialID.Enabled = false;
        }

        private void CargarCombos()
        {
            // Tipo Material
            cboTipoMaterial.DataSource = logTipomaterial.Instancia.ListarTipomaterial();
            cboTipoMaterial.DisplayMember = "Nombre";
            cboTipoMaterial.ValueMember   = "TipomaterialID";

            // Marca
            cboMarca.DataSource = logMarca.Instancia.ListarMarca();
            cboMarca.DisplayMember = "Nombre";
            cboMarca.ValueMember   = "MarcaID";

            // Proveedor
            cboProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cboProveedor.DisplayMember = "RazonSocial";  // lo que quieres ver
            cboProveedor.ValueMember   = "ProveedorID";
        }

        private void listar()
        {
            dgvMaterial.DataSource = logMaterial.Instancia.ListarMaterial();
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
                entMaterial m = new entMaterial
                {
                    Codigo         = txtCodigo.Text.Trim(),
                    Nombre         = txtMaterial.Text.Trim(),
                    TipomaterialID = (int)cboTipoMaterial.SelectedValue,
                    MarcaID        = (int)cboMarca.SelectedValue,
                    ProveedorID    = (int)cboProveedor.SelectedValue,
                    UnidadMedida   = txtUnidadMedida.Text.Trim(),
                    Stock          = decimal.Parse(txtStock.Text.Trim()),
                    Estado         = chkEstado.Checked
                };

                logMaterial.Instancia.InsertarMaterial(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar material: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                entMaterial m = (entMaterial)dgvMaterial.Rows[e.RowIndex].DataBoundItem;

                txtMaterialID.Text   = m.MaterialID.ToString();
                txtCodigo.Text       = m.Codigo;
                txtMaterial.Text     = m.Nombre;
                cboTipoMaterial.SelectedValue = m.TipomaterialID;
                cboMarca.SelectedValue        = m.MarcaID;
                cboProveedor.SelectedValue    = m.ProveedorID;
                txtUnidadMedida.Text = m.UnidadMedida;
                txtStock.Text        = m.Stock.ToString("0.##");
                chkEstado.Checked    = m.Estado;
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
            if (string.IsNullOrWhiteSpace(txtMaterialID.Text))
            {
                MessageBox.Show("Selecciona un material primero.");
                return;
            }

            try
            {
                entMaterial m = new entMaterial
                {
                    MaterialID     = int.Parse(txtMaterialID.Text.Trim()),
                    Codigo         = txtCodigo.Text.Trim(),
                    Nombre         = txtMaterial.Text.Trim(),
                    TipomaterialID = (int)cboTipoMaterial.SelectedValue,
                    MarcaID        = (int)cboMarca.SelectedValue,
                    ProveedorID    = (int)cboProveedor.SelectedValue,
                    UnidadMedida   = txtUnidadMedida.Text.Trim(),
                    Stock          = decimal.Parse(txtStock.Text.Trim()),
                    Estado         = chkEstado.Checked
                };

                logMaterial.Instancia.EditarMaterial(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar material: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaterialID.Text))
            {
                MessageBox.Show("Selecciona un material primero.");
                return;
            }

            try
            {
                entMaterial m = new entMaterial
                {
                    MaterialID = int.Parse(txtMaterialID.Text.Trim())
                };

                logMaterial.Instancia.DeshabilitarMaterial(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar material: " + ex.Message);
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
            txtMaterialID.Text = "";
            txtCodigo.Text = "";
            txtMaterial.Text = "";
            txtUnidadMedida.Text = "";
            txtStock.Text = "";
            if (cboTipoMaterial.Items.Count > 0) cboTipoMaterial.SelectedIndex = 0;
            if (cboMarca.Items.Count > 0) cboMarca.SelectedIndex = 0;
            if (cboProveedor.Items.Count > 0) cboProveedor.SelectedIndex = 0;
            chkEstado.Checked = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            new MantenedorMarca().ShowDialog();
            
            CargarCombos();
        }

        private void btnAgregarTipoMaterial_Click(object sender, EventArgs e)
        {
            new MantenedorTipoMaterial().ShowDialog();
            CargarCombos();

        }
    }
}
