using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    public class PremioMapper: EntityMapper
    {
        private const string DbColIdPremio = "ID_PREMIO";
        private const string DbColNombrePremio = "NOMBRE_PREMIO";
        private const string DbColDescripcionPremio = "DESCRIPCION_PREMIO";
        private const string DbColEstado_Premio = "ESTADO_PREMIO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PREMIO"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var premio = BuildObject(row);
                lstResults.Add(premio);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var premio = new Premio()
            {
                IdPremio = GetIntValue(row, DbColIdPremio),
                NombrePremio = GetStringValue(row, DbColNombrePremio),
                DescripcionPremio = GetStringValue(row, DbColDescripcionPremio),
               Estado_Premio = GetStringValue(row, DbColEstado_Premio),
            };

            return premio;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };
            var premio = (Premio)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPremio, premio.IdPremio);
            operation.AddVarcharParam(DbColNombrePremio, premio.NombrePremio);
            operation.AddVarcharParam(DbColDescripcionPremio, premio.DescripcionPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };
            var premio = (Premio)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPremio, premio.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };
            var premio = (Premio)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPremio, premio.IdPremio);
            operation.AddVarcharParam(DbColNombrePremio, premio.NombrePremio);
            operation.AddVarcharParam(DbColDescripcionPremio, premio.DescripcionPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };
            var premio = (Premio)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdPremio, premio.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };

            var premio = (Premio)entity;
            operation.AddVarcharParam(DbColNombrePremio, premio.NombrePremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PREMIO"
            };

            var premio = (Premio)entity;
            operation.AddIntParam(DbColIdPremio, premio.IdPremio);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }
    }
}
