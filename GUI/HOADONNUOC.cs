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
    public partial class HOADONNUOC : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        public HOADONNUOC()
        {
            InitializeComponent();
            dgvHDN.DataSource = Load_form().Tables["HOADONNUOC"];
            /**/
            CBmaHDN.DataSource = Load_form().Tables["HOADONNUOC"];
            CBmaHDN.DisplayMember = "MAHDNUOC";
            CBmaHDN.ValueMember = "MAHDNUOC";
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
        public HOADONNUOC(string mahgd)
        {
            InitializeComponent();
            dgvHDN.DataSource = Load_form_Condition(mahgd).Tables["HOADONNUOCCONDITION"];
            /**/
            CBmaHDN.DataSource = Load_form().Tables["HOADONNUOC"];
            CBmaHDN.DisplayMember = "MAHDNUOC";
            CBmaHDN.ValueMember = "MAHDNUOC";
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
            string sql = "Select * from HOADONNUOC";
            DataSet dataSet = connDB.get_data(sql, "HOADONNUOC", null);
            return dataSet;
        }
        public DataSet Load_form_Condition(string mahgd)
        {
            string sql = "Select * from HOADONNUOC WHERE MAHGD = '"+ mahgd + "'";
            DataSet dataSet = connDB.get_data(sql, "HOADONNUOCCONDITION", null);
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
            DateNgayIn.Text = "";
            txtSokhoi.Text = "";
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
            dgvHDN.DataSource = Load_form().Tables["HOADONNUOC"];
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
            string sokhoi = txtSokhoi.Text;
            string dongia = txtDongia.Text;
            float tongtien = float.Parse(txtTong.Text);
            string trangthai = txtTrangthai.Text;
            /**/
            string sql = "INSERT INTO HOADONNUOC VALUES(@MAHD,@TENHD,@MANV,@TENNV,@NGAYIN,@MAHGD,@TENCHUHO,@MACANHO,@LOAICANHO,@SOKHOI,@DONGIA,@TONGTIEN,@TRANGTHAI)";
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
            parameters.Add(new SqlParameter("@SOKHOI", sokhoi));
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
            string sokhoi = txtSokhoi.Text;
            string dongia = txtDongia.Text;
            float tongtien = float.Parse(txtTong.Text);
            string trangthai = txtTrangthai.Text;
            /**/
            string sql = "UPDATE HOADONNUOC SET " +
                "TENHD = @TENHD,MANV = @MANV,TENNV = @TENNV,MAHGD = @MAHGD,TENCHUHO = @TENCHUHO," +
                "MACH = @MACANHO,LOAICANHO = @LOAICANHO,NGAYIN = @NGAYIN,SOKHOI = @SOKHOI," +
                "DONGIA = @DONGIA,TONGTIEN = @TONGTIEN,TRANGTHAI = @TRANGTHAI WHERE MAHDNUOC = @MAHD";
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
            parameters.Add(new SqlParameter("@SOKHOI", sokhoi));
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
            string sql = "DELETE HOADONNUOC WHERE MAHDNUOC = '" + txtmahd.Text + "'";
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
            string sql = "Select * from HOADONNUOC WHERE MAHDNUOC = @MAHDNC";
            string mahd = CBmaHDN.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MAHDNC", mahd));
            DataSet dataSet = connDB.get_data(sql, "TKHDN", parameters);
            dgvHDN.DataSource = dataSet.Tables["TKHDN"];
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

        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvHDN.Rows.Count - 1)
            {
                txtmahd.Text = dgvHDN.Rows[index].Cells[0].Value.ToString();
                txtTenhd.Text = dgvHDN.Rows[index].Cells[1].Value.ToString();
                CBMaNV.SelectedValue = dgvHDN.Rows[index].Cells[2].Value.ToString();
                txtTenNV.Text = dgvHDN.Rows[index].Cells[3].Value.ToString();
                DateNgayIn.Text = dgvHDN.Rows[index].Cells[4].Value.ToString();
                CBMaHGD.SelectedValue = dgvHDN.Rows[index].Cells[5].Value.ToString();
                txtTenchuho.Text = dgvHDN.Rows[index].Cells[6].Value.ToString();
                CBMacanho.SelectedValue = dgvHDN.Rows[index].Cells[7].Value.ToString();
                txtLoaiCH.Text = dgvHDN.Rows[index].Cells[8].Value.ToString();
                txtSokhoi.Text = dgvHDN.Rows[index].Cells[9].Value.ToString();
                txtDongia.Text = dgvHDN.Rows[index].Cells[10].Value.ToString();
                txtTong.Text = dgvHDN.Rows[index].Cells[11].Value.ToString();
                txtTrangthai.Text = dgvHDN.Rows[index].Cells[12].Value.ToString();
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

        private void txtSokhoi_TextChanged(object sender, EventArgs e)
        {
            if (txtSokhoi.Text != "")
            {
                float tongtien = Int32.Parse(txtSokhoi.Text) * Int32.Parse(txtDongia.Text);
                txtTong.Text = tongtien.ToString();
            }
            else txtTong.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\Users\\Admin\\Documents\\NETFILE";
            saveFileDialog1.Filter = "xlsx Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                
                app.Visible = false;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "HÓA ĐƠN NƯỚC";
                for (int i = 1; i < dgvHDN.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvHDN.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvHDN.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvHDN.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvHDN.Rows[i].Cells[j].Value.ToString();
                    }
                }
                
                MessageBox.Show("Expored successfully !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                workbook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}
