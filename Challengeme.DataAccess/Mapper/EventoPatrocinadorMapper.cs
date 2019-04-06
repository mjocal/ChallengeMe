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
    public class EventoPatrocinadorMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdPatrocinador = "ID_PATROCINADOR";
        private const string DbColTipoPatrocinio = "TIPO_PATROCINIO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO_PATROCINADOR"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var eventoPatrocinador = BuildObject(row);
                lstResults.Add(eventoPatrocinador);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var eventoPatrocinador = new EventoPatrocinador()
            {
                
                IdEvento = GetIntValue(row, DbColIdEvento),
                IdPatrocinador = GetIntValue(row, DbColIdPatrocinador),
                TipoPatrocinio = GetStringValue(row, DbColTipoPatrocinio),



            };

            return eventoPatrocinador;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PATROCINADOR"
            };

            var eventoPatrocinador = (EventoPatrocinador)entity;
            
            operation.AddIntParam(DbColIdEvento, eventoPatrocinador.IdEvento);
            operation.AddIntParam(DbColIdPatrocinador, eventoPatrocinador.IdPatrocinador);
            operation.AddVarcharParam(DbColTipoPatrocinio, eventoPatrocinador.TipoPatrocinio);
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
                ProcedureName = "CRUD_EVENTO_PATROCINADOR"
            };

            var eventoPatrocinador = (EventoPatrocinador)entity;
            operation.AddIntParam(DbColIdPatrocinador, eventoPatrocinador.IdEvento);
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
                ProcedureName = "CRUD_EVENTO_PATROCINADOR"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);


            return operation;
        }


        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PATROCINADOR"
            };

            var eventoPatrocinador = (EventoPatrocinador)entity;
            
            operation.AddIntParam(DbColIdEvento, eventoPatrocinador.IdEvento);
            operation.AddIntParam(DbColIdPatrocinador, eventoPatrocinador.IdPatrocinador);
            operation.AddVarcharParam(DbColTipoPatrocinio, eventoPatrocinador.TipoPatrocinio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllByIdRol(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PATROCINADOR"
            };
            var eventoPatrocinador = (EventoPatrocinador)entity;
            operation.AddIntParam(DbColIdPatrocinador, eventoPatrocinador.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;

        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
