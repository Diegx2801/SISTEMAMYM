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
    public partial class OrdenSalida : Form
    {
        private List<entDetordensalida> listaDetalles = new List<entDetordensalida>();

        public OrdenSalida()
        {
            InitializeComponent();
            InicializarFormulario(); // Usar un método de inicialización centralizado
        }

        // Función centralizada para inicializar y resetear el formulario
        private void InicializarFormulario()
        {
            dgvDetalles.DataSource = null;
            listaDetalles.Clear(); // Asegurar que la lista temporal esté vacía

            // 1. Cargar ComboBox de Obra (solo se hace una vez si los datos no cambian mucho)
            CargarObras();

            // 2. Configurar DataGridView y enlazar la lista vacía
            ConfigurarDgvDetalles(); // Configura las columnas del DGV
            dgvDetalles.DataSource = listaDetalles;

            // 3. Valores por defecto para Cabecera
            dtpFecha.Value = DateTime.Now;
            chkEstado.Checked = false;
            txtObservaciones.Text = string.Empty;
        }

        private void CargarObras()
        {
            try
            {
                // Se asume que tienes logObra y entObra implementados
                cboObra.DataSource = logObra.Instancia.ListarObra();
                cboObra.DisplayMember = "Nombre";
                cboObra.ValueMember = "ObraID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Obras: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDgvDetalles()
        {
            // 1. Crear las columnas solo si no existen
            if (dgvDetalles.Columns.Count == 0)
            {
                dgvDetalles.AutoGenerateColumns = false; // Deshabilitar
                dgvDetalles.ReadOnly = true;

                // Columna 1: ID (Oculta, necesaria para la lógica interna)
                dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "MaterialID",
                    Name = "MaterialID",
                    Visible = false
                });

                // Columna 2: Código (Visible)
                dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "CodigoMaterial",
                    HeaderText = "Código"
                });

                // Columna 3: Material (Visible)
                dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "NombreMaterial",
                    HeaderText = "Material"
                });

                // Columna 4: Unidad de Medida (Visible)
                dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "UnidadMedida",
                    HeaderText = "Unidad de Medida"
                });

                // Columna 5: Cantidad (Visible)
                dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Cantidad",
                    HeaderText = "Cantidad"
                });
            }

            // 2. Ajuste de auto-tamaño
            dgvDetalles.AutoResizeColumns();
        }

        private void RefrescarDgvDetalles()
        {
            // 1. Forzar la actualización del enlace
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = listaDetalles;

            // 2. Configurar las columnas (si ya existen, solo aplica el ajuste de tamaño)
            ConfigurarDgvDetalles();
        }

        private void LimpiarDetalle()
        {
            txtCodigoMaterial.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        // ==============================================================================
        // Lógica de Detalle: Botón AGREGAR
        // ==============================================================================
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            // Lógica interna idéntica a la que proporcionaste, solo cambiamos el refresco
            if (string.IsNullOrWhiteSpace(txtCodigoMaterial.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar el Código y la Cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCantidad.Text.Trim(), out decimal cantidadRequerida) || cantidadRequerida <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número válido y mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string codigo = txtCodigoMaterial.Text.Trim();
                entMaterial materialEncontrado = logOrdensalida.Instancia.ValidarYBuscarMaterial(codigo, cantidadRequerida);

                entDetordensalida nuevoDetalle = new entDetordensalida
                {
                    MaterialID = materialEncontrado.MaterialID,
                    CodigoMaterial = materialEncontrado.Codigo,
                    NombreMaterial = materialEncontrado.Nombre,
                    UnidadMedida = materialEncontrado.UnidadMedida,
                    Cantidad = cantidadRequerida,
                };

                listaDetalles.Add(nuevoDetalle);

                // Usamos la función de refresco
                RefrescarDgvDetalles();
                LimpiarDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==============================================================================
        // Lógica de Registro: Botón AÑADIR ORDEN DE SALIDA
        // ==============================================================================
        private void btnAnadirOrdenSalida_Click(object sender, EventArgs e)
        {
            // 1. Validar Número de Orden (Campo Obligatorio)
            if (string.IsNullOrWhiteSpace(txtNroOrdenSalida.Text))
            {
                MessageBox.Show("Debe ingresar el Número de Orden de Salida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroOrdenSalida.Focus();
                return;
            }

            // 2. Validar Obra (Campo Obligatorio)
            if (cboObra.SelectedValue == null || (int)cboObra.SelectedValue == 0)
            {
                MessageBox.Show("Debe seleccionar la Obra de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboObra.Focus();
                return;
            }
            if (chkEstado.Checked == false)
            {
                MessageBox.Show("La Orden de Salida debe estar marcada como 'Estado Activo' para registrarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkEstado.Focus();
                return;
            }
            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un material para registrar la Orden de Salida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entOrdensalida os = new entOrdensalida
                {
                    Numero = txtNroOrdenSalida.Text.Trim(),
                    ObraID = (int)cboObra.SelectedValue,
                    Fecha = dtpFecha.Value.Date,
                    Observacion = txtObservaciones.Text.Trim(),
                    Estado = "Registrado",
                    Detalle = listaDetalles
                };

                int nuevoId = logOrdensalida.Instancia.InsertarOrdensalida(os);

                MessageBox.Show($"Orden de Salida N° {os.Numero} (ID: {nuevoId}) registrada con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // CORRECCIÓN CLAVE: Usar la función de inicialización para reiniciar
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la Orden de Salida: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
