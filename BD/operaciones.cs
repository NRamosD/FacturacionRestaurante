using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace BD
{
    public class operaciones
    {

        conexion objConnection = new conexion();
        DataTable tabla = new DataTable();
        MySqlCommand comando = new MySqlCommand();

        public DataTable MostrarCliente(string _ci)
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Customers WHERE txtId_Card = '" + _ci + "'", objConnection.conectar);
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

        public int CrearNuevoIdCliente()
        {
            objConnection.abrir();
            SqlCommand command = new SqlCommand("NewIdCustomer", objConnection.conectar);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable id = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(id);
            objConnection.cerrar();
            return Convert.ToInt16(id.Rows[0][0]);
        }

        public void InsertarCliente(int _id, string _ci, string _fn, string _ln, string _cp, string _ed, string _dir, string _sexo)
        {
            try
            {
                    objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [dbo].[Customers] (intId_Customer, txtId_Card, txtFirst_Name, txtLast_Name, txtCell_Phone, txtEmail_Direction, txtDirection, txtSex)" +
                    "VALUES(@id, @ci, @fn, @ln, @cp, @ed, @dir, @sexo) GO", objConnection.conectar);
                command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                command.Parameters.Add("@ci", SqlDbType.Char, 10).Value = _ci;
                command.Parameters.Add("@fn", SqlDbType.VarChar, 50).Value = _fn;
                command.Parameters.Add("@ln", SqlDbType.VarChar, 50).Value = _ln;
                command.Parameters.Add("@cp", SqlDbType.Char, 10).Value = _cp;
                command.Parameters.Add("@ed", SqlDbType.VarChar, 50).Value = _ed;
                command.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = _dir;
                command.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = _sexo;
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void EditarCliente(int _id, string _cp, string _ed, string _dir)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "UPDATE Customers SET " +
                    "txtCell_Phone = '" + _cp +
                    "', txtEmail_Direction = '" + _ed +
                    "', txtDirection = '" + _dir +
                    "' WHERE intId_Customer = " + _id, objConnection.conectar);                
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("-> Error" + ex);
            }
}

        public void EliminarCliente(int _id)
        {
            try
            {
                objConnection.abrir();
                string cadena = "ALTER TABLE Customers NOCHECK CONSTRAINT FK_Orders_Customers GO";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);

                cadena = "DELETE FROM Customers where intId_Customer=" + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);

                cadena = "ALTER TABLE Customers CHECK CONSTRAINT FK_Orders_Customers GO";
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception)
            {
                return;
            }
        }

        //----------------------------------------------------------------------------------------------------------
        public DataTable MostrarProducto(int _id)
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Products WHERE intId_Product = '" + _id + "'", objConnection.conectar);
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

        public DataTable MostrarProductos()
        {
            try
            {
                objConnection.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Products", objConnection.conectar);
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

        public int ObtenerTotalProductos()
        {
            objConnection.abrir();
            SqlCommand command = new SqlCommand("QuantiyProducts", objConnection.conectar);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable id = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(id);

            return Convert.ToInt16(id.Rows[0][0]);
        }

        public int CrearNuevoIdProducto()
        {
            objConnection.abrir();
            SqlCommand command = new SqlCommand("NewIdProduct", objConnection.conectar);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable id = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(id);

            return Convert.ToInt16(id.Rows[0][0]);
        }

        public void InsertarProducto(int _id,string _nom, double _prec, string _cat, byte[] _img)
        {
            objConnection.abrir();
            SqlCommand command = new SqlCommand(
                      "INSERT INTO Products (intId_Product, txtName, mnPrice, txtCategory, vbPicture)" +
                      "Values(@id, @nom, @prec, @cat, @img)", objConnection.conectar);
            command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
            command.Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = _nom;
            command.Parameters.Add("@prec", SqlDbType.Money).Value = _prec;
            command.Parameters.Add("@cat", SqlDbType.Char, 1).Value = _cat;
            command.Parameters.Add("@img", SqlDbType.VarBinary, _img.Length).Value = _img;
            command.ExecuteNonQuery();
            objConnection.cerrar();
            Console.WriteLine("Ingresado correctamente :)");
        }

        public void EditarProducto(int _id, string _nom, double _prec, byte[] _img)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "UPDATE Products SET " +
                    "', txtName = '" + _nom +
                    "', mnPrice = '" + _prec +
                    "', vbPicture = '" + _img +
                    "' WHERE intId_Product = " + _id + "GO", objConnection.conectar);
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void EliminarProducto(int _id)
        {
            try
            {
                objConnection.abrir();
                string cadena = "ALTER TABLE Products NOCHECK CONSTRAINT FK_Orders_Producs GO";
                SqlCommand comando = new SqlCommand(cadena, objConnection.conectar);

                cadena = "DELETE FROM Products where intId_Customer=" + _id;
                comando = new SqlCommand(cadena, objConnection.conectar);

                cadena = "ALTER TABLE Products CHECK CONSTRAINT intId_Product GO";
                comando = new SqlCommand(cadena, objConnection.conectar);
                comando.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception)
            {
                return;
            }
        }
        //--------------------------------------------------------------
        public int CrearNuevoIdOrdem()
        {
            objConnection.abrir();
            SqlCommand command = new SqlCommand("NewIdOrder", objConnection.conectar);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable id = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(id);

            return Convert.ToInt16(id.Rows[0][0]);
        }

        public void InsertarNuevaOrden(int _id, int _idP, int _idC, int _cant, double _sub, char _pago)
        {
            try
            {
                objConnection.abrir();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [dbo].[Orders] ( intId_Order, intId_Product, intId_Customer, bytProduct_Quantity, mnSubtotal, txtType_Payment)" +
                    "VALUES(@id, @idP, @idC, @cant, @sub, @pago) GO", objConnection.conectar);
                command.Parameters.Add("@id", SqlDbType.Int).Value = _id;
                command.Parameters.Add("@idP", SqlDbType.Int).Value = _idP;
                command.Parameters.Add("@idC", SqlDbType.Int).Value = _idC;
                command.Parameters.Add("@cant", SqlDbType.Int).Value = _cant;
                command.Parameters.Add("@sub", SqlDbType.Money).Value = _sub;
                command.Parameters.Add("@pago", SqlDbType.Char, 1).Value = _pago;
                command.ExecuteNonQuery();
                objConnection.cerrar();
            }
            catch (Exception)
            {
                return;
            }
        }

    }
}