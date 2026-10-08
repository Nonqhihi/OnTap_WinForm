namespace bt_04
{
    partial class FormDatBan
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
            label1 = new Label();
            cboKhungGio = new ComboBox();
            lblTamTinh = new Label();
            btnXacNhan = new Button();
            flpSoDoBan = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Khung giờ:";
            // 
            // cboKhungGio
            // 
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Items.AddRange(new object[] { "Sáng", "Trưa", "Tối" });
            cboKhungGio.Location = new Point(133, 31);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(121, 23);
            cboKhungGio.TabIndex = 1;
            // 
            // lblTamTinh
            // 
            lblTamTinh.AutoSize = true;
            lblTamTinh.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTamTinh.ForeColor = Color.Red;
            lblTamTinh.Location = new Point(434, 39);
            lblTamTinh.Name = "lblTamTinh";
            lblTamTinh.Size = new Size(112, 17);
            lblTamTinh.TabIndex = 2;
            lblTamTinh.Text = "Tạm tính: 0 VNĐ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(557, 31);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // flpSoDoBan
            // 
            flpSoDoBan.AutoScroll = true;
            flpSoDoBan.BorderStyle = BorderStyle.Fixed3D;
            flpSoDoBan.Location = new Point(111, 77);
            flpSoDoBan.Name = "flpSoDoBan";
            flpSoDoBan.Size = new Size(582, 244);
            flpSoDoBan.TabIndex = 4;
            // 
            // FormDatBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpSoDoBan);
            Controls.Add(btnXacNhan);
            Controls.Add(lblTamTinh);
            Controls.Add(cboKhungGio);
            Controls.Add(label1);
            Name = "FormDatBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sơ Đồ Đặt Bàn";
            Load += FormDatBan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboKhungGio;
        private Label lblTamTinh;
        private Button btnXacNhan;
        private FlowLayoutPanel flpSoDoBan;
    }
}
