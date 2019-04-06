using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class PremioManagement : BaseManagement
    {
        public PremioManagement()
        {
            _factory = new CrudPremio();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreatePremio(Premio premio)
        {
            try
            {
                _factory.Create(premio);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public Premio RetrievePremio(Premio premio)
        {
            var ret = new Premio();
            try
            {
                ret = _factory.Retrieve<Premio>(premio);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllPremios<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Premio>();

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

        public void DeletePremio(Premio premio)
        {
            try
            {
                _factory.Delete(premio);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdatePremio(Premio premio)
        {
            try
            {
                _factory.Update(premio);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public List<T> RetrieveByName<T>(Premio premio)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Premio>(premio);
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

        public List<T> RetrieveAllById<T>(Premio premio)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<Premio>(premio);
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
