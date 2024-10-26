using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTraCuuDiemSV
{
    public partial class btntracuu : Form
    {
        private Dictionary<string, string> danhSachSinhVien;
        public btntracuu()
        {
            InitializeComponent();
            danhSachSinhVien = new Dictionary<string, string>
            {
                { "22810310416", "Nguyen Dang Khoa - Diem: 8.5" },
                { "22810310412", "Nhu Quynh - Diem: 9.0" },
                { "22810310419", "Phan Ngoc - Diem: 7.5" }
            };
        }

     
        private void txtmasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maSV = txtmaSV.Text.Trim();

            // Kiểm tra mã sinh viên trong danh sách
            if (danhSachSinhVien.ContainsKey(maSV))
            {
                // Hiển thị thông tin sinh viên
                txtThongTin.Text = danhSachSinhVien[maSV];
            }
            else
            {
                // Thông báo khi không tìm thấy mã sinh viên
                MessageBox.Show("Không tìm thấy mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThongTin.Text = ""; // Xóa thông tin cũ nếu có
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntracuu_Load(object sender, EventArgs e)
        {

        }

        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
