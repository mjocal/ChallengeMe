using Challengeme.DataAccess.Crud;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
    public class PermisosManagement : BaseManagement
    {
        public PermisosManagement()
        {
            _factory = new CrudPermisos();
            _exMan = ExceptionManagement.GetInstance();
        }

        public void CreatePermiso(Permisos permiso)
        {
            try
            {
                _factory.Create(permiso);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

        }

        public Permisos Retrieve(Permisos permisos)
        {
            var list = new Permisos();
            try
            {
                list = _factory.Retrieve<Permisos>(permisos);
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
                var lista = _factory.RetrieveAll<Permisos>();
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

        public List<T> RetrieveByName<T>(Permisos permiso)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Permisos>(permiso);
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
        public List<T> RetrieveAllByIdPermiso<T>(Permisos permiso)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveAllById<Permisos>(permiso);
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



        public void Delete(Permisos permisos)
        {
            try
            {
                _factory.Delete(permisos);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }

        public void Update(Permisos permisos)
        {
            try
            {
                _factory.Update(permisos);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
        }
    }
}
