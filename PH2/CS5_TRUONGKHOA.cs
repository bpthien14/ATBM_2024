using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CS5_TRUONGKHOA : CS4_TRUONGDONVI
    {
        public CS5_TRUONGKHOA()
        {
            InitializeComponent();
        }

        public override void ViewPhanCong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.PHANCONG";
            CS4_TRUONGDONVI.dataGridView2.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            CS4_TRUONGDONVI.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CS4_TRUONGDONVI.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public override void Fix_PhanCong_Click(object sender, EventArgs e)
        {
            DataGridViewRow OldRow = dataGridView2.SelectedCells[0].OwningRow;

            string oldMAHP = OldRow.Cells["MAHP"].Value.ToString();
            string oldMAGV = OldRow.Cells["MAGV"].Value.ToString();
            int oldHK = Convert.ToInt32(OldRow.Cells["HK"].Value);
            int oldNAM = Convert.ToInt32(OldRow.Cells["NAM"].Value);
            string oldMACT = OldRow.Cells["MACT"].Value.ToString();
            MessageBox.Show(oldMAHP + " | " + oldMAGV);
            //DataGridViewRow Row = data.SelectedCells[0].OwningRow;

            string MAHP = textMAHP.Text;
            string MAGV = textMAGV.Text;
            int HK = Convert.ToInt32(textHK.Text);
            int NAM = Convert.ToInt32(textNAM.Text);
            string MACT = textMACT.Text;

            PhanCongDTO OldUser = new PhanCongDTO()
            {
                MAHP = oldMAHP,
                MAGV = oldMAGV,
                HK = oldHK,
                NAM = oldNAM,
                MACT = oldMACT
            };
            PhanCongDTO User = new PhanCongDTO()
            {
                MAHP = MAHP,
                MAGV = MAGV,
                HK = HK,
                NAM = NAM,
                MACT = MACT
            };

            if (UserDAO.Instance.FixPhanCongTRUONGKHOA(OldUser, User))
            {
                MessageBox.Show("Sửa thành công!");
                ViewPhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        public override void deletePHANCONG_Click(object sender, EventArgs e)
        {
            string MAHP = textMAHP.Text;
            string MAGV = textMAGV.Text;
            int HK = Convert.ToInt32(textHK.Text);
            int NAM = Convert.ToInt32(textNAM.Text);
            string MACT = textMACT.Text;
            PhanCongDTO User = new PhanCongDTO()
            {
                MAHP = MAHP,
                MAGV = MAGV,
                HK = HK,
                NAM = NAM,
                MACT = MACT
            };
            if (UserDAO.Instance.deletePHANCONG_TRUONGKHOA(User))
            {
                MessageBox.Show("Xóa thành công!");
                ViewPhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
        public override void ViewDangKy_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.DANGKY";

            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void addNHANVIEN_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Add_NhanVien(dataGridView3))
            {
                MessageBox.Show("Thêm thành công!");
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void deleteNHANVIEN_Click(object sender, EventArgs e)
        {
            string MANV = textMANV.Text;
            string HOTEN = textHOTEN.Text;
            string PHAI = textPHAI.Text;
            string DT = textDIENTHOAI.Text;
            string VAITRO = textVAITRO.Text;
            string MADV = textMADV.Text;
            // Tiếp tục lấy dữ liệu từ các TextBox khác

            // Tạo đối tượng NVienDTO và gán giá trị
            NVienDTO user = new NVienDTO();
            {
                user.MANV = MANV;
                user.HOTEN = HOTEN;
                user.PHAI = PHAI;
                user.DT = DT;
                user.VAITRO = VAITRO;
                user.MADV = MADV;

                user.NGAYSINH = Convert.ToDateTime(textNGSINH.Text);
                user.PHUCAP = Convert.ToDecimal(textPHUCAP.Text);

                // Tiếp tục gán các giá trị khác
            }

            // Gọi hàm Add_NhanVien từ UserDAO để thêm nhân viên
            if (UserDAO.Instance.DeleteNhanVien(user))
            {
                MessageBox.Show("Xóa nhân viên thành công!");

                // Cập nhật lại dữ liệu trên DataGridView sau khi xóa
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên không thành công!");
            }
        }
        public override void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.NHANSU";
            dataGridView3.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView3.SelectedCells[0].OwningRow;

                // Lấy giá trị từ cột "MANV" của dòng được chọn và đưa vào TextBox textMANV
                textMANV.Text = row.Cells["MANV"].Value.ToString();

                // Tiếp tục lấy giá trị từ các cột khác của dòng được chọn và đưa vào các TextBox tương ứng
                // Ví dụ:
                textHOTEN.Text = row.Cells["HOTEN"].Value.ToString();
                textPHAI.Text = row.Cells["PHAI"].Value.ToString();
                textNGSINH.Text = row.Cells["NGSINH"].Value.ToString();
                textPHUCAP.Text = row.Cells["PHUCAP"].Value.ToString();
                textDIENTHOAI.Text = row.Cells["DT"].Value.ToString();
                textVAITRO.Text = row.Cells["VAITRO"].Value.ToString();
                textMADV.Text = row.Cells["MADV"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu từ DataGridView: " + ex.Message);
            }
        }
        public override void FixPhone_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow OldRow = dataGridView3.SelectedCells[0].OwningRow;

                // Lấy thông tin cũ của nhân viên từ các ô của dòng được chọn
                string oldMANV = OldRow.Cells["MANV"].Value.ToString();
                string oldHOTEN = OldRow.Cells["HOTEN"].Value.ToString();
                string oldPHAI = OldRow.Cells["PHAI"].Value.ToString();
                DateTime oldNGAYSINH = Convert.ToDateTime(OldRow.Cells["NGSINH"].Value);
                decimal oldPHUCAP = Convert.ToDecimal(OldRow.Cells["PHUCAP"].Value);
                string oldDT = OldRow.Cells["DT"].Value.ToString();
                string oldVAITRO = OldRow.Cells["VAITRO"].Value.ToString();
                string oldMADV = OldRow.Cells["MADV"].Value.ToString();

                // Lấy thông tin mới từ các TextBox
                string newMANV = textMANV.Text;
                string newHOTEN = textHOTEN.Text;
                string newPHAI = textPHAI.Text;
                DateTime newNGAYSINH = Convert.ToDateTime(textNGSINH.Text);
                decimal newPHUCAP = Convert.ToDecimal(textPHUCAP.Text);
                string newDT = textDIENTHOAI.Text;
                string newVAITRO = textVAITRO.Text;
                string newMADV = textMADV.Text;

                // Tạo đối tượng NVienDTO để lưu thông tin cũ và mới
                NVienDTO OldUser = new NVienDTO()
                {
                    MANV = oldMANV,
                    HOTEN = oldHOTEN,
                    PHAI = oldPHAI,
                    NGAYSINH = oldNGAYSINH,
                    PHUCAP = oldPHUCAP,
                    DT = oldDT,
                    VAITRO = oldVAITRO,
                    MADV = oldMADV
                };

                NVienDTO User = new NVienDTO()
                {
                    MANV = newMANV,
                    HOTEN = newHOTEN,
                    PHAI = newPHAI,
                    NGAYSINH = newNGAYSINH,
                    PHUCAP = newPHUCAP,
                    DT = newDT,
                    VAITRO = newVAITRO,
                    MADV = newMADV
                };

                // Gọi hàm sửa nhân viên từ UserDAO
                if (UserDAO.Instance.FixNhanVien(OldUser, User))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                    // Cập nhật lại dữ liệu trên DataGridView sau khi sửa
                    button1_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin nhân viên: " + ex.Message);
            }
        }
    }
}
