using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
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
    public static int UserN
        {
            get;
            set;
        }

        public static string MailPass
        {
            get;
            set;
        }
        public static string MailUser
        {
            get;
            set;
        }
        
        public static SqlConnection GetConnection()
        {
          //  var connectionString = @"data source = .\sqlexpress; integrated security = true; database = ExamDB";
            var connectionString = "Server=tcp:servermarc.database.windows.net,1433;Database=TestDB;User ID=cphmu@servermarc;Password=Hejmig123;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public static SqlCommand AddUser(string pUserName, string pPassword, string pEmail, string pCountry, int pPhone, int pUserType)
        {
            SqlConnection conn = GetConnection();
            conn.Open();

            string queryString = "spAddNewUser";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter Username = command.Parameters.Add("@Username", SqlDbType.VarChar);
            SqlParameter Password = command.Parameters.Add("@Password", SqlDbType.VarChar);
            SqlParameter Email = command.Parameters.Add("@Email", SqlDbType.VarChar);
            SqlParameter Country = command.Parameters.Add("@Country", SqlDbType.VarChar);
            SqlParameter Phone = command.Parameters.Add("@Phone", SqlDbType.Int);
            SqlParameter UserType = command.Parameters.Add("@UserType", SqlDbType.Bit);

            Username.Value = pUserName;
            Password.Value = pPassword;
            Email.Value = pEmail;
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

            SqlParameter Headline = command.Parameters.Add("@pHeadline", SqlDbType.VarChar);
            SqlParameter Message = command.Parameters.Add("@pMessage", SqlDbType.VarChar);
            SqlParameter User = command.Parameters.Add("@pUserID", SqlDbType.Int);


            Headline.Value = pHeadline;
            Message.Value = pMessage;
            User.Value = UserN;

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
                        passU = rdr["Username"].ToString();
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
            SqlConnection conn = GetConnection();
            string queryString = "spCheckName";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pUsername";
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

        public static void getPassword(string pEmail)
        {
            SqlConnection conn = GetConnection();
            string queryString = "spGetPassword";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "pEmail";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = pEmail;
            command.Parameters.Add(parameter);
            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                if(pEmail == rdr["Email"].ToString())
                {
                    MailPass = rdr["Password"].ToString();
                    MailUser = rdr["Email"].ToString();
                }
            }
        }

        public static void MailSender()
        {
            var fromAddress = new MailAddress("nicolajstr@gmail.com", "Password recovery");
            var toAddress = new MailAddress(MailUser, passU);

            const string fromPassword = "Synopsisklamp22";
            const string subject = "Password Recovery";
            string body = "You receive this email because you forgot your password, your password is \n" + MailPass;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        public static void GetUserID(string pUsername)
        {
            SqlConnection conn = GetConnection();
            string queryString = "spGetID";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@pUsername";
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = pUsername;
            command.Parameters.Add(parameter);
            conn.Open();
            SqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                if(pUsername == rdr["Username"].ToString())
                {
                    UserN = Convert.ToInt32(rdr["UserID"]);
                }
            }
        }
        public static void updateUserInfo(string pUsername, string pPassword, string pCountry, int pPhone)
        {
            SqlConnection conn = GetConnection();
            string queryString = "spUpdateUserInfo";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter();
            SqlParameter parameter2 = new SqlParameter();
            SqlParameter parameter3 = new SqlParameter();
            SqlParameter paramter4 = new SqlParameter();

            parameter.ParameterName = "@pUsername";
            parameter2.ParameterName = "pPassword";
            parameter3.ParameterName = "pCountry";
            paramter4.ParameterName = "pPhone";

            parameter.SqlDbType = SqlDbType.VarChar;
            parameter2.SqlDbType = SqlDbType.VarChar;
            parameter3.SqlDbType = SqlDbType.VarChar;
            paramter4.SqlDbType = SqlDbType.Int;

            parameter.Direction = ParameterDirection.Input;
            parameter2.Direction = ParameterDirection.Input;
            parameter3.Direction = ParameterDirection.Input;
            paramter4.Direction = ParameterDirection.Input;

            parameter.Value = pUsername;
            parameter2.Value = pPassword;
            parameter3.Value = pCountry;
            paramter4.Value = pPhone;

            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);
            command.Parameters.Add(paramter4);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static bool isValid(string emailAddress)
        {
            try
            {
                MailAddress ma = new MailAddress(emailAddress);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }
    }
}