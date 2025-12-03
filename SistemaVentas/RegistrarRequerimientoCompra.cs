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
    public partial class RegistrarRequerimientoCompra : Form
    {
        public RegistrarRequerimientoCompra()
        {
            InitializeComponent();
        }


        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCantidad.Text, out decimal cant) || cant <= 0)
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            // Contar solo las filas reales
            int itemNumber = dgvDetalle.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow) + 1;

            dgvDetalle.Rows.Add(
                itemNumber,
                txtNombreMaterial.Text.Trim(),
                txtUnidad.Text.Trim(),
                cant,
                txtObsItem.Text.Trim()
            );

            // Actualizar el TextBox del total de ítems
            txtTotalItems.Text = dgvDetalle.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow).ToString();

            txtNombreMaterial.Clear();
            txtUnidad.Clear();
            txtCantidad.Clear();
            txtObsItem.Clear();
            txtNombreMaterial.Focus();
        }

        private void CargarObras()
        {
            var lista = logObra.Instancia.ListarObra();

            cboObra.DataSource = lista;
            cboObra.DisplayMember = "Nombre";
            cboObra.ValueMember = "ObraID";

            cboObra.SelectedIndex = -1;
        }
        // Registrar requerimiento
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un item.");
                    return;
                }

                entReqcompra req = new entReqcompra
                {
                    ObraID = Convert.ToInt32(cboObra.SelectedValue),
                    Fecha = dtpFecha.Value,
                    Solicitante = txtSolicitante.Text.Trim(),
                    Prioridad = cmbPrioridad.SelectedItem?.ToString(),
                    Observacion = txtObsGeneral.Text.Trim(),
                    Estado = "Pendiente"
                };

                foreach (DataGridViewRow fila in dgvDetalle.Rows)
                {
                    if (fila.IsNewRow) continue;

                    entDetreqcompra det = new entDetreqcompra
                    {
                        MaterialID = Convert.ToInt32(fila.Cells[0].Value),
                        NombreMaterial = fila.Cells[1].Value.ToString(),
                        UnidadMedida = fila.Cells[2].Value.ToString(),
                        Cantidad = Convert.ToDecimal(fila.Cells[3].Value),
                        Observacion = fila.Cells[4].Value?.ToString()
                    };

                    req.Detalles.Add(det);
                }

                req.TotalItems = req.Detalles.Count;

                bool ok = logReqcompra.Instancia.RegistrarRequerimiento(req);
                if (ok)
                {
                    MessageBox.Show("Requerimiento registrado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RegistrarRequerimientoCompra_Load(object sender, EventArgs e)
        {
            CargarObras();
            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");
            cmbPrioridad.SelectedIndex = 1;
            txtTotalItems.ReadOnly = true;
        }

        private void btnCierra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
