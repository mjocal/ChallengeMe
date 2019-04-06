using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Challengeme.DataAccess.Mapper
{
    public class RutaMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdEventoRuta = "ID_EVENTO";
        private const string DbColIdRuta = "ID_RUTA";
        private const string DbColNombreRuta = "NOMBRE_RUTA";
        private const string DbColDireccionRuta = "DIRECCION_RUTA";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_RUTA"
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
            var ruta = new RutaEvento
            {
                idRuta = GetIntValue(row, DbColIdRuta),
                nombreRuta = GetStringValue(row, DbColNombreRuta),
                direccionRuta = GetStringValue(row, DbColDireccionRuta)
            };

            return ruta;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            var ruta = (RutaEvento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, ruta.idRuta);
            operation.AddVarcharParam(DbColNombreRuta, ruta.nombreRuta);
            operation.AddVarcharParam(DbColDireccionRuta, ruta.direccionRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            var ruta = (RutaEvento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, ruta.idRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            var ruta = (RutaEvento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, ruta.idRuta);
            operation.AddVarcharParam(DbColNombreRuta, ruta.nombreRuta);
            operation.AddVarcharParam(DbColDireccionRuta, ruta.direccionRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            var ruta = (RutaEvento)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRuta, ruta.idRuta);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRetriveAllRoutesByIdEvento(int idEvento)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RUTA"
            };

            operation.AddIntParam(DbColIdEventoRuta, idEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;
        }

        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetrieveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllByIdRol(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
