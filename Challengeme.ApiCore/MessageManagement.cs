using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.ApiCore
{
   public class MessageManagement:BaseManagement
    {
        public Dictionary<string, string> ListMessages { get; set; }

        public MessageManagement()
        {
            ListMessages = new Dictionary<string, string>();
            LoadMessages();
        }

        private void LoadMessages()
        {
            //
            //var crudMessage = new CrudMessage();
            //var lstMsgs = crudMessage.RetrieveAll<Message>();

            //foreach (var msg in lstMsgs)
            //{
            //    ListMessages[msg.code] = msg.description;

            //}

            ListMessages["FE.0001"] = "Nuestros servidores no se encuentran disponibles";
            ListMessages["BE.0001"] = "El usuario no cumple con la edad mínima";
            ListMessages["BE.0002"] = "El registro ya existe en la base de datos";

        }

        public string GetMessageByCode(string code)
        {
            return ListMessages[code];
        }

    }
}
