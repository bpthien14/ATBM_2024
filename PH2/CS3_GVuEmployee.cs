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
    public partial class CS3_GVuEmployee : CS1_BasicEmployee
    {

        public CS3_GVuEmployee()
        {
            InitializeComponent();
        }

        private void Fix_SVien_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Fix_SVien(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                button2_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void Add_SVien_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Add_SVien(dataGridView1))
            {
                MessageBox.Show("Thêm thành công!");
                button2_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void Fix_DVi_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Fix_DVi(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                button3_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void Add_DVi_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Add_DVi(dataGridView1))
            {
                MessageBox.Show("Thêm thành công!");
                button3_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void Fix_HPhan_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Fix_HPhan(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void Add_HPhan_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Add_HPhan(dataGridView1))
            {
                MessageBox.Show("Thêm thành công!");
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }
        private void Add_KHMo_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.Add_KHoc(dataGridView2))
            {
                MessageBox.Show("Thêm thành công!");
                button4_Click(sender, e);
                dataGridView2.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
                dataGridView2.ReadOnly = true;

            }
        }


        private void View_PhanCong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.PHANCONG";
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
        private void Fix_PhanCong_Click(object sender, EventArgs e)
        {
            /*
            if (UserBUS.Instance.Fix_PhanCong(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                View_PhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
            */
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

            if (UserDAO.Instance.Fix_PhanCong(OldUser, User))
            {
                MessageBox.Show("Sửa thành công!");
                View_PhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dataGridView2.SelectedCells[0].OwningRow;
            textMAHP.Text = Row.Cells["MAHP"].Value.ToString();
            textMAGV.Text = Row.Cells["MAGV"].Value.ToString();
            textHK.Text = Row.Cells["HK"].Value.ToString();
            textNAM.Text = Row.Cells["NAM"].Value.ToString();
            textMACT.Text = Row.Cells["MACT"].Value.ToString();

        }

        private void Add_DKi_Click(object sender, EventArgs e)
        {
            string MASV = txtMASV.Text;
            string MAGV = txtMAGV.Text;
            int HK = Convert.ToInt32(txtHK.Text);
            int NAM = Convert.ToInt32(txtNAM.Text);
            string MACT = txtMACT.Text;
            string MAHP = txtMAHP.Text;
            /*
            decimal DIEMTK = Convert.ToDecimal(txtDIEMTK.Text);
            decimal DIEMTH = Convert.ToDecimal(txtDIEMTH.Text);
            decimal DIEMQT = Convert.ToDecimal(txtDIEMQT.Text);
            decimal DIEMCK = Convert.ToDecimal(txtDIEMCK.Text);
            */
            DKiDTO User = new DKiDTO()
            {
                MaSV = MASV,
                MaGV = MAGV,
                MaHP = MAHP,
                MaCT = MACT,
                NAM = NAM,
                HK = HK
            };
            if (UserDAO.Instance.Add_DKi(User))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        private void DeleteDKy_Click(object sender, EventArgs e)
        {
            string MASV = txtMASV.Text;
            string MAGV = txtMAGV.Text;
            int HK = Convert.ToInt32(txtHK.Text);
            int NAM = Convert.ToInt32(txtNAM.Text);
            string MACT = txtMACT.Text;
            string MAHP = txtMAHP.Text;
            /*
            decimal DIEMTK = Convert.ToDecimal(txtDIEMTK.Text);
            decimal DIEMTH = Convert.ToDecimal(txtDIEMTH.Text);
            decimal DIEMQT = Convert.ToDecimal(txtDIEMQT.Text);
            decimal DIEMCK = Convert.ToDecimal(txtDIEMCK.Text);
            */
            DKiDTO User = new DKiDTO()
            {
                MaSV = MASV,
                MaGV = MAGV,
                MaHP = MAHP,
                MaCT = MACT,
                NAM = NAM,
                HK = HK
            };
            if (UserDAO.Instance.DeleteDKy(User) )
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }


        /*
        public override void button4_Click(object sender, EventArgs e)
        {
           string query = "SELECT * FROM SEC_ADM.KHMO";
           dataGridView2.DataSource = DataProvider.Instance.ExecuteQuerry(query);
           dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
           dataGridView2.ReadOnly = false;
        }
*/
    }
}
