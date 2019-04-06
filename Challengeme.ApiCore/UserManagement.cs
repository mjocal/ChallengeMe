using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
    public class UserManagement : BaseManagement
    {
        public UserManagement()
        {
            _factory = new CrudUser();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateUser(User user)
        {
            try
            {
                _factory.Create(user);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public User Retrieve(User user)
        {
            var list = new User();
            try
            {
                list = _factory.Retrieve<User>(user);
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
        public User RetrieveByEmail(User user)
        {
            var list = new User();
            try
            {
                list = _factory.RetrieveByEmail<User>(user);
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
                var lista = _factory.RetrieveAll<User>();
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

        public void Delete(User user)
        {
            try
            {
                _factory.Delete(user);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void Update(User user)
        {
            try
            {
                _factory.Update(user);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public List<T> RetrieveByName<T>(User usuario)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<User>(usuario);
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
