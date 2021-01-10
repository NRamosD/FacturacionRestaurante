using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD
{
    class conexion
    {
<<<<<<< HEAD
        public string cadena = "Data Source =NR; Initial Catalog = Invoice; Integrated Security = true";
=======
        public string cadena = "Data Source = DESKTOP-8BF136O; Initial Catalog = Invoice; Integrated Security = true";
>>>>>>> 83b2f563d682904e8e9a7e2d9004453f7874e505
        public SqlConnection conectar = new SqlConnection();

        public conexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al conectarse.\n" + e);
            }
        }
        public void cerrar()
        {
            conectar.Close();
        }
    }
}
