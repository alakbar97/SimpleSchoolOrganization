using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolForm
{
    public partial class Teachers : Form
    {
        string str = @"Data Source=CAPR0\PLUTOSQL ; Initial Catalog = SchoolDb; Integrated Security= true;";
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            DataTable subjectData = new DataTable();
           using( SqlConnection sqlConnection = new SqlConnection(str))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM SUBJECT",sqlConnection))
                {
                    using (SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand))
                    {
                        sqlData.Fill(subjectData);
                    }
                }
            }

            cmx_Subject.DataSource = subjectData;
            cmx_Subject.DisplayMember = "Name";
            cmx_Subject.ValueMember = "Id";
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(str))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand($"INSERT INTO TEACHER (Name,Surname,SubjectId) " +
                    $"VALUES('{txbx_Name.Text}','{txbx_surname.Text}','{cmx_Subject.SelectedValue}')",sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Succesfully added");
                }
            }
            txbx_Name.Text = String.Empty;
            txbx_surname.Text = String.Empty;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }
    }
}
