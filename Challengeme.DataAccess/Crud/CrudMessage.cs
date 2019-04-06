using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challengeme.Entities;

namespace Challengeme.DataAccess.Crud
{
    public class CrudMessage : CrudFactory
    {
        public override bool Create(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

       

        public override bool Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T RCreate<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override bool Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public override List<T> RetrieveAllById<T>(BaseEntity entity)
        {
            throw new NotImplementedException();

        }
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAllRutasByIdEvento<T>(int idEvento)
        {
            throw new NotImplementedException();
        }

        public override T RetrieveByEmail<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
