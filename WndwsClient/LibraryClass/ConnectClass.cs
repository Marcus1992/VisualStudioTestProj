using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace LibraryClass
{
  public class ConnectClass
    {
      public static string passU
      {
          get;
          set;
      }

      public static bool Access
      {
          get;
          set;
      }
      public static int UseType
      {
          get;
          set;
      }
      public static bool NameTaken
      {
          get;
          set;
      }
        public static SqlConnection GetConnection()
        {
            var connectionString = @"data source = .\sqlexpress; integrated security = true; database = ExamDB";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public static SqlCommand AddUser(string pUserName, string pPassword, string pCountry, int pPhone, int pUserType)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            string queryString = "spAddNewUser";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter Username = command.Parameters.Add("@Username", SqlDbType.VarChar);
            SqlParameter Password = command.Parameters.Add("@Password", SqlDbType.VarChar);
            SqlParameter Country = command.Parameters.Add("@Country", SqlDbType.VarChar);
            SqlParameter Phone = command.Parameters.Add("@Phone", SqlDbType.Int);
            SqlParameter UserType = command.Parameters.Add("@UserType", SqlDbType.Bit);

            Username.Value = pUserName;
            Password.Value = pPassword;
            Country.Value = pCountry;
            Phone.Value = pPhone;
            UserType.Value = pUserType;

            command.ExecuteNonQuery();
            conn.Close();
            return command;
        }
        public static SqlCommand AddMessage(string pHeadline, string pMessage)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            string queryString = "spAddNewMessage";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter Headline = command.Parameters.Add("@Headline", SqlDbType.VarChar);
            SqlParameter Message = command.Parameters.Add("@Message", SqlDbType.VarChar);

            Headline.Value = pHeadline;
            Message.Value = pMessage;

            command.ExecuteNonQuery();
            conn.Close();
            return command;
        }
        public static SqlCommand checkLogin(string pUsername, string pPassword)
        {
            SqlConnection conn = GetConnection();
            string queryString = "spCheckLogin";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            SqlParameter parameter2 = new SqlParameter();
            parameter.ParameterName = "@pUsername";
            parameter2.ParameterName = "@pPassword";

            parameter.SqlDbType = SqlDbType.VarChar;
            parameter2.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter2.Direction = ParameterDirection.Input;

            parameter.Value = pUsername;
            parameter2.Value = pPassword;
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);

            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                try
                {  
                    if (rdr["Username"].ToString().Equals(pUsername) && rdr["Password"].ToString().Equals(pPassword))
                    {
                        Access = true;
                    }
                    else
                    {
                        Access = false;
                    }
                }
                catch (Exception e)
                {
                    passU = "Database Error";
                    Access = false;
                }
            }
            rdr.Close();
            conn.Close();
            return command;
        }
        public static void GetUserType(string pUserName)
        {
            SqlConnection conn = GetConnection();
            string queryString = "spGetUserType";
            SqlCommand command = new SqlCommand(queryString, conn);
           
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pUsername";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = pUserName;
            command.Parameters.Add(parameter);
            conn.Open();

            SqlDataReader rdr = command.ExecuteReader();

                if (rdr.Read() && rdr["UserType"].ToString().Equals("True"))
                {
                    UseType = 1; 
                }
                else if(rdr.Read() && rdr["UserType"].ToString().Equals("False"))
                {
                    UseType = 0;
                }
        }
        public static void checkUserName(string pUsername)
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

        public static void getName()
        {
            SqlConnection conn = GetConnection();
        }

        public static void GetData(string selectCommand)
        {
            //try
            //{
            //    SqlConnection conn = GetConnection();

            //    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, conn);
            //    datagrid
            //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            //    DataTable table = new DataTable();
            //    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            //    adapter.Fill(table);
                
            //}
        }
    }
}