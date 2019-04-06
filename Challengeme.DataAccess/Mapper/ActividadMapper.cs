using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Challengeme.DataAccess.Crud;
using Challengeme.DataAccess.Dao;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    public class ActividadMapper : EntityMapper
    {
        private const string DbColIdActividad = "ID_ACTIVIDAD";
        private const string DbColNombreActividad = "NOMBRE_ACTIVIDAD";
        private const string DbColDescripcionActividad = "DESCRIPCION_ACTIVIDAD";
        private const string DbColEstado_Actividad = "ESTADO_ACTIVIDAD";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_ACTIVIDAD"
        };

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var actividad = BuildObject(row);
                lstResults.Add(actividad);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var actividad = new Actividad()
            {
                IdActividad = GetIntValue(row, DbColIdActividad),
                NombreActividad = GetStringValue(row, DbColNombreActividad),
                DescripcionActividad = GetStringValue(row, DbColDescripcionActividad),
                Estado_Actividad= GetStringValue(row,DbColEstado_Actividad),
            };

            return actividad;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            var actividad = (Actividad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdActividad, actividad.IdActividad);
            operation.AddVarcharParam(DbColNombreActividad, actividad.NombreActividad);
            operation.AddVarcharParam(DbColDescripcionActividad, actividad.DescripcionActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            var actividad = (Actividad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdActividad, actividad.IdActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            var actividad = (Actividad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdActividad, actividad.IdActividad);
            operation.AddVarcharParam(DbColNombreActividad, actividad.NombreActividad);
            operation.AddVarcharParam(DbColDescripcionActividad, actividad.DescripcionActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            var actividad = (Actividad)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdActividad, actividad.IdActividad);
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
                ProcedureName = "CRUD_ACTIVIDAD"
            };

            var actividad = (Actividad)entity;
            operation.AddVarcharParam(DbColNombreActividad, actividad.NombreActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ACTIVIDAD"
            };
            var actividad = (Actividad)entity;
            operation.AddIntParam(DbColIdActividad, actividad.IdActividad);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;

        }

    }
}
