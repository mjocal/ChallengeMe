using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challengeme.DataAccess.Crud;
using Challengeme.Entities;

namespace Challengeme.ApiCore
{
    public class EventoProductoManagement : BaseManagement
    {
        public EventoProductoManagement()
        {
            _factory = new CrudEventoProducto();
            _exMan = ExceptionManagement.GetInstance();
        }

        
        public void CreateEventoProducto(EventoProducto eventoProducto)
        {
            try
            {
                _factory.Create(eventoProducto);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }

        public EventoProducto RetrieveEventoProducto(EventoProducto eventoProducto)
        {
            var ret = new EventoProducto();
            try
            {
                ret = _factory.Retrieve<EventoProducto>(eventoProducto);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
            return ret;
        }

        public Dictionary<string, Object> RetrievePatrocinadorProducto(Producto producto, Patrocinador patrocinador)
        {
            
            _factory = new CrudPatrocinador();
            var diccionario = new Dictionary<string, Object>();
            var ret = new Patrocinador();
            try
            {
                ret = _factory.Retrieve<Patrocinador>(patrocinador);
                diccionario.Add("Patrocinador", (object)ret);
                
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
            _factory = new CrudProducto();
            var retp = new Producto();
            try
            {
                retp = _factory.Retrieve<Producto>(producto);
                diccionario.Add("producto", (object)ret);

            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }

            return diccionario;
        }


        public Dictionary<string, Object> RetrieveAllPatrocinadorProducto(Patrocinador patrocinador)
        {

            _factory = new CrudPatrocinador();
            var diccionario = new Dictionary<string, Object>();
            var ret = new Patrocinador();
            try
            {
                ret = _factory.Retrieve<Patrocinador>(patrocinador);
                diccionario.Add("Patrocinador", (object)ret);

            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
            //_factory = new CrudProducto();
            //var retp = new Producto();
            //try
            //{
            //    retp = _factory.Retrieve<Producto>(producto);
            //    diccionario.Add("producto", (object)ret);

            //}
            //catch (Exception e)
            //{

            //    _exMan.ManageException(e);
            //}

            return diccionario;
        }


        public List<T> RetrieveAllEventoProducto<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<EventoProducto>();
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

        public List<T> RetrieveAllEventoProductoByIdEvento<T>(EventoProducto eventoProducto)
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAllById<EventoProducto>(eventoProducto);
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

        public void DeleteEventoProducto(EventoProducto eventoProducto)
        {
            try
            {
                _factory.Delete(eventoProducto);
            }
            catch (Exception e)
            {
                _exMan.ManageException(e);
            }
        }

        public void UpdateEventoProducto(EventoProducto eventoProducto)
        {
            try
            {
                _factory.Update(eventoProducto);
            }
            catch (Exception e)
            {

                _exMan.ManageException(e);
            }
        }
    }
}
