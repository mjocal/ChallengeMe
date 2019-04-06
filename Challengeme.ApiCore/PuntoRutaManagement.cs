using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
    public class PuntoRutaManagement : BaseManagement
    {
        public PuntoRutaManagement()
        {
            _factory = new CrudPuntoRuta();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreatePuntoRuta(PuntoRuta puntoRuta)
        {
            try
            {
                _factory.Create(puntoRuta);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }

        public PuntoRuta RetrievePuntoRuta(PuntoRuta puntoRuta)
        {
            var ret = new PuntoRuta();
            try
            {
                ret = _factory.Retrieve<PuntoRuta>(puntoRuta);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
            return ret;
        }

        public List<T> RetrieveAllPuntosRuta<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<PuntoRuta>();
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


        public List<T> RetrieveAllPuntoRutaByIdRuta<T>(PuntoRuta puntoRuta)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<PuntoRuta>(puntoRuta);
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

        public void DeletePuntoRuta(PuntoRuta puntoRuta)
        {
            try
            {
                _factory.Delete(puntoRuta);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdatePuntoRuta(PuntoRuta puntoRuta)
        {
            try
            {
                _factory.Update(puntoRuta);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }

        public List<T> RetrieveByName<T>(PuntoRuta puntoRuta)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<PuntoRuta>(puntoRuta);
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
