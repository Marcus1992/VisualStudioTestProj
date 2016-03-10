using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using LibraryClass;
using System.Data;

namespace ServiceLayer
{
    /// <summary>
    /// Summary description for MessageService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MessageService : System.Web.Services.WebService
    {
        public static bool NameTaken
        {
            get;
            set;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public void checkUserName(string pUsername)
        {
            SqlConnection conn = ConnectClass.GetConnection();
            string queryString = "spCheckName";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;
          
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "pUsername";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = pUsername;
            command.Parameters.Add(parameter);
            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                if (pUsername == rdr["Username"].ToString())
                {
                    NameTaken = true;
                }
            }
        }
    }
}
