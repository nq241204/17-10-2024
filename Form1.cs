using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQLDSSV
{
    public partial class Form1 : Form
    {
        public class SinhVien
        {
            public string MaSinhVien { get; set; }
            public string HoTen { get; set; }
            public string LopHoc { get; set; }
        }

        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }
        private void HienThiDanhSach()
        {
            dataGridviewSV.DataSource = null;
            dataGridviewSV.DataSource = danhSachSinhVien;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridviewSV.CurrentRow.Index;
            danhSachSinhVien[index].MaSinhVien = mssv.Text;
            danhSachSinhVien[index].HoTen = tensv.Text;
            danhSachSinhVien[index].LopHoc = LopSV.Text;
            HienThiDanhSach();
            xoa();
        }
        private void xoa()
        {
            mssv.Clear();
            tensv.Clear();
            LopSV.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridviewSV.CurrentRow != null)
            {
                mssv.Text = dataGridviewSV.CurrentRow.Cells[0].Value.ToString();
                tensv.Text = dataGridviewSV.CurrentRow.Cells[1].Value.ToString();
                LopSV.Text = dataGridviewSV.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = mssv.Text,
                HoTen = tensv.Text,
                LopHoc = LopSV.Text
            };
            danhSachSinhVien.Add(sv);
            HienThiDanhSach();
            xoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridviewSV.CurrentRow.Index;
            danhSachSinhVien.RemoveAt(index);
            HienThiDanhSach();
            xoa();
        }
    }
}
