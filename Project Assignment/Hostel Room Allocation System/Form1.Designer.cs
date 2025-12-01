namespace HostelRoomAllocation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtRoomNumber;

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAssignRoom;
        private System.Windows.Forms.Button btnCheckAvailability;

        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();

            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnAssignRoom = new System.Windows.Forms.Button();

            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            this.label5 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            //
            // Label5 - Title
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(120, 20);
            this.label5.Text = "Hostel Room Allocation System";

            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Text = "Student Name";

            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(150, 88);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Text = "Department";

            //
            // txtDept
            //
            this.txtDept.Location = new System.Drawing.Point(150, 128);
            this.txtDept.Size = new System.Drawing.Size(200, 23);

            //
            // btnAddStudent
            //
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Location = new System.Drawing.Point(150, 170);
            this.btnAddStudent.Size = new System.Drawing.Size(120, 30);
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 240);
            this.label3.Text = "Student ID";

            //
            // txtStudentID
            //
            this.txtStudentID.Location = new System.Drawing.Point(150, 238);
            this.txtStudentID.Size = new System.Drawing.Size(100, 23);

            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 280);
            this.label4.Text = "Room Number";

            //
            // txtRoomNumber
            //
            this.txtRoomNumber.Location = new System.Drawing.Point(150, 278);
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 23);

            //
            // btnAssignRoom
            //
            this.btnAssignRoom.Text = "Assign Room";
            this.btnAssignRoom.Location = new System.Drawing.Point(150, 320);
            this.btnAssignRoom.Size = new System.Drawing.Size(120, 30);
            this.btnAssignRoom.Click += new System.EventHandler(this.btnAssignRoom_Click);

            //
            // btnCheckAvailability
            //
            this.btnCheckAvailability.Text = "Check Availability";
            this.btnCheckAvailability.Location = new System.Drawing.Point(150, 360);
            this.btnCheckAvailability.Size = new System.Drawing.Size(140, 30);
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);

            //
            // lblResult
            //
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 410);
            this.lblResult.Text = "Result appears here";

            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btnAssignRoom);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.lblResult);

            this.Text = "Hostel Room Allocation System";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
