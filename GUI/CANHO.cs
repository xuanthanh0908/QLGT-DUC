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
    public partial class CANHO : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        public CANHO()
        {
            InitializeComponent();
            dgvCH.DataSource = Load_form().Tables["CANHO"];
            txtID.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void ClearText()
        {
            txtID.Text = "";
            txtTime.Text = "";
            txtPrice.Text = "";
            txtName.Text = "";
            txtNu.Text = "";
            txtScript.Text = "";
        }
        public DataSet Load_form()
        {
            string sql = "Select * from qlgt";
            DataSet dataSet = connDB.get_data(sql, "CANHO", null);
            return dataSet;
        }
        public void Refresh()
        {
            dgvCH.DataSource = Load_form().Tables["CANHO"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO QLGT(name, time, price,script,nutrition) VALUES(@name, @time, @price, @script,@nutrition)";
            if (txtName.Text == "")
                return;
            else
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@name", txtName.Text));
                parameters.Add(new SqlParameter("@time", txtTime.Text));
                parameters.Add(new SqlParameter("@price", txtPrice.Text));
                parameters.Add(new SqlParameter("@script", txtScript.Text));
                parameters.Add(new SqlParameter("@nutrition", txtNu.Text));
                connDB.Excute(sql, parameters);
                /**/
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                txtName.Focus();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        

        private void txtmach_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE QLGT WHERE ID = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", txtID.Text));
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void dgvCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0 && index < dgvCH.Rows.Count - 1)
            {
                txtID.Text = dgvCH.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dgvCH.Rows[index].Cells[1].Value.ToString();
                txtPrice.Text = dgvCH.Rows[index].Cells[3].Value.ToString();
                txtScript.Text = dgvCH.Rows[index].Cells[2].Value.ToString();
                txtTime.Text = dgvCH.Rows[index].Cells[4].Value.ToString();
                txtNu.Text = dgvCH.Rows[index].Cells[5].Value.ToString();

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

  
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from CANHO where MACANHO = @MACH";
            string mach = CBmaCH.SelectedValue.ToString();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MACH", mach));
            DataSet dataSet = connDB.get_data(sql, "MACH", parameters);
            dgvCH.DataSource = dataSet.Tables["MACH"];
       
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
            string sql = "UPDATE  QLGT set name = @name, time = @time, price = @price,script = @script,nutrition= @nutrition where id = @ID";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", txtName.Text));
            parameters.Add(new SqlParameter("@time", txtTime.Text));
            parameters.Add(new SqlParameter("@price", txtPrice.Text));
            parameters.Add(new SqlParameter("@script", txtScript.Text));
            parameters.Add(new SqlParameter("@nutrition", txtNu.Text));
            parameters.Add(new SqlParameter("@ID", txtID.Text));


            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length> 0)
            {
                btnThem.Enabled = true;
            }else
            {
                btnThem.Enabled = false;
            }
        }
    }
}
