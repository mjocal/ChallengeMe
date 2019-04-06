using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
    public class EventoActividadManagement : BaseManagement
    {
        public EventoActividadManagement()
        {
            _factory = new CrudEventoActividad();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void Create(EventoActividad eventoActividad)
        {
            try
            {
                _factory.Create(eventoActividad);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public EventoActividad Retrieve(EventoActividad eventoActividad)
        {
            var list = new EventoActividad();
            try
            {
                list = _factory.Retrieve<EventoActividad>(eventoActividad);
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

        public List<T> RetrieveAlls<T>()
        {

            var lst = new List<T>();//se declara la variable que va a ser retornada al form de VB
            try
            {
                var lista = _factory.RetrieveAll<EventoActividad>();
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



        public List<T> RetrieveByName<T>(EventoActividad eventoActividad)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<EventoActividad>(eventoActividad);
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

        public List<T> RetrieveAllById<T>(EventoActividad eventoActividad)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<EventoActividad>(eventoActividad);
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
        public void Delete(EventoActividad eventoActividad)
        {
            try
            {
                _factory.Delete(eventoActividad);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void Update(EventoActividad eventoActividad)
        {
            try
            {
                _factory.Update(eventoActividad);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

    }
}
