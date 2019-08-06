using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class ConexionORA : IConexion
    {
        private string host;
        private string port;
        private string user;
        private string password;

        public ConexionORA()
        {
            this.host = "localhost";
            this.port = "2103";
            this.user = "usrORA";
            this.password = "pwdORA";
        }
        public void conectar()
        {
            Console.WriteLine("Conectado a BD ORACLE");
        }

        public void desconectar()
        {
            Console.WriteLine("Desconectado de BD ORACLE");
        }
    }
}
