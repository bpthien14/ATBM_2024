namespace QLDLNB_PH1.PH2
{
    partial class CS2_GVienEmployee
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
            ViewPhanCong = new Button();
            ViewDangKy = new Button();
            FixGrade = new Button();
            SuspendLayout();
            // 
            // ViewPhanCong
            // 
            ViewPhanCong.Location = new Point(370, 382);
            ViewPhanCong.Name = "ViewPhanCong";
            ViewPhanCong.Size = new Size(129, 67);
            ViewPhanCong.TabIndex = 8;
            ViewPhanCong.Text = "Xem phân công giảng dạy";
            ViewPhanCong.UseVisualStyleBackColor = true;
            ViewPhanCong.Click += ViewPhanCong_Click;
            // 
            // ViewDangKy
            // 
            ViewDangKy.Location = new Point(505, 382);
            ViewDangKy.Name = "ViewDangKy";
            ViewDangKy.Size = new Size(129, 67);
            ViewDangKy.TabIndex = 9;
            ViewDangKy.Text = "Xem lớp học phần";
            ViewDangKy.UseVisualStyleBackColor = true;
            ViewDangKy.Click += ViewDangKy_Click;
            // 
            // FixGrade
            // 
            FixGrade.Location = new Point(640, 382);
            FixGrade.Name = "FixGrade";
            FixGrade.Size = new Size(129, 67);
            FixGrade.TabIndex = 10;
            FixGrade.Text = "Sửa thông tin lớp học phần";
            FixGrade.UseVisualStyleBackColor = true;
            FixGrade.Click += FixGrade_Click;
            // 
            // CS2_GVienEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 457);
            Controls.Add(FixGrade);
            Controls.Add(ViewDangKy);
            Controls.Add(ViewPhanCong);
            Name = "CS2_GVienEmployee";
            Text = "Xem phân công giảng dạy";
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(button5, 0);
            Controls.SetChildIndex(FixPhone, 0);
            Controls.SetChildIndex(PushNotification, 0);
            Controls.SetChildIndex(ViewPhanCong, 0);
            Controls.SetChildIndex(ViewDangKy, 0);
            Controls.SetChildIndex(FixGrade, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button ViewPhanCong;
        private Button ViewDangKy;
        private Button FixGrade;
    }
}