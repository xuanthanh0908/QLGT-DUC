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
    public partial class DICHVU : Form
    {
        ConnectToDB ConnDB = new ConnectToDB();
        public DICHVU()
        {
            InitializeComponent();
            dgvDV.DataSource = Load_form().Tables["DICHVU"];
            CBMADV.DataSource = Load_form().Tables["DICHVU"];
            CBMADV.DisplayMember = "MADV";
            CBMADV.ValueMember = "MADV";
            /**/
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public DataSet Load_form()
        {
            string sql = "Select * from DICHVU";
            DataSet dataSet = ConnDB.get_data(sql, "DICHVU", null);
            return dataSet;
        }
        public void ClearText()
        {
            txtMadv.Text = "";
            txtTendv.Text = "";
            txtGia.Text = "";
            txtMadv.Focus();
        }
        public void Refresh()
        {
            dgvDV.DataSource = Load_form().Tables["DICHVU"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string madv = txtMadv.Text;
            string tendv = txtTendv.Text;
            string gia = txtGia.Text;

            string sql = "INSERT INTO DICHVU VALUES(@MADV,@TENDV,@GIA)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MADV", madv));
            parameters.Add(new SqlParameter("@TENDV", tendv));
            parameters.Add(new SqlParameter("@GIA", gia));

            if (txtMadv.Text == "")
                return;
            else
            {
                ConnDB.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Refresh();
            ClearText();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string madv = txtMadv.Text;
            string tendv = txtTendv.Text;
            string gia = txtGia.Text;

            string sql = "UPDATE DICHVU SET TENDV = @TENDV,GIA = @GIA WHERE MADV = @MADV";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MADV", madv));
            parameters.Add(new SqlParameter("@TENDV", tendv));
            parameters.Add(new SqlParameter("@GIA", gia));

            /**/
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConnDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string madv = txtMadv.Text;
            string sql = "DELETE DICHVU WHERE MADV = @MADV";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MADV", madv));
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConnDB.Excute(sql, parameters);
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

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 && index < dgvDV.Rows.Count - 1)
            {
                txtMadv.Text = dgvDV.Rows[index].Cells[0].Value.ToString();
                txtTendv.Text = dgvDV.Rows[index].Cells[1].Value.ToString();
                txtGia.Text = dgvDV.Rows[index].Cells[2].Value.ToString();

                /**/
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtMadv_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMadv.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from DICHVU where MADV = @MADV";
            string madv = CBMADV.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MADV", madv));
            DataSet dataSet = ConnDB.get_data(sql, "TKDV", parameters);
            dgvDV.DataSource = dataSet.Tables["TKDV"];
        }
    }
}
