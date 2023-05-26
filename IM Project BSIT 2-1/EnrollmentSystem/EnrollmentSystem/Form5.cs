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
    public partial class tagging : Form
    {
        MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
        MySqlCommand myCmd = new MySqlCommand();
        MySqlDataAdapter adp = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public string id;
        public string f_name;
        public string l_name;

        public tagging()
        {
            InitializeComponent();
            dgTagging.ColumnCount = 4;
            dgTagging.Columns[0].Name = "Student ID";
            dgTagging.Columns[1].Name = "Student Name";
            dgTagging.Columns[2].Name = "Section Description";
            dgTagging.Columns[3].Name = "Course";
            dgTagging.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgTagging.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTagging.MultiSelect = false;

            
            cbStudName.Text = "--Select Student--";
            comboBox2.Text = "--Select Section--";
            comboBox3.Text = "--Select Course ID--";
        }

        public void FillCombo3()
        {
            MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");

            string query = "Select * from enrollment.CoursesOffered";
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader rdr;
            


            try
            {
                myCon.Open();
                rdr = myCmd.ExecuteReader();
                while (rdr.Read())
                {
                    string courseId = rdr.GetString("course_Id");
                    comboBox3.Items.Add(courseId);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        public void FillCombo2()
        {
            MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");

            string query = "Select * from enrollment.Sections";
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader rdr;


            try
            {
                myCon.Open();
                rdr = myCmd.ExecuteReader();
                while (rdr.Read())
                {
                    string secdescrip = rdr.GetString("sec_descrip");
                    comboBox2.Items.Add(secdescrip);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }
        }

        public void FillCombo1()
        {
            MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
            
            string query = "Select * from enrollment.StudentProfile";
            
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            MySqlDataReader rdr;
             

            try
            {
                myCon.Open();
                rdr = myCmd.ExecuteReader();
                while (rdr.Read())
                {
                    f_name = rdr.GetString("f_name");
                    l_name = rdr.GetString("l_name");
                    cbStudName.Items.Add(f_name + " " + l_name);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                
            }
        }

        private void tagging_Load(object sender, EventArgs e)
        {

            FillCombo1();
            FillCombo2();
            FillCombo3();
            retrieve();
        }

        public void tagBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection("server = localhost; user id = root; port = 3306; database = enrollment;password=yuri082502; database = enrollment");
            myCon.Open();
            string fullname = cbStudName.GetItemText(cbStudName.SelectedItem);
            string query = "SELECT * FROM enrollment.StudentProfile where fullname = @FULLNAME";
            
            MySqlCommand myCmd = new MySqlCommand(query, myCon);
            myCmd.Parameters.AddWithValue("@FULLNAME", fullname);
            MySqlDataReader rdr;

            rdr = myCmd.ExecuteReader();
            if (rdr.Read())
            {
                id = rdr.GetString("student_Id");
                
                add(id);
                cbStudName.Items.Remove(cbStudName.SelectedItem);
                cbStudName.Text = "--Select Student--"; 
                
                
                
            }
            else
            {
                MessageBox.Show("No Data for this Student Name " + fullname);
            }
            myCon.Close();
        }

        

        public void add(string id)
        {
            string query = "insert into tagging(studentId, studName, secDesc, course)" +
                "Values(@STUDENTID, @STUDNAME, @SECDESC, @COURSE)";
            myCmd = new MySqlCommand(query, myCon);
            myCmd.Parameters.AddWithValue("@STUDENTID", id);
            myCmd.Parameters.AddWithValue("@STUDNAME", cbStudName.GetItemText(cbStudName.SelectedItem));
            myCmd.Parameters.AddWithValue("@SECDESC", comboBox2.GetItemText(comboBox2.SelectedItem));
            myCmd.Parameters.AddWithValue("@COURSE", comboBox3.GetItemText(comboBox3.SelectedItem));



            try
            {
                
                myCon.Open();

                if (myCmd.ExecuteNonQuery() > 0)
                {
                    string title = "Message Alert";
                  MessageBox.Show("Insert Successfully!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                myCon.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                myCon.Close();
            }
        }

        public void retrieve()
        {
            dgTagging.Rows.Clear();
            string query = "select * from tagging";
            myCmd = new MySqlCommand(query, myCon);
            try
            {
                myCon.Open();
                adp = new MySqlDataAdapter(myCmd);
                adp.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                }
                myCon.Close();

                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                myCon.Close();
            }
        }

        private void populate(string st_id, string stud_name, string section, string course)
        {
            dgTagging.Rows.Add(st_id, stud_name, section, course);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sections f3 = new Sections();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseOffered f2 = new CourseOffered();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudProfile f1 = new StudProfile();
            f1.Show();
            this.Hide();
        }

        private void tagging_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(

            "Do You Want To Exit?",

            "Close Application",

             MessageBoxButtons.YesNo,

             MessageBoxIcon.Question,

             MessageBoxDefaultButton.Button2))

            {

                e.Cancel = true;

            }
        }
    }
}
