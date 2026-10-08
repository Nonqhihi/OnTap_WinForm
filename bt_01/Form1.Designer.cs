namespace bt_01
{
    partial class Form1
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
            lblDonGia = new Label();
            lblKhach = new Label();
            lblGiamGia = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(12, 26);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(93, 15);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá dịch vụ:";
            lblDonGia.Click += label1_Click;
            // 
            // lblKhach
            // 
            lblKhach.AutoSize = true;
            lblKhach.Location = new Point(12, 87);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(92, 15);
            lblKhach.TabIndex = 1;
            lblKhach.Text = "Số lượng khách:";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(12, 145);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(78, 15);
            lblGiamGia.TabIndex = 2;
            lblGiamGia.Text = "Giảm giá (%):";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(108, 18);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(100, 23);
            txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(108, 79);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 23);
            txtSoLuong.TabIndex = 2;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(108, 137);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(100, 23);
            txtGiamGia.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(12, 193);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(126, 17);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng Tiền:  0 VND";
            lblTongTien.Click += label4_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(89, 259);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(75, 23);
            btnTinhTien.TabIndex = 4;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(251, 259);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lblGiamGia);
            Controls.Add(lblKhach);
            Controls.Add(lblDonGia);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonGia;
        private Label lblKhach;
        private Label lblGiamGia;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblTongtien;
        private Button btnTinhTien;
        private Button btnLamMoi;
        private Label lblTongTien;
    }
}
