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
        public int ObtenerCodCliente()
        {
            return objOpe.CrearNuevoIdCliente();
        }
        public DataTable MostrarDatosCliente(string _ci)
        {
            DataTable tabla = new DataTable();
            tabla = objOpe.MostrarCliente( _ci);
            return tabla;
        }
        public void OpInsertarCliente(string _id, string _ci, string _fn, string _ln, string _cp, string _ed, string _dir, string _sexo)
        {
<<<<<<< HEAD
            try
            {
                objOpe.InsertarCliente(Convert.ToInt16(_id), Convert.ToChar(_ci), _fn, _ln, _cp.ToCharArray(), _ed, _dir, _sexo);
            }catch(Exception exc)
            {
                Console.WriteLine("Error al ingresar: " + exc);
            }
            
=======
            objOpe.InsertarCliente(Convert.ToInt16(_id), _ci, _fn, _ln, _cp, _ed, _dir, _sexo);
>>>>>>> 83b2f563d682904e8e9a7e2d9004453f7874e505
        }
       
        public void EditarCliente(string _id, string _cp, string _ed, string _dir)
        {
            objOpe.EditarCliente(Convert.ToInt16(_id), _cp, _ed, _dir);
        }
        public void EliminarCliente(string _id)
        {
            objOpe.EliminarCliente(Convert.ToInt16(_id));
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
        public void InsertarProducto(int _id, string _nom, string _prec, string _cat, byte[] _img)
        {
            objOpe.InsertarProducto(_id, _nom, Convert.ToDouble(_prec), _cat,_img);
        }

        public void EditarProducto(int _id, string _nom, double _prec, byte[] _img)
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
