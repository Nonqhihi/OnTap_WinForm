namespace bt_04
{
    public partial class FormDatBan : Form
    {
        private int soBanDangChon = 0;
        private const double GIA_MOI_BAN = 150000;
        public FormDatBan()
        {
            InitializeComponent();

        }

        private void FormDatBan_Load(object sender, EventArgs e)
        {
            if (cboKhungGio.Items.Count > 0)
                cboKhungGio.SelectedIndex = 0;

            for (int i = 1; i <= 20; i++)
            {
                Button btnBan = new Button();
                btnBan.Text = "Bàn " + i;
                btnBan.Width = 80;  
                btnBan.Height = 80; 
                btnBan.BackColor = Color.White; 


                btnBan.Tag = 0;


                btnBan.Click += BtnBan_Click;

                flpSoDoBan.Controls.Add(btnBan);
            }
        }
        private void BtnBan_Click(object sender, EventArgs e)
        {

            Button btnDuocClick = sender as Button;


            int trangThai = Convert.ToInt32(btnDuocClick.Tag);

            if (trangThai == 0)
            {
    
                btnDuocClick.BackColor = Color.LightGreen;
                btnDuocClick.Tag = 1; 
                soBanDangChon++;      
            }
            else
            {

                btnDuocClick.BackColor = Color.White;
                btnDuocClick.Tag = 0; 
                soBanDangChon--;      

            TinhTien();
        }

        private void TinhTien()
        {
            double tongTien = soBanDangChon * GIA_MOI_BAN;
            lblTamTinh.Text = $"Tạm tính: {tongTien:N0} VNĐ";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (soBanDangChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn bàn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string danhSachBan = "";
            foreach (Control ctrl in flpSoDoBan.Controls)
            {
                if (ctrl is Button btn && Convert.ToInt32(btn.Tag) == 1)
                {
                    danhSachBan += btn.Text + ", ";
                }
            }

            danhSachBan = danhSachBan.TrimEnd(',', ' ');

            string thongBao = $"Khung giờ: {cboKhungGio.Text}\n" +
                              $"Danh sách bàn: {danhSachBan}\n" +
                              $"Tổng tiền cọc: {soBanDangChon * GIA_MOI_BAN:N0} VNĐ";

            MessageBox.Show(thongBao, "Xác nhận đặt bàn thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}