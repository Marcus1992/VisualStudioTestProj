using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using LibraryClass;
using System.Net.Mail;
using System.Data;
namespace LibraryClass.Tests
{
    [TestClass]
    public class LoginTest
    {
        public static SqlConnection GetConnection()
        {
            var connectionString = @"data source = .\sqlexpress; integrated security = true; database = ExamDB";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public static bool isValid(string emailAddress)
        {
            try
            {
                MailAddress ma = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static string checkLogin()
        {
            SqlConnection conn = GetConnection();
            string queryString = "spCheckLogin";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            SqlParameter parameter2 = new SqlParameter();
            parameter.ParameterName = "@pUsername";
            parameter2.ParameterName = "@pPassword";

            parameter.SqlDbType = SqlDbType.VarChar;
            parameter2.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter2.Direction = ParameterDirection.Input;
            string namun = "Hey";
            string passun = "123";
            parameter.Value = namun;
            parameter2.Value = passun;
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);

            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();
            //while (rdr.Read())
            //{
            //try
            //{
            if (rdr["Username"].ToString().Equals(parameter) && rdr["Password"].ToString().Equals(parameter2))
            {
                return "Marcus";
            }
            else
            {
                return "unknown";
            }
        }
        //catch (Exception e)
        //{

        //}
        //}
        //rdr.Close();
        //conn.Close();
        //return "N/A";

        [TestMethod]
        public void isTrued()
        {
            string valu = checkLogin();
            Assert.AreEqual("Marcus", valu);
        }
    }
}
