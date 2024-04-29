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
    public partial class CS4_TRUONGDONVI : CS2_GVienEmployee
    {
        public CS4_TRUONGDONVI()
        {
            InitializeComponent();
        }

        public virtual void Fix_PhanCong_Click(object sender, EventArgs e)
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

            if (UserDAO.Instance.FixPhanCongTRUONGDONVI(OldUser, User))
            {
                MessageBox.Show("Sửa thành công!");
                ViewPhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        public override void ViewPhanCong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.UV_TRUONGDONVI_PHANCONG";
            dataGridView2.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dataGridView2.SelectedCells[0].OwningRow;
            textMAHP.Text = Row.Cells["MAHP"].Value.ToString();
            textMAGV.Text = Row.Cells["MAGV"].Value.ToString();
            textHK.Text = Row.Cells["HK"].Value.ToString();
            textNAM.Text = Row.Cells["NAM"].Value.ToString();
            textMACT.Text = Row.Cells["MACT"].Value.ToString();

        }

        public virtual void addPHANCONG_Click(object sender, EventArgs e)
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
            if (UserDAO.Instance.addPHANCONG(User))
            {
                MessageBox.Show("Thêm thành công!");
                ViewPhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công!");
            }
        }

        public virtual void deletePHANCONG_Click(object sender, EventArgs e)
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
            if (UserDAO.Instance.deletePHANCONG(User))
            {
                MessageBox.Show("Xóa thành công!");
                ViewPhanCong_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }
    }
}
