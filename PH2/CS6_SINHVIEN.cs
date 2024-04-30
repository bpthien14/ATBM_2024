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
    public partial class CS6_SINHVIEN : Form
    {
        public CS6_SINHVIEN()
        {
            InitializeComponent();
        }

        private void ViewSinhVien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.SINHVIEN";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = false;
        }

        private void fixPhoneOrAddress_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.fixPhoneOrAddress(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                ViewSinhVien_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void ViewHocPhan_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            string query = "SELECT * FROM SEC_ADM.HOCPHAN";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ViewKHMo_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            string query = "SELECT * FROM SEC_ADM.KHMO";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void updateDKy_Click(object sender, EventArgs e)
        {
            string MASV = textMASV.Text;
            string MAGV = textMAGV.Text;
            string MAHP = textMAHP.Text;
            int HK = Convert.ToInt32(textHK.Text);
            int NAM = Convert.ToInt32(textNAM.Text);
            string MACT = textMACT.Text;
            // Bổ sung các thông tin khác cần thiết cho việc đăng kí, như điểm thi, điểm quá trình, điểm cuối kỳ, điểm tổng kết...

            // Tạo một Đăng ký mới
            DKiDTO Registration = new DKiDTO()
            {
                MaSV = MASV,
                MaGV = MAGV,
                MaHP = MAHP,
                HK = HK,
                NAM = NAM,
                MaCT = MACT,
                // Bổ sung các thông tin khác vào đây
            };

            // Thực hiện thêm đăng ký vào cơ sở dữ liệu
            if (UserDAO.Instance.AddDANGKY(Registration))
            {
                MessageBox.Show("Thêm đăng ký thành công!");
                // Cập nhật giao diện hiển thị danh sách đăng ký sau khi thêm thành công
                //ViewDANGKY_Click(sender, e);
                button1_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Thêm đăng ký không thành công!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MASV = textMASV.Text;
            string MAGV = textMAGV.Text;
            string MAHP = textMAHP.Text;
            int HK = Convert.ToInt32(textHK.Text);
            int NAM = Convert.ToInt32(textNAM.Text);
            string MACT = textMACT.Text;

            // Tạo một Đăng ký mới để sử dụng cho việc xóa
            DKiDTO registration = new DKiDTO()
            {
                MaSV = MASV,
                MaGV = MAGV,
                MaHP = MAHP,
                HK = HK,
                NAM = NAM,
                MaCT = MACT
            };

            if (UserDAO.Instance.deleteDANGKY(registration))
            {
                MessageBox.Show("Xóa đăng ký thành công!");
                // Cập nhật giao diện hiển thị danh sách đăng ký sau khi xóa thành công
                //ViewDANGKY_Click(sender, e);
                button1_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Xóa đăng ký không thành công!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.DANGKY";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = true;
        }
    }
}
