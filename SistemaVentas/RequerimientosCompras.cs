using CapaEntidad;
using CapaLogica;
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CapaAccesoDatos;

namespace SistemaVentas
{
    public partial class RequerimientosCompras : Form
    {
        public RequerimientosCompras()
        {
            InitializeComponent();
        }

        private void CargarBandeja()
        {
            dgvRequerimientos.AutoGenerateColumns = false;

            DateTime? desde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

            var lista = logReqcompra.Instancia.Listar(
            string.IsNullOrEmpty(txtBuscarNumReq.Text) ? (int?)null : int.Parse(txtBuscarNumReq.Text),
            cboObra.SelectedIndex <= 0 ? (int?)null : (int)cboObra.SelectedValue,
            string.IsNullOrEmpty(cboEstado.Text) ? null : cboEstado.Text,
            desde, hasta);

            dgvRequerimientos.DataSource = lista;
        }

        // Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new RegistrarRequerimientoCompra())
            {
                if (frm.ShowDialog() == DialogResult.OK) CargarBandeja();
            }
        }

        // Enviar
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells["ReqcompraID"].Value);
            if (logReqcompra.Instancia.EnviarACompras(id)) MessageBox.Show("Enviado a compras");
            CargarBandeja();
        }

        // Anular
        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvRequerimientos.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells["ReqcompraID"].Value);
            if (logReqcompra.Instancia.Anular(id))
                MessageBox.Show("Requerimiento anulado.");
            CargarBandeja();
        }

        // Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void RequerimientosCompras_Load(object sender, EventArgs e)
        {
            CargarBandeja();
        }

        private void grpFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            // Verificar si hay una fila seleccionada
            if (dgvRequerimientos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un requerimiento para imprimir.");
                return;
            }

            // Obtener el ReqcompraID del requerimiento seleccionado
            int reqcompraID = Convert.ToInt32(dgvRequerimientos.CurrentRow.Cells["ReqcompraID"].Value);

            // Definir la ruta donde se guardará el archivo PDF
            string pdfFilePath = $"D:\\DIEGO\\DOCUMENTOS\\Requerimiento_{reqcompraID}.pdf";

            // Crear el documento PDF
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
            doc.Open();

            // Información general del requerimiento (Encabezado)
            Paragraph header = new Paragraph($"Reporte del Requerimiento de Compra {reqcompraID}");
            header.Alignment = Element.ALIGN_CENTER;
            doc.Add(header);

            // Obtener los detalles del requerimiento (por ejemplo, Número, Obra, Estado, etc.)
            string obra = dgvRequerimientos.CurrentRow.Cells["ObraID"].Value.ToString();
            string estado = dgvRequerimientos.CurrentRow.Cells["Estado"].Value.ToString();
            string solicitante = dgvRequerimientos.CurrentRow.Cells["Solicitante"].Value.ToString();
            string prioridad = dgvRequerimientos.CurrentRow.Cells["Prioridad"].Value.ToString();

            // Agregar los datos generales del requerimiento
            doc.Add(new Paragraph($"Obra: {obra}"));
            doc.Add(new Paragraph($"Estado: {estado}"));
            doc.Add(new Paragraph($"Solicitante: {solicitante}"));
            doc.Add(new Paragraph($"Prioridad: {prioridad}"));
            doc.Add(new Paragraph(""));

            // Obtener los materiales asociados a este requerimiento
            List<MaterialReq> materiales = datReqcompra.Instancia.ObtenerMaterialesPorRequerimiento(reqcompraID);

            // Crear una tabla para los detalles de los materiales
            PdfPTable table = new PdfPTable(5);  // 5 columnas: ID, Material, Unidad, Cantidad, Observación
            table.AddCell("ID");
            table.AddCell("Material");
            table.AddCell("Unidad");
            table.AddCell("Cantidad");
            table.AddCell("Observación");

            // Agregar los materiales del requerimiento en la tabla
            foreach (var material in materiales)
            {
                table.AddCell(material.MaterialID.ToString());
                table.AddCell(material.NombreMaterial);
                table.AddCell(material.UnidadMedida);
                table.AddCell(material.Cantidad.ToString());
                table.AddCell(material.Observacion);
            }

            // Agregar la tabla de detalles al documento
            doc.Add(table);

            // Cerrar el documento
            doc.Close();

            // Confirmar al usuario que el PDF ha sido generado
            MessageBox.Show($"PDF del requerimiento {reqcompraID} exportado correctamente!");
        }
    }
}
