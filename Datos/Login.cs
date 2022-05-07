using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Login
    {
        public static int GetPermission(string name, string password)
        {
            //Aca deberia crear la conexion con la base de datos, pero ahora
            //solo voy a emularlo.
            //Busco el usuario y la contraseña, si existen, devuelvo 1 sino 0
            if (name == "admin" && password == "admin") return 1;
            return 0;
        }
    }
}
