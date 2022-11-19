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
using System.Globalization;
using  Microsoft.Office.Interop.Excel;

namespace BAOCAO.GUI
{
    public partial class XEMHOADON : Form
    {
        ConnectToDB ConnDB = new ConnectToDB();
        public XEMHOADON()
        {
            InitializeComponent();
            dgvHD.DataSource = Load_form().Tables["HOADON"];
            DataSet data = Load_form();
            Load_Text_WithCondition(data,"HOADON");
        }
        public DataSet Load_form()
        {
            string sql = "SELECT * FROM HOADON";
            DataSet dataSet = ConnDB.get_data(sql, "HOADON", null);
            return dataSet;
        }
        public void Load_Text_WithCondition(DataSet data,string TableName)
        {
            float tongtien = 0;
            float tiendien = 0;
            float tiennuoc = 0;
            float tiendv = 0;
            if(dgvHD.Rows.Count > 0 )
            {
                for (int i = 0; i < data.Tables[TableName].Rows.Count; i++)
                {
                    if(data.Tables[TableName].Rows[i][3] !=DBNull.Value && data.Tables[TableName].Rows[i][4] !=DBNull.Value)
                    {
                        tiendien += float.Parse(data.Tables[TableName].Rows[i].ItemArray.GetValue(3).ToString());
                        tiennuoc += float.Parse(data.Tables[TableName].Rows[i].ItemArray.GetValue(4).ToString());
                        tiendv += 450000;
                    }
                    else
                    {
                        tiendien += 0;
                        tiennuoc += 0;
                        tiendv += 450000;
                    }
                }
                tongtien = tiendien + tiendv + tiennuoc;
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   
                txtDien.Text = tiendien.ToString("#,###", cul.NumberFormat);
                txtNuoc.Text = tiennuoc.ToString("#,###", cul.NumberFormat);
                txtDV.Text = tiendv.ToString("#,###", cul.NumberFormat);
                txtTong.Text = tongtien.ToString("#,###", cul.NumberFormat);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (CBthang.Enabled )
            {
                if(CBthang.SelectedIndex != -1)
                {
                    int thang = Int32.Parse(CBthang.SelectedItem.ToString());
                    string sql = "Select * from HOADON WHERE MONTH(NGAY) = '" + thang + "'";
                    DataSet dataSet = ConnDB.get_data(sql, "THANG", null);
                    if (dataSet.Tables["THANG"].Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        dgvHD.DataSource = dataSet.Tables["THANG"];
                        Load_Text_WithCondition(dataSet,"THANG");
                    }
                }
            }
            if(txtNam.Enabled )
            {
                if(txtNam.Text !="")
                {
                    int nam = Int32.Parse(txtNam.Text);
                    string sql = "Select * from HOADON WHERE YEAR(NGAY) = '" + nam + "'";
                    DataSet dataSet = ConnDB.get_data(sql, "NAM", null);
                    if (dataSet.Tables["NAM"].Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy thông tin !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        dgvHD.DataSource = dataSet.Tables["NAM"];
                        Load_Text_WithCondition(dataSet,"NAM");
                    }
                }
            }
        }

        private void CBthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBthang.SelectedIndex == 0)
            {
                CBthang.Enabled = false;
                txtNam.Enabled = true;
            }
            else
            {
                CBthang.Enabled = true;
                txtNam.Enabled = false;
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                txtNam.Enabled = false;
                CBthang.Enabled = true;
            }
            else
            {
                CBthang.Enabled = false;
                txtNam.Enabled = true;
            }
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
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dgvHD.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvHD.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvHD.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvHD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvHD.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
        }
    }
}
