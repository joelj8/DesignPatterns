using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class ConexionSQL : IConexion
    {
            private string host;
            private string port;
            private string user;
            private string password;

            public ConexionSQL()
            {
                this.host = "localhost";
                this.port = "5433";
                this.user = "usrSQL";
                this.password = "pwdSQL";
            }

            public void conectar()
            {
                Console.WriteLine("Conectado a BD SQL");
            }

            public void desconectar()
            {
                Console.WriteLine("Desconectado de BD SQL");
            }
     }
 
}