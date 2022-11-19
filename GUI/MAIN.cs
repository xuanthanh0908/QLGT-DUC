using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOCAO.GUI
{
    public partial class MAIN : Form
    {
        string TK = "";
        string MK = "";
        ConnectToDB conDB = new ConnectToDB();
        public MAIN(string tk, string mk)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Load_Main();
            TK = tk;
            MK = mk;
        }
        public int CheckQuyen()
        {
            int dem = 0;
            string query = "select Quyen from TAIKHOAN where TaiKhoan = @tk and MatKhau = @mk";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@tk", TK));
            parameters.Add(new SqlParameter("@mk", MK));
            DataSet data = conDB.get_data(query, "TK", parameters);
            if (data.Tables["TK"].Rows[0].ItemArray.GetValue(0).Equals("admin"))
                dem++;
            return dem;
        }
        public void FullScreen(Form a)
        {
            a.Dock = DockStyle.Fill;
            a.MaximizeBox = false;
            a.MinimizeBox = false;
            a.ControlBox = false;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void quảnLýHộGiaĐìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.HGD frmHGD = new GUI.HGD();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHGD.MdiParent = this;
            FullScreen(frmHGD);
            frmHGD.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.NHANVIEN frmNV = new GUI.NHANVIEN();
            this.Size = new Size(930, 630);
            this.StartPosition = FormStartPosition.Manual;
            frmNV.MdiParent = this;
            FullScreen(frmNV);
            frmNV.Show();
        }

        private void quảnLýCănHộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.CANHO frmCH = new GUI.CANHO();
            this.Size = new Size(930, 630);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmCH.MdiParent = this;
            FullScreen(frmCH);
            frmCH.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckQuyen() == 1)
            {
                GUI.TAIKHOAN frmTK = new GUI.TAIKHOAN();
                this.Size = new Size(920, 630);
                this.StartPosition = FormStartPosition.CenterScreen;
                frmTK.MdiParent = this;
                FullScreen(frmTK);
                frmTK.Show();
            }
            else
            {
                MessageBox.Show("Chức năng này dành cho quản lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.DICHVU frmDV = new GUI.DICHVU();
            this.Size = new Size(885, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmDV.MdiParent = this;
            FullScreen(frmDV);
            frmDV.Show();
        }

        private void quảnLýThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.THANHVIEN frmTV = new GUI.THANHVIEN();
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmTV.MdiParent = this;
            FullScreen(frmTV);
            frmTV.Show();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.HOPDONG frmHD = new GUI.HOPDONG();
            this.Size = new Size(930, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHD.MdiParent = this;
            FullScreen(frmHD);
            frmHD.Show();
        }

        private void quảnLýHóaĐơnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.HOADONDIEN frmHDD = new GUI.HOADONDIEN();
            this.Size = new Size(1150, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHDD.MdiParent = this;
            FullScreen(frmHDD);
            frmHDD.Show();
        }

        private void quảnLýHóaĐơnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.HOADONNUOC frmHDNC = new GUI.HOADONNUOC();
            this.Size = new Size(1150, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHDNC.MdiParent = this;
            FullScreen(frmHDNC);
            frmHDNC.Show();
        }

        private void thốngKêHóaĐơnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.TKDIEN frmTKHD = new GUI.TKDIEN();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmTKHD.MdiParent = this;
            FullScreen(frmTKHD);
            frmTKHD.Show();
        }

        private void thốngKêHóaĐơnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.TKNUOC frmTKHDN = new GUI.TKNUOC();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmTKHDN.MdiParent = this;
            FullScreen(frmTKHDN);
            frmTKHDN.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.XEMHOADON frmHD = new GUI.XEMHOADON();
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHD.MdiParent = this;
            FullScreen(frmHD);
            frmHD.Show();
        }
        public void Load_Main()
        {
            GUI.TRANGCHU frMain = new GUI.TRANGCHU();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frMain.MdiParent = this;
            FullScreen(frMain);
            frMain.Show();
        }

        private void toolbtnDN_Click(object sender, EventArgs e)
        {
            Load_Main();
        }

        private void toolbtnHGD_Click(object sender, EventArgs e)
        {
            GUI.HGD frmHGD = new GUI.HGD();
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHGD.MdiParent = this;
            FullScreen(frmHGD);
            frmHGD.Show();
        }

        private void toolbtnHD_Click(object sender, EventArgs e)
        {
            GUI.HOPDONG frmHD = new GUI.HOPDONG();
            this.Size = new Size(930, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmHD.MdiParent = this;
            FullScreen(frmHD);
            frmHD.Show();
        }

        private void toolbtnNV_Click(object sender, EventArgs e)
        {
            if (CheckQuyen() == 1)
            {
                GUI.NHANVIEN frmNV = new GUI.NHANVIEN();
                this.Size = new Size(930, 630);
                this.StartPosition = FormStartPosition.Manual;
                frmNV.MdiParent = this;
                FullScreen(frmNV);
                frmNV.Show();
            }
            else
            {
                MessageBox.Show("Chức năng này dành cho quản lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolbtnTK_Click(object sender, EventArgs e)
        {
            if (CheckQuyen() == 1)
            {
                GUI.TAIKHOAN frmTK = new GUI.TAIKHOAN();
                this.Size = new Size(920, 630);
                this.StartPosition = FormStartPosition.CenterScreen;
                frmTK.MdiParent = this;
                FullScreen(frmTK);
                frmTK.Show();
            }
            else
            {
                MessageBox.Show("Chức năng này dành cho quản lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolbtnDN_Click_1(object sender, EventArgs e)
        {
            Form1 frLOGIN = new Form1("","");
            frLOGIN.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frLOGIN = new Form1("", "");
            frLOGIN.Show();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frLOGIN = new Form1("xuanthanh", "123");
            frLOGIN.Show();
            this.Close();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GUI.CANHO frmCH = new GUI.CANHO();
            this.Size = new Size(930, 630);
            this.StartPosition = FormStartPosition.CenterScreen;
            frmCH.MdiParent = this;
            FullScreen(frmCH);
            frmCH.Show();
        }
    }
}
