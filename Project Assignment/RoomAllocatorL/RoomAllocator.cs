using Microsoft.Data.SqlClient;

namespace RoomAllocationDLL
{
    public class RoomAllocator
    {
        public string AssignRoom(int studentId, string roomNumber, SqlConnection con)
        {
            string check = "SELECT IsAllocated FROM Rooms WHERE RoomNumber = @room";

            SqlCommand cmd = new SqlCommand(check, con);
            cmd.Parameters.AddWithValue("@room", roomNumber);

            bool allocated = Convert.ToBoolean(cmd.ExecuteScalar());

            if (allocated)
                return "Room already allocated.";

            string update = "UPDATE Rooms SET IsAllocated = 1, AllocatedTo = @sid WHERE RoomNumber = @room";

            SqlCommand cmd2 = new SqlCommand(update, con);
            cmd2.Parameters.AddWithValue("@sid", studentId);
            cmd2.Parameters.AddWithValue("@room", roomNumber);
            cmd2.ExecuteNonQuery();

            return "Room assigned successfully.";
        }
    }
}
