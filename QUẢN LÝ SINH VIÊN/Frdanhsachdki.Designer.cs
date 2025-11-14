namespace QUẢN_LÝ_SINH_VIÊN
{
    partial class Frdanhsachdki
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
            this.components = new System.ComponentModel.Container();
            this.dgvdsdk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.qLSinhVienDataSet3 = new QUẢN_LÝ_SINH_VIÊN.QLSinhVienDataSet3();
            this.danhsachdkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.danhsachdkiTableAdapter = new QUẢN_LÝ_SINH_VIÊN.QLSinhVienDataSet3TableAdapters.DanhsachdkiTableAdapter();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongMonDaHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachdkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdsdk
            // 
            this.dgvdsdk.AutoGenerateColumns = false;
            this.dgvdsdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsdk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSSVDataGridViewTextBoxColumn,
            this.tenSinhVienDataGridViewTextBoxColumn,
            this.soLuongMonDaHocDataGridViewTextBoxColumn});
            this.dgvdsdk.DataSource = this.danhsachdkiBindingSource;
            this.dgvdsdk.Location = new System.Drawing.Point(51, 109);
            this.dgvdsdk.Name = "dgvdsdk";
            this.dgvdsdk.RowTemplate.Height = 24;
            this.dgvdsdk.Size = new System.Drawing.Size(484, 267);
            this.dgvdsdk.TabIndex = 0;
            this.dgvdsdk.DataSourceChanged += new System.EventHandler(this.frdanhsachdki_Load_1);
            this.dgvdsdk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsdk_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(225, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đăng kí";
            // 
            // qLSinhVienDataSet3
            // 
            this.qLSinhVienDataSet3.DataSetName = "QLSinhVienDataSet3";
            this.qLSinhVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // danhsachdkiBindingSource
            // 
            this.danhsachdkiBindingSource.DataMember = "Danhsachdki";
            this.danhsachdkiBindingSource.DataSource = this.qLSinhVienDataSet3;
            // 
            // danhsachdkiTableAdapter
            // 
            this.danhsachdkiTableAdapter.ClearBeforeFill = true;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            // 
            // tenSinhVienDataGridViewTextBoxColumn
            // 
            this.tenSinhVienDataGridViewTextBoxColumn.DataPropertyName = "TenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.HeaderText = "TenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.Name = "tenSinhVienDataGridViewTextBoxColumn";
            // 
            // soLuongMonDaHocDataGridViewTextBoxColumn
            // 
            this.soLuongMonDaHocDataGridViewTextBoxColumn.DataPropertyName = "SoLuongMonDaHoc";
            this.soLuongMonDaHocDataGridViewTextBoxColumn.HeaderText = "SoLuongMonDaHoc";
            this.soLuongMonDaHocDataGridViewTextBoxColumn.Name = "soLuongMonDaHocDataGridViewTextBoxColumn";
            // 
            // Frdanhsachdki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdsdk);
            this.Name = "Frdanhsachdki";
            this.Text = "Frdanhsachdki";
            this.Load += new System.EventHandler(this.Frdanhsachdki_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsdk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachdkiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsdk;
        private System.Windows.Forms.Label label1;
        private QLSinhVienDataSet3 qLSinhVienDataSet3;
        private System.Windows.Forms.BindingSource danhsachdkiBindingSource;
        private QLSinhVienDataSet3TableAdapters.DanhsachdkiTableAdapter danhsachdkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongMonDaHocDataGridViewTextBoxColumn;
    }
}