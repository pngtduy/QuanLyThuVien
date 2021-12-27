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

namespace QL_THUVIEN
{
    public partial class frmTimkiemsach : MetroFramework.Forms.MetroForm
    {
        Timkiemsach_BUS sachBUS = new Timkiemsach_BUS();
        public frmTimkiemsach()
        {
            InitializeComponent();
        }

        private void frmTimkiemsach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sachBUS.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Tên loại";
            dataGridView1.Columns[3].HeaderText = "Tác giả";
            dataGridView1.Columns[4].HeaderText = "Tình trạng";
            dataGridView1.Columns[5].HeaderText = "Nhà xuất bản";
           

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
           
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                dataGridView1.DataSource = sachBUS.GetList();

            }
            else
            {
                if (rdb_masach.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "MaSach");
                else if (rdb_nhaxb.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "NhaXB");
                else if (rdb_tacgia.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "TacGia");
                else if (rdb_tensach.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "TenSach");
                else if (rdb_theloai.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "TenLoai");
                else if (rdb_tinhtrang.Checked == true)
                    dataGridView1.DataSource = sachBUS.TimKiem(txt_timkiem.Text, "TinhTrangSach");
            }
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }
    }
}
