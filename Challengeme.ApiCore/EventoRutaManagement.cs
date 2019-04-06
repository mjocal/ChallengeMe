using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;

namespace Challengeme.ApiCore
{
    public class EventoRutaManagement : BaseManagement
    {
        public EventoRutaManagement()
        {
            _factory = new CrudEventoRuta();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateRelacionEventoRuta(EventoRuta eventoRuta)
        {
            try
            {
                _factory.Create(eventoRuta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public EventoRuta RetrieveRelacionEventoRuta(EventoRuta eventoRuta)
        {
            var list = new EventoRuta();
            try
            {
                list = _factory.Retrieve<EventoRuta>(eventoRuta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
            //como lo que necesito devolver es solo un registro
            // entonces lo devuelto como tipo User que es la clase 
            // de la que necesito mostrar los datos en los campos en el form

            return list;

        }

        public List<T> RetrieveAllRelacionesEventoRuta<T>()
        {

            var lst = new List<T>();//se declara la variable que va a ser retornada al form de VB
            try
            {
                var lista = _factory.RetrieveAll<EventoRuta>();
                //se recibe en una vairiable lo que se encontró en el procedimiento RetrieveAll


                if (lista.Count > 0)// se recorre la lista similar a como se recorre en el procedimiento RetrieveALl del CrudUser
                {


                    foreach (var obj in lista)
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
            return lst;//se retorna la lista al formulario
        }

        public void DeleteRelacionEventoRuta(EventoRuta eventoRuta)
        {
            try
            {
                _factory.Delete(eventoRuta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void UpdateRelacionEventoRuta(EventoRuta eventoRuta)
        {
            try
            {
                _factory.Update(eventoRuta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public List<T> RetrieveByName<T>(EventoRuta eventoRuta)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<EventoRuta>(eventoRuta);
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
