using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Login
    {
        public static int GetPermission(string name, string password)
        {
            return Datos.Login.GetPermission(name, password);
        }
    }
}
