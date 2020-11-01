using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace M_ERP
{
    class Varibles

    {
        public static int user_id = 0;
        public static String DBserverName = Properties.Settings.Default.DBserverName;
        public static String DBuserId = Properties.Settings.Default.DBuserId;
        public static String DBpassword = Properties.Settings.Default.DBpassword;
        public static String DBPort = Properties.Settings.Default.DBPort;

        public static String DBName = Properties.Settings.Default.DBName;

        public static bool ValidConnection = Properties.Settings.Default.DBConnected;

        public static MySqlConnection myconn;
        public static MySqlCommand cmd;
        
        public static MySqlConnectionStringBuilder myBuilder = new MySqlConnectionStringBuilder();

        public static int sellInvoiceForm = 1;
        public static int buyInvoiceForm = 2;
        public static int sellReturnInvoiceForm = 3;
        public static int buyReturnInvoiceForm = 4;


        private static String key1 = Properties.Settings.Default.Key1;
        private static String key2 = Properties.Settings.Default.Key2;


        public static void setActivated()
        {
            Properties.Settings.Default.Key1 = key2;
            Properties.Settings.Default.Save();

            Properties.Settings.Default.Key2 = key1;
            Properties.Settings.Default.Save();

            key1 = Properties.Settings.Default.Key1;
            key2 = Properties.Settings.Default.Key2;
        }

        public static bool isActivated()
        {
            if (Properties.Settings.Default.Key1 == "Mina")
            {
                return true;
            }
            else 
            {
                return false;
            }

        }

        public static void setUserId(int id)
        {
            user_id = id;
        }

        public static int getUserId()
        {
            return user_id;
        }

        public static void setConnection()
        {
            myBuilder = new MySqlConnectionStringBuilder();

            myBuilder.Database = getDBName();
            myBuilder.Server = getDBServerName();
            myBuilder.Port = Convert.ToUInt32(getDBPort());
            myBuilder.UserID = getDBUserID();
            myBuilder.Password = getDBPassword();

            myconn = new MySqlConnection(myBuilder.ConnectionString);
            cmd = new MySqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.Connection = myconn;

            myconn.Open();
        }

        public static bool checkConnection()
        {
            try
            {
                myBuilder = new MySqlConnectionStringBuilder();

                myBuilder.Database = getDBName();
                myBuilder.Server = getDBServerName();
                myBuilder.Port = Convert.ToUInt32(getDBPort());
                myBuilder.UserID = getDBUserID();
                myBuilder.Password = getDBPassword();


                myconn = new MySqlConnection(myBuilder.ConnectionString);
                cmd = new MySqlCommand();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;

                myconn.Open();


            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                myconn.Close();
            }

            return true;
        }


        public static MySqlCommand getCommand()
        {
            return cmd;
        }

        public static void setDBserverame(String s)
        {
            Properties.Settings.Default.DBserverName = s;
            Properties.Settings.Default.Save();

            DBserverName = s;
        }
        public static String getDBServerName()
        {
            return DBserverName;
        }
        public static void setDBuserID(String s)
        {
            Properties.Settings.Default.DBuserId = s;
            Properties.Settings.Default.Save();

            DBuserId = s;
        }

        public static void setValidConnection(bool tf)
        {
            Properties.Settings.Default.DBConnected = tf;
            Properties.Settings.Default.Save();

            ValidConnection = tf;
        }

        public static bool getValidConnection()
        {
            return ValidConnection;
        }

        public static String getDBUserID()
        {
            return DBuserId;
        }

        public static void setDBPassword(String s)
        {
            Properties.Settings.Default.DBpassword = s;
            Properties.Settings.Default.Save();

            DBpassword = s;
        }
        public static String getDBPassword()
        {
            return DBpassword;
        }
        public static void setDBPort(String s)
        {
            Properties.Settings.Default.DBPort = s;
            Properties.Settings.Default.Save();

            DBPort = s;
        }
        public static String getDBPort()
        {
            return DBPort;
        }

        public static MySqlConnection getConnection()
        {
            return myconn;
        }

        public static String getDBName()
        {
            return DBName;
        }

        public static void closeConnection()
        {
            myconn.Close();
        }

        public static String MD5(String a)
        {
            String s = key1 + a + key2;
            using (var provider = System.Security.Cryptography.MD5.Create())
            {
                StringBuilder builder = new StringBuilder();

                foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                    builder.Append(b.ToString("x2").ToUpper());

                return builder.ToString();
            }
        }
    }

}