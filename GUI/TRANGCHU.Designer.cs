
namespace BAOCAO.GUI
{
    partial class TRANGCHU
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQuanTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(726, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 84);
            this.button5.TabIndex = 13;
            this.button5.Text = "Quản lý nhân viên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 84);
            this.button4.TabIndex = 12;
            this.button4.Text = "Quản lý gói tập";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(833, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 84);
            this.button3.TabIndex = 11;
            this.button3.Text = "Quản lý hợp đồng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(547, 288);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(183, 84);
            this.btnQLKH.TabIndex = 10;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQuanTK
            // 
            this.btnQuanTK.Location = new System.Drawing.Point(276, 288);
            this.btnQuanTK.Name = "btnQuanTK";
            this.btnQuanTK.Size = new System.Drawing.Size(183, 84);
            this.btnQuanTK.TabIndex = 9;
            this.btnQuanTK.Text = "Quản lý tài khoản";
            this.btnQuanTK.UseVisualStyleBackColor = true;
            this.btnQuanTK.Click += new System.EventHandler(this.btnQuanTK_Click);
            // 
            // TRANGCHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 807);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btnQuanTK);
            this.DoubleBuffered = true;
            this.Name = "TRANGCHU";
            this.Text = "TRANGCHU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQuanTK;
    }
}