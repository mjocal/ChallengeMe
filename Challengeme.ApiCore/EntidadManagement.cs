using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class EntidadManagement : BaseManagement
    {
        public EntidadManagement()
        {
            _factory = new CrudEntidad();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateEntidad(Entidad entidad)
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

        public Entidad RetrieveEntidad(Entidad entidad)
        {
            var ret = new Entidad();
            try
            {
                ret = _factory.Retrieve<Entidad>(entidad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllEntidades<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Entidad>();

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

        public List<T> RetrieveByName<T>(Entidad entidad)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Entidad>(entidad);
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

        public void DeleteEntidad(Entidad entidad)
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

        public void UpdateEntidad(Entidad entidad)
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
    }
}
