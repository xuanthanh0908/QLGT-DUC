using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAOCAO.GUI
{
    public partial class HGD : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        int MAKH = 1234567;
        public HGD()
        {
            InitializeComponent();
            dgvHGD.DataSource = Load_form().Tables["HGD"];
            dgvHGD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public DataSet Load_form()
        {
            string sql = "Select * from QLKH ";
            DataSet dataSet = connDB.get_data(sql,"HGD",null);
            return dataSet; 
        }
        public void ClearText()
        {
            txtNS.Text = "";
            txtTen.Text = "";
            txtQT.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtCart.Text = "";
        }
        public void Refresh()
        {
            MAKH = 1234567;
            dgvHGD.DataSource = Load_form().Tables["HGD"];
            dgvHGD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO QLKH(name, dob, sex, nationality,phone, cartid) VALUES(@TENKH,@NS,@GT,@QG, @PHONE, @CART)";
            if (txtTen.Text == "")
                return;
            else
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@TENKH", txtTen.Text));
                parameters.Add(new SqlParameter("@NS", txtNS.Text));
                parameters.Add(new SqlParameter("@GT", txtGT.Text));
                parameters.Add(new SqlParameter("@QG", txtQT.Text));
                parameters.Add(new SqlParameter("@PHONE", txtSDT.Text));
                parameters.Add(new SqlParameter("@CART", Int32.Parse(txtCart.Text)));
                connDB.Excute(sql, parameters);
                /**/
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                txtTen.Focus();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string sql = "UPDATE QLKH SET name = @TENKH, dob= @NS, sex = @GT, nationality = @QG, phone = @PHONE,  cartid = @CART WHERE ID =@ID";
            try
            {

                List<SqlParameter> parameters = new List<SqlParameter>();
                if(MAKH == 1234567)
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    parameters.Add(new SqlParameter("@TENKH", txtTen.Text));
                    parameters.Add(new SqlParameter("@NS", txtNS.Text));
                    parameters.Add(new SqlParameter("@GT", txtGT.Text));
                    parameters.Add(new SqlParameter("@QG", txtQT.Text));
                    parameters.Add(new SqlParameter("@PHONE", txtSDT.Text));
                    parameters.Add(new SqlParameter("@CART", Int32.Parse(txtCart.Text)));
                    parameters.Add(new SqlParameter("@ID", MAKH));

                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(rs == DialogResult.Yes)
                    {
                        connDB.Excute(sql, parameters);
                        Refresh();
                        ClearText();
                        txtTen.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE QLKH WHERE ID = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID", MAKH));


            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                connDB.Excute(sql, parameters);
                Refresh();
                ClearText();
                txtTen.Focus();
            }
        }

        private void dgvHGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0 && index < dgvHGD.Rows.Count - 1)
            {
                MAKH = Int32.Parse(dgvHGD.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTen.Text = dgvHGD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNS.Text = dgvHGD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGT.Text = dgvHGD.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQT.Text = dgvHGD.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dgvHGD.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCart.Text = dgvHGD.Rows[e.RowIndex].Cells[6].Value.ToString();
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
        
            string sql = "select * from qlkh where (name LIKE @Search1) OR (name LIKE @Search2) OR (name LIKE @Search3) OR (name = @Search)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter s1 = new SqlParameter("@Search1", SqlDbType.NVarChar, 255)
            {
                Value = "%" + txtTK.Text.ToString() + "%",

            };
            SqlParameter s2 = new SqlParameter("@Search2", SqlDbType.NVarChar, 255)
            {
                Value = txtTK.Text.ToString() + "%"
            };
            SqlParameter s3 = new SqlParameter("@Search3", SqlDbType.NVarChar, 255)
            {
                Value = "%" + txtTK.Text.ToString()
            };
            SqlParameter s4 = new SqlParameter("@Search", SqlDbType.NVarChar, 255)
            {
                Value =  txtTK.Text.ToString()
            };
            parameters.Add(new SqlParameter("@ID", txtTK.Text));
            parameters.Add(new SqlParameter("@Search1", s1.Value));
            parameters.Add(new SqlParameter("@Search2", s2.Value));
            parameters.Add(new SqlParameter("@Search3", s3.Value));
            parameters.Add(new SqlParameter("@Search", s4.Value));

            DataSet dataSet = connDB.get_data(sql, "HGD", parameters);
            dgvHGD.DataSource = dataSet.Tables["HGD"];
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }

        private void txtMahgd_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTen.Text))
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
    }
}
