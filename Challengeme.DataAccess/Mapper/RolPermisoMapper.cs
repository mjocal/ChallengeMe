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
    public class RolPermisoMapper: EntityMapper,IObjectMapper,ISqlStaments
    {
        private const string DbColIdRol = "ID_ROLE";
        private const string DbColIdPermiso = "ID_PERMISO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_ROLE_PERMISO"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var rolPermisos = BuildObject(row);
                lstResults.Add(rolPermisos);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var rolPermisos = new RolPermiso()
            {
                IdRol = GetIntValue(row, DbColIdRol),
                IdPermiso = GetIntValue(row, DbColIdPermiso),
               


            };

            return rolPermisos;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
           var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE_PERMISO"
            };
         
            var rolPermisos = (RolPermiso)entity;
            operation.AddIntParam(DbColIdRol, rolPermisos.IdRol);
            operation.AddIntParam(DbColIdPermiso, rolPermisos.IdPermiso);
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
                ProcedureName = "CRUD_ROLE_PERMISO"
            };
            var rolPermisos = (RolPermiso)entity;
            operation.AddIntParam(DbColIdRol, rolPermisos.IdRol);
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
                ProcedureName = "CRUD_ROLE_PERMISO"
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
                ProcedureName = "CRUD_ROLE_PERMISO"
            };
            var rolPermisos = (RolPermiso)entity;
            operation.AddIntParam(DbColIdRol, rolPermisos.IdRol);
            operation.AddIntParam(DbColIdPermiso, rolPermisos.IdPermiso);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllByIdRol(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_ROLE_PERMISO"
            };
            var rolPermisos = (RolPermiso)entity;
            operation.AddIntParam(DbColIdRol, rolPermisos.IdRol);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);

            return operation;

        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
}
