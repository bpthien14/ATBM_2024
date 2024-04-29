using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using QLDLNB.Connector;
using QLDLNB_PH1.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDLNB_PH1.PH2
{

    public partial class CS1_BasicEmployee : Form
    {

        public static DataGridViewRow OLDdataGridViewRow = null;
        //public static DataGridView OLDdataGridView;
        public CS1_BasicEmployee()
        {
            InitializeComponent();
            //InitializeDataGridView();

        }

        protected void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.NHANSU";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.SINHVIEN";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        protected void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.DONVI";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public virtual void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.KHMO";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        protected void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SEC_ADM.HOCPHAN";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuerry(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        protected void FixPhone_Click(object sender, EventArgs e)
        {
            if (UserBUS.Instance.FixPhone(dataGridView1))
            {
                MessageBox.Show("Sửa thành công!");
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }
        protected void PushNotification_Click(object sender, EventArgs e)
        {
            string querry = " SELECT * FROM SEC_ADM.THONGBAO ";
            string notification = DataProvider.Instance.ExecuteReader(querry);
            MessageBox.Show(notification);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
