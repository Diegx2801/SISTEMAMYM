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
    public partial class MantenedorProveedor : Form
    {
        public MantenedorProveedor()
        {
            InitializeComponent();
            listar();
            groupBoxDatos.Enabled = false;
            txtProveedorID.Enabled = false;
        }

        private void listar()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            limpiar();
            chkEstadoProveedor.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor p = new entProveedor
                {
                    Ruc = txtRuc.Text.Trim(),
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chkEstadoProveedor.Checked
                };

                logProveedor.Instancia.InsertarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar proveedor: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];

                
                txtProveedorID.Text = fila.Cells[0].Value.ToString();   
                txtRuc.Text = fila.Cells[1].Value.ToString();    
                txtRazonSocial.Text = fila.Cells[2].Value.ToString();    
                txtTelefono.Text = fila.Cells[3].Value.ToString();    
                txtCorreo.Text = fila.Cells[4].Value.ToString();   
                txtDireccion.Text = fila.Cells[5].Value.ToString();    
                txtDescripcion.Text = fila.Cells[6].Value.ToString();    
                chkEstadoProveedor.Checked = Convert.ToBoolean(fila.Cells[7].Value); 
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProveedorID.Text))
            {
                MessageBox.Show("Selecciona un proveedor primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entProveedor p = new entProveedor
                {
                    ProveedorID = int.Parse(txtProveedorID.Text.Trim()),
                    Ruc = txtRuc.Text.Trim(),
                    RazonSocial = txtRazonSocial.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Estado = chkEstadoProveedor.Checked
                };

                logProveedor.Instancia.EditarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar proveedor: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProveedorID.Text))
            {
                MessageBox.Show("Selecciona un proveedor primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                entProveedor p = new entProveedor
                {
                    ProveedorID = int.Parse(txtProveedorID.Text.Trim())
                };

                logProveedor.Instancia.DeshabilitarProveedor(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar proveedor: " + ex.Message);
            }

            limpiar();
            groupBoxDatos.Enabled = false;
            listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            txtProveedorID.Text = "";
            txtRuc.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            chkEstadoProveedor.Checked = false;
        }
    }
}
