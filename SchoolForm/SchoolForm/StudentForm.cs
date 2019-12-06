using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class StudentForm : Form
    {
        string str = @"Data Source=CAPR0\PLUTOSQL ; Initial Catalog = SchoolDb; Integrated Security= true;";
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            DataTable ClassTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(str))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Class", sqlConnection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        adapter.Fill(ClassTable);
                    }
                }
            }
            cmbc_Class.DataSource = ClassTable;
            cmbc_Class.DisplayMember = "Name";
            cmbc_Class.ValueMember = "Id";
        }

        private void cmbc_Class_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbc_Class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string conStr = @"Data Source=CAPR0\PLUTOSQL;Initial Catalog=SchoolDb;Integrated Security=true;";
            string num = ((ComboBox)sender).SelectedValue.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand($"SELECT DISTINCT S.Name,S.Id FROM Class AS C INNER JOIN LESSONCLASS AS L ON L.ClassId = {num}" +
                    " INNER JOIN Subject AS S ON s.Id = L.SubjectId", sqlConnection))
                {
                    using (SqlDataAdapter sqlData = new SqlDataAdapter(command))
                    {
                        sqlData.Fill(data);
                        cmbx_Subject.DataSource = data;
                        cmbx_Subject.DisplayMember = "Name";
                        cmbx_Subject.ValueMember = "Id";
                        cmbx_Teacher.DataSource = null;
                    }
                }
            }
        }

        private void cmbx_Subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string conStr = @"Data Source=CAPR0\PLUTOSQL;Initial Catalog=SchoolDb;Integrated Security=true;";
            string num = ((ComboBox)sender).SelectedValue.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand($"SELECT DISTINCT T.Name+' '+T.Surname AS 'Name Surname'  FROM Subject s " +
                    $"JOIN Teacher T ON T.SubjectId={num}", sqlConnection))
                {
                    using (SqlDataAdapter sqlData = new SqlDataAdapter(command))
                    {
                        sqlData.Fill(data);
                        cmbx_Teacher.DataSource = data;
                        cmbx_Teacher.DisplayMember = "Name Surname";
                    }
                }
            }
        }
    }
}
