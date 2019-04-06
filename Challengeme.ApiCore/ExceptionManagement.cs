using Challengeme.Entities;
using System;
using System.Data.SqlClient;
using System.IO;

namespace Challengeme.ApiCore
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
            //Determinamos si es una excepcion tipo ChallengeMe
            if (ex.GetType() == typeof(ChallengeMeException))
            {
                ManageException((ChallengeMeException)ex);
            }
            else if (ex.GetType() == typeof(SqlException))
            {
                var sqlEx = (SqlException)ex;
                //Registro ya existe en la BD.
                if (sqlEx.Number == 2627)
                {
                    //BE.0002 = Registro ya existe en la Base de Datos
                    //BE => Business Exception
                    var rEx = new ChallengeMeException("BE.0002");
                    ManageException(rEx);
                }
                else
                {
                    var rEx = new ChallengeMeException("FE.0001");
                    ManageException(rEx);
                }
            }
            else
            {
                //Si no es ninguna de las anteriores excepciones
                //entonces manejamos la excepcion como una excepcion
                //genérica y lo manejamos como un Fatal Error.
                //Creamos un código genérico que es para tipo de excepciones
                //no controladas
                var rEx = new ChallengeMeException("FE.0001");
                ManageException(rEx);
            }
            throw ex;
        }

        public void ManageException(ChallengeMeException ex)
        {
            //Tiene que Determinar el mensaje de error
            var mm = new MessageManagement();
            ex.ErrorDescription = mm.GetMessageByCode(ex.ErrorBusinnesCode);




            //Escribe el error en el Log.
            using (StreamWriter w = File.AppendText("c:\\temp\\log.txt"))
            {
                Log(ex.ErrorDescription, w);
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
