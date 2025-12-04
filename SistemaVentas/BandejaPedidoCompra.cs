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
    public partial class BandejaPedidoCompra : Form
    {
        public BandejaPedidoCompra()
        {
            InitializeComponent();

        }

        private void CargarBandejaPedidos()
        {
            dgvPedidoCompra.AutoGenerateColumns = false;

            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            int? proveedorID = cboProveedor.SelectedIndex <= 0 ? (int?)null : (int)cboProveedor.SelectedValue;

            var lista = logPedidoCompra.Instancia.Listar(null, null, proveedorID, desde, hasta);

            dgvPedidoCompra.DataSource = lista;
        }

        private void BandejaPedidoCompra_Load(object sender, EventArgs e)
        {
            CargarBandejaPedidos();
        }
    }
}
