using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOCAO.GUI
{
    public partial class TKDIEN : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        public TKDIEN()
        {
            InitializeComponent();
            dgvHDD.DataSource = Load_form().Tables["HOADONDIEN"];
        }
        public DataSet Load_form()
        {
            string sql = "Select * from HOADONDIEN";
            DataSet dataSet = connDB.get_data(sql, "HOADONDIEN", null);
            return dataSet;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBthang.SelectedIndex == 0)
            {
                CBthang.Enabled = false;
                txtNam.Enabled = true;
                btnThang.Enabled = false;
                btnNam.Enabled = true;
            }
            else {
                CBthang.Enabled = true;
                txtNam.Enabled = false;
                btnThang.Enabled = true;
                btnNam.Enabled = false;
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if(txtNam.Text == "")
            {
                txtNam.Enabled = false;
                CBthang.Enabled = true;
                btnThang.Enabled = true;
                btnNam.Enabled = false;
            }
            else
            {
                CBthang.Enabled = false;
                txtNam.Enabled = true;
                btnThang.Enabled = false;
                btnNam.Enabled = true;
            }
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            if (CBthang.SelectedIndex != -1)
            {
                int thang = Int32.Parse(CBthang.SelectedItem.ToString());
                string sql = "Select * from HOADONDIEN WHERE MONTH(NGAYIN) = '" + thang + "'";
                DataSet dataSet = connDB.get_data(sql, "THANG", null);
                if (dataSet.Tables["THANG"].Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else dgvHDD.DataSource = dataSet.Tables["THANG"];
            }
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            if (txtNam.Text != "")
            {
                int nam = Int32.Parse(txtNam.Text);
                string sql = "Select * from HOADONDIEN WHERE YEAR(NGAYIN) = '" + nam + "'";
                DataSet dataSet = connDB.get_data(sql, "NAM", null);
                if (dataSet.Tables["NAM"].Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else dgvHDD.DataSource = dataSet.Tables["NAM"];
            }
        }
    }
}
