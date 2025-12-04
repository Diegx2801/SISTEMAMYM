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
        private List<entDetPedidoCompra> _detalles;
        public PedidoCompra(int reqcompraID)
        {
            InitializeComponent();
            _reqcompraID = reqcompraID;
        }

        private void grupBoxDatos_Enter(object sender, EventArgs e)
        {

        }
        private void CargarComboFormasPago()
        {
            var listaFormasPago = logFormapago.Instancia.ListarFormapago();

            cboFormaPago.DataSource = listaFormasPago;
            cboFormaPago.DisplayMember = "Descripcion"; // o cualquier campo relevante
            cboFormaPago.ValueMember = "FormaPagoID";  // Valor que se usará internamente

            cboFormaPago.SelectedIndex = -1; // Deja el combo vacío para selección
        }
        private void CargarComboProveedores()
        {
            var listaProveedores = logProveedor.Instancia.ListarProveedor();

            cboProveedor.DataSource = listaProveedores;
            cboProveedor.DisplayMember = "RazonSocial"; // o el campo que consideres importante
            cboProveedor.ValueMember = "ProveedorID";  // Valor que se usará internamente

            cboProveedor.SelectedIndex = -1; // Deja el combo vacío para selección
        }
        private void PedidoCompra_Load(object sender, EventArgs e)
        {
            CargarDetallesRequerimiento();
            CargarComboProveedores();
            CargarComboFormasPago();
            txtNroPedido.Enabled = false;
        }
        private void CargarDetallesRequerimiento()
        {
            dgvDetalles.AutoGenerateColumns = false;

            _detalles = logReqcompra.Instancia.ListarDetalles(_reqcompraID)
                            .Select(d => new entDetPedidoCompra
                            {
                                MaterialID = d.MaterialID,
                                NombreMaterial = d.NombreMaterial,
                                UnidadMedida = d.UnidadMedida,
                                Cantidad = d.Cantidad,
                                Observacion = d.Observacion
                            }).ToList();

            dgvDetalles.DataSource = _detalles;
            txtTotalItems.Text = _detalles.Count.ToString(); // el textbox "Total Items"
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_detalles == null || _detalles.Count == 0)
            {
                MessageBox.Show("No hay ítems para registrar.");
                return;
            }

            var pedido = new entPedidoCompra
            {
                ReqcompraID = _reqcompraID,
                Fecha = dtpFecha.Value.Date,
                FormaPagoID = (int)cboFormaPago.SelectedValue,
                ProveedorID = (int)cboProveedor.SelectedValue,
                Observacion = txtObservaciones.Text.Trim()
            };

            // Ahora solo pasamos los parámetros necesarios
            bool ok = logPedidoCompra.Instancia.RegistrarPedido(pedido, _detalles);

            if (ok)
            {
                MessageBox.Show("Pedido de compra registrado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
