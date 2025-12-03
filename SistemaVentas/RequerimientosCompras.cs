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
    public partial class RequerimientosCompras : Form
    {
        public RequerimientosCompras()
        {
            InitializeComponent();
        }

        private void CargarBandeja()
        {
            dgvRequerimientos.AutoGenerateColumns = false;

            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            var lista = logReqcompra.Instancia.Listar(
            string.IsNullOrEmpty(txtBuscarNumReq.Text) ? (int?)null : int.Parse(txtBuscarNumReq.Text),
            cboObra.SelectedIndex <= 0 ? (int?)null : (int)cboObra.SelectedValue,
            string.IsNullOrEmpty(cboEstado.Text) ? null : cboEstado.Text,
            desde, hasta);

            dgvRequerimientos.DataSource = lista;
        }

        // Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new RegistrarRequerimientoCompra())
            {
                if (frm.ShowDialog() == DialogResult.OK) CargarBandeja();
            }
        }

        // Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells["ReqcompraID"].Value);
            if (logReqcompra.Instancia.EnviarACompras(id)) MessageBox.Show("Enviado a compras");
            CargarBandeja();
        }

        // Anular
        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells["ReqcompraID"].Value);
            if (logReqcompra.Instancia.Anular(id))
                MessageBox.Show("Requerimiento anulado.");
            CargarBandeja();
        }

        // Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void RequerimientosCompras_Load(object sender, EventArgs e)
        {
            CargarBandeja();
        }
    }
}
