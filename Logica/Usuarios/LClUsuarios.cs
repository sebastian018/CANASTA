using Data.Usuarios;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Usuarios
{
    public class LClUsuarios
    {
        DClUsuarios dUsuarios = new DClUsuarios();

        public EClUsuarios mtdListarUsuarios(EClUsuarios user)
          => dUsuarios.mtdListarUsuarios(user);
    }
}
