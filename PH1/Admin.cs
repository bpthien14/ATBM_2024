namespace QLDLNB
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void mnu_User_Click(object sender, EventArgs e)
        {
            Admin_ViewUser frm_ViewUser = new Admin_ViewUser();
            frm_ViewUser.MdiParent = this;
            frm_ViewUser.Show();
        }

        private void mnu_Priv_Click(object sender, EventArgs e)
        {
            Admin_ViewRole frm_ViewRole = new Admin_ViewRole();
            frm_ViewRole.MdiParent = this;
            frm_ViewRole.Show();
        }

        private void mnu_GrantPriv_Click(object sender, EventArgs e)
        {
            Admin_Privileges frm_Privileges = new Admin_Privileges();
            frm_Privileges.MdiParent = this;
            frm_Privileges.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}