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
    public partial class THANHVIEN : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        public THANHVIEN()
        {
            InitializeComponent();
            dgvTV.DataSource = Load_form().Tables["THANHVIEN"];
            CBMATV.DataSource = Load_form().Tables["THANHVIEN"];
            CBMATV.DisplayMember = "MATV";
            CBMATV.ValueMember = "MATV";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public THANHVIEN(string mahgd)
        {
            InitializeComponent();
            dgvTV.DataSource = Load_form_condition(mahgd).Tables["THANHVIENCONDITION"];
            CBMATV.DataSource = Load_form().Tables["THANHVIEN"];
            CBMATV.DisplayMember = "MATV";
            CBMATV.ValueMember = "MATV";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public DataSet Load_form()
        {
            string sql = "Select * from THANHVIEN ";
            DataSet dataSet = connDB.get_data(sql, "THANHVIEN", null);
            return dataSet;
        }
        public DataSet Load_form_condition(string mahgd)
        {
            string sql = "Select * from THANHVIEN WHERE MAHGD = '"+mahgd+"'";
            DataSet dataSet = connDB.get_data(sql, "THANHVIENCONDITION", null);
            return dataSet;
        }
        public void ClearText()
        {
            txtCMND.Text = "";
            txtEmail.Text = "";
            txtHoten.Text = "";
            txtMaHGD.Text = "";
            txtmatv.Text = "";
            txtSDT.Text = "";
            rdbtNam.Checked = true;
            DateNS.Text = "01-01-2021";
            txtmatv.Focus();
        }
        public void Refresh()
        {
            dgvTV.DataSource = Load_form().Tables["THANHVIEN"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string matv = txtmatv.Text;
            string hoten = txtHoten.Text;
            string sdt = txtSDT.Text;
            string mahgd = txtMaHGD.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            string gioitinh = "";
            if (rdbtNu.Checked)
                gioitinh = rdbtNu.Text;
            else gioitinh = rdbtNam.Text;

            /**/
            string sql = "INSERT INTO THANHVIEN VALUES(@MATV,@TENTV,@SDT,@NGAYSINH,@MAHGD,@CMND,@EMAIL,@GIOITINH)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MATV", matv));
            parameters.Add(new SqlParameter("@TENTV", hoten));
            parameters.Add(new SqlParameter("@SDT", sdt));
            parameters.Add(new SqlParameter("@NGAYSINH", DateNS.Value.Date));
            parameters.Add(new SqlParameter("@MAHGD", mahgd));
            parameters.Add(new SqlParameter("@CMND", cmnd));
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@GIOITINH", gioitinh));

            if (txtmatv.Text == "")
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
            string matv = txtmatv.Text;
            string hoten = txtHoten.Text;
            string sdt = txtSDT.Text;
            string mahgd = txtMaHGD.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            string gioitinh = "";
            if (rdbtNu.Checked)
                gioitinh = rdbtNu.Text;
            else gioitinh = rdbtNam.Text;

            /**/
            string sql = "UPDATE THANHVIEN SET TENTV = @TENTV, SDT = @SDT,NGAYSINH = @NGAYSINH, MAHGD = @MAHGD,SOCMND = @CMND,EMAIL = @EMAIL,GIOITINH = @GIOITINH WHERE MATV = @MATV";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MATV", matv));
            parameters.Add(new SqlParameter("@TENTV", hoten));
            parameters.Add(new SqlParameter("@SDT", sdt));
            parameters.Add(new SqlParameter("@NGAYSINH", DateNS.Value.Date));
            parameters.Add(new SqlParameter("@MAHGD", mahgd));
            parameters.Add(new SqlParameter("@CMND", cmnd));
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@GIOITINH", gioitinh));

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
            string sql = "DELETE THANHVIEN WHERE MATV = @MATV";
            string matv = txtmatv.Text;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MATV", matv));
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, parameters);
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
            string sql = "select * from THANHVIEN where MATV = @MATV";
            string matv = CBMATV.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MATV", matv));
            DataSet dataSet = connDB.get_data(sql, "TKTV", parameters);
            dgvTV.DataSource = dataSet.Tables["TKTV"];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }

        private void txtmatv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmatv.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void dgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 && index < dgvTV.Rows.Count - 1)
            {
                txtmatv.Text = dgvTV.Rows[index].Cells[0].Value.ToString();
                txtHoten.Text = dgvTV.Rows[index].Cells[1].Value.ToString();
                txtSDT.Text = dgvTV.Rows[index].Cells[2].Value.ToString();
                DateNS.Text = dgvTV.Rows[index].Cells[3].Value.ToString();
                txtMaHGD.Text = dgvTV.Rows[index].Cells[4].Value.ToString();
                txtCMND.Text = dgvTV.Rows[index].Cells[5].Value.ToString();
                txtEmail.Text = dgvTV.Rows[index].Cells[6].Value.ToString();
                string gioitinh = dgvTV.Rows[index].Cells[7].Value.ToString();
                if (gioitinh == "Nữ")
                    rdbtNu.Checked = true;
                else rdbtNam.Checked = true;

                /**/
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

    }
}
