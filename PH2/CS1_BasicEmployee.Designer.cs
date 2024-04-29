

namespace QLDLNB_PH1.PH2
{
    partial class CS1_BasicEmployee
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            FixPhone = new Button();
            PushNotification = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(370, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(613, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(370, 12);
            button1.Name = "button1";
            button1.Size = new Size(182, 38);
            button1.TabIndex = 1;
            button1.Text = "Xem thông tin Nhân viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 36);
            button2.Name = "button2";
            button2.Size = new Size(103, 67);
            button2.TabIndex = 2;
            button2.Text = "Xem thông tin Sinh viên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(12, 109);
            button3.Name = "button3";
            button3.Size = new Size(103, 67);
            button3.TabIndex = 3;
            button3.Text = "Xem thông tin Đơn vị";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(12, 255);
            button4.Name = "button4";
            button4.Size = new Size(103, 67);
            button4.TabIndex = 4;
            button4.Text = "Xem thông tin Khóa học Mở";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(12, 182);
            button5.Name = "button5";
            button5.Size = new Size(103, 67);
            button5.TabIndex = 5;
            button5.Text = "Xem thông tin học phần";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FixPhone
            // 
            FixPhone.Location = new Point(558, 12);
            FixPhone.Name = "FixPhone";
            FixPhone.Size = new Size(137, 39);
            FixPhone.TabIndex = 6;
            FixPhone.Text = "Sửa số điện thoại";
            FixPhone.UseVisualStyleBackColor = true;
            FixPhone.Click += FixPhone_Click;
            // 
            // PushNotification
            // 
            PushNotification.Location = new Point(847, 12);
            PushNotification.Name = "PushNotification";
            PushNotification.Size = new Size(136, 39);
            PushNotification.TabIndex = 7;
            PushNotification.Text = "Xem thông báo";
            PushNotification.UseVisualStyleBackColor = true;
            PushNotification.Click += PushNotification_Click;
            // 
            // CS1_BasicEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(995, 454);
            Controls.Add(PushNotification);
            Controls.Add(FixPhone);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CS1_BasicEmployee";
            Text = "CS1_BasicEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        protected DataGridView dataGridView1;
        protected Button button1;
        protected Button button2;
        protected Button button3;
        protected Button button4;
        protected Button button5;
        protected Button FixPhone;
        protected Button PushNotification;
    }
}