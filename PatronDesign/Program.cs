using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Probando el patron de diseño Singlenton
            //TestSinglenton();

            // Probando el patron de diseño Factory
            //TestFactory();

            // Probando el patron de diseño Factory Abstract
            //TestFactoryAbstract();

        }

        private static void TestSinglenton()
        {
            SingleT myConect = SingleT.getSingleT();
            //SingleT myConect2 = SingleT.getSingleT();
            myConect.conectar();
            myConect.desconectar();

            //myConect2.conectar();
            //myConect2.desconectar();

            var ret = myConect.GetType();
            Console.WriteLine(ret);
            Console.ReadKey();
        }

        private static void TestFactory()
        {
            ConexionFactory conectToFactory = new ConexionFactory();

            IConexion conectBD = conectToFactory.getConexion("Oracle");
            conectBD.conectar();
            conectBD.desconectar();
            Console.ReadKey();


        }

    }
}
