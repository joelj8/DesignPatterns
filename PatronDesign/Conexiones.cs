using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class Conexiones: IConexion
    {
        private string host;
        private string port;
        private string user;
        private string password;

        public Conexiones()
        {
            this.host = "localhost";
            this.port = "5433";
            this.user = "usrND";
            this.password = "pwdND";

        }

        public void conectar()
        {
            Console.WriteLine("No fue definida BD a Conectar");
        }

        public void desconectar()
        {
            Console.WriteLine("No fue definida BD a Desconectar");
        }
    }

}
