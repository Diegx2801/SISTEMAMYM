using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
 
    public partial class FrmLogin : Form
    {


        private readonly Dictionary<string, (string Password, string Rol)> _users =
            new Dictionary<string, (string Password, string Rol)>(StringComparer.OrdinalIgnoreCase)
            {
        { "admin", ("1234", "Gerente") },
        { "asis",  ("1234", "Asistente de Producción") },
        { "alm",   ("1234", "Almacenero") },
        { "prov",  ("1234", "Proveedor") },
        { "dis",   ("1234", "Distribuidor") }
            };


        public FrmLogin()
            {
                InitializeComponent();

                btnSalir.Click += (s, e) => Application.Exit();
                chkVer.CheckedChanged += (s, e) => txtPassword.UseSystemPasswordChar = !chkVer.Checked;
                txtUsuario.Focus();
            }

            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

            private void btnIngresar_Click(object sender, EventArgs e)
            {
                var user = txtUsuario.Text.Trim();
                var pass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                    return;

                if (_users.TryGetValue(user, out var data) && data.Password == pass)
                {
                    // setea sesión
                    Sesion.Usuario = user;
                    Sesion.Rol = data.Rol;

                    // navegación por rol (ajusta según tu clase Sesion)
                    Form destino = null;
                    if (Sesion.EsAsistente || Sesion.EsGerencia)
                        destino = new BandejaRequerimientosForm();
                    else if (Sesion.EsProveedor)
                        destino = new MantenedorProveedor();
                    else
                    {
                        MessageBox.Show("Tu rol no tiene una pantalla inicial asignada.");
                        return;
                    }

                    destino.FormClosed += (s2, e2) => Application.Exit();
                    destino.Show();
                    this.Hide();
                }
                else
                {
                    // credenciales no válidas
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }

            private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        
    }
}
