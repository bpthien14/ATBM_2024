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
    public partial class Admin_ViewUser : Form
    {
        AdminConn adminconn = new AdminConn();
        public Admin_ViewUser()
        {
            InitializeComponent();
            adminconn.GetUsers(dataGridView1);
            panel1.Hide();
            panel2.Hide();
        }

        private void btn_ViewPriv_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.ToUpper();
            adminconn.GetUserPrivileges(username, dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            adminconn.GetUsers(dataGridView1);
            panel1.Hide();
            panel2.Hide();
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                adminconn.DeleteUser(username); 
            }
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string username = txt_Username2.Text.ToUpper();
            string password = txt_Password.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin username và password!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            txt_Username2.Clear();
            txt_Password.Clear();
            panel1.Hide();
            adminconn.CreateUser(username, password);
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void btn_OK2_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text.ToUpper();
            string password = textBox1.Text.ToUpper();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin username và password!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                textBox2.Clear();
                textBox1.Clear();
                panel1.Hide();
                adminconn.EditUser(username, password);
            }
        }
    }
}
