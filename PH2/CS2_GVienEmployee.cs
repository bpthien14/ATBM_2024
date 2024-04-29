using QLDLNB_PH1.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDLNB_PH1.PH2
{
    public partial class CS2_GVienEmployee : CS1_BasicEmployee
    {
        public CS2_GVienEmployee()
        {
            InitializeComponent();
        }

        public virtual void ViewPhanCong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.UV_GIANGVIEN_PHANCONG";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        public virtual void ViewDangKy_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.UV_GIANGVIEN_DANGKY";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void FixGrade_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.FixGrade(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                ViewDangKy_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }
    }
}
