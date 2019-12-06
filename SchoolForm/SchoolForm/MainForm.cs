using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string str = @"Data Source=CAPR0\PLUTOSQL;Initial catalog=SchoolDb;integrated security=true;";

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable ClassTable = new DataTable();

            using (SqlConnection sql = new SqlConnection(str))
            {
                sql.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Class", sql))
                {
                    using (SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand))
                    {
                        sqlData.Fill(ClassTable);
                    }
                }
            }
            comboBox1.DataSource = ClassTable;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            DataTable SubjectTable = new DataTable();
            using (SqlConnection sql = new SqlConnection(str))
            {
                sql.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Subject", sql))
                {
                    using (SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand))
                    {
                        sqlData.Fill(SubjectTable);
                    }
                }
            }
            comboBox2.DataSource = SubjectTable;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(str))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO LESSONCLASS (ClassId,SubjectId)" +
                    $"VALUES('{comboBox1.SelectedValue}','{comboBox2.SelectedValue}')", sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();

                }

            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.ShowDialog();

        }
    }
}
