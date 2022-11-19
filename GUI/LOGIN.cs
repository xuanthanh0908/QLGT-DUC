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

namespace BAOCAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTK.Text = "Tam";
            txtMK.Text = "222";
        }
        public Form1(string tk,string mk)
        {
            InitializeComponent();
            txtTK.Text = tk;
            txtMK.Text = mk;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string query = "select count(*) from admin where username = @tk and password = @mk";
                SqlConnection connection = new SqlConnection(ConnectToDB.conn);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@tk",tk);
                cmd.Parameters.AddWithValue("@mk", mk);
                int soluong = (int)cmd.ExecuteScalar();
                connection.Close();

                if (soluong > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GUI.MAIN frmMain = new GUI.MAIN(txtTK.Text,txtMK.Text);
                    frmMain.Show();
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
            
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!", ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
    }
}
