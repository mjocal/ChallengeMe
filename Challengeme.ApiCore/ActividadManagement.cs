using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class ActividadManagement : BaseManagement
    {
        public ActividadManagement()
        {
            _factory = new CrudActividad();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateActividad(Actividad actividad)
        {
            try
            {
                _factory.Create(actividad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public Actividad RetrieveActividad(Actividad actividad)
        {
            var ret = new Actividad();
            try
            {
                ret = _factory.Retrieve<Actividad>(actividad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllActividades<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Actividad>();

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

        public void DeleteActividad(Actividad actividad)
        {
            try
            {
                _factory.Delete(actividad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdateActividad(Actividad actividad)
        {
            try
            {
                _factory.Update(actividad);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }
        public List<T> RetrieveByName<T>(Actividad actividad)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Actividad>(actividad);
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

        public List<T> RetrieveAllById<T>(Actividad actividad)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<Actividad>(actividad);
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
