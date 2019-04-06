using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class EventoManagement : BaseManagement
    {
        public EventoManagement()
        {
            _factory = new CrudEvento();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateEvento(Evento evento)
        {
            try
            {
                _factory.Create(evento);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public Evento RetrieveEvento(Evento evento)
        {
            var ret = new Evento();
            try
            {
                ret = _factory.Retrieve<Evento>(evento);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return ret;
        }

        public List<T> RetrieveAllEventos<T>()
        {
            var lst = new List<T>();

            try
            {
                var ret = _factory.RetrieveAll<Evento>();

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

        public List<T> RetrieveByName<T>(Evento evento)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Evento>(evento);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                _exMan.ManageException(ex);
            }
            return lst; 

        }

        public void DeleteEvento(Evento evento)
        {
            try
            {
                _factory.Delete(evento);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdateEvento(Evento evento)
        {
            try
            {
                _factory.Update(evento);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }
    }
}
