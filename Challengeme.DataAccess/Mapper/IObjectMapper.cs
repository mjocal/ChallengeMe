using System.Collections.Generic;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Mapper
{
    internal interface IObjectMapper
    {
        List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows);
        BaseEntity BuildObject(Dictionary<string, object> row);
    }
}
