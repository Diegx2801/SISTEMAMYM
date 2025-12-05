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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            new MantenedorMaterial().ShowDialog();

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            new MantenedorMarca().ShowDialog();
        }

        private void btnFormaPago_Click(object sender, EventArgs e)
        {
            new MantenedorFormaDePago().ShowDialog();
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            new MantenedorObra().ShowDialog();
        }

        private void btnTipoMaterial_Click(object sender, EventArgs e)
        {
            new MantenedorTipoMaterial().ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            new MantenedorProveedor().ShowDialog();
        }

        private void btnOrdenIngreso_Click(object sender, EventArgs e)
        {
            new BandejaOrdenIngreso().ShowDialog();
        }

        private void btnRequerimientoCompra_Click(object sender, EventArgs e)
        {
            new RequerimientosCompras().ShowDialog();
        }

        private void btnOrdenSalida_Click(object sender, EventArgs e)
        {
            new BandejaOrdenSalida().ShowDialog();
        }

        private void btnPedidoCompra_Click(object sender, EventArgs e)
        {
            new BandejaRequerimientosCompras().ShowDialog();
        }
    }
}
