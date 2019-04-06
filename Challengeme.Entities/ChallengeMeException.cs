using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
   public class ChallengeMeException:Exception
    {
        public string ErrorBusinnesCode { get; set; }
        public string ErrorDescription { get; set; }

        public ChallengeMeException(string errCode)
        {
            ErrorBusinnesCode = errCode;
        }
    }
}
