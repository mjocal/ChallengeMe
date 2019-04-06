using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Challengeme.DataAccess.Dao
{
    public class SqlDao
    {

        private static SqlDao _instance;

        private SqlDao()
        {

        }

        public static SqlDao GetInstance()
        {
            return _instance ?? (_instance = new SqlDao());
        }

        private const string ConnectionString = "Server=tcp:challengeme.database.windows.net,1433;Initial Catalog=CHALLENGE_ME_DB;Persist Security Info=False;User ID=maxterdize;Password=Cenfotec123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //private const string ConnectionString = "Data Source=.;Initial Catalog=challenge_me_db;Integrated Security=True;";
        public void ExecuteProcedure(SqlOperation sqlOperation)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation sqlOperation)
        {
            var lstResult = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sqlOperation.ProcedureName, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                foreach (var param in sqlOperation.Parameters)
                {
                    command.Parameters.Add(param);
                }

                conn.Open();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var dict = new Dictionary<string, object>();
                        for (var lp = 0; lp < reader.FieldCount; lp++)
                        {
                            dict.Add(reader.GetName(lp), reader.GetValue(lp));
                        }
                        lstResult.Add(dict);
                    }
                }
            }

            return lstResult;
        }
    }
}