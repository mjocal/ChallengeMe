using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class PatrocinadorManagement : BaseManagement
    {
        public PatrocinadorManagement()
        {
            _factory = new CrudPatrocinador();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreatePatrocinador(Patrocinador patrocinador)
        {
            try
            {
                _factory.Create(patrocinador);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public Patrocinador RetrievePatrocinador(Patrocinador patrocinador)
        {
            var ret = new Patrocinador();
            try
            {
                ret = _factory.Retrieve<Patrocinador>(patrocinador);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllPatrocinadores<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Patrocinador>();

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

        public List<T> RetrieveAllPatrocinadoresById<T>(Patrocinador patrocinador)
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAllById<Patrocinador>(patrocinador);

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

        public void DeletePatrocinador(Patrocinador patrocinador)
        {
            try
            {
                _factory.Delete(patrocinador);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdatePatrocinador(Patrocinador patrocinador)
        {
            try
            {
                _factory.Update(patrocinador);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }
        public List<T> RetrieveByName<T>(Patrocinador patrocinador)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Patrocinador>(patrocinador);
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
