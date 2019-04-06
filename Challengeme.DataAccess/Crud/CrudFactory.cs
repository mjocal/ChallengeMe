using System.Collections.Generic;
using Challengeme.DataAccess.Dao;
using Challengeme.DataAccess.Mapper;
using Challengeme.Entities;
using Challengeme.DataAccess.Management;

namespace Challengeme.DataAccess.Crud
{
    public abstract class CrudFactory
    {
        protected SqlDao SqlSqlDao;
        protected EntityMapper EntityMapper { get; set; }

        protected ExceptionManagement _exMan;

        public abstract bool Create(BaseEntity entity);
        public abstract T RCreate<T>(BaseEntity entity);
        public abstract T Retrieve<T>(BaseEntity entity);
        public abstract T RetrieveByEmail<T>(BaseEntity entity);
        public abstract List<T> RetrieveByName<T>(BaseEntity entity);
        public abstract List<T> RetrieveAllById<T>(BaseEntity entity);
        public abstract List<T> RetrieveAllRutasByIdEvento<T>(int idEvento);

        public abstract List<T> RetrieveAll<T>();
        public abstract bool Update(BaseEntity entity);
        public abstract bool Delete(BaseEntity entity);
        
    }
}
