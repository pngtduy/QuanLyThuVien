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
    public partial class frmDangmuon : MetroFramework.Forms.MetroForm
    {
        Dangmuon_BUS dmBus = new Dangmuon_BUS();
        public frmDangmuon()
        {
            InitializeComponent();
        }

        private void frmDangmuon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dmBus.GetList();
            dataGridView1.Columns[0].HeaderText = "Họ tên";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Ngày mượn";
           


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

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
               dataGridView1.DataSource = dmBus.GetList();

            }
            else
            {
                if (rdb_hoten.Checked == true)
                    dataGridView1.DataSource = dmBus.TimKiem(txt_timkiem.Text, "HoTen");
                else if (rdb_tensach.Checked == true)
                    dataGridView1.DataSource = dmBus.TimKiem(txt_timkiem.Text, "TenSach");
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
