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
    public partial class CHITIET : Form
    {
        ConnectToDB connDB = new ConnectToDB();
        string MAHGD ;
        public CHITIET(string mahgd)
        {
            InitializeComponent();
            dgvTV.DataSource = Load_form(mahgd).Tables["THANHVIEN"];
            LbHGD.Text = mahgd;
            MAHGD = mahgd;
            CHECK_ALL();
        }

        public DataSet Load_form(string mahgd)
        {
            string sql = "Select * from THANHVIEN WHERE MAHGD = '"+mahgd+"' ";
            DataSet dataSet = connDB.get_data(sql, "THANHVIEN", null);
            return dataSet;
        }
        public void FullScreen(Form a)
        {
            a.Dock = DockStyle.Fill;
            a.MaximizeBox = false;
            a.MinimizeBox = false;
            a.ControlBox = false;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void btnHD_Click(object sender, EventArgs e)
        {
            GUI.HOPDONG frmHD = new GUI.HOPDONG(MAHGD);
            this.MdiParent.Size = new Size(930, 650);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frmHD.MdiParent = this.MdiParent;
            FullScreen(frmHD);
            frmHD.Show();
        }

        private void btnHDD_Click(object sender, EventArgs e)
        {
            GUI.HOADONDIEN frmHDD = new GUI.HOADONDIEN(MAHGD);
            this.MdiParent.Size = new Size(1150, 650);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frmHDD.MdiParent = this.MdiParent;
            FullScreen(frmHDD);
            frmHDD.Show();
        }

        private void btnHDDN_Click(object sender, EventArgs e)
        {
            GUI.HOADONNUOC frmHDNC = new GUI.HOADONNUOC(MAHGD);
            this.MdiParent.Size = new Size(1150, 650);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frmHDNC.MdiParent = this.MdiParent;
            FullScreen(frmHDNC);
            frmHDNC.Show();
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            GUI.THANHVIEN frmTV = new GUI.THANHVIEN();
            this.MdiParent.Size = new Size(900, 650);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frmTV.MdiParent = this.MdiParent;
            FullScreen(frmTV);
            frmTV.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
        public void CHECK_ALL()
        {
            string time;
            DateTime dateTime = DateTime.Now;
            time = GET_DATA_HD(MAHGD).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
            string text = "";
            if(DateTime.Parse(time).CompareTo(dateTime) <= 0)
            {
                text = MAHGD + " cần gia hạn hợp đồng";
                Lbcanhbao.Text = text;
            }
            if(KiemTraTinhTrangDien(MAHGD) == 1)
            {
                string Trangthai = GET_DATA_DIEN(MAHGD).Tables["GETDATADIEN"].Rows[0].ItemArray.GetValue(12).ToString();
                if(Trangthai.Equals("Chưa đóng"))
                {
                    if(text != "")
                    {
                        text += ", thanh toán hóa đơn điện";
                        Lbcanhbao.Text = text;
                    }
                    else
                    {
                        text += MAHGD+ " cần thanh toán hóa đơn điện";
                        Lbcanhbao.Text = text;
                    }
                }
            }
            if (KiemTraTinhTrangNuoc(MAHGD) == 1)
            {
                string Trangthai = GET_DATA_NUOC(MAHGD).Tables["GETDATANUOC"].Rows[0].ItemArray.GetValue(12).ToString();
                if (Trangthai.Equals("Chưa đóng"))
                {
                    if (text != "")
                    {
                        text += ", thanh toán hóa đơn nước";
                        Lbcanhbao.Text = text;
                    }
                    else
                    {
                        text += MAHGD + " cần thanh toán hóa đơn nước";
                        Lbcanhbao.Text = text;
                    }
                }
            }
        }
        public DataSet GET_DATA_DIEN(string mahgd)
        {

            string sql = "SELECT * FROM HOADONDIEN WHERE MAHGD = '" + mahgd + "' ";
            DataSet dataSet = connDB.get_data(sql, "GETDATADIEN", null);
            return dataSet;
        }
        public DataSet GET_DATA_NUOC(string mahgd)
        {

            string sql = "SELECT * FROM HOADONNUOC WHERE MAHGD = '" + mahgd + "' ";
            DataSet dataSet = connDB.get_data(sql, "GETDATANUOC", null);
            return dataSet;
        }
        public DataSet GET_DATA_HD(string mahgd)
        {

            string sql = "SELECT * FROM HOPDONG WHERE MAHGD = '" + mahgd + "' ";
            DataSet dataSet = connDB.get_data(sql, "GETDATA", null);
            return dataSet;
        }
        public int KiemTraHD(string mahgd)
        {

            string sql = "SELECT * FROM HOPDONG ";
            DataSet dataSet = connDB.get_data(sql, "HOPDONG", null);
            for (int i = 0; i < dataSet.Tables["HOPDONG"].Rows.Count; i++)
            {
                string MaHgd = dataSet.Tables["HOPDONG"].Rows[i].ItemArray.GetValue(6).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    return 1;
                }

            }
            return 0;
        }
        public int KiemTraTinhTrangDien(string mahgd)
        {
            string sql = "SELECT * FROM HOADONDIEN ";
            DataSet dataSet = connDB.get_data(sql, "HOADONDIEN", null);
            for (int i = 0; i < dataSet.Tables["HOADONDIEN"].Rows.Count; i++)
            {
                string MaHgd = dataSet.Tables["HOADONDIEN"].Rows[i].ItemArray.GetValue(5).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    return 1;
                }

            }
            return 0;
        }
        public int KiemTraTinhTrangNuoc(string mahgd)
        {
            
            string sql = "SELECT * FROM HOADONNUOC ";
            DataSet dataSet = connDB.get_data(sql, "HOADONNUOC", null);
            for (int i = 0; i < dataSet.Tables["HOADONNUOC"].Rows.Count; i++)
            {
                string MaHgd = dataSet.Tables["HOADONNUOC"].Rows[i].ItemArray.GetValue(5).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    return 1;
                }

            }
            return 0;
        }
    }
}
