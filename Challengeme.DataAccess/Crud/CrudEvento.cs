using System;
using System.Collections.Generic;
using Challengeme.DataAccess.Dao;
using Challengeme.DataAccess.Mapper;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Crud
{
    public class CrudEvento : CrudFactory
    {
        public CrudEvento()
        {
            _mapper = new EventoMapper();
        }

        private readonly EventoMapper _mapper;

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

        public override T Retrieve<T>(BaseEntity entity)
        {
            var operation = _mapper.GetRetriveStatement(entity);
            var instance = SqlDao.GetInstance();
            var ltsSqldao = instance.ExecuteQueryProcedure(operation);

            if (ltsSqldao.Count <= 0) return default(T);
            var lista = ltsSqldao[0];
            var evento = _mapper.BuildObject(lista);
            try
            {
                if (ltsSqldao.Count <= 0) return default(T);

                lista = ltsSqldao[0];
                evento = _mapper.BuildObject(lista);
            }
            catch (Exception ex)
            {
                _exMan.ManageException(ex);
            }

            return (T)Convert.ChangeType(evento, typeof(T));
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
