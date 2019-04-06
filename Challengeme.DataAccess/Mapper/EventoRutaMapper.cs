using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;

namespace Challengeme.DataAccess.Mapper
{
    class EventoRutaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdRuta = "ID_RUTA";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO_RUTA"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var eventoRuta = BuildObject(row);
                lstResults.Add(eventoRuta);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {

            var eventoRuta = new EventoRuta()
            {
                IdEvento = GetIntValue(row, DbColIdEvento),
                IdRuta = GetIntValue(row, DbColIdRuta),
            };

            return eventoRuta;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_RUTA"
            };

            var eventoRuta = (EventoRuta)entity;
            operation.AddIntParam(DbColIdEvento, eventoRuta.IdEvento);
            operation.AddIntParam(DbColIdRuta, eventoRuta.IdRuta);
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
                ProcedureName = "CRUD_EVENTO_RUTA"
            };

            var eventoRuta = (EventoRuta)entity;
            operation.AddIntParam(DbColIdEvento, eventoRuta.IdEvento);
            operation.AddIntParam(DbColIdRuta, eventoRuta.IdRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_RUTA"
            };

            var eventoRuta = (EventoRuta)entity;
            operation.AddIntParam(DbColIdEvento, eventoRuta.IdEvento);
            operation.AddIntParam(DbColIdRuta, eventoRuta.IdRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_RUTA"
            };

            var eventoRuta = (EventoRuta)entity;
            operation.AddIntParam(DbColIdEvento, eventoRuta.IdEvento);
            operation.AddIntParam(DbColIdRuta, eventoRuta.IdRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }


        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
