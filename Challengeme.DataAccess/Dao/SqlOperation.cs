using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Challengeme.DataAccess.Dao
{
    public class SqlOperation
    {

        public string ProcedureName { get; set; }
        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<SqlParameter>();
        }

        public void AddVarcharParam(string paramName, string paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.VarChar)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddIntParam(string paramName, int paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Int)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddDoubleParam(string paramName, double paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Decimal)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }

        public void AddByteParam(string paramName, byte[] paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Image)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }
        public void AddDateParam(string paramName, System.DateTime paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.DateTime)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }
        public void AddDecimalParam(string paramName, decimal paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, SqlDbType.Money)
            {
                Value = paramValue
            };
            Parameters.Add(param);
        }
    }
}
