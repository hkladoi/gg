namespace _3.PL.Views
{
    partial class FrmKhachHang
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
            this.dtg_Show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TenDem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tb_timKiem = new System.Windows.Forms.TextBox();
            this.dtg_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Show
            // 
            this.dtg_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Show.Location = new System.Drawing.Point(39, 285);
            this.dtg_Show.Name = "dtg_Show";
            this.dtg_Show.RowTemplate.Height = 25;
            this.dtg_Show.Size = new System.Drawing.Size(628, 263);
            this.dtg_Show.TabIndex = 0;
            this.dtg_Show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Show_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(214, 69);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(100, 23);
            this.tb_ma.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(592, 81);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_Ten
            // 
            this.tb_Ten.Location = new System.Drawing.Point(214, 117);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(100, 23);
            this.tb_Ten.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // tb_ho
            // 
            this.tb_ho.Location = new System.Drawing.Point(421, 81);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(100, 23);
            this.tb_ho.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ";
            // 
            // tb_TenDem
            // 
            this.tb_TenDem.Location = new System.Drawing.Point(214, 164);
            this.tb_TenDem.Name = "tb_TenDem";
            this.tb_TenDem.Size = new System.Drawing.Size(100, 23);
            this.tb_TenDem.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đệm";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(421, 130);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(100, 23);
            this.tb_diachi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(592, 178);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "Hiển thị";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(592, 124);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.Location = new System.Drawing.Point(486, 256);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Size = new System.Drawing.Size(181, 23);
            this.tb_timKiem.TabIndex = 14;
            // 
            // dtg_ngaysinh
            // 
            this.dtg_ngaysinh.Location = new System.Drawing.Point(129, 213);
            this.dtg_ngaysinh.Name = "dtg_ngaysinh";
            this.dtg_ngaysinh.Size = new System.Drawing.Size(200, 23);
            this.dtg_ngaysinh.TabIndex = 15;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(456, 195);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 578);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dtg_ngaysinh);
            this.Controls.Add(this.tb_timKiem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_ho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_TenDem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_Show);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TenDem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox tb_timKiem;
        private System.Windows.Forms.DateTimePicker dtg_ngaysinh;
        private System.Windows.Forms.Button btn_sua;
    }
}