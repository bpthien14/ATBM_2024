namespace QLDLNB
{
    partial class Admin_Privileges
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Role = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Revoke = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Grant = new System.Windows.Forms.Button();
            this.txt_Col = new System.Windows.Forms.TextBox();
            this.txt_Tab = new System.Windows.Forms.TextBox();
            this.Permission = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.txt_Role);
            this.panel1.Location = new System.Drawing.Point(538, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 109);
            this.panel1.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thu hồi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 56);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(191, 40);
            this.btn_OK.TabIndex = 16;
            this.btn_OK.Text = "Cấp Role";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(236, 9);
            this.txt_User.Name = "txt_User";
            this.txt_User.PlaceholderText = "User";
            this.txt_User.Size = new System.Drawing.Size(191, 35);
            this.txt_User.TabIndex = 15;
            // 
            // txt_Role
            // 
            this.txt_Role.Location = new System.Drawing.Point(12, 9);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.PlaceholderText = "Role";
            this.txt_Role.Size = new System.Drawing.Size(191, 35);
            this.txt_Role.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xử lý role cho user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Revoke
            // 
            this.btn_Revoke.Location = new System.Drawing.Point(754, 268);
            this.btn_Revoke.Name = "btn_Revoke";
            this.btn_Revoke.Size = new System.Drawing.Size(210, 40);
            this.btn_Revoke.TabIndex = 11;
            this.btn_Revoke.Text = "Thu hồi quyền";
            this.btn_Revoke.UseVisualStyleBackColor = true;
            this.btn_Revoke.Click += new System.EventHandler(this.btn_Revoke_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(754, 73);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "User/Role";
            this.txt_Name.Size = new System.Drawing.Size(210, 35);
            this.txt_Name.TabIndex = 6;
            // 
            // btn_Grant
            // 
            this.btn_Grant.Location = new System.Drawing.Point(549, 268);
            this.btn_Grant.Name = "btn_Grant";
            this.btn_Grant.Size = new System.Drawing.Size(191, 40);
            this.btn_Grant.TabIndex = 10;
            this.btn_Grant.Text = "Cấp quyền";
            this.btn_Grant.UseVisualStyleBackColor = true;
            this.btn_Grant.Click += new System.EventHandler(this.btn_Grant_Click);
            // 
            // txt_Col
            // 
            this.txt_Col.Location = new System.Drawing.Point(754, 170);
            this.txt_Col.Name = "txt_Col";
            this.txt_Col.PlaceholderText = "Column";
            this.txt_Col.Size = new System.Drawing.Size(210, 35);
            this.txt_Col.TabIndex = 8;
            // 
            // txt_Tab
            // 
            this.txt_Tab.Location = new System.Drawing.Point(754, 119);
            this.txt_Tab.Name = "txt_Tab";
            this.txt_Tab.PlaceholderText = "Table";
            this.txt_Tab.Size = new System.Drawing.Size(210, 35);
            this.txt_Tab.TabIndex = 7;
            // 
            // Permission
            // 
            this.Permission.CheckOnClick = true;
            this.Permission.FormattingEnabled = true;
            this.Permission.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.Permission.Location = new System.Drawing.Point(549, 73);
            this.Permission.Name = "Permission";
            this.Permission.Size = new System.Drawing.Size(171, 132);
            this.Permission.TabIndex = 1;
            this.Permission.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Permission_ItemCheck);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(549, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(248, 34);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "WITH GRANT OPTION";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 457);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(495, 197);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(495, 323);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "Chọn quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quyền của User/Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "User/Role được cấp role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "_____________________________________________";
            // 
            // Admin_Privileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 674);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Revoke);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Grant);
            this.Controls.Add(this.txt_Col);
            this.Controls.Add(this.txt_Tab);
            this.Controls.Add(this.Permission);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Privileges";
            this.Text = "Admin_Privileges";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btn_OK;
        private TextBox txt_User;
        private TextBox txt_Role;
        private Button button2;
        private Button button1;
        private Button btn_Revoke;
        private TextBox txt_Name;
        private Button btn_Grant;
        private TextBox txt_Col;
        private TextBox txt_Tab;
        private CheckedListBox Permission;
        private CheckBox checkBox1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
    }
}