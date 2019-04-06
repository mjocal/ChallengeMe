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
    public class PermisosMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColId = "ID_PERMISO";
        private const string DbColNombre = "NOMBRE_PERMISO";
        private const string DbColDescripcion = "DESCRIPCION_PERMISO";
        private const string DbColArea = "AREA_PERMISO";
        private const string DbColEstado_Permiso = "ESTADO_PERMISO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PERMISOS"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var permisos = BuildObject(row);
                lstResults.Add(permisos);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var permisos = new Permisos()
            {
                IdPermiso = GetIntValue(row, DbColId),
                Nombre = GetStringValue(row, DbColNombre),
                Descripcion = GetStringValue(row, DbColDescripcion),
                Area = GetStringValue(row, DbColArea),
                Estado_Permiso = GetStringValue(row, DbColEstado_Permiso),


            };

            return permisos;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            };

            var permiso = (Permisos)entity;
            operation.AddIntParam(DbColId, permiso.IdPermiso);
            operation.AddVarcharParam(DbColNombre, permiso.Nombre);
            operation.AddVarcharParam(DbColDescripcion, permiso.Descripcion);
            operation.AddVarcharParam(DbColArea, permiso.Area);
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
                ProcedureName = "CRUD_PERMISOS"
            };

            var permiso = (Permisos)entity;
            operation.AddIntParam(DbColId, permiso.IdPermiso);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            };

            var permiso = (Permisos)entity;
            operation.AddVarcharParam(DbColNombre, permiso.Nombre);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);
            return operation;
        }

        public SqlOperation GetRetriveAllById(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            }; 

            var permiso = (Permisos)entity;
            operation.AddIntParam(DbColId, permiso.IdPermiso);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            };

            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);


            return operation;
        }
        

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            };

            var permiso = (Permisos)entity;
            operation.AddIntParam(DbColId, permiso.IdPermiso);
            operation.AddVarcharParam(DbColNombre, permiso.Nombre);
            operation.AddVarcharParam(DbColDescripcion, permiso.Descripcion);
            operation.AddVarcharParam(DbColArea, permiso.Area);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PERMISOS"
            };

            var permiso = (Permisos)entity;
            operation.AddIntParam(DbColId, permiso.IdPermiso);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }


    }
}
