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
    public partial class frmDocgia : MetroFramework.Forms.MetroForm
    {
        Docgia_BUS docGiaBUS = new Docgia_BUS();
        string flag = "";
        public frmDocgia()
        {
            InitializeComponent();
           
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = docGiaBUS.GetList();
            txt_madocgia.Enabled = false;
            txt_hoten.Enabled = false;
            txt_diachi.Enabled = false;
            rdb_nam.Enabled = false;
            rdb_Nu.Enabled = false;
            dateTimePicker1.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Mã độc giả";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "add";
            txt_hoten.Enabled = true;
            txt_diachi.Enabled = true;
            rdb_nam.Enabled = true;
            rdb_Nu.Enabled = true;
            dateTimePicker1.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            rdb_nam.Checked = false;
            rdb_Nu.Checked = false;
            txt_hoten.ResetText();
            txt_madocgia.ResetText();
            txt_diachi.ResetText();
         
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txt_hoten.Enabled = true;
            txt_diachi.Enabled = true;
            rdb_nam.Enabled = true;
            rdb_Nu.Enabled = true;
            dateTimePicker1.Enabled = true;
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
                if (txt_hoten.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Thông báo");
                }else if (txt_diachi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo");
                }
                else if(rdb_nam.Checked==false && rdb_Nu.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn giới tính", "Thông báo");
                }
                else
                {
                    Docgia_DTO dg = new Docgia_DTO();
                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_madocgia.Text = "DG00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_madocgia.Text = "DG0" + (chuoi2 + 1).ToString();
                    dg.MaDocGia = txt_madocgia.Text;
                    dg.HoTen = txt_hoten.Text;
                    dg.NgaySinh = dateTimePicker1.Value.Date;
                    if (rdb_nam.Checked == true)
                        dg.GioiTinh = "Nam";
                    else if (rdb_Nu.Checked == true)
                        dg.GioiTinh = "Nữ";
                    dg.DiaChi = txt_diachi.Text;
                    //kiem tra loi madocgia
                    int check = docGiaBUS.Them(dg);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã độc giả", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmDocgia_Load(sender, e);
                    ResetGridview();
                }
               
            }
            else if (flag == "edit")
            {
                if (txt_hoten.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Thông báo");
                }
                else if (txt_diachi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo");
                }
                else
                {
                    Docgia_DTO dg = new Docgia_DTO();
                    dg.MaDocGia = txt_madocgia.Text;
                    dg.HoTen = txt_hoten.Text;
                    dg.NgaySinh = dateTimePicker1.Value.Date;

                    if (rdb_nam.Checked == true)
                        dg.GioiTinh = "Nam";
                    else if (rdb_Nu.Checked == true)
                        dg.GioiTinh = "Nữ";

                    dg.DiaChi = txt_diachi.Text;

                    //kiem tra loi madocgia
                    if (!docGiaBUS.Sua(dg))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã độc giả", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmDocgia_Load(sender, e);
                    ResetGridview();
                }
               

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_madocgia.Text = dataGridView1[0, chiso].Value.ToString();
            txt_hoten.Text = dataGridView1[1, chiso].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1[2, chiso].Value;
            string a = dataGridView1[3, chiso].Value.ToString();
            if (a == "Nam")
            {
                rdb_nam.Checked = true;
            }
            else if (a == "Nữ")
                rdb_Nu.Checked = true;
            txt_diachi.Text = dataGridView1[4, chiso].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_madocgia.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    docGiaBUS.Xoa(txt_madocgia.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmDocgia_Load(sender, e);
                ResetGridview();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = docGiaBUS.GetList();
            }
            else
                dataGridView1.DataSource = docGiaBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }
        private void ResetGridview()
        {
            txt_madocgia.ResetText();
            txt_hoten.ResetText();
            txt_diachi.ResetText();
            rdb_Nu.Checked = false;
            rdb_nam.Checked = false;
            txt_hoten.Enabled = false;
            txt_diachi.Enabled = false;
            dateTimePicker1.Enabled = false;
            rdb_nam.Enabled = false;
            rdb_Nu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDocgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
