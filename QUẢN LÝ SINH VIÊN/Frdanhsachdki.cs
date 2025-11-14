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

namespace QUẢN_LÝ_SINH_VIÊN
{
    public partial class Frdanhsachdki : Form
    {
        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public Frdanhsachdki()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM Danhsachdki ";
            command.CommandText = "SELECT SinhVien.MaSV, SinhVien.TenSV, MonHoc.TenMon " +
                                  "FROM Danhsachdki " +
                                  "INNER JOIN SinhVien ON Danhsachdki.MaSV = SinhVien.MaSV " +
                                  "INNER JOIN MonHoc ON Danhsachdki.MaMon = MonHoc.MaMon";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvdsdk.DataSource = table;
        }
        private void frdanhsachdki_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conStr);
            connection.Open();
            dgvdsdk.ReadOnly = true;
            loaddata();
        }
        private void frdanhsachdki_Load_1(object sender, EventArgs e)
        {
           
            if (connection == null)
            {
                connection = new SqlConnection(Program.conStr);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            dgvdsdk.ReadOnly = true;
            loaddata();
        }

        private void frdanhsachdki_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void Frdanhsachdki_Load_2(object sender, EventArgs e)
        {
           
            this.danhsachdkiTableAdapter.Fill(this.qLSinhVienDataSet3.Danhsachdki);
            

        }

        private void dgvdsdk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = @"
        SELECT SinhVien.MaSV, SinhVien.TenSV, MonHoc.TenMon
        FROM Danhsachdki
        INNER JOIN SinhVien ON Danhsachdki.MaSV = SinhVien.MaSV
        INNER JOIN MonHoc ON Danhsachdki.MaMon = MonHoc.MaMon ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvdsdk.DataSource = table;
        }
    }
}
