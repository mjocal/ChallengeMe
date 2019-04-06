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
    public class CrudPago : CrudFactory
    {
        public CrudPago()
        {
            _mapper = new PagoMapper();

        }

        private readonly PagoMapper _mapper;

        public override bool Create(BaseEntity entity)
        {
            // tipo de operacion a realizar
            var operation = _mapper.GetCreateStatement(entity);
            var instance = SqlDao.GetInstance();
            instance.ExecuteProcedure(operation);

            return true;
        }

        // T es un param de clases genericas o dato "creado". Pueden tomar cualquier tipo de valor
        // necesita un return porque no tiene void, y devovlerle el valor al proc que lo llama
        public override T Retrieve<T>(BaseEntity entity)
        {
            var operation = _mapper.GetRetriveStatement(entity);
            var instance = SqlDao.GetInstance();
            var ltsSqldao = instance.ExecuteQueryProcedure(operation);

            // revisa que el dato sea o no nulo
            if (ltsSqldao.Count <= 0) return default(T);

            var lista = ltsSqldao[0];
            var pago = _mapper.BuildObject(lista);

            return (T)Convert.ChangeType(pago, typeof(T));
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
            throw new NotImplementedException();
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
