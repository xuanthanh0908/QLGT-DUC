using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAOCAO.GUI
{
    public partial class HOADONDIEN : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        public HOADONDIEN()
        {
            InitializeComponent();
            dgvHDD.DataSource = Load_form().Tables["HOADONDIEN"];
            /**/
            CBmaHDD.DataSource = Load_form().Tables["HOADONDIEN"];
            CBmaHDD.DisplayMember = "MAHDDIEN";
            CBmaHDD.ValueMember = "MAHDDIEN";
            /**/
            CBMacanho.DataSource = Load_CBCanHO().Tables["CBCANHO"];
            CBMacanho.DisplayMember = "MACANHO";
            CBMacanho.ValueMember = "MACANHO";
            /**/
            CBMaNV.DataSource = Load_CBNhanVien().Tables["CBNHANVIEN"];
            CBMaNV.DisplayMember = "MANV";
            CBMaNV.ValueMember = "MANV";
            /**/
            CBMaHGD.DataSource = Load_CBHGD().Tables["CBHGD"];
            CBMaHGD.DisplayMember = "MAHGD";
            CBMaHGD.ValueMember = "MAHGD";
            /**/
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            /**/
            txtmahd.Focus();
        }
        public HOADONDIEN(string mahgd)
        {
            InitializeComponent();
            dgvHDD.DataSource = Load_form_Condition(mahgd).Tables["HOADONDIENCONDITION"];
            /**/
            CBmaHDD.DataSource = Load_form().Tables["HOADONDIEN"];
            CBmaHDD.DisplayMember = "MAHDDIEN";
            CBmaHDD.ValueMember = "MAHDDIEN";
            /**/
            CBMacanho.DataSource = Load_CBCanHO().Tables["CBCANHO"];
            CBMacanho.DisplayMember = "MACANHO";
            CBMacanho.ValueMember = "MACANHO";
            /**/
            CBMaNV.DataSource = Load_CBNhanVien().Tables["CBNHANVIEN"];
            CBMaNV.DisplayMember = "MANV";
            CBMaNV.ValueMember = "MANV";
            /**/
            CBMaHGD.DataSource = Load_CBHGD().Tables["CBHGD"];
            CBMaHGD.DisplayMember = "MAHGD";
            CBMaHGD.ValueMember = "MAHGD";
            /**/
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            /**/
            txtmahd.Focus();
        }
        public DataSet Load_form()
        {
            string sql = "Select * from HOADONDIEN";
            DataSet dataSet = connDB.get_data(sql, "HOADONDIEN", null);
            return dataSet;
        }
        public DataSet Load_form_Condition(string mahgd)
        {
            string sql = "Select * from HOADONDIEN WHERE MAHGD = '"+mahgd+"'";
            DataSet dataSet = connDB.get_data(sql, "HOADONDIENCONDITION", null);
            return dataSet;
        }
        public DataSet Load_CBNhanVien()
        {
            string sql = "Select * from NHANVIEN";
            DataSet dataSet = connDB.get_data(sql, "CBNHANVIEN", null);
            return dataSet;
        }
        public DataSet Load_CBCanHO()
        {
            string sql = "Select * from CANHO";
            DataSet dataSet = connDB.get_data(sql, "CBCANHO", null);
            return dataSet;
        }
        public DataSet Load_CBHGD()
        {
            string sql = "Select * from HGD";
            DataSet dataSet = connDB.get_data(sql, "CBHGD", null);
            return dataSet;
        }
        public DataSet Load_TextNV()
        {
            string sql = "Select TENNV from NHANVIEN WHERE MANV = @MANV";
            string manv = CBMaNV.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MANV", manv));
            DataSet dataSet = connDB.get_data(sql, "TENNV", parameters);
            return dataSet;
        }
        public DataSet Load_TextTENCHUHO()
        {
            string sql = "Select TENCH from HGD WHERE MAHGD = @MAHGD";
            string mahgd = CBMaHGD.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MAHGD", mahgd));
            DataSet dataSet = connDB.get_data(sql, "TENCH", parameters);
            return dataSet;
        }
        public DataSet Load_TextTenCanHo()
        {
            string sql = "Select LOAICANHO from CANHO WHERE MACANHO = @MACANHO";
            string macanho = CBMacanho.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MACANHO", macanho));
            DataSet dataSet = connDB.get_data(sql, "TENCANHO", parameters);
            return dataSet;
        }

        public void ClearText()
        {
            txtmahd.Text = "";
            txtLoaiCH.Text = "";
            DateNgayIn.Text = "01-01-2021";
            txtSoluong.Text = "";
            txtTenchuho.Text = "";
            txtTenNV.Text = "";
            txtTong.Text = "";
            txtTrangthai.Text = "";
            txtTenhd.Text = "";
            CBMacanho.SelectedIndex = 0;
            CBMaHGD.SelectedIndex = 0;
            CBMacanho.SelectedIndex = 0;
            CBMaNV.ValueMember = "MANV";
            txtTenNV.Text = Load_TextNV().Tables["TENNV"].Rows[0].ItemArray.GetValue(0).ToString();
            CBMaHGD.ValueMember = "MAHGD";
            txtTenchuho.Text = Load_TextTENCHUHO().Tables["TENCH"].Rows[0].ItemArray.GetValue(0).ToString();
            CBMacanho.ValueMember = "MACANHO";
            txtLoaiCH.Text = Load_TextTenCanHo().Tables["TENCANHO"].Rows[0].ItemArray.GetValue(0).ToString();
            txtmahd.Focus();
        }
        public void Refresh()
        {
            dgvHDD.DataSource = Load_form().Tables["HOADONDIEN"];
        }
        private void CBMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            CBMaNV.ValueMember = "MANV";
            txtTenNV.Text = Load_TextNV().Tables["TENNV"].Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void CBMaHGD_SelectedValueChanged(object sender, EventArgs e)
        {
            CBMaHGD.ValueMember = "MAHGD";
            txtTenchuho.Text = Load_TextTENCHUHO().Tables["TENCH"].Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void CBMacanho_SelectedValueChanged(object sender, EventArgs e)
        {
            CBMacanho.ValueMember = "MACANHO";
            txtLoaiCH.Text = Load_TextTenCanHo().Tables["TENCANHO"].Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string tenhd = txtTenhd.Text;
            string manv = CBMaNV.SelectedValue.ToString();
            string tennv = txtTenNV.Text;
            string mahgd = CBMaHGD.SelectedValue.ToString();
            string tenchuho = txtTenchuho.Text;
            string macanho = CBMacanho.SelectedValue.ToString();
            string loaicanho = txtLoaiCH.Text;
            string soluong = txtSoluong.Text;
            string dongia = txtDongia.Text;
            float tongtien = float.Parse(txtTong.Text);
            string trangthai = txtTrangthai.Text;
            /**/
            string sql = "INSERT INTO HOADONDIEN VALUES(@MAHD,@TENHD,@MANV,@TENNV,@NGAYIN,@MAHGD,@TENCHUHO,@MACANHO,@LOAICANHO,@SOLUONG,@DONGIA,@TONGTIEN,@TRANGTHAI)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MAHD", mahd));
            parameters.Add(new SqlParameter("@TENHD", tenhd));
            parameters.Add(new SqlParameter("@MANV", manv));
            parameters.Add(new SqlParameter("@TENNV", tennv));
            parameters.Add(new SqlParameter("@MAHGD", mahgd));
            parameters.Add(new SqlParameter("@TENCHUHO", tenchuho));
            parameters.Add(new SqlParameter("@MACANHO", macanho));
            parameters.Add(new SqlParameter("@LOAICANHO", loaicanho));
            parameters.Add(new SqlParameter("@NGAYIN", DateNgayIn.Value.Date));
            parameters.Add(new SqlParameter("@SOLUONG", soluong));
            parameters.Add(new SqlParameter("@DONGIA", dongia));
            parameters.Add(new SqlParameter("@TONGTIEN", tongtien));
            parameters.Add(new SqlParameter("@TRANGTHAI", trangthai));
            /**/
            if (txtmahd.Text == "")
                return;
            else
            {
                connDB.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string tenhd = txtTenhd.Text;
            string manv = CBMaNV.SelectedValue.ToString();
            string tennv = txtTenNV.Text;
            string mahgd = CBMaHGD.SelectedValue.ToString();
            string tenchuho = txtTenchuho.Text;
            string macanho = CBMacanho.SelectedValue.ToString();
            string loaicanho = txtLoaiCH.Text;
            string soluong = txtSoluong.Text;
            string dongia = txtDongia.Text;
            float tongtien = float.Parse(txtTong.Text);
            string trangthai = txtTrangthai.Text;
            /**/
            string sql = "UPDATE HOADONDIEN SET " +
                "TENHD = @TENHD,MANV = @MANV,TENNV = @TENNV,MAHGD = @MAHGD,TENCHUHO = @TENCHUHO," +
                "MACH = @MACANHO,LOAICANHO = @LOAICANHO,NGAYIN = @NGAYIN,SOLUONG = @SOLUONG," +
                "DONGIA = @DONGIA,TONGTIEN = @TONGTIEN,TRANGTHAI = @TRANGTHAI WHERE MAHDDIEN = @MAHD";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MAHD", mahd));
            parameters.Add(new SqlParameter("@TENHD", tenhd));
            parameters.Add(new SqlParameter("@MANV", manv));
            parameters.Add(new SqlParameter("@TENNV", tennv));
            parameters.Add(new SqlParameter("@MAHGD", mahgd));
            parameters.Add(new SqlParameter("@TENCHUHO", tenchuho));
            parameters.Add(new SqlParameter("@MACANHO", macanho));
            parameters.Add(new SqlParameter("@LOAICANHO", loaicanho));
            parameters.Add(new SqlParameter("@NGAYIN", DateNgayIn.Value.Date));
            parameters.Add(new SqlParameter("@SOLUONG", soluong));
            parameters.Add(new SqlParameter("@DONGIA", dongia));
            parameters.Add(new SqlParameter("@TONGTIEN", tongtien));
            parameters.Add(new SqlParameter("@TRANGTHAI", trangthai));
            /**/
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE HOADONDIEN WHERE MAHDDIEN = '"+txtmahd.Text+"'";
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, null);
                Refresh();
                ClearText();
                
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Refresh();
            ClearText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HOADONDIEN WHERE MAHDDIEN = @MAHDDIEN";
            string mahd = CBmaHDD.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MAHDDIEN", mahd));
            DataSet dataSet = connDB.get_data(sql, "TKHDD", parameters);
            dgvHDD.DataSource = dataSet.Tables["TKHDD"];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }

        private void txtmahd_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmahd.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void dgvHDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0 && index < dgvHDD.Rows.Count - 1)
            {
                txtmahd.Text = dgvHDD.Rows[index].Cells[0].Value.ToString();
                txtTenhd.Text = dgvHDD.Rows[index].Cells[1].Value.ToString();
                CBMaNV.SelectedValue = dgvHDD.Rows[index].Cells[2].Value.ToString();
                txtTenNV.Text = dgvHDD.Rows[index].Cells[3].Value.ToString();
                DateNgayIn.Text = dgvHDD.Rows[index].Cells[4].Value.ToString();
                CBMaHGD.SelectedValue = dgvHDD.Rows[index].Cells[5].Value.ToString();
                txtTenchuho.Text = dgvHDD.Rows[index].Cells[6].Value.ToString();
                CBMacanho.SelectedValue = dgvHDD.Rows[index].Cells[7].Value.ToString();
                txtLoaiCH.Text = dgvHDD.Rows[index].Cells[8].Value.ToString();
                txtSoluong.Text = dgvHDD.Rows[index].Cells[9].Value.ToString();
                txtDongia.Text = dgvHDD.Rows[index].Cells[10].Value.ToString();
                txtTong.Text = dgvHDD.Rows[index].Cells[11].Value.ToString();
                txtTrangthai.Text = dgvHDD.Rows[index].Cells[12].Value.ToString();
                /**/
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                /**/
                CBMaNV.ValueMember = "MANV";
                txtTenNV.Text = Load_TextNV().Tables["TENNV"].Rows[0].ItemArray.GetValue(0).ToString();
                CBMaHGD.ValueMember = "MAHGD";
                txtTenchuho.Text = Load_TextTENCHUHO().Tables["TENCH"].Rows[0].ItemArray.GetValue(0).ToString();
                CBMacanho.ValueMember = "MACANHO";
                txtLoaiCH.Text = Load_TextTenCanHo().Tables["TENCANHO"].Rows[0].ItemArray.GetValue(0).ToString();
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text != "")
            {
                float tongtien = Int32.Parse(txtSoluong.Text) * 4000;
                txtTong.Text = tongtien.ToString();
            }
            else txtTong.Text = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\Users\\Admin\\Documents\\NETFILE";
            saveFileDialog1.Filter = "xlsx Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "HÓA ĐƠN ĐIỆN";
                // storing header part in Excel  
                for (int i = 1; i < dgvHDD.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvHDD.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvHDD.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvHDD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvHDD.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // Show mess
                MessageBox.Show("Expored successfully !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // save the application  
                workbook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
        }
    }
}
