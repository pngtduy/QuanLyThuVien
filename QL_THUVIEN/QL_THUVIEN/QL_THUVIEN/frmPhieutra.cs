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
    public partial class frmPhieutra : MetroFramework.Forms.MetroForm
    {
        Phieutra_BUS phieuTraBUS = new Phieutra_BUS();
        string flag = "";
        public frmPhieutra()
        {
            InitializeComponent();
        }

        private void frmPhieutra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Sach' table. You can move, or remove it, as needed.
            this.sachTableAdapter.Fill(this.qL_THUVIENDataSet.Sach);
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Thedocgia' table. You can move, or remove it, as needed.
            this.thedocgiaTableAdapter.Fill(this.qL_THUVIENDataSet.Thedocgia);
            dataGridView1.DataSource = phieuTraBUS.GetList();
            txt_maphieutra.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbo_masach.Enabled = false;
            cbo_mathe.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Mã phiếu trả";
            dataGridView1.Columns[1].HeaderText = "Mã thẻ độc giả";
            dataGridView1.Columns[2].HeaderText = "Mã sách";
            dataGridView1.Columns[3].HeaderText = "Ngày trả";
           
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
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
            txt_maphieutra.Text = dataGridView1[0, chiso].Value.ToString();
            cbo_mathe.Text = dataGridView1[1, chiso].Value.ToString();
            cbo_masach.Text = dataGridView1[2, chiso].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1[3, chiso].Value;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "add";
           
            dateTimePicker1.Enabled = true;
            cbo_masach.Enabled = true;
            cbo_mathe.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_maphieutra.Clear();
            cbo_masach.SelectedIndex = 0;
            cbo_mathe.SelectedIndex = 0;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
          
            dateTimePicker1.Enabled = true;
            cbo_masach.Enabled = true;
            cbo_mathe.Enabled = true;
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
                if (dateTimePicker1.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày trả không hợp lệ!", "Thông báo");
                }
                else
                {
                    Phieutra_DTO pt = new Phieutra_DTO();

                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_maphieutra.Text = "PT00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_maphieutra.Text = "PT0" + (chuoi2 + 1).ToString();
                    pt.MaPhieuTra = txt_maphieutra.Text;
                    pt.MaThe = cbo_mathe.Text;
                    pt.MaSach = cbo_masach.Text;
                    pt.NgayTra = dateTimePicker1.Value.Date;

                    //kiem tra loi
                    int check = phieuTraBUS.Them(pt);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã phiếu trả", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmPhieutra_Load(sender, e);
                    ResetGridview();
                }
              
            }
            else if (flag == "edit")
            {
                if (dateTimePicker1.Value.Date > DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày trả không hợp lệ!", "Thông báo");
                }
                else
                {
                    Phieutra_DTO pt = new Phieutra_DTO();
                    pt.MaPhieuTra = txt_maphieutra.Text;
                    pt.MaThe = cbo_mathe.Text;
                    pt.MaSach = cbo_masach.Text;
                    pt.NgayTra = dateTimePicker1.Value.Date;
                    //kiem tra loi 
                    if (!phieuTraBUS.Sua(pt))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã phiếu", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmPhieutra_Load(sender, e);
                    ResetGridview();
                }
              
            }

        }
        private void ResetGridview()
        {
            txt_maphieutra.Clear();
            cbo_masach.SelectedIndex = 0;
            cbo_mathe.SelectedIndex = 0;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_maphieutra.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbo_masach.Enabled = false;
            cbo_mathe.Enabled = false;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maphieutra.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    phieuTraBUS.Xoa(txt_maphieutra.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmPhieutra_Load(sender, e);
                ResetGridview();
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
                dataGridView1.DataSource = phieuTraBUS.GetList();
            }
            else
                dataGridView1.DataSource = phieuTraBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void frmPhieutra_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
