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
    public partial class frmThedocgia : MetroFramework.Forms.MetroForm
    {
        Thedocgia_BUS theDocgiaBUS = new Thedocgia_BUS();
        string flag = "";
        public frmThedocgia()
        {
            InitializeComponent();
        }

        private void frmThedocgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Docgia' table. You can move, or remove it, as needed.
            this.docgiaTableAdapter.Fill(this.qL_THUVIENDataSet.Docgia);
            dataGridView1.DataSource = theDocgiaBUS.GetList();
            txt_mathe.Enabled = false;
            dateTime_ngaylap.Enabled = false;
            dateTime_ngayhethan.Enabled = false;
            cbo_madocgia.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            dataGridView1.Columns[0].HeaderText = "Mã thẻ";
            dataGridView1.Columns[1].HeaderText = "Ngày lập";
            dataGridView1.Columns[2].HeaderText = "Ngày hết hạn";
            dataGridView1.Columns[3].HeaderText = "Mã độc giả";
           
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            flag = "add";
            dateTime_ngaylap.Enabled = true;
            dateTime_ngayhethan.Enabled = true;
            cbo_madocgia.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            cbo_madocgia.SelectedIndex = 0;
            txt_mathe.Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            dateTime_ngaylap.Enabled = true;
            dateTime_ngayhethan.Enabled = true;
            cbo_madocgia.Enabled = true;
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
               
                if (dateTime_ngayhethan.Value.Date <= dateTime_ngaylap.Value.Date)
                {
                    MessageBox.Show("Ngày hết hạn không hợp lệ", "Thông báo");
                }
                else
                {
                    Thedocgia_DTO tdg = new Thedocgia_DTO();
                    int count = 0;
                    count = dataGridView1.Rows.Count;//dem tat ca cac dong cua datagridview roi gán cho count
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataGridView1.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//loai bo ky tu chu cua ma 
                    if (chuoi2 + 1 < 10)
                        txt_mathe.Text = "T00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txt_mathe.Text = "T0" + (chuoi2 + 1).ToString();
                    tdg.MaThe = txt_mathe.Text;
                    tdg.NgayLap = dateTime_ngaylap.Value.Date;
                    tdg.NgayHetHan = dateTime_ngayhethan.Value.Date;
                    tdg.MaDocGia = cbo_madocgia.Text;
                    //kiem tra loi
                    int check = theDocgiaBUS.Them(tdg);
                    if (check == 0)
                    {
                        MessageBox.Show("Lỗi bỏ trống mã thẻ", "Thông báo");
                    }

                    else if (check == -1)
                    {
                        MessageBox.Show("Lỗi trùng khóa", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo");
                    }

                    frmThedocgia_Load(sender, e);
                    ResetGridview();
                }
              
            }
            else if (flag == "edit")
            {
                if (dateTime_ngayhethan.Value.Date <= dateTime_ngaylap.Value.Date)
                {
                    MessageBox.Show("Ngày hết hạn không hợp lệ", "Thông báo");
                }
                else
                {
                    Thedocgia_DTO tdg = new Thedocgia_DTO();
                    tdg.MaThe = txt_mathe.Text;
                    tdg.NgayLap = dateTime_ngaylap.Value.Date;
                    tdg.NgayHetHan = dateTime_ngayhethan.Value.Date;
                    tdg.MaDocGia = cbo_madocgia.Text;
                    //kiem tra loi 
                    if (!theDocgiaBUS.Sua(tdg))
                    {
                        MessageBox.Show("Lỗi bỏ trống mã thẻ", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                    frmThedocgia_Load(sender, e);
                    ResetGridview();
                }
                
            }
        }
        private void ResetGridview()
        {
            txt_mathe.Clear();
            cbo_madocgia.SelectedIndex = 0;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            txt_mathe.Enabled = false;
            dateTime_ngaylap.Enabled = false;
            dateTime_ngayhethan.Enabled = false;
            cbo_madocgia.Enabled = false;
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataGridView1.CurrentRow.Index;
            txt_mathe.Text = dataGridView1[0, chiso].Value.ToString();
            dateTime_ngaylap.Value =(DateTime) dataGridView1[1, chiso].Value;
            dateTime_ngayhethan.Value =(DateTime)dataGridView1[2, chiso].Value;
            cbo_madocgia.Text = dataGridView1[3, chiso].Value.ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mathe.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    theDocgiaBUS.Xoa(txt_mathe.Text);
                }
                MessageBox.Show("Xóa thành công", "Thông báo");
                frmThedocgia_Load(sender, e);
                ResetGridview();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = theDocgiaBUS.GetList();
            }
            else
                dataGridView1.DataSource = theDocgiaBUS.TimKiem(txt_timkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void frmThedocgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
