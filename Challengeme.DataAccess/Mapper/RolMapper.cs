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
    class RolMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColId = "ID_ROLE";
        private const string DbColNombre = "NOMBRE_ROLE";
        private const string DbColDescripcion = "DESCRIPCION_ROLE";
        private const string DbIdPermiso = "ID_PERMISO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_ROLE"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var rol = BuildObject(row);
                lstResults.Add(rol);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var rol = new Rol()
            {
                IdRol = GetIntValue(row, DbColId),
                Nombre_Role = GetStringValue(row, DbColNombre),
                Descripcion_Role = GetStringValue(row, DbColDescripcion),
                

            };

            return rol;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE"
            };

            var rol = (Rol)entity;
            operation.AddIntParam(DbColId, rol.IdRol);
            operation.AddVarcharParam(DbColNombre, rol.Nombre_Role);
            operation.AddVarcharParam(DbColDescripcion, rol.Descripcion_Role);
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
                ProcedureName = "CRUD_ROLE"
            };
            var rol = (Rol)entity;
            operation.AddIntParam(DbColId,rol.IdRol);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;
        }

        public SqlOperation GetRetriveByName(BaseEntity entity)
        {

            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE"
            };
            var rol = (Rol)entity;
            operation.AddVarcharParam(DbColNombre, rol.Nombre_Role);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveByName);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE"
            };

            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);


            return operation;
        }
       

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE"
            };

            var rol = (Rol)entity;
            operation.AddIntParam(DbColId, rol.IdRol);
            operation.AddVarcharParam(DbColNombre, rol.Nombre_Role);
            operation.AddVarcharParam(DbColDescripcion, rol.Descripcion_Role);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);


            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE"
            };

            var rol = (Rol)entity;
            operation.AddIntParam(DbColId, rol.IdRol);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);

            return operation;
        }

        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }


    }
}
