using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencio a la librería Data.SqlClient
using System.Data.SqlClient;

namespace DataAccess
{
    //Clase abstracta porque es una clase base, no será instanciada 
    public abstract class ConnectionSQLdb //Nombre de la clase
    {
        //Declaramos una variable privada tipo string para la cadena de conección
        //Es privada porque yo solo quiero que la modifique y la acceda la misma clase 
        private readonly string StringDeConeccion; 

        //Creamos el constructor e inicializamos la cadena de conección
        public ConnectionSQLdb()
        {
            StringDeConeccion = "Server=DESKTOP-GSR7RFN\\SQLEXPRESS; Database=SistemaAutomecanica; integrated security=true";
        }

        //Creamos un método protegido de tipo conección para obtener la conección
        //Es protegido porque solo deseo que sea accedido desde una clase derivada 
        protected SqlConnection GetConnection()
        {
            //Retornamos una instancia de SqlConnection con el parámetro StringDeConeccion, es decir, la cadena de conección
            return new SqlConnection(StringDeConeccion);


        }
    }
}
