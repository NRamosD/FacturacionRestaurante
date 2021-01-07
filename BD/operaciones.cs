using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;*/

namespace BD
{
    class operaciones
    {

        /*Conexion objConnection = new Conexion();
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable mostrar()
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM materias", objConnection.conectar);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
                return tabla;
            }
            catch
            {
                return tabla;
            }
        }

        public void Insertar(string _CodMateria, string _Nombre)
        {
            try
            {
                objConnection.abrir();
                string cadena = "INSERT INTO materias(txtCodigo,txtNombre) VALUES(" + _CodMateria + "," + _Nombre + ")";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
        }

        public void Eliminar(string id)
        {
            try
            {
                objConnection.abrir();
                string cadena = "DELETE FROM materias where txtCodigo=" + id;
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch
            {

            }
        }
        public void Editar(string id, string nom)
        {
            objConnection.abrir();
            string cadena = "DELETE FROM materias where txtCodigo=" + id;
            SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);
            comando.ExecuteNonQuery();
            objConnection.cerrar();
        }
        */


    }
}
