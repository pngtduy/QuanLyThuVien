using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_THUVIEN.BUS;
using QL_THUVIEN.DTO;

namespace QL_THUVIEN
{
    public partial class frmLoaisach : MetroFramework.Forms.MetroForm
    {
        Loaisach_BUS loaiSachBUS = new Loaisach_BUS();
        string flag = "";
        public frmLoaisach()
        {
            InitializeComponent();
        }

        private void frmLoaisach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loaiSachBUS.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã loại sách";
            dataGridView1.Columns[1].HeaderText = "Tên loại sách";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_maloai.Enabled = false;
            txt_tenloai.Enabled = false;
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
            txt_maloai.Text = dataGridView1[0, chiso].Value.ToString();
            txt_tenloai.Text = dataGridView1[1, chiso].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "add";
            txt_tenloai.Enabled = true;
            txt_tenloai.Clear();
            txt_maloai.Clear();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txt_tenloai.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (txt_tenloai.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên loại sách", "Thông báo");
                }
                else
                {
                    Loaisach_DTO ls = new Loaisach_DTO();

                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_maloai.Text = "L00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_maloai.Text = "L0" + (chuoi2 + 1).ToString();
                    ls.MaLoai = txt_maloai.Text;
                    ls.TenLoai = txt_tenloai.Text;

                    //kiem tra loi
                    int check = loaiSachBUS.Them(ls);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã loại sách", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmLoaisach_Load(sender, e);
                    ResetGridview();
                }
               
            }
            else if (flag == "edit")
            {
                if (txt_tenloai.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên loại", "Thông báo");
                }
                else
                {
                    Loaisach_DTO ls = new Loaisach_DTO();
                    ls.MaLoai = txt_maloai.Text;
                    ls.TenLoai = txt_tenloai.Text;
                    //kiem tra loi 
                    if (!loaiSachBUS.Sua(ls))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã loại sách", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmLoaisach_Load(sender, e);
                    ResetGridview();
                }
               
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maloai.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    loaiSachBUS.Xoa(txt_maloai.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmLoaisach_Load(sender, e);
                ResetGridview();
            }
        }
        private void ResetGridview()
        {
            txt_maloai.Clear();
            txt_tenloai.Clear();
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_maloai.Enabled = false;
            txt_tenloai.Enabled = false;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = loaiSachBUS.GetList();
            }
            else
                dataGridView1.DataSource = loaiSachBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void frmLoaisach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
