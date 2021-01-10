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
        public DataTable MostrarDatosProducto(string _id)
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarProducto(Convert.ToInt16(_id));
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

        public void EditarProducto(string _id, string _nom, string _prec, byte[] _img)
        {
            objOpe.EditarProducto(Convert.ToInt16(_id), _nom, Convert.ToDouble(_prec), _img);
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

        public void InsertarOrden(string _id, string _idP, string _idC, string _cant, string _sub, string _pago)
        {
            objOpe.InsertarNuevaOrden(Convert.ToInt16(_id), Convert.ToInt16(_idP), Convert.ToInt16(_idC), Convert.ToInt16(_cant), Convert.ToDouble(_sub), Convert.ToChar(_pago));
        }
    }
}
