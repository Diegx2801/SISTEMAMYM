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

            // Cargar la bandeja al inicio (sin mostrar mensaje si está vacía)
            ListarBandeja(false);
        }

        private void ListarBandeja(bool mostrarMensaje = true)
        {
            try
            {
                // 1. Obtener filtros
                string numero = txtNroPedido.Text.Trim(); // Asumiendo que se usa txtNroPedido para buscar N° de Orden Ingreso
                DateTime? desde = dtpDesde.Value.Date;
                DateTime? hasta = dtpHasta.Value.Date;

                // Nota: El filtro por Proveedor NO está en el SP de ListarOrdenIngreso (se omite por ahora)

                // 2. Llamada a la Capa Lógica
                List<entOrdeningreso> lista = logOrdeningreso.Instancia.Listar(null, numero, desde, hasta);

                // 3. CONFIGURACIÓN MANUAL DEL DGV
                dgvOrdenes.Columns.Clear();
                dgvOrdenes.AutoGenerateColumns = false;

                // Creación de columnas
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Numero", HeaderText = "N° Orden Ingreso" });
                dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NroPedido", HeaderText = "N° Pedido Compra" }); // N° del Pedido original
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

            // Recargar la bandeja al cerrar el formulario de registro
            ListarBandeja(false);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            // Implementación pendiente: Si decides anular Ordenes de Ingreso, 
            // necesitarás un SP transaccional que revierta el stock (restar la cantidad)
            MessageBox.Show("Funcionalidad de Anular Orden de Ingreso Pendiente.");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}