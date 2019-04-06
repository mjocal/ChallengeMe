using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.DataAccess.Mapper
{
    public class EventoPremioMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdPremio = "ID_PREMIO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO_PREMIO"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var eventoPremio = BuildObject(row);
                lstResults.Add(eventoPremio);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var eventoPremio = new EventoPremio()
            {
                IdEvento = GetIntValue(row, DbColIdEvento),
                IdPremio = GetIntValue(row, DbColIdPremio),
                



            };

            return eventoPremio;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };

            var eventoPremio = (EventoPremio)entity;
           
            operation.AddIntParam(DbColIdEvento, eventoPremio.IdEvento);
            operation.AddIntParam(DbColIdPremio, eventoPremio.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };

            var premioEvento = (EventoPremio)entity;
            operation.AddIntParam(DbColIdPremio, premioEvento.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };

            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);


            return operation;
        }


        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };
            var eventoPremio = (EventoPremio)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, eventoPremio.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };
            var eventoPremio = (EventoPremio)entity;
            
            operation.AddIntParam(DbColIdEvento, eventoPremio.IdEvento);
            operation.AddIntParam(DbColIdPremio, eventoPremio.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PREMIO"
            };
            var eventoPremio = (EventoPremio)entity;
            operation.AddIntParam(DbColIdEvento, eventoPremio.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;

        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
