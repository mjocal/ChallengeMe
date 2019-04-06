using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.Entities
{
    public class Message:BaseEntity
    {
        public string code { get; set; }
        public string description { get; set; }

    }
}
