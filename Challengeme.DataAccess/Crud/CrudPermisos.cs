using Challengeme.DataAccess.Dao;
using Challengeme.DataAccess.Mapper;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.DataAccess.Crud
{
    public class CrudPermisos : CrudFactory
    {
        public CrudPermisos()
        {
            _mapper = new PermisosMapper();

        }
        private readonly PermisosMapper _mapper;


        public override bool Create(BaseEntity entity)
        {
            try
            {
                var operation = _mapper.GetCreateStatement(entity);
                var instance = SqlDao.GetInstance();
                instance.ExecuteProcedure(operation);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

            return true;
        }


        public override T RCreate<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {

            var instance = SqlDao.GetInstance();//verifica si hay algun registro coincidente en la BD
            var operation = _mapper.GetRetriveStatement(entity);//le indica al método qué tipo de operación se va a ejecutar
            //o sea qué tipo de SP es el que se requiere para la operacion
            var lstResult = instance.ExecuteQueryProcedure(operation);
            //invoca el procedimiento para la busqueda del registro y almacena el objeto
            //retornado en la variable lstResult

            if (lstResult.Count <= 0) return default(T);
            //si lstResutl es nulo significa que es menos que 0 por lo tanto no hay registros coincidentes
            //en la BD y retornar null

            var list = lstResult[0];//de lo contrario retorna lo que encuentra en la lista y que lo trae
            //en la posicion 0 que es donde trae guardado el dato conicidente del registro que encontró
            //en la BD
            var permisoEncontrado = _mapper.BuildObject(list);
            //contruye el objeto pasandole los datos
            //a cada atributo
            try
            {
                if (lstResult.Count <= 0) return default(T);
                list = lstResult[0];
                permisoEncontrado = _mapper.BuildObject(list);

            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }
            //devuelte el tipo de dato generico T parametrizado, casteando el objeto
            //userEncontrado para que se devuelva a la UI el tipo de dato de la entidad
            //adecuada
            return (T)Convert.ChangeType(permisoEncontrado, typeof(T));
        }

        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();

            try
            {
                var instance = SqlDao.GetInstance();
                var lstResult = instance.ExecuteQueryProcedure(_mapper.GetRetriveAllStatement());

                if (lstResult.Count > 0)
                {
                    var objs = _mapper.BuildObjects(lstResult);


                    foreach (var obj in objs)
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
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {

            var lst = new List<T>();
            try
            {
                var instance = SqlDao.GetInstance();
                var lstResult = instance.ExecuteQueryProcedure(_mapper.GetRetriveByName(entity));

                if (lstResult.Count > 0)
                {
                    var objs = _mapper.BuildObjects(lstResult);

                    foreach (var obj in objs)
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

        public override bool Update(BaseEntity entity)
        {
            try
            {
                var operation = _mapper.GetUpdateStatement(entity);
                var instance = SqlDao.GetInstance();
                instance.ExecuteProcedure(operation);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

            return true;
        }


        public override bool Delete(BaseEntity entity)
        {
            try
            {
                var operation = _mapper.GetDeleteStatement(entity);
                var instance = SqlDao.GetInstance();
                instance.ExecuteProcedure(operation);
            }
            catch (Exception ex)
            {

                _exMan.ManageException(ex);
            }

            return true;
        }
        public  override List<T> RetrieveAllById<T>(BaseEntity entity)
        {

            var lst = new List<T>();
            try
            {
                var instance = SqlDao.GetInstance();
                var lstResult = instance.ExecuteQueryProcedure(_mapper.GetRetriveAllById(entity));

                if (lstResult.Count > 0)
                {
                    var objs = _mapper.BuildObjects(lstResult);

                    foreach (var obj in objs)
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

        public override List<T> RetrieveAllRutasByIdEvento<T>(int idEvento)
        {
            throw new NotImplementedException();
        }

        public override T RetrieveByEmail<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
