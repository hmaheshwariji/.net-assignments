using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BENI1J9G\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student_table", sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BENI1J9G\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into student_table values(@stid,@name,@course,@marks)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@stid", textBox7.Text);
            sqlCommand.Parameters.AddWithValue("@name", textBox8.Text);
            sqlCommand.Parameters.AddWithValue("@course", textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@marks", textBox6.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BENI1J9G\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE student_table SET Sname = @name, course = @course, marks = @marks WHERE studentID = @stid", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@stid", textBox7.Text);
            sqlCommand.Parameters.AddWithValue("@name", textBox8.Text);
            sqlCommand.Parameters.AddWithValue("@course", textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@marks", textBox6.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BENI1J9G\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from student_table where studentID = @stid", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@stid", textBox7.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-BENI1J9G\\SQLEXPRESS;Initial Catalog=studentDB;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            MessageBox.Show("Connection successful");
            sqlConnection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet2.student_table' table. You can move, or remove it, as needed.
            this.student_tableTableAdapter.Fill(this.studentDBDataSet2.student_table);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
