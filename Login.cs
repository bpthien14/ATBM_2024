using QLDLNB;
using QLDLNB.Connector;
using QLDLNB_PH1.Connector;
using QLDLNB_PH1.PH2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDLNB_PH1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string? host = txtHost.Text;
            string? port = txtPort.Text;
            string? sid = txtSID.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(host)) { host = "localhost"; }
            if (string.IsNullOrEmpty(port)) { port = "1521"; }
            if (string.IsNullOrEmpty(sid)) { sid = "xepdb1"; }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                return;
            }
            else
            {
                if (username.ToUpper() == "SYS" || username.ToUpper() == "SYSTEM")
                {
                    AdminConn conn = new AdminConn(host, port, sid, username, password, true);
                    if (conn.TestConn())
                    {
                        Admin frmAdmin = new Admin();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (username.ToUpper() == "SEC_ADM")
                {
                    AdminConn conn = new AdminConn(host, port, sid, username, password, false);
                    if (conn.TestConn())
                    {
                        Admin frmAdmin = new Admin();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    StaffConn conn = new StaffConn(host, port, sid, username, password);
                    if (conn.TestConn())
                    {
                        List<string> roles = conn.GetRoles();

                        if (roles.Contains("RL_TRUONG_KHOA"))
                        {

                        }
                        else if (roles.Contains("RL_TRUONG_DON_VI"))
                        {
                            CS4_TRUONGDONVI frmEmployee4 = new CS4_TRUONGDONVI();
                            frmEmployee4.Show();
                            this.Hide();
                        }
                        else if (roles.Contains("RL_GIAO_VU"))
                        {
                            CS3_GVuEmployee frmEmployee3 = new CS3_GVuEmployee();
                            frmEmployee3.Show();
                            this.Hide();
                        }
                        else if (roles.Contains("RL_GIANG_VIEN"))
                        {
                            CS2_GVienEmployee frmEmployee2 = new CS2_GVienEmployee();
                            frmEmployee2.Show();
                            this.Hide();
                        }
                        else if (roles.Contains("RL_NV_CO_BAN"))
                        {
                            CS1_BasicEmployee frmEmployee1 = new CS1_BasicEmployee();
                            frmEmployee1.Show();
                            this.Hide();
                        }
                        else if (roles.Contains("RL_SINHVIEN"))
                        {
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Người dùng không thuộc hệ thống quản lý dữ liệu nội bộ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}