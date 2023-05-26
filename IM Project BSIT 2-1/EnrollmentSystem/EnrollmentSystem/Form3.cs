using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace EnrollmentSystem
{
    public partial class courseEdit : Form

    {
        MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
        MySqlCommand myCmd = new MySqlCommand();
        MySqlCommandBuilder scb = new MySqlCommandBuilder();

        public static courseEdit instance;
        public TextBox courseId;
        public TextBox courseDesc;
        public courseEdit()
        {
            InitializeComponent();
            instance = this;
            courseId = textBoxCID;
            courseDesc = textBoxCDesc;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void saveBtn_Click(object sender, EventArgs e)
        {
            string descrip = textBoxCDesc.Text;
          
            
            //CourseOffered.instance.dg.SelectedRows[0].Cells[1].Value = update;
            myCon.Open();
            
            CourseOffered.instance.dg.SelectedRows[0].Cells[1].Value = descrip;
            MySqlCommand cmd = new MySqlCommand("update CoursesOffered set c_desc = @DESC where course_Id = @ID", myCon);
            cmd.Parameters.AddWithValue("@DESC", descrip);
            cmd.Parameters.AddWithValue("@ID", textBoxCID.Text);
            cmd.ExecuteNonQuery();
            myCon.Close();


            string title = "Message Alert";
            MessageBox.Show("Insert Successfully!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }
    }
}
