using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    public class CategoriaMapper : EntityMapper
    {

        private const string DbColIdCategoria = "ID_CATEGORIA";
        private const string DbColNombreCategoria = "NOMBRE_CATEGORIA";
        private const string DbColEstado_Categoria = "ESTADO_CATEGORIA";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_CATEGORIA"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var entidad = BuildObject(row);
                lstResults.Add(entidad);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var entidad = new Categoria()
            {
                IdCategoria = GetIntValue(row, DbColIdCategoria),
                NombreCategoria = GetStringValue(row, DbColNombreCategoria),
                Estado_Categoria = GetStringValue(row, DbColEstado_Categoria),
            };

            return entidad;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_CATEGORIA"
            };
            var entidad = (Categoria)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdCategoria, entidad.IdCategoria);
            operation.AddVarcharParam(DbColNombreCategoria, entidad.NombreCategoria);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_CATEGORIA"
            };
            var entidad = (Categoria)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdCategoria, entidad.IdCategoria);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_CATEGORIA"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_CATEGORIA"
            };
            var entidad = (Categoria)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdCategoria, entidad.IdCategoria);
            operation.AddVarcharParam(DbColNombreCategoria, entidad.NombreCategoria);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_CATEGORIA"
            };
            var entidad = (Categoria)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdCategoria, entidad.IdCategoria);
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
                ProcedureName = "CRUD_CATEGORIA"
            };

            var categoria = (Categoria)entity;
            operation.AddVarcharParam(DbColNombreCategoria, categoria.NombreCategoria);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

    }
}
