
namespace BAOCAO.GUI
{
    partial class TKNUOC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKNUOC));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.MaHDNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBthang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(45, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chung cư Thanh Hà ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(439, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "THỐNG KÊ TIỀN NƯỚC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(52, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 437);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả thống kê";
            // 
            // dgvHDN
            // 
            this.dgvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDNuoc,
            this.TenHD,
            this.MaNV,
            this.TenNV,
            this.NgayIn,
            this.MaHGD,
            this.TenChuHo,
            this.MaCH,
            this.LoaiCanHo,
            this.SoKhoi,
            this.DonGia,
            this.TongTien,
            this.TrangThai});
            this.dgvHDN.Location = new System.Drawing.Point(6, 103);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.ReadOnly = true;
            this.dgvHDN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDN.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDN.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvHDN.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHDN.RowTemplate.Height = 28;
            this.dgvHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDN.Size = new System.Drawing.Size(1228, 328);
            this.dgvHDN.TabIndex = 2;
            // 
            // MaHDNuoc
            // 
            this.MaHDNuoc.DataPropertyName = "MaHDNuoc";
            this.MaHDNuoc.HeaderText = "Mã hóa đơn";
            this.MaHDNuoc.MinimumWidth = 8;
            this.MaHDNuoc.Name = "MaHDNuoc";
            this.MaHDNuoc.ReadOnly = true;
            this.MaHDNuoc.Width = 149;
            // 
            // TenHD
            // 
            this.TenHD.DataPropertyName = "TenHD";
            this.TenHD.HeaderText = "Tên hóa đơn";
            this.TenHD.MinimumWidth = 8;
            this.TenHD.Name = "TenHD";
            this.TenHD.ReadOnly = true;
            this.TenHD.Width = 156;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 163;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 170;
            // 
            // NgayIn
            // 
            this.NgayIn.DataPropertyName = "NgayIn";
            this.NgayIn.HeaderText = "Ngày in";
            this.NgayIn.MinimumWidth = 8;
            this.NgayIn.Name = "NgayIn";
            this.NgayIn.ReadOnly = true;
            this.NgayIn.Width = 112;
            // 
            // MaHGD
            // 
            this.MaHGD.DataPropertyName = "MaHGD";
            this.MaHGD.HeaderText = "Mã hộ gia đình";
            this.MaHGD.MinimumWidth = 8;
            this.MaHGD.Name = "MaHGD";
            this.MaHGD.ReadOnly = true;
            this.MaHGD.Width = 137;
            // 
            // TenChuHo
            // 
            this.TenChuHo.DataPropertyName = "TenChuHo";
            this.TenChuHo.HeaderText = "Tên chủ hộ";
            this.TenChuHo.MinimumWidth = 8;
            this.TenChuHo.Name = "TenChuHo";
            this.TenChuHo.ReadOnly = true;
            this.TenChuHo.Width = 123;
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã căn hộ";
            this.MaCH.MinimumWidth = 8;
            this.MaCH.Name = "MaCH";
            this.MaCH.ReadOnly = true;
            this.MaCH.Width = 116;
            // 
            // LoaiCanHo
            // 
            this.LoaiCanHo.DataPropertyName = "LoaiCanHo";
            this.LoaiCanHo.HeaderText = "Loại căn hộ";
            this.LoaiCanHo.MinimumWidth = 8;
            this.LoaiCanHo.Name = "LoaiCanHo";
            this.LoaiCanHo.ReadOnly = true;
            this.LoaiCanHo.Width = 125;
            // 
            // SoKhoi
            // 
            this.SoKhoi.DataPropertyName = "SoKhoi";
            this.SoKhoi.HeaderText = "Số khối";
            this.SoKhoi.MinimumWidth = 8;
            this.SoKhoi.Name = "SoKhoi";
            this.SoKhoi.ReadOnly = true;
            this.SoKhoi.Width = 112;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 87;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 128;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 134;
            // 
            // CBthang
            // 
            this.CBthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBthang.ForeColor = System.Drawing.Color.Black;
            this.CBthang.FormattingEnabled = true;
            this.CBthang.Items.AddRange(new object[] {
            "Chọn",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13"});
            this.CBthang.Location = new System.Drawing.Point(326, 48);
            this.CBthang.Name = "CBthang";
            this.CBthang.Size = new System.Drawing.Size(91, 33);
            this.CBthang.TabIndex = 7;
            this.CBthang.SelectedIndexChanged += new System.EventHandler(this.CBthang_SelectedIndexChanged);
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.ForeColor = System.Drawing.Color.Black;
            this.txtNam.Location = new System.Drawing.Point(326, 110);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(91, 30);
            this.txtNam.TabIndex = 6;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(227, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // btnNam
            // 
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.ForeColor = System.Drawing.Color.Black;
            this.btnNam.Image = ((System.Drawing.Image)(resources.GetObject("btnNam.Image")));
            this.btnNam.Location = new System.Drawing.Point(951, 50);
            this.btnNam.Name = "btnNam";
            this.btnNam.Padding = new System.Windows.Forms.Padding(5);
            this.btnNam.Size = new System.Drawing.Size(271, 86);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Thống kê theo năm";
            this.btnNam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnThang
            // 
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThang.ForeColor = System.Drawing.Color.Black;
            this.btnThang.Image = ((System.Drawing.Image)(resources.GetObject("btnThang.Image")));
            this.btnThang.Location = new System.Drawing.Point(643, 50);
            this.btnThang.Name = "btnThang";
            this.btnThang.Padding = new System.Windows.Forms.Padding(5);
            this.btnThang.Size = new System.Drawing.Size(271, 86);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Thống kê theo tháng";
            this.btnThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBthang);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNam);
            this.groupBox1.Controls.Add(this.btnThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(52, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // TKNUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 770);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TKNUOC";
            this.Text = "TKNUOC";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.ComboBox CBthang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}