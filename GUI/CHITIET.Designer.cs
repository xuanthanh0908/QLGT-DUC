
namespace BAOCAO.GUI
{
    partial class CHITIET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHITIET));
            this.label1 = new System.Windows.Forms.Label();
            this.LbHGD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTV = new System.Windows.Forms.DataGridView();
            this.MaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTV = new System.Windows.Forms.Button();
            this.btnHDDN = new System.Windows.Forms.Button();
            this.btnHDD = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.Lbcanhbao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(455, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN VỀ";
            // 
            // LbHGD
            // 
            this.LbHGD.AutoSize = true;
            this.LbHGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHGD.ForeColor = System.Drawing.Color.Red;
            this.LbHGD.Location = new System.Drawing.Point(685, 63);
            this.LbHGD.Name = "LbHGD";
            this.LbHGD.Size = new System.Drawing.Size(0, 32);
            this.LbHGD.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(84, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thành viên";
            // 
            // dgvTV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTV,
            this.TenTV,
            this.SDT,
            this.NgaySinh,
            this.MaHGD,
            this.SoCMND,
            this.Email,
            this.GioiTinh});
            this.dgvTV.Location = new System.Drawing.Point(6, 43);
            this.dgvTV.Name = "dgvTV";
            this.dgvTV.ReadOnly = true;
            this.dgvTV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTV.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvTV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTV.RowTemplate.Height = 28;
            this.dgvTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTV.Size = new System.Drawing.Size(1120, 222);
            this.dgvTV.TabIndex = 1;
            // 
            // MaTV
            // 
            this.MaTV.DataPropertyName = "MaTV";
            this.MaTV.HeaderText = "Mã thành viên";
            this.MaTV.MinimumWidth = 8;
            this.MaTV.Name = "MaTV";
            this.MaTV.ReadOnly = true;
            this.MaTV.Width = 132;
            // 
            // TenTV
            // 
            this.TenTV.DataPropertyName = "TenTV";
            this.TenTV.HeaderText = "Tên thành viên";
            this.TenTV.MinimumWidth = 8;
            this.TenTV.Name = "TenTV";
            this.TenTV.ReadOnly = true;
            this.TenTV.Width = 132;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 132;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 132;
            // 
            // MaHGD
            // 
            this.MaHGD.DataPropertyName = "MaHGD";
            this.MaHGD.HeaderText = "Mã hộ gia đình";
            this.MaHGD.MinimumWidth = 8;
            this.MaHGD.Name = "MaHGD";
            this.MaHGD.ReadOnly = true;
            this.MaHGD.Width = 132;
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.HeaderText = "CMND";
            this.SoCMND.MinimumWidth = 8;
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.ReadOnly = true;
            this.SoCMND.Width = 132;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 132;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 132;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnTV);
            this.groupBox2.Controls.Add(this.btnHDDN);
            this.groupBox2.Controls.Add(this.btnHDD);
            this.groupBox2.Controls.Add(this.btnHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(90, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1125, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(959, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(5);
            this.btnThoat.Size = new System.Drawing.Size(144, 62);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTV
            // 
            this.btnTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTV.ForeColor = System.Drawing.Color.Black;
            this.btnTV.Image = ((System.Drawing.Image)(resources.GetObject("btnTV.Image")));
            this.btnTV.Location = new System.Drawing.Point(738, 38);
            this.btnTV.Name = "btnTV";
            this.btnTV.Padding = new System.Windows.Forms.Padding(5);
            this.btnTV.Size = new System.Drawing.Size(200, 62);
            this.btnTV.TabIndex = 3;
            this.btnTV.Text = "QL Thành viên";
            this.btnTV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTV.UseVisualStyleBackColor = true;
            this.btnTV.Click += new System.EventHandler(this.btnTV_Click);
            // 
            // btnHDDN
            // 
            this.btnHDDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDDN.ForeColor = System.Drawing.Color.Black;
            this.btnHDDN.Image = ((System.Drawing.Image)(resources.GetObject("btnHDDN.Image")));
            this.btnHDDN.Location = new System.Drawing.Point(496, 38);
            this.btnHDDN.Name = "btnHDDN";
            this.btnHDDN.Padding = new System.Windows.Forms.Padding(5);
            this.btnHDDN.Size = new System.Drawing.Size(215, 62);
            this.btnHDDN.TabIndex = 2;
            this.btnHDDN.Text = "QL Hóa đơn nước";
            this.btnHDDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDDN.UseVisualStyleBackColor = true;
            this.btnHDDN.Click += new System.EventHandler(this.btnHDDN_Click);
            // 
            // btnHDD
            // 
            this.btnHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDD.ForeColor = System.Drawing.Color.Black;
            this.btnHDD.Image = ((System.Drawing.Image)(resources.GetObject("btnHDD.Image")));
            this.btnHDD.Location = new System.Drawing.Point(262, 38);
            this.btnHDD.Name = "btnHDD";
            this.btnHDD.Padding = new System.Windows.Forms.Padding(5);
            this.btnHDD.Size = new System.Drawing.Size(210, 62);
            this.btnHDD.TabIndex = 1;
            this.btnHDD.Text = "QL Hóa đơn điện";
            this.btnHDD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDD.UseVisualStyleBackColor = true;
            this.btnHDD.Click += new System.EventHandler(this.btnHDD_Click);
            // 
            // btnHD
            // 
            this.btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.ForeColor = System.Drawing.Color.Black;
            this.btnHD.Image = ((System.Drawing.Image)(resources.GetObject("btnHD.Image")));
            this.btnHD.Location = new System.Drawing.Point(31, 38);
            this.btnHD.Name = "btnHD";
            this.btnHD.Padding = new System.Windows.Forms.Padding(5);
            this.btnHD.Size = new System.Drawing.Size(200, 62);
            this.btnHD.TabIndex = 0;
            this.btnHD.Text = "QL Hợp đồng";
            this.btnHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // Lbcanhbao
            // 
            this.Lbcanhbao.AutoSize = true;
            this.Lbcanhbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbcanhbao.ForeColor = System.Drawing.Color.Red;
            this.Lbcanhbao.Location = new System.Drawing.Point(96, 608);
            this.Lbcanhbao.Name = "Lbcanhbao";
            this.Lbcanhbao.Size = new System.Drawing.Size(0, 25);
            this.Lbcanhbao.TabIndex = 5;
            // 
            // CHITIET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1262, 676);
            this.Controls.Add(this.Lbcanhbao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbHGD);
            this.Controls.Add(this.label1);
            this.Name = "CHITIET";
            this.Text = "CHITIET";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbHGD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Button btnHDDN;
        private System.Windows.Forms.Button btnHDD;
        private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Label Lbcanhbao;
        private System.Windows.Forms.DataGridView dgvTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
    }
}