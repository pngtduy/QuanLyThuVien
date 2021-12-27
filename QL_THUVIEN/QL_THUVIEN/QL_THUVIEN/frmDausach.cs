using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_THUVIEN.BUS;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN
{
    public partial class frmDausach : MetroFramework.Forms.MetroForm
    {
        Dausach_BUS dauSachBUS = new Dausach_BUS();
        string flag = "";
        public frmDausach()
        {
            InitializeComponent();
        }

        private void frmDausach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Loaisach' table. You can move, or remove it, as needed.
            this.loaisachTableAdapter.Fill(this.qL_THUVIENDataSet.Loaisach);
            dataGridView1.DataSource = dauSachBUS.GetList();
            txt_madausach.Enabled = false;
            txt_tensach.Enabled = false;
            txt_tacgia.Enabled = false;
            txt_nhaxb.Enabled = false;
            txt_namxb.Enabled = false;
            txt_soluong.Enabled = false;
            txt_dongia.Enabled = false;
            cbo_maloai.Enabled = false;
            dateTimePicker1.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Mã đầu sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Tác giả";
            dataGridView1.Columns[3].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns[4].HeaderText = "Năm xuất bản";
            dataGridView1.Columns[5].HeaderText = "Số lượng";
            dataGridView1.Columns[6].HeaderText = "Đơn giá";
            dataGridView1.Columns[7].HeaderText = "Ngày nhập";
            dataGridView1.Columns[8].HeaderText = "Mã loại";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 150;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_madausach.Text = dataGridView1[0, chiso].Value.ToString();
            txt_tensach.Text = dataGridView1[1, chiso].Value.ToString();
            txt_tacgia.Text = dataGridView1[2, chiso].Value.ToString();
            txt_nhaxb.Text = dataGridView1[3, chiso].Value.ToString();
            txt_namxb.Text = dataGridView1[4, chiso].Value.ToString();
            txt_soluong.Text = dataGridView1[5, chiso].Value.ToString();
            txt_dongia.Text = dataGridView1[6, chiso].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1[7, chiso].Value;
            cbo_maloai.Text = dataGridView1[8, chiso].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "add";
            txt_tensach.Enabled = true;
            txt_tacgia.Enabled = true;
            txt_nhaxb.Enabled = true;
            txt_namxb.Enabled = true;
            txt_soluong.Enabled = true;
            txt_dongia.Enabled = true;
            cbo_maloai.Enabled = true;
            dateTimePicker1.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_madausach.Clear();
            txt_tacgia.Clear();
            txt_tensach.Clear();
            txt_soluong.Clear();
            txt_nhaxb.Clear();
            txt_namxb.Clear();
            txt_dongia.Clear();
            cbo_maloai.SelectedIndex = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txt_tensach.Enabled = true;
            txt_tacgia.Enabled = true;
            txt_nhaxb.Enabled = true;
            txt_namxb.Enabled = true;
            txt_soluong.Enabled = true;
            txt_dongia.Enabled = true;
            cbo_maloai.Enabled = true;
            dateTimePicker1.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (txt_tensach.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên sách", "Thông báo");
                }
                else if (txt_tacgia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tác giả", "Thông báo");
                }
                else if (txt_nhaxb.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo");
                }
                else if (txt_namxb.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập năm xuất bản", "Thông báo");
                }
                else if (txt_soluong.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Thông báo");
                }
                else if (txt_dongia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo");
                }
                else if(IsNumber(txt_namxb.Text) != true)
                {
                    MessageBox.Show("Năm xuất bản không được nhập số", "Thông báo");
                }
                else if (IsNumber(txt_dongia.Text) != true)
                {
                    MessageBox.Show("Đơn giá không được nhập số", "Thông báo");
                }
                else if (IsNumber(txt_soluong.Text) != true)
                {
                    MessageBox.Show("Số lượng không được nhập số", "Thông báo");
                }
                else if (dateTimePicker1.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày nhập sách không đúng", "Thông báo");
                }
                else
                {
                    Dausach_DTO ds = new Dausach_DTO();

                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_madausach.Text = "DS00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_madausach.Text = "DS0" + (chuoi2 + 1).ToString();
                    ds.MaDauSach = txt_madausach.Text;
                    ds.TenSach = txt_tensach.Text;
                    ds.TacGia = txt_tacgia.Text;
                    ds.NgayNhap = dateTimePicker1.Value.Date;
                    ds.NhaXB = txt_nhaxb.Text;
                    ds.NamXB = txt_namxb.Text;
                    ds.SoLuong = Convert.ToInt32(txt_soluong.Text);
                    ds.DonGia = Convert.ToDouble(txt_dongia.Text);
                    ds.MaLoai = cbo_maloai.Text;
                    //kiem tra loi
                    int check = dauSachBUS.Them(ds);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã đầu sách", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmDausach_Load(sender, e);
                    ResetGridview();
                }
               
            }
            else if (flag == "edit")
            {
                if (txt_tensach.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên sách", "Thông báo");
                }
                else if (txt_tacgia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tác giả", "Thông báo");
                }
                else if (txt_nhaxb.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo");
                }
                else if (txt_namxb.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập năm xuất bản", "Thông báo");
                }
                else if (txt_soluong.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Thông báo");
                }
                else if (txt_dongia.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá", "Thông báo");
                }
                else if (IsNumber(txt_namxb.Text) != true)
                {
                    MessageBox.Show("Năm xuất bản không được nhập số", "Thông báo");
                }
                else if (IsNumber(txt_dongia.Text) != true)
                {
                    MessageBox.Show("Đơn giá không được nhập số", "Thông báo");
                }
                else if (IsNumber(txt_soluong.Text) != true)
                {
                    MessageBox.Show("Số lượng không được nhập số", "Thông báo");
                }
                else if (dateTimePicker1.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày nhập sách không đúng", "Thông báo");
                }
                else
                {
                    Dausach_DTO ds = new Dausach_DTO();
                    ds.MaDauSach = txt_madausach.Text;
                    ds.TenSach = txt_tensach.Text;
                    ds.TacGia = txt_tacgia.Text;
                    ds.NgayNhap = dateTimePicker1.Value.Date;
                    ds.NhaXB = txt_nhaxb.Text;
                    ds.NamXB = txt_namxb.Text;
                    ds.SoLuong = Convert.ToInt32(txt_soluong.Text);
                    ds.DonGia = Convert.ToDouble(txt_dongia.Text);
                    ds.MaLoai = cbo_maloai.Text;

                    //kiem tra loi 
                    if (!dauSachBUS.Sua(ds))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã đầu sách", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmDausach_Load(sender, e);
                    ResetGridview();
                }
               
            }
           
        }
        //kiểm tra bắt lỗi nếu người dùng nhập kí tự
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_madausach.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dauSachBUS.Xoa(txt_madausach.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmDausach_Load(sender, e);
                ResetGridview();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
        private void ResetGridview()
        {
            txt_madausach.Clear();
            txt_tacgia.Clear();
            txt_tensach.Clear();
            txt_soluong.Clear();
            txt_nhaxb.Clear();
            txt_namxb.Clear();
            txt_dongia.Clear();
            cbo_maloai.SelectedIndex = 0;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_madausach.Enabled = false;
            txt_tensach.Enabled = false;
            txt_tacgia.Enabled = false;
            txt_nhaxb.Enabled = false;
            txt_namxb.Enabled = false;
            txt_soluong.Enabled = false;
            txt_dongia.Enabled = false;
            cbo_maloai.Enabled = false;
            dateTimePicker1.Enabled = false;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = dauSachBUS.GetList();
            }
            else
                dataGridView1.DataSource = dauSachBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void frmDausach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
