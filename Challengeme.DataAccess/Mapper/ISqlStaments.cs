using Challengeme.DataAccess.Dao;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    internal interface ISqlStaments
    {
        SqlOperation GetCreateStatement(BaseEntity entity);
        SqlOperation GetRCreateStatement(BaseEntity entity);
        SqlOperation GetRetriveStatement(BaseEntity entity);
        SqlOperation GetRetriveAllStatement();
        SqlOperation GetRetriveStatement();
        SqlOperation GetUpdateStatement(BaseEntity entity);
        SqlOperation GetDeleteStatement(BaseEntity entity);
    }
}
