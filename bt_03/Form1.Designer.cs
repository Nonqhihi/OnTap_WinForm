namespace bt_03
{
    partial class FormQuanLyVatTu
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
            gbThongTin = new GroupBox();
            gbDanhSach = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaVT = new TextBox();
            txtTenVT = new TextBox();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lsvVatTu = new ListView();
            cboDVT = new ComboBox();
            Mã = new ColumnHeader();
            Tên = new ColumnHeader();
            ĐVT = new ColumnHeader();
            Giá = new ColumnHeader();
            gbThongTin.SuspendLayout();
            gbDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(cboDVT);
            gbThongTin.Controls.Add(btnXoa);
            gbThongTin.Controls.Add(btnSua);
            gbThongTin.Controls.Add(btnThem);
            gbThongTin.Controls.Add(txtDonGia);
            gbThongTin.Controls.Add(txtTenVT);
            gbThongTin.Controls.Add(txtMaVT);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label3);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Location = new Point(0, 0);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(386, 333);
            gbThongTin.TabIndex = 0;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin vật tư";
            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(lsvVatTu);
            gbDanhSach.Location = new Point(403, 12);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Size = new Size(375, 333);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh sách vật tư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã VT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên VT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 158);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 216);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá";
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(140, 44);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(100, 23);
            txtMaVT.TabIndex = 4;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(140, 107);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(100, 23);
            txtTenVT.TabIndex = 5;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(140, 216);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(100, 23);
            txtDonGia.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 275);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(155, 275);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(284, 275);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lsvVatTu
            // 
            lsvVatTu.Columns.AddRange(new ColumnHeader[] { Mã, Tên, ĐVT, Giá });
            lsvVatTu.Dock = DockStyle.Fill;
            lsvVatTu.FullRowSelect = true;
            lsvVatTu.GridLines = true;
            lsvVatTu.Location = new Point(3, 19);
            lsvVatTu.Name = "lsvVatTu";
            lsvVatTu.Size = new Size(369, 311);
            lsvVatTu.TabIndex = 0;
            lsvVatTu.UseCompatibleStateImageBehavior = false;
            lsvVatTu.View = View.Details;
            lsvVatTu.SelectedIndexChanged += lsvVatTu_SelectedIndexChanged;
            // 
            // cboDVT
            // 
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "Cái", "Hộp", "Cuộn", "Kg" });
            cboDVT.Location = new Point(140, 158);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(121, 23);
            cboDVT.TabIndex = 11;
            // 
            // FormQuanLyVatTu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbDanhSach);
            Controls.Add(gbThongTin);
            Name = "FormQuanLyVatTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Vật Tư";
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbThongTin;
        private GroupBox gbDanhSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtDonGia;
        private TextBox textBox3;
        private TextBox txtTenVT;
        private TextBox txtMaVT;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListView lsvVatTu;
        private ComboBox cboDVT;
        private ColumnHeader Mã;
        private ColumnHeader Tên;
        private ColumnHeader ĐVT;
        private ColumnHeader Giá;
    }
}
