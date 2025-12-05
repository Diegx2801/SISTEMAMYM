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
    public partial class BandejaPedidoCompra : Form
    {
        public BandejaPedidoCompra()
        {
            InitializeComponent();

            // 1. Inicialización de estilos
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpHasta.Format = DateTimePickerFormat.Short;

            // 2. Cargar datos de combos (Proveedor y Estado)
            CargarCombos();

            // 3. Cargar la bandeja al inicio (silenciosamente)
            ListarBandeja(false);
        }

        private void CargarCombos()
        {
            // --- 1. Cargar Proveedores ---
            try
            {
                List<entProveedor> listaProveedores = logProveedor.Instancia.ListarProveedor();
                listaProveedores.Insert(0, new entProveedor { ProveedorID = 0, RazonSocial = "--- Todos ---" });

                // Asumo que el ComboBox de Proveedor se llama cboProveedorFiltro
                cboProveedorFiltro.DataSource = listaProveedores;
                cboProveedorFiltro.DisplayMember = "RazonSocial";
                cboProveedorFiltro.ValueMember = "ProveedorID";
                cboProveedorFiltro.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Proveedores: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // --- 2. Cargar Estados ---
            var listaEstados = new List<string> { "--- Todos ---", "Pendiente", "Aprobado" };
            // Asumo que el ComboBox de Estado se llama cboEstadoFiltro
            cboEstadoFiltro.DataSource = listaEstados;
            cboEstadoFiltro.SelectedIndex = 0;
        }

        private void ListarBandeja(bool mostrarMensaje = true)
        {
            try
            {
                // 1. Obtener filtros de la interfaz
                int? pedidoID = string.IsNullOrWhiteSpace(txtNroPedido.Text) ? (int?)null : int.Parse(txtNroPedido.Text);

                // Lectura segura de Proveedor y Estado:
                int provIdSeleccionado = (int)cboProveedorFiltro.SelectedValue;
                int? proveedorID = (provIdSeleccionado > 0) ? provIdSeleccionado : (int?)null;

                // Estado: Si es "--- Todos ---", pasamos null.
                string estadoFiltro = cboEstadoFiltro.SelectedValue.ToString();
                string estado = (estadoFiltro == "--- Todos ---") ? null : estadoFiltro;

                // Fechas: Usando el .Checked si existe, o solo la fecha si no existe.
                DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
                DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

                // 2. Llamar a la Capa Lógica con la secuencia de argumentos correcta
                List<entPedidoCompra> lista = logPedidoCompra.Instancia.Listar(
                    pedidoID,
                    null,        // reqcompraID (Argumento 2)
                    proveedorID, // Argumento 3
                    estado,      // Argumento 4 (string)
                    desde,       // Argumento 5
                    hasta        // Argumento 6
                );

                // 3. CONFIGURACIÓN MANUAL DE COLUMNAS
                dgvPedidoCompra.Columns.Clear();
                dgvPedidoCompra.AutoGenerateColumns = false;

                // Creación de columnas
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NroPedido", HeaderText = "N° Pedido" });
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fecha", HeaderText = "Fecha", DefaultCellStyle = { Format = "dd/MM/yyyy" } });
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreProveedor", HeaderText = "Proveedor" });
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Estado", HeaderText = "Estado" });
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Observacion", HeaderText = "Observación" });
                dgvPedidoCompra.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "PedidoCompraID", Visible = false });

                // 4. Asignar el origen de datos
                dgvPedidoCompra.DataSource = lista;

                // 5. Ajuste y mensaje
                if (lista.Count > 0) dgvPedidoCompra.AutoResizeColumns();
                if (lista.Count == 0 && mostrarMensaje)
                {
                    MessageBox.Show("No se encontraron Pedidos de Compra con los filtros especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar o aplicar filtros: " + ex.Message, "Error de Listado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarBandejaPedidos()
        {
            // Este método duplica la lógica de ListarBandeja, pero es llamado desde Load
            // Para simplificar, simplemente delegamos al método principal sin mensaje.
            ListarBandeja(false);
        }

        private void BandejaPedidoCompra_Load(object sender, EventArgs e)
        {
            CargarBandejaPedidos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarBandeja(true);
        }

        // =================================================================
        // >> LÓGICA DE APROBAR PEDIDO DE COMPRA <<
        // =================================================================

        private void btnAprobarPedidoCompra_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay alguna fila seleccionada
            if (dgvPedidoCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el Pedido de Compra a aprobar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener el objeto PedidoCompra de la fila seleccionada
                entPedidoCompra pcSeleccionado = (entPedidoCompra)dgvPedidoCompra.SelectedRows[0].DataBoundItem;
                int pedidoID = pcSeleccionado.PedidoCompraID;
                string estadoActual = pcSeleccionado.Estado;
                string nroPedido = pcSeleccionado.NroPedido;

                // 2. Verificar si el estado es 'Pendiente'
                if (estadoActual != "Pendiente")
                {
                    MessageBox.Show($"Solo se pueden aprobar pedidos en estado Pendiente. Estado actual: {estadoActual}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Confirmación de Usuario
                if (MessageBox.Show($"¿Está seguro de APROBAR el Pedido N° {nroPedido}?", "Confirmar Aprobación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 4. Ejecutar la acción en la Capa Lógica
                    logPedidoCompra.Instancia.AprobarPedido(pedidoID);

                    MessageBox.Show("Pedido de Compra aprobado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Refrescar la bandeja (para ver el estado "Aprobado")
                    ListarBandeja(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aprobar el Pedido: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =================================================================
        // >> LÓGICA DE ANULAR PEDIDO DE COMPRA <<
        // =================================================================

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvPedidoCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el Pedido de Compra a anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entPedidoCompra pcSeleccionado = (entPedidoCompra)dgvPedidoCompra.SelectedRows[0].DataBoundItem;
                int pedidoID = pcSeleccionado.PedidoCompraID;
                string estadoActual = pcSeleccionado.Estado;
                string nroPedido = pcSeleccionado.NroPedido;

                // 1. Verificar si el estado es 'Pendiente' (Solo se anulan los pendientes)
                if (estadoActual != "Pendiente")
                {
                    MessageBox.Show($"Solo se pueden anular pedidos en estado Pendiente. Estado actual: {estadoActual}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Confirmación de Usuario
                if (MessageBox.Show($"¿Está seguro de ANULAR el Pedido N° {nroPedido}?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 3. Ejecutar la acción en la Capa Lógica
                    logPedidoCompra.Instancia.AnularPedido(pedidoID);

                    MessageBox.Show("Pedido de Compra anulado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Refrescar la bandeja
                    ListarBandeja(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular el Pedido: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {


        }
    }
}