using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace SistemaVentas
{
    public partial class BandejaOrdenSalida : Form
    {
        public BandejaOrdenSalida()
        {
            InitializeComponent();
            CargarCombos();
            // Mostrar solo la fecha en los DateTimePickers
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpHasta.Format = DateTimePickerFormat.Short;

            ListarBandeja(false);
        }


        private void CargarCombos()
        {
            // Cargar el ComboBox de Obra (filtro)
            // Necesitas la clase logObra y entObra, siguiendo el patrón de MantenedorMaterial.
            try
            {
                // Se asume que tienes logObra y entObra implementados:
                List<entObra> listaObras = logObra.Instancia.ListarObra();

                // Añadir una opción para "Todas las Obras" (opcional pero útil)
                listaObras.Insert(0, new entObra { ObraID = 0, Nombre = "--- Todas ---" });

                cboObraFiltro.DataSource = listaObras;
                cboObraFiltro.DisplayMember = "Nombre";
                cboObraFiltro.ValueMember = "ObraID";
                cboObraFiltro.SelectedValue = 0; // Seleccionar "Todas" por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Obras: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarBandeja(bool mostrarMensaje = true)
        {
            try
            {
                // 1. Obtener filtros y llamar a la Capa Lógica (sin cambios)
                string num = txtNroPedido.Text.Trim();
                int obraIdSeleccionada = (int)cboObraFiltro.SelectedValue;
                int? obraId = (obraIdSeleccionada > 0) ? obraIdSeleccionada : (int?)null;
                DateTime? desde = dtpDesde.Value.Date;
                DateTime? hasta = dtpHasta.Value.Date;

                List<entOrdensalida> lista = logOrdensalida.Instancia.ListarOrdensalida(num, obraId, desde, hasta);

                // 2. CONFIGURACIÓN MANUAL DE COLUMNAS
                if (dgvOrdenes.Columns.Count == 0)
                {
                    dgvOrdenes.AutoGenerateColumns = false; // Deshabilitar la generación automática

                    // -----------------------------------------------------
                    // >> INICIO DE LA CREACIÓN MANUAL DE COLUMNAS <<
                    // -----------------------------------------------------

                    // Columna 1: N° Pedido (Visible)
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Numero",
                        HeaderText = "N° Pedido",
                        Name = "Numero"
                    });

                    // Columna 2: Obra (Visible)
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "NombreObra", // Propiedad que trae el nombre de la obra
                        HeaderText = "Obra",
                        Name = "NombreObra"
                    });

                    // Columna 3: Fecha (Visible y Formateada)
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Fecha",
                        HeaderText = "Fecha",
                        Name = "Fecha",
                        DefaultCellStyle = { Format = "dd/MM/yyyy" } // Formato de fecha
                    });

                    // Columna 4: Estado (Visible)
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Estado",
                        HeaderText = "Estado",
                        Name = "Estado"
                    });

                    // Columna 5: OrdensalidaID (Oculta, necesaria para Anular)
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "OrdensalidaID",
                        HeaderText = "ID",
                        Name = "OrdensalidaID",
                        Visible = false // Ocultar
                    });

                    // -----------------------------------------------------
                    // >> FIN DE LA CREACIÓN MANUAL DE COLUMNAS <<
                    // -----------------------------------------------------
                }

                // 3. Asignar el origen de datos
                dgvOrdenes.DataSource = lista;

                // 4. Ajuste de auto-tamaño y control de mensaje (sin cambios)
                if (lista.Count > 0)
                {
                    dgvOrdenes.AutoResizeColumns();
                }

                if (lista.Count == 0 && mostrarMensaje)
                {
                    MessageBox.Show("No se encontraron Órdenes de Salida con los filtros especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar órdenes: " + ex.Message, "Error de Listado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Evento btnBuscar_Click (LLAMA CON MOSTRARMENSAJE = TRUE) ---
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Llama a ListarBandeja y permite que muestre el mensaje si está vacío
            ListarBandeja(true);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar la Orden de Salida a anular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener el objeto entOrdensalida de la fila seleccionada
                entOrdensalida osSeleccionada = (entOrdensalida)dgvOrdenes.SelectedRows[0].DataBoundItem;

                if (osSeleccionada.Estado == "Anulado")
                {
                    MessageBox.Show("La Orden de Salida ya se encuentra Anulada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje = $"¿Está seguro de anular la Orden de Salida N° {osSeleccionada.Numero}? Esta acción revertirá el stock de los materiales.";

                if (MessageBox.Show(mensaje, "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Llamar a la Capa Lógica para realizar la transacción de anulación y reversión de stock
                    logOrdensalida.Instancia.AnularOrdensalida(osSeleccionada);

                    MessageBox.Show("Orden de Salida anulada con éxito y stock revertido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarBandeja(); // Refrescar la bandeja para ver el nuevo estado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular la Orden de Salida: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarOrdenSalida_Click(object sender, EventArgs e)
        {
            // Asumiendo que el formulario de registro se llama RegistrarOrdenSalida
            OrdenSalida frm = new OrdenSalida();
            frm.ShowDialog();

            // Refrescar la bandeja después de cerrar el formulario de registro
            ListarBandeja(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
