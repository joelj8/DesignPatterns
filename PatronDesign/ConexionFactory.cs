using PatronDesign.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesign
{
    class ConexionFactory 
    {
        public IConexion getConexion(string myDB)
        {
            if (myDB == null)
            {
                return new Conexiones();
            }
            if (myDB.ToUpper().Contains("MYSQL"))
            {
                return new ConexionMYSQL();
            } else if (myDB.ToUpper().Contains("ORACLE"))
            {
                return new ConexionORA();

            } else if (myDB.ToUpper().Contains("SQL"))
            {
                return new ConexionSQL();
            } 
            
            return new Conexiones();
            
        }
    }
}
