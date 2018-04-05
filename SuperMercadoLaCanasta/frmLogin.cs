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
    public partial class frmLogin : Form
    {
        LClUsuarios lUsuario;

        public frmLogin()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtUsuario,"Ingrese un Usuario");
            this.ttmensaje.SetToolTip(this.txtContrasena,"Ingrese Contraseña");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

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
                        new frmSugeridos(usuario).Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Erro al Ingresar ");
                }else
                    MessageBox.Show("Campos Incompletos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar");
                Console.WriteLine("Error al Ingresar :"+ex.Message);
            }
        }
        /// <summary>
        /// Boton para cerrar el formulario de Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSalir_Click(object sender, EventArgs e)
       => this.Close();

    }
}
