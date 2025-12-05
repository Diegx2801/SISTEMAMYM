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
    public partial class BandejaRequerimientosCompras : Form
    {
        public BandejaRequerimientosCompras()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }


        private void btnProv_Click(object sender, EventArgs e)
        {
            MantenedorProveedor frm = new MantenedorProveedor();
            frm.Show();
            this.Hide();
        }

        private void btnFormaPago_Click(object sender, EventArgs e)
        {
            MantenedorFormaDePago frm = new MantenedorFormaDePago();
            frm.Show();
            this.Hide();
        }

        private void BandejaRequerimientosCompras_Load(object sender, EventArgs e)
        {
            CargarBandeja();
        }
        private void CargarBandeja()
        {
            dgvRequerimientosCompras.AutoGenerateColumns = false;

            int? nroReq = string.IsNullOrWhiteSpace(txtBuscarNumReq.Text)
               ? (int?)null
               : int.Parse(txtBuscarNumReq.Text);

            int? obraId = cboObra.SelectedIndex <= 0
                          ? (int?)null
                          : (int)cboObra.SelectedValue;

            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            
            var lista = logReqcompra.Instancia.Listar(nroReq, obraId, "ENVIADO", desde, hasta);

            dgvRequerimientosCompras.DataSource = lista;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientosCompras.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un requerimiento.");
                return;
            }

            int reqID = Convert.ToInt32(
                dgvRequerimientosCompras.CurrentRow.Cells["ReqcompraID"].Value
            );

            using (var frm = new PedidoCompra(reqID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                  
                    CargarBandeja();
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay alguna fila seleccionada
            if (dgvRequerimientosCompras.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Requerimiento para anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener el objeto seleccionado
                // Se asume que el DataSource del DGV es una lista de la entidad de Requerimiento (entReqcompra)
                entReqcompra reqSeleccionado = (entReqcompra)dgvRequerimientosCompras.CurrentRow.DataBoundItem;
                int reqID = reqSeleccionado.ReqcompraID;
                string estadoActual = reqSeleccionado.Estado;

                // 2. Validar que el estado sea anulable (ej: Registrado o Enviado)
                if (estadoActual == "Anulado" || estadoActual == "Cerrado")
                {
                    MessageBox.Show($"Solo se pueden anular requerimientos en estado Pendiente o Enviado. Estado actual: {estadoActual}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Confirmación de Usuario
                string mensaje = $"¿Está seguro de ANULAR el Requerimiento N° {reqID}?";

                if (MessageBox.Show(mensaje, "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 4. Llamar a la Capa Lógica para cambiar el estado en la BD
                    // Nota: Este método solo actualiza el estado a 'Anulado'
                    logReqcompra.Instancia.Anular(reqID);

                    MessageBox.Show("Requerimiento de Compra anulado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Refrescar la bandeja (para ver el estado 'Anulado')
                    CargarBandeja();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular el Requerimiento: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPedidoCompra_Click(object sender, EventArgs e)
        {
            new BandejaPedidoCompra().ShowDialog();
        }
    }
}
