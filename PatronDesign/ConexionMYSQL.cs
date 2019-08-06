using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class ConexionMYSQL : IConexion
    {
        private string host;
        private string port;
        private string user;
        private string password;

        public ConexionMYSQL()
        {
            this.host = "localhost";
            this.port = "2103";
            this.user = "usrMySQL";
            this.password = "pwdMySQL";
        }
        public void conectar()
        {
            Console.WriteLine("Conectado a BD MySQL");
        }

        public void desconectar()
        {
            Console.WriteLine("Desconectado de BD MySQL");
        }
    }
}
