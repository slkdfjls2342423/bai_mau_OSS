namespace QUẢN_LÝ_SINH_VIÊN
{
    partial class frQuantri
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvQuantri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtDiem1 = new System.Windows.Forms.TextBox();
            this.txtDiem2 = new System.Windows.Forms.TextBox();
            this.txtDiem3 = new System.Windows.Forms.TextBox();
            this.btnDangxuat2 = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbtieuchisx = new System.Windows.Forms.ComboBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txttimMSSV = new System.Windows.Forms.TextBox();
            this.cbTimkiem = new System.Windows.Forms.CheckBox();
            this.cbTimtheolop = new System.Windows.Forms.CheckBox();
            this.cbTimtheoMSSV = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btntt = new System.Windows.Forms.Button();
            this.btnttgv = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantri)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnThem.Location = new System.Drawing.Point(789, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnXoa.Location = new System.Drawing.Point(789, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSua.Location = new System.Drawing.Point(789, 162);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 38);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQuantri);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvQuantri
            // 
            this.dgvQuantri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantri.Location = new System.Drawing.Point(12, 21);
            this.dgvQuantri.Name = "dgvQuantri";
            this.dgvQuantri.RowTemplate.Height = 24;
            this.dgvQuantri.Size = new System.Drawing.Size(1149, 327);
            this.dgvQuantri.TabIndex = 0;
            this.dgvQuantri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgvQuantri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm môn 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điểm môn 3";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(118, 127);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(122, 24);
            this.cbGioitinh.TabIndex = 12;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(118, 16);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(185, 22);
            this.txtMSSV.TabIndex = 13;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(118, 53);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(185, 22);
            this.txtTenSV.TabIndex = 14;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(118, 90);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(185, 22);
            this.txtLop.TabIndex = 15;
            // 
            // txtDiem1
            // 
            this.txtDiem1.Location = new System.Drawing.Point(515, 16);
            this.txtDiem1.Name = "txtDiem1";
            this.txtDiem1.Size = new System.Drawing.Size(100, 22);
            this.txtDiem1.TabIndex = 16;
            // 
            // txtDiem2
            // 
            this.txtDiem2.Location = new System.Drawing.Point(515, 51);
            this.txtDiem2.Name = "txtDiem2";
            this.txtDiem2.Size = new System.Drawing.Size(100, 22);
            this.txtDiem2.TabIndex = 17;
            // 
            // txtDiem3
            // 
            this.txtDiem3.Location = new System.Drawing.Point(515, 90);
            this.txtDiem3.Name = "txtDiem3";
            this.txtDiem3.Size = new System.Drawing.Size(100, 22);
            this.txtDiem3.TabIndex = 18;
            // 
            // btnDangxuat2
            // 
            this.btnDangxuat2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangxuat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDangxuat2.Location = new System.Drawing.Point(1081, 222);
            this.btnDangxuat2.Name = "btnDangxuat2";
            this.btnDangxuat2.Size = new System.Drawing.Size(108, 40);
            this.btnDangxuat2.TabIndex = 19;
            this.btnDangxuat2.Text = "Đăng xuất";
            this.btnDangxuat2.UseVisualStyleBackColor = false;
            this.btnDangxuat2.Click += new System.EventHandler(this.btnDangxuat2_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoitao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnKhoitao.Location = new System.Drawing.Point(789, 223);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(86, 38);
            this.btnKhoitao.TabIndex = 20;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = false;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(456, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "THÔNG TIN SINH VIÊN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbtieuchisx);
            this.groupBox2.Controls.Add(this.btntim);
            this.groupBox2.Controls.Add(this.txttimMSSV);
            this.groupBox2.Controls.Add(this.cbTimkiem);
            this.groupBox2.Controls.Add(this.cbTimtheolop);
            this.groupBox2.Controls.Add(this.cbTimtheoMSSV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMSSV);
            this.groupBox2.Controls.Add(this.txtDiem3);
            this.groupBox2.Controls.Add(this.txtTenSV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDiem2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiem1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.cbLop);
            this.groupBox2.Controls.Add(this.cbGioitinh);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 236);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sắp xếp dữ liệu";
            // 
            // cbtieuchisx
            // 
            this.cbtieuchisx.FormattingEnabled = true;
            this.cbtieuchisx.Items.AddRange(new object[] {
            "Tên Sinh Viên",
            "MSSV",
            "Lớp",
            "Điểm TB"});
            this.cbtieuchisx.Location = new System.Drawing.Point(118, 167);
            this.cbtieuchisx.Name = "cbtieuchisx";
            this.cbtieuchisx.Size = new System.Drawing.Size(122, 24);
            this.cbtieuchisx.TabIndex = 27;
            this.cbtieuchisx.SelectedIndexChanged += new System.EventHandler(this.cbtieuchisx_SelectedIndexChanged);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(649, 160);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(60, 26);
            this.btntim.TabIndex = 26;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttimMSSV
            // 
            this.txttimMSSV.Location = new System.Drawing.Point(515, 162);
            this.txttimMSSV.Name = "txttimMSSV";
            this.txttimMSSV.Size = new System.Drawing.Size(110, 22);
            this.txttimMSSV.TabIndex = 25;
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.AutoSize = true;
            this.cbTimkiem.Location = new System.Drawing.Point(385, 135);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(145, 21);
            this.cbTimkiem.TabIndex = 24;
            this.cbTimkiem.Text = "Tìm kiếm thông tin";
            this.cbTimkiem.UseVisualStyleBackColor = true;
            this.cbTimkiem.CheckedChanged += new System.EventHandler(this.cbTimkiem_CheckedChanged);
            // 
            // cbTimtheolop
            // 
            this.cbTimtheolop.AutoSize = true;
            this.cbTimtheolop.Location = new System.Drawing.Point(385, 199);
            this.cbTimtheolop.Name = "cbTimtheolop";
            this.cbTimtheolop.Size = new System.Drawing.Size(108, 21);
            this.cbTimtheolop.TabIndex = 24;
            this.cbTimtheolop.Text = "Tìm theo lớp";
            this.cbTimtheolop.UseVisualStyleBackColor = true;
            this.cbTimtheolop.CheckedChanged += new System.EventHandler(this.cbTimtheolop_CheckedChanged);
            // 
            // cbTimtheoMSSV
            // 
            this.cbTimtheoMSSV.AutoSize = true;
            this.cbTimtheoMSSV.Location = new System.Drawing.Point(385, 164);
            this.cbTimtheoMSSV.Name = "cbTimtheoMSSV";
            this.cbTimtheoMSSV.Size = new System.Drawing.Size(127, 21);
            this.cbTimtheoMSSV.TabIndex = 23;
            this.cbTimtheoMSSV.Text = "Tìm theo MSSV";
            this.cbTimtheoMSSV.UseVisualStyleBackColor = true;
            this.cbTimtheoMSSV.CheckedChanged += new System.EventHandler(this.cbTimtheoMSSV_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên sinh viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Điểm môn 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giới tính";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(515, 199);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(110, 24);
            this.cbLop.TabIndex = 12;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btntt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.Location = new System.Drawing.Point(127, 31);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(101, 37);
            this.btntt.TabIndex = 23;
            this.btntt.Text = "Sinh viên";
            this.btntt.UseVisualStyleBackColor = false;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnttgv
            // 
            this.btnttgv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnttgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnttgv.Location = new System.Drawing.Point(6, 31);
            this.btnttgv.Name = "btnttgv";
            this.btnttgv.Size = new System.Drawing.Size(101, 37);
            this.btnttgv.TabIndex = 24;
            this.btnttgv.Text = "Giảng viên";
            this.btnttgv.UseVisualStyleBackColor = false;
            this.btnttgv.Click += new System.EventHandler(this.btnttgv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnttgv);
            this.groupBox3.Controls.Add(this.btntt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox3.Location = new System.Drawing.Point(955, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 90);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý tài khoản";
            // 
            // frQuantri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1221, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKhoitao);
            this.Controls.Add(this.btnDangxuat2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frQuantri";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frQuantri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiem1;
        private System.Windows.Forms.TextBox txtDiem2;
        private System.Windows.Forms.TextBox txtDiem3;
        private System.Windows.Forms.Button btnDangxuat2;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.DataGridView dgvQuantri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btnttgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttimMSSV;
        private System.Windows.Forms.CheckBox cbTimtheolop;
        private System.Windows.Forms.CheckBox cbTimtheoMSSV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.CheckBox cbTimkiem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ComboBox cbtieuchisx;
        private System.Windows.Forms.Label label2;
    }
}