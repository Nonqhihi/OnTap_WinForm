namespace bt_03
{
    public partial class FormQuanLyVatTu : Form
    {
        public FormQuanLyVatTu()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDVT.SelectedIndex = -1; 
            txtDonGia.Clear();
            txtMaVT.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã và Tên vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txtMaVT.Text.Trim());

            item.SubItems.Add(txtTenVT.Text.Trim());
            item.SubItems.Add(cboDVT.Text);
            item.SubItems.Add(donGia.ToString("N0")); 

            lsvVatTu.Items.Add(item);

            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vật tư trong bảng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và >= 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            selectedItem.SubItems[0].Text = txtMaVT.Text.Trim();
            selectedItem.SubItems[1].Text = txtTenVT.Text.Trim();
            selectedItem.SubItems[2].Text = cboDVT.Text;
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một vật tư trong bảng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(lsvVatTu.SelectedItems[0]);
                ClearForm();
            }
        }

        private void lsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvVatTu.SelectedItems[0];

                txtMaVT.Text = selectedItem.SubItems[0].Text;
                txtTenVT.Text = selectedItem.SubItems[1].Text;
                cboDVT.Text = selectedItem.SubItems[2].Text;
                txtDonGia.Text = selectedItem.SubItems[3].Text.Replace(",", "").Replace(".", "");
            }
        }
    }
    }
