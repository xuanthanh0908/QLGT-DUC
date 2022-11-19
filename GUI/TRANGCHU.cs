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

namespace BAOCAO.GUI
{
    public partial class TRANGCHU : Form
    {
        ConnectToDB ConnDB = new ConnectToDB();
        public TRANGCHU()
        {
            InitializeComponent();
           /* CHECKALL();*/
        }
        public void FullScreen(Form a)
        {
            a.Dock = DockStyle.Fill;
            a.MaximizeBox = false;
            a.MinimizeBox = false;
            a.ControlBox = false;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD01");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD02");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD03");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD04");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD05");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD06");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD07");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD08");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GUI.CHITIET frHGD01 = new GUI.CHITIET("HGD09");
            this.MdiParent.Size = new Size(870, 570);
            this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
            frHGD01.MdiParent = this.MdiParent;
            FullScreen(frHGD01);
            frHGD01.Show();
        }
        /*public void CHECKALL()
        {
            string mahgd = "HGD01";
            string time ;
            DateTime dateTime = DateTime.Now;
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn01.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn01.BackColor = Color.Red;
                    }
                    else
                    {
                        btn01.BackColor = Color.Cyan;
                        btn01.Enabled = true;
                    }
                }
                else btn01.Enabled = false;
            }
            else btn01.Enabled = false;

            *//**//*
            mahgd = "HGD02";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn02.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn02.BackColor = Color.Red;
                    }
                    else
                    {
                        btn02.BackColor = Color.Cyan;
                        btn02.Enabled = true;
                    }
                }
                else btn02.Enabled = false;
            }
            else btn02.Enabled = false;
            *//**//*
            mahgd = "HGD03";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn03.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn03.BackColor = Color.Red;
                    }
                    else
                    {
                        btn03.BackColor = Color.Cyan;
                        btn03.Enabled = true;
                    }
                }
                else btn03.Enabled = false;
            }
            else btn03.Enabled = false;
            *//**//*
            mahgd = "HGD04";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn04.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn04.BackColor = Color.Red;
                    }
                    else
                    {
                        btn04.BackColor = Color.Cyan;
                        btn04.Enabled = true;
                    }
                }
                else btn04.Enabled = false;
            }
            else btn04.Enabled = false;

            *//**//*
            mahgd = "HGD05";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn05.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn05.BackColor = Color.Red;
                    }
                    else
                    {
                        btn05.BackColor = Color.Cyan;
                        btn05.Enabled = true;
                    }
                }
                else btn05.Enabled = false;
            }
            else btn05.Enabled = false;

            *//**//*
            mahgd = "HGD06";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn06.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn06.BackColor = Color.Red;
                    }
                    else
                    {
                        btn06.BackColor = Color.Cyan;
                        btn06.Enabled = true;
                    }
                }
                else btn06.Enabled = false;
            }
            else btn06.Enabled = false;

            *//**//*
            mahgd = "HGD07";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn07.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn07.BackColor = Color.Red;
                    }
                    else
                    {
                        btn07.BackColor = Color.Cyan;
                        btn07.Enabled = true;
                    }
                }
                else btn07.Enabled = false;
            }
            else btn07.Enabled = false;

            *//**//*
            mahgd = "HGD08";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn08.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn08.BackColor = Color.Red;
                    }
                    else
                    {
                        btn08.BackColor = Color.Cyan;
                        btn08.Enabled = true;
                    }
                }
                else btn08.Enabled = false;
            }
            else btn08.Enabled = false;

            *//**//*
            mahgd = "HGD09";
            if (KiemTraTinhTrang(mahgd) == 1)
            {
                if (KiemTraHD(mahgd) == 1)
                {
                    btn09.Enabled = true;
                    time = GET_DATA_HD(mahgd).Tables["GETDATA"].Rows[0].ItemArray.GetValue(9).ToString();
                    if (DateTime.Parse(time).CompareTo(dateTime) <= 0 || KiemTraTinhTrangDien(mahgd) == 2 || KiemTraTinhTrangNuoc(mahgd) == 2)
                    {
                        btn09.BackColor = Color.Red;
                    }
                    else
                    {
                        btn09.BackColor = Color.Cyan;
                        btn09.Enabled = true;
                    }
                }
                else btn09.Enabled = false;
            }
            else btn09.Enabled = false;

        }*/
        public int KiemTraTinhTrang(string mahgd)
        {
            
            string sql = "SELECT * FROM HGD ";
            DataSet dataSet = ConnDB.get_data(sql, "HGD", null);
            for (int i = 0; i < dataSet.Tables["HGD"].Rows.Count; i++)
            {
                string MaHgd = dataSet.Tables["HGD"].Rows[i].ItemArray.GetValue(0).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    return 1;
                }

            }
            return 0;
        }
        public DataSet GET_DATA_HD(string mahgd)
        {

            string sql = "SELECT * FROM HOPDONG WHERE MAHGD = '"+mahgd+"' ";
            DataSet dataSet = ConnDB.get_data(sql, "GETDATA", null);
            return dataSet;
        }
        public int KiemTraHD(string mahgd)
        {

            string sql = "SELECT * FROM HOPDONG ";
            DataSet dataSet = ConnDB.get_data(sql, "HOPDONG", null);
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
            int dem = 0;
            string sql = "SELECT * FROM HOADONDIEN ";
            DataSet dataSet = ConnDB.get_data(sql, "HOADONDIEN", null);
            for(int i = 0; i < dataSet.Tables["HOADONDIEN"].Rows.Count; i++)
            {
                string Trangthai = dataSet.Tables["HOADONDIEN"].Rows[i].ItemArray.GetValue(12).ToString();
                string MaHgd = dataSet.Tables["HOADONDIEN"].Rows[i].ItemArray.GetValue(5).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    dem++;
                    if (Trangthai.Equals("Chưa đóng"))
                    {
                        dem++;
                    }
                }
                   
            }
            return dem;
        }
        public int KiemTraTinhTrangNuoc(string mahgd)
        {
            int dem = 0;
            string sql = "SELECT * FROM HOADONNUOC ";
            DataSet dataSet = ConnDB.get_data(sql, "HOADONNUOC", null);
            for (int i = 0; i < dataSet.Tables["HOADONNUOC"].Rows.Count; i++)
            {
                string Trangthai = dataSet.Tables["HOADONNUOC"].Rows[i].ItemArray.GetValue(12).ToString();
                string MaHgd = dataSet.Tables["HOADONNUOC"].Rows[i].ItemArray.GetValue(5).ToString();
                if (MaHgd.Equals(mahgd))
                {
                    dem++;
                    if (Trangthai.Equals("Chưa đóng"))
                    {
                        dem++;
                    }
                }

            }
            return dem;
        }

        private void btnQuanTK_Click(object sender, EventArgs e)
        {
            GUI.TAIKHOAN frmTK = new GUI.TAIKHOAN();
            this.Size = new Size(920, 630);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmTK.MdiParent = this.MdiParent;
            FullScreen(frmTK);
            frmTK.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            GUI.HGD frmHGD = new GUI.HGD();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHGD.MdiParent = this.MdiParent;
            FullScreen(frmHGD);
            frmHGD.Show();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GUI.HOPDONG frmHD = new GUI.HOPDONG();
            this.Size = new Size(930, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHD.MdiParent = this.MdiParent;
            FullScreen(frmHD);
            frmHD.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            GUI.CANHO frmCH = new GUI.CANHO();
            this.Size = new Size(930, 630);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmCH.MdiParent = this.MdiParent;
            FullScreen(frmCH);
            frmCH.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            GUI.NHANVIEN frmNV = new GUI.NHANVIEN();
            this.Size = new Size(930, 630);
            this.StartPosition = FormStartPosition.Manual;
            frmNV.MdiParent = this.MdiParent;
            FullScreen(frmNV);
            frmNV.Show();
        }
    }
}
