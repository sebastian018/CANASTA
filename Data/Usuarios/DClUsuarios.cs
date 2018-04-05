using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public class DClUsuarios
    {
        ClTransacciones transaccion = new ClTransacciones();

        public EClUsuarios mtdListarUsuarios(EClUsuarios user)
        {
            EClUsuarios usuario = new EClUsuarios();

            try
            {
                string consulta = string.Format(@"SELECT CODUSUARIO, USUARIO FROM USUARIOS WHERE USUARIO = '{0}' AND PASS = '{1}'", user.usuario,user.password);
                DataTable tablaUsuarios = transaccion.mtdListar(consulta);

                for (int i = 0; i < tablaUsuarios.Rows.Count; i++)
                {
                    usuario.codUsuario = int.Parse(tablaUsuarios.Rows[i]["CODUSUARIO"].ToString());
                    usuario.usuario = tablaUsuarios.Rows[i]["USUARIO"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar Usuarios: "+ex.Message);
            }

            return usuario;
        }
    }
}
