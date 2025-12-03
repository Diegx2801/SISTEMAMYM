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
    public partial class MantenedorFormaDePago : Form
    {
        public MantenedorFormaDePago()
        {
            InitializeComponent();
            listar();
            groupBoxDatos.Enabled = false;
            txtFormapagoID.Enabled = false;
        }

        private void listar()
        {
            dgvFormapago.DataSource = logFormapago.Instancia.ListarFormapago();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entFormapago fp = new entFormapago
            {
                Entidad = txtEntidad.Text.Trim(),
                Condiciones = txtCondiciones.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Estado = chkEstado.Checked
            };

            logFormapago.Instancia.InsertarFormapago(fp);

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void dgvFormapago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvFormapago.Rows[e.RowIndex];
            txtFormapagoID.Text = fila.Cells[0].Value.ToString();
            txtEntidad.Text = fila.Cells[1].Value.ToString();
            txtCondiciones.Text = fila.Cells[2].Value.ToString();
            txtDescripcion.Text = fila.Cells[3].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(fila.Cells[4].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            entFormapago fp = new entFormapago
            {
                FormapagoID = int.Parse(txtFormapagoID.Text),
                Entidad = txtEntidad.Text.Trim(),
                Condiciones = txtCondiciones.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Estado = chkEstado.Checked
            };

            logFormapago.Instancia.EditarFormapago(fp);

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFormapagoID.Text);
            logFormapago.Instancia.DeshabilitarFormapago(id);

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void limpiar()
        {
            txtFormapagoID.Text = "";
            txtEntidad.Text = "";
            txtCondiciones.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
