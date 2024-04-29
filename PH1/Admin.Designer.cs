namespace QLDLNB
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_User = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Priv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_GrantPriv = new System.Windows.Forms.ToolStripMenuItem();
            this.quanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_User,
            this.mnu_Priv,
            this.mnu_GrantPriv,
            this.quanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_User
            // 
            this.mnu_User.Name = "mnu_User";
            this.mnu_User.Size = new System.Drawing.Size(243, 34);
            this.mnu_User.Text = "Danh sách người dùng";
            this.mnu_User.Click += new System.EventHandler(this.mnu_User_Click);
            // 
            // mnu_Priv
            // 
            this.mnu_Priv.Name = "mnu_Priv";
            this.mnu_Priv.Size = new System.Drawing.Size(170, 34);
            this.mnu_Priv.Text = "Danh sách role";
            this.mnu_Priv.Click += new System.EventHandler(this.mnu_Priv_Click);
            // 
            // mnu_GrantPriv
            // 
            this.mnu_GrantPriv.Name = "mnu_GrantPriv";
            this.mnu_GrantPriv.Size = new System.Drawing.Size(139, 34);
            this.mnu_GrantPriv.Text = "Xử lý quyền";
            this.mnu_GrantPriv.Click += new System.EventHandler(this.mnu_GrantPriv_Click);
            // 
            // quanToolStripMenuItem
            // 
            this.quanToolStripMenuItem.Name = "quanToolStripMenuItem";
            this.quanToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.quanToolStripMenuItem.Text = "Quản lý dữ liệu nội bộ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 711);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_User;
        private ToolStripMenuItem mnu_Priv;
        private ToolStripMenuItem mnu_GrantPriv;
        private ToolStripMenuItem quanToolStripMenuItem;
    }
}