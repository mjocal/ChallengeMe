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
    public class RankingMapper : EntityMapper, IObjectMapper, ISqlStaments
    {
        private const string DbColIdRanking = "ID_RANKING";
        private const string DbColPosicionUsuario = "POSICION_USUARIO";
        private const string DbColIdUsuario = "ID_USUARIO";
        private const string DbColIdEvento = "ID_EVENTO";
        private const string DbColEstado_Ranking = "ESTADO_RANKING";
        private const string DbCrudAction = "ACTION";

       

        private SqlOperation operation = new SqlOperation()
        {
            ProcedureName = "CRUD_RANKING"
        };

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {

            var ranking = new Ranking()
            {
                IdRanking = GetIntValue(row, DbColIdRanking),
                PosicionUsuario = GetIntValue(row, DbColPosicionUsuario),
                IdUsuario = GetStringValue(row, DbColIdUsuario),
                IdEvento = GetIntValue(row, DbColIdEvento),
                Estado_Ranking = GetStringValue(row, DbColEstado_Ranking),
            };
            return ranking;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var ranking = BuildObject(row);
                lstResults.Add(ranking);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            var ranking = (Ranking)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRanking, ranking.IdRanking);
            operation.AddIntParam(DbColPosicionUsuario, ranking.PosicionUsuario);
            operation.AddVarcharParam(DbColIdUsuario, ranking.IdUsuario);
            operation.AddIntParam(DbColIdEvento, ranking.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Create);
            return operation;
        }
       
        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            var ranking = (Ranking)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRanking, ranking.IdRanking);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Delete);
            return operation;
        }
        public SqlOperation GetRCreateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAll);
            return operation;
        }
        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            var ranking = (Ranking)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRanking, ranking.IdRanking);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Retrieve);
            return operation;
        }
        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            var ranking = (Ranking)entity;
            operation.Parameters = new List<SqlParameter>();
            operation.AddIntParam(DbColIdRanking, ranking.IdRanking);
            operation.AddIntParam(DbColPosicionUsuario, ranking.PosicionUsuario);
            operation.AddVarcharParam(DbColIdUsuario, ranking.IdUsuario);
            operation.AddIntParam(DbColIdEvento, ranking.IdEvento);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.Update);
            return operation;
        }
        public SqlOperation GetRetriveStatement()
        {
            throw new NotImplementedException();
        }
        

        public SqlOperation GetRetriveAllByIdRanking(BaseEntity entity)
        {
            var operation = new SqlOperation()
            {
                ProcedureName = "CRUD_RANKING"
            };
            var ranking = (Ranking)entity;
            operation.AddIntParam(DbColIdRanking, ranking.IdRanking);
            operation.AddIntParam(DbCrudAction, (int)CrudActionEnum.RetrieveAllById);
            return operation;
        }

        

    }

}
