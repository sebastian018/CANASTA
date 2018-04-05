using Entidades.Usuarios;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercadoLaCanasta
{
    public partial class login : Form
    {
        LClUsuarios lUsuario;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 alto = (desktopSize.Height - 280) / 2;
            Int32 ancho = (desktopSize.Width - 500) / 2;
            panel1.Location = new Point(ancho, alto);

            this.ttmensaje.SetToolTip(this.txtUsuario, "Ingrese un Usuario");
            this.ttmensaje.SetToolTip(this.txtContrasena, "Ingrese Contraseña");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Trim() != "" && txtContrasena.Text.Trim() != "")
                {
                    lUsuario = new LClUsuarios();

                    EClUsuarios user = new EClUsuarios();
                    user.usuario = txtUsuario.Text;
                    user.password = txtContrasena.Text;

                    EClUsuarios usuario = lUsuario.mtdListarUsuarios(user);

                    if (usuario.usuario != null)
                    {
                        MessageBox.Show("Hola .................Bienvenido");
                        new frmAgregarSugerido(usuario).Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Erro al Ingresar ");
                }
                else
                    MessageBox.Show("Campos Incompletos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar");
                Console.WriteLine("Error al Ingresar :" + ex.Message);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        => this.WindowState = FormWindowState.Minimized;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
