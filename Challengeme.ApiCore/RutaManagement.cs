using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class RutaManagement : BaseManagement
    {
        public RutaManagement()
        {
            _factory = new CrudRutaEvento();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateRuta(RutaEvento ruta)
        {
            try
            {
                _factory.Create(ruta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public RutaEvento Retrieve(RutaEvento ruta)
        {
            var list = new RutaEvento();
            try
            {
                list = _factory.Retrieve<RutaEvento>(ruta);
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

        public List<T> RetrieveAll<T>()
        {

            var lst = new List<T>();//se declara la variable que va a ser retornada al form de VB
            try
            {
                var lista = _factory.RetrieveAll<RutaEvento>();
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

        public List<T> RetrieveAllRutasByIdEvento<T>(int idEvento)
        {
            var lst = new List<T>();//se declara la variable que va a ser retornada al form de VB
            try
            {
                var lista = _factory.RetrieveAllRutasByIdEvento<RutaEvento>(idEvento);
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

        public void Delete(RutaEvento ruta)
        {
            try
            {
                _factory.Delete(ruta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void Update(RutaEvento ruta)
        {
            try
            {
                _factory.Update(ruta);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public List<T> RetrieveByName<T>(RutaEvento ruta)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<RutaEvento>(ruta);
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
