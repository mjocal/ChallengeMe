using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class ProductoManagement : BaseManagement
    {
        public ProductoManagement()
        {
            _factory = new CrudProducto();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateProducto(Producto producto)
        {
            try
            {
                _factory.Create(producto);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }

        public Producto RetrieveProducto(Producto producto)
        {
            var ret = new Producto();
            try
            {
                ret = _factory.Retrieve<Producto>(producto);
            }
            catch (Exception e)
            {
                
                _exMan.ManageException(e);
            }
            return ret;
        }

        public List<T> RetrieveAllProducto<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Producto>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
            return lst;
        }


        public List<T> RetrieveAllByIdProducto<T>(Producto producto)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<Producto>(producto);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                        //se convierte la lista a un tipo List<T> para que pueda ser retornada 
                        //al formulario y reconocida como una lista de una instancia de User's
                    }
                }
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
            return lst; //se retorna la lista al formulario

        }

        public void DeleteProducto(Producto producto)
        {
            try
            {
                _factory.Delete(producto);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdateProducto(Producto producto)
        {
            try
            {
                _factory.Update(producto);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }

        public List<T> RetrieveByName<T>(Producto producto)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Producto>(producto);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                        //se convierte la lista a un tipo List<T> para que pueda ser retornada 
                        //al formulario y reconocida como una lista de una instancia de User's
                    }
                }
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
            return lst; //se retorna la lista al formulario

        }

    }

}
