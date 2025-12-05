using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class OrdenIngreso : Form
    {
        // Almacena el Pedido de Compra seleccionado para la transacción
        private entPedidoCompra pedidoSeleccionado;

        public OrdenIngreso()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            pedidoSeleccionado = null;

            // Generar número temporal de Orden de Ingreso
            // Se asume que el TextBox se llama txtNroOrdenIngreso
            txtNroOrdenIngreso.Text = "OI-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Se asume que el control de fecha es dtpFecha
            dtpFecha.Value = DateTime.Now;

            // Se asume que el control de observaciones es txtObservaciones
            txtObservaciones.Text = string.Empty;

            // Se asume que hay un TextBox de solo lectura para mostrar la selección, ej: txtPedidoSeleccionado
            // Si no existe, puedes usar un Label o simplemente confiar en el dgvPedidosAprobados_CellDoubleClick

            CargarPedidosAprobados();
        }

        private void CargarPedidosAprobados()
        {
            try
            {
                // Llama a la lógica para obtener solo los pedidos en estado 'Aprobado'
                // Este método utiliza datPedidoCompra.Instancia.ListarPedidosAprobados()
                List<entPedidoCompra> lista = logOrdeningreso.Instancia.ListarPedidosAprobados();

                // Configuración Manual DGV (Asumo que el DGV de selección se llama dgvPedidosAprobados)
                // Esto es el DGV que está en la parte superior del formulario de registro.
                dgvPedidosAprobados.Columns.Clear();
                dgvPedidosAprobados.AutoGenerateColumns = false;
                dgvPedidosAprobados.ReadOnly = true;

                // Definición de columnas
                dgvPedidosAprobados.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NroPedido", HeaderText = "N° Pedido Compra" });
                dgvPedidosAprobados.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreProveedor", HeaderText = "Proveedor" });
                dgvPedidosAprobados.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fecha", HeaderText = "Fecha Aprobación", DefaultCellStyle = { Format = "dd/MM/yyyy" } });
                dgvPedidosAprobados.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "PedcompraID", Visible = false });

                dgvPedidosAprobados.DataSource = lista;
                if (lista.Count > 0) dgvPedidosAprobados.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos aprobados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se dispara al hacer doble clic en el DGV para seleccionar el pedido
        private void dgvPedidosAprobados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Capturar la fila seleccionada y la entidad
                pedidoSeleccionado = (entPedidoCompra)dgvPedidosAprobados.Rows[e.RowIndex].DataBoundItem;

                // Mostrar el pedido seleccionado en el control de Nro Pedido
                // Asumo que tienes un control para mostrar el pedido seleccionado
                txtNroPedidoCompraSeleccionado.Text = pedidoSeleccionado.NroPedido + " (" + pedidoSeleccionado.NombreProveedor + ")";

                // Puedes mostrar los detalles del pedido seleccionado en otro DGV si lo deseas
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) // Asumo que este es el botón "Agregar/Registrar"
        {
            // =======================================================
            // 1. VALIDACIÓN DE SELECCIÓN DE PEDIDO COMPRA
            // =======================================================
            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un Pedido de Compra Aprobado de la lista para generar la Orden de Ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // =======================================================
            // 2. VALIDACIÓN DE DATOS DE LA CABECERA (Nro y Observaciones)
            // =======================================================

            // Asumo que el control de fecha (dtpFecha) siempre tiene un valor por defecto.

            // A. Validación del Nro de Orden de Ingreso (Obligatorio)
            if (string.IsNullOrWhiteSpace(txtNroOrdenIngreso.Text))
            {
                MessageBox.Show("Debe ingresar el Número de Orden de Ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroOrdenIngreso.Focus();
                return;
            }

            // B. Validación de Observaciones (Obligatorio, según tu regla)
            if (string.IsNullOrWhiteSpace(txtObservaciones.Text))
            {
                MessageBox.Show("Debe ingresar las Observaciones (el campo no puede estar vacío).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObservaciones.Focus();
                return;
            }

            // =======================================================
            // 3. EJECUCIÓN DE LA TRANSACCIÓN (Si todo es válido)
            // =======================================================

            try
            {
                entOrdeningreso oi = new entOrdeningreso
                {
                    Numero = txtNroOrdenIngreso.Text.Trim(),
                    PedcompraID = pedidoSeleccionado.PedidoCompraID,
                    Fecha = dtpFecha.Value.Date,
                    Observacion = txtObservaciones.Text.Trim()
                };

                // Llama a la Capa Lógica (ejecuta la transacción SQL que aumenta stock y cambia el estado del Pedido)
                int nuevoId = logOrdeningreso.Instancia.RegistrarOrdenIngreso(oi);

                MessageBox.Show($"Orden de Ingreso N° {oi.Numero} registrada con éxito. Stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la Orden de Ingreso: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}