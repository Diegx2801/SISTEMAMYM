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
    }
}
