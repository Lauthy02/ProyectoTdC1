using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos la capa de acceso a datos
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        //instanciamos al objeto de acceso a datos de usuario
        UserDAO userDao = new UserDAO();
        //creamos un método bool de nombre inicio de sesión de usuario
        public bool LoginUser(string UserName, string Password)
        {
            //retornamos el método login del objeto de acceso de datos
            return userDao.Login(UserName, Password);
        }
    }
}
