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
            
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpHasta.Format = DateTimePickerFormat.Short;

            ListarBandeja(false);
        }


        private void CargarCombos()
        {
            
            
            try
            {
                
                List<entObra> listaObras = logObra.Instancia.ListarObra();

                
                listaObras.Insert(0, new entObra { ObraID = 0, Nombre = "--- Todas ---" });

                cboObraFiltro.DataSource = listaObras;
                cboObraFiltro.DisplayMember = "Nombre";
                cboObraFiltro.ValueMember = "ObraID";
                cboObraFiltro.SelectedValue = 0; 
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
                
                string num = txtNroPedido.Text.Trim();
                int obraIdSeleccionada = (int)cboObraFiltro.SelectedValue;
                int? obraId = (obraIdSeleccionada > 0) ? obraIdSeleccionada : (int?)null;
                DateTime? desde = dtpDesde.Value.Date;
                DateTime? hasta = dtpHasta.Value.Date;

                List<entOrdensalida> lista = logOrdensalida.Instancia.ListarOrdensalida(num, obraId, desde, hasta);

                
                if (dgvOrdenes.Columns.Count == 0)
                {
                    dgvOrdenes.AutoGenerateColumns = false; 

                  

                   
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Numero",
                        HeaderText = "N° Pedido",
                        Name = "Numero"
                    });

                    
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "NombreObra", 
                        HeaderText = "Obra",
                        Name = "NombreObra"
                    });

                    
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Fecha",
                        HeaderText = "Fecha",
                        Name = "Fecha",
                        DefaultCellStyle = { Format = "dd/MM/yyyy" } 
                    });

                    
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Estado",
                        HeaderText = "Estado",
                        Name = "Estado"
                    });

                    
                    dgvOrdenes.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "OrdensalidaID",
                        HeaderText = "ID",
                        Name = "OrdensalidaID",
                        Visible = false 
                    });

                  
                }

                
                dgvOrdenes.DataSource = lista;

               
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

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
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
                
                entOrdensalida osSeleccionada = (entOrdensalida)dgvOrdenes.SelectedRows[0].DataBoundItem;

                if (osSeleccionada.Estado == "Anulado")
                {
                    MessageBox.Show("La Orden de Salida ya se encuentra Anulada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje = $"¿Está seguro de anular la Orden de Salida N° {osSeleccionada.Numero}? Esta acción revertirá el stock de los materiales.";

                if (MessageBox.Show(mensaje, "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    logOrdensalida.Instancia.AnularOrdensalida(osSeleccionada);

                    MessageBox.Show("Orden de Salida anulada con éxito y stock revertido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarBandeja(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular la Orden de Salida: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarOrdenSalida_Click(object sender, EventArgs e)
        {
            
            OrdenSalida frm = new OrdenSalida();
            frm.ShowDialog();

            
            ListarBandeja(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
