using Oracle.ManagedDataAccess.Client;
using QLDLNB.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDLNB
{
    public partial class Admin_Privileges : Form
    {
        AdminConn conn = new AdminConn();
        public Admin_Privileges()
        {
            InitializeComponent();
            txt_Col.Visible = false;
            panel1.Hide();
        }

        private void Permission_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Khi chọn quyền select hoặc update
            if ((e.Index == 0 && e.NewValue == CheckState.Checked) || (e.Index == 2 && e.NewValue == CheckState.Checked))
            {
                // nếu không tồn tại quyền insert và delete
                if (!Permission.GetItemChecked(1) && !Permission.GetItemChecked(3))
                {
                    // cho phép nhập phân quyền trên dòng
                     txt_Col.Visible = true;
                }
                // nếu có tồn tại 
                else
                {
                    txt_Col.Visible = false;
                    txt_Col.Clear();
                }
            }
            // Khi bỏ chọn quyền insert hoặc delete
            else if ((e.Index == 1 && e.NewValue == CheckState.Unchecked) || (e.Index == 3 && e.NewValue == CheckState.Unchecked))
            {
                // nếu chỉ tồn tại quyền select và update
                if ((Permission.GetItemChecked(0) || Permission.GetItemChecked(2)) && (!Permission.GetItemChecked(1) || !Permission.GetItemChecked(3)))
                {
                    // cho phép nhập phân quyền trên dòng
                    txt_Col.Visible = true;
                }
                else
                {
                    txt_Col.Visible = false;
                    txt_Col.Clear();
                }
            }
            else
            {
                txt_Col.Visible = false;
                txt_Col.Clear(); 
            }
        }

        private void btn_Grant_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim().ToUpper(); // Lấy tên user hoặc role và loại bỏ khoảng trắng
            string tableName = txt_Tab.Text.Trim().ToUpper(); // Lấy tên bảng và loại bỏ khoảng trắng
            string? columnName = string.IsNullOrEmpty(txt_Col.Text) ? null : txt_Col.Text.Trim().ToUpper(); // Lấy tên cột (nếu không null) và loại bỏ khoảng trắng
            bool withGrantOption = checkBox1.Checked;

            // Lấy quyền từ danh sách Permission
            string permission = "";
            foreach (object itemChecked in Permission.CheckedItems)
            {
                permission += itemChecked.ToString() + ", ";
            }
            permission = permission.TrimEnd(',', ' '); // Xóa dấu phẩy cuối cùng và khoảng trắng

            // Kiểm tra tính hợp lệ của các tham số đầu vào
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(permission))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên user/role, Tên bảng, Quyền hạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (columnName != null && Permission.GetItemChecked(0))
            {
                DialogResult res1 = MessageBox.Show("Grant " + permission + " on " + tableName + (columnName != null ? "(" + columnName + ")" : "") + " to " + name + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (Permission.GetItemChecked(2))
                {
                    conn.GrantPermission(name, tableName, columnName, "UPDATE", withGrantOption);
                }
                conn.CreateViewAndGrantSelect(columnName, tableName, withGrantOption, name);
                conn.GetUserPrivileges(name, dataGridView1);
                conn.GetUserRole(name, dataGridView2);
                return;
            }
            else
            {
                DialogResult res2 = MessageBox.Show("Grant " + permission + " on " + tableName + " to " + name + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (res2 == DialogResult.Yes)
                {
                    // Thực hiện cấp quyền và cập nhật danh sách quyền
                    conn.GrantPermission(name, tableName, columnName, permission, withGrantOption);
                    conn.GetUserPrivileges(name, dataGridView1);
                    conn.GetUserRole(name, dataGridView2);
                }
                else
                {
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim().ToUpper(); // Lấy tên user hoặc role và loại bỏ khoảng trắng
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập thông tin User ở ô bên dưới.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.GetUserPrivileges(name, dataGridView1);
            conn.GetUserRole(name, dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string rolename = txt_Role.Text.Trim().ToUpper();
            string username = txt_User.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(rolename))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên user/role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!conn.CheckUserOrRoleExists(username, rolename))
            {
                MessageBox.Show("user/role không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                conn.GrantRoleToUser(rolename, username);
                conn.GetUserPrivileges(username, dataGridView1);
                conn.GetUserRole(username, dataGridView2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
            string rolename = txt_Role.Text.Trim().ToUpper();
            string username = txt_User.Text.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(rolename))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên user/role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!conn.CheckUserOrRoleExists(username, rolename))
            {
                MessageBox.Show("user/role không tồn tại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                conn.RevokeRoleFromUser(rolename, username);
                conn.GetUserPrivileges(username, dataGridView1);
                conn.GetUserRole(username, dataGridView2);
            }
        }

        private void btn_Revoke_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim().ToUpper(); // Lấy tên user hoặc role và loại bỏ khoảng trắng
            string tableName = txt_Tab.Text.Trim().ToUpper(); // Lấy tên bảng và loại bỏ khoảng trắng
            string? columnName = string.IsNullOrEmpty(txt_Col.Text) ? null : txt_Col.Text.Trim().ToUpper(); // Lấy tên cột (nếu không null) và loại bỏ khoảng trắng

            // Lấy quyền từ danh sách Permission
            string permission = "";
            foreach (object itemChecked in Permission.CheckedItems)
            {
                permission += itemChecked.ToString() + ", ";
            }
            permission = permission.TrimEnd(',', ' '); // Xóa dấu phẩy cuối cùng và khoảng trắng

            // Kiểm tra tính hợp lệ của các tham số đầu vào
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(tableName) || string.IsNullOrWhiteSpace(permission))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên user/role, Tên bảng, Quyền hạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (columnName != null)
            {
                if (Permission.GetItemChecked(2) && !Permission.GetItemChecked(0))
                {
                    DialogResult res = MessageBox.Show("Quyền UPDATE phải được thu hồi trên bảng, không thể thu hồi trên cột. Tiếp tục thu hồi trên bảng?", "Confirmation", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        txt_Col.Clear();
                        conn.RevokePermission(name, tableName, permission, null);
                        conn.GetUserPrivileges(name, dataGridView1);
                        conn.GetUserRole(name, dataGridView2);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (!Permission.GetItemChecked(2) && Permission.GetItemChecked(0))
                {
                    MessageBox.Show("Để thu hồi quyền SELECT trên cột, hãy nhập tên View đã tạo vào ô Table name.\nCú pháp view: UV_<tên cột>_<tên_bảng>", "Thông báo", MessageBoxButtons.OK);
                    txt_Col.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Để thu hồi quyền SELECT trên cột, hãy nhập tên View đã tạo vào ô Table name.\nCú pháp view: UV_<tên cột>_<tên_bảng>", "Thông báo", MessageBoxButtons.OK);
                    DialogResult res = MessageBox.Show("Quyền UPDATE phải được thu hồi trên bảng, không thể thu hồi trên cột. Tiếp tục thu hồi trên bảng?", "Confirmation", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        conn.RevokePermission(name, tableName, "UPDATE", null);
                        conn.GetUserPrivileges(name, dataGridView1);
                        conn.GetUserRole(name, dataGridView2);
                    }
                    txt_Col.Clear();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Revoke " + permission + " on " + tableName + " from " + name + "?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Thực hiện thu hồi quyền và cập nhật danh sách quyền
                    conn.RevokePermission(name, tableName, permission, columnName);
                    conn.GetUserPrivileges(name, dataGridView1);
                    conn.GetUserRole(name, dataGridView2);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
