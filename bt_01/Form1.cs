namespace bt_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia <= 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá là số lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus(); 
                return; 
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách là số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!double.TryParse(txtGiamGia.Text, out double giamGia) || giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Giảm giá phải là số từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }

            double tongTien = (donGia * soLuong) * ((100 - giamGia) / 100);

            lblTongTien.Text = $"TỔNG TIỀN THANH TOÁN: {tongTien:N0} VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();

            lblTongTien.Text = "TỔNG TIỀN THANH TOÁN: 0 VNĐ";

            txtDonGia.Focus();
        }
    }
}
