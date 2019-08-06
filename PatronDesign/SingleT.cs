using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    public class SingleT
    {
        private static SingleT instancia;
        private SingleT()
        {

        }

        public static SingleT getSingleT()
        {
            if (instancia == null)
            {
                instancia = new SingleT();
            }
            return instancia;
        }

        public void conectar() {
            Console.WriteLine("Conectado a la BD");
        }

        public void desconectar() {
            Console.WriteLine("Desconectado de la BD");
        }
    }
}
