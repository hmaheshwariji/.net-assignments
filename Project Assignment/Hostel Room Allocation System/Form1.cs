using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RoomAllocationDLL;

namespace HostelRoomAllocation
{
    public partial class Form1 : Form
    {
        RoomAllocator allocator = new RoomAllocator();

        public Form1()
        {
            InitializeComponent();
        }

        // Add student
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "INSERT INTO Students (StudentName, Department) VALUES (@name, @dept)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dept", txtDept.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Student added successfully.");
            }
        }

        // Assign room
        private void btnAssignRoom_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                int studentId = int.Parse(txtStudentID.Text);
                string room = txtRoomNumber.Text;

                string msg = allocator.AssignRoom(studentId, room, con);
                lblResult.Text = msg;
            }
        }

        // Check availability
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                string query = "SELECT IsAllocated FROM Rooms WHERE RoomNumber=@room";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@room", txtRoomNumber.Text);

                object res = cmd.ExecuteScalar();
                if (res == null) { lblResult.Text = "Room does not exist."; return; }

                bool allocated = Convert.ToBoolean(res);

                lblResult.Text = allocated ? "Room NOT available" : "Room Available";
            }
        }
    }
}
