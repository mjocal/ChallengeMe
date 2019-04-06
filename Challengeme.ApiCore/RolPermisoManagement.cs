using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
    public class RolPermisoManagement:BaseManagement
    {
        public RolPermisoManagement()
        {
            _factory = new CrudRolPermiso();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreateRolPermiso(RolPermiso rolPermisos)
        {
            try
            {
                _factory.Create(rolPermisos);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public RolPermiso Retrieve(RolPermiso rolPermisos)
        {
            var list = new RolPermiso();
            try
            {
                list = _factory.Retrieve<RolPermiso>(rolPermisos);
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
                var lista = _factory.RetrieveAll<RolPermiso>();
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

        

        public List<T> RetrieveByName<T>(RolPermiso rolPermisos)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<RolPermiso>(rolPermisos);
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

        public List<T> RetrieveAllByIdRol<T>(RolPermiso rolPermisos)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<RolPermiso>(rolPermisos);
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
        public void Delete(RolPermiso rolPermisos)
        {
            try
            {
                _factory.Delete(rolPermisos);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void Update(RolPermiso rolPermisos)
        {
            try
            {
                _factory.Update(rolPermisos);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

    }
}
