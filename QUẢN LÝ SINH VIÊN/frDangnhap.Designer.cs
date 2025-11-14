namespace QUẢN_LÝ_SINH_VIÊN
{
    partial class frDangnhap
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
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbhtmk = new System.Windows.Forms.CheckBox();
            this.LoiVaiTro = new System.Windows.Forms.Label();
            this.Thongbaoloi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVaitro = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDN
            // 
            this.txtTenDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDN.Location = new System.Drawing.Point(229, 174);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(316, 27);
            this.txtTenDN.TabIndex = 0;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatkhau.Location = new System.Drawing.Point(229, 216);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '•';
            this.txtMatkhau.Size = new System.Drawing.Size(316, 27);
            this.txtMatkhau.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";

            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";

            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangnhap.Location = new System.Drawing.Point(226, 299);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(130, 42);
            this.btnDangnhap.TabIndex = 2;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbhtmk);
            this.groupBox1.Controls.Add(this.LoiVaiTro);
            this.groupBox1.Controls.Add(this.Thongbaoloi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbVaitro);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangnhap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatkhau);
            this.groupBox1.Controls.Add(this.txtTenDN);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 367);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(211, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đăng nhập";
            // 
            // cbhtmk
            // 
            this.cbhtmk.AutoSize = true;
            this.cbhtmk.Location = new System.Drawing.Point(229, 269);
            this.cbhtmk.Name = "cbhtmk";
            this.cbhtmk.Size = new System.Drawing.Size(162, 24);
            this.cbhtmk.TabIndex = 10;
            this.cbhtmk.Text = "Hiển thị mật khẩu";
            this.cbhtmk.UseVisualStyleBackColor = true;
            this.cbhtmk.CheckedChanged += new System.EventHandler(this.cbhtmk_CheckedChanged);
            // 
            // LoiVaiTro
            // 
            this.LoiVaiTro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoiVaiTro.AutoSize = true;
            this.LoiVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoiVaiTro.ForeColor = System.Drawing.Color.Red;
            this.LoiVaiTro.Location = new System.Drawing.Point(38, 132);
            this.LoiVaiTro.Name = "LoiVaiTro";
            this.LoiVaiTro.Size = new System.Drawing.Size(35, 36);
            this.LoiVaiTro.TabIndex = 9;
            this.LoiVaiTro.Text = " *";
            // 
            // Thongbaoloi
            // 
            this.Thongbaoloi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thongbaoloi.AutoSize = true;
            this.Thongbaoloi.BackColor = System.Drawing.Color.Transparent;
            this.Thongbaoloi.ForeColor = System.Drawing.Color.Red;
            this.Thongbaoloi.Location = new System.Drawing.Point(222, 246);
            this.Thongbaoloi.Name = "Thongbaoloi";
            this.Thongbaoloi.Size = new System.Drawing.Size(323, 20);
            this.Thongbaoloi.TabIndex = 8;
            this.Thongbaoloi.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng nhập với tư cách";
            // 
            // cbVaitro
            // 
            this.cbVaitro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbVaitro.FormattingEnabled = true;
            this.cbVaitro.Items.AddRange(new string[] {
            "Sinh viên",
            "Giảng viên",
            "Quản trị"});
            this.cbVaitro.Location = new System.Drawing.Point(415, 132);
            this.cbVaitro.Name = "cbVaitro";
            this.cbVaitro.Size = new System.Drawing.Size(130, 28);
            this.cbVaitro.TabIndex = 6;

            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Location = new System.Drawing.Point(453, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 42);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(620, 468);
            this.Controls.Add(this.groupBox1);
            this.Name = "frDangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frDangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbVaitro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Thongbaoloi;
        private System.Windows.Forms.Label LoiVaiTro;
        private System.Windows.Forms.CheckBox cbhtmk;
        private System.Windows.Forms.Label label4;
    }
}

