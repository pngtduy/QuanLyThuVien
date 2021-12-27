using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using QL_THUVIEN.BUS;

namespace QL_THUVIEN
{
    public partial class frmSachdangmuon : MetroFramework.Forms.MetroForm
    {
        Sachdangmuon_BUS sdmBus = new Sachdangmuon_BUS();
        public frmSachdangmuon()
        {
            InitializeComponent();
        }

        private void frmSachdangmuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.Dausach' table. You can move, or remove it, as needed.
            this.dausachTableAdapter.Fill(this.qL_THUVIENDataSet.Dausach);
            dataGridView1.DataSource = sdmBus.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã phiếu mượn";
            dataGridView1.Columns[1].HeaderText = "Mã thẻ";
            dataGridView1.Columns[2].HeaderText = "Mã độc giả";
            dataGridView1.Columns[3].HeaderText = "Họ tên";
            dataGridView1.Columns[4].HeaderText = "Mã sách";
            dataGridView1.Columns[5].HeaderText = "Tên sách";
            dataGridView1.Columns[6].HeaderText = "Tác giả";
            dataGridView1.Columns[7].HeaderText = "Ngày mượn";
            dataGridView1.Columns[8].HeaderText = "Ngày trả dự kiến";
            
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tensach.Text == "")
            {
                dataGridView1.DataSource = sdmBus.GetList();

            }
            else
                dataGridView1.DataSource = sdmBus.TimKiem(cbo_tensach.Text);
            int iCount = 0;
            for (int i = 0; i <= dataGridView1.RowCount; i++)
            {
                this.txt_tongso.Text = iCount.ToString();
                iCount++;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            // khởi tạo excel
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo workshet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            int row = 1;
            string fontName = "Times New Roman";
            int fontSizeTieuDe = 16;
            int fontSizeTenTruong = 12;
            //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
            Range row1_TieuDe_ThongKeDoiTuong = worksheet.get_Range("A1", "I1");
            row1_TieuDe_ThongKeDoiTuong.Merge();
            row1_TieuDe_ThongKeDoiTuong.Font.Size = fontSizeTieuDe;
            row1_TieuDe_ThongKeDoiTuong.Font.Name = fontName;
            row1_TieuDe_ThongKeDoiTuong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe_ThongKeDoiTuong.Value2 = "THỐNG KÊ SÁCH ĐANG ĐƯỢC MƯỢN";
            row1_TieuDe_ThongKeDoiTuong.Font.Bold = true;
            row1_TieuDe_ThongKeDoiTuong.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            //Tạo Mã phiếu :
            Range row2_MaSo = worksheet.get_Range("A2", "A2");
            row2_MaSo.Font.Size = fontSizeTenTruong;
            row2_MaSo.Font.Name = fontName;
            row2_MaSo.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_MaSo.Value2 = "Mã phiếu mượn";
            row2_MaSo.ColumnWidth = 15;
            //Tạo mã thẻ
            Range row2_HoTen = worksheet.get_Range("B2", "B2");
            row2_HoTen.Font.Size = fontSizeTenTruong;
            row2_HoTen.Font.Name = fontName;
            row2_HoTen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_HoTen.Value2 = "Mã thẻ";
            row2_HoTen.ColumnWidth = 20;
            //Tạo mã độc giả
            Range row2_GioiTinh = worksheet.get_Range("C2", "C2");
            row2_GioiTinh.Font.Size = fontSizeTenTruong;
            row2_GioiTinh.Font.Name = fontName;
            row2_GioiTinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_GioiTinh.Value2 = "Mã độc giả";
            row2_GioiTinh.ColumnWidth = 20;
            //Tạo họ tên
            Range row2_NgSinh = worksheet.get_Range("D2", "D2");
            row2_NgSinh.Font.Size = fontSizeTenTruong;
            row2_NgSinh.Font.Name = fontName;
            row2_NgSinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_NgSinh.Value2 = "Họ tên";
            row2_NgSinh.ColumnWidth = 20;
            //Tạo mã sách
            Range row2_NgheNghiep = worksheet.get_Range("E2", "E2");
            row2_NgheNghiep.Font.Size = fontSizeTenTruong;
            row2_NgheNghiep.Font.Name = fontName;
            row2_NgheNghiep.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_NgheNghiep.Value2 = "Mã sách";
            row2_NgheNghiep.ColumnWidth = 20;
            //Tạo tên sách
            Range row2_BenhNen = worksheet.get_Range("F2", "F2");
            row2_BenhNen.Font.Size = fontSizeTenTruong;
            row2_BenhNen.Font.Name = fontName;
            row2_BenhNen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_BenhNen.Value2 = "Tên sách";
            row2_BenhNen.ColumnWidth = 30;
            //Tạo tác giả
            Range row2_Nha = worksheet.get_Range("G2", "G2");
            row2_Nha.Font.Size = fontSizeTenTruong;
            row2_Nha.Font.Name = fontName;
            row2_Nha.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_Nha.Value2 = "Tác giả";
            row2_Nha.ColumnWidth = 20;
            //Tạo ngày mượn
            Range row2_Duong = worksheet.get_Range("H2", "H2");
            row2_Duong.Font.Size = fontSizeTenTruong;
            row2_Duong.Font.Name = fontName;
            row2_Duong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_Duong.Value2 = "Ngày mượn";
            row2_Duong.ColumnWidth = 20;
            //Tạo ngày trả dự kiến
            Range row2_To = worksheet.get_Range("I2", "I2");
            row2_To.Font.Size = fontSizeTenTruong;
            row2_To.Font.Name = fontName;
            row2_To.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_To.Value2 = "Ngày trả dự kiến";
            row2_To.ColumnWidth = 20;
           
            //Tô nền vàng các cột tiêu đề:
            Range row2_CotTieuDe = worksheet.get_Range("A2", "I2");
            //nền vàng
            row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //in đậm
            row2_CotTieuDe.Font.Bold = true;

            //chữ đen
            row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

            //// lấy tên cột dữ liệu
            //for (int j = 0; j < dataThongKe.ColumnCount; j++)
            //{
            //    worksheet.Cells[1, j + 1] = dataThongKe.Columns[j].HeaderText;
            //}
            // đổ dữ liệu vào sheet
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            //Kẻ khung toàn bộ
            BorderAround(worksheet.get_Range("A2", "I" + row));
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
    }
}
