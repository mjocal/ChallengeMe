using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System.IO;

namespace Challengeme.DataAccess.Mapper
{
    public class EventoProductoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdProducto = "ID_PRODUCTO";
        private const string DbColTipoPatrocinio = "TIPO_PATROCINIO";
        private const string DbColCantidadProducto = "CANTIDAD_PRODUCTO";
        private const string DbColValorTotalProducto = "VALOR_TOTAL_PRODUCTO";
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColIdPatrocinador = "ID_PATROCINADOR";
        private const string DbCrudAction = "ACTION";

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var eventoProducto = BuildObject(row);
                lstResults.Add(eventoProducto);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var eventoProducto = new EventoProducto()
            {
                IdProducto = GetIntValue(row, DbColIdProducto),
                TipoPatrocinio = GetStringValue(row, DbColTipoPatrocinio),
                CantidadProducto = GetIntValue(row,DbColCantidadProducto),
                ValorTotalProducto= GetDecimalValue(row,DbColValorTotalProducto),
                IdEvento=GetIntValue(row,DbColIdEvento),
                IdPatrocinador=GetIntValue(row,DbColIdPatrocinador),
            };
            return eventoProducto;
        }

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_EVENTO_PRODUCTO"
        };

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            var eventoProducto = (EventoProducto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, eventoProducto.IdProducto);
            operation.AddVarcharParam(DbColTipoPatrocinio, eventoProducto.TipoPatrocinio);
            operation.AddIntParam(DbColCantidadProducto, eventoProducto.CantidadProducto);
            operation.AddDecimalParam(DbColValorTotalProducto, eventoProducto.ValorTotalProducto);
            operation.AddIntParam(DbColIdEvento, eventoProducto.IdEvento);
            operation.AddIntParam(DbColIdPatrocinador, eventoProducto.IdPatrocinador);
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
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            var eventoProducto = (EventoProducto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdProducto, eventoProducto.IdProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetRetriveStatement()
        {

            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            var eventoProducto = (EventoProducto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, eventoProducto.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);
            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            var eventoProducto = (EventoProducto)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdEvento, eventoProducto.IdEvento);
            operation.AddIntParam(DbColIdProducto, eventoProducto.IdProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllByIdEvento(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_EVENTO_PRODUCTO"
            };
            var eventoProducto = (EventoProducto)entity;
            operation.AddIntParam(DbColIdEvento, eventoProducto.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }
    }
}
