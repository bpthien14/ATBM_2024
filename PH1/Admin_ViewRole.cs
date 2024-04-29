using QLDLNB.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLDLNB
{
    public partial class Admin_ViewRole : Form
    {
        AdminConn adminconn = new AdminConn();
        public Admin_ViewRole()
        {
            InitializeComponent();
            adminconn.GetRoles(dataGridView1);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            adminconn.GetRoles(dataGridView1);
        }

        private void btn_CreateRole_Click(object sender, EventArgs e)
        {
            string rolename = txt_RoleName.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(rolename))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                adminconn.CreateRole(rolename);
            }
        }

        private void btn_DeleteRole_Click(object sender, EventArgs e)
        {
            string rolename = txt_RoleName.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(rolename))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                adminconn.DeleteRole(rolename);
            }
        }

        private void btn_ViewUser_Click(object sender, EventArgs e)
        {
            string rolename = txt_RoleName.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(rolename))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                adminconn.GetRoleMembers(rolename, dataGridView1);
            }
        }
    }
}
