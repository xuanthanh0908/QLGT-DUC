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
    public partial class HOPDONG : Form
    {
        ConnectToDB ConnectToDB = new ConnectToDB();
        public HOPDONG()
        {
            InitializeComponent();
            dgvHD.DataSource = Load_form().Tables["HOPDONG"];
            /**/
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public HOPDONG(string mahgd)
        {
            InitializeComponent();
            
            /**/
            /**/
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public DataSet Load_form()
        {
            string sql = "Select * from QLHD";
            DataSet dataSet = ConnectToDB.get_data(sql, "HOPDONG", null);
            return dataSet;
        }
   
      
        public void ClearText()
        {
            txtHD.Text = "";
            txtMGT.Text = "";
            txtTenNV.Text = "";
            txtTime.Text = "";
            txtTENKH.Text = "";
            txtMNV.Text = "";
            txtNK.Text = "";
            txtTGT.Text = "";
            txtGia.Text = "";
            txtMKH.Text = "";
            txtHD.Focus();
        }
        public void Refresh()
        {
            dgvHD.DataSource = Load_form().Tables["HOPDONG"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO QLHD(customid,customname,time,bcontract," +
                "price,scriptid,scriptname,staffid,staffname) VALUES(@customid,@customname,@time,@bcontract," +
                "@price,@scriptid,@scriptname,@staffid,@staffname)";


            List<SqlParameter> parameters = new List<SqlParameter>();
         
  


            parameters.Add(new SqlParameter("@customid", Int32.Parse(txtMKH.Text)));
            parameters.Add(new SqlParameter("@customname", txtTENKH.Text));
            parameters.Add(new SqlParameter("@time", txtTime.Text));
            parameters.Add(new SqlParameter("@bcontract", txtNK.Text));
            parameters.Add(new SqlParameter("@price", txtGia.Text));
            parameters.Add(new SqlParameter("@scriptid", Int32.Parse(txtMGT.Text)));
            parameters.Add(new SqlParameter("@scriptname", txtTGT.Text));
            parameters.Add(new SqlParameter("@staffid", Int32.Parse(txtMNV.Text)));
            parameters.Add(new SqlParameter("@staffname", txtTenNV.Text));


            if (txtTENKH.Text == "")
                return;
            else
            {
                ConnectToDB.Excute(sql, parameters);
                MessageBox.Show("Thêm mới thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                ClearText();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        public string Load_TENNV()
        {
            string query = "Select name from QLNV where id = "+Int32.Parse(txtMNV.Text)+"";
            string name = "";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectToDB.conn);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    name = (string)data.GetValue(0);
                }
                connection.Close();
                return name;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
                return null;
            }
        }
        public string Load_TENGT()
        {
            string query = "Select name from QLGT where id = " + Int32.Parse(txtMGT.Text) + "";
            string name = "";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectToDB.conn);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    name = (string)data.GetValue(0);
                }
                connection.Close();
                return name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
                return null;
            }
        }
        public string Load_TENKH()
        {
            string name = "";
            string query = "Select name from QLKH where id = " + Int32.Parse(txtMKH.Text) + "";
            try
            {
                SqlConnection connection = new SqlConnection(ConnectToDB.conn);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    name = (string)data.GetValue(0);
                }
                connection.Close();
                return name;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
                return null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
     
            string sql = "UPDATE QLHD SET customid = @customid ,customname = @customname,time=@time,bcontract=@bcontract," +
                "price=@price,scriptid=@scriptid,scriptname=@scriptname,staffid=@staffid,staffname=@staffname where id = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@customid", Int32.Parse(txtMKH.Text)));
           
            parameters.Add(new SqlParameter("@customname", Load_TENKH()));
            parameters.Add(new SqlParameter("@time", txtTime.Text));
            parameters.Add(new SqlParameter("@bcontract", txtNK.Text));
            parameters.Add(new SqlParameter("@price", txtGia.Text));
            parameters.Add(new SqlParameter("@scriptid", Int32.Parse(txtMGT.Text)));
            parameters.Add(new SqlParameter("@scriptname", Load_TENGT().ToString()));
            parameters.Add(new SqlParameter("@staffid", Int32.Parse(txtMNV.Text)));
            parameters.Add(new SqlParameter("@staffname", Load_TENNV().ToString()));
            parameters.Add(new SqlParameter("@ID", Int32.Parse(txtHD.Text)));

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn sửa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConnectToDB.Excute(sql, parameters);
                Refresh();
                ClearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE QLHD WHERE ID = '"+Int32.Parse( txtHD.Text)+"'";
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                ConnectToDB.Excute(sql, null);
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
            string sql = "select * from qlhd where (customname LIKE @Search1) OR (customname LIKE @Search2) OR (customname LIKE @Search3) OR (customname = @Search)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter s1 = new SqlParameter("@Search1", SqlDbType.NVarChar, 255)
            {
                Value = "%" + txtTimkiem.Text + "%",

            };
            SqlParameter s2 = new SqlParameter("@Search2", SqlDbType.NVarChar, 255)
            {
                Value = txtTimkiem.Text + "%"
            };
            SqlParameter s3 = new SqlParameter("@Search3", SqlDbType.NVarChar, 255)
            {
                Value = "%" + txtTimkiem.Text
            };
            parameters.Add(new SqlParameter("@Search1",s1.Value));
            parameters.Add(new SqlParameter("@Search2", s2.Value));
            parameters.Add(new SqlParameter("@Search3",s3.Value));
            parameters.Add(new SqlParameter("@Search",  txtTimkiem.Text));

            DataSet dataSet = ConnectToDB.get_data(sql, "TKHD", parameters);
            dgvHD.DataSource = dataSet.Tables["TKHD"];
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
      


        private void txtMahd_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHD.Text))
            {
                btnThem.Enabled = false;
            }
            else btnThem.Enabled = true;
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 && index < dgvHD.Rows.Count - 1)
            {
                txtHD.Text = dgvHD.Rows[index].Cells[0].Value.ToString();
                txtMKH.Text = dgvHD.Rows[index].Cells[1].Value.ToString();
                txtTENKH.Text = dgvHD.Rows[index].Cells[2].Value.ToString();
                txtTime.Text = dgvHD.Rows[index].Cells[3].Value.ToString();
                txtNK.Text = dgvHD.Rows[index].Cells[4].Value.ToString();
                txtGia.Text = dgvHD.Rows[index].Cells[5].Value.ToString();
                txtMGT.Text = dgvHD.Rows[index].Cells[6].Value.ToString();
                txtTGT.Text = dgvHD.Rows[index].Cells[7].Value.ToString();
                txtMNV.Text = dgvHD.Rows[index].Cells[8].Value.ToString();
                txtTenNV.Text = dgvHD.Rows[index].Cells[9].Value.ToString();
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtMKH_TextChanged(object sender, EventArgs e)
        {
          if(txtMKH.Text.Length > 0)
            {
                btnThem.Enabled = true;
                txtTENKH.Text = Load_TENKH().ToString();
            }
            else btnThem.Enabled = false;

        }

        private void txtMNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMNV.Text.Length > 0)
            {
                txtTenNV.Text = Load_TENNV().ToString();
            }
        }

        private void txtMGT_TextChanged(object sender, EventArgs e)
        {
            if (txtMGT.Text.Length > 0)
            {
                txtTGT.Text = Load_TENGT().ToString();
            }
        }
    }
}
