using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class CategoriaManagement : BaseManagement
    {
        public CategoriaManagement()
        {
            _factory = new CrudCategoria();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateCategoria(Categoria entidad)
        {
            try
            {
                _factory.Create(entidad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public Categoria RetrieveCategoria(Categoria entidad)
        {
            var ret = new Categoria();
            try
            {
                ret = _factory.Retrieve<Categoria>(entidad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllCategorias<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Categoria>();

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

        public void DeleteCategoria(Categoria entidad)
        {
            try
            {
                _factory.Delete(entidad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdateCategoria(Categoria entidad)
        {
            try
            {
                _factory.Update(entidad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public List<T> RetrieveByName<T>(Categoria categoria)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Categoria>(categoria);
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
