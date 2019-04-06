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
   public class PatrocinadorProductoMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdPatrocinador = "ID_PATROCINADOR";
        private const string DbColIdProducto = "ID_PRODUCTO";
        private const string DbCrudAction = "ACTION";

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
        };


        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var patrocinadorProducto = BuildObject(row);
                lstResults.Add(patrocinadorProducto);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var patrocinadorProducto = new PatrocinadorProducto()
            {
                idPatrocinador = GetIntValue(row, DbColIdPatrocinador),
                idProducto = GetIntValue(row, DbColIdProducto),



            };

            return patrocinadorProducto;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
            };

            var patrocinadorProducto = (PatrocinadorProducto)entity;
            operation.AddIntParam(DbColIdPatrocinador, patrocinadorProducto.idPatrocinador);
            operation.AddIntParam(DbColIdProducto, patrocinadorProducto.idProducto);
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
                ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
            };

            var patrocinadorProducto = (PatrocinadorProducto)entity;
            operation.AddIntParam(DbColIdProducto, patrocinadorProducto.idProducto);
            operation.AddIntParam(DbColIdPatrocinador, patrocinadorProducto.idPatrocinador);
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
                ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
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
                ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
            };
            var patrocinadorProducto = (PatrocinadorProducto)entity;
            operation.AddIntParam(DbColIdPatrocinador, patrocinadorProducto.idPatrocinador);
            operation.AddIntParam(DbColIdProducto, patrocinadorProducto.idProducto);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRetriveAllByIdPatrocinador(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_PATROCINADOR_PRODUCTO"
            };
            var patrocinadorProducto = (PatrocinadorProducto)entity;
            operation.AddIntParam(DbColIdPatrocinador, patrocinadorProducto.idPatrocinador);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);

            return operation;

        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
