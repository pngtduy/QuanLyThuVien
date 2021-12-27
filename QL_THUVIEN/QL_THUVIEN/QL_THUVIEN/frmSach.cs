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
    public partial class frmSach : MetroFramework.Forms.MetroForm
    {
        Sach_BUS SachBUS = new Sach_BUS();
        string flag = "";
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Dausach' table. You can move, or remove it, as needed.
            this.dausachTableAdapter.Fill(this.qL_THUVIENDataSet.Dausach);
            dataGridView1.DataSource = SachBUS.GetList();
            txt_masach.Enabled = false;
            cbo_tinhtrang.Enabled = false;
            cbo_madausach.Enabled = false;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tình trạng sách";
            dataGridView1.Columns[2].HeaderText = "Mã đầu sách";
           
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
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
            cbo_tinhtrang.Enabled = true;
            cbo_madausach.Enabled = true;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            txt_masach.Clear();
            
            cbo_madausach.SelectedIndex = 0;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            cbo_tinhtrang.Enabled = true;
            cbo_madausach.Enabled = true;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (cbo_tinhtrang.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn tình trạng sách", "Thông báo");
                }
                else
                {
                    Sach_DTO s = new Sach_DTO();

                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_masach.Text = "S00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_masach.Text = "S0" + (chuoi2 + 1).ToString();
                    s.MaSach = txt_masach.Text;
                    s.TinhTrangSach = cbo_tinhtrang.Text;
                    s.MaDauSach = cbo_madausach.Text;
                    //kiem tra loi
                    int check = SachBUS.Them(s);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã sách", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmSach_Load(sender, e);
                    ResetGridview();
                }
               
            }
            else if (flag == "edit")
            {
                if (cbo_tinhtrang.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập tình trạng sách", "Thông báo");
                }
                else
                {
                    Sach_DTO s = new Sach_DTO();
                    s.MaSach = txt_masach.Text;
                    s.TinhTrangSach = cbo_tinhtrang.Text;
                    s.MaDauSach = cbo_madausach.Text;
                    //kiem tra loi 
                    if (!SachBUS.Sua(s))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã sách", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmSach_Load(sender, e);
                    ResetGridview();
                }
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_masach.Text = dataGridView1[0, chiso].Value.ToString();
            cbo_tinhtrang.Text = dataGridView1[1, chiso].Value.ToString();
            cbo_madausach.Text = dataGridView1[2, chiso].Value.ToString();
        }
        private void ResetGridview()
        {
            txt_masach.Clear();
            cbo_tinhtrang.SelectedIndex = 0;
            cbo_madausach.SelectedIndex = 0;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_masach.Enabled = false;
            cbo_tinhtrang.Enabled = false;
            cbo_madausach.Enabled = false;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SachBUS.Xoa(txt_masach.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmSach_Load(sender, e);
                ResetGridview();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = SachBUS.GetList();
            }
            else
                dataGridView1.DataSource = SachBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
