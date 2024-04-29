namespace QLDLNB
{
    partial class Admin_ViewRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RoleName = new System.Windows.Forms.TextBox();
            this.btn_DeleteRole = new System.Windows.Forms.Button();
            this.btn_CreateRole = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ViewUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(31, 28);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(206, 40);
            this.btn_Reset.TabIndex = 21;
            this.btn_Reset.Text = "Reset danh sách";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "____________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhập Role để điều chỉnh";
            // 
            // txt_RoleName
            // 
            this.txt_RoleName.Location = new System.Drawing.Point(653, 74);
            this.txt_RoleName.Name = "txt_RoleName";
            this.txt_RoleName.Size = new System.Drawing.Size(223, 35);
            this.txt_RoleName.TabIndex = 13;
            // 
            // btn_DeleteRole
            // 
            this.btn_DeleteRole.Location = new System.Drawing.Point(653, 199);
            this.btn_DeleteRole.Name = "btn_DeleteRole";
            this.btn_DeleteRole.Size = new System.Drawing.Size(223, 40);
            this.btn_DeleteRole.TabIndex = 15;
            this.btn_DeleteRole.Text = "Xóa Role";
            this.btn_DeleteRole.UseVisualStyleBackColor = true;
            this.btn_DeleteRole.Click += new System.EventHandler(this.btn_DeleteRole_Click);
            // 
            // btn_CreateRole
            // 
            this.btn_CreateRole.Location = new System.Drawing.Point(653, 269);
            this.btn_CreateRole.Name = "btn_CreateRole";
            this.btn_CreateRole.Size = new System.Drawing.Size(223, 40);
            this.btn_CreateRole.TabIndex = 17;
            this.btn_CreateRole.Text = "Tạo Role";
            this.btn_CreateRole.UseVisualStyleBackColor = true;
            this.btn_CreateRole.Click += new System.EventHandler(this.btn_CreateRole_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(553, 508);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_ViewUser
            // 
            this.btn_ViewUser.Location = new System.Drawing.Point(653, 133);
            this.btn_ViewUser.Name = "btn_ViewUser";
            this.btn_ViewUser.Size = new System.Drawing.Size(223, 40);
            this.btn_ViewUser.TabIndex = 14;
            this.btn_ViewUser.Text = "Xem Users của Role";
            this.btn_ViewUser.UseVisualStyleBackColor = true;
            this.btn_ViewUser.Click += new System.EventHandler(this.btn_ViewUser_Click);
            // 
            // Admin_ViewRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 611);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RoleName);
            this.Controls.Add(this.btn_DeleteRole);
            this.Controls.Add(this.btn_CreateRole);
            this.Controls.Add(this.btn_ViewUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_ViewRole";
            this.Text = "Admin_ViewRole";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Reset;
        private Label label2;
        private Label label1;
        private TextBox txt_RoleName;
        private Button btn_DeleteRole;
        private Button btn_CreateRole;
        private DataGridView dataGridView1;
        private Button btn_ViewUser;
    }
}