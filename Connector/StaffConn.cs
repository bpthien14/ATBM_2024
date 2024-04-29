using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDLNB_PH1.Connector
{
    internal class StaffConn
    {
        public static string _connStr;

        ///// User
        public StaffConn(string host, string port, string sid, string username, string password)
        {
            _connStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + ";";
        }

        public bool TestConn()
        {
            using (OracleConnection connection = new OracleConnection(_connStr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to Oracle successful!");
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đăng nhập với thông tin của bạn: " + ex.Message);
                    return false;
                }
            }
        }

        public List<string> GetRoles()
        {
            using (OracleConnection conn = new OracleConnection(_connStr))
            {
                List<string> roles = new List<string>();
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM SESSION_ROLES";
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            roles.Add(reader.GetString(0));
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kiểm tra vai trò của bạn: " + ex.Message);
                }
                return roles;
            }
        }
        public StaffConn()
        {
            using (OracleConnection connection = new OracleConnection(_connStr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to Oracle successful!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to Oracle: " + ex.Message);
                }
            }
        }
    }
}