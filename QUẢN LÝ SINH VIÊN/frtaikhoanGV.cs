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
    public partial class frtaikhoanGV : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Lecturers"; 
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvtkgv.DataSource = table; 
        }
    
        public frtaikhoanGV()
        {
            InitializeComponent();
        }
        private void frtaikhoanGV_Load(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(Program.conStr);
            }
           
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            
            loaddata();

        }
        private void frThongtintaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dgvtkgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvtkgv.CurrentRow.Index;
            if (i >= 0)
            {
                txtlecturerid.Text = dgvtkgv.Rows[i].Cells[0].Value.ToString();
                txtusername.Text = dgvtkgv.Rows[i].Cells[1].Value.ToString();
                txtpassword.Text = dgvtkgv.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void frtaikhoanGV_Load_1(object sender, EventArgs e)
        {
            this.lecturersTableAdapter.Fill(this.qLSinhVienDataSet2.Lecturers);
            if (connection == null)
            {
                connection = new SqlConnection(Program.conStr);
            }

          
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {          
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Lecturers (Username, Password) VALUES ( @Username, @Password)";           
            command.Parameters.AddWithValue("@Username", txtusername.Text);
            command.Parameters.AddWithValue("@Password", txtpassword.Text);           
            command.ExecuteNonQuery();          
            loaddata();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
          
                txtlecturerid.Text = "";
                txtusername.Text = "";
                txtpassword.Text = "";
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            string query = "UPDATE Lecturers SET Username = @Username, Password = @Password WHERE LecturerID = @LecturerID";
            command = new SqlCommand(query, connection);

           
            command.Parameters.AddWithValue("@LecturerID", txtlecturerid.Text);
            command.Parameters.AddWithValue("@Username", txtusername.Text);
            command.Parameters.AddWithValue("@Password", txtpassword.Text);
            command.ExecuteNonQuery();
            loaddata(); 
            MessageBox.Show("Sửa thông tin thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Lecturers WHERE LecturerID ='" + txtlecturerid.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
