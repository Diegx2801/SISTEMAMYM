using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class BandejaOrdenIngreso : Form
    {
        public BandejaOrdenIngreso()
        {
            InitializeComponent();

            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpHasta.Format = DateTimePickerFormat.Short;

            // 1. Cargar datos de combos (Solo Proveedor)
            CargarCombos();

            // 2. Cargar la bandeja al inicio (silenciosamente)
            ListarBandeja(false);
        }

        private void CargarCombos()
        {
            // --- 1. Cargar Proveedores ---
            try
            {
                // **NOTA:** Asumo que existe logProveedor.Instancia.ListarProveedor()
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
            // La lógica de Estados se elimina de aquí, dejando solo el ComboBox de Proveedores.
            // Si cboEstadoFiltro existe en tu diseñador, se deja sin enlazar datos. 
        }

        private void ListarBandeja(bool mostrarMensaje = true)
        {
            try
            {
                // 1. Obtener filtros
                string numero = txtNroPedido.Text.Trim();

                // >> Lectura de Proveedor <<
                int provIdSeleccionado = (int)cboProveedorFiltro.SelectedValue;
                int? proveedorID = (provIdSeleccionado > 0) ? provIdSeleccionado : (int?)null;

                // El filtro de Estado ya no se lee ni se envía.

                DateTime? desde = dtpDesde.Value.Date;
                DateTime? hasta = dtpHasta.Value.Date;

                // 2. Llamada a la Capa Lógica con 5 argumentos (oiId, numero, proveedorID, desde, hasta)
                List<entOrdeningreso> lista = logOrdeningreso.Instancia.Listar(
                    null,
                    numero,
                    proveedorID, // Argumento 3: ProveedorID
                    desde,
                    hasta
                );

                // 3. CONFIGURACIÓN MANUAL DEL DGV (Tu código de DGV es correcto)
                dgvOrdenes.Columns.Clear();
                dgvOrdenes.AutoGenerateColumns = false;

                // Creación de columnas
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Numero", HeaderText = "N° Orden Ingreso" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NroPedido", HeaderText = "N° Pedido Compra" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fecha", HeaderText = "Fecha", DefaultCellStyle = { Format = "dd/MM/yyyy" } });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreProveedor", HeaderText = "Proveedor" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Estado", HeaderText = "Estado" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Observacion", HeaderText = "Observación" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "OrdeningresoID", Visible = false });

                dgvOrdenes.DataSource = lista;

                // 4. Ajuste y mensaje
                if (lista.Count > 0) dgvOrdenes.AutoResizeColumns();
                if (lista.Count == 0 && mostrarMensaje)
                {
                    MessageBox.Show("No se encontraron Órdenes de Ingreso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Órdenes de Ingreso: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarBandeja(true); // Buscar con mensaje
        }

        private void btnGenerarOrdenIngreso_Click(object sender, EventArgs e)
        {
            OrdenIngreso frmRegistro = new OrdenIngreso();
            frmRegistro.ShowDialog();
            ListarBandeja(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de Anular Orden de Ingreso Pendiente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}