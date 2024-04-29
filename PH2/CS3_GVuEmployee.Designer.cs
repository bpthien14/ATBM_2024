namespace QLDLNB_PH1.PH2
{
    public partial class CS3_GVuEmployee
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
            Fix_SVien = new Button();
            Fix_DVi = new Button();
            Fix_HPhan = new Button();
            Add_SVien = new Button();
            Add_DVi = new Button();
            Add_KHMo = new Button();
            Add_HPhan = new Button();
            View_PhanCong = new Button();
            Fix_PhanCong = new Button();
            panel1 = new Panel();
            labelMACT = new Label();
            textHK = new TextBox();
            textMACT = new TextBox();
            textNAM = new TextBox();
            textMAGV = new TextBox();
            labelNAM = new Label();
            labelHK = new Label();
            labelMAGV = new Label();
            labelMAHP = new Label();
            textMAHP = new TextBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            Add_DKi = new Button();
            DeleteDKy = new Button();
            txtMACT = new TextBox();
            txtNAM = new TextBox();
            txtMASV = new TextBox();
            txtHK = new TextBox();
            txtMAHP = new TextBox();
            txtMAGV = new TextBox();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            lbMAHP = new Label();
            lbMAGV = new Label();
            labelMASV = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(370, 13);
            // 
            // button4
            // 
            button4.Click += button4_Click;
            // 
            // Fix_SVien
            // 
            Fix_SVien.Location = new Point(233, 36);
            Fix_SVien.Name = "Fix_SVien";
            Fix_SVien.Size = new Size(97, 67);
            Fix_SVien.TabIndex = 8;
            Fix_SVien.Text = "Sửa thông tin Sinh viên";
            Fix_SVien.UseVisualStyleBackColor = true;
            Fix_SVien.Click += Fix_SVien_Click;
            // 
            // Fix_DVi
            // 
            Fix_DVi.Location = new Point(233, 109);
            Fix_DVi.Name = "Fix_DVi";
            Fix_DVi.Size = new Size(97, 67);
            Fix_DVi.TabIndex = 9;
            Fix_DVi.Text = "Sửa thông tin đơn vị";
            Fix_DVi.UseVisualStyleBackColor = true;
            Fix_DVi.Click += Fix_DVi_Click;
            // 
            // Fix_HPhan
            // 
            Fix_HPhan.Location = new Point(233, 182);
            Fix_HPhan.Name = "Fix_HPhan";
            Fix_HPhan.Size = new Size(97, 67);
            Fix_HPhan.TabIndex = 11;
            Fix_HPhan.Text = "Sửa thông tin Học phần";
            Fix_HPhan.UseVisualStyleBackColor = true;
            Fix_HPhan.Click += Fix_HPhan_Click;
            // 
            // Add_SVien
            // 
            Add_SVien.Location = new Point(121, 36);
            Add_SVien.Name = "Add_SVien";
            Add_SVien.Size = new Size(97, 67);
            Add_SVien.TabIndex = 12;
            Add_SVien.Text = "Thêm Sinh Viên";
            Add_SVien.UseVisualStyleBackColor = true;
            Add_SVien.Click += Add_SVien_Click;
            // 
            // Add_DVi
            // 
            Add_DVi.Location = new Point(121, 109);
            Add_DVi.Name = "Add_DVi";
            Add_DVi.Size = new Size(97, 67);
            Add_DVi.TabIndex = 13;
            Add_DVi.Text = "Thêm Đơn Vị";
            Add_DVi.UseVisualStyleBackColor = true;
            Add_DVi.Click += Add_DVi_Click;
            // 
            // Add_KHMo
            // 
            Add_KHMo.Location = new Point(121, 255);
            Add_KHMo.Name = "Add_KHMo";
            Add_KHMo.Size = new Size(97, 67);
            Add_KHMo.TabIndex = 14;
            Add_KHMo.Text = "Thêm Khóa học";
            Add_KHMo.UseVisualStyleBackColor = true;
            Add_KHMo.Click += Add_KHMo_Click;
            // 
            // Add_HPhan
            // 
            Add_HPhan.Location = new Point(121, 182);
            Add_HPhan.Name = "Add_HPhan";
            Add_HPhan.Size = new Size(97, 67);
            Add_HPhan.TabIndex = 15;
            Add_HPhan.Text = "Thêm Học phần";
            Add_HPhan.UseVisualStyleBackColor = true;
            Add_HPhan.Click += Add_HPhan_Click;
            // 
            // View_PhanCong
            // 
            View_PhanCong.Location = new Point(12, 343);
            View_PhanCong.Name = "View_PhanCong";
            View_PhanCong.Size = new Size(140, 33);
            View_PhanCong.TabIndex = 16;
            View_PhanCong.Text = "Xem Phân công";
            View_PhanCong.UseVisualStyleBackColor = true;
            View_PhanCong.Click += View_PhanCong_Click;
            // 
            // Fix_PhanCong
            // 
            Fix_PhanCong.Location = new Point(167, 137);
            Fix_PhanCong.Name = "Fix_PhanCong";
            Fix_PhanCong.Size = new Size(130, 36);
            Fix_PhanCong.TabIndex = 17;
            Fix_PhanCong.Text = "Sửa Phân công";
            Fix_PhanCong.UseVisualStyleBackColor = true;
            Fix_PhanCong.Click += Fix_PhanCong_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelMACT);
            panel1.Controls.Add(Fix_PhanCong);
            panel1.Controls.Add(textHK);
            panel1.Controls.Add(textMACT);
            panel1.Controls.Add(textNAM);
            panel1.Controls.Add(textMAGV);
            panel1.Controls.Add(labelNAM);
            panel1.Controls.Add(labelHK);
            panel1.Controls.Add(labelMAGV);
            panel1.Controls.Add(labelMAHP);
            panel1.Controls.Add(textMAHP);
            panel1.Location = new Point(12, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 191);
            panel1.TabIndex = 18;
            // 
            // labelMACT
            // 
            labelMACT.AutoSize = true;
            labelMACT.Location = new Point(14, 97);
            labelMACT.Name = "labelMACT";
            labelMACT.Size = new Size(49, 20);
            labelMACT.TabIndex = 9;
            labelMACT.Text = "MACT";
            // 
            // textHK
            // 
            textHK.Location = new Point(324, 53);
            textHK.Name = "textHK";
            textHK.Size = new Size(125, 27);
            textHK.TabIndex = 8;
            // 
            // textMACT
            // 
            textMACT.Location = new Point(81, 90);
            textMACT.Name = "textMACT";
            textMACT.Size = new Size(125, 27);
            textMACT.TabIndex = 7;
            // 
            // textNAM
            // 
            textNAM.Location = new Point(324, 12);
            textNAM.Name = "textNAM";
            textNAM.Size = new Size(125, 27);
            textNAM.TabIndex = 6;
            // 
            // textMAGV
            // 
            textMAGV.Location = new Point(81, 49);
            textMAGV.Name = "textMAGV";
            textMAGV.Size = new Size(125, 27);
            textMAGV.TabIndex = 5;
            // 
            // labelNAM
            // 
            labelNAM.AutoSize = true;
            labelNAM.Location = new Point(268, 15);
            labelNAM.Name = "labelNAM";
            labelNAM.Size = new Size(43, 20);
            labelNAM.TabIndex = 4;
            labelNAM.Text = "NAM";
            // 
            // labelHK
            // 
            labelHK.AutoSize = true;
            labelHK.Location = new Point(268, 56);
            labelHK.Name = "labelHK";
            labelHK.Size = new Size(29, 20);
            labelHK.TabIndex = 3;
            labelHK.Text = "HK";
            // 
            // labelMAGV
            // 
            labelMAGV.AutoSize = true;
            labelMAGV.Location = new Point(15, 52);
            labelMAGV.Name = "labelMAGV";
            labelMAGV.Size = new Size(51, 20);
            labelMAGV.TabIndex = 2;
            labelMAGV.Text = "MAGV";
            // 
            // labelMAHP
            // 
            labelMAHP.AutoSize = true;
            labelMAHP.Location = new Point(14, 11);
            labelMAHP.Name = "labelMAHP";
            labelMAHP.RightToLeft = RightToLeft.Yes;
            labelMAHP.Size = new Size(51, 20);
            labelMAHP.TabIndex = 1;
            labelMAHP.Text = "MAHP";
            // 
            // textMAHP
            // 
            textMAHP.Location = new Point(81, 8);
            textMAHP.Name = "textMAHP";
            textMAHP.Size = new Size(125, 27);
            textMAHP.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(476, 168);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(501, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 191);
            panel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 370);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 20;
            label1.Text = "Thông tin Phân công";
            // 
            // panel3
            // 
            panel3.Controls.Add(Add_DKi);
            panel3.Controls.Add(DeleteDKy);
            panel3.Controls.Add(txtMACT);
            panel3.Controls.Add(txtNAM);
            panel3.Controls.Add(txtMASV);
            panel3.Controls.Add(txtHK);
            panel3.Controls.Add(txtMAHP);
            panel3.Controls.Add(txtMAGV);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lbMAHP);
            panel3.Controls.Add(lbMAGV);
            panel3.Controls.Add(labelMASV);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 593);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 191);
            panel3.TabIndex = 21;
            // 
            // Add_DKi
            // 
            Add_DKi.Location = new Point(65, 161);
            Add_DKi.Name = "Add_DKi";
            Add_DKi.Size = new Size(134, 27);
            Add_DKi.TabIndex = 22;
            Add_DKi.Text = "Thêm DangKy";
            Add_DKi.UseVisualStyleBackColor = true;
            Add_DKi.Click += Add_DKi_Click;
            // 
            // DeleteDKy
            // 
            DeleteDKy.Location = new Point(233, 159);
            DeleteDKy.Name = "DeleteDKy";
            DeleteDKy.Size = new Size(134, 29);
            DeleteDKy.TabIndex = 23;
            DeleteDKy.Text = "Xoá DangKy";
            DeleteDKy.UseVisualStyleBackColor = true;
            DeleteDKy.Click += DeleteDKy_Click;
            // 
            // txtMACT
            // 
            txtMACT.Location = new Point(233, 121);
            txtMACT.Name = "txtMACT";
            txtMACT.Size = new Size(85, 27);
            txtMACT.TabIndex = 20;
            // 
            // txtNAM
            // 
            txtNAM.Location = new Point(233, 81);
            txtNAM.Name = "txtNAM";
            txtNAM.Size = new Size(85, 27);
            txtNAM.TabIndex = 19;
            // 
            // txtMASV
            // 
            txtMASV.Location = new Point(65, 40);
            txtMASV.Name = "txtMASV";
            txtMASV.Size = new Size(85, 27);
            txtMASV.TabIndex = 16;
            // 
            // txtHK
            // 
            txtHK.Location = new Point(233, 44);
            txtHK.Name = "txtHK";
            txtHK.Size = new Size(85, 27);
            txtHK.TabIndex = 15;
            // 
            // txtMAHP
            // 
            txtMAHP.Location = new Point(65, 114);
            txtMAHP.Name = "txtMAHP";
            txtMAHP.Size = new Size(85, 27);
            txtMAHP.TabIndex = 14;
            // 
            // txtMAGV
            // 
            txtMAGV.Location = new Point(65, 77);
            txtMAGV.Name = "txtMAGV";
            txtMAGV.Size = new Size(85, 27);
            txtMAGV.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(167, 121);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 9;
            label11.Text = "MACT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 84);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 5;
            label7.Text = "NAM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 50);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 4;
            label6.Text = "HK";
            // 
            // lbMAHP
            // 
            lbMAHP.AutoSize = true;
            lbMAHP.Location = new Point(9, 117);
            lbMAHP.Name = "lbMAHP";
            lbMAHP.Size = new Size(51, 20);
            lbMAHP.TabIndex = 3;
            lbMAHP.Text = "MAHP";
            // 
            // lbMAGV
            // 
            lbMAGV.AutoSize = true;
            lbMAGV.Location = new Point(9, 80);
            lbMAGV.Name = "lbMAGV";
            lbMAGV.Size = new Size(51, 20);
            lbMAGV.TabIndex = 2;
            lbMAGV.Text = "MAGV";
            // 
            // labelMASV
            // 
            labelMASV.AutoSize = true;
            labelMASV.Location = new Point(9, 43);
            labelMASV.Name = "labelMASV";
            labelMASV.Size = new Size(49, 20);
            labelMASV.TabIndex = 1;
            labelMASV.Text = "MASV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 0;
            label2.Text = "Thêm hoặc Xóa trên DangKy";
            // 
            // CS3_GVuEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 816);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(View_PhanCong);
            Controls.Add(Add_KHMo);
            Controls.Add(Add_HPhan);
            Controls.Add(Add_DVi);
            Controls.Add(Add_SVien);
            Controls.Add(Fix_HPhan);
            Controls.Add(Fix_DVi);
            Controls.Add(Fix_SVien);
            Name = "CS3_GVuEmployee";
            Text = "CS3_GVuEmployee";
            Controls.SetChildIndex(Fix_SVien, 0);
            Controls.SetChildIndex(Fix_DVi, 0);
            Controls.SetChildIndex(Fix_HPhan, 0);
            Controls.SetChildIndex(Add_SVien, 0);
            Controls.SetChildIndex(Add_DVi, 0);
            Controls.SetChildIndex(Add_HPhan, 0);
            Controls.SetChildIndex(Add_KHMo, 0);
            Controls.SetChildIndex(View_PhanCong, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(button5, 0);
            Controls.SetChildIndex(FixPhone, 0);
            Controls.SetChildIndex(PushNotification, 0);
            Controls.SetChildIndex(panel3, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Fix_SVien;
        private Button Fix_DVi;
        private Button Fix_HPhan;
        private Button Add_SVien;
        private Button Add_DVi;
        private Button Add_KHMo;
        private Button Add_HPhan;
        private Button View_PhanCong;
        private Button Fix_PhanCong;
        private Panel panel1;
        private Label labelMAHP;
        public TextBox textMAHP;
        public TextBox textMACT;
        public TextBox textNAM;
        public TextBox textMAGV;
        private Label labelNAM;
        private Label labelHK;
        private Label labelMAGV;
        private Label labelMACT;
        public TextBox textHK;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        
        private TextBox txtHK;
        private TextBox txtMAHP;
        private TextBox txtMAGV;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label lbMAHP;
        private Label lbMAGV;
        private Label label2;
        private TextBox txtMACT;
        private TextBox txtNAM;
        private Button DeleteDKy;
        private Button Add_DKi;
        private Label labelMASV;
        private TextBox txtMASV;
    }
}