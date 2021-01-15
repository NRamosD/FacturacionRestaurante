using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using System.Data;


namespace Logica
{
    public class OperacionesLogicas
    {
        
        private operaciones objOpe = new operaciones();
        DataTable tabla = new DataTable();
        public int ObtenerCodCliente()
        {
            return objOpe.CrearNuevoIdCliente();
        }
        public DataTable MostrarDatosCliente(string _ci)
        {
            try
            {
                tabla = objOpe.MostrarCliente(_ci);
                return tabla;
            }
            catch(Exception)
            {
                return tabla;
            }
        }
        public void OpInsertarCliente(string _id, string _ci, string _fn, string _ln, string _cp, string _ed, string _dir, string _sexo)
        {
            try
            {
                objOpe.InsertarCliente(Convert.ToInt16 (_id), _ci, _fn, _ln, _cp, _ed, _dir, _sexo);
            }catch(Exception exc)
            {
                Console.WriteLine("Error al ingresar: " + exc);
            }
            
        }
       
        public void EditarCliente(string _id, string _cp, string _ed, string _dir)
        {
            try
            {
                objOpe.EditarCliente(Convert.ToInt16(_id), _cp, _ed, _dir);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al editar: " + exc);
            }
        }
        public void EliminarCliente(string _id)
        {
            try
            {
                objOpe.EliminarCliente(Convert.ToInt16(_id));
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al eliminar: " + exc);
            }

        }

        //-------------------------------------------------------------------------------------------
        public DataTable MostrarDatosProducto(int _id)
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarProducto(_id);
            return tabla;
        }

        public DataTable MostrarDatosProductos()
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarProductos();
            return tabla;
        }
        public int ObterTotalProd()
        {
            return objOpe.ObtenerTotalProductos();
        }
        public int NuevoProd()
        {
            return objOpe.CrearNuevoIdProducto();
        }
        public void InsertarProducto(string _id, string _nom, string _prec, string _cat, byte[] _img)
        {
            objOpe.InsertarProducto(Convert.ToInt16 (_id), _nom, Convert.ToDouble(_prec), _cat,_img);
        }

        public void EditarProducto(string _id, string _nom, string _prec, string _cat, byte[] _img)
        {
            objOpe.EditarProducto(Convert.ToInt16(_id), _nom, Convert.ToDouble(_prec), _cat, _img);
        }
        public void EliminarProducto(string _id)
        {
            objOpe.EliminarProducto(Convert.ToInt16(_id));
        }

        //---------------------------------------------------------------------------------------------------------

        public int NuevaOrden()
        {
            return objOpe.CrearNuevoIdOrdem();
        }

        public void InsertarOrden(int _id, string _idP, string _idC, string _cant, string _sub, string _pago)
        {
            objOpe.InsertarNuevaOrden(_id, _idP, _idC, _cant, _sub, _pago);
        }

        public DataTable OrdenesRecientes()
        {
            return objOpe.OrdenesRecientes();
        }

        //-------------------------------------------------------

        //Validar cédula de identidad

        public int Verificar(char[] vec)
        {

            int res = -1;
            int suma = 0;
            int Superior;
            int digito;
            int numero;
            int num = 0;


            for (int j = 0; j < 9; j++)
            {

                num = Convert.ToInt32(vec[j].ToString());

                if ((j % 2) == 0)
                {
                    num = Convert.ToInt32(vec[j].ToString()) * 2;
                    if (num > 9)
                    {
                        num = num - 9;
                    }
                }
                suma = suma + num;
            }
            Superior = suma % 10;

            if (Superior != 0)
            {

                digito = 10 - Superior;

            }

            else
                digito = 0;

            numero = Convert.ToInt32(vec[9].ToString());

            if (digito == numero)
            {
                res = 2;
                return (res);

            }

            else
            {
                return (res);

            }
        }
    }
}
