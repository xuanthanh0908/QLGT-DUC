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
    public partial class NHANVIEN : Form
    {
        ConnectToDB ConDB = new ConnectToDB();
        public NHANVIEN()
        {
            InitializeComponent();
            dgvNV.DataSource = Load_form().Tables["NHANVIEN"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CBmaNV.DataSource = Load_CB().Tables["LOADCB"];
            CBmaNV.DisplayMember = "MANV";
            CBmaNV.ValueMember = "MANV";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public DataSet Load_form()
        {
            string sql = "Select * from NHANVIEN";
            DataSet dataSet = ConDB.get_data(sql,"NHANVIEN",null);
            return dataSet;
        }

        public DataSet Load_CB()
        {
            string sql = "Select MANV from NHANVIEN ";
            DataSet dataSet = ConDB.get_data(sql, "LOADCB", null);
            return dataSet;
        }
        public void ClearText()
        {
            txtManv.Focus();
            txtManv.Text = "";
            txtHoten.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            DateNS.Text = "1-1-2021";
            rdbtNam.Checked = true;
            txtDiachi.Text = "";
        }
        public void Refresh()
        {
            dgvNV.DataSource = Load_form().Tables["NHANVIEN"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = txtManv.Text;
            string hoten = txtHoten.Text;
            string diachi = txtDiachi.Text;
            string gioitinh = "";
            if (rdbtNu.Checked)
                gioitinh = rdbtNu.Text;
            else gioitinh = rdbtNam.Text;
            string dateNS = DateNS.Value.Date.ToString();
            string sdt = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;

            string sql = "INSERT INTO NHANVIEN VALUES (@MANV,@TENNV,@GIOITINH,@DIACHI,@SDT,@NGAYSINH,@EMAIL,@CMND)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MANV", manv));
            parameters.Add(new SqlParameter("@TENNV", hoten));
            parameters.Add(new SqlParameter("@GIOITINH", gioitinh));
            parameters.Add(new SqlParameter("@DIACHI", diachi));
            parameters.Add(new SqlParameter("@SDT", sdt));
            parameters.Add(new SqlParameter("@NGAYSINH", dateNS));
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@CMND", cmnd));

            /**/
            if (txtManv.Text == "")
                return;
            else
            {
                ConDB.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtManv.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Refresh();
            ClearText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 && index < dgvNV.Rows.Count - 1)
            {
                txtManv.Text = dgvNV.Rows[index].Cells[0].Value.ToString();
                txtHoten.Text = dgvNV.Rows[index].Cells[1].Value.ToString();
                string gioitinh = dgvNV.Rows[index].Cells[2].Value.ToString();
                if (gioitinh == "Nữ")
                    rdbtNu.Checked = true;
                else rdbtNam.Checked = true;
                txtDiachi.Text = dgvNV.Rows[index].Cells[3].Value.ToString();
                txtSDT.Text = dgvNV.Rows[index].Cells[4].Value.ToString();
                DateNS.Text = dgvNV.Rows[index].Cells[5].Value.ToString();
                txtEmail.Text = dgvNV.Rows[index].Cells[6].Value.ToString();
                txtCMND.Text = dgvNV.Rows[index].Cells[7].Value.ToString();
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NHANVIEN SET TENNV = @HOTEN,GIOITINH = @GIOITINH, DIACHI = @DIACHI, SDT = @SDT, NGAYSINH = @NGAYSINH, EMAIL = @EMAIL, SOCMND = @CMND WHERE MANV = @MANV";
            string manv = txtManv.Text;
            string hoten = txtHoten.Text;
            string diachi = txtDiachi.Text;
            string gioitinh = "";
            if (rdbtNu.Checked)
                gioitinh = rdbtNu.Text;
            else gioitinh = rdbtNam.Text;
            string dateNS = DateNS.Value.Date.ToString();
            string sdt = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MANV", manv));
            parameters.Add(new SqlParameter("@HOTEN", hoten));
            parameters.Add(new SqlParameter("@GIOITINH", gioitinh));
            parameters.Add(new SqlParameter("@DIACHI", diachi));
            parameters.Add(new SqlParameter("@SDT", sdt));
            parameters.Add(new SqlParameter("@NGAYSINH", dateNS));
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@CMND", cmnd));

            /**/
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE NHANVIEN WHERE MANV = @MANV";
            string manv = txtManv.Text;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MANV", manv ));
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from NHANVIEN where MANV = @MANV";
            string manv = CBmaNV.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MANV", manv));
            DataSet dataSet = ConDB.get_data(sql, "NV", parameters);
            dgvNV.DataSource = dataSet.Tables["NV"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
