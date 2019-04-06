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
    public class EventoActividadMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdActividad = "ID_ACTIVIDAD";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var actividadEvento = BuildObject(row);
                lstResults.Add(actividadEvento);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var eventoActividad = new EventoActividad()
            {
                IdEvento = GetIntValue(row, DbColIdEvento),
                IdActividad = GetIntValue(row, DbColIdActividad),
                



            };

            return eventoActividad;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };

            var eventoActividad = (EventoActividad)entity;
            operation.AddIntParam(DbColIdEvento, eventoActividad.IdEvento);
            operation.AddIntParam(DbColIdActividad, eventoActividad.IdActividad);
            
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
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };


            var eventoActividad = (EventoActividad)entity;
            operation.AddIntParam(DbColIdActividad, eventoActividad.IdActividad);
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
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };

            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);


            return operation;
        }


        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };
            var eventoActividad = (EventoActividad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, eventoActividad.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };

            var eventoActividad = (EventoActividad)entity;
            operation.AddIntParam(DbColIdEvento, eventoActividad.IdEvento);
            operation.AddIntParam(DbColIdActividad, eventoActividad.IdActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_ACTIVIDAD"
            };
            var eventoActividad = (EventoActividad)entity;
            operation.AddIntParam(DbColIdEvento, eventoActividad.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;

        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
