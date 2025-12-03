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
    public partial class PedidoCompra : Form
    {
        private int _reqcompraID;
        private List<entDetreqcompra> _detalles;
        public PedidoCompra(int reqcompraID)
        {
            InitializeComponent();
            _reqcompraID = reqcompraID;
        }

        private void grupBoxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void PedidoCompra_Load(object sender, EventArgs e)
        {
            CargarDetallesRequerimiento();
        }
        private void CargarDetallesRequerimiento()
        {
            dgvDetalles.AutoGenerateColumns = false; // tu dgv de la parte superior

            _detalles = logReqcompra.Instancia.ListarDetalles(_reqcompraID);

            dgvDetalles.DataSource = _detalles;

            txtTotalItems.Text = _detalles.Count.ToString(); // el textbox "Total Items"
        }
    }
}
