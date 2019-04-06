using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Dao;
using Challengeme.DataAccess.Mapper;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Crud
{
    public class CrudCategoria : CrudFactory
    {
        public CrudCategoria()
        {
            _mapper = new CategoriaMapper();
        }

        private readonly CategoriaMapper _mapper;

        public override bool Create(BaseEntity entity)
        {
            var operation = _mapper.GetCreateStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);

            return true;
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var operation = _mapper.GetRetriveStatement(entity);
            var instance = SqlDao.GetInstance();
            var ltsSqldao = instance.ExecuteQueryProcedure(operation);

            // revisa que el dato sea o no nulo
            if (ltsSqldao.Count <= 0) return default(T);

            var lista = ltsSqldao[0];
            var entidad = _mapper.BuildObject(lista);

            return (T)Convert.ChangeType(entidad, typeof(T));
        }

        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();

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

            return lst;
        }

        public override bool Update(BaseEntity entity)
        {
            var operation = _mapper.GetUpdateStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);

            return true;
        }

        public override bool Delete(BaseEntity entity)
        {
            var operation = _mapper.GetDeleteStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);

            return true;
        }

        public override T RCreate<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
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
        public override List<T> RetrieveAllById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();


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
