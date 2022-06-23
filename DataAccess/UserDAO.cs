using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserDAO : ConnectionSQLdb //Indico que la clase UserDAO hereda de la clase ConnectionSQLdb
    {
        //Creamos un tipo bool para el login del usuario
        //Como parametros de entrada tenemos UserName y Password
        public bool Login(string UserName, string Password)
        {
            //Creamos un bloque using declaramos una variable implícita de nombre conexión que será igual a la instancia sql conexión del método obtener conexión de la clase base conexión
            using (var connection = GetConnection())
            {
                //Abrimos la coneccion
                connection.Open();
                //Creamos otro bloque using para el objeto sql comando
                //
                using (var comando = new SqlCommand())
                {
                    //especificamos la conexión del comando
                    comando.Connection = connection;
                    //especificamos el texto de comando
                    comando.CommandText = "select * from Users where UserName=@UserName and Password=@Password";
                    comando.Parameters.AddWithValue("@UserName", UserName);
                    comando.Parameters.AddWithValue("@Password", Password);
                    comando.CommandType = System.Data.CommandType.Text; //Ojo con esto, dudo q ande
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
