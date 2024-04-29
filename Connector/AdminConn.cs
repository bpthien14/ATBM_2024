using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDLNB.Connector
{
    internal class AdminConn
    {
        private static string _connStr;

        ///// User

        public AdminConn(string host, string port, string sid, string username, string password, bool sys)
        {
            if (sys)
            {
                _connStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + "; DBA Privilege = SYSDBA;";
            }
            else
            {
                _connStr = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + ";";
            }
        }

        public bool TestConn()
        {
            using (OracleConnection connection = new OracleConnection(_connStr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to Oracle successful!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đăng nhập với thông tin của bạn: " + ex.Message);
                    return false;
                }
            }
        }
        public AdminConn()
        {
            using (OracleConnection connection = new OracleConnection(_connStr))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to Oracle successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to Oracle: " + ex.Message);
                }
            }
        }

        public void GetUsers(DataGridView dataGridView)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    string query = "sp_GetUser";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("users", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void GetUserPrivileges(string username, DataGridView dataGridView)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    string query = "sp_GetUserPrivileges";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        //command.CommandText = "SELECT COUNT(*) FROM all_users WHERE username = :username";
                        //command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        //int userCount = Convert.ToInt32(command.ExecuteScalar());

                        //if (userCount > 0)
                        //{
                        //    command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("user_privileges", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Người dùng " + username + " không tồn tại!", "Thông báo");
                        //}
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void DeleteUser(string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM all_users WHERE username = :username";
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            command.Parameters.Clear();
                            command.CommandText = "sp_DeleteUser";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa người dùng " + username + " thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Người dùng " + username + " không tồn tại!", "Thông báo");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void CreateUser(string username, string password)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM all_users WHERE username = :username";
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Người dùng " + username + " đã tồn tại!", "Thông báo");
                        }
                        else
                        {
                            command.Parameters.Clear();
                            command.CommandText = "sp_CreateUser";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                            command.ExecuteNonQuery();

                            MessageBox.Show("Người dùng " + username + " đã được tạo thành công!", "Thông báo");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void EditUser(string username, string password)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM all_users WHERE username = :username";
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            command.Parameters.Clear();
                            command.CommandText = "sp_EditUser";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                            command.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;

                            command.ExecuteNonQuery();

                            MessageBox.Show("Người dùng " + username + " đã được chỉnh sửa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Người dùng " + username + " không tồn tại!", "Thông báo");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        ///// Role
        public void GetRoles(DataGridView dataGridView)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    string query = "sp_GetRoles";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("roles", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void GetRoleMembers(string roleName, DataGridView dataGridView)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    string query = "sp_GetRoleMembers";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                        command.Parameters.Add("role_members", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void DeleteRole(string roleName)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM dba_role_privs WHERE granted_role = :roleName";
                        command.Parameters.Add(":roleName", OracleDbType.Varchar2).Value = roleName;

                        int roleCount = Convert.ToInt32(command.ExecuteScalar());

                        if (roleCount > 0)
                        {
                            command.Parameters.Clear();
                            command.CommandText = "sp_DeleteRole";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_role", OracleDbType.Varchar2).Value = roleName;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role " + roleName + " đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại role có tên này!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CreateRole(string roleName)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT COUNT(*) FROM dba_role_privs WHERE granted_role = :roleName";
                        command.Parameters.Add(":roleName", OracleDbType.Varchar2).Value = roleName;

                        int roleCount = Convert.ToInt32(command.ExecuteScalar());

                        if (roleCount > 0)
                        {
                            MessageBox.Show("Đã tồn tại role có tên này!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            command.Parameters.Clear();
                            command.CommandText = "sp_CreateRole";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("p_role", OracleDbType.Varchar2).Value = roleName;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Role " + roleName + " đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //// Cấp quyền
        public void GetUserRole(string username, DataGridView dataGridView)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    string query = "sp_get_user_roles";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_user_name", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("role_members", OracleDbType.RefCursor, ParameterDirection.Output);
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void GrantPermission(string username, string tableName, string? columnName, string permission, bool withGrantOption)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("sp_GrantPermission", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho procedure
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_table_name", OracleDbType.Varchar2).Value = tableName;
                        command.Parameters.Add("p_column_name", OracleDbType.Varchar2).Value = columnName;
                        command.Parameters.Add("p_permission", OracleDbType.Varchar2).Value = permission;
                        command.Parameters.Add("p_with_grant_option", OracleDbType.Int32).Value = withGrantOption ? 1 : 0;

                        // Thực thi procedure
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MessageBox.Show("Cấp quyền thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void GrantRoleToUser(string roleName, string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "GrantRoleToUser";

                        // Thêm các tham số cho procedure
                        command.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Cấp role " + roleName + " cho " + username + " thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public bool CheckUserOrRoleExists(string username, string Role)
        {
            bool exists = false;

            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        // Kiểm tra username
                        command.CommandText = "SELECT COUNT(*) FROM all_users WHERE username = :username";
                        command.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 1) count = 1;

                        // Kiểm tra role
                        command.CommandText = "SELECT COUNT(*) FROM dba_roles WHERE role = :role";
                        command.Parameters.Clear();
                        command.Parameters.Add(":role", OracleDbType.Varchar2).Value = Role;

                        count += Convert.ToInt32(command.ExecuteScalar());
                        exists = (count > 1);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return exists;
        }
        public void RevokeRoleFromUser(string roleName, string userName)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "sp_RevokeRoleFromUser";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = userName;
                        command.Parameters.Add("p_role_name", OracleDbType.Varchar2).Value = roleName;

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Thu hồi role " + roleName + " từ " + userName + " thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public void RevokePermission(string username, string tableName, string permission, string? columnName = null)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("sp_RevokePermission", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho procedure
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_table_name", OracleDbType.Varchar2).Value = tableName;
                        command.Parameters.Add("p_permission", OracleDbType.Varchar2).Value = permission;
                        command.Parameters.Add("p_column_name", OracleDbType.Varchar2).Value = columnName;

                        // Thực thi procedure
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Thu hồi quyền thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void CreateViewAndGrantSelect(string? columnName, string tableName, bool withGrantOption, string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connStr))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand("sp_CreatView_GrantSelect", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho procedure
                        command.Parameters.Add("p_column_name", OracleDbType.Varchar2).Value = columnName;
                        command.Parameters.Add("p_table_name", OracleDbType.Varchar2).Value = tableName;
                        command.Parameters.Add("p_with_grant_option", OracleDbType.Int32).Value = withGrantOption ? 1 : 0;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                        // Thực thi procedure
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                string viewName = "UV_" + columnName + "_" + tableName;
                MessageBox.Show("Đã tạo View " + viewName + " và cấp quyền SELECT cho người dùng " + username + " thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}