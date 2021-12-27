using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using ExcelDataReader;
using System.IO;
using System.Data.SqlClient;
using QL_THUVIEN.DTO;
using System.Threading;

namespace QL_THUVIEN
{
    public partial class frmImport : MetroFramework.Forms.MetroForm
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_Report.Dausach' table. You can move, or remove it, as needed.
            this.dausachTableAdapter.Fill(this.data_Report.Dausach);
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

        }
        DataTableCollection tableCollection;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_filename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbo_sheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cbo_sheet.Items.Add(table.TableName);//them sheet vao combo
                            }
                        }
                    }
                }
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=.;Initial Catalog = QL_THUVIEN; Integrated Security = True";
                DapperPlusManager.Entity<Dausach_DTO>().Table("Dausach");
                List<Dausach_DTO> dausach = dausachBindingSource.DataSource as List<Dausach_DTO>;
                if (dausach != null)
                {
                    using (IDbConnection db = new SqlConnection(constr))
                    {
                        db.BulkInsert(dausach);
                    }
                }
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo");
                
            }
            catch (Exception ex)
            {
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(8000);
                splashScreenManager1.CloseWaitForm();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbo_sheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Dausach_DTO> dausachs = new List<Dausach_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Dausach_DTO dausach = new Dausach_DTO();
                    dausach.MaDauSach = dt.Rows[i]["MaDauSach"].ToString();
                    dausach.TenSach = dt.Rows[i]["TenSach"].ToString();
                    dausach.TacGia = dt.Rows[i]["TacGia"].ToString();
                    dausach.NhaXB = dt.Rows[i]["NhaXB"].ToString();
                    dausach.NamXB = dt.Rows[i]["NamXB"].ToString();
                    dausach.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"].ToString());
                    dausach.DonGia = Convert.ToDouble(dt.Rows[i]["DonGia"].ToString());
                    dausach.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                    dausach.MaLoai = dt.Rows[i]["MaLoai"].ToString();
                    dausachs.Add(dausach);
                }
                dausachBindingSource.DataSource = dausachs;
            }
        }
    }
}
