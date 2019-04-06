using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengeme.DataAccess.Management
{
    public class ExceptionManagement
    {
        private static ExceptionManagement _instance;

        private ExceptionManagement()
        {

        }

        public static ExceptionManagement GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ExceptionManagement();
            }
            return _instance;
        }

        public void ManageException(Exception ex)
        {
            using (StreamWriter w = File.AppendText("c:\\temp\\log.txt"))
            {
                Log(ex.Message, w);
            }
            throw ex;
        }

        private static void Log(string logMessage, TextWriter w)
        {


            w.Write("\r\nLog Entry :");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine(" : ");
            w.WriteLine(" :{0}", logMessage);
            w.WriteLine("----------------------------------");
        }
    }
}
